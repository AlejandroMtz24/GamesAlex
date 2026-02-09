namespace GamesAlex
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
            groupBox4 = new GroupBox();
            btnEliminar = new Button();
            BuscarPla = new ComboBox();
            label8 = new Label();
            btnBuscar = new Button();
            groupBox3 = new GroupBox();
            BuscarNom = new TextBox();
            label7 = new Label();
            label1 = new Label();
            Inventario = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Plataforma = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtId = new TextBox();
            Sto = new NumericUpDown();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            Pre = new NumericUpDown();
            Cat = new ComboBox();
            Pla = new ComboBox();
            Nom = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label9 = new Label();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Inventario).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Sto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pre).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(255, 128, 128);
            groupBox4.Controls.Add(btnEliminar);
            groupBox4.Location = new Point(13, 459);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1071, 59);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Eliminar videojuego";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(15, 17);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(1050, 42);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar Videojuego (Tener mucho cuidado de no borrar algo con lo que te puedas arrepentir :(";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // BuscarPla
            // 
            BuscarPla.DropDownStyle = ComboBoxStyle.DropDownList;
            BuscarPla.FormattingEnabled = true;
            BuscarPla.Items.AddRange(new object[] { "PlayStation 4", "PlayStation 5", "Xbox Series S", "Xbox Series X", "Nintendo Switch", "Nintendo Switch 2" });
            BuscarPla.Location = new Point(154, 73);
            BuscarPla.Name = "BuscarPla";
            BuscarPla.Size = new Size(325, 23);
            BuscarPla.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(6, 76);
            label8.Name = "label8";
            label8.Size = new Size(142, 15);
            label8.TabIndex = 16;
            label8.Text = "Plataforma del videjuego:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 255);
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(530, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 73);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkOrange;
            groupBox3.Controls.Add(BuscarPla);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(BuscarNom);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(406, 56);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(685, 108);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar videojuego";
            // 
            // BuscarNom
            // 
            BuscarNom.Location = new Point(154, 22);
            BuscarNom.Name = "BuscarNom";
            BuscarNom.Size = new Size(325, 23);
            BuscarNom.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(6, 29);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 13;
            label7.Text = "Nombre del videjuego";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(481, 37);
            label1.TabIndex = 17;
            label1.Text = "Control de inventario de GamesAlex";
            // 
            // Inventario
            // 
            Inventario.AllowUserToResizeColumns = false;
            Inventario.AllowUserToResizeRows = false;
            Inventario.BackgroundColor = Color.FromArgb(192, 255, 192);
            Inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Inventario.Columns.AddRange(new DataGridViewColumn[] { Nombre, Plataforma, Precio, Stock, Categoria });
            Inventario.GridColor = SystemColors.MenuHighlight;
            Inventario.Location = new Point(12, 22);
            Inventario.Name = "Inventario";
            Inventario.Size = new Size(666, 226);
            Inventario.TabIndex = 0;
            Inventario.CellClick += Inventario_CellClick;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 200;
            // 
            // Plataforma
            // 
            Plataforma.DataPropertyName = "Plataforma";
            Plataforma.HeaderText = "Plataforma";
            Plataforma.Name = "Plataforma";
            Plataforma.Width = 120;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 192, 255);
            groupBox2.Controls.Add(Inventario);
            groupBox2.Location = new Point(406, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(685, 254);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inventario de GamesAlex";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(255, 192, 192);
            txtId.Location = new Point(0, 359);
            txtId.Name = "txtId";
            txtId.Size = new Size(21, 23);
            txtId.TabIndex = 16;
            txtId.Visible = false;
            // 
            // Sto
            // 
            Sto.Location = new Point(180, 173);
            Sto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            Sto.Name = "Sto";
            Sto.Size = new Size(192, 23);
            Sto.TabIndex = 14;
            Sto.KeyPress += Sto_KeyPress;
            Sto.Leave += Sto_Leave;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 255, 128);
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(121, 340);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(142, 42);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar/Reiniciar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(128, 255, 128);
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(230, 269);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(142, 42);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar videojuego";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 255);
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(16, 269);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(142, 42);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar videojuego";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Pre
            // 
            Pre.DecimalPlaces = 2;
            Pre.Location = new Point(180, 126);
            Pre.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            Pre.Name = "Pre";
            Pre.Size = new Size(133, 23);
            Pre.TabIndex = 8;
            Pre.ThousandsSeparator = true;
            Pre.KeyPress += Pre_KeyPress;
            Pre.Leave += Pre_Leave;
            // 
            // Cat
            // 
            Cat.DropDownStyle = ComboBoxStyle.DropDownList;
            Cat.FormattingEnabled = true;
            Cat.Items.AddRange(new object[] { "Acción", "Aventura", "RPG", "Deportes", "Estrategia", "Shooter", "Lucha", "Carreras", "Terror", "Simulación" });
            Cat.Location = new Point(180, 215);
            Cat.Name = "Cat";
            Cat.Size = new Size(192, 23);
            Cat.TabIndex = 7;
            // 
            // Pla
            // 
            Pla.DropDownStyle = ComboBoxStyle.DropDownList;
            Pla.FormattingEnabled = true;
            Pla.Items.AddRange(new object[] { "PlayStation 4", "PlayStation 5", "Xbox Series S", "Xbox Series X", "Nintendo Switch", "Nintendo Switch 2" });
            Pla.Location = new Point(180, 85);
            Pla.Name = "Pla";
            Pla.Size = new Size(192, 23);
            Pla.TabIndex = 6;
            // 
            // Nom
            // 
            Nom.Location = new Point(180, 38);
            Nom.Name = "Nom";
            Nom.Size = new Size(192, 23);
            Nom.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(16, 220);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 4;
            label6.Text = "Categoria del videjuego:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(16, 175);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 3;
            label5.Text = "Stock del videjuego:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(16, 130);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 2;
            label4.Text = "Precio del videjuego:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(16, 90);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 1;
            label3.Text = "Plataforma del videjuego:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(16, 43);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre del videjuego:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 255);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(Sto);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(Pre);
            groupBox1.Controls.Add(Cat);
            groupBox1.Controls.Add(Pla);
            groupBox1.Controls.Add(Nom);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 382);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar/Actualizar videojuego";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(319, 130);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 17;
            label9.Text = "Pesos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 527);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Inventario).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Sto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pre).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox4;
        private Button btnEliminar;
        private ComboBox BuscarPla;
        private Label label8;
        private Button btnBuscar;
        private GroupBox groupBox3;
        private TextBox BuscarNom;
        private Label label7;
        private Label label1;
        private DataGridView Inventario;
        private GroupBox groupBox2;
        private TextBox txtId;
        private NumericUpDown Sto;
        private Button btnLimpiar;
        private Button btnActualizar;
        private Button btnAgregar;
        private NumericUpDown Pre;
        private ComboBox Cat;
        private ComboBox Pla;
        private TextBox Nom;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Plataforma;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Categoria;
        private Label label9;
    }
}
