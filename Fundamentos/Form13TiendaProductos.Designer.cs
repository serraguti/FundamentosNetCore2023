namespace Fundamentos
{
    partial class Form13TiendaProductos
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
            btnBajar = new Button();
            btnSubir = new Button();
            btnTodos = new Button();
            btnSeleccionados = new Button();
            lstAlmacen = new ListBox();
            label3 = new Label();
            lstTienda = new ListBox();
            label2 = new Label();
            btnBorrarTodos = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtProducto = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(900, 166);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(120, 46);
            btnBajar.TabIndex = 27;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(899, 105);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(121, 47);
            btnSubir.TabIndex = 26;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(518, 215);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(105, 50);
            btnTodos.TabIndex = 25;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(518, 146);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(105, 52);
            btnSeleccionados.TabIndex = 24;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.ItemHeight = 32;
            lstAlmacen.Location = new Point(629, 63);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(253, 324);
            lstAlmacen.TabIndex = 23;
            lstAlmacen.SelectedIndexChanged += lstAlmacen_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(626, 32);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 22;
            label3.Text = "Productos";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.ItemHeight = 32;
            lstTienda.Location = new Point(256, 63);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(247, 324);
            lstTienda.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 30);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 20;
            label2.Text = "Tienda";
            // 
            // btnBorrarTodos
            // 
            btnBorrarTodos.Location = new Point(29, 330);
            btnBorrarTodos.Name = "btnBorrarTodos";
            btnBorrarTodos.Size = new Size(193, 51);
            btnBorrarTodos.TabIndex = 19;
            btnBorrarTodos.Text = "Borrar todos";
            btnBorrarTodos.UseVisualStyleBackColor = true;
            btnBorrarTodos.Click += btnBorrarTodos_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(29, 263);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(193, 51);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(27, 199);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(195, 49);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(26, 133);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(196, 48);
            btnInsertar.TabIndex = 16;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(25, 72);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(197, 39);
            txtProducto.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 37);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 14;
            label1.Text = "Producto";
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 466);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccionados);
            Controls.Add(lstAlmacen);
            Controls.Add(label3);
            Controls.Add(lstTienda);
            Controls.Add(label2);
            Controls.Add(btnBorrarTodos);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBajar;
        private Button btnSubir;
        private Button btnTodos;
        private Button btnSeleccionados;
        private ListBox lstAlmacen;
        private Label label3;
        private ListBox lstTienda;
        private Label label2;
        private Button btnBorrarTodos;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtProducto;
        private Label label1;
    }
}