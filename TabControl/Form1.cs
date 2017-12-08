using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings set = Properties.Settings.Default;
            if(set.風格 ==1)
            { RdbS1.Checked = true; }//Windows
            else if (set.風格==2)
            { RdbS2.Checked = true; }//Linux
            else
            { RdbS3.Checked = true; }//Mac

            if(set.工具列==1)
            { RdbT1.Checked = true; }//無
            else if(set.工具列==2)
            { RdbT2.Checked = true; }//小圖示
            else
            { RdbT3.Checked = true; }//大圖示
            if (set.字體 == 1)
            { RdbF1.Checked = true; }//標楷體
            else if (set.字體 == 2)
            { RdbF2.Checked = true; }//新細明體
            else
            {
                RdbF3.Checked = true;
                TxtSize.Text = set.字體大小;
                ChkF1.Checked = set.字型1;
                ChkF2.Checked = set.字型2;
                ChkA1.Checked = set.自動化1;
                ChkA2.Checked = set.自動化2;
                ChkA3.Checked = set.自動化3;
            }
            if(set.結束==1)
            { ChkE1.Checked = true; }
            else
            { ChkE2.Checked = true; }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings set = Properties.Settings.Default;
            if (RdbS1.Checked == true)
                set.風格 = 1;
            else if (RdbS2.Checked == true)
                set.風格 = 2;
            else
                set.風格 = 3;
            if (RdbT1.Checked == true)
                set.工具列 = 1;
            else if (RdbT2.Checked == true)
                set.工具列 = 2;
            else
                set.工具列 = 3;
            if (RdbF1.Checked == true)
                set.字體 = 1;
            else if (RdbF2.Checked == true)
                set.字體 = 2;
            else
                set.字體 = 3;
            set.字體大小 = TxtSize.Text;
            set.字型1 = ChkF1.Checked;
            set.字型2 = ChkF2.Checked;
            set.自動化1 = ChkA1.Checked;
            set.自動化2 = ChkA2.Checked;
            set.自動化3 = ChkA3.Checked;
            if (ChkE1.Checked == true)
                set.結束 = 1;
            else
                set.結束 = 2;
            set.Save();
            Application.Exit();

        }
    }
}
