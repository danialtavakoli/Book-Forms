namespace ProjectForm
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.join_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.library_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penalty_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_penalty_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowed_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(568, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(267, 80);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "نام نویسنده";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(568, 363);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(267, 80);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "عنوان کتاب";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(60, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(421, 80);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(60, 363);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(421, 80);
            this.textBox4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.member_id,
            this.name,
            this.phone_number,
            this.address,
            this.join_date,
            this.image,
            this.library_address,
            this.borrow_id,
            this.penalty_id,
            this.total_penalty_amount,
            this.borrowed_book});
            this.dataGridView1.Location = new System.Drawing.Point(891, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1268, 675);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // member_id
            // 
            this.member_id.HeaderText = "member_id";
            this.member_id.MinimumWidth = 10;
            this.member_id.Name = "member_id";
            this.member_id.ReadOnly = true;
            this.member_id.Width = 200;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "phone_number";
            this.phone_number.MinimumWidth = 10;
            this.phone_number.Name = "phone_number";
            this.phone_number.ReadOnly = true;
            this.phone_number.Width = 200;
            // 
            // address
            // 
            this.address.HeaderText = "address";
            this.address.MinimumWidth = 10;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 200;
            // 
            // join_date
            // 
            this.join_date.HeaderText = "join_date";
            this.join_date.MinimumWidth = 10;
            this.join_date.Name = "join_date";
            this.join_date.ReadOnly = true;
            this.join_date.Width = 200;
            // 
            // image
            // 
            this.image.HeaderText = "image";
            this.image.MinimumWidth = 10;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 200;
            // 
            // library_address
            // 
            this.library_address.HeaderText = "library_address";
            this.library_address.MinimumWidth = 10;
            this.library_address.Name = "library_address";
            this.library_address.ReadOnly = true;
            this.library_address.Width = 200;
            // 
            // borrow_id
            // 
            this.borrow_id.HeaderText = "borrow_id";
            this.borrow_id.MinimumWidth = 10;
            this.borrow_id.Name = "borrow_id";
            this.borrow_id.ReadOnly = true;
            this.borrow_id.Width = 200;
            // 
            // penalty_id
            // 
            this.penalty_id.HeaderText = "penalty_id";
            this.penalty_id.MinimumWidth = 10;
            this.penalty_id.Name = "penalty_id";
            this.penalty_id.ReadOnly = true;
            this.penalty_id.Width = 200;
            // 
            // total_penalty_amount
            // 
            this.total_penalty_amount.HeaderText = "total_penalty_amount";
            this.total_penalty_amount.MinimumWidth = 10;
            this.total_penalty_amount.Name = "total_penalty_amount";
            this.total_penalty_amount.ReadOnly = true;
            this.total_penalty_amount.Width = 200;
            // 
            // borrowed_book
            // 
            this.borrowed_book.HeaderText = "borrowed_book";
            this.borrowed_book.MinimumWidth = 10;
            this.borrowed_book.Name = "borrowed_book";
            this.borrowed_book.ReadOnly = true;
            this.borrowed_book.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "جستجو";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn join_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn library_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn penalty_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_penalty_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowed_book;
        private System.Windows.Forms.Button button1;
    }
}