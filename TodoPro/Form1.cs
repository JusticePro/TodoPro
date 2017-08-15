using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoPro
{
    public partial class Form1 : Form
    {

        List<string> todos = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File (*.txt)|txt";
            DialogResult result = save.ShowDialog();

            if (save.FileName!="")
            {
                File.WriteAllLines(save.FileName + ".txt", todos.ToArray());
            }

        }

        private void addTodo_Click(object sender, EventArgs e)
        {
            Textbox box = new Textbox("Todo?", "Add todo", todos, todoBro);
            box.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCN5sHxEg8f9mAH9593dDDZg");
        }
    }
}
