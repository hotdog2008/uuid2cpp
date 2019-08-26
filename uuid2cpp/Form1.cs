using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uuid2cpp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Buttontrans_Click(object sender, EventArgs e)
        {
            string source = textBoxSource.Text.Trim();
            if (source == "") return;

            try
            {
                Guid uuid = Guid.Parse(source);
                byte[] buf = uuid.ToByteArray();

                string outstr = "";
                for (int i = 0; i < buf.Length; i++)
                {
                    outstr += $"0x{buf[i]:x2}";
                    if (i != buf.Length - 1) outstr += ",";
                }
                textBoxTarget.Text = outstr;
            }
            catch (Exception err)
            {
                textBoxTarget.Text = err.Message;
            }
        }
    }
}
