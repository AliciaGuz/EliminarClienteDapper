namespace EliminarClienteDapper
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.txbObtenerID = new System.Windows.Forms.TextBox();
            this.btnObtenerTodo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnObtenerID = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbContactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbContactTittle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.Size = new System.Drawing.Size(835, 213);
            this.dgvCustomers.TabIndex = 0;
            // 
            // txbObtenerID
            // 
            this.txbObtenerID.Location = new System.Drawing.Point(131, 354);
            this.txbObtenerID.Name = "txbObtenerID";
            this.txbObtenerID.Size = new System.Drawing.Size(155, 26);
            this.txbObtenerID.TabIndex = 1;
            // 
            // btnObtenerTodo
            // 
            this.btnObtenerTodo.Location = new System.Drawing.Point(66, 254);
            this.btnObtenerTodo.Name = "btnObtenerTodo";
            this.btnObtenerTodo.Size = new System.Drawing.Size(173, 43);
            this.btnObtenerTodo.TabIndex = 10;
            this.btnObtenerTodo.Text = "Mostrar Datos";
            this.btnObtenerTodo.UseVisualStyleBackColor = true;
            this.btnObtenerTodo.Click += new System.EventHandler(this.btnObtenerTodo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "CustomerID";
            // 
            // btnObtenerID
            // 
            this.btnObtenerID.Location = new System.Drawing.Point(292, 348);
            this.btnObtenerID.Name = "btnObtenerID";
            this.btnObtenerID.Size = new System.Drawing.Size(88, 38);
            this.btnObtenerID.TabIndex = 12;
            this.btnObtenerID.Text = "Obtener";
            this.btnObtenerID.UseVisualStyleBackColor = true;
            this.btnObtenerID.Click += new System.EventHandler(this.btnObtenerID_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(431, 439);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 44);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "CustomerID";
            // 
            // txbCustomerID
            // 
            this.txbCustomerID.Location = new System.Drawing.Point(692, 273);
            this.txbCustomerID.Name = "txbCustomerID";
            this.txbCustomerID.Size = new System.Drawing.Size(155, 26);
            this.txbCustomerID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Company Name";
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(692, 319);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(155, 26);
            this.txbCompanyName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contact Name";
            // 
            // txbContactName
            // 
            this.txbContactName.Location = new System.Drawing.Point(692, 373);
            this.txbContactName.Name = "txbContactName";
            this.txbContactName.Size = new System.Drawing.Size(155, 26);
            this.txbContactName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Contact Tittle";
            // 
            // txbContactTittle
            // 
            this.txbContactTittle.Location = new System.Drawing.Point(692, 421);
            this.txbContactTittle.Name = "txbContactTittle";
            this.txbContactTittle.Size = new System.Drawing.Size(155, 26);
            this.txbContactTittle.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbContactTittle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbContactName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCompanyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCustomerID);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnObtenerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnObtenerTodo);
            this.Controls.Add(this.txbObtenerID);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txbObtenerID;
        private System.Windows.Forms.Button btnObtenerTodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnObtenerID;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbContactName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbContactTittle;
    }
}

