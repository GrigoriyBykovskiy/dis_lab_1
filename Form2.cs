using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dis_lab_1
{
    public partial class Form2 : Form
    {
        public Form2(Form1 MainApp)
        {
            InitializeComponent();
            textBox_log.Text = MainApp.app_log.Read();
            // need to add exception for long data
        }
    }
}
