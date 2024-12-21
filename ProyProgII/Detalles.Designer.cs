namespace ProyProgII
{
    partial class Detalles
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
            item1 = new Panel();
            id = new Label();
            img = new PictureBox();
            nom = new Label();
            panel1 = new Panel();
            btnBorrar = new Button();
            label1 = new Label();
            btnVolver = new Button();
            btnComprar = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            ex = new Label();
            des = new Label();
            precio = new Label();
            item1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            //
            // Detalles_Load
            //
            this.Load += new System.EventHandler(this.Detalles_Load);

            // 
            // item1
            // 
            item1.BackColor = Color.MidnightBlue;
            item1.Controls.Add(id);
            item1.Controls.Add(img);
            item1.Controls.Add(nom);
            item1.Location = new Point(12, 57);
            item1.Name = "item1";
            item1.Size = new Size(275, 297);
            item1.TabIndex = 2;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id.ForeColor = SystemColors.ButtonFace;
            id.Location = new Point(108, 275);
            id.Name = "id";
            id.Size = new Size(17, 13);
            id.TabIndex = 12;
            id.Text = "Id";
            // 
            // img
            // 
            img.Location = new Point(24, 24);
            img.Name = "img";
            img.Size = new Size(213, 197);
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.TabIndex = 0;
            img.TabStop = false;
            // 
            // nom
            // 
            nom.AutoSize = true;
            nom.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nom.ForeColor = SystemColors.ButtonFace;
            nom.Location = new Point(108, 248);
            nom.Name = "nom";
            nom.Size = new Size(50, 13);
            nom.TabIndex = 10;
            nom.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnBorrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnComprar);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ex);
            panel1.Controls.Add(des);
            panel1.Controls.Add(precio);
            panel1.Location = new Point(319, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 322);
            panel1.TabIndex = 3;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(184, 274);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(86, 23);
            btnBorrar.TabIndex = 31;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(336, 223);
            label1.Name = "label1";
            label1.Size = new Size(112, 13);
            label1.TabIndex = 30;
            label1.Text = "Cantidad a comprar:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(22, 274);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 23);
            btnVolver.TabIndex = 29;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(359, 276);
            btnComprar.Margin = new Padding(3, 2, 3, 2);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(82, 22);
            btnComprar.TabIndex = 28;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(381, 248);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "0";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(36, 23);
            textBox1.TabIndex = 27;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.Location = new Point(422, 248);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(26, 22);
            button2.TabIndex = 26;
            button2.Text = "+";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.Location = new Point(349, 248);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(26, 22);
            button1.TabIndex = 25;
            button1.Text = "-";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ex
            // 
            ex.AutoSize = true;
            ex.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ex.ForeColor = SystemColors.ButtonFace;
            ex.Location = new Point(204, 33);
            ex.Name = "ex";
            ex.Size = new Size(66, 13);
            ex.TabIndex = 13;
            ex.Text = "Existencias:";
            // 
            // des
            // 
            des.AutoSize = true;
            des.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            des.ForeColor = SystemColors.ButtonFace;
            des.Location = new Point(41, 75);
            des.Name = "des";
            des.Size = new Size(67, 13);
            des.TabIndex = 12;
            des.Text = "Descripción";
            // 
            // precio
            // 
            precio.AutoSize = true;
            precio.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            precio.ForeColor = SystemColors.ButtonFace;
            precio.Location = new Point(41, 33);
            precio.Name = "precio";
            precio.Size = new Size(39, 13);
            precio.TabIndex = 11;
            precio.Text = "Precio";
            // 
            // Detalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(item1);
            Name = "Detalles";
            Text = "Detalles del producto";
            item1.ResumeLayout(false);
            item1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel item1;
        private PictureBox img;
        private Label nom;
        private Panel panel1;
        private Label ex;
        private Label des;
        private Label precio;
        private Label id;
        private Button btnComprar;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Button btnVolver;
        private Button btnBorrar;
        private Label label1;
    }
}