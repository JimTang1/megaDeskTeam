namespace megaDesk_Jim
{
    partial class ViewAllQuotes
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
            this.listOfQuotes = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listOfQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfQuotes
            // 
            this.listOfQuotes.AllowUserToAddRows = false;
            this.listOfQuotes.AllowUserToDeleteRows = false;
            this.listOfQuotes.AllowUserToResizeColumns = false;
            this.listOfQuotes.AllowUserToResizeRows = false;
            this.listOfQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfQuotes.Location = new System.Drawing.Point(0, 0);
            this.listOfQuotes.Name = "listOfQuotes";
            this.listOfQuotes.RowHeadersWidth = 51;
            this.listOfQuotes.RowTemplate.Height = 24;
            this.listOfQuotes.Size = new System.Drawing.Size(880, 465);
            this.listOfQuotes.TabIndex = 0;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(372, 496);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(138, 35);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 543);
            this.Controls.Add(this.close);
            this.Controls.Add(this.listOfQuotes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfQuotes;
        private System.Windows.Forms.Button close;
    }
}