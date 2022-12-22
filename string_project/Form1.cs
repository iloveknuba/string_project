using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace string_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            Tstring st;
            st = new Tstring();
            try
            {

                s = Convert.ToString(textBox1.Text);
                label3.Text = Convert.ToString(st.ST);
                Tstring.Str(Convert.ToString(st.ST), label2);
                Tstring.Str(s, label5);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        class Tstring
        {
            StringBuilder s;
            public Tstring()
            {
                s = new StringBuilder();
                s = s.Append("okolytsya"); // case 1: string made in class
            }
            public StringBuilder ST
            {
                get
                {
                    return s;
                }
            }

            public static void Str(string s1, Label l) // case 2: string made by user
            {

                int m = 0;
                int n = 0;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == s1[0])
                        m++;
                }
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] == s1.Last())
                        n++;
                }
                if (m > n)
                    l.Text = "First letter happens more often then last";
                else if (m == n)
                    l.Text = "First and last letters happens equal";
                else
                    l.Text = "Last letter happens more often then first";
            }
        }
    }
}
