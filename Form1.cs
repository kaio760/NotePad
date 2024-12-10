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
using System.Xml.Linq;

namespace Bloco_de_notas
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, RtbDigitar.Text);
            }
            //File.WriteAllText(salvarComoToolStripMenuItem.Text, RtbDigitar.Text);
            //Directory.CreateDirectory("C:\\Users\\kaio.sljcampos\\Documento");
            //nomeArquivo = "Kaio";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtbDigitar.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RtbDigitar.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtbDigitar.Copy();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtbDigitar.Paste();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
                this.RtbDigitar.Font = fd.Font;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsobre sobre = new frmsobre();
            sobre.ShowDialog();

        }
    }
}
