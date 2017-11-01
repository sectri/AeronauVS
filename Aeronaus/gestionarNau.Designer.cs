namespace Aeronaus
{
    partial class GestionarNau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarNau));
            this.menuFinalitzar = new System.Windows.Forms.Button();
            this.menuRumb = new System.Windows.Forms.Button();
            this.menuAparcar = new System.Windows.Forms.Button();
            this.menuPosicionarXY = new System.Windows.Forms.Button();
            this.menuMotorOnOff = new System.Windows.Forms.Button();
            this.menuAccelerar = new System.Windows.Forms.Button();
            this.menuTrenAterratge = new System.Windows.Forms.Button();
            this.menuPujarAlcada = new System.Windows.Forms.Button();
            this.menuFrenar = new System.Windows.Forms.Button();
            this.menuBaixarAlcada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuFinalitzar
            // 
            this.menuFinalitzar.Location = new System.Drawing.Point(310, 380);
            this.menuFinalitzar.Name = "menuFinalitzar";
            this.menuFinalitzar.Size = new System.Drawing.Size(250, 70);
            this.menuFinalitzar.TabIndex = 9;
            this.menuFinalitzar.Text = "Finalitzar operativa";
            this.menuFinalitzar.UseVisualStyleBackColor = true;
            this.menuFinalitzar.Click += new System.EventHandler(this.menuFinalitzar_Click);
            // 
            // menuRumb
            // 
            this.menuRumb.Location = new System.Drawing.Point(310, 290);
            this.menuRumb.Name = "menuRumb";
            this.menuRumb.Size = new System.Drawing.Size(250, 70);
            this.menuRumb.TabIndex = 8;
            this.menuRumb.Text = "Establir rumb";
            this.menuRumb.UseVisualStyleBackColor = true;
            this.menuRumb.Click += new System.EventHandler(this.menuRumb_Click);
            // 
            // menuAparcar
            // 
            this.menuAparcar.Location = new System.Drawing.Point(20, 380);
            this.menuAparcar.Name = "menuAparcar";
            this.menuAparcar.Size = new System.Drawing.Size(250, 70);
            this.menuAparcar.TabIndex = 4;
            this.menuAparcar.Text = "Aparcar";
            this.menuAparcar.UseVisualStyleBackColor = true;
            this.menuAparcar.Click += new System.EventHandler(this.menuAparcar_Click);
            // 
            // menuPosicionarXY
            // 
            this.menuPosicionarXY.Location = new System.Drawing.Point(20, 290);
            this.menuPosicionarXY.Name = "menuPosicionarXY";
            this.menuPosicionarXY.Size = new System.Drawing.Size(250, 70);
            this.menuPosicionarXY.TabIndex = 3;
            this.menuPosicionarXY.Text = "Posicionar X, Y";
            this.menuPosicionarXY.UseVisualStyleBackColor = true;
            this.menuPosicionarXY.Click += new System.EventHandler(this.menuPosicionarXY_Click);
            // 
            // menuMotorOnOff
            // 
            this.menuMotorOnOff.Location = new System.Drawing.Point(20, 20);
            this.menuMotorOnOff.Name = "menuMotorOnOff";
            this.menuMotorOnOff.Size = new System.Drawing.Size(250, 70);
            this.menuMotorOnOff.TabIndex = 0;
            this.menuMotorOnOff.Text = "Encendre / Apagar motor";
            this.menuMotorOnOff.UseVisualStyleBackColor = true;
            this.menuMotorOnOff.Click += new System.EventHandler(this.menuMotorOnOff_Click);
            // 
            // menuAccelerar
            // 
            this.menuAccelerar.Location = new System.Drawing.Point(20, 200);
            this.menuAccelerar.Name = "menuAccelerar";
            this.menuAccelerar.Size = new System.Drawing.Size(250, 70);
            this.menuAccelerar.TabIndex = 2;
            this.menuAccelerar.Text = "Accelerar";
            this.menuAccelerar.UseVisualStyleBackColor = true;
            this.menuAccelerar.Click += new System.EventHandler(this.menuAccelerar_Click);
            // 
            // menuTrenAterratge
            // 
            this.menuTrenAterratge.Location = new System.Drawing.Point(310, 20);
            this.menuTrenAterratge.Name = "menuTrenAterratge";
            this.menuTrenAterratge.Size = new System.Drawing.Size(250, 70);
            this.menuTrenAterratge.TabIndex = 5;
            this.menuTrenAterratge.Text = "Pujar / Baixar tren aterratge";
            this.menuTrenAterratge.UseVisualStyleBackColor = true;
            this.menuTrenAterratge.Click += new System.EventHandler(this.menuTrenAterratge_Click);
            // 
            // menuPujarAlcada
            // 
            this.menuPujarAlcada.Location = new System.Drawing.Point(20, 110);
            this.menuPujarAlcada.Name = "menuPujarAlcada";
            this.menuPujarAlcada.Size = new System.Drawing.Size(250, 70);
            this.menuPujarAlcada.TabIndex = 1;
            this.menuPujarAlcada.Text = "Pujar";
            this.menuPujarAlcada.UseVisualStyleBackColor = true;
            this.menuPujarAlcada.Click += new System.EventHandler(this.menuPujarAlcada_Click);
            // 
            // menuFrenar
            // 
            this.menuFrenar.Location = new System.Drawing.Point(310, 200);
            this.menuFrenar.Name = "menuFrenar";
            this.menuFrenar.Size = new System.Drawing.Size(250, 70);
            this.menuFrenar.TabIndex = 7;
            this.menuFrenar.Text = "Frenar";
            this.menuFrenar.UseVisualStyleBackColor = true;
            this.menuFrenar.Click += new System.EventHandler(this.menuFrenar_Click);
            // 
            // menuBaixarAlcada
            // 
            this.menuBaixarAlcada.Location = new System.Drawing.Point(310, 110);
            this.menuBaixarAlcada.Name = "menuBaixarAlcada";
            this.menuBaixarAlcada.Size = new System.Drawing.Size(250, 70);
            this.menuBaixarAlcada.TabIndex = 6;
            this.menuBaixarAlcada.Text = "Baixar";
            this.menuBaixarAlcada.UseVisualStyleBackColor = true;
            this.menuBaixarAlcada.Click += new System.EventHandler(this.menuBaixarAlcada_Click);
            // 
            // GestionarNau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 468);
            this.Controls.Add(this.menuBaixarAlcada);
            this.Controls.Add(this.menuFrenar);
            this.Controls.Add(this.menuFinalitzar);
            this.Controls.Add(this.menuRumb);
            this.Controls.Add(this.menuTrenAterratge);
            this.Controls.Add(this.menuAparcar);
            this.Controls.Add(this.menuAccelerar);
            this.Controls.Add(this.menuPujarAlcada);
            this.Controls.Add(this.menuMotorOnOff);
            this.Controls.Add(this.menuPosicionarXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionarNau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuFinalitzar;
        private System.Windows.Forms.Button menuRumb;
        private System.Windows.Forms.Button menuAparcar;
        private System.Windows.Forms.Button menuPosicionarXY;
        private System.Windows.Forms.Button menuMotorOnOff;
        private System.Windows.Forms.Button menuAccelerar;
        private System.Windows.Forms.Button menuTrenAterratge;
        private System.Windows.Forms.Button menuPujarAlcada;
        private System.Windows.Forms.Button menuFrenar;
        private System.Windows.Forms.Button menuBaixarAlcada;
    }
}