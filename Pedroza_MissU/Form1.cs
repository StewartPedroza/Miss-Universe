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

namespace Pedroza_MissU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (top10.SelectedItem != null)
            {
                string selectedItem = top10.SelectedItem.ToString();
                top10.Items.Remove(selectedItem);
                top3.Items.Add(selectedItem);

                if (top3.Items.Count == 3)
                {
                    MessageBox.Show("Top 3 is full.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            if (top3.Items.Count == 3)
            {
                top10.Enabled = false;
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (top3.SelectedItem != null)
            {

                string selectedItem = top3.SelectedItem.ToString();
                top3.Items.Remove(selectedItem);
                MissUniverse.Items.Add(selectedItem);

                MessageBox.Show(selectedItem + " is the Miss Universe!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (MissUniverse.Items.Count == 1)
            {
                top3.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (top20.SelectedItem != null)
            {

                string selectedItem = top20.SelectedItem.ToString();

                if (top10.Items.Count == 10)
                {
                    MessageBox.Show("Top 10 is full.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                top20.Items.Remove(selectedItem);
                top10.Items.Add(selectedItem);
            }

            if (top10.Items.Count == 10)
            {
                top20.Enabled = false;
            }


        }

        private void upload_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\johnp\OneDrive\Desktop\top20.txt"))
                {
                    string line;

                while ((line = sr.ReadLine()) != null)
                {
                    top20.Items.Add(line);
                }
            }
        }
        private void SaveFile(ListBox listBox, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (string item in listBox.Items)
                {
                    sw.WriteLine(item);
                }
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            if (top10.Items.Count != 0)
            {
                string fileName = "Top10.txt";

                SaveFile(top10, fileName);

                MessageBox.Show("Success!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The list is empty. Nothing to print.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (top3.Items.Count != 0)
            {
                string fileName = "Top3.txt";

                SaveFile(top3, fileName);

                MessageBox.Show("Success!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The list is empty. Nothing to print.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MissUniverse.Items.Count != 0)
            {
                string fileName = "MissUniverse.txt";

                SaveFile(MissUniverse, fileName);
    
                MessageBox.Show("Success!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The list is empty. Nothing to print.");
                return;
            }
        }
    }
}
