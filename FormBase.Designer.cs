namespace AgendaClientes
{
    partial class FormBase
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
            labelTitulo = new Label();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.BackColor = Color.DarkSlateGray;
            labelTitulo.Dock = DockStyle.Top;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(0, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(800, 75);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Agenda de clientes personalizada";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSalir
            // 
            buttonSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalir.BackColor = Color.Firebrick;
            buttonSalir.FlatAppearance.BorderColor = Color.Black;
            buttonSalir.FlatAppearance.BorderSize = 3;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.ForeColor = Color.White;
            buttonSalir.Location = new Point(681, 391);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(107, 47);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalir);
            Controls.Add(labelTitulo);
            Name = "FormBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de Clientes";
            Load += FormBase_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitulo;
        private Button buttonSalir;
    }
}