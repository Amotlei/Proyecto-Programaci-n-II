namespace ProyProgII
{
    partial class Alta
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
            panel2 = new Panel();
            btnVolver = new Button();
            label3 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            panel1 = new Panel();
            txtPrecio = new TextBox();
            txtExistencias = new TextBox();
            txtDescripcion = new TextBox();
            txtImagen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lblExistencias = new Label();
            lblPrecio = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(btnVolver);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 453);
            panel2.TabIndex = 9;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(61, 398);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 23);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 51);
            label3.Name = "label3";
            label3.Size = new Size(169, 13);
            label3.TabIndex = 10;
            label3.Text = "Registra una tupla de producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(27, 16);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 9;
            label2.Text = "Alta de productos";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(61, 328);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtExistencias);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtImagen);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblExistencias);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(326, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 420);
            panel1.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(164, 235);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio del producto";
            txtPrecio.Size = new Size(251, 23);
            txtPrecio.TabIndex = 20;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(164, 193);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.PlaceholderText = "Numero de existencias";
            txtExistencias.Size = new Size(251, 23);
            txtExistencias.TabIndex = 19;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(164, 150);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Breve descipcion del producto";
            txtDescripcion.Size = new Size(251, 23);
            txtDescripcion.TabIndex = 18;
            // 
            // txtImagen
            // 
            txtImagen.Location = new Point(164, 100);
            txtImagen.Name = "txtImagen";
            txtImagen.PlaceholderText = "Nombre de la imagen con su extension";
            txtImagen.Size = new Size(251, 23);
            txtImagen.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(57, 149);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 16;
            label5.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(57, 99);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 15;
            label4.Text = "Imagen";
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.ForeColor = SystemColors.ButtonFace;
            lblExistencias.Location = new Point(57, 196);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(85, 20);
            lblExistencias.TabIndex = 14;
            lblExistencias.Text = "Existencias";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = SystemColors.ButtonFace;
            lblPrecio.Location = new Point(57, 238);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(52, 20);
            lblPrecio.TabIndex = 12;
            lblPrecio.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(151, 28);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 10;
            label1.Text = "Registro del producto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(309, 328);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 23);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // Alta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Alta";
            Text = "Alta de productos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtProductoID;
        private Button btnBuscar;
        private Button btnCancelar;
        private Button btnVolver;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label lblExistencias;
        private Label lblPrecio;
        private Label label1;
        private TextBox txtPrecio;
        private TextBox txtExistencias;
        private TextBox txtDescripcion;
        private TextBox txtImagen;
        private Label label5;
        private Label label4;
        private Button btnGuardar;
    }
}