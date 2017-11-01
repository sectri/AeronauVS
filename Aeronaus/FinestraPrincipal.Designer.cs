namespace Aeronaus
{
    partial class finestraPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finestraPrincipal));
            this.menuInfoEspaiAeri = new System.Windows.Forms.Button();
            this.menuMantenimentAeri = new System.Windows.Forms.Button();
            this.menuGestionarAvio = new System.Windows.Forms.Button();
            this.menuDonarAlta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.consoleOut = new System.Windows.Forms.Label();
            this.textSortida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuInfoEspaiAeri
            // 
            this.menuInfoEspaiAeri.Location = new System.Drawing.Point(300, 100);
            this.menuInfoEspaiAeri.Name = "menuInfoEspaiAeri";
            this.menuInfoEspaiAeri.Size = new System.Drawing.Size(250, 60);
            this.menuInfoEspaiAeri.TabIndex = 3;
            this.menuInfoEspaiAeri.Text = "Informació de l\'espai aeri";
            this.menuInfoEspaiAeri.UseVisualStyleBackColor = true;
            this.menuInfoEspaiAeri.Click += new System.EventHandler(this.infoEspaiAeri_Click);
            // 
            // menuMantenimentAeri
            // 
            this.menuMantenimentAeri.Location = new System.Drawing.Point(300, 20);
            this.menuMantenimentAeri.Name = "menuMantenimentAeri";
            this.menuMantenimentAeri.Size = new System.Drawing.Size(250, 60);
            this.menuMantenimentAeri.TabIndex = 2;
            this.menuMantenimentAeri.Text = "Manteniment de l\'espai aeri";
            this.menuMantenimentAeri.UseVisualStyleBackColor = true;
            this.menuMantenimentAeri.Click += new System.EventHandler(this.mantenimentAeri_Click);
            // 
            // menuGestionarAvio
            // 
            this.menuGestionarAvio.Location = new System.Drawing.Point(20, 100);
            this.menuGestionarAvio.Name = "menuGestionarAvio";
            this.menuGestionarAvio.Size = new System.Drawing.Size(250, 60);
            this.menuGestionarAvio.TabIndex = 1;
            this.menuGestionarAvio.Text = "Gestiona un dels avions";
            this.menuGestionarAvio.UseVisualStyleBackColor = true;
            this.menuGestionarAvio.Click += new System.EventHandler(this.gestionarAvio_Click);
            // 
            // menuDonarAlta
            // 
            this.menuDonarAlta.Location = new System.Drawing.Point(20, 20);
            this.menuDonarAlta.Name = "menuDonarAlta";
            this.menuDonarAlta.Size = new System.Drawing.Size(250, 60);
            this.menuDonarAlta.TabIndex = 0;
            this.menuDonarAlta.Text = "Donar d\'alta avio al sistema";
            this.menuDonarAlta.UseVisualStyleBackColor = true;
            this.menuDonarAlta.Click += new System.EventHandler(this.donarAlta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "consoleOut";
            // 
            // consoleOut
            // 
            this.consoleOut.Location = new System.Drawing.Point(53, 256);
            this.consoleOut.Name = "consoleOut";
            this.consoleOut.Size = new System.Drawing.Size(567, 69);
            this.consoleOut.TabIndex = 5;
            this.consoleOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textSortida
            // 
            this.textSortida.Location = new System.Drawing.Point(53, 256);
            this.textSortida.Name = "textSortida";
            this.textSortida.Size = new System.Drawing.Size(567, 69);
            this.textSortida.TabIndex = 5;
            this.textSortida.Text = "a";
            this.textSortida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finestraPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 178);
            this.Controls.Add(this.menuDonarAlta);
            this.Controls.Add(this.menuMantenimentAeri);
            this.Controls.Add(this.menuInfoEspaiAeri);
            this.Controls.Add(this.menuGestionarAvio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "finestraPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aeronaus - Sergi Alonso Vicente";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button menuInfoEspaiAeri;
        private System.Windows.Forms.Button menuMantenimentAeri;
        private System.Windows.Forms.Button menuGestionarAvio;
        private System.Windows.Forms.Button menuDonarAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label consoleOut;
        private System.Windows.Forms.Label textSortida;
    }
}

