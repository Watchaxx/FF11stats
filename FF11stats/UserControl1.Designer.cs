namespace FF11stats
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange( new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 } );
            menuStrip1.Location = new Point( 0, 0 );
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size( 400, 24 );
            menuStrip1.TabIndex = 0;
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
            toolStripMenuItem5.Size = new Size( 188, 22 );
            toolStripMenuItem5.Text = "検索(&F)...";
            toolStripMenuItem5.Click +=  ToolStripMenuItem5_Click ;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size( 185, 6 );
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Image = Resource1.CheckBoxChecked;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size( 188, 22 );
            toolStripMenuItem6.Text = "全てコンプリートにする(&C)";
            toolStripMenuItem6.Click +=  ToolStripMenuItem6_Click ;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Image = Resource1.CheckBoxUnchecked;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size( 188, 22 );
            toolStripMenuItem7.Text = "全て未完にする(&I)";
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
            toolStripMenuItem8.Size = new Size( 214, 22 );
            toolStripMenuItem8.Text = "コンプリートを隠す(&H)";
            toolStripMenuItem8.Click +=  ToolStripMenuItem8_Click ;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point( 12, 27 );
            flowLayoutPanel1.Margin = new Padding( 12, 3, 12, 3 );
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size( 376, 232 );
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Right ;
            button1.Location = new Point( 232, 265 );
            button1.Name = "button1";
            button1.Size = new Size( 75, 23 );
            button1.TabIndex = 2;
            button1.Text = "&OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  Button1_Click ;
            // 
            // button2
            // 
            button2.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Right ;
            button2.Location = new Point( 313, 265 );
            button2.Margin = new Padding( 3, 3, 12, 12 );
            button2.Name = "button2";
            button2.Size = new Size( 75, 23 );
            button2.TabIndex = 3;
            button2.Text = "キャンセル";
            button2.UseVisualStyleBackColor = true;
            button2.Click +=  Button2_Click ;
            // 
            // label1
            // 
            label1.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Left ;
            label1.AutoSize = true;
            label1.Location = new Point( 12, 269 );
            label1.Margin = new Padding( 12, 0, 3, 12 );
            label1.Name = "label1";
            label1.Size = new Size( 38, 15 );
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add( label1 );
            Controls.Add( button2 );
            Controls.Add( button1 );
            Controls.Add( flowLayoutPanel1 );
            Controls.Add( menuStrip1 );
            Name = "UserControl1";
            Size = new Size( 400, 300 );
            menuStrip1.ResumeLayout( false );
            menuStrip1.PerformLayout();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

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
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}
