namespace ProyProgII
{
    partial class portada
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelFechaHora = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            //portada_Load
            this.Load += new System.EventHandler(this.portada_Load);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Uaa_logo;
            pictureBox1.Location = new Point(332, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(318, 372);
            button1.Name = "button1";
            button1.Size = new Size(180, 50);
            button1.TabIndex = 1;
            button1.Text = "Entrar a Strong&Fit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(342, 197);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 2;
            label1.Text = "Programacion II";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(294, 230);
            label2.Name = "label2";
            label2.Size = new Size(233, 21);
            label2.TabIndex = 3;
            label2.Text = "Dra. Georgina Salazar Partida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(307, 317);
            label3.Name = "label3";
            label3.Size = new Size(205, 21);
            label3.TabIndex = 5;
            label3.Text = "Luis Antonio García Gómez";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(355, 284);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 4;
            label4.Text = "Integrantes:";
            // 
            // labelFechaHora
            // 
            labelFechaHora.AutoSize = true;
            labelFechaHora.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFechaHora.ForeColor = SystemColors.ButtonFace;
            labelFechaHora.Location = new Point(30, 30);
            labelFechaHora.Name = "labelFechaHora";
            labelFechaHora.Size = new Size(108, 21);
            labelFechaHora.TabIndex = 6;
            labelFechaHora.Text = "Fecha y Hora";
            // 
            // portada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(labelFechaHora);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "portada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Portada";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelFechaHora;
    }
}
