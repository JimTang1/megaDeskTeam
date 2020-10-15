namespace megaDesk_Jim
{
    partial class SearchQuotes
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
            this.searchedQuotes = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            this.surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchedQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // searchedQuotes
            // 
            this.searchedQuotes.AllowUserToAddRows = false;
            this.searchedQuotes.AllowUserToDeleteRows = false;
            this.searchedQuotes.AllowUserToResizeColumns = false;
            this.searchedQuotes.AllowUserToResizeRows = false;
            this.searchedQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchedQuotes.Location = new System.Drawing.Point(0, 54);
            this.searchedQuotes.Name = "searchedQuotes";
            this.searchedQuotes.RowHeadersWidth = 51;
            this.searchedQuotes.RowTemplate.Height = 24;
            this.searchedQuotes.Size = new System.Drawing.Size(880, 412);
            this.searchedQuotes.TabIndex = 1;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(372, 496);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(138, 35);
            this.close.TabIndex = 2;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.FormattingEnabled = true;
            this.surfaceMaterial.Location = new System.Drawing.Point(229, 12);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(213, 24);
            this.surfaceMaterial.TabIndex = 3;
            this.surfaceMaterial.SelectedValueChanged += new System.EventHandler(this.surfaceMaterial_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Surface Material:";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.close);
            this.Controls.Add(this.searchedQuotes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchedQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchedQuotes;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox surfaceMaterial;
        private System.Windows.Forms.Label label1;
    }
}