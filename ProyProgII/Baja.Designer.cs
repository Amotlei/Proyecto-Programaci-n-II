namespace ProyProgII
{
    partial class Baja
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
            txtProductoID = new TextBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lblExistencias = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            pbImagen = new PictureBox();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(txtProductoID);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnVolver);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-1, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 453);
            panel2.TabIndex = 7;
            // 
            // txtProductoID
            // 
            txtProductoID.Location = new Point(54, 128);
            txtProductoID.Name = "txtProductoID";
            txtProductoID.PlaceholderText = "ID del producto";
            txtProductoID.Size = new Size(99, 23);
            txtProductoID.TabIndex = 14;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(61, 197);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(61, 251);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(61, 398);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 23);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(34, 51);
            label3.Name = "label3";
            label3.Size = new Size(113, 13);
            label3.TabIndex = 10;
            label3.Text = "Los elimina por el ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(27, 16);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 9;
            label2.Text = "Baja de productos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lblExistencias);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(pbImagen);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(325, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 420);
            panel1.TabIndex = 6;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.ForeColor = SystemColors.ButtonFace;
            lblExistencias.Location = new Point(227, 140);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(85, 20);
            lblExistencias.TabIndex = 14;
            lblExistencias.Text = "Existencias";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = SystemColors.ButtonFace;
            lblDescripcion.Location = new Point(46, 256);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(66, 13);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = SystemColors.ButtonFace;
            lblPrecio.Location = new Point(227, 79);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(52, 20);
            lblPrecio.TabIndex = 12;
            lblPrecio.Text = "Precio";
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(46, 79);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(159, 157);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 11;
            pbImagen.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(152, 30);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 10;
            label1.Text = "Datos del producto";
            // 
            // Baja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Baja";
            Text = "Baja de productos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtProductoID;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnVolver;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label lblExistencias;
        private Label lblDescripcion;
        private Label lblPrecio;
        private PictureBox pbImagen;
        private Label label1;
    }
}