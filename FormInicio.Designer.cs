namespace AgendaClientes
{
    partial class FormInicio
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
            labelSubtitulo = new Label();
            labelPropietario = new Label();
            textBoxPropietario = new TextBox();
            labelTelefono = new Label();
            textBoxTelefono = new TextBox();
            buttonContinuar = new Button();
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
            labelSubtitulo.Text = "Ingresa los datos del propietario";
            labelSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPropietario
            // 
            labelPropietario.AutoSize = true;
            labelPropietario.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPropietario.Location = new Point(130, 195);
            labelPropietario.Name = "labelPropietario";
            labelPropietario.Size = new Size(263, 31);
            labelPropietario.TabIndex = 3;
            labelPropietario.Text = "Nombre del propietario";
            // 
            // textBoxPropietario
            // 
            textBoxPropietario.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPropietario.Location = new Point(399, 188);
            textBoxPropietario.Name = "textBoxPropietario";
            textBoxPropietario.Size = new Size(222, 38);
            textBoxPropietario.TabIndex = 4;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefono.Location = new Point(130, 274);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(266, 31);
            labelTelefono.TabIndex = 5;
            labelTelefono.Text = "Teléfono del propietario";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTelefono.Location = new Point(402, 267);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(219, 38);
            textBoxTelefono.TabIndex = 6;
            // 
            // buttonContinuar
            // 
            buttonContinuar.BackColor = Color.Green;
            buttonContinuar.FlatAppearance.BorderColor = Color.Black;
            buttonContinuar.FlatAppearance.BorderSize = 3;
            buttonContinuar.FlatStyle = FlatStyle.Flat;
            buttonContinuar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContinuar.ForeColor = Color.White;
            buttonContinuar.Location = new Point(322, 389);
            buttonContinuar.Name = "buttonContinuar";
            buttonContinuar.Size = new Size(164, 48);
            buttonContinuar.TabIndex = 7;
            buttonContinuar.Text = "Continuar";
            buttonContinuar.UseVisualStyleBackColor = false;
            buttonContinuar.Click += this.buttonContinuar_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonContinuar);
            Controls.Add(textBoxTelefono);
            Controls.Add(labelTelefono);
            Controls.Add(textBoxPropietario);
            Controls.Add(labelPropietario);
            Controls.Add(labelSubtitulo);
            Name = "FormInicio";
            Text = "Agenda de clientes";
            Controls.SetChildIndex(labelSubtitulo, 0);
            Controls.SetChildIndex(labelPropietario, 0);
            Controls.SetChildIndex(textBoxPropietario, 0);
            Controls.SetChildIndex(labelTelefono, 0);
            Controls.SetChildIndex(textBoxTelefono, 0);
            Controls.SetChildIndex(buttonContinuar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSubtitulo;
        private Label labelPropietario;
        private TextBox textBoxPropietario;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Button buttonContinuar;
    }
}
