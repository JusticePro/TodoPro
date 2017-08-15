using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoPro
{
    public partial class Textbox : Form
    {
        private List<string> array;
        private RichTextBox todo;

        public Textbox(string message, string title, List<string> list, RichTextBox todoBro)
        {
            InitializeComponent();
            Text = title + " - TodoPro";
            Message.Text = message;
            array = list;
            this.todo = todoBro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            todo.Text = todo.Text + "(" + textBox1.Text + ") Completed?" + "\n";
            array.Add("(" + textBox1.Text + ") Completed?");
            Close();
        }
        
    }
}
