
namespace TvPrograms
{
    partial class ShowAll
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
            this.btnChannels = new System.Windows.Forms.Button();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.btnHostes = new System.Windows.Forms.Button();
            this.btnHostProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChannels
            // 
            this.btnChannels.Location = new System.Drawing.Point(63, 22);
            this.btnChannels.Name = "btnChannels";
            this.btnChannels.Size = new System.Drawing.Size(171, 41);
            this.btnChannels.TabIndex = 0;
            this.btnChannels.Text = "Show Channels";
            this.btnChannels.UseVisualStyleBackColor = true;
            this.btnChannels.Click += new System.EventHandler(this.btnChannels_Click);
            // 
            // btnPrograms
            // 
            this.btnPrograms.Location = new System.Drawing.Point(63, 85);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(171, 41);
            this.btnPrograms.TabIndex = 1;
            this.btnPrograms.Text = "Show Programs";
            this.btnPrograms.UseVisualStyleBackColor = true;
            this.btnPrograms.Click += new System.EventHandler(this.btnPrograms_Click);
            // 
            // btnHostes
            // 
            this.btnHostes.Location = new System.Drawing.Point(63, 149);
            this.btnHostes.Name = "btnHostes";
            this.btnHostes.Size = new System.Drawing.Size(171, 47);
            this.btnHostes.TabIndex = 2;
            this.btnHostes.Text = "Show Hostes";
            this.btnHostes.UseVisualStyleBackColor = true;
            this.btnHostes.Click += new System.EventHandler(this.btnHostes_Click);
            // 
            // btnHostProgram
            // 
            this.btnHostProgram.Location = new System.Drawing.Point(63, 214);
            this.btnHostProgram.Name = "btnHostProgram";
            this.btnHostProgram.Size = new System.Drawing.Size(171, 48);
            this.btnHostProgram.TabIndex = 3;
            this.btnHostProgram.Text = "Show Hostes and Programs";
            this.btnHostProgram.UseVisualStyleBackColor = true;
            this.btnHostProgram.Click += new System.EventHandler(this.btnHostProgram_Click);
            // 
            // ShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 340);
            this.Controls.Add(this.btnHostProgram);
            this.Controls.Add(this.btnHostes);
            this.Controls.Add(this.btnPrograms);
            this.Controls.Add(this.btnChannels);
            this.Name = "ShowAll";
            this.Text = "ShowAll";
            this.Load += new System.EventHandler(this.ShowAll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChannels;
        private System.Windows.Forms.Button btnPrograms;
        private System.Windows.Forms.Button btnHostes;
        private System.Windows.Forms.Button btnHostProgram;
    }
}