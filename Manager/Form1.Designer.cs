namespace Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gruVistaPrevia = new System.Windows.Forms.GroupBox();
            this.picPrevia = new System.Windows.Forms.PictureBox();
            this.btnSelecFuente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarpetaFuente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecDestino = new System.Windows.Forms.Button();
            this.listImagenes = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblDestino = new System.Windows.Forms.Label();
            this.checkBorrar = new System.Windows.Forms.CheckBox();
            this.gruVistaPrevia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // gruVistaPrevia
            // 
            this.gruVistaPrevia.Controls.Add(this.picPrevia);
            this.gruVistaPrevia.Location = new System.Drawing.Point(12, 12);
            this.gruVistaPrevia.Name = "gruVistaPrevia";
            this.gruVistaPrevia.Size = new System.Drawing.Size(244, 215);
            this.gruVistaPrevia.TabIndex = 0;
            this.gruVistaPrevia.TabStop = false;
            this.gruVistaPrevia.Text = "Vista Previa";
            // 
            // picPrevia
            // 
            this.picPrevia.Location = new System.Drawing.Point(6, 20);
            this.picPrevia.Name = "picPrevia";
            this.picPrevia.Size = new System.Drawing.Size(232, 189);
            this.picPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrevia.TabIndex = 0;
            this.picPrevia.TabStop = false;
            // 
            // btnSelecFuente
            // 
            this.btnSelecFuente.Location = new System.Drawing.Point(352, 22);
            this.btnSelecFuente.Name = "btnSelecFuente";
            this.btnSelecFuente.Size = new System.Drawing.Size(82, 23);
            this.btnSelecFuente.TabIndex = 1;
            this.btnSelecFuente.Text = "Seleccionar";
            this.btnSelecFuente.UseVisualStyleBackColor = true;
            this.btnSelecFuente.Click += new System.EventHandler(this.BtnSelecFuente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carpeta Fuente:";
            // 
            // lblCarpetaFuente
            // 
            this.lblCarpetaFuente.AutoSize = true;
            this.lblCarpetaFuente.Location = new System.Drawing.Point(440, 27);
            this.lblCarpetaFuente.Name = "lblCarpetaFuente";
            this.lblCarpetaFuente.Size = new System.Drawing.Size(87, 13);
            this.lblCarpetaFuente.TabIndex = 2;
            this.lblCarpetaFuente.Text = "No seleccionado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carpeta Destino:";
            // 
            // btnSelecDestino
            // 
            this.btnSelecDestino.Location = new System.Drawing.Point(352, 60);
            this.btnSelecDestino.Name = "btnSelecDestino";
            this.btnSelecDestino.Size = new System.Drawing.Size(82, 23);
            this.btnSelecDestino.TabIndex = 1;
            this.btnSelecDestino.Text = "Seleccionar";
            this.btnSelecDestino.UseVisualStyleBackColor = true;
            this.btnSelecDestino.Click += new System.EventHandler(this.BtnSelecDestino_Click);
            // 
            // listImagenes
            // 
            this.listImagenes.FormattingEnabled = true;
            this.listImagenes.Location = new System.Drawing.Point(266, 95);
            this.listImagenes.Name = "listImagenes";
            this.listImagenes.Size = new System.Drawing.Size(305, 121);
            this.listImagenes.TabIndex = 4;
            this.listImagenes.SelectedIndexChanged += new System.EventHandler(this.ListImagenes_SelectedIndexChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(440, 65);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(87, 13);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "No seleccionado";
            // 
            // checkBorrar
            // 
            this.checkBorrar.AutoSize = true;
            this.checkBorrar.Location = new System.Drawing.Point(266, 223);
            this.checkBorrar.Name = "checkBorrar";
            this.checkBorrar.Size = new System.Drawing.Size(101, 17);
            this.checkBorrar.TabIndex = 5;
            this.checkBorrar.Text = "Borrar de origen";
            this.checkBorrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 261);
            this.Controls.Add(this.checkBorrar);
            this.Controls.Add(this.listImagenes);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblCarpetaFuente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelecDestino);
            this.Controls.Add(this.btnSelecFuente);
            this.Controls.Add(this.gruVistaPrevia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gruVistaPrevia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gruVistaPrevia;
        private System.Windows.Forms.Button btnSelecFuente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarpetaFuente;
        private System.Windows.Forms.PictureBox picPrevia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelecDestino;
        private System.Windows.Forms.ListBox listImagenes;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.CheckBox checkBorrar;
    }
}

