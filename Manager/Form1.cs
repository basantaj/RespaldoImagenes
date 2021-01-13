using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Manager
 {
    

    public partial class Form1 : Form
    {

       

        string[] archivos;
        Image im;
        public Form1()
        
        {
            InitializeComponent();
           
            this.listImagenes.MouseDoubleClick+= new MouseEventHandler(listImagenes_MouseDoubleClick);
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecFuente_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                lblCarpetaFuente.Text = folderBrowserDialog1.SelectedPath;
                archivos =Directory.GetFiles(folderBrowserDialog1.SelectedPath,"*.jpg");
               
                for (int i = 0; i <= archivos.Length-1; i++)
                {
                    int index = archivos[i].LastIndexOf("\\");
                    //Console.Write(index);
                    if (index > 0)
                    {
                        archivos[i] = archivos[i].Substring(index,archivos[i].Length-index);
                       Console.Write(archivos[i]);
                    }
                }
                listImagenes.DataSource = archivos;
                folderBrowserDialog1.Dispose();
               
            }

        }

      

        private void btnSelecDestino_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblDestino.Text = folderBrowserDialog1.SelectedPath;
            }
            folderBrowserDialog1.Dispose();
        }


       
        

        private void listImagenes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            int ind = this.listImagenes.IndexFromPoint(e.Location);
           
            if (ind != System.Windows.Forms.ListBox.NoMatches && lblDestino.Text!="No seleccionado") 
            {
                
                string img = listImagenes.SelectedItem.ToString();
                //MessageBox.Show(lblDestino.Text + img);
                File.Copy(lblCarpetaFuente.Text + img, lblDestino.Text + img);
                MessageBox.Show("Copiado");
            }

        }
        private void listImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Console.Write(lblCarpetaFuente.Text + listImagenes.SelectedItem);
            if (listImagenes.SelectedItem != null)
            {
                im = new Bitmap(lblCarpetaFuente.Text + listImagenes.SelectedItem);
                picPrevia.Image = im;
            }
        }
    }
}
