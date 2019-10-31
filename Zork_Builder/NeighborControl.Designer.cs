﻿namespace Zork_Builder
{
    partial class NeighborControl
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
            this.components = new System.ComponentModel.Container();
            this.directionTextBox = new System.Windows.Forms.TextBox();
            this.neighborsComboBox = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // directionTextBox
            // 
            this.directionTextBox.Location = new System.Drawing.Point(0, 0);
            this.directionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.directionTextBox.Name = "directionTextBox";
            this.directionTextBox.ReadOnly = true;
            this.directionTextBox.Size = new System.Drawing.Size(98, 22);
            this.directionTextBox.TabIndex = 0;
            this.directionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // neighborsComboBox
            // 
            this.neighborsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.roomsBindingSource, "Name", true));
            this.neighborsComboBox.DataSource = this.roomsBindingSource1;
            this.neighborsComboBox.DisplayMember = "Name";
            this.neighborsComboBox.FormattingEnabled = true;
            this.neighborsComboBox.Location = new System.Drawing.Point(0, 30);
            this.neighborsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.neighborsComboBox.Name = "neighborsComboBox";
            this.neighborsComboBox.Size = new System.Drawing.Size(98, 24);
            this.neighborsComboBox.TabIndex = 1;
            this.neighborsComboBox.ValueMember = "Description";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork_Builder.WorldViewModel);
            // 
            // worldViewModelBindingSource1
            // 
            this.worldViewModelBindingSource1.DataSource = typeof(Zork_Builder.WorldViewModel);
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.worldViewModelBindingSource1;
            // 
            // NeighborControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.neighborsComboBox);
            this.Controls.Add(this.directionTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NeighborControl";
            this.Size = new System.Drawing.Size(142, 62);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directionTextBox;
        private System.Windows.Forms.ComboBox neighborsComboBox;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource1;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
    }
}
