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
            this.menuFinalitzar = new System.Windows.Forms.Button();
            this.menuRumb = new System.Windows.Forms.Button();
            this.menuAparcar = new System.Windows.Forms.Button();
            this.menuPosicionarXY = new System.Windows.Forms.Button();
            this.menuMotorOnOff = new System.Windows.Forms.Button();
            this.menuVelocitat = new System.Windows.Forms.Button();
            this.menuTrenAterratge = new System.Windows.Forms.Button();
            this.menuAlcada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuFinalitzar
            // 
            this.menuFinalitzar.Location = new System.Drawing.Point(310, 290);
            this.menuFinalitzar.Name = "menuFinalitzar";
            this.menuFinalitzar.Size = new System.Drawing.Size(250, 70);
            this.menuFinalitzar.TabIndex = 7;
            this.menuFinalitzar.Text = "Finalitzar operativa";
            this.menuFinalitzar.UseVisualStyleBackColor = true;
            this.menuFinalitzar.Click += new System.EventHandler(this.menuFinalitzar_Click);
            // 
            // menuRumb
            // 
            this.menuRumb.Location = new System.Drawing.Point(310, 200);
            this.menuRumb.Name = "menuRumb";
            this.menuRumb.Size = new System.Drawing.Size(250, 70);
            this.menuRumb.TabIndex = 6;
            this.menuRumb.Text = "Establir rumb";
            this.menuRumb.UseVisualStyleBackColor = true;
            this.menuRumb.Click += new System.EventHandler(this.menuRumb_Click);
            // 
            // menuAparcar
            // 
            this.menuAparcar.Location = new System.Drawing.Point(310, 110);
            this.menuAparcar.Name = "menuAparcar";
            this.menuAparcar.Size = new System.Drawing.Size(250, 70);
            this.menuAparcar.TabIndex = 5;
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
            this.menuMotorOnOff.Location = new System.Drawing.Point(20, 200);
            this.menuMotorOnOff.Name = "menuMotorOnOff";
            this.menuMotorOnOff.Size = new System.Drawing.Size(250, 70);
            this.menuMotorOnOff.TabIndex = 2;
            this.menuMotorOnOff.Text = "Encendre / Apagar motor";
            this.menuMotorOnOff.UseVisualStyleBackColor = true;
            this.menuMotorOnOff.Click += new System.EventHandler(this.menuMotorOnOff_Click);
            // 
            // menuVelocitat
            // 
            this.menuVelocitat.Location = new System.Drawing.Point(20, 110);
            this.menuVelocitat.Name = "menuVelocitat";
            this.menuVelocitat.Size = new System.Drawing.Size(250, 70);
            this.menuVelocitat.TabIndex = 1;
            this.menuVelocitat.Text = "Accelerar / Frenar";
            this.menuVelocitat.UseVisualStyleBackColor = true;
            this.menuVelocitat.Click += new System.EventHandler(this.menuVelocitat_Click);
            // 
            // menuTrenAterratge
            // 
            this.menuTrenAterratge.Location = new System.Drawing.Point(20, 20);
            this.menuTrenAterratge.Name = "menuTrenAterratge";
            this.menuTrenAterratge.Size = new System.Drawing.Size(250, 70);
            this.menuTrenAterratge.TabIndex = 0;
            this.menuTrenAterratge.Text = "Pujar / Baixar tren aterratge";
            this.menuTrenAterratge.UseVisualStyleBackColor = true;
            this.menuTrenAterratge.Click += new System.EventHandler(this.menuTrenAterratge_Click);
            // 
            // menuAlcada
            // 
            this.menuAlcada.Location = new System.Drawing.Point(310, 20);
            this.menuAlcada.Name = "menuAlcada";
            this.menuAlcada.Size = new System.Drawing.Size(250, 70);
            this.menuAlcada.TabIndex = 4;
            this.menuAlcada.Text = "Agafar / Baixar alçada";
            this.menuAlcada.UseVisualStyleBackColor = true;
            this.menuAlcada.Click += new System.EventHandler(this.menuAlcada_Click);
            // 
            // GestionarNau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 378);
            this.Controls.Add(this.menuFinalitzar);
            this.Controls.Add(this.menuRumb);
            this.Controls.Add(this.menuTrenAterratge);
            this.Controls.Add(this.menuAparcar);
            this.Controls.Add(this.menuVelocitat);
            this.Controls.Add(this.menuAlcada);
            this.Controls.Add(this.menuMotorOnOff);
            this.Controls.Add(this.menuPosicionarXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GestionarNau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionarNau";
            this.Load += new System.EventHandler(this.GestionarNau_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuFinalitzar;
        private System.Windows.Forms.Button menuRumb;
        private System.Windows.Forms.Button menuAparcar;
        private System.Windows.Forms.Button menuPosicionarXY;
        private System.Windows.Forms.Button menuMotorOnOff;
        private System.Windows.Forms.Button menuVelocitat;
        private System.Windows.Forms.Button menuTrenAterratge;
        private System.Windows.Forms.Button menuAlcada;
    }
}