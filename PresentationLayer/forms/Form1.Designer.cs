namespace PresentationLayer
{
    partial class Form1
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
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxDescription = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxPrice = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxName
            // 
            this.tboxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxName.Location = new System.Drawing.Point(39, 174);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(264, 20);
            this.tboxName.TabIndex = 0;
            // 
            // tboxDescription
            // 
            this.tboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxDescription.Location = new System.Drawing.Point(39, 232);
            this.tboxDescription.Multiline = true;
            this.tboxDescription.Name = "tboxDescription";
            this.tboxDescription.Size = new System.Drawing.Size(264, 43);
            this.tboxDescription.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(315, 174);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(456, 226);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(39, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(39, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // tboxPrice
            // 
            this.tboxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxPrice.Location = new System.Drawing.Point(39, 310);
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.Size = new System.Drawing.Size(264, 20);
            this.tboxPrice.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(129, 367);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(84, 33);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(39, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search Product:";
            // 
            // tboxSearch
            // 
            this.tboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxSearch.Location = new System.Drawing.Point(172, 96);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(509, 20);
            this.tboxSearch.TabIndex = 12;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(687, 88);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(84, 33);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "PRODUCT REGISTRATION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tboxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.tboxDescription);
            this.Controls.Add(this.tboxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Button btnFind;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxPrice;

        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.DataGridView dgvProducts;

        private System.Windows.Forms.TextBox tboxDescription;

        private System.Windows.Forms.TextBox tboxName;

        #endregion
    }
}