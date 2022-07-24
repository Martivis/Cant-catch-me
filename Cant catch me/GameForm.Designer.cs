namespace Cant_catch_me
{
    partial class GameForm
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
            this._runningButton = new System.Windows.Forms.Button();
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _runningButton
            // 
            this._runningButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._runningButton.Location = new System.Drawing.Point(105, 119);
            this._runningButton.Name = "_runningButton";
            this._runningButton.Size = new System.Drawing.Size(75, 23);
            this._runningButton.TabIndex = 0;
            this._runningButton.Text = "Ok";
            this._runningButton.UseVisualStyleBackColor = true;
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountdownLabel.AutoSize = true;
            this.CountdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 240F);
            this.CountdownLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CountdownLabel.Location = new System.Drawing.Point(-13, -51);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(0, 362);
            this.CountdownLabel.TabIndex = 1;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._runningButton);
            this.Controls.Add(this.CountdownLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Can\'t catch me!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _runningButton;
        private System.Windows.Forms.Label CountdownLabel;
    }
}