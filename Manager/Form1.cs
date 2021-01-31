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
           
            this.listImagenes.MouseDoubleClick+= new MouseEventHandler(ListImagenes_MouseDoubleClick);
        }

        


        private void BtnSelecFuente_Click(object sender, EventArgs e)
        {
            
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                lblCarpetaFuente.Text = folderBrowserDialog1.SelectedPath;
                ActualizarListBox(lblCarpetaFuente.Text);

            }
        }

      

        private void BtnSelecDestino_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                lblDestino.Text = folderBrowserDialog1.SelectedPath;
            }
        }


       
        

        private void ListImagenes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            int ind = this.listImagenes.IndexFromPoint(e.Location);
           
            if (ind != System.Windows.Forms.ListBox.NoMatches && lblDestino.Text!="No seleccionado") 
            {
                
                string img = listImagenes.SelectedItem.ToString();

                im.Dispose();
                if(!File.Exists(lblDestino.Text + img)) { 
                    File.Copy(lblCarpetaFuente.Text + img, lblDestino.Text + img);
                    if (checkBorrar.Checked) {
                        File.Delete((lblCarpetaFuente.Text + img).ToString());
                    }
                MessageBox.Show("Imagen movida");
                    ActualizarListBox(lblCarpetaFuente.Text);
                } else { MessageBox.Show("La imagen ya existe en la carpeta destino"); }


            }

        }
        private void ListImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listImagenes.SelectedItem != null)
            {
                im = new Bitmap(lblCarpetaFuente.Text + listImagenes.SelectedItem);
                picPrevia.Image = im;
              
            }
        }


        public void ActualizarListBox(string ruta) {
            listImagenes.Items.Clear();
            archivos = Directory.GetFiles(ruta, "*.jpg");
            for (int i = 0; i <= archivos.Length - 1; i++) {
                int index = archivos[i].LastIndexOf("\\");
                if (index > 0) {
                    archivos[i] = archivos[i].Substring(index, archivos[i].Length - index);
                    listImagenes.Items.Add(archivos[i].ToString());
                }
            }

        }

    }
    

}
