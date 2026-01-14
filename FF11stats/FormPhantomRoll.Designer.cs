namespace FF11stats
{
    partial class FormPhantomRoll
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox16 = new CheckBox();
            checkBox17 = new CheckBox();
            checkBox18 = new CheckBox();
            checkBox19 = new CheckBox();
            checkBox20 = new CheckBox();
            checkBox21 = new CheckBox();
            checkBox22 = new CheckBox();
            checkBox23 = new CheckBox();
            checkBox24 = new CheckBox();
            checkBox25 = new CheckBox();
            checkBox26 = new CheckBox();
            checkBox27 = new CheckBox();
            checkBox28 = new CheckBox();
            checkBox29 = new CheckBox();
            checkBox30 = new CheckBox();
            checkBox31 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange( new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 } );
            menuStrip1.Location = new Point( 0, 0 );
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size( 784, 24 );
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
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.ShortcutKeys =  Keys.Control  |  Keys.F ;
            toolStripMenuItem5.Size = new Size( 184, 22 );
            toolStripMenuItem5.Text = "検索(&F)...";
            toolStripMenuItem5.Click +=  ToolStripMenuItem5_Click ;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size( 181, 6 );
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size( 184, 22 );
            toolStripMenuItem6.Text = "全て習得済みにする(&L)";
            toolStripMenuItem6.Click +=  ToolStripMenuItem6_Click ;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size( 184, 22 );
            toolStripMenuItem7.Text = "全て未習得にする(&U)";
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
            toolStripMenuItem8.Size = new Size( 169, 22 );
            toolStripMenuItem8.Text = "習得済みを隠す(&H)";
            toolStripMenuItem8.Click +=  ToolStripMenuItem8_Click ;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point( 3, 3 );
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size( 103, 19 );
            checkBox1.TabIndex = 0;
            checkBox1.Text = "ファイターズロール";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point( 3, 28 );
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size( 89, 19 );
            checkBox2.TabIndex = 1;
            checkBox2.Text = "モンクスロール";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point( 3, 53 );
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size( 94, 19 );
            checkBox3.TabIndex = 2;
            checkBox3.Text = "ヒーラーズロール";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point( 3, 78 );
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size( 96, 19 );
            checkBox4.TabIndex = 3;
            checkBox4.Text = "ウィザーズロール";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point( 3, 103 );
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size( 105, 19 );
            checkBox5.TabIndex = 4;
            checkBox5.Text = "ワーロックスロール";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point( 3, 128 );
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size( 88, 19 );
            checkBox6.TabIndex = 5;
            checkBox6.Text = "ローグズロール";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point( 3, 153 );
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size( 89, 19 );
            checkBox7.TabIndex = 6;
            checkBox7.Text = "ガランツロール";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point( 3, 178 );
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size( 80, 19 );
            checkBox8.TabIndex = 7;
            checkBox8.Text = "カオスロール";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point( 3, 203 );
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size( 86, 19 );
            checkBox9.TabIndex = 8;
            checkBox9.Text = "ビーストロール";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point( 3, 228 );
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size( 87, 19 );
            checkBox10.TabIndex = 9;
            checkBox10.Text = "コーラルロール";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point( 3, 253 );
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size( 97, 19 );
            checkBox11.TabIndex = 10;
            checkBox11.Text = "ハンターズロール";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point( 3, 278 );
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size( 88, 19 );
            checkBox12.TabIndex = 11;
            checkBox12.Text = "サムライロール";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point( 3, 303 );
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size( 89, 19 );
            checkBox13.TabIndex = 12;
            checkBox13.Text = "ニンジャロール";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point( 3, 328 );
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size( 87, 19 );
            checkBox14.TabIndex = 13;
            checkBox14.Text = "ドラケンロール";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point( 3, 353 );
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size( 98, 19 );
            checkBox15.TabIndex = 14;
            checkBox15.Text = "エボカーズロール";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point( 3, 378 );
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size( 89, 19 );
            checkBox16.TabIndex = 15;
            checkBox16.Text = "メガスズロール";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point( 3, 403 );
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size( 99, 19 );
            checkBox17.TabIndex = 16;
            checkBox17.Text = "コルセアズロール";
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            checkBox18.AutoSize = true;
            checkBox18.Location = new Point( 3, 428 );
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size( 89, 19 );
            checkBox18.TabIndex = 17;
            checkBox18.Text = "パペットロール";
            checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            checkBox19.AutoSize = true;
            checkBox19.Location = new Point( 3, 453 );
            checkBox19.Name = "checkBox19";
            checkBox19.Size = new Size( 89, 19 );
            checkBox19.TabIndex = 18;
            checkBox19.Text = "ダンサーロール";
            checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            checkBox20.AutoSize = true;
            checkBox20.Location = new Point( 114, 3 );
            checkBox20.Name = "checkBox20";
            checkBox20.Size = new Size( 87, 19 );
            checkBox20.TabIndex = 19;
            checkBox20.Text = "スカラーロール";
            checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            checkBox21.AutoSize = true;
            checkBox21.Location = new Point( 114, 28 );
            checkBox21.Name = "checkBox21";
            checkBox21.Size = new Size( 99, 19 );
            checkBox21.TabIndex = 20;
            checkBox21.Text = "ボルターズロール";
            checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            checkBox22.AutoSize = true;
            checkBox22.Location = new Point( 114, 53 );
            checkBox22.Name = "checkBox22";
            checkBox22.Size = new Size( 105, 19 );
            checkBox22.TabIndex = 21;
            checkBox22.Text = "キャスターズロール";
            checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            checkBox23.AutoSize = true;
            checkBox23.Location = new Point( 114, 78 );
            checkBox23.Name = "checkBox23";
            checkBox23.Size = new Size( 97, 19 );
            checkBox23.TabIndex = 22;
            checkBox23.Text = "コアサーズロール";
            checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            checkBox24.AutoSize = true;
            checkBox24.Location = new Point( 114, 103 );
            checkBox24.Name = "checkBox24";
            checkBox24.Size = new Size( 94, 19 );
            checkBox24.TabIndex = 23;
            checkBox24.Text = "ブリッツァロール";
            checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            checkBox25.AutoSize = true;
            checkBox25.Location = new Point( 114, 128 );
            checkBox25.Name = "checkBox25";
            checkBox25.Size = new Size( 104, 19 );
            checkBox25.TabIndex = 24;
            checkBox25.Text = "タクティックロール";
            checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            checkBox26.AutoSize = true;
            checkBox26.Location = new Point( 114, 153 );
            checkBox26.Name = "checkBox26";
            checkBox26.Size = new Size( 88, 19 );
            checkBox26.TabIndex = 25;
            checkBox26.Text = "アライズロール";
            checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            checkBox27.AutoSize = true;
            checkBox27.Location = new Point( 114, 178 );
            checkBox27.Name = "checkBox27";
            checkBox27.Size = new Size( 89, 19 );
            checkBox27.TabIndex = 26;
            checkBox27.Text = "マイザーロール";
            checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            checkBox28.AutoSize = true;
            checkBox28.Location = new Point( 114, 203 );
            checkBox28.Name = "checkBox28";
            checkBox28.Size = new Size( 107, 19 );
            checkBox28.TabIndex = 27;
            checkBox28.Text = "コンパニオンロール";
            checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            checkBox29.AutoSize = true;
            checkBox29.Location = new Point( 114, 228 );
            checkBox29.Name = "checkBox29";
            checkBox29.Size = new Size( 97, 19 );
            checkBox29.TabIndex = 28;
            checkBox29.Text = "カウンターロール";
            checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            checkBox30.AutoSize = true;
            checkBox30.Location = new Point( 114, 253 );
            checkBox30.Name = "checkBox30";
            checkBox30.Size = new Size( 112, 19 );
            checkBox30.TabIndex = 29;
            checkBox30.Text = "ナチュラリストロール";
            checkBox30.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            checkBox31.AutoSize = true;
            checkBox31.Location = new Point( 114, 278 );
            checkBox31.Name = "checkBox31";
            checkBox31.Size = new Size( 97, 19 );
            checkBox31.TabIndex = 30;
            checkBox31.Text = "ルーニストロール";
            checkBox31.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Right ;
            button1.Location = new Point( 616, 526 );
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
            button2.Location = new Point( 697, 526 );
            button2.Name = "button2";
            button2.Size = new Size( 75, 23 );
            button2.TabIndex = 3;
            button2.Text = "キャンセル";
            button2.UseVisualStyleBackColor = true;
            button2.Click +=  Button2_Click ;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add( checkBox1 );
            flowLayoutPanel1.Controls.Add( checkBox2 );
            flowLayoutPanel1.Controls.Add( checkBox3 );
            flowLayoutPanel1.Controls.Add( checkBox4 );
            flowLayoutPanel1.Controls.Add( checkBox5 );
            flowLayoutPanel1.Controls.Add( checkBox6 );
            flowLayoutPanel1.Controls.Add( checkBox7 );
            flowLayoutPanel1.Controls.Add( checkBox8 );
            flowLayoutPanel1.Controls.Add( checkBox9 );
            flowLayoutPanel1.Controls.Add( checkBox10 );
            flowLayoutPanel1.Controls.Add( checkBox11 );
            flowLayoutPanel1.Controls.Add( checkBox12 );
            flowLayoutPanel1.Controls.Add( checkBox13 );
            flowLayoutPanel1.Controls.Add( checkBox14 );
            flowLayoutPanel1.Controls.Add( checkBox15 );
            flowLayoutPanel1.Controls.Add( checkBox16 );
            flowLayoutPanel1.Controls.Add( checkBox17 );
            flowLayoutPanel1.Controls.Add( checkBox18 );
            flowLayoutPanel1.Controls.Add( checkBox19 );
            flowLayoutPanel1.Controls.Add( checkBox20 );
            flowLayoutPanel1.Controls.Add( checkBox21 );
            flowLayoutPanel1.Controls.Add( checkBox22 );
            flowLayoutPanel1.Controls.Add( checkBox23 );
            flowLayoutPanel1.Controls.Add( checkBox24 );
            flowLayoutPanel1.Controls.Add( checkBox25 );
            flowLayoutPanel1.Controls.Add( checkBox26 );
            flowLayoutPanel1.Controls.Add( checkBox27 );
            flowLayoutPanel1.Controls.Add( checkBox28 );
            flowLayoutPanel1.Controls.Add( checkBox29 );
            flowLayoutPanel1.Controls.Add( checkBox30 );
            flowLayoutPanel1.Controls.Add( checkBox31 );
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point( 12, 27 );
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size( 760, 493 );
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Left ;
            label1.AutoSize = true;
            label1.Location = new Point( 12, 530 );
            label1.Name = "label1";
            label1.Size = new Size( 38, 15 );
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // FormPhantomRoll
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size( 784, 561 );
            Controls.Add( label1 );
            Controls.Add( flowLayoutPanel1 );
            Controls.Add( button2 );
            Controls.Add( button1 );
            Controls.Add( menuStrip1 );
            MainMenuStrip = menuStrip1;
            Name = "FormPhantomRoll";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ファントムロール";
            menuStrip1.ResumeLayout( false );
            menuStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout( false );
            flowLayoutPanel1.PerformLayout();
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
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private CheckBox checkBox18;
        private CheckBox checkBox19;
        private CheckBox checkBox20;
        private CheckBox checkBox21;
        private CheckBox checkBox22;
        private CheckBox checkBox23;
        private CheckBox checkBox24;
        private CheckBox checkBox25;
        private CheckBox checkBox26;
        private CheckBox checkBox27;
        private CheckBox checkBox28;
        private CheckBox checkBox29;
        private CheckBox checkBox30;
        private CheckBox checkBox31;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}