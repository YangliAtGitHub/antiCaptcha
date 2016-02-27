using System.Windows.Forms.VisualStyles;

namespace CaptchaRecogizeDemo
{
    partial class DetailForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_bg = new System.Windows.Forms.Button();
            this.btn_binary = new System.Windows.Forms.Button();
            this.btn_cutImage = new System.Windows.Forms.Button();
            this.btn_CodeStudy = new System.Windows.Forms.Button();
            this.lbl_recoResult = new System.Windows.Forms.Label();
            this.btn_recognize = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_showZimo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoise = new System.Windows.Forms.TextBox();
            this.txtMinWidth = new System.Windows.Forms.TextBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.rb_quanzhong = new System.Windows.Forms.RadioButton();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.rb_pingjun = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.rb_max = new System.Windows.Forms.RadioButton();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btn_noise = new System.Windows.Forms.Button();
            this.pborigin = new System.Windows.Forms.PictureBox();
            this.pb_grey = new System.Windows.Forms.PictureBox();
            this.btn_gray = new System.Windows.Forms.Button();
            this.pb_bg = new System.Windows.Forms.PictureBox();
            this.pb_noise = new System.Windows.Forms.PictureBox();
            this.pb_noise_binary = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pborigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_noise_binary)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bg
            // 
            this.btn_bg.BackColor = System.Drawing.Color.White;
            this.btn_bg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bg.Location = new System.Drawing.Point(584, 37);
            this.btn_bg.Name = "btn_bg";
            this.btn_bg.Size = new System.Drawing.Size(75, 36);
            this.btn_bg.TabIndex = 8;
            this.btn_bg.Text = "去背景";
            this.btn_bg.UseVisualStyleBackColor = false;
            this.btn_bg.Click += new System.EventHandler(this.btn_bg_Click);
            // 
            // btn_binary
            // 
            this.btn_binary.BackColor = System.Drawing.Color.White;
            this.btn_binary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_binary.Location = new System.Drawing.Point(584, 180);
            this.btn_binary.Name = "btn_binary";
            this.btn_binary.Size = new System.Drawing.Size(75, 35);
            this.btn_binary.TabIndex = 10;
            this.btn_binary.Text = "二值化";
            this.btn_binary.UseVisualStyleBackColor = false;
            this.btn_binary.Click += new System.EventHandler(this.btn_binary_Click);
            // 
            // btn_cutImage
            // 
            this.btn_cutImage.BackColor = System.Drawing.Color.White;
            this.btn_cutImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cutImage.Location = new System.Drawing.Point(295, 294);
            this.btn_cutImage.Name = "btn_cutImage";
            this.btn_cutImage.Size = new System.Drawing.Size(75, 39);
            this.btn_cutImage.TabIndex = 17;
            this.btn_cutImage.Text = "图片分割";
            this.btn_cutImage.UseVisualStyleBackColor = false;
            this.btn_cutImage.Click += new System.EventHandler(this.btn_cutImage_Click);
            // 
            // btn_CodeStudy
            // 
            this.btn_CodeStudy.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CodeStudy.Location = new System.Drawing.Point(354, 489);
            this.btn_CodeStudy.Name = "btn_CodeStudy";
            this.btn_CodeStudy.Size = new System.Drawing.Size(305, 55);
            this.btn_CodeStudy.TabIndex = 21;
            this.btn_CodeStudy.Text = "字模学习入库(正确可不输)";
            this.btn_CodeStudy.UseVisualStyleBackColor = true;
            this.btn_CodeStudy.Click += new System.EventHandler(this.btn_CodeStudy_Click);
            // 
            // lbl_recoResult
            // 
            this.lbl_recoResult.AutoSize = true;
            this.lbl_recoResult.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_recoResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_recoResult.Location = new System.Drawing.Point(179, 417);
            this.lbl_recoResult.Name = "lbl_recoResult";
            this.lbl_recoResult.Size = new System.Drawing.Size(89, 19);
            this.lbl_recoResult.TabIndex = 22;
            this.lbl_recoResult.Text = "识别结果";
            // 
            // btn_recognize
            // 
            this.btn_recognize.Location = new System.Drawing.Point(164, 61);
            this.btn_recognize.Name = "btn_recognize";
            this.btn_recognize.Size = new System.Drawing.Size(75, 35);
            this.btn_recognize.TabIndex = 23;
            this.btn_recognize.Text = "识别";
            this.btn_recognize.UseVisualStyleBackColor = true;
            this.btn_recognize.Click += new System.EventHandler(this.btn_recognize_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Location = new System.Drawing.Point(498, 320);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 16);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "4个字符";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_showZimo
            // 
            this.btn_showZimo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_showZimo.Enabled = false;
            this.btn_showZimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showZimo.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_showZimo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_showZimo.Location = new System.Drawing.Point(796, 512);
            this.btn_showZimo.Name = "btn_showZimo";
            this.btn_showZimo.Size = new System.Drawing.Size(66, 32);
            this.btn_showZimo.TabIndex = 26;
            this.btn_showZimo.Text = "字模操作";
            this.btn_showZimo.UseVisualStyleBackColor = false;
            this.btn_showZimo.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(390, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "最小宽度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(275, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "噪点阈值";
            // 
            // txtNoise
            // 
            this.txtNoise.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNoise.ForeColor = System.Drawing.Color.Red;
            this.txtNoise.Location = new System.Drawing.Point(335, 217);
            this.txtNoise.Name = "txtNoise";
            this.txtNoise.Size = new System.Drawing.Size(35, 21);
            this.txtNoise.TabIndex = 30;
            this.txtNoise.Text = "1";
            this.txtNoise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoise.TextChanged += new System.EventHandler(this.txtNoise_TextChanged);
            // 
            // txtMinWidth
            // 
            this.txtMinWidth.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMinWidth.ForeColor = System.Drawing.Color.Red;
            this.txtMinWidth.Location = new System.Drawing.Point(449, 312);
            this.txtMinWidth.Name = "txtMinWidth";
            this.txtMinWidth.Size = new System.Drawing.Size(35, 21);
            this.txtMinWidth.TabIndex = 29;
            this.txtMinWidth.Text = "8";
            this.txtMinWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinWidth.TextChanged += new System.EventHandler(this.txtMinWidth_TextChanged);
            // 
            // pb3
            // 
            this.pb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb3.Location = new System.Drawing.Point(420, 365);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(55, 37);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb3.TabIndex = 15;
            this.pb3.TabStop = false;
            // 
            // rb_quanzhong
            // 
            this.rb_quanzhong.AutoSize = true;
            this.rb_quanzhong.Location = new System.Drawing.Point(295, 125);
            this.rb_quanzhong.Name = "rb_quanzhong";
            this.rb_quanzhong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_quanzhong.Size = new System.Drawing.Size(71, 16);
            this.rb_quanzhong.TabIndex = 28;
            this.rb_quanzhong.Text = "加权平均";
            this.rb_quanzhong.UseVisualStyleBackColor = true;
            // 
            // pb4
            // 
            this.pb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb4.Location = new System.Drawing.Point(487, 365);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(50, 37);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb4.TabIndex = 16;
            this.pb4.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(741, 450);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(24, 21);
            this.textBox8.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(681, 449);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(24, 21);
            this.textBox7.TabIndex = 20;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(740, 415);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(24, 21);
            this.txt8.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(617, 450);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(24, 21);
            this.textBox6.TabIndex = 20;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(617, 415);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(24, 21);
            this.txt6.TabIndex = 20;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(681, 415);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(24, 21);
            this.txt7.TabIndex = 20;
            // 
            // pb2
            // 
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb2.Location = new System.Drawing.Point(358, 365);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(54, 37);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb2.TabIndex = 14;
            this.pb2.TabStop = false;
            // 
            // rb_pingjun
            // 
            this.rb_pingjun.AutoSize = true;
            this.rb_pingjun.Checked = true;
            this.rb_pingjun.Location = new System.Drawing.Point(295, 81);
            this.rb_pingjun.Name = "rb_pingjun";
            this.rb_pingjun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_pingjun.Size = new System.Drawing.Size(71, 16);
            this.rb_pingjun.TabIndex = 28;
            this.rb_pingjun.TabStop = true;
            this.rb_pingjun.Text = "平均值法";
            this.rb_pingjun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb_pingjun.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(561, 450);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(24, 21);
            this.textBox5.TabIndex = 20;
            // 
            // rb_max
            // 
            this.rb_max.AutoSize = true;
            this.rb_max.Location = new System.Drawing.Point(295, 103);
            this.rb_max.Name = "rb_max";
            this.rb_max.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_max.Size = new System.Drawing.Size(71, 16);
            this.rb_max.TabIndex = 28;
            this.rb_max.Text = "最大值法";
            this.rb_max.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_max.UseVisualStyleBackColor = true;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(560, 415);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(24, 21);
            this.txt5.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(498, 449);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(24, 21);
            this.textBox4.TabIndex = 20;
            // 
            // pb5
            // 
            this.pb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb5.Location = new System.Drawing.Point(543, 365);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(55, 37);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb5.TabIndex = 13;
            this.pb5.TabStop = false;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(497, 414);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(24, 21);
            this.txt4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(435, 449);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(24, 21);
            this.textBox3.TabIndex = 20;
            // 
            // pb8
            // 
            this.pb8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb8.Location = new System.Drawing.Point(731, 365);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(55, 37);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb8.TabIndex = 13;
            this.pb8.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(370, 449);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 21);
            this.textBox2.TabIndex = 20;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(434, 414);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(24, 21);
            this.txt3.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 450);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 21);
            this.textBox1.TabIndex = 20;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(315, 415);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(24, 21);
            this.txt1.TabIndex = 20;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(370, 415);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(24, 21);
            this.txt2.TabIndex = 20;
            // 
            // pb7
            // 
            this.pb7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb7.Location = new System.Drawing.Point(670, 365);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(55, 37);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb7.TabIndex = 13;
            this.pb7.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb6.Location = new System.Drawing.Point(604, 365);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(55, 37);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb6.TabIndex = 13;
            this.pb6.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Location = new System.Drawing.Point(295, 365);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(55, 37);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb1.TabIndex = 13;
            this.pb1.TabStop = false;
            // 
            // btn_noise
            // 
            this.btn_noise.BackColor = System.Drawing.Color.White;
            this.btn_noise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_noise.Location = new System.Drawing.Point(295, 180);
            this.btn_noise.Name = "btn_noise";
            this.btn_noise.Size = new System.Drawing.Size(75, 35);
            this.btn_noise.TabIndex = 22;
            this.btn_noise.Text = "去噪点";
            this.btn_noise.UseVisualStyleBackColor = false;
            this.btn_noise.Click += new System.EventHandler(this.btn_noise_Click);
            // 
            // pborigin
            // 
            this.pborigin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pborigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pborigin.Location = new System.Drawing.Point(12, 185);
            this.pborigin.Name = "pborigin";
            this.pborigin.Size = new System.Drawing.Size(164, 85);
            this.pborigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pborigin.TabIndex = 20;
            this.pborigin.TabStop = false;
            // 
            // pb_grey
            // 
            this.pb_grey.BackColor = System.Drawing.SystemColors.Control;
            this.pb_grey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_grey.Location = new System.Drawing.Point(392, 38);
            this.pb_grey.Name = "pb_grey";
            this.pb_grey.Size = new System.Drawing.Size(172, 100);
            this.pb_grey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_grey.TabIndex = 2;
            this.pb_grey.TabStop = false;
            // 
            // btn_gray
            // 
            this.btn_gray.AutoSize = true;
            this.btn_gray.BackColor = System.Drawing.Color.White;
            this.btn_gray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gray.FlatAppearance.BorderSize = 0;
            this.btn_gray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_gray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_gray.Location = new System.Drawing.Point(295, 38);
            this.btn_gray.Margin = new System.Windows.Forms.Padding(0);
            this.btn_gray.Name = "btn_gray";
            this.btn_gray.Size = new System.Drawing.Size(75, 38);
            this.btn_gray.TabIndex = 1;
            this.btn_gray.Text = "灰度";
            this.btn_gray.UseVisualStyleBackColor = false;
            this.btn_gray.Click += new System.EventHandler(this.btn_gray_Click);
            // 
            // pb_bg
            // 
            this.pb_bg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_bg.Location = new System.Drawing.Point(665, 37);
            this.pb_bg.Name = "pb_bg";
            this.pb_bg.Size = new System.Drawing.Size(179, 101);
            this.pb_bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_bg.TabIndex = 6;
            this.pb_bg.TabStop = false;
            // 
            // pb_noise
            // 
            this.pb_noise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_noise.Location = new System.Drawing.Point(392, 178);
            this.pb_noise.Name = "pb_noise";
            this.pb_noise.Size = new System.Drawing.Size(172, 92);
            this.pb_noise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_noise.TabIndex = 9;
            this.pb_noise.TabStop = false;
            // 
            // pb_noise_binary
            // 
            this.pb_noise_binary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_noise_binary.Location = new System.Drawing.Point(665, 180);
            this.pb_noise_binary.Name = "pb_noise_binary";
            this.pb_noise_binary.Size = new System.Drawing.Size(179, 94);
            this.pb_noise_binary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_noise_binary.TabIndex = 12;
            this.pb_noise_binary.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.Blue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 148);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "更换";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 556);
            this.Controls.Add(this.btn_showZimo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_recoResult);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.btn_CodeStudy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pb_noise_binary);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.btn_binary);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.pb_noise);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.pb_bg);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.btn_gray);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.btn_bg);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtNoise);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.pb_grey);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btn_recognize);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pborigin);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txtMinWidth);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_noise);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.btn_cutImage);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rb_quanzhong);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.rb_max);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rb_pingjun);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DetailForm";
            this.Text = "细节分析";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pborigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_noise_binary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gray;
        private System.Windows.Forms.PictureBox pb_grey;
        private System.Windows.Forms.PictureBox pb_bg;
        private System.Windows.Forms.Button btn_bg;
        private System.Windows.Forms.PictureBox pb_noise;
        private System.Windows.Forms.Button btn_binary;
        private System.Windows.Forms.PictureBox pb_noise_binary;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btn_cutImage;
        private System.Windows.Forms.Button btn_CodeStudy;
        private System.Windows.Forms.Label lbl_recoResult;
        private System.Windows.Forms.Button btn_recognize;
        private System.Windows.Forms.PictureBox pborigin;
        private System.Windows.Forms.Button btn_showZimo;
        private System.Windows.Forms.Button btn_noise;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.RadioButton rb_quanzhong;
        private System.Windows.Forms.RadioButton rb_pingjun;
        private System.Windows.Forms.RadioButton rb_max;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoise;
        private System.Windows.Forms.TextBox txtMinWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

