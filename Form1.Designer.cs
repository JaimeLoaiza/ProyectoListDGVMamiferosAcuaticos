namespace ProyectoTareaListDGV_MamiferosAcuaticos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblespecie = new System.Windows.Forms.Label();
            this.lbllocalizacion = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtespecie = new System.Windows.Forms.TextBox();
            this.txtlocalizacion = new System.Windows.Forms.TextBox();
            this.btnnuevoregistro = new System.Windows.Forms.Button();
            this.btnagregarregistro = new System.Windows.Forms.Button();
            this.btnmodificarregistro = new System.Windows.Forms.Button();
            this.btneliminarregistro = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.DGVmamiferosacuaticos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmamiferosacuaticos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(35, 31);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(630, 26);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "REGISTRO DE MAMIFEROS ACUATICOS EN TODO EL PLANETA";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(181, 76);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(64, 17);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "NOMBRE";
            // 
            // lblespecie
            // 
            this.lblespecie.AutoSize = true;
            this.lblespecie.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblespecie.Location = new System.Drawing.Point(312, 76);
            this.lblespecie.Name = "lblespecie";
            this.lblespecie.Size = new System.Drawing.Size(58, 17);
            this.lblespecie.TabIndex = 3;
            this.lblespecie.Text = "ESPECIE";
            // 
            // lbllocalizacion
            // 
            this.lbllocalizacion.AutoSize = true;
            this.lbllocalizacion.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllocalizacion.Location = new System.Drawing.Point(423, 76);
            this.lbllocalizacion.Name = "lbllocalizacion";
            this.lbllocalizacion.Size = new System.Drawing.Size(108, 17);
            this.lbllocalizacion.TabIndex = 6;
            this.lbllocalizacion.Text = "LOCALIZACIÓN";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(149, 104);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(127, 20);
            this.txtnombre.TabIndex = 8;
            // 
            // txtespecie
            // 
            this.txtespecie.Location = new System.Drawing.Point(282, 104);
            this.txtespecie.Name = "txtespecie";
            this.txtespecie.Size = new System.Drawing.Size(127, 20);
            this.txtespecie.TabIndex = 9;
            // 
            // txtlocalizacion
            // 
            this.txtlocalizacion.Location = new System.Drawing.Point(415, 104);
            this.txtlocalizacion.Name = "txtlocalizacion";
            this.txtlocalizacion.Size = new System.Drawing.Size(127, 20);
            this.txtlocalizacion.TabIndex = 12;
            // 
            // btnnuevoregistro
            // 
            this.btnnuevoregistro.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevoregistro.ForeColor = System.Drawing.Color.Blue;
            this.btnnuevoregistro.Location = new System.Drawing.Point(117, 139);
            this.btnnuevoregistro.Name = "btnnuevoregistro";
            this.btnnuevoregistro.Size = new System.Drawing.Size(112, 41);
            this.btnnuevoregistro.TabIndex = 13;
            this.btnnuevoregistro.Text = "NUEVO REGISTRO";
            this.btnnuevoregistro.UseVisualStyleBackColor = true;
            this.btnnuevoregistro.Click += new System.EventHandler(this.btnnuevoregistro_Click);
            // 
            // btnagregarregistro
            // 
            this.btnagregarregistro.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarregistro.ForeColor = System.Drawing.Color.Blue;
            this.btnagregarregistro.Location = new System.Drawing.Point(235, 139);
            this.btnagregarregistro.Name = "btnagregarregistro";
            this.btnagregarregistro.Size = new System.Drawing.Size(112, 41);
            this.btnagregarregistro.TabIndex = 14;
            this.btnagregarregistro.Text = "AGREGAR REGISTRO";
            this.btnagregarregistro.UseVisualStyleBackColor = true;
            this.btnagregarregistro.Click += new System.EventHandler(this.btnagregarregistro_Click);
            // 
            // btnmodificarregistro
            // 
            this.btnmodificarregistro.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarregistro.ForeColor = System.Drawing.Color.Blue;
            this.btnmodificarregistro.Location = new System.Drawing.Point(353, 139);
            this.btnmodificarregistro.Name = "btnmodificarregistro";
            this.btnmodificarregistro.Size = new System.Drawing.Size(111, 41);
            this.btnmodificarregistro.TabIndex = 15;
            this.btnmodificarregistro.Text = "MODIFICAR REGISTRO";
            this.btnmodificarregistro.UseVisualStyleBackColor = true;
            this.btnmodificarregistro.Click += new System.EventHandler(this.btnmodificarregistro_Click);
            // 
            // btneliminarregistro
            // 
            this.btneliminarregistro.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarregistro.ForeColor = System.Drawing.Color.Blue;
            this.btneliminarregistro.Location = new System.Drawing.Point(470, 139);
            this.btneliminarregistro.Name = "btneliminarregistro";
            this.btneliminarregistro.Size = new System.Drawing.Size(111, 41);
            this.btneliminarregistro.TabIndex = 16;
            this.btneliminarregistro.Text = "ELIMINAR REGISTRO";
            this.btneliminarregistro.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Maroon;
            this.btnsalir.Location = new System.Drawing.Point(577, 480);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(106, 31);
            this.btnsalir.TabIndex = 17;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // DGVmamiferosacuaticos
            // 
            this.DGVmamiferosacuaticos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVmamiferosacuaticos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVmamiferosacuaticos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVmamiferosacuaticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmamiferosacuaticos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.DGVmamiferosacuaticos.Location = new System.Drawing.Point(26, 195);
            this.DGVmamiferosacuaticos.Name = "DGVmamiferosacuaticos";
            this.DGVmamiferosacuaticos.Size = new System.Drawing.Size(639, 279);
            this.DGVmamiferosacuaticos.TabIndex = 18;
            this.DGVmamiferosacuaticos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVmamiferosacuaticos_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 523);
            this.Controls.Add(this.DGVmamiferosacuaticos);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminarregistro);
            this.Controls.Add(this.btnmodificarregistro);
            this.Controls.Add(this.btnagregarregistro);
            this.Controls.Add(this.btnnuevoregistro);
            this.Controls.Add(this.txtlocalizacion);
            this.Controls.Add(this.txtespecie);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbllocalizacion);
            this.Controls.Add(this.lblespecie);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmamiferosacuaticos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblespecie;
        private System.Windows.Forms.Label lbllocalizacion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtespecie;
        private System.Windows.Forms.TextBox txtlocalizacion;
        private System.Windows.Forms.Button btnnuevoregistro;
        private System.Windows.Forms.Button btnagregarregistro;
        private System.Windows.Forms.Button btnmodificarregistro;
        private System.Windows.Forms.Button btneliminarregistro;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView DGVmamiferosacuaticos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

