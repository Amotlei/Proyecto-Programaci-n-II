namespace ProyProgII
{
    partial class Ventas
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
            lblMontoTotal = new Label();
            btnVolver = new Button();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(lblMontoTotal);
            panel2.Controls.Add(btnVolver);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(38, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 307);
            panel2.TabIndex = 7;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoTotal.ForeColor = SystemColors.ButtonFace;
            lblMontoTotal.Location = new Point(114, 143);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(108, 20);
            lblMontoTotal.TabIndex = 12;
            lblMontoTotal.Text = "Ventas totales";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(125, 233);
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
            label3.Location = new Point(56, 68);
            label3.Name = "label3";
            label3.Size = new Size(258, 13);
            label3.TabIndex = 10;
            label3.Text = "La suma de todos los montos en la tabla perfiles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(115, 28);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 9;
            label2.Text = "Ventas totales";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(410, 373);
            Controls.Add(panel2);
            Name = "Ventas";
            Text = "Total de ventas";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnVolver;
        private Label label3;
        private Label label2;
        private Label lblMontoTotal;
    }
}