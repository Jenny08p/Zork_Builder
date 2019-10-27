namespace Zork_Builder
{
    partial class Button
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directionsButton
            // 
            this.directionsButton.Location = new System.Drawing.Point(3, 3);
            this.directionsButton.Name = "directionsButton";
            this.directionsButton.Size = new System.Drawing.Size(75, 69);
            this.directionsButton.TabIndex = 0;
            this.directionsButton.UseVisualStyleBackColor = true;
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.directionsButton);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(81, 78);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button directionsButton;
    }
}
