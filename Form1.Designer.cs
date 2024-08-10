namespace RegistroContactosApp
{
    partial class Form1
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
            EtiquetaNombre = new Label();
            EtiquetaTelefono = new Label();
            EtiquetaEmail = new Label();
            TextBoxNombre = new TextBox();
            TextBoxTelefono = new TextBox();
            TextBoxEmail = new TextBox();
            ButtonAgregar = new Button();
            ButtonLimpiar = new Button();
            ListBoxContactos = new ListBox();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.BackColor = Color.Crimson;
            EtiquetaNombre.Font = new Font("Segoe UI", 11F);
            EtiquetaNombre.ForeColor = Color.Cornsilk;
            EtiquetaNombre.Location = new Point(85, 6);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(64, 20);
            EtiquetaNombre.TabIndex = 0;
            EtiquetaNombre.Text = "Nombre";
            // 
            // EtiquetaTelefono
            // 
            EtiquetaTelefono.AutoSize = true;
            EtiquetaTelefono.BackColor = Color.Crimson;
            EtiquetaTelefono.Font = new Font("Segoe UI", 11F);
            EtiquetaTelefono.ForeColor = Color.Cornsilk;
            EtiquetaTelefono.Location = new Point(82, 66);
            EtiquetaTelefono.Name = "EtiquetaTelefono";
            EtiquetaTelefono.Size = new Size(67, 20);
            EtiquetaTelefono.TabIndex = 1;
            EtiquetaTelefono.Text = "Teléfono";
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.BackColor = Color.Crimson;
            EtiquetaEmail.Font = new Font("Segoe UI", 11F);
            EtiquetaEmail.ForeColor = Color.Cornsilk;
            EtiquetaEmail.Location = new Point(55, 129);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(132, 20);
            EtiquetaEmail.TabIndex = 2;
            EtiquetaEmail.Text = "Correo Electrónico";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(1, 29);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(246, 23);
            TextBoxNombre.TabIndex = 3;
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(1, 89);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.Size = new Size(246, 23);
            TextBoxTelefono.TabIndex = 4;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(-1, 152);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(246, 23);
            TextBoxEmail.TabIndex = 5;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.BackColor = SystemColors.ControlText;
            ButtonAgregar.ForeColor = Color.Cornsilk;
            ButtonAgregar.Location = new Point(1, 196);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(88, 43);
            ButtonAgregar.TabIndex = 6;
            ButtonAgregar.Text = "Agregar Contacto";
            ButtonAgregar.UseVisualStyleBackColor = false;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // ButtonLimpiar
            // 
            ButtonLimpiar.BackColor = SystemColors.ControlText;
            ButtonLimpiar.ForeColor = Color.Cornsilk;
            ButtonLimpiar.Location = new Point(157, 196);
            ButtonLimpiar.Name = "ButtonLimpiar";
            ButtonLimpiar.Size = new Size(88, 43);
            ButtonLimpiar.TabIndex = 7;
            ButtonLimpiar.Text = "Limpiar Campos";
            ButtonLimpiar.UseVisualStyleBackColor = false;
            ButtonLimpiar.Click += ButtonLimpiar_Click;
            // 
            // ListBoxContactos
            // 
            ListBoxContactos.BackColor = Color.Aquamarine;
            ListBoxContactos.Cursor = Cursors.SizeWE;
            ListBoxContactos.Font = new Font("Segoe UI", 8F);
            ListBoxContactos.ForeColor = Color.Black;
            ListBoxContactos.FormattingEnabled = true;
            ListBoxContactos.ItemHeight = 13;
            ListBoxContactos.Location = new Point(253, 12);
            ListBoxContactos.Name = "ListBoxContactos";
            ListBoxContactos.Size = new Size(520, 316);
            ListBoxContactos.TabIndex = 8;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.BackColor = Color.Cornsilk;
            LabelEstado.Location = new Point(68, 253);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(106, 15);
            LabelEstado.TabIndex = 9;
            LabelEstado.Text = "¿Mensaje Enviado?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelEstado);
            Controls.Add(ListBoxContactos);
            Controls.Add(ButtonLimpiar);
            Controls.Add(ButtonAgregar);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxTelefono);
            Controls.Add(TextBoxNombre);
            Controls.Add(EtiquetaEmail);
            Controls.Add(EtiquetaTelefono);
            Controls.Add(EtiquetaNombre);
            Cursor = Cursors.Cross;
            Name = "Form1";
            Text = "Registro de Contactos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label EtiquetaNombre;
        private System.Windows.Forms.Label EtiquetaTelefono;
        private System.Windows.Forms.Label EtiquetaEmail;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.TextBox TextBoxTelefono;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Button ButtonAgregar;
        private System.Windows.Forms.Button ButtonLimpiar;
        private System.Windows.Forms.ListBox ListBoxContactos;
        private System.Windows.Forms.Label LabelEstado;
    }
}
