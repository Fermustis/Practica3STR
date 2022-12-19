namespace Practica3
{
    partial class Calculos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBNC = new System.Windows.Forms.ComboBox();
            this.cBFM = new System.Windows.Forms.ComboBox();
            this.cBNB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NumCanales = new System.Windows.Forms.Label();
            this.TasaCompresion = new System.Windows.Forms.Label();
            this.FrecMax = new System.Windows.Forms.Label();
            this.NumBits = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBCS = new System.Windows.Forms.ComboBox();
            this.cBRT = new System.Windows.Forms.ComboBox();
            this.cBPC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textHF = new System.Windows.Forms.TextBox();
            this.textHI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labeTasaCompAudio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarVideo = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTasaCompVideo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labeTasaCompAudio);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.cBNC);
            this.groupBox1.Controls.Add(this.cBFM);
            this.groupBox1.Controls.Add(this.cBNB);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.NumCanales);
            this.groupBox1.Controls.Add(this.TasaCompresion);
            this.groupBox1.Controls.Add(this.FrecMax);
            this.groupBox1.Controls.Add(this.NumBits);
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(335, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio";
            // 
            // cBNC
            // 
            this.cBNC.FormattingEnabled = true;
            this.cBNC.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.cBNC.Location = new System.Drawing.Point(214, 298);
            this.cBNC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBNC.Name = "cBNC";
            this.cBNC.Size = new System.Drawing.Size(92, 21);
            this.cBNC.TabIndex = 11;
            // 
            // cBFM
            // 
            this.cBFM.FormattingEnabled = true;
            this.cBFM.Items.AddRange(new object[] {
            "4",
            "8",
            "18",
            "22"});
            this.cBFM.Location = new System.Drawing.Point(214, 143);
            this.cBFM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBFM.Name = "cBFM";
            this.cBFM.Size = new System.Drawing.Size(92, 21);
            this.cBFM.TabIndex = 9;
            // 
            // cBNB
            // 
            this.cBNB.FormattingEnabled = true;
            this.cBNB.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "16"});
            this.cBNB.Location = new System.Drawing.Point(214, 74);
            this.cBNB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBNB.Name = "cBNB";
            this.cBNB.Size = new System.Drawing.Size(92, 21);
            this.cBNB.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumCanales
            // 
            this.NumCanales.AutoSize = true;
            this.NumCanales.Location = new System.Drawing.Point(81, 305);
            this.NumCanales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumCanales.Name = "NumCanales";
            this.NumCanales.Size = new System.Drawing.Size(79, 13);
            this.NumCanales.TabIndex = 7;
            this.NumCanales.Text = "No. de canales";
            // 
            // TasaCompresion
            // 
            this.TasaCompresion.AutoSize = true;
            this.TasaCompresion.Location = new System.Drawing.Point(81, 223);
            this.TasaCompresion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TasaCompresion.Name = "TasaCompresion";
            this.TasaCompresion.Size = new System.Drawing.Size(103, 13);
            this.TasaCompresion.TabIndex = 6;
            this.TasaCompresion.Text = "Tasa de compresion";
            // 
            // FrecMax
            // 
            this.FrecMax.AutoSize = true;
            this.FrecMax.Location = new System.Drawing.Point(81, 150);
            this.FrecMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FrecMax.Name = "FrecMax";
            this.FrecMax.Size = new System.Drawing.Size(99, 13);
            this.FrecMax.TabIndex = 5;
            this.FrecMax.Text = "Frecuencia Maxima";
            // 
            // NumBits
            // 
            this.NumBits.AutoSize = true;
            this.NumBits.Location = new System.Drawing.Point(81, 74);
            this.NumBits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumBits.Name = "NumBits";
            this.NumBits.Size = new System.Drawing.Size(59, 13);
            this.NumBits.TabIndex = 4;
            this.NumBits.Text = "No. de Bits";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labelTasaCompVideo);
            this.groupBox2.Controls.Add(this.trackBarVideo);
            this.groupBox2.Controls.Add(this.cBCS);
            this.groupBox2.Controls.Add(this.cBRT);
            this.groupBox2.Controls.Add(this.cBPC);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textHF);
            this.groupBox2.Controls.Add(this.textHI);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(395, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(335, 655);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cBCS
            // 
            this.cBCS.FormattingEnabled = true;
            this.cBCS.Items.AddRange(new object[] {
            "14",
            "24",
            "30",
            "60"});
            this.cBCS.Location = new System.Drawing.Point(214, 217);
            this.cBCS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBCS.Name = "cBCS";
            this.cBCS.Size = new System.Drawing.Size(92, 21);
            this.cBCS.TabIndex = 15;
            // 
            // cBRT
            // 
            this.cBRT.FormattingEnabled = true;
            this.cBRT.Items.AddRange(new object[] {
            "320X240",
            "640X480",
            "1920X1080",
            "2048X1080",
            "4096X2160"});
            this.cBRT.Location = new System.Drawing.Point(214, 143);
            this.cBRT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBRT.Name = "cBRT";
            this.cBRT.Size = new System.Drawing.Size(92, 21);
            this.cBRT.TabIndex = 14;
            // 
            // cBPC
            // 
            this.cBPC.FormattingEnabled = true;
            this.cBPC.Items.AddRange(new object[] {
            "1",
            "4",
            "8",
            "24",
            "32"});
            this.cBPC.Location = new System.Drawing.Point(214, 67);
            this.cBPC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBPC.Name = "cBPC";
            this.cBPC.Size = new System.Drawing.Size(92, 21);
            this.cBPC.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 419);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Duracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 541);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hora final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 460);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hora inicial";
            // 
            // textHF
            // 
            this.textHF.Location = new System.Drawing.Point(214, 539);
            this.textHF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textHF.Name = "textHF";
            this.textHF.Size = new System.Drawing.Size(76, 20);
            this.textHF.TabIndex = 9;
            // 
            // textHI
            // 
            this.textHI.Location = new System.Drawing.Point(214, 460);
            this.textHI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textHI.Name = "textHI";
            this.textHI.Size = new System.Drawing.Size(76, 20);
            this.textHI.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tasa de compresion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cuadros por segundo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resolucion o tamaño\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Profundidad de color";
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.Items.AddRange(new object[] {
            " "});
            this.LB1.Location = new System.Drawing.Point(763, 28);
            this.LB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(290, 433);
            this.LB1.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(96, 248);
            this.trackBar1.Maximum = 99;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(234, 45);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labeTasaCompAudio
            // 
            this.labeTasaCompAudio.AutoSize = true;
            this.labeTasaCompAudio.Location = new System.Drawing.Point(240, 221);
            this.labeTasaCompAudio.Name = "labeTasaCompAudio";
            this.labeTasaCompAudio.Size = new System.Drawing.Size(13, 13);
            this.labeTasaCompAudio.TabIndex = 19;
            this.labeTasaCompAudio.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "%";
            // 
            // trackBarVideo
            // 
            this.trackBarVideo.Location = new System.Drawing.Point(72, 332);
            this.trackBarVideo.Maximum = 99;
            this.trackBarVideo.Name = "trackBarVideo";
            this.trackBarVideo.Size = new System.Drawing.Size(234, 45);
            this.trackBarVideo.TabIndex = 19;
            this.trackBarVideo.Scroll += new System.EventHandler(this.trackBarVideo_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "%";
            // 
            // labelTasaCompVideo
            // 
            this.labelTasaCompVideo.AutoSize = true;
            this.labelTasaCompVideo.Location = new System.Drawing.Point(225, 294);
            this.labelTasaCompVideo.Name = "labelTasaCompVideo";
            this.labelTasaCompVideo.Size = new System.Drawing.Size(13, 13);
            this.labelTasaCompVideo.TabIndex = 21;
            this.labelTasaCompVideo.Text = "0";
            // 
            // Calculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 725);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Calculos";
            this.Text = "Calculos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NumCanales;
        private System.Windows.Forms.Label TasaCompresion;
        private System.Windows.Forms.Label FrecMax;
        private System.Windows.Forms.Label NumBits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textHF;
        private System.Windows.Forms.TextBox textHI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cBNB;
        private System.Windows.Forms.ComboBox cBNC;
        private System.Windows.Forms.ComboBox cBFM;
        private System.Windows.Forms.ComboBox cBCS;
        private System.Windows.Forms.ComboBox cBRT;
        private System.Windows.Forms.ComboBox cBPC;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labeTasaCompAudio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTasaCompVideo;
        private System.Windows.Forms.TrackBar trackBarVideo;
    }
}