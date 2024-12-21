namespace ProyProgII
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos.
            if (string.IsNullOrWhiteSpace(textBoxUser.Text) || string.IsNullOrWhiteSpace(textBoxPass.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.",
                    "Campos Vacíos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Crear una instancia de la base de datos.
            using (FitDatabase data = new FitDatabase())
            {
                // Llamar al método para verificar la cuenta.
                Perfiles perfil = data.VerifyAccount(this.textBoxUser.Text, this.textBoxPass.Text);

                // Evaluar si la cuenta es válida.
                if (perfil != null)
                {
                    // Obtener los datos necesarios del perfil.
                    int perfilId = perfil.Id; // Asumimos que `Perfiles` tiene una propiedad `Id`.
                    string nombreUsuario = perfil.Nombre;

                    MessageBox.Show("Inicio de sesión exitoso", "¡¡Bienvenido!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirigir según el perfil del usuario.
                    if (perfilId == 2) // Verificar si el usuario es admin.
                    {
                        // Crear y mostrar el formulario de administrador.
                        MenuAdmin menuAdminForm = new MenuAdmin(nombreUsuario);
                        menuAdminForm.Show();
                    }
                    else
                    {
                        // Crear y mostrar el formulario de productos.
                        Productos nuevoForm = new Productos(perfilId, nombreUsuario);
                        nuevoForm.Show();
                    }

                    // Cerrar o esconder el formulario actual.
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error, usuario o contraseña incorrectos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        private void btnVolver_Click(object sender, EventArgs e)
        {
            portada f2 = new portada();
            f2.Show();

            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSalir = new Button();
            btnVolver = new Button();
            textBoxPass = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSesion = new Button();
            textBoxUser = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(textBoxPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSesion);
            panel1.Controls.Add(textBoxUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(268, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 397);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(185, 352);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(21, 352);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(85, 23);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(68, 234);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PlaceholderText = "Ingrese contraseña";
            textBoxPass.Size = new Size(165, 23);
            textBoxPass.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(66, 92);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 5;
            label3.Text = "Lo mejor para ser más fuerte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(92, 145);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 4;
            label2.Text = "Inicio de sesion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(111, 61);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "Strong&Fit";
            // 
            // btnSesion
            // 
            btnSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSesion.Location = new Point(111, 283);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(85, 23);
            btnSesion.TabIndex = 2;
            btnSesion.Text = "Iniciar sesion";
            btnSesion.UseVisualStyleBackColor = true;
            btnSesion.Click += btnSesion_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(68, 186);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Ingrese usuario";
            textBoxUser.Size = new Size(165, 23);
            textBoxUser.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.weightlifting;
            pictureBox1.Location = new Point(125, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // inicio
            // 
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(803, 452);
            Controls.Add(panel1);
            Name = "inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Inicio de Sesion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label label1;
        private Button btnSesion;
        private TextBox textBoxUser;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private Button btnVolver;
        private TextBox textBoxPass;
        private Label label3;
        private Label label2;
    }
}
