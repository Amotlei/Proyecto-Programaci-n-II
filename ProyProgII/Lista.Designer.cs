namespace ProyProgII
{
    partial class Lista
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
            panel1 = new Panel();
            dataGridViewProductos = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(btnVolver);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-2, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 426);
            panel2.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(34, 216);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 23);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(4, 57);
            label3.Name = "label3";
            label3.Size = new Size(161, 13);
            label3.TabIndex = 10;
            label3.Text = "Existencias de menor a mayor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 25);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 9;
            label2.Text = "Lista de productos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(dataGridViewProductos);
            panel1.Location = new Point(193, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 393);
            panel1.TabIndex = 4;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(30, 23);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.Size = new Size(516, 343);
            dataGridViewProductos.TabIndex = 0;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(795, 417);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Lista";
            Text = "Lista de productos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnVolver;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridViewProductos;
    }
}