namespace ProjectForm
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publication_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.author,
            this.translator,
            this.publisher,
            this.publication_date,
            this.name,
            this.section,
            this.borrow_id,
            this.button});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1657, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // book_id
            // 
            this.book_id.HeaderText = "book_id";
            this.book_id.MinimumWidth = 10;
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Width = 200;
            // 
            // author
            // 
            this.author.HeaderText = "author";
            this.author.MinimumWidth = 10;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 200;
            // 
            // translator
            // 
            this.translator.HeaderText = "translator";
            this.translator.MinimumWidth = 10;
            this.translator.Name = "translator";
            this.translator.ReadOnly = true;
            this.translator.Width = 200;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "publisher";
            this.publisher.MinimumWidth = 10;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            this.publisher.Width = 200;
            // 
            // publication_date
            // 
            this.publication_date.HeaderText = "publication_date";
            this.publication_date.MinimumWidth = 10;
            this.publication_date.Name = "publication_date";
            this.publication_date.ReadOnly = true;
            this.publication_date.Width = 200;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // section
            // 
            this.section.HeaderText = "section";
            this.section.MinimumWidth = 10;
            this.section.Name = "section";
            this.section.ReadOnly = true;
            this.section.Width = 200;
            // 
            // borrow_id
            // 
            this.borrow_id.HeaderText = "borrow_id";
            this.borrow_id.MinimumWidth = 10;
            this.borrow_id.Name = "borrow_id";
            this.borrow_id.ReadOnly = true;
            this.borrow_id.Width = 200;
            // 
            // button
            // 
            this.button.HeaderText = "button";
            this.button.MinimumWidth = 10;
            this.button.Name = "button";
            this.button.ReadOnly = true;
            this.button.Width = 200;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 407);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn translator;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn publication_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_id;
        private System.Windows.Forms.DataGridViewButtonColumn button;
    }
}