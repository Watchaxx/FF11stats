namespace FF11stats
{
    partial class FormItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            contextMenuStrip1 = new ContextMenuStrip( components );
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point( 12, 27 );
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size( 760, 424 );
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Left ;
            button1.Location = new Point( 12, 457 );
            button1.Name = "button1";
            button1.Size = new Size( 75, 23 );
            button1.TabIndex = 1;
            button1.Text = "全て預け(&A)";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  Button1_Click ;
            // 
            // button2
            // 
            button2.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Left ;
            button2.Location = new Point( 93, 457 );
            button2.Name = "button2";
            button2.Size = new Size( 75, 23 );
            button2.TabIndex = 2;
            button2.Text = "リセット(&R)";
            button2.UseVisualStyleBackColor = true;
            button2.Click +=  Button2_Click ;
            // 
            // textBox1
            // 
            textBox1.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Left ;
            textBox1.ImeMode = ImeMode.On;
            textBox1.Location = new Point( 174, 457 );
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "アイテムの検索";
            textBox1.Size = new Size( 120, 23 );
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Left ;
            button3.Location = new Point( 300, 457 );
            button3.Name = "button3";
            button3.Size = new Size( 75, 23 );
            button3.TabIndex = 4;
            button3.Text = "検索(&F)";
            button3.UseVisualStyleBackColor = true;
            button3.Click +=  Button3_Click ;
            // 
            // button4
            // 
            button4.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Right ;
            button4.Location = new Point( 616, 457 );
            button4.Name = "button4";
            button4.Size = new Size( 75, 23 );
            button4.TabIndex = 5;
            button4.Text = "&OK";
            button4.UseVisualStyleBackColor = true;
            button4.Click +=  Button4_Click ;
            // 
            // button5
            // 
            button5.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Right ;
            button5.Location = new Point( 697, 457 );
            button5.Name = "button5";
            button5.Size = new Size( 75, 23 );
            button5.TabIndex = 6;
            button5.Text = "キャンセル(&C)";
            button5.UseVisualStyleBackColor = true;
            button5.Click +=  Button5_Click ;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size( 61, 4 );
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange( new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 } );
            menuStrip1.Location = new Point( 0, 0 );
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size( 784, 24 );
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange( new ToolStripItem[] { toolStripMenuItem4 } );
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size( 67, 20 );
            toolStripMenuItem1.Text = "ファイル(&F)";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size( 128, 22 );
            toolStripMenuItem4.Text = "閉じる(&C)...";
            toolStripMenuItem4.Click +=  ToolStripMenuItem4_Click ;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange( new ToolStripItem[] { toolStripMenuItem5, toolStripSeparator1, toolStripMenuItem6, toolStripMenuItem7 } );
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size( 57, 20 );
            toolStripMenuItem2.Text = "編集(&E)";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Image = Resource1.Search;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.ShortcutKeys =  Keys.Control  |  Keys.F ;
            toolStripMenuItem5.Size = new Size( 151, 22 );
            toolStripMenuItem5.Text = "検索(&F)";
            toolStripMenuItem5.Click +=  ToolStripMenuItem5_Click ;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size( 148, 6 );
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Image = Resource1.CheckBoxChecked;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size( 151, 22 );
            toolStripMenuItem6.Text = "全て預ける(&A)";
            toolStripMenuItem6.Click +=  ToolStripMenuItem6_Click ;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Image = Resource1.CheckBoxUnchecked;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size( 151, 22 );
            toolStripMenuItem7.Text = "リセット(&R)";
            toolStripMenuItem7.Click +=  ToolStripMenuItem7_Click ;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange( new ToolStripItem[] { toolStripMenuItem8 } );
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size( 58, 20 );
            toolStripMenuItem3.Text = "表示(&V)";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.CheckOnClick = true;
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.ShortcutKeys =  Keys.Control  |  Keys.H ;
            toolStripMenuItem8.Size = new Size( 230, 22 );
            toolStripMenuItem8.Text = "預けたアイテムを隠す(&H)";
            toolStripMenuItem8.Click +=  ToolStripMenuItem8_Click ;
            // 
            // FormItems
            // 
            AcceptButton = button4;
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button5;
            ClientSize = new Size( 784, 492 );
            Controls.Add( menuStrip1 );
            Controls.Add( button5 );
            Controls.Add( button4 );
            Controls.Add( button3 );
            Controls.Add( textBox1 );
            Controls.Add( button2 );
            Controls.Add( button1 );
            Controls.Add( flowLayoutPanel1 );
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "FormItems";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormItems";
            menuStrip1.ResumeLayout( false );
            menuStrip1.PerformLayout();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem8;
    }
}