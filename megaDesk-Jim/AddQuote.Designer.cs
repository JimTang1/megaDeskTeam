﻿namespace megaDesk_Jim
{
    partial class AddQuote
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
            this.numerWidth = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.Label();
            this.getQuote = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.cmbSurefaceM = new System.Windows.Forms.ComboBox();
            this.surfaceMaterial = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.Label();
            this.numerDepth = new System.Windows.Forms.NumericUpDown();
            this.numerDrawers = new System.Windows.Forms.NumericUpDown();
            this.numberDrawers = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.Label();
            this.cmbDelivery = new System.Windows.Forms.ComboBox();
            this.newQuote = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numerWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // numerWidth
            // 
            this.numerWidth.Location = new System.Drawing.Point(201, 285);
            this.numerWidth.Margin = new System.Windows.Forms.Padding(4);
            this.numerWidth.Name = "numerWidth";
            this.numerWidth.Size = new System.Drawing.Size(160, 22);
            this.numerWidth.TabIndex = 2;
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.width.Location = new System.Drawing.Point(100, 280);
            this.width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(75, 26);
            this.width.TabIndex = 1;
            this.width.Text = "Width:";
            // 
            // getQuote
            // 
            this.getQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuote.Location = new System.Drawing.Point(176, 444);
            this.getQuote.Margin = new System.Windows.Forms.Padding(4);
            this.getQuote.Name = "getQuote";
            this.getQuote.Size = new System.Drawing.Size(225, 59);
            this.getQuote.TabIndex = 6;
            this.getQuote.Text = "Get Quote";
            this.getQuote.UseVisualStyleBackColor = true;
            this.getQuote.Click += new System.EventHandler(this.getQuote_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(478, 444);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(228, 59);
            this.close.TabIndex = 7;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // cmbSurefaceM
            // 
            this.cmbSurefaceM.FormattingEnabled = true;
            this.cmbSurefaceM.Location = new System.Drawing.Point(622, 222);
            this.cmbSurefaceM.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSurefaceM.Name = "cmbSurefaceM";
            this.cmbSurefaceM.Size = new System.Drawing.Size(160, 24);
            this.cmbSurefaceM.TabIndex = 4;
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.AutoSize = true;
            this.surfaceMaterial.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.surfaceMaterial.Location = new System.Drawing.Point(435, 221);
            this.surfaceMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(174, 26);
            this.surfaceMaterial.TabIndex = 5;
            this.surfaceMaterial.Text = "Surface Material:";
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.depth.Location = new System.Drawing.Point(100, 341);
            this.depth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(76, 26);
            this.depth.TabIndex = 6;
            this.depth.Text = "Depth:";
            // 
            // numerDepth
            // 
            this.numerDepth.Location = new System.Drawing.Point(201, 341);
            this.numerDepth.Margin = new System.Windows.Forms.Padding(4);
            this.numerDepth.Name = "numerDepth";
            this.numerDepth.Size = new System.Drawing.Size(160, 22);
            this.numerDepth.TabIndex = 3;
            // 
            // numerDrawers
            // 
            this.numerDrawers.Location = new System.Drawing.Point(310, 223);
            this.numerDrawers.Margin = new System.Windows.Forms.Padding(4);
            this.numerDrawers.Name = "numerDrawers";
            this.numerDrawers.Size = new System.Drawing.Size(51, 22);
            this.numerDrawers.TabIndex = 1;
            // 
            // numberDrawers
            // 
            this.numberDrawers.AutoSize = true;
            this.numberDrawers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.numberDrawers.Location = new System.Drawing.Point(90, 221);
            this.numberDrawers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberDrawers.Name = "numberDrawers";
            this.numberDrawers.Size = new System.Drawing.Size(202, 26);
            this.numberDrawers.TabIndex = 9;
            this.numberDrawers.Text = "Number of Drawers:";
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.delivery.Location = new System.Drawing.Point(435, 280);
            this.delivery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(99, 26);
            this.delivery.TabIndex = 10;
            this.delivery.Text = "Delivery:";
            // 
            // cmbDelivery
            // 
            this.cmbDelivery.FormattingEnabled = true;
            this.cmbDelivery.Location = new System.Drawing.Point(623, 281);
            this.cmbDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDelivery.Name = "cmbDelivery";
            this.cmbDelivery.Size = new System.Drawing.Size(160, 24);
            this.cmbDelivery.TabIndex = 5;
            // 
            // newQuote
            // 
            this.newQuote.AutoSize = true;
            this.newQuote.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Bold);
            this.newQuote.Location = new System.Drawing.Point(299, 25);
            this.newQuote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newQuote.Name = "newQuote";
            this.newQuote.Size = new System.Drawing.Size(285, 63);
            this.newQuote.TabIndex = 12;
            this.newQuote.Text = "New Quote";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.customerName.Location = new System.Drawing.Point(158, 133);
            this.customerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(168, 26);
            this.customerName.TabIndex = 13;
            this.customerName.Text = "Customer Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(334, 135);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(391, 22);
            this.name.TabIndex = 0;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 533);
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
            this.Controls.Add(this.getQuote);
            this.Controls.Add(this.width);
            this.Controls.Add(this.numerWidth);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddQuote";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numerWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Button getQuote;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label surfaceMaterial;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.Label numberDrawers;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.Label newQuote;
        private System.Windows.Forms.Label customerName;
        public System.Windows.Forms.NumericUpDown numerWidth;
        public System.Windows.Forms.ComboBox cmbSurefaceM;
        public System.Windows.Forms.NumericUpDown numerDepth;
        public System.Windows.Forms.NumericUpDown numerDrawers;
        public System.Windows.Forms.ComboBox cmbDelivery;
        public System.Windows.Forms.TextBox name;
    }
}