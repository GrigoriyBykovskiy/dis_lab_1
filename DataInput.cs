using System;
using System.Collections.Generic;
using System.Text;

namespace dis_lab_1
{
    public class DataInput
    {
        public string name = "Name";
        public string surname = "Фамилия";
        public string tail;
        public void GetInfo()
        {
            /*Console.WriteLine($"Имя: {name}\n Фамилия: {surname}\n");
            byte[] res = System.Text.Encoding.Default.GetBytes(surname);
            foreach (byte element in res)

            {
                Console.WriteLine("{0} = {1}", element, (char)element);
            }*/
            Console.WriteLine($" Имя: {name}\n Фамилия: {surname}\n Хвост: {tail}\n");
        }
        public void CalculateTail()
        {
            int len_name = name.Length;
            Console.WriteLine("1) The length of '{0}' is {1}", name, len_name);
            int len_surname = surname.Length;
            Console.WriteLine("2) The length of '{0}' is {1}", surname, len_surname);
            if (len_name > len_surname)
            {
                tail = name.Substring(len_surname);
            }
            if (len_name < len_surname)
            {
                tail = surname.Substring(len_name);
            }
            if (len_name == len_surname)
            {
                tail = "";
            }
        }
        public string GetAsciiRepresentation(string str)
        {
            Console.WriteLine($"Исходная строка: {str}\n");
            byte[] res = System.Text.Encoding.Default.GetBytes(str);
            string result = "";
            foreach (byte element in res)
            {
                Console.WriteLine("{0} = {1}", element, (char)element);
                string buf = element.ToString();
                Console.WriteLine($"Буфер {buf}\n");
                result += buf;
                result += " ";
            }
            return result;
        }
        public string GetResult()
        {
            int len_name = name.Length;
            int len_surname = surname.Length;
            int tmp = 0;
            if (len_name > len_surname)
            {
                tmp = len_surname;
            }
            if (len_name < len_surname)
            {
                tmp = len_name;
            }
            if (len_name == len_surname)
            {
                tmp = len_name;
            }
            byte[] name_byte = System.Text.Encoding.Default.GetBytes(name);
            byte[] surname_byte = System.Text.Encoding.Default.GetBytes(surname);
            string result = "";
            for (int i = 0; i < tmp; i++)
            {
                byte buf = (byte)(name_byte[i] & surname_byte[i]);
                string element = buf.ToString();
                result += element;
                result += " ";
            }
            return result;
        }
    }
}
