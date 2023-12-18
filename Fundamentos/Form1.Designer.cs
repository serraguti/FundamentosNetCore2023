namespace Fundamentos
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
            btnPulsar = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPulsar
            // 
            btnPulsar.BackColor = SystemColors.ActiveCaption;
            btnPulsar.Location = new Point(108, 117);
            btnPulsar.Margin = new Padding(6);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(139, 49);
            btnPulsar.TabIndex = 0;
            btnPulsar.Text = "Pulsar";
            btnPulsar.UseVisualStyleBackColor = false;
            btnPulsar.Click += btnPulsar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 39);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(381, 208);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnPulsar);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPulsar;
        private TextBox txtNombre;
        private Label label1;
    }
}
