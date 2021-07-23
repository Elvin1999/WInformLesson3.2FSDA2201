using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInformLesson3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> todos = new List<string>
            {
                "Read Book",
                "Drink Coffee",
                "Write Code",
                "Write more code",
                "Sleep"
            };

            checkedListBox1.Items.AddRange(todos.ToArray());

            comboBox1.DataSource = todos;

          
        }

        private void showDoneBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                sb.Append($"{item as string}\n");
            }

            label1.Text = sb.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem as string;
        }
    }
}
