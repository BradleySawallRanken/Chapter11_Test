namespace Chapter11_Test
{
    partial class frmCardStore
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
            this.lblOccasion = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.occasionComboBox = new System.Windows.Forms.ComboBox();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.envelopeCheckBox = new System.Windows.Forms.CheckBox();
            this.stampCheckBox = new System.Windows.Forms.CheckBox();
            this.messageCheckBox = new System.Windows.Forms.CheckBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCardPreview = new System.Windows.Forms.Label();
            this.txtCustomMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOccasion
            // 
            this.lblOccasion.AutoSize = true;
            this.lblOccasion.Location = new System.Drawing.Point(0, 27);
            this.lblOccasion.Name = "lblOccasion";
            this.lblOccasion.Size = new System.Drawing.Size(64, 16);
            this.lblOccasion.TabIndex = 0;
            this.lblOccasion.Text = "Occasion";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(0, 67);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(37, 16);
            this.lblStyle.TabIndex = 1;
            this.lblStyle.Text = "Style";
            // 
            // occasionComboBox
            // 
            this.occasionComboBox.FormattingEnabled = true;
            this.occasionComboBox.Items.AddRange(new object[] {
            "Birthday",
            "Anniversary",
            "Congratulations"});
            this.occasionComboBox.Location = new System.Drawing.Point(86, 24);
            this.occasionComboBox.Name = "occasionComboBox";
            this.occasionComboBox.Size = new System.Drawing.Size(121, 24);
            this.occasionComboBox.TabIndex = 2;
            this.occasionComboBox.SelectedIndexChanged += new System.EventHandler(this.occasionComboBox_SelectedIndexChanged_1);
            // 
            // styleComboBox
            // 
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Items.AddRange(new object[] {
            "Tree",
            "Mountain",
            "Big Chungus"});
            this.styleComboBox.Location = new System.Drawing.Point(86, 67);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(121, 24);
            this.styleComboBox.TabIndex = 3;
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged_1);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Image = global::Chapter11_Test.Properties.Resources.Tree;
            this.previewPictureBox.Location = new System.Drawing.Point(340, 24);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(416, 359);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.previewPictureBox.TabIndex = 4;
            this.previewPictureBox.TabStop = false;
            // 
            // envelopeCheckBox
            // 
            this.envelopeCheckBox.AutoSize = true;
            this.envelopeCheckBox.Location = new System.Drawing.Point(86, 128);
            this.envelopeCheckBox.Name = "envelopeCheckBox";
            this.envelopeCheckBox.Size = new System.Drawing.Size(129, 20);
            this.envelopeCheckBox.TabIndex = 5;
            this.envelopeCheckBox.Text = "Envelope ($0.25)";
            this.envelopeCheckBox.UseVisualStyleBackColor = true;
            this.envelopeCheckBox.CheckedChanged += new System.EventHandler(this.envelopeCheckBox_CheckedChanged_1);
            // 
            // stampCheckBox
            // 
            this.stampCheckBox.AutoSize = true;
            this.stampCheckBox.Location = new System.Drawing.Point(86, 152);
            this.stampCheckBox.Name = "stampCheckBox";
            this.stampCheckBox.Size = new System.Drawing.Size(110, 20);
            this.stampCheckBox.TabIndex = 6;
            this.stampCheckBox.Text = "Stamp ($0.50)";
            this.stampCheckBox.UseVisualStyleBackColor = true;
            this.stampCheckBox.CheckedChanged += new System.EventHandler(this.stampCheckBox_CheckedChanged_1);
            // 
            // messageCheckBox
            // 
            this.messageCheckBox.AutoSize = true;
            this.messageCheckBox.Location = new System.Drawing.Point(86, 178);
            this.messageCheckBox.Name = "messageCheckBox";
            this.messageCheckBox.Size = new System.Drawing.Size(176, 20);
            this.messageCheckBox.TabIndex = 7;
            this.messageCheckBox.Text = "Custom Message ($0.30)";
            this.messageCheckBox.UseVisualStyleBackColor = true;
            this.messageCheckBox.CheckedChanged += new System.EventHandler(this.messageCheckBox_CheckedChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(20, 404);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 20);
            this.lblCost.TabIndex = 9;
            this.lblCost.Text = "Cost:";
            // 
            // lblCardPreview
            // 
            this.lblCardPreview.AutoSize = true;
            this.lblCardPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblCardPreview.Location = new System.Drawing.Point(371, 332);
            this.lblCardPreview.Name = "lblCardPreview";
            this.lblCardPreview.Size = new System.Drawing.Size(0, 20);
            this.lblCardPreview.TabIndex = 10;
            // 
            // txtCustomMessage
            // 
            this.txtCustomMessage.Location = new System.Drawing.Point(12, 232);
            this.txtCustomMessage.Multiline = true;
            this.txtCustomMessage.Name = "txtCustomMessage";
            this.txtCustomMessage.Size = new System.Drawing.Size(278, 120);
            this.txtCustomMessage.TabIndex = 11;
            // 
            // frmCardStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCustomMessage);
            this.Controls.Add(this.lblCardPreview);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.messageCheckBox);
            this.Controls.Add(this.stampCheckBox);
            this.Controls.Add(this.envelopeCheckBox);
            this.Controls.Add(this.previewPictureBox);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.occasionComboBox);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblOccasion);
            this.Name = "frmCardStore";
            this.Text = "Card Designer";
            this.Load += new System.EventHandler(this.frmCardStore_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOccasion;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.ComboBox occasionComboBox;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.CheckBox envelopeCheckBox;
        private System.Windows.Forms.CheckBox stampCheckBox;
        private System.Windows.Forms.CheckBox messageCheckBox;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCardPreview;
        private System.Windows.Forms.TextBox txtCustomMessage;
    }
}

