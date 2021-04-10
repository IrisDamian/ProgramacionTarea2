
namespace TareaDatos
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
            this.buttonCar = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonPG = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonNt = new System.Windows.Forms.Button();
            this.listBoxA = new System.Windows.Forms.ListBox();
            this.listBoxNom = new System.Windows.Forms.ListBox();
            this.listBoxPro = new System.Windows.Forms.ListBox();
            this.listBoxGeneral = new System.Windows.Forms.ListBox();
            this.listBoxNota = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCar
            // 
            this.buttonCar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCar.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCar.Location = new System.Drawing.Point(27, 388);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(179, 36);
            this.buttonCar.TabIndex = 0;
            this.buttonCar.Text = "Cargar Archivo";
            this.buttonCar.UseVisualStyleBackColor = false;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // buttonN
            // 
            this.buttonN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonN.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN.ForeColor = System.Drawing.Color.Transparent;
            this.buttonN.Location = new System.Drawing.Point(217, 388);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(119, 36);
            this.buttonN.TabIndex = 1;
            this.buttonN.Text = "Nombres";
            this.buttonN.UseVisualStyleBackColor = false;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonP
            // 
            this.buttonP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonP.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonP.ForeColor = System.Drawing.Color.Transparent;
            this.buttonP.Location = new System.Drawing.Point(344, 388);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(119, 36);
            this.buttonP.TabIndex = 2;
            this.buttonP.Text = "Promedio";
            this.buttonP.UseVisualStyleBackColor = false;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonPG
            // 
            this.buttonPG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPG.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPG.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPG.Location = new System.Drawing.Point(477, 388);
            this.buttonPG.Name = "buttonPG";
            this.buttonPG.Size = new System.Drawing.Size(176, 42);
            this.buttonPG.TabIndex = 3;
            this.buttonPG.Text = "Promedio General ";
            this.buttonPG.UseVisualStyleBackColor = false;
            this.buttonPG.Click += new System.EventHandler(this.buttonPG_Click);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonA.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.ForeColor = System.Drawing.Color.Transparent;
            this.buttonA.Location = new System.Drawing.Point(670, 388);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(119, 36);
            this.buttonA.TabIndex = 4;
            this.buttonA.Text = "Arreglo";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonNt
            // 
            this.buttonNt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNt.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNt.ForeColor = System.Drawing.Color.Transparent;
            this.buttonNt.Location = new System.Drawing.Point(795, 388);
            this.buttonNt.Name = "buttonNt";
            this.buttonNt.Size = new System.Drawing.Size(119, 36);
            this.buttonNt.TabIndex = 5;
            this.buttonNt.Text = "Notas";
            this.buttonNt.UseVisualStyleBackColor = false;
            this.buttonNt.Click += new System.EventHandler(this.buttonNt_Click);
            // 
            // listBoxA
            // 
            this.listBoxA.FormattingEnabled = true;
            this.listBoxA.Location = new System.Drawing.Point(2, 100);
            this.listBoxA.Name = "listBoxA";
            this.listBoxA.Size = new System.Drawing.Size(52, 82);
            this.listBoxA.TabIndex = 6;
            // 
            // listBoxNom
            // 
            this.listBoxNom.FormattingEnabled = true;
            this.listBoxNom.Location = new System.Drawing.Point(57, 100);
            this.listBoxNom.Name = "listBoxNom";
            this.listBoxNom.Size = new System.Drawing.Size(307, 251);
            this.listBoxNom.TabIndex = 7;
            // 
            // listBoxPro
            // 
            this.listBoxPro.FormattingEnabled = true;
            this.listBoxPro.Location = new System.Drawing.Point(370, 100);
            this.listBoxPro.Name = "listBoxPro";
            this.listBoxPro.Size = new System.Drawing.Size(139, 251);
            this.listBoxPro.TabIndex = 8;
            // 
            // listBoxGeneral
            // 
            this.listBoxGeneral.FormattingEnabled = true;
            this.listBoxGeneral.Location = new System.Drawing.Point(515, 100);
            this.listBoxGeneral.Name = "listBoxGeneral";
            this.listBoxGeneral.Size = new System.Drawing.Size(189, 251);
            this.listBoxGeneral.TabIndex = 9;
            // 
            // listBoxNota
            // 
            this.listBoxNota.FormattingEnabled = true;
            this.listBoxNota.Location = new System.Drawing.Point(710, 100);
            this.listBoxNota.Name = "listBoxNota";
            this.listBoxNota.Size = new System.Drawing.Size(258, 251);
            this.listBoxNota.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(119, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombres de Alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(399, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Moccasin;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(540, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Promedio General";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Moccasin;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(739, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Notas más altas y bajas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(971, 498);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNota);
            this.Controls.Add(this.listBoxGeneral);
            this.Controls.Add(this.listBoxPro);
            this.Controls.Add(this.listBoxNom);
            this.Controls.Add(this.listBoxA);
            this.Controls.Add(this.buttonNt);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonPG);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonCar);
            this.Name = "Form1";
            this.Text = "NOTAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonPG;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonNt;
        private System.Windows.Forms.ListBox listBoxA;
        private System.Windows.Forms.ListBox listBoxNom;
        private System.Windows.Forms.ListBox listBoxPro;
        private System.Windows.Forms.ListBox listBoxGeneral;
        private System.Windows.Forms.ListBox listBoxNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

