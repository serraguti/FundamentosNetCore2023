namespace Fundamentos
{
    partial class Form06ValidarMail
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
            label1 = new Label();
            txtEmail = new TextBox();
            btnValidarEmail = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 22);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 0;
            label1.Text = "Introduzca Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(66, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(394, 39);
            txtEmail.TabIndex = 1;
            // 
            // btnValidarEmail
            // 
            btnValidarEmail.Location = new Point(147, 117);
            btnValidarEmail.Name = "btnValidarEmail";
            btnValidarEmail.Size = new Size(215, 49);
            btnValidarEmail.TabIndex = 2;
            btnValidarEmail.Text = "Validar Email";
            btnValidarEmail.UseVisualStyleBackColor = true;
            btnValidarEmail.Click += btnValidarEmail_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = Color.Blue;
            lblResultado.Location = new Point(66, 208);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(144, 32);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form06ValidarMail
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 272);
            Controls.Add(lblResultado);
            Controls.Add(btnValidarEmail);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form06ValidarMail";
            Text = "Form06ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnValidarEmail;
        private Label lblResultado;
    }
}