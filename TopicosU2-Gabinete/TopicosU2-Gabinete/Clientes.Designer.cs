namespace TopicosU2_Gabinete
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.txtNombreCl = new System.Windows.Forms.TextBox();
            this.txtDireccionCl = new System.Windows.Forms.TextBox();
            this.txtDNICl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarCl = new System.Windows.Forms.Button();
            this.btnGuardarCl = new System.Windows.Forms.Button();
            this.txtApellidoCl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarCl = new System.Windows.Forms.Button();
            this.btnConsultaCl = new System.Windows.Forms.Button();
            this.btnActualizarCl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dNIClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanaccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abogadosDataSet1 = new TopicosU2_Gabinete.AbogadosDataSet1();
            this.clientesTableAdapter = new TopicosU2_Gabinete.AbogadosDataSet1TableAdapters.ClientesTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtFNCl = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abogadosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCl
            // 
            this.txtNombreCl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreCl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCl.Location = new System.Drawing.Point(275, 74);
            this.txtNombreCl.Name = "txtNombreCl";
            this.txtNombreCl.Size = new System.Drawing.Size(279, 22);
            this.txtNombreCl.TabIndex = 11;
            // 
            // txtDireccionCl
            // 
            this.txtDireccionCl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionCl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCl.Location = new System.Drawing.Point(275, 195);
            this.txtDireccionCl.Name = "txtDireccionCl";
            this.txtDireccionCl.Size = new System.Drawing.Size(279, 22);
            this.txtDireccionCl.TabIndex = 10;
            // 
            // txtDNICl
            // 
            this.txtDNICl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDNICl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNICl.Location = new System.Drawing.Point(275, 32);
            this.txtDNICl.Name = "txtDNICl";
            this.txtDNICl.Size = new System.Drawing.Size(279, 22);
            this.txtDNICl.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI";
            // 
            // btnCancelarCl
            // 
            this.btnCancelarCl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarCl.BackgroundImage")));
            this.btnCancelarCl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelarCl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCl.FlatAppearance.BorderSize = 0;
            this.btnCancelarCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCl.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCl.Location = new System.Drawing.Point(628, 275);
            this.btnCancelarCl.Name = "btnCancelarCl";
            this.btnCancelarCl.Size = new System.Drawing.Size(76, 61);
            this.btnCancelarCl.TabIndex = 13;
            this.btnCancelarCl.Text = "Atrás";
            this.btnCancelarCl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarCl.UseVisualStyleBackColor = true;
            this.btnCancelarCl.Click += new System.EventHandler(this.btnCancelarCl_Click);
            // 
            // btnGuardarCl
            // 
            this.btnGuardarCl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarCl.BackgroundImage")));
            this.btnGuardarCl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardarCl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCl.FlatAppearance.BorderSize = 0;
            this.btnGuardarCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCl.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCl.Location = new System.Drawing.Point(628, 12);
            this.btnGuardarCl.Name = "btnGuardarCl";
            this.btnGuardarCl.Size = new System.Drawing.Size(76, 61);
            this.btnGuardarCl.TabIndex = 12;
            this.btnGuardarCl.Text = "Guardar";
            this.btnGuardarCl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarCl.UseVisualStyleBackColor = true;
            this.btnGuardarCl.Click += new System.EventHandler(this.btnGuardarCl_Click);
            // 
            // txtApellidoCl
            // 
            this.txtApellidoCl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidoCl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCl.Location = new System.Drawing.Point(275, 114);
            this.txtApellidoCl.Name = "txtApellidoCl";
            this.txtApellidoCl.Size = new System.Drawing.Size(279, 22);
            this.txtApellidoCl.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(92, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(92, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // btnEliminarCl
            // 
            this.btnEliminarCl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarCl.BackgroundImage")));
            this.btnEliminarCl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarCl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCl.FlatAppearance.BorderSize = 0;
            this.btnEliminarCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCl.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCl.Location = new System.Drawing.Point(628, 82);
            this.btnEliminarCl.Name = "btnEliminarCl";
            this.btnEliminarCl.Size = new System.Drawing.Size(76, 60);
            this.btnEliminarCl.TabIndex = 18;
            this.btnEliminarCl.Text = "Eliminar";
            this.btnEliminarCl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarCl.UseVisualStyleBackColor = true;
            this.btnEliminarCl.Click += new System.EventHandler(this.btnEliminarCl_Click);
            // 
            // btnConsultaCl
            // 
            this.btnConsultaCl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultaCl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultaCl.BackgroundImage")));
            this.btnConsultaCl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultaCl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaCl.FlatAppearance.BorderSize = 0;
            this.btnConsultaCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCl.ForeColor = System.Drawing.Color.White;
            this.btnConsultaCl.Location = new System.Drawing.Point(628, 148);
            this.btnConsultaCl.Name = "btnConsultaCl";
            this.btnConsultaCl.Size = new System.Drawing.Size(76, 56);
            this.btnConsultaCl.TabIndex = 19;
            this.btnConsultaCl.Text = "Consulta";
            this.btnConsultaCl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultaCl.UseVisualStyleBackColor = true;
            this.btnConsultaCl.Click += new System.EventHandler(this.btnConsultaCl_Click);
            // 
            // btnActualizarCl
            // 
            this.btnActualizarCl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarCl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarCl.BackgroundImage")));
            this.btnActualizarCl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizarCl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarCl.FlatAppearance.BorderSize = 0;
            this.btnActualizarCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCl.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCl.Location = new System.Drawing.Point(628, 210);
            this.btnActualizarCl.Name = "btnActualizarCl";
            this.btnActualizarCl.Size = new System.Drawing.Size(76, 59);
            this.btnActualizarCl.TabIndex = 20;
            this.btnActualizarCl.Text = "Modificar";
            this.btnActualizarCl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizarCl.UseVisualStyleBackColor = true;
            this.btnActualizarCl.Click += new System.EventHandler(this.btnActualizarCl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNIClienteDataGridViewTextBoxColumn,
            this.nameClienteDataGridViewTextBoxColumn,
            this.apellidoClienteDataGridViewTextBoxColumn,
            this.dirClienteDataGridViewTextBoxColumn,
            this.fechanaccDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 163);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dNIClienteDataGridViewTextBoxColumn
            // 
            this.dNIClienteDataGridViewTextBoxColumn.DataPropertyName = "DNI_Cliente";
            this.dNIClienteDataGridViewTextBoxColumn.HeaderText = "DNI_Cliente";
            this.dNIClienteDataGridViewTextBoxColumn.Name = "dNIClienteDataGridViewTextBoxColumn";
            // 
            // nameClienteDataGridViewTextBoxColumn
            // 
            this.nameClienteDataGridViewTextBoxColumn.DataPropertyName = "Name_Cliente";
            this.nameClienteDataGridViewTextBoxColumn.HeaderText = "Name_Cliente";
            this.nameClienteDataGridViewTextBoxColumn.Name = "nameClienteDataGridViewTextBoxColumn";
            // 
            // apellidoClienteDataGridViewTextBoxColumn
            // 
            this.apellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "Apellido_Cliente";
            this.apellidoClienteDataGridViewTextBoxColumn.HeaderText = "Apellido_Cliente";
            this.apellidoClienteDataGridViewTextBoxColumn.Name = "apellidoClienteDataGridViewTextBoxColumn";
            // 
            // dirClienteDataGridViewTextBoxColumn
            // 
            this.dirClienteDataGridViewTextBoxColumn.DataPropertyName = "Dir_Cliente";
            this.dirClienteDataGridViewTextBoxColumn.HeaderText = "Dir_Cliente";
            this.dirClienteDataGridViewTextBoxColumn.Name = "dirClienteDataGridViewTextBoxColumn";
            // 
            // fechanaccDataGridViewTextBoxColumn
            // 
            this.fechanaccDataGridViewTextBoxColumn.DataPropertyName = "Fecha_nacc";
            this.fechanaccDataGridViewTextBoxColumn.HeaderText = "Fecha_nacc";
            this.fechanaccDataGridViewTextBoxColumn.Name = "fechanaccDataGridViewTextBoxColumn";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.abogadosDataSet1;
            // 
            // abogadosDataSet1
            // 
            this.abogadosDataSet1.DataSetName = "AbogadosDataSet1";
            this.abogadosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkBlue;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Clientes";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtFNCl
            // 
            this.txtFNCl.CustomFormat = "dd/MM/yy";
            this.txtFNCl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFNCl.Location = new System.Drawing.Point(275, 155);
            this.txtFNCl.Name = "txtFNCl";
            this.txtFNCl.Size = new System.Drawing.Size(279, 20);
            this.txtFNCl.TabIndex = 32;
            this.txtFNCl.Value = new System.DateTime(2021, 4, 27, 0, 0, 0, 0);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(716, 436);
            this.Controls.Add(this.txtFNCl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnActualizarCl);
            this.Controls.Add(this.btnConsultaCl);
            this.Controls.Add(this.btnEliminarCl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoCl);
            this.Controls.Add(this.btnCancelarCl);
            this.Controls.Add(this.btnGuardarCl);
            this.Controls.Add(this.txtNombreCl);
            this.Controls.Add(this.txtDireccionCl);
            this.Controls.Add(this.txtDNICl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abogadosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCl;
        private System.Windows.Forms.TextBox txtDireccionCl;
        private System.Windows.Forms.TextBox txtDNICl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarCl;
        private System.Windows.Forms.Button btnGuardarCl;
        private System.Windows.Forms.TextBox txtApellidoCl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarCl;
        private System.Windows.Forms.Button btnConsultaCl;
        private System.Windows.Forms.Button btnActualizarCl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AbogadosDataSet1 abogadosDataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private AbogadosDataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanaccDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DateTimePicker txtFNCl;
    }
}