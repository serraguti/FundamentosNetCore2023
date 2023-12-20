namespace Fundamentos
{
    partial class Form08ValidarIsbn
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
            txtIsbn = new TextBox();
            btnValidarIsbn = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 19);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 0;
            label1.Text = "Introduzca ISBN";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(39, 54);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(399, 39);
            txtIsbn.TabIndex = 1;
            // 
            // btnValidarIsbn
            // 
            btnValidarIsbn.Location = new Point(122, 116);
            btnValidarIsbn.Name = "btnValidarIsbn";
            btnValidarIsbn.Size = new Size(212, 46);
            btnValidarIsbn.TabIndex = 2;
            btnValidarIsbn.Text = "Validar ISBN";
            btnValidarIsbn.UseVisualStyleBackColor = true;
            btnValidarIsbn.Click += btnValidarIsbn_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(50, 195);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(130, 32);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form08ValidarIsbn
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 267);
            Controls.Add(lblMensaje);
            Controls.Add(btnValidarIsbn);
            Controls.Add(txtIsbn);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form08ValidarIsbn";
            Text = "Form08ValidarIsbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIsbn;
        private Button btnValidarIsbn;
        private Label lblMensaje;
    }
}