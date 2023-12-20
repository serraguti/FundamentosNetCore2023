namespace Fundamentos
{
    partial class Form02PosicionColores
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
            label2 = new Label();
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            btnCambiarPosicion = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCambiarColor = new Button();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 24);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 0;
            label1.Text = "Posición X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 80);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 1;
            label2.Text = "Posición Y:";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(166, 19);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 39);
            txtPosicionX.TabIndex = 2;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(166, 73);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 39);
            txtPosicionY.TabIndex = 3;
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(24, 147);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(218, 51);
            btnCambiarPosicion.TabIndex = 4;
            btnCambiarPosicion.Text = "Cambiar Posición";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 19);
            label3.Name = "label3";
            label3.Size = new Size(61, 32);
            label3.TabIndex = 5;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 76);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 6;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(384, 139);
            label5.Name = "label5";
            label5.Size = new Size(60, 32);
            label5.TabIndex = 7;
            label5.Text = "Azul";
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(369, 198);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(239, 45);
            btnCambiarColor.TabIndex = 8;
            btnCambiarColor.Text = "Cambiar Color";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btnCambiarColor_Click;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(495, 12);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 39);
            txtRojo.TabIndex = 9;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(494, 73);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 39);
            txtVerde.TabIndex = 10;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(494, 132);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 39);
            txtAzul.TabIndex = 11;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 275);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(btnCambiarColor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(txtPosicionY);
            Controls.Add(txtPosicionX);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private Button btnCambiarPosicion;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCambiarColor;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
    }
}