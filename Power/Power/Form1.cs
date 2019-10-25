using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 640;
        }
        int i = 0,x=0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i%2 == 0)
            {
                bool pow = System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline;
                if (pow == true)
                {
                    label2.Text = "DC";
                    label2.BackColor = Color.Red; 
                }
                    
                else
                {
                    label2.Text = "AC";
                    label2.BackColor = Color.GreenYellow;
                }
            }
            else
            {
                bool pow = System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline;
                if (pow == true)
                {
                    label2.Text = "DC";
                    label2.BackColor = Color.Red;
                }
                
                else
                {
                    label2.Text = "AC";
                    label2.BackColor = Color.GreenYellow;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    this.WindowState = FormWindowState.Minimized;

                    break;

                case MouseButtons.Right:
                    Close();
                    break;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                PowerStatus power = SystemInformation.PowerStatus;
                int check = (int)(power.BatteryLifePercent * 100);
                label1.Text = Convert.ToString(check) + "%";

                if (check == 100)
                    label1.Text = "Full";
                else if (check >= 80)
                    label1.BackColor = Color.Blue;
                else if (check >= 50)
                    label1.BackColor = Color.Yellow;
                else if (check >= 30)
                    label1.BackColor = Color.Orange;
                else if (check >= 20)
                    label1.BackColor = Color.OrangeRed;
                else
                    label1.BackColor = Color.Red;
            }
            else
            {
                PowerStatus power = SystemInformation.PowerStatus;
                int check = (int)(power.BatteryLifePercent * 100);
                label1.Text = Convert.ToString(check) + "%";

                if (check == 100)
                    label1.Text = "Full";
                else if (check >= 80)
                    label1.BackColor = Color.Blue;
                else if (check >= 50)
                    label1.BackColor = Color.Yellow;
                else if (check >= 30)
                    label1.BackColor = Color.Orange;
                else if (check >= 20)
                    label1.BackColor = Color.OrangeRed;
                else
                    label1.BackColor = Color.Red;
            }
        }
    }
}
