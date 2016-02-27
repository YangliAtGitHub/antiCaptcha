using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using CaptchaRecogizeDemo.Utility;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace CaptchaRecogizeDemo
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> dic = new Dictionary<string, string>();
        private string urlCurrent;

        private string imgOriginal;
        private string imgBged;
        private string imgNoised;
        private string imgBinaried;
        private string imgGreied;
        private int graytype = 2;
        private Image nullImg = Image.FromFile(Config.ResourceDir + "img\\null.jpg");
        private int noiseThreshold = 1;
        private int minWidth = 8;
        private bool isFourChars = false;

        private void DetailForm_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Config.ResourceDir, "imgurl.yaml");
            FileInfo fi = new FileInfo(path);

            using (StreamReader sr = fi.OpenText())
            {
                var deserializer = new Deserializer(namingConvention: new CamelCaseNamingConvention());
                dic = deserializer.Deserialize<Dictionary<string, string>>(sr);
            }

            this.listBox1.Items.Clear();
            foreach (string s in dic.Keys)
            {
                if (urlCurrent == null)
                {
                    urlCurrent = dic[s];
                }
                this.listBox1.Items.Add(s);
            }
            this.listBox1.SelectedIndex = 0;
            button2_Click(null, null);
        }

        /// <summary>
        /// 三种方式下灰度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gray_Click(object sender, EventArgs e)
        {
            Image img = pborigin.Image;
            Image img_grey = (Image)img.Clone();
            imgOriginal = Image2Num((Bitmap)img_grey);

            //灰度化处理       
            //img_gray = ccccccmd.ImageHelper.Gray(img_gray, ccccccmd.ImageHelper.AlgorithmsType.AverageValue);//平均
            //img_gray = ccccccmd.ImageHelper.Gray(img_gray, ccccccmd.ImageHelper.AlgorithmsType.MaxValue );//最大值
            //img_gray = ccccccmd.ImageHelper.Gray(img_gray, ccccccmd.ImageHelper.AlgorithmsType.WeightAverage);//加权
            graytype = 2;
            if (rb_max.Checked)
            {
                graytype = 1;
            }
            if (rb_quanzhong.Checked)
            {
                graytype = 3;
            }
            img_grey = ImageProcess.Gray((Bitmap)img_grey, graytype);
            imgGreied = Image2Num((Bitmap)img_grey);
            pb_grey.Image = img_grey;
        }

        /// <summary>
        /// 图片转换成像素数值
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public string Image2Num(Bitmap img)
        {
            StringBuilder sb = new StringBuilder();
            string imgPixel = "";
            int height = img.Height;
            int width = img.Width;
            BitmapData bdata = img.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytelength = width * height * 4;
            byte[] bytes = new byte[bytelength];
            Marshal.Copy(bdata.Scan0, bytes, 0, bytelength);
            int row = 1;
            for (int i = 0; i < bytelength; i += 4)
            {
                imgPixel = bytes[i] + "," + bytes[i + 1] + "," + bytes[i + 2];
                if (imgPixel.Length < 11)
                {
                    for (int j = 0; j < 11 - imgPixel.Length; j++)
                    {
                        imgPixel += " ";
                    }
                }
                imgPixel += "\t";
                sb.Append(imgPixel);
                if (row % width == 0)
                {
                    sb.Append("\r\n");
                }
                row++;
            }
            img.UnlockBits(bdata);
            return sb.ToString();
        }

        /// <summary>
        /// 将数据写入文件
        /// </summary>
        /// <param name="data"></param>
        /// <param name="path"></param>
        public void WriteToFile(string data, string path)
        {
            File.WriteAllText(path, data);
        }

        /// <summary>
        /// 去背景
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_bg_Click(object sender, EventArgs e)
        {
            Image img_noise = (Image)pb_grey.Image.Clone();

            //得到灰度图像前景色临界值
            int v = ImageProcess.ComputeThresholdValue((Bitmap)img_noise);
            Image img_bg = ImageProcess.RemoveBg((Bitmap)img_noise, v);
            imgBged = Image2Num((Bitmap)img_bg);
            pb_bg.Image = img_bg;
        }

        /// <summary>
        /// 去噪点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_noise_Click(object sender, EventArgs e)
        {
            Image img_noise = ImageProcess.RemoveNoise((Bitmap)pb_bg.Image.Clone(), noiseThreshold);
            imgNoised = Image2Num((Bitmap)img_noise);
            pb_noise.Image = img_noise;
        }

        /// <summary>
        /// 二值化处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_binary_Click(object sender, EventArgs e)
        {
            //去噪处理后的图片
            Image imgBinary = (Image)pb_noise.Image.Clone();
            imgBinary = ImageProcess.Binary((Bitmap)imgBinary);
            imgBinaried = Image2Num((Bitmap)imgBinary);
            pb_noise_binary.Image = imgBinary;
        }

        private List<Bitmap> cutResult = new List<Bitmap>(4);
        //字模存储路径
        private string zimoPath = "";
        //字模数据
        private string[] zimoData;

        private void btn_cutImage_Click(object sender, EventArgs e)
        {
            Image img_cut = (Image)pb_noise_binary.Image.Clone();
            List<Bitmap> list = ImageProcess.CutImage(img_cut, 20, 30, isFourChars, minWidth);
            cutResult = list;

            pb1.Image = list[0];
            if (list.Count >= 2)
            {
                pb2.Image = list[1];
            }
            else
            {
                pb2.Image = nullImg;
            }
            if (list.Count >= 3)
            {
                pb3.Image = list[2];
            }
            else
            {
                pb3.Image = nullImg;
            }
            if (list.Count >= 4)
            {
                pb4.Image = list[3];
            }
            else
            {
                pb4.Image = nullImg;
            }

            if (list.Count >= 5)
            {
                pb5.Image = list[4];
            }
            else
            {
                pb5.Image = nullImg;
            }
            if (list.Count >= 6)
            {
                pb6.Image = list[5];
            }
            else
            {
                pb6.Image = nullImg;
            }

            if (list.Count >= 7)
            {
                pb7.Image = list[6];
            }
            else
            {
                pb7.Image = nullImg;
            }

            if (list.Count >= 8)
            {
                pb8.Image = list[7];
            }
            else
            {
                pb8.Image = nullImg;
            }
        }

        /// <summary>
        /// 字模学习入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CodeStudy_Click(object sender, EventArgs e)
        {
            if (cutResult != null)
            {
                string[] zimos = File.ReadAllLines(zimoPath);
                string zimo = string.Empty;
                StringBuilder sb = new StringBuilder();
                string[] stuCode = new string[] { txt1.Text.Trim(), txt2.Text.Trim(), txt3.Text.Trim(), txt4.Text.Trim(), txt5.Text.Trim(), txt6.Text.Trim(), txt7.Text.Trim(), txt8.Text.Trim() };
                for (int i = 0; i < cutResult.Count; i++)
                {
                    if (!string.IsNullOrEmpty(stuCode[i]))
                    {
                        ImageProcess.WriteZimo(cutResult[i], zimoPath, stuCode[i]);
                    }
                }
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
                txt6.Text = "";
                txt7.Text = "";
                txt8.Text = "";
            }
            else
            {
                MessageBox.Show("验证码分割过程错误！");
            }
        }

        /// <summary>
        /// 识别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_recognize_Click(object sender, EventArgs e)
        {
            Image img2 = (Image)pborigin.Image.Clone();
            string sb = ImageProcess.GetYZMCode(img2, zimoPath, noiseThreshold, 20, 30, graytype, isFourChars, minWidth);
            char[] cs = sb.ToCharArray();
            for (int i = 0; i < 8; i++)
            {
                TextBox tb = this.Controls.Find("txt" + (i + 1), true).FirstOrDefault() as TextBox;
                if (cs.Length > i)
                {
                    tb.Text = cs[i].ToString();
                }
                else
                {
                    tb.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ZimoList form = new ZimoList(zimoPath);
            form.Show();
        }
        /// <summary>
        /// 显示个步骤处理结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Result1_Click(object sender, EventArgs e)
        {
            Process1 form = new Process1(imgOriginal, imgGreied);
            form.Text = "灰度处理前后对比";
            form.Show();
        }

        private void btn_Result2_Click(object sender, EventArgs e)
        {
            Process2 form = new Process2(imgBged, imgGreied);
            form.Text = "背景处理前后对比";
            form.Show();
        }

        private void btn_Result3_Click(object sender, EventArgs e)
        {
            Process3 form = new Process3(imgBged, imgNoised);
            form.Text = "噪点处理前后对比";
            form.Show();
        }

        private void btn_Result4_Click(object sender, EventArgs e)
        {
            Process4 form = new Process4(imgNoised, imgBinaried);
            form.Text = "二值化处理前后对比";
            form.Show();
        }

        private void txtNoise_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNoise.Text.Trim()))
            {
                int.TryParse(txtNoise.Text.Trim(), out noiseThreshold);
            }
        }

        private void txtMinWidth_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMinWidth.Text.Trim()))
            {
                int.TryParse(txtMinWidth.Text.Trim(), out minWidth);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isFourChars = checkBox1.Checked;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb.SelectedItem != null)
            {
                string picurl = dic[lb.SelectedItem.ToString()];
                urlCurrent = picurl;
                Stream ms = WebUtils.DownloadStreamAsync(picurl);
                pborigin.Image = Image.FromStream(ms);


                System.Uri u = new Uri(picurl);
                string name = u.DnsSafeHost;

                string zimoPathTemp = Path.Combine(Config.ResourceDir, "zimo", name + ".zimo");
                if (!File.Exists(zimoPathTemp))
                {
                    string zimoPathDefault = Path.Combine(Config.ResourceDir, "zimo", "default.zimo");
                    File.Copy(zimoPathDefault, zimoPathTemp);
                }
                zimoPath = zimoPathTemp;
            }
            else
            {
                MessageBox.Show("请选择网站");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string picurl = dic[this.listBox1.SelectedItem.ToString()];
            urlCurrent = picurl;
            Stream ms = WebUtils.DownloadStreamAsync(picurl);
            pborigin.Image = Image.FromStream(ms);
            btn_gray_Click(null, null);
            btn_bg_Click(null, null);
            btn_noise_Click(null, null);
            btn_binary_Click(null, null);
            btn_cutImage_Click(null, null);
        }
    }
}
