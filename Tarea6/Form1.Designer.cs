
namespace Tarea6
{
    partial class Carro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carro));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAce = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonCrea = new System.Windows.Forms.Button();
            this.labelE = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.buttonCamvel = new System.Windows.Forms.Button();
            this.labelC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPau = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(354, 358);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(215, 45);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.Gold;
            this.buttonEncender.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEncender.Location = new System.Drawing.Point(104, 161);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(129, 66);
            this.buttonEncender.TabIndex = 5;
            this.buttonEncender.Text = "Encender";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAce
            // 
            this.buttonAce.BackColor = System.Drawing.Color.Gold;
            this.buttonAce.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAce.Location = new System.Drawing.Point(330, 161);
            this.buttonAce.Name = "buttonAce";
            this.buttonAce.Size = new System.Drawing.Size(129, 66);
            this.buttonAce.TabIndex = 6;
            this.buttonAce.Text = "Acelerar";
            this.buttonAce.UseVisualStyleBackColor = false;
            this.buttonAce.Click += new System.EventHandler(this.buttonAce_Click);
            // 
            // buttonParar
            // 
            this.buttonParar.BackColor = System.Drawing.Color.Gold;
            this.buttonParar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParar.Location = new System.Drawing.Point(706, 161);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(129, 66);
            this.buttonParar.TabIndex = 7;
            this.buttonParar.Text = "Parar";
            this.buttonParar.UseVisualStyleBackColor = false;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Escoje tu vehículo que deseas crear";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "KIA",
            "HONDA",
            "BMW"});
            this.comboBox1.Location = new System.Drawing.Point(330, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // buttonCrea
            // 
            this.buttonCrea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCrea.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrea.Location = new System.Drawing.Point(406, 74);
            this.buttonCrea.Name = "buttonCrea";
            this.buttonCrea.Size = new System.Drawing.Size(98, 35);
            this.buttonCrea.TabIndex = 10;
            this.buttonCrea.Text = "Crear";
            this.buttonCrea.UseVisualStyleBackColor = false;
            this.buttonCrea.Click += new System.EventHandler(this.buttonCrea_Click);
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.ForeColor = System.Drawing.Color.Blue;
            this.labelE.Location = new System.Drawing.Point(31, 264);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(0, 16);
            this.labelE.TabIndex = 11;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelV.ForeColor = System.Drawing.Color.Blue;
            this.labelV.Location = new System.Drawing.Point(330, 263);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(0, 16);
            this.labelV.TabIndex = 12;
            // 
            // buttonCamvel
            // 
            this.buttonCamvel.BackColor = System.Drawing.Color.Gold;
            this.buttonCamvel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamvel.Location = new System.Drawing.Point(531, 161);
            this.buttonCamvel.Name = "buttonCamvel";
            this.buttonCamvel.Size = new System.Drawing.Size(129, 66);
            this.buttonCamvel.TabIndex = 13;
            this.buttonCamvel.Text = "Cambiar velocidad";
            this.buttonCamvel.UseVisualStyleBackColor = false;
            this.buttonCamvel.Click += new System.EventHandler(this.buttonCamvel_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.Color.Blue;
            this.labelC.Location = new System.Drawing.Point(539, 263);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(0, 16);
            this.labelC.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(215, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Listo empieza a conducir tu vehículo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(587, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reproducir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Lime;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.Black;
            this.buttonStop.Location = new System.Drawing.Point(588, 412);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(77, 27);
            this.buttonStop.TabIndex = 18;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPau
            // 
            this.buttonPau.BackColor = System.Drawing.Color.Lime;
            this.buttonPau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPau.ForeColor = System.Drawing.Color.Black;
            this.buttonPau.Location = new System.Drawing.Point(587, 376);
            this.buttonPau.Name = "buttonPau";
            this.buttonPau.Size = new System.Drawing.Size(78, 27);
            this.buttonPau.TabIndex = 19;
            this.buttonPau.Text = "Pausa";
            this.buttonPau.UseVisualStyleBackColor = false;
            this.buttonPau.Click += new System.EventHandler(this.buttonPau_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(347, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Encienda la Radio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tarea6.Properties.Resources.holograma_fondo_estilo_interfaz_usuario_hud_115579_831;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPau);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.buttonCamvel);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.buttonCrea);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.buttonAce);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Carro";
            this.Text = "Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAce;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonCrea;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Button buttonCamvel;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPau;
        private System.Windows.Forms.Label label3;
    }
}

