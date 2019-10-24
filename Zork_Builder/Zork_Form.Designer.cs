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
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TextBox_RoomSearch = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_AddRoom = new System.Windows.Forms.Button();
            this.tabControl_Form = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_RoomName = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.button_Neighbor_N = new System.Windows.Forms.Button();
            this.textBox_North = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Neighbor_S = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_Neighbor_E = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_Neighbor_W = new System.Windows.Forms.Button();
            this.textBox_Room = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl_Form.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.editToolStripMenuItem,
            this.playToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
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
            this.newWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newWorldToolStripMenuItem.Text = "New World ";
            // 
            // openWorldCtrlOToolStripMenuItem
            // 
            this.openWorldCtrlOToolStripMenuItem.Name = "openWorldCtrlOToolStripMenuItem";
            this.openWorldCtrlOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldCtrlOToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openWorldCtrlOToolStripMenuItem.Text = "Open World";
            this.openWorldCtrlOToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldCtrlOToolStripMenuItem_Click);
            // 
            // closeWorldToolStripMenuItem
            // 
            this.closeWorldToolStripMenuItem.Name = "closeWorldToolStripMenuItem";
            this.closeWorldToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.closeWorldToolStripMenuItem.Text = "Close World ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // saveCtrlSToolStripMenuItem
            // 
            this.saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            this.saveCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveCtrlSToolStripMenuItem.Text = "Save...";
            this.saveCtrlSToolStripMenuItem.Click += new System.EventHandler(this.SaveCtrlSToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
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
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // copyCtrlCToolStripMenuItem
            // 
            this.copyCtrlCToolStripMenuItem.Name = "copyCtrlCToolStripMenuItem";
            this.copyCtrlCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyCtrlCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyCtrlCToolStripMenuItem.Text = "Copy";
            // 
            // pasteCtrlVToolStripMenuItem
            // 
            this.pasteCtrlVToolStripMenuItem.Name = "pasteCtrlVToolStripMenuItem";
            this.pasteCtrlVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteCtrlVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteCtrlVToolStripMenuItem.Text = "Paste";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.playToolStripMenuItem.Text = "Play ";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
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
            this.TextBox_RoomSearch.Location = new System.Drawing.Point(3, 3);
            this.TextBox_RoomSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBox_RoomSearch.Name = "TextBox_RoomSearch";
            this.TextBox_RoomSearch.Size = new System.Drawing.Size(730, 20);
            this.TextBox_RoomSearch.TabIndex = 4;
            this.TextBox_RoomSearch.Text = "RoomSearch:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(421, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(59, 20);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel_Buttons
            // 
            this.flowLayoutPanel_Buttons.AutoSize = true;
            this.flowLayoutPanel_Buttons.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel_Buttons.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel_Buttons.Name = "flowLayoutPanel_Buttons";
            this.flowLayoutPanel_Buttons.Size = new System.Drawing.Size(744, 0);
            this.flowLayoutPanel_Buttons.TabIndex = 6;
            // 
            // Button_AddRoom
            // 
            this.Button_AddRoom.Location = new System.Drawing.Point(7, 27);
            this.Button_AddRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_AddRoom.Name = "Button_AddRoom";
            this.Button_AddRoom.Size = new System.Drawing.Size(56, 39);
            this.Button_AddRoom.TabIndex = 3;
            this.Button_AddRoom.Text = "Add";
            this.Button_AddRoom.UseVisualStyleBackColor = true;
            this.Button_AddRoom.Click += new System.EventHandler(this.Button_AddRoom_Click);
            // 
            // tabControl_Form
            // 
            this.tabControl_Form.Controls.Add(this.tabPage1);
            this.tabControl_Form.Controls.Add(this.tabPage2);
            this.tabControl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Form.Location = new System.Drawing.Point(0, 24);
            this.tabControl_Form.Name = "tabControl_Form";
            this.tabControl_Form.SelectedIndex = 0;
            this.tabControl_Form.Size = new System.Drawing.Size(744, 572);
            this.tabControl_Form.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox_Room);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.button_Neighbor_W);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button_Neighbor_E);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button_Neighbor_S);
            this.tabPage1.Controls.Add(this.textBox_North);
            this.tabPage1.Controls.Add(this.button_Neighbor_N);
            this.tabPage1.Controls.Add(this.textBox_Description);
            this.tabPage1.Controls.Add(this.textBox_RoomName);
            this.tabPage1.Controls.Add(this.TextBox_RoomSearch);
            this.tabPage1.Controls.Add(this.Button_AddRoom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Room";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_RoomName
            // 
            this.textBox_RoomName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_RoomName.Location = new System.Drawing.Point(154, 63);
            this.textBox_RoomName.Name = "textBox_RoomName";
            this.textBox_RoomName.Size = new System.Drawing.Size(364, 20);
            this.textBox_RoomName.TabIndex = 5;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Description.Location = new System.Drawing.Point(154, 310);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(364, 143);
            this.textBox_Description.TabIndex = 7;
            // 
            // button_Neighbor_N
            // 
            this.button_Neighbor_N.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Neighbor_N.Location = new System.Drawing.Point(311, 98);
            this.button_Neighbor_N.Name = "button_Neighbor_N";
            this.button_Neighbor_N.Size = new System.Drawing.Size(47, 41);
            this.button_Neighbor_N.TabIndex = 8;
            this.button_Neighbor_N.Text = "North";
            this.button_Neighbor_N.UseVisualStyleBackColor = true;
            // 
            // textBox_North
            // 
            this.textBox_North.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_North.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_North.Location = new System.Drawing.Point(297, 145);
            this.textBox_North.Name = "textBox_North";
            this.textBox_North.Size = new System.Drawing.Size(76, 13);
            this.textBox_North.TabIndex = 9;
            this.textBox_North.Text = "< RoomName >";
            this.textBox_North.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(297, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 13);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "< RoomName >";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Neighbor_S
            // 
            this.button_Neighbor_S.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Neighbor_S.Location = new System.Drawing.Point(311, 235);
            this.button_Neighbor_S.Name = "button_Neighbor_S";
            this.button_Neighbor_S.Size = new System.Drawing.Size(47, 41);
            this.button_Neighbor_S.TabIndex = 10;
            this.button_Neighbor_S.Text = "South";
            this.button_Neighbor_S.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(393, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 13);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "< RoomName >";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Neighbor_E
            // 
            this.button_Neighbor_E.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Neighbor_E.Location = new System.Drawing.Point(405, 169);
            this.button_Neighbor_E.Name = "button_Neighbor_E";
            this.button_Neighbor_E.Size = new System.Drawing.Size(47, 41);
            this.button_Neighbor_E.TabIndex = 12;
            this.button_Neighbor_E.Text = "East";
            this.button_Neighbor_E.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(207, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 13);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "< RoomName >";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Neighbor_W
            // 
            this.button_Neighbor_W.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Neighbor_W.Location = new System.Drawing.Point(221, 169);
            this.button_Neighbor_W.Name = "button_Neighbor_W";
            this.button_Neighbor_W.Size = new System.Drawing.Size(47, 41);
            this.button_Neighbor_W.TabIndex = 14;
            this.button_Neighbor_W.Text = "West";
            this.button_Neighbor_W.UseVisualStyleBackColor = true;
            // 
            // textBox_Room
            // 
            this.textBox_Room.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Room.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Room.Location = new System.Drawing.Point(154, 44);
            this.textBox_Room.Name = "textBox_Room";
            this.textBox_Room.Size = new System.Drawing.Size(76, 13);
            this.textBox_Room.TabIndex = 16;
            this.textBox_Room.Text = "Room:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(154, 291);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 13);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Description:";
            // 
            // Zork_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(744, 596);
            this.Controls.Add(this.tabControl_Form);
            this.Controls.Add(this.flowLayoutPanel_Buttons);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Zork_Form";
            this.Text = "Zork_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl_Form.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TextBox_RoomSearch;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Buttons;
        private System.Windows.Forms.Button Button_AddRoom;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_Form;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_RoomName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Neighbor_N;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_Neighbor_W;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_Neighbor_E;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Neighbor_S;
        private System.Windows.Forms.TextBox textBox_North;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox_Room;
    }
}

