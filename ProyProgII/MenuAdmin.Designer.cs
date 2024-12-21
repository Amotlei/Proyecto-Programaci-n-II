namespace ProyProgII
{
    partial class MenuAdmin
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
            panel1 = new Panel();
            labelFechaHora = new Label();
            labelUsuario = new Label();
            label1 = new Label();
            btnCerrar = new Button();
            label3 = new Label();
            label2 = new Label();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnGraficaExist = new Button();
            btnTotalVenta = new Button();
            btnListado = new Button();
            btnBaja = new Button();
            btnAlta = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(labelFechaHora);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 462);
            panel1.TabIndex = 1;
            // 
            // labelFechaHora
            // 
            labelFechaHora.AutoSize = true;
            labelFechaHora.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFechaHora.ForeColor = SystemColors.ButtonFace;
            labelFechaHora.Location = new Point(12, 204);
            labelFechaHora.Name = "labelFechaHora";
            labelFechaHora.Size = new Size(131, 13);
            labelFechaHora.TabIndex = 11;
            labelFechaHora.Text = "Da clic para ver la HORA";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = SystemColors.ButtonFace;
            labelUsuario.Location = new Point(12, 179);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(148, 13);
            labelUsuario.TabIndex = 10;
            labelUsuario.Text = "De clic para ver el USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 156);
            label1.Name = "label1";
            label1.Size = new Size(50, 13);
            label1.TabIndex = 9;
            label1.Text = "Usuario:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(41, 336);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(86, 23);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar sesion";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(3, 108);
            label3.Name = "label3";
            label3.Size = new Size(155, 13);
            label3.TabIndex = 7;
            label3.Text = "Lo mejor para ser más fuerte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(41, 88);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 6;
            label2.Text = "Strong&Fit";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(41, 375);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.weightlifting;
            pictureBox1.Location = new Point(48, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(btnGraficaExist);
            panel2.Controls.Add(btnTotalVenta);
            panel2.Controls.Add(btnListado);
            panel2.Controls.Add(btnBaja);
            panel2.Controls.Add(btnAlta);
            panel2.Location = new Point(282, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 311);
            panel2.TabIndex = 2;
            // 
            // btnGraficaExist
            // 
            btnGraficaExist.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGraficaExist.Location = new Point(118, 207);
            btnGraficaExist.Name = "btnGraficaExist";
            btnGraficaExist.Size = new Size(86, 44);
            btnGraficaExist.TabIndex = 13;
            btnGraficaExist.Text = "Grafica de existencias";
            btnGraficaExist.UseVisualStyleBackColor = true;
            btnGraficaExist.Click += btnGraficaExist_Click;
            // 
            // btnTotalVenta
            // 
            btnTotalVenta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalVenta.Location = new Point(186, 131);
            btnTotalVenta.Name = "btnTotalVenta";
            btnTotalVenta.Size = new Size(86, 44);
            btnTotalVenta.TabIndex = 12;
            btnTotalVenta.Text = "Ventas totales";
            btnTotalVenta.UseVisualStyleBackColor = true;
            btnTotalVenta.Click += btnTotalVenta_Click;
            // 
            // btnListado
            // 
            btnListado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListado.Location = new Point(47, 131);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(86, 44);
            btnListado.TabIndex = 11;
            btnListado.Text = "Lista de productos";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnListado_Click;
            // 
            // btnBaja
            // 
            btnBaja.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaja.Location = new Point(186, 60);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(86, 44);
            btnBaja.TabIndex = 10;
            btnBaja.Text = "Baja a producto";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnAlta
            // 
            btnAlta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlta.Location = new Point(47, 60);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(86, 44);
            btnAlta.TabIndex = 9;
            btnAlta.Text = "Alta a producto";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(718, 458);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu del administrador";
            Load += MenuAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelFechaHora;
        private Label labelUsuario;
        private Label label1;
        private Button btnCerrar;
        private Label label3;
        private Label label2;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnListado;
        private Button btnBaja;
        private Button btnAlta;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnGraficaExist;
        private Button btnTotalVenta;
    }
}