
namespace SegundoParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNA = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonGs = new System.Windows.Forms.Button();
            this.buttonPg = new System.Windows.Forms.Button();
            this.buttonMN = new System.Windows.Forms.Button();
            this.listBoxNA = new System.Windows.Forms.ListBox();
            this.listBoxPro = new System.Windows.Forms.ListBox();
            this.listBoxProG = new System.Windows.Forms.ListBox();
            this.listBoxGenS = new System.Windows.Forms.ListBox();
            this.listBoxMeN = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(115, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar Archivo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNA
            // 
            this.buttonNA.BackColor = System.Drawing.Color.Yellow;
            this.buttonNA.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNA.Location = new System.Drawing.Point(115, 76);
            this.buttonNA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNA.Name = "buttonNA";
            this.buttonNA.Size = new System.Drawing.Size(124, 55);
            this.buttonNA.TabIndex = 1;
            this.buttonNA.Text = "Nombres Alumno";
            this.buttonNA.UseVisualStyleBackColor = false;
            this.buttonNA.Click += new System.EventHandler(this.buttonNA_Click);
            // 
            // buttonP
            // 
            this.buttonP.BackColor = System.Drawing.Color.Yellow;
            this.buttonP.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonP.Location = new System.Drawing.Point(456, 13);
            this.buttonP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(124, 55);
            this.buttonP.TabIndex = 2;
            this.buttonP.Text = "Promedio";
            this.buttonP.UseVisualStyleBackColor = false;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonGs
            // 
            this.buttonGs.BackColor = System.Drawing.Color.Yellow;
            this.buttonGs.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGs.Location = new System.Drawing.Point(806, 4);
            this.buttonGs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGs.Name = "buttonGs";
            this.buttonGs.Size = new System.Drawing.Size(124, 55);
            this.buttonGs.TabIndex = 4;
            this.buttonGs.Text = "General Seccion";
            this.buttonGs.UseVisualStyleBackColor = false;
            this.buttonGs.Click += new System.EventHandler(this.buttonGs_Click);
            // 
            // buttonPg
            // 
            this.buttonPg.BackColor = System.Drawing.Color.Yellow;
            this.buttonPg.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPg.Location = new System.Drawing.Point(456, 76);
            this.buttonPg.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPg.Name = "buttonPg";
            this.buttonPg.Size = new System.Drawing.Size(124, 55);
            this.buttonPg.TabIndex = 5;
            this.buttonPg.Text = "Promedios Generales";
            this.buttonPg.UseVisualStyleBackColor = false;
            this.buttonPg.Click += new System.EventHandler(this.buttonPg_Click);
            // 
            // buttonMN
            // 
            this.buttonMN.BackColor = System.Drawing.Color.Yellow;
            this.buttonMN.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMN.Location = new System.Drawing.Point(806, 76);
            this.buttonMN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMN.Name = "buttonMN";
            this.buttonMN.Size = new System.Drawing.Size(124, 55);
            this.buttonMN.TabIndex = 6;
            this.buttonMN.Text = "Mejores Notas";
            this.buttonMN.UseVisualStyleBackColor = false;
            this.buttonMN.Click += new System.EventHandler(this.buttonMN_Click);
            // 
            // listBoxNA
            // 
            this.listBoxNA.FormattingEnabled = true;
            this.listBoxNA.ItemHeight = 16;
            this.listBoxNA.Location = new System.Drawing.Point(9, 223);
            this.listBoxNA.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxNA.Name = "listBoxNA";
            this.listBoxNA.Size = new System.Drawing.Size(354, 308);
            this.listBoxNA.TabIndex = 7;
            // 
            // listBoxPro
            // 
            this.listBoxPro.FormattingEnabled = true;
            this.listBoxPro.ItemHeight = 16;
            this.listBoxPro.Location = new System.Drawing.Point(371, 223);
            this.listBoxPro.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPro.Name = "listBoxPro";
            this.listBoxPro.Size = new System.Drawing.Size(146, 308);
            this.listBoxPro.TabIndex = 8;
            // 
            // listBoxProG
            // 
            this.listBoxProG.FormattingEnabled = true;
            this.listBoxProG.ItemHeight = 16;
            this.listBoxProG.Location = new System.Drawing.Point(525, 223);
            this.listBoxProG.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProG.Name = "listBoxProG";
            this.listBoxProG.Size = new System.Drawing.Size(142, 308);
            this.listBoxProG.TabIndex = 9;
            // 
            // listBoxGenS
            // 
            this.listBoxGenS.FormattingEnabled = true;
            this.listBoxGenS.ItemHeight = 16;
            this.listBoxGenS.Location = new System.Drawing.Point(675, 233);
            this.listBoxGenS.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGenS.Name = "listBoxGenS";
            this.listBoxGenS.Size = new System.Drawing.Size(200, 308);
            this.listBoxGenS.TabIndex = 10;
            // 
            // listBoxMeN
            // 
            this.listBoxMeN.FormattingEnabled = true;
            this.listBoxMeN.ItemHeight = 16;
            this.listBoxMeN.Location = new System.Drawing.Point(883, 233);
            this.listBoxMeN.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMeN.Name = "listBoxMeN";
            this.listBoxMeN.Size = new System.Drawing.Size(170, 308);
            this.listBoxMeN.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(128, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "NOMBRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(386, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "PROMEDIOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(540, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "PROMEDIOS \r\nGENERALES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(719, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "PROMEDIOS \r\nSECCIÓN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Wheat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(916, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "El mejor \r\n Promedio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1066, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMeN);
            this.Controls.Add(this.listBoxGenS);
            this.Controls.Add(this.listBoxProG);
            this.Controls.Add(this.listBoxPro);
            this.Controls.Add(this.listBoxNA);
            this.Controls.Add(this.buttonMN);
            this.Controls.Add(this.buttonPg);
            this.Controls.Add(this.buttonGs);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonNA);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNA;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonGs;
        private System.Windows.Forms.Button buttonPg;
        private System.Windows.Forms.Button buttonMN;
        private System.Windows.Forms.ListBox listBoxNA;
        private System.Windows.Forms.ListBox listBoxPro;
        private System.Windows.Forms.ListBox listBoxProG;
        private System.Windows.Forms.ListBox listBoxGenS;
        private System.Windows.Forms.ListBox listBoxMeN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

