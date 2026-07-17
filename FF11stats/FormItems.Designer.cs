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
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point( 12, 12 );
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size( 760, 520 );
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Left ;
            button1.Location = new Point( 12, 538 );
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
            button2.Location = new Point( 93, 538 );
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
            textBox1.Location = new Point( 174, 538 );
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "アイテムの検索";
            textBox1.Size = new Size( 120, 23 );
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Left ;
            button3.Location = new Point( 300, 538 );
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
            button4.Location = new Point( 616, 538 );
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
            button5.Location = new Point( 697, 538 );
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
            // FormItems
            // 
            AcceptButton = button4;
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button5;
            ClientSize = new Size( 784, 573 );
            Controls.Add( button5 );
            Controls.Add( button4 );
            Controls.Add( button3 );
            Controls.Add( textBox1 );
            Controls.Add( button2 );
            Controls.Add( button1 );
            Controls.Add( flowLayoutPanel1 );
            DoubleBuffered = true;
            Name = "FormItems";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormItems";
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
    }
}