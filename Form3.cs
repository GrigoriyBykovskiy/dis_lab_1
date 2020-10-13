using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dis_lab_1
{
    public partial class Form3 : Form
    {
        public Form3(Form1 MainApp)
        {
            try
            {
                InitializeComponent();
                MainApp.data.GetInfo();
                string ascii_name = MainApp.data.GetAsciiRepresentation(MainApp.data.name);
                textBox_name.Text = ascii_name;
                string ascii_surname = MainApp.data.GetAsciiRepresentation(MainApp.data.surname);
                textBox_surname.Text = ascii_surname;
                if (MainApp.data.tail == "")
                {
                    textBox_tail.Text = "пусто";
                }
                else
                {
                    string ascii_tail = MainApp.data.GetAsciiRepresentation(MainApp.data.tail);
                    textBox_tail.Text = ascii_tail;
                }
                string result = MainApp.data.GetResult();
                textBox_result.Text = result;
                Console.WriteLine($"Результат {result}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Анта бака!\n Что-то пошло не так!\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainApp.app_log.Write(ex.Message, ex.StackTrace);
            }
        }
    }
}
