namespace AgendaClientes
{
    partial class FormAgregar
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
            labelSubtitulo = new Label();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            labelTelefono = new Label();
            textBoxTelefono = new TextBox();
            labelEmpresa = new Label();
            textBoxEmpresa = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            buttonAgregar = new Button();
            buttonLimpiar = new Button();
            buttonRegresar = new Button();
            SuspendLayout();
            // 
            // labelSubtitulo
            // 
            labelSubtitulo.BackColor = Color.LightGray;
            labelSubtitulo.Dock = DockStyle.Top;
            labelSubtitulo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSubtitulo.ForeColor = Color.Black;
            labelSubtitulo.Location = new Point(0, 75);
            labelSubtitulo.Name = "labelSubtitulo";
            labelSubtitulo.Size = new Size(800, 55);
            labelSubtitulo.TabIndex = 2;
            labelSubtitulo.Text = "Agregar cliente";
            labelSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(150, 160);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(95, 31);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(360, 153);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(300, 38);
            textBoxNombre.TabIndex = 4;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefono.Location = new Point(150, 220);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(103, 31);
            labelTelefono.TabIndex = 5;
            labelTelefono.Text = "Teléfono";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTelefono.Location = new Point(360, 213);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(300, 38);
            textBoxTelefono.TabIndex = 6;
            // 
            // labelEmpresa
            // 
            labelEmpresa.AutoSize = true;
            labelEmpresa.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmpresa.Location = new Point(150, 280);
            labelEmpresa.Name = "labelEmpresa";
            labelEmpresa.Size = new Size(99, 31);
            labelEmpresa.TabIndex = 7;
            labelEmpresa.Text = "Empresa";
            // 
            // textBoxEmpresa
            // 
            textBoxEmpresa.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEmpresa.Location = new Point(360, 273);
            textBoxEmpresa.Name = "textBoxEmpresa";
            textBoxEmpresa.Size = new Size(300, 38);
            textBoxEmpresa.TabIndex = 8;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(150, 340);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(66, 31);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(360, 333);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(300, 38);
            textBoxEmail.TabIndex = 10;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.Green;
            buttonAgregar.FlatAppearance.BorderColor = Color.Black;
            buttonAgregar.FlatAppearance.BorderSize = 3;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(330, 441);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(150, 47);
            buttonAgregar.TabIndex = 11;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.DarkGoldenrod;
            buttonLimpiar.FlatAppearance.BorderColor = Color.Black;
            buttonLimpiar.FlatAppearance.BorderSize = 3;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiar.ForeColor = Color.White;
            buttonLimpiar.Location = new Point(500, 441);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(150, 47);
            buttonLimpiar.TabIndex = 12;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRegresar.BackColor = Color.DimGray;
            buttonRegresar.FlatAppearance.BorderColor = Color.Black;
            buttonRegresar.FlatAppearance.BorderSize = 3;
            buttonRegresar.FlatStyle = FlatStyle.Flat;
            buttonRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.ForeColor = Color.White;
            buttonRegresar.Location = new Point(12, 441);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(130, 47);
            buttonRegresar.TabIndex = 13;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmpresa);
            Controls.Add(labelEmpresa);
            Controls.Add(textBoxTelefono);
            Controls.Add(labelTelefono);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Controls.Add(labelSubtitulo);
            Name = "FormAgregar";
            Text = "Agenda de clientes";
            Controls.SetChildIndex(labelSubtitulo, 0);
            Controls.SetChildIndex(labelNombre, 0);
            Controls.SetChildIndex(textBoxNombre, 0);
            Controls.SetChildIndex(labelTelefono, 0);
            Controls.SetChildIndex(textBoxTelefono, 0);
            Controls.SetChildIndex(labelEmpresa, 0);
            Controls.SetChildIndex(textBoxEmpresa, 0);
            Controls.SetChildIndex(labelEmail, 0);
            Controls.SetChildIndex(textBoxEmail, 0);
            Controls.SetChildIndex(buttonAgregar, 0);
            Controls.SetChildIndex(buttonLimpiar, 0);
            Controls.SetChildIndex(buttonRegresar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSubtitulo;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Label labelEmpresa;
        private TextBox textBoxEmpresa;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Button buttonAgregar;
        private Button buttonLimpiar;
        private Button buttonRegresar;
    }
}
