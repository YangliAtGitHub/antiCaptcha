using System;
using System.Windows.Forms;

namespace CaptchaRecogizeDemo
{
    public partial class Process1 : Form
    {
        public Process1()
        {
            InitializeComponent();
        }

        private string Original;
        private string Grey;
        public Process1(string original,string grey)
        {
            InitializeComponent();
            Original = original;
            this.Grey = grey;
            this.Text = "灰度处理前后对比";
          
        }

        private void ProcessResults_Load(object sender, EventArgs e)
        {
            listBox_Original.Items.AddRange(Original.Split(new string[] { "\r\n" }, StringSplitOptions.None));     
            listBox_Grey.Items.AddRange(Grey.Split(new string[] { "\r\n" },StringSplitOptions.None ));
        }
    }
}
