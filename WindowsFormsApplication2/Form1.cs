using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread Tread1 = new Thread(UpdateLabel);
            Tread1.Start(lbl1);
            Thread Tread2 = new Thread(UpdateLabel);
            Tread2.Start(lbl2);
            Thread Tread3 = new Thread(UpdateLabel);
            Tread3.Start(lbl3);

        }

         void UpdateLabel(object n)
        {
            Label statusLabel = n as Label;
            for (int i = 1; i <= 1000; i++)
            {
                int count1 = 0;
                int count2 = 0;
                for (int k = 2; k < i - 1; k++)
                {
                    int rem = i % k;
                    if (rem == 0)
                    {
                        count1++;
                    }
                    else
                    {
                        count2++;
                    }
                }
                if (count1 == 0)
                {
                    BeginInvoke((Action)(() => statusLabel.Text = i.ToString()));                
                    Thread.Sleep(500);
                }

            }

    
        }
    }
}
