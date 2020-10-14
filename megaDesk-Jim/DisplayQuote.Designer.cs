namespace megaDesk_Jim
{
    partial class DisplayQuote
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
            this.name = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.Label();
            this.newQuote = new System.Windows.Forms.Label();
            this.cmbDelivery = new System.Windows.Forms.ComboBox();
            this.delivery = new System.Windows.Forms.Label();
            this.numberDrawers = new System.Windows.Forms.Label();
            this.numerDrawers = new System.Windows.Forms.NumericUpDown();
            this.numerDepth = new System.Windows.Forms.NumericUpDown();
            this.depth = new System.Windows.Forms.Label();
            this.surfaceMaterial = new System.Windows.Forms.Label();
            this.cmbSurefaceM = new System.Windows.Forms.ComboBox();
            this.close = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.Label();
            this.numerWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numerDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(236, 122);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(294, 21);
            this.name.TabIndex = 29;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.customerName.Location = new System.Drawing.Point(100, 122);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(130, 22);
            this.customerName.TabIndex = 28;
            this.customerName.Text = "Customer Name";
            // 
            // newQuote
            // 
            this.newQuote.AutoSize = true;
            this.newQuote.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold);
            this.newQuote.Location = new System.Drawing.Point(260, 41);
            this.newQuote.Name = "newQuote";
            this.newQuote.Size = new System.Drawing.Size(229, 49);
            this.newQuote.TabIndex = 27;
            this.newQuote.Text = "New Quote";
            // 
            // cmbDelivery
            // 
            this.cmbDelivery.FormattingEnabled = true;
            this.cmbDelivery.Location = new System.Drawing.Point(568, 279);
            this.cmbDelivery.Name = "cmbDelivery";
            this.cmbDelivery.Size = new System.Drawing.Size(121, 20);
            this.cmbDelivery.TabIndex = 26;
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.delivery.Location = new System.Drawing.Point(427, 279);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(70, 22);
            this.delivery.TabIndex = 25;
            this.delivery.Text = "Delivery";
            // 
            // numberDrawers
            // 
            this.numberDrawers.AutoSize = true;
            this.numberDrawers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.numberDrawers.Location = new System.Drawing.Point(402, 187);
            this.numberDrawers.Name = "numberDrawers";
            this.numberDrawers.Size = new System.Drawing.Size(158, 22);
            this.numberDrawers.TabIndex = 24;
            this.numberDrawers.Text = "Number of Drawers";
            // 
            // numerDrawers
            // 
            this.numerDrawers.Location = new System.Drawing.Point(568, 187);
            this.numerDrawers.Name = "numerDrawers";
            this.numerDrawers.Size = new System.Drawing.Size(38, 21);
            this.numerDrawers.TabIndex = 23;
            // 
            // numerDepth
            // 
            this.numerDepth.Location = new System.Drawing.Point(165, 278);
            this.numerDepth.Name = "numerDepth";
            this.numerDepth.Size = new System.Drawing.Size(120, 21);
            this.numerDepth.TabIndex = 22;
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.depth.Location = new System.Drawing.Point(100, 278);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(59, 22);
            this.depth.TabIndex = 21;
            this.depth.Text = "Depth:";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.AutoSize = true;
            this.surfaceMaterial.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.surfaceMaterial.Location = new System.Drawing.Point(427, 235);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(133, 22);
            this.surfaceMaterial.TabIndex = 20;
            this.surfaceMaterial.Text = "Surface Material";
            // 
            // cmbSurefaceM
            // 
            this.cmbSurefaceM.FormattingEnabled = true;
            this.cmbSurefaceM.Location = new System.Drawing.Point(567, 232);
            this.cmbSurefaceM.Name = "cmbSurefaceM";
            this.cmbSurefaceM.Size = new System.Drawing.Size(121, 20);
            this.cmbSurefaceM.TabIndex = 19;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(286, 394);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(171, 44);
            this.close.TabIndex = 18;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.width.Location = new System.Drawing.Point(100, 232);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(59, 22);
            this.width.TabIndex = 16;
            this.width.Text = "Width:";
            // 
            // numerWidth
            // 
            this.numerWidth.Location = new System.Drawing.Point(165, 236);
            this.numerWidth.Name = "numerWidth";
            this.numerWidth.Size = new System.Drawing.Size(120, 21);
            this.numerWidth.TabIndex = 15;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.name);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.newQuote);
            this.Controls.Add(this.cmbDelivery);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.numberDrawers);
            this.Controls.Add(this.numerDrawers);
            this.Controls.Add(this.numerDepth);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.cmbSurefaceM);
            this.Controls.Add(this.close);
            this.Controls.Add(this.width);
            this.Controls.Add(this.numerWidth);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuote_FormClosed);
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numerDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label newQuote;
        private System.Windows.Forms.ComboBox cmbDelivery;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.Label numberDrawers;
        private System.Windows.Forms.NumericUpDown numerDrawers;
        private System.Windows.Forms.NumericUpDown numerDepth;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.Label surfaceMaterial;
        private System.Windows.Forms.ComboBox cmbSurefaceM;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.NumericUpDown numerWidth;
    }
}