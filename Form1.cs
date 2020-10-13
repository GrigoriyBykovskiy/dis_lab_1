using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace dis_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // init global objects
        public SimpleLog app_log = new SimpleLog();
        public DataInput data = new DataInput();
        // event listener for init log
        private void Form1_Load(object sender, EventArgs e)
        {
            app_log.Write("[INFO]" , "PROGRAM START");
            data.GetInfo();
        }
        // event listener for show log
        private void button_get_log_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }
        // event listener for placeholders
        private void textBox_name_GotFocus(object sender, EventArgs e)
        {
            if (textBox_name.Text == "введите имя")
            {
                textBox_name.Text = "";
                // ForeColor = SystemColors.GrayText;
            }
        }
        private void textBox_name_LostFocus(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                textBox_name.Text = "введите имя";
                //ForeColor = SystemColors.ControlText;
            }
        }
        
        private void textBox_surname_GotFocus(object sender, EventArgs e)
        {
            if (textBox_surname.Text == "введите фамилию")
            {
                textBox_surname.Text = "";
                //ForeColor = SystemColors.ControlText;
            }
        }
        private void textBox_surname_LostFocus(object sender, EventArgs e)
        {
            if (textBox_surname.Text == "")
            {
                textBox_surname.Text = "введите фамилию";
                //ForeColor = SystemColors.ControlText;
            }
        }
        // end event listener for placeholder
        private void button_get_result_Click(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Z][a-zA-Z]*$")).IsMatch(textBox_name.Text)&&
                (new Regex(@"^[A-Z][a-zA-Z]*$")).IsMatch(textBox_surname.Text))
            {
                data.name = textBox_name.Text;
                data.surname = textBox_surname.Text;
                data.CalculateTail();
                Form3 newForm = new Form3(this);
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Анта бака!\nСледи за тем, что вводишь в поля формы!\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                app_log.Write("[WARNING]", "BAD USER INPUT");
            }
        }
    }
}