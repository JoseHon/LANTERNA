namespace LANTERNA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LigaDesliga = new System.Windows.Forms.Button();
            this.Ligada = new System.Windows.Forms.PictureBox();
            this.Ldesligada = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Trocar = new System.Windows.Forms.Button();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.Pb2 = new System.Windows.Forms.PictureBox();
            this.Pb3 = new System.Windows.Forms.PictureBox();
            this.lbstatus = new System.Windows.Forms.Label();
            this.lbPer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ligada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ldesligada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // LigaDesliga
            // 
            this.LigaDesliga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LigaDesliga.Location = new System.Drawing.Point(541, 81);
            this.LigaDesliga.Name = "LigaDesliga";
            this.LigaDesliga.Size = new System.Drawing.Size(141, 62);
            this.LigaDesliga.TabIndex = 1;
            this.LigaDesliga.Text = "Liga/Desliga";
            this.LigaDesliga.UseVisualStyleBackColor = true;
            this.LigaDesliga.Click += new System.EventHandler(this.LigaDesliga_Click);
            // 
            // Ligada
            // 
            this.Ligada.Image = global::LANTERNA.Properties.Resources.Ligada;
            this.Ligada.Location = new System.Drawing.Point(114, 27);
            this.Ligada.Name = "Ligada";
            this.Ligada.Size = new System.Drawing.Size(146, 367);
            this.Ligada.TabIndex = 2;
            this.Ligada.TabStop = false;
            // 
            // Ldesligada
            // 
            this.Ldesligada.Image = global::LANTERNA.Properties.Resources.Desli;
            this.Ldesligada.Location = new System.Drawing.Point(89, 71);
            this.Ldesligada.Name = "Ldesligada";
            this.Ldesligada.Size = new System.Drawing.Size(185, 367);
            this.Ldesligada.TabIndex = 4;
            this.Ldesligada.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Trocar
            // 
            this.Trocar.Location = new System.Drawing.Point(541, 189);
            this.Trocar.Name = "Trocar";
            this.Trocar.Size = new System.Drawing.Size(141, 55);
            this.Trocar.TabIndex = 5;
            this.Trocar.Text = "Trocar bateria";
            this.Trocar.UseVisualStyleBackColor = true;
            this.Trocar.Click += new System.EventHandler(this.Trocar_Click);
            // 
            // Pb1
            // 
            this.Pb1.Image = global::LANTERNA.Properties.Resources.bat1;
            this.Pb1.Location = new System.Drawing.Point(356, 152);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(41, 50);
            this.Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb1.TabIndex = 6;
            this.Pb1.TabStop = false;
            // 
            // Pb2
            // 
            this.Pb2.Image = global::LANTERNA.Properties.Resources.bat2;
            this.Pb2.Location = new System.Drawing.Point(356, 152);
            this.Pb2.Name = "Pb2";
            this.Pb2.Size = new System.Drawing.Size(41, 50);
            this.Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb2.TabIndex = 7;
            this.Pb2.TabStop = false;
            // 
            // Pb3
            // 
            this.Pb3.Image = global::LANTERNA.Properties.Resources.bat3;
            this.Pb3.Location = new System.Drawing.Point(356, 152);
            this.Pb3.Name = "Pb3";
            this.Pb3.Size = new System.Drawing.Size(41, 50);
            this.Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb3.TabIndex = 8;
            this.Pb3.TabStop = false;
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Location = new System.Drawing.Point(356, 128);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(25, 15);
            this.lbstatus.TabIndex = 9;
            this.lbstatus.Text = "100";
            // 
            // lbPer
            // 
            this.lbPer.AutoSize = true;
            this.lbPer.Location = new System.Drawing.Point(380, 128);
            this.lbPer.Name = "lbPer";
            this.lbPer.Size = new System.Drawing.Size(17, 15);
            this.lbPer.TabIndex = 10;
            this.lbPer.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPer);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.Pb3);
            this.Controls.Add(this.Pb2);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.Trocar);
            this.Controls.Add(this.Ligada);
            this.Controls.Add(this.LigaDesliga);
            this.Controls.Add(this.Ldesligada);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ligada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ldesligada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LigaDesliga;
        private System.Windows.Forms.PictureBox Ligada;
        private System.Windows.Forms.PictureBox Ldesligada;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Trocar;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.PictureBox Pb2;
        private System.Windows.Forms.PictureBox Pb3;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Label lbPer;
    }
}
