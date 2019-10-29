namespace Zork_Builder
{
    partial class Zork_Form
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.directionButton4 = new Zork_Builder.directionButton();
            this.directionButton3 = new Zork_Builder.directionButton();
            this.directionButton2 = new Zork_Builder.directionButton();
            this.directionButton1 = new Zork_Builder.directionButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.mainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.playToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(443, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldToolStripMenuItem,
            this.openWorldCtrlOToolStripMenuItem,
            this.closeWorldToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveCtrlSToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(46, 24);
            this.FileMenu.Text = "File";
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.newWorldToolStripMenuItem.Text = "New World";
            // 
            // openWorldCtrlOToolStripMenuItem
            // 
            this.openWorldCtrlOToolStripMenuItem.Name = "openWorldCtrlOToolStripMenuItem";
            this.openWorldCtrlOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldCtrlOToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.openWorldCtrlOToolStripMenuItem.Text = "Open World";
            // 
            // closeWorldToolStripMenuItem
            // 
            this.closeWorldToolStripMenuItem.Name = "closeWorldToolStripMenuItem";
            this.closeWorldToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.closeWorldToolStripMenuItem.Text = "Close";
            this.closeWorldToolStripMenuItem.Click += new System.EventHandler(this.closeWorldToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // saveCtrlSToolStripMenuItem
            // 
            this.saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            this.saveCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.saveCtrlSToolStripMenuItem.Text = "Save... ";
            this.saveCtrlSToolStripMenuItem.Click += new System.EventHandler(this.SaveCtrlSToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.saveAsToolStripMenuItem.Text = "Save as...      ";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.playToolStripMenuItem.Text = "Play ";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Work Files (*json)|*.json";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(561, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(77, 24);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel_Buttons
            // 
            this.flowLayoutPanel_Buttons.AutoSize = true;
            this.flowLayoutPanel_Buttons.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel_Buttons.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel_Buttons.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel_Buttons.Name = "flowLayoutPanel_Buttons";
            this.flowLayoutPanel_Buttons.Size = new System.Drawing.Size(443, 0);
            this.flowLayoutPanel_Buttons.TabIndex = 6;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.AllowNew = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.directionButton4);
            this.tabPage2.Controls.Add(this.directionButton3);
            this.tabPage2.Controls.Add(this.directionButton2);
            this.tabPage2.Controls.Add(this.directionButton1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.addRoomButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(905, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // directionButton4
            // 
            this.directionButton4.Location = new System.Drawing.Point(122, 332);
            this.directionButton4.Name = "directionButton4";
            this.directionButton4.Size = new System.Drawing.Size(112, 74);
            this.directionButton4.TabIndex = 18;
            // 
            // directionButton3
            // 
            this.directionButton3.Location = new System.Drawing.Point(3, 332);
            this.directionButton3.Name = "directionButton3";
            this.directionButton3.Size = new System.Drawing.Size(94, 70);
            this.directionButton3.TabIndex = 17;
            // 
            // directionButton2
            // 
            this.directionButton2.Location = new System.Drawing.Point(122, 258);
            this.directionButton2.Name = "directionButton2";
            this.directionButton2.Size = new System.Drawing.Size(91, 78);
            this.directionButton2.TabIndex = 16;
            // 
            // directionButton1
            // 
            this.directionButton1.Location = new System.Drawing.Point(3, 258);
            this.directionButton1.Name = "directionButton1";
            this.directionButton1.Size = new System.Drawing.Size(93, 78);
            this.directionButton1.TabIndex = 15;
            this.directionButton1.Load += new System.EventHandler(this.directionButton1_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Starting Location";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(247, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rooms";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(268, 420);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete Room";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(247, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(155, 308);
            this.listBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.textBox2.Location = new System.Drawing.Point(15, 101);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 151);
            this.textBox2.TabIndex = 6;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataSource = typeof(Zork_Common.Room);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.textBox1.Location = new System.Drawing.Point(15, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 5;
            // 
            // addRoomButton
            // 
            this.addRoomButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addRoomButton.Location = new System.Drawing.Point(63, 420);
            this.addRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(93, 34);
            this.addRoomButton.TabIndex = 4;
            this.addRoomButton.Text = "Add Room";
            this.addRoomButton.UseVisualStyleBackColor = true;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabPage2);
            this.mainTab.Location = new System.Drawing.Point(12, 34);
            this.mainTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(913, 498);
            this.mainTab.TabIndex = 11;
            // 
            // Zork_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(443, 556);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.flowLayoutPanel_Buttons);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Zork_Form";
            this.Text = "Zork_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.mainTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Buttons;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.TabControl mainTab;
        public System.Windows.Forms.Label label4;
        private directionButton directionButton1;
        private directionButton directionButton4;
        private directionButton directionButton3;
        private directionButton directionButton2;
        private System.Windows.Forms.BindingSource roomsBindingSource;
    }
}

