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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zork_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_AddRoom = new System.Windows.Forms.PictureBox();
            this.Button_RunZork = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TextBox_RoomSearch = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_RunZork)).BeginInit();
            this.flowLayoutPanel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldToolStripMenuItem,
            this.openWorldCtrlOToolStripMenuItem,
            this.closeWorldToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveCtrlSToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            this.FileMenu.Click += new System.EventHandler(this.FileMenu_Click);
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.newWorldToolStripMenuItem.Text = "New World           Ctrl + N ";
            // 
            // openWorldCtrlOToolStripMenuItem
            // 
            this.openWorldCtrlOToolStripMenuItem.Name = "openWorldCtrlOToolStripMenuItem";
            this.openWorldCtrlOToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.openWorldCtrlOToolStripMenuItem.Text = "Open World         Ctrl + O";
            this.openWorldCtrlOToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldCtrlOToolStripMenuItem_Click);
            // 
            // closeWorldToolStripMenuItem
            // 
            this.closeWorldToolStripMenuItem.Name = "closeWorldToolStripMenuItem";
            this.closeWorldToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.closeWorldToolStripMenuItem.Text = "Close World ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // saveCtrlSToolStripMenuItem
            // 
            this.saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            this.saveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.saveCtrlSToolStripMenuItem.Text = "Save...                  Ctrl + S";
            this.saveCtrlSToolStripMenuItem.Click += new System.EventHandler(this.SaveCtrlSToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...        Shift + Ctrl + S";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.copyCtrlCToolStripMenuItem,
            this.pasteCtrlVToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.undoToolStripMenuItem.Text = "Undo            Ctrl + Z";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.redoToolStripMenuItem.Text = "Redo            Ctrl + Y";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // copyCtrlCToolStripMenuItem
            // 
            this.copyCtrlCToolStripMenuItem.Name = "copyCtrlCToolStripMenuItem";
            this.copyCtrlCToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.copyCtrlCToolStripMenuItem.Text = "Copy            Ctrl + C";
            // 
            // pasteCtrlVToolStripMenuItem
            // 
            this.pasteCtrlVToolStripMenuItem.Name = "pasteCtrlVToolStripMenuItem";
            this.pasteCtrlVToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pasteCtrlVToolStripMenuItem.Text = "Paste            Ctrl + V";
            // 
            // Button_AddRoom
            // 
            this.Button_AddRoom.Image = global::Zork_Builder.Properties.Resources.addbutton2;
            this.Button_AddRoom.Location = new System.Drawing.Point(43, 2);
            this.Button_AddRoom.Margin = new System.Windows.Forms.Padding(2);
            this.Button_AddRoom.Name = "Button_AddRoom";
            this.Button_AddRoom.Size = new System.Drawing.Size(41, 40);
            this.Button_AddRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_AddRoom.TabIndex = 1;
            this.Button_AddRoom.TabStop = false;
            // 
            // Button_RunZork
            // 
            this.Button_RunZork.Image = global::Zork_Builder.Properties.Resources.play_button;
            this.Button_RunZork.Location = new System.Drawing.Point(2, 2);
            this.Button_RunZork.Margin = new System.Windows.Forms.Padding(2);
            this.Button_RunZork.Name = "Button_RunZork";
            this.Button_RunZork.Size = new System.Drawing.Size(37, 37);
            this.Button_RunZork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_RunZork.TabIndex = 2;
            this.Button_RunZork.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextBox_RoomSearch
            // 
            this.TextBox_RoomSearch.BackColor = System.Drawing.Color.White;
            this.TextBox_RoomSearch.CausesValidation = false;
            this.TextBox_RoomSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox_RoomSearch.Location = new System.Drawing.Point(0, 24);
            this.TextBox_RoomSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_RoomSearch.Name = "TextBox_RoomSearch";
            this.TextBox_RoomSearch.Size = new System.Drawing.Size(641, 20);
            this.TextBox_RoomSearch.TabIndex = 4;
            this.TextBox_RoomSearch.Text = "RoomSearch";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(421, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(59, 20);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel_Buttons
            // 
            this.flowLayoutPanel_Buttons.AutoSize = true;
            this.flowLayoutPanel_Buttons.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_Buttons.Controls.Add(this.Button_RunZork);
            this.flowLayoutPanel_Buttons.Controls.Add(this.Button_AddRoom);
            this.flowLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel_Buttons.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel_Buttons.Name = "flowLayoutPanel_Buttons";
            this.flowLayoutPanel_Buttons.Size = new System.Drawing.Size(641, 44);
            this.flowLayoutPanel_Buttons.TabIndex = 6;
            // 
            // Zork_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(641, 412);
            this.Controls.Add(this.flowLayoutPanel_Buttons);
            this.Controls.Add(this.TextBox_RoomSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Zork_Form";
            this.Text = "Zork_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_AddRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_RunZork)).EndInit();
            this.flowLayoutPanel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteCtrlVToolStripMenuItem;
        private System.Windows.Forms.PictureBox Button_AddRoom;
        private System.Windows.Forms.PictureBox Button_RunZork;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TextBox_RoomSearch;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Buttons;
    }
}

