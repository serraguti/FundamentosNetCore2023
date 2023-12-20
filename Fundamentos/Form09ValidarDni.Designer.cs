namespace Fundamentos
{
    partial class Form09ValidarDni
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
            txtDni = new TextBox();
            btnValidarDni = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 0;
            label1.Text = "Introduzca DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(47, 44);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(369, 39);
            txtDni.TabIndex = 1;
            // 
            // btnValidarDni
            // 
            btnValidarDni.Location = new Point(122, 102);
            btnValidarDni.Name = "btnValidarDni";
            btnValidarDni.Size = new Size(210, 51);
            btnValidarDni.TabIndex = 2;
            btnValidarDni.Text = "Validar DNI";
            btnValidarDni.UseVisualStyleBackColor = true;
            btnValidarDni.Click += btnValidarDni_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(47, 198);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(144, 32);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form09ValidarDni
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 303);
            Controls.Add(lblResultado);
            Controls.Add(btnValidarDni);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form09ValidarDni";
            Text = "Form09ValidarDni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDni;
        private Button btnValidarDni;
        private Label lblResultado;
    }
}