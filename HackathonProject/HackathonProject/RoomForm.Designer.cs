namespace HackathonProject
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.roomDropDown = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lightingTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.tempLabel = new System.Windows.Forms.TextBox();
            this.LightingLabel = new System.Windows.Forms.TextBox();
            this.peopleInRoomLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // roomDropDown
            // 
            this.roomDropDown.FormattingEnabled = true;
            this.roomDropDown.Location = new System.Drawing.Point(13, 13);
            this.roomDropDown.Name = "roomDropDown";
            this.roomDropDown.Size = new System.Drawing.Size(121, 21);
            this.roomDropDown.TabIndex = 0;
            this.roomDropDown.SelectedIndexChanged += new System.EventHandler(this.roomDropDown_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lightingTextBox
            // 
            this.lightingTextBox.Location = new System.Drawing.Point(90, 94);
            this.lightingTextBox.Name = "lightingTextBox";
            this.lightingTextBox.ReadOnly = true;
            this.lightingTextBox.Size = new System.Drawing.Size(94, 20);
            this.lightingTextBox.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(90, 180);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.ReadOnly = true;
            this.temperatureTextBox.Size = new System.Drawing.Size(94, 20);
            this.temperatureTextBox.TabIndex = 4;
            // 
            // tempLabel
            // 
            this.tempLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempLabel.Location = new System.Drawing.Point(90, 161);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.ReadOnly = true;
            this.tempLabel.Size = new System.Drawing.Size(118, 13);
            this.tempLabel.TabIndex = 5;
            this.tempLabel.Text = "Temperature increase:";
            // 
            // LightingLabel
            // 
            this.LightingLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LightingLabel.Location = new System.Drawing.Point(90, 75);
            this.LightingLabel.Name = "LightingLabel";
            this.LightingLabel.ReadOnly = true;
            this.LightingLabel.Size = new System.Drawing.Size(118, 13);
            this.LightingLabel.TabIndex = 6;
            this.LightingLabel.Text = "Lighting increase:";
            // 
            // peopleInRoomLabel
            // 
            this.peopleInRoomLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.peopleInRoomLabel.Location = new System.Drawing.Point(14, 41);
            this.peopleInRoomLabel.Name = "peopleInRoomLabel";
            this.peopleInRoomLabel.ReadOnly = true;
            this.peopleInRoomLabel.Size = new System.Drawing.Size(194, 13);
            this.peopleInRoomLabel.TabIndex = 7;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 260);
            this.Controls.Add(this.peopleInRoomLabel);
            this.Controls.Add(this.LightingLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lightingTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roomDropDown);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox roomDropDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lightingTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox tempLabel;
        private System.Windows.Forms.TextBox LightingLabel;
        private System.Windows.Forms.TextBox peopleInRoomLabel;
    }
}