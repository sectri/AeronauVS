namespace Aeronaus
{
    partial class DonarAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonarAlta));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.introduirFabricant = new System.Windows.Forms.TextBox();
            this.textFabricant = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.introduirCapacitat = new System.Windows.Forms.TextBox();
            this.textCapacitat = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.introduirMatricula = new System.Windows.Forms.TextBox();
            this.textMatricula = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.introduirModel = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.crearNau = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 339);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.introduirFabricant);
            this.panel2.Controls.Add(this.textFabricant);
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 61);
            this.panel2.TabIndex = 2;
            // 
            // introduirFabricant
            // 
            this.introduirFabricant.Location = new System.Drawing.Point(100, 20);
            this.introduirFabricant.MaxLength = 15;
            this.introduirFabricant.Name = "introduirFabricant";
            this.introduirFabricant.Size = new System.Drawing.Size(160, 22);
            this.introduirFabricant.TabIndex = 1;
            // 
            // textFabricant
            // 
            this.textFabricant.AutoSize = true;
            this.textFabricant.Location = new System.Drawing.Point(15, 22);
            this.textFabricant.Name = "textFabricant";
            this.textFabricant.Size = new System.Drawing.Size(71, 17);
            this.textFabricant.TabIndex = 0;
            this.textFabricant.Text = "Fabricant:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.introduirCapacitat);
            this.panel3.Controls.Add(this.textCapacitat);
            this.panel3.Location = new System.Drawing.Point(3, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 61);
            this.panel3.TabIndex = 2;
            // 
            // introduirCapacitat
            // 
            this.introduirCapacitat.Location = new System.Drawing.Point(100, 20);
            this.introduirCapacitat.MaxLength = 6;
            this.introduirCapacitat.Name = "introduirCapacitat";
            this.introduirCapacitat.Size = new System.Drawing.Size(160, 22);
            this.introduirCapacitat.TabIndex = 1;
            this.introduirCapacitat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumeric);
            // 
            // textCapacitat
            // 
            this.textCapacitat.AutoSize = true;
            this.textCapacitat.Location = new System.Drawing.Point(15, 22);
            this.textCapacitat.Name = "textCapacitat";
            this.textCapacitat.Size = new System.Drawing.Size(71, 17);
            this.textCapacitat.TabIndex = 0;
            this.textCapacitat.Text = "Capacitat:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.introduirMatricula);
            this.panel4.Controls.Add(this.textMatricula);
            this.panel4.Location = new System.Drawing.Point(3, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 61);
            this.panel4.TabIndex = 2;
            // 
            // introduirMatricula
            // 
            this.introduirMatricula.Location = new System.Drawing.Point(100, 20);
            this.introduirMatricula.MaxLength = 15;
            this.introduirMatricula.Name = "introduirMatricula";
            this.introduirMatricula.Size = new System.Drawing.Size(160, 22);
            this.introduirMatricula.TabIndex = 1;
            // 
            // textMatricula
            // 
            this.textMatricula.AutoSize = true;
            this.textMatricula.Location = new System.Drawing.Point(15, 22);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(69, 17);
            this.textMatricula.TabIndex = 0;
            this.textMatricula.Text = "Matricula:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.introduirModel);
            this.panel1.Controls.Add(this.textModel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 61);
            this.panel1.TabIndex = 0;
            // 
            // introduirModel
            // 
            this.introduirModel.Location = new System.Drawing.Point(100, 20);
            this.introduirModel.MaxLength = 15;
            this.introduirModel.Name = "introduirModel";
            this.introduirModel.Size = new System.Drawing.Size(160, 22);
            this.introduirModel.TabIndex = 1;
            // 
            // textModel
            // 
            this.textModel.AutoSize = true;
            this.textModel.Location = new System.Drawing.Point(15, 22);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(50, 17);
            this.textModel.TabIndex = 0;
            this.textModel.Text = "Model:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.crearNau);
            this.panel5.Location = new System.Drawing.Point(3, 271);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 65);
            this.panel5.TabIndex = 3;
            // 
            // crearNau
            // 
            this.crearNau.Location = new System.Drawing.Point(35, 7);
            this.crearNau.Name = "crearNau";
            this.crearNau.Size = new System.Drawing.Size(230, 50);
            this.crearNau.TabIndex = 0;
            this.crearNau.Text = "Crear";
            this.crearNau.UseVisualStyleBackColor = true;
            this.crearNau.Click += new System.EventHandler(this.crearNau_Click);
            // 
            // DonarAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 363);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonarAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonarAlta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textModel;
        private System.Windows.Forms.TextBox introduirModel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox introduirFabricant;
        private System.Windows.Forms.Label textFabricant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox introduirCapacitat;
        private System.Windows.Forms.Label textCapacitat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label textMatricula;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button crearNau;
        private System.Windows.Forms.TextBox introduirMatricula;
    }
}