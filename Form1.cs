using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noteme__
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SaveFile = new
            System.IO.StreamWriter(openFileDialog1.FileName);
            SaveFile.WriteLine(txtMain.Text);
            SaveFile.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtMain_TextChanged(object sender, EventArgs e)
        {
            txtMain.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.IO.StreamReader OpenFile = new
            System.IO.StreamReader(openFileDialog1.FileName);
            txtMain.Text = OpenFile.ReadToEnd();
            OpenFile.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            System.IO.StreamWriter SaveFile = new
            System.IO.StreamWriter(saveFileDialog1.FileName);
            SaveFile.WriteLine(txtMain.Text);
            SaveFile.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument prntDoc = new
            System.Drawing.Printing.PrintDocument();


        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();


            if (preview.ShowDialog(this) == DialogResult.OK)

            {


            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " what is in your mind ";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Noteme + is here";
        }

        private void statusStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}

  