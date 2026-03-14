namespace FF11Stats
{
    partial class FormFaithPoints
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.Location = new Point( 12, 12 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.Size = new Size( 573, 368 );
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Left ;
            button1.Location = new Point( 12, 526 );
            button1.Name = "button1";
            button1.Size = new Size( 90, 23 );
            button1.TabIndex = 1;
            button1.Text = "全て最大値(&X)";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  Button1_Click ;
            // 
            // button2
            // 
            button2.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Left ;
            button2.Location = new Point( 108, 526 );
            button2.Name = "button2";
            button2.Size = new Size( 90, 23 );
            button2.TabIndex = 2;
            button2.Text = "全て最小値(&N)";
            button2.UseVisualStyleBackColor = true;
            button2.Click +=  Button2_Click ;
            // 
            // button3
            // 
            button3.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Right ;
            button3.Location = new Point( 610, 526 );
            button3.Name = "button3";
            button3.Size = new Size( 78, 23 );
            button3.TabIndex = 3;
            button3.Text = "&OK";
            button3.UseVisualStyleBackColor = true;
            button3.Click +=  Button3_Click ;
            // 
            // button4
            // 
            button4.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Right ;
            button4.Location = new Point( 694, 526 );
            button4.Name = "button4";
            button4.Size = new Size( 78, 23 );
            button4.TabIndex = 4;
            button4.Text = "キャンセル(&C)";
            button4.UseVisualStyleBackColor = true;
            button4.Click +=  Button4_Click ;
            // 
            // FormFaithPoints
            // 
            AcceptButton = button3;
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button4;
            ClientSize = new Size( 784, 561 );
            Controls.Add( button4 );
            Controls.Add( button3 );
            Controls.Add( button2 );
            Controls.Add( button1 );
            Controls.Add( tableLayoutPanel1 );
            Name = "FormFaithPoints";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "フェイスポイント/";
            ResumeLayout( false );
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}