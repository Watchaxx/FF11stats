namespace FF11stats
{
    partial class FormMagicNinjutsu
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ma0318 = new CheckBox();
            ma0319 = new CheckBox();
            ma0320 = new CheckBox();
            ma0321 = new CheckBox();
            ma0322 = new CheckBox();
            ma0323 = new CheckBox();
            ma0324 = new CheckBox();
            ma0325 = new CheckBox();
            ma0326 = new CheckBox();
            ma0327 = new CheckBox();
            ma0328 = new CheckBox();
            ma0329 = new CheckBox();
            ma0330 = new CheckBox();
            ma0331 = new CheckBox();
            ma0332 = new CheckBox();
            ma0333 = new CheckBox();
            ma0334 = new CheckBox();
            ma0335 = new CheckBox();
            ma0336 = new CheckBox();
            ma0337 = new CheckBox();
            ma0338 = new CheckBox();
            ma0339 = new CheckBox();
            ma0340 = new CheckBox();
            ma0341 = new CheckBox();
            ma0344 = new CheckBox();
            ma0345 = new CheckBox();
            ma0347 = new CheckBox();
            ma0348 = new CheckBox();
            ma0350 = new CheckBox();
            ma0353 = new CheckBox();
            ma0354 = new CheckBox();
            ma0505 = new CheckBox();
            ma0506 = new CheckBox();
            ma0507 = new CheckBox();
            ma0508 = new CheckBox();
            ma0509 = new CheckBox();
            ma0510 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            toolStripMenuItem5.Image = Resource1.Search;
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
            toolStripMenuItem6.Image = Resource1.CheckBoxChecked;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size( 184, 22 );
            toolStripMenuItem6.Text = "全て習得済みにする(&L)";
            toolStripMenuItem6.Click +=  ToolStripMenuItem6_Click ;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Image = Resource1.CheckBoxUnchecked;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.Controls.Add( ma0318, 0, 0 );
            tableLayoutPanel1.Controls.Add( ma0319, 0, 1 );
            tableLayoutPanel1.Controls.Add( ma0320, 0, 2 );
            tableLayoutPanel1.Controls.Add( ma0321, 1, 2 );
            tableLayoutPanel1.Controls.Add( ma0322, 2, 2 );
            tableLayoutPanel1.Controls.Add( ma0323, 0, 3 );
            tableLayoutPanel1.Controls.Add( ma0324, 1, 3 );
            tableLayoutPanel1.Controls.Add( ma0325, 2, 3 );
            tableLayoutPanel1.Controls.Add( ma0326, 0, 4 );
            tableLayoutPanel1.Controls.Add( ma0327, 1, 4 );
            tableLayoutPanel1.Controls.Add( ma0328, 2, 4 );
            tableLayoutPanel1.Controls.Add( ma0329, 0, 5 );
            tableLayoutPanel1.Controls.Add( ma0330, 1, 5 );
            tableLayoutPanel1.Controls.Add( ma0331, 2, 5 );
            tableLayoutPanel1.Controls.Add( ma0332, 0, 6 );
            tableLayoutPanel1.Controls.Add( ma0333, 1, 6 );
            tableLayoutPanel1.Controls.Add( ma0334, 2, 6 );
            tableLayoutPanel1.Controls.Add( ma0335, 0, 7 );
            tableLayoutPanel1.Controls.Add( ma0336, 1, 7 );
            tableLayoutPanel1.Controls.Add( ma0337, 2, 7 );
            tableLayoutPanel1.Controls.Add( ma0338, 0, 8 );
            tableLayoutPanel1.Controls.Add( ma0339, 1, 8 );
            tableLayoutPanel1.Controls.Add( ma0340, 2, 8 );
            tableLayoutPanel1.Controls.Add( ma0341, 0, 9 );
            tableLayoutPanel1.Controls.Add( ma0344, 0, 10 );
            tableLayoutPanel1.Controls.Add( ma0345, 1, 10 );
            tableLayoutPanel1.Controls.Add( ma0347, 0, 11 );
            tableLayoutPanel1.Controls.Add( ma0348, 1, 11 );
            tableLayoutPanel1.Controls.Add( ma0350, 0, 12 );
            tableLayoutPanel1.Controls.Add( ma0353, 0, 13 );
            tableLayoutPanel1.Controls.Add( ma0354, 1, 13 );
            tableLayoutPanel1.Controls.Add( ma0505, 0, 14 );
            tableLayoutPanel1.Controls.Add( ma0506, 0, 15 );
            tableLayoutPanel1.Controls.Add( ma0507, 0, 16 );
            tableLayoutPanel1.Controls.Add( ma0508, 0, 17 );
            tableLayoutPanel1.Controls.Add( ma0509, 0, 18 );
            tableLayoutPanel1.Controls.Add( ma0510, 0, 19 );
            tableLayoutPanel1.Location = new Point( 12, 27 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 20;
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.Size = new Size( 300, 504 );
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ma0318
            // 
            ma0318.AutoSize = true;
            ma0318.Location = new Point( 3, 3 );
            ma0318.Name = "ma0318";
            ma0318.Size = new Size( 87, 19 );
            ma0318.TabIndex = 0;
            ma0318.Text = "物見の術:壱";
            ma0318.UseVisualStyleBackColor = true;
            // 
            // ma0319
            // 
            ma0319.AutoSize = true;
            ma0319.Location = new Point( 3, 28 );
            ma0319.Name = "ma0319";
            ma0319.Size = new Size( 87, 19 );
            ma0319.TabIndex = 1;
            ma0319.Text = "哀車の術:壱";
            ma0319.UseVisualStyleBackColor = true;
            // 
            // ma0320
            // 
            ma0320.AutoSize = true;
            ma0320.Location = new Point( 3, 53 );
            ma0320.Name = "ma0320";
            ma0320.Size = new Size( 87, 19 );
            ma0320.TabIndex = 2;
            ma0320.Text = "火遁の術:壱";
            ma0320.UseVisualStyleBackColor = true;
            // 
            // ma0321
            // 
            ma0321.AutoSize = true;
            ma0321.Location = new Point( 96, 53 );
            ma0321.Name = "ma0321";
            ma0321.Size = new Size( 87, 19 );
            ma0321.TabIndex = 3;
            ma0321.Text = "火遁の術:弐";
            ma0321.UseVisualStyleBackColor = true;
            // 
            // ma0322
            // 
            ma0322.AutoSize = true;
            ma0322.Location = new Point( 189, 53 );
            ma0322.Name = "ma0322";
            ma0322.Size = new Size( 87, 19 );
            ma0322.TabIndex = 4;
            ma0322.Text = "火遁の術:参";
            ma0322.UseVisualStyleBackColor = true;
            // 
            // ma0323
            // 
            ma0323.AutoSize = true;
            ma0323.Location = new Point( 3, 78 );
            ma0323.Name = "ma0323";
            ma0323.Size = new Size( 87, 19 );
            ma0323.TabIndex = 5;
            ma0323.Text = "氷遁の術:壱";
            ma0323.UseVisualStyleBackColor = true;
            // 
            // ma0324
            // 
            ma0324.AutoSize = true;
            ma0324.Location = new Point( 96, 78 );
            ma0324.Name = "ma0324";
            ma0324.Size = new Size( 87, 19 );
            ma0324.TabIndex = 6;
            ma0324.Text = "氷遁の術:弐";
            ma0324.UseVisualStyleBackColor = true;
            // 
            // ma0325
            // 
            ma0325.AutoSize = true;
            ma0325.Location = new Point( 189, 78 );
            ma0325.Name = "ma0325";
            ma0325.Size = new Size( 87, 19 );
            ma0325.TabIndex = 7;
            ma0325.Text = "氷遁の術:参";
            ma0325.UseVisualStyleBackColor = true;
            // 
            // ma0326
            // 
            ma0326.AutoSize = true;
            ma0326.Location = new Point( 3, 103 );
            ma0326.Name = "ma0326";
            ma0326.Size = new Size( 87, 19 );
            ma0326.TabIndex = 8;
            ma0326.Text = "風遁の術:壱";
            ma0326.UseVisualStyleBackColor = true;
            // 
            // ma0327
            // 
            ma0327.AutoSize = true;
            ma0327.Location = new Point( 96, 103 );
            ma0327.Name = "ma0327";
            ma0327.Size = new Size( 87, 19 );
            ma0327.TabIndex = 9;
            ma0327.Text = "風遁の術:弐";
            ma0327.UseVisualStyleBackColor = true;
            // 
            // ma0328
            // 
            ma0328.AutoSize = true;
            ma0328.Location = new Point( 189, 103 );
            ma0328.Name = "ma0328";
            ma0328.Size = new Size( 87, 19 );
            ma0328.TabIndex = 10;
            ma0328.Text = "風遁の術:参";
            ma0328.UseVisualStyleBackColor = true;
            // 
            // ma0329
            // 
            ma0329.AutoSize = true;
            ma0329.Location = new Point( 3, 128 );
            ma0329.Name = "ma0329";
            ma0329.Size = new Size( 87, 19 );
            ma0329.TabIndex = 11;
            ma0329.Text = "土遁の術:壱";
            ma0329.UseVisualStyleBackColor = true;
            // 
            // ma0330
            // 
            ma0330.AutoSize = true;
            ma0330.Location = new Point( 96, 128 );
            ma0330.Name = "ma0330";
            ma0330.Size = new Size( 87, 19 );
            ma0330.TabIndex = 12;
            ma0330.Text = "土遁の術:弐";
            ma0330.UseVisualStyleBackColor = true;
            // 
            // ma0331
            // 
            ma0331.AutoSize = true;
            ma0331.Location = new Point( 189, 128 );
            ma0331.Name = "ma0331";
            ma0331.Size = new Size( 87, 19 );
            ma0331.TabIndex = 13;
            ma0331.Text = "土遁の術:参";
            ma0331.UseVisualStyleBackColor = true;
            // 
            // ma0332
            // 
            ma0332.AutoSize = true;
            ma0332.Location = new Point( 3, 153 );
            ma0332.Name = "ma0332";
            ma0332.Size = new Size( 87, 19 );
            ma0332.TabIndex = 14;
            ma0332.Text = "雷遁の術:壱";
            ma0332.UseVisualStyleBackColor = true;
            // 
            // ma0333
            // 
            ma0333.AutoSize = true;
            ma0333.Location = new Point( 96, 153 );
            ma0333.Name = "ma0333";
            ma0333.Size = new Size( 87, 19 );
            ma0333.TabIndex = 15;
            ma0333.Text = "雷遁の術:弐";
            ma0333.UseVisualStyleBackColor = true;
            // 
            // ma0334
            // 
            ma0334.AutoSize = true;
            ma0334.Location = new Point( 189, 153 );
            ma0334.Name = "ma0334";
            ma0334.Size = new Size( 87, 19 );
            ma0334.TabIndex = 16;
            ma0334.Text = "雷遁の術:参";
            ma0334.UseVisualStyleBackColor = true;
            // 
            // ma0335
            // 
            ma0335.AutoSize = true;
            ma0335.Location = new Point( 3, 178 );
            ma0335.Name = "ma0335";
            ma0335.Size = new Size( 87, 19 );
            ma0335.TabIndex = 17;
            ma0335.Text = "水遁の術:壱";
            ma0335.UseVisualStyleBackColor = true;
            // 
            // ma0336
            // 
            ma0336.AutoSize = true;
            ma0336.Location = new Point( 96, 178 );
            ma0336.Name = "ma0336";
            ma0336.Size = new Size( 87, 19 );
            ma0336.TabIndex = 18;
            ma0336.Text = "水遁の術:弐";
            ma0336.UseVisualStyleBackColor = true;
            // 
            // ma0337
            // 
            ma0337.AutoSize = true;
            ma0337.Location = new Point( 189, 178 );
            ma0337.Name = "ma0337";
            ma0337.Size = new Size( 87, 19 );
            ma0337.TabIndex = 19;
            ma0337.Text = "水遁の術:参";
            ma0337.UseVisualStyleBackColor = true;
            // 
            // ma0338
            // 
            ma0338.AutoSize = true;
            ma0338.Location = new Point( 3, 203 );
            ma0338.Name = "ma0338";
            ma0338.Size = new Size( 87, 19 );
            ma0338.TabIndex = 20;
            ma0338.Text = "空蝉の術:壱";
            ma0338.UseVisualStyleBackColor = true;
            // 
            // ma0339
            // 
            ma0339.AutoSize = true;
            ma0339.Location = new Point( 96, 203 );
            ma0339.Name = "ma0339";
            ma0339.Size = new Size( 87, 19 );
            ma0339.TabIndex = 21;
            ma0339.Text = "空蝉の術:弐";
            ma0339.UseVisualStyleBackColor = true;
            // 
            // ma0340
            // 
            ma0340.AutoSize = true;
            ma0340.Location = new Point( 189, 203 );
            ma0340.Name = "ma0340";
            ma0340.Size = new Size( 87, 19 );
            ma0340.TabIndex = 22;
            ma0340.Text = "空蝉の術:参";
            ma0340.UseVisualStyleBackColor = true;
            // 
            // ma0341
            // 
            ma0341.AutoSize = true;
            ma0341.Location = new Point( 3, 228 );
            ma0341.Name = "ma0341";
            ma0341.Size = new Size( 87, 19 );
            ma0341.TabIndex = 23;
            ma0341.Text = "呪縛の術:壱";
            ma0341.UseVisualStyleBackColor = true;
            // 
            // ma0344
            // 
            ma0344.AutoSize = true;
            ma0344.Location = new Point( 3, 253 );
            ma0344.Name = "ma0344";
            ma0344.Size = new Size( 87, 19 );
            ma0344.TabIndex = 24;
            ma0344.Text = "捕縄の術:壱";
            ma0344.UseVisualStyleBackColor = true;
            // 
            // ma0345
            // 
            ma0345.AutoSize = true;
            ma0345.Location = new Point( 96, 253 );
            ma0345.Name = "ma0345";
            ma0345.Size = new Size( 87, 19 );
            ma0345.TabIndex = 25;
            ma0345.Text = "捕縄の術:弐";
            ma0345.UseVisualStyleBackColor = true;
            // 
            // ma0347
            // 
            ma0347.AutoSize = true;
            ma0347.Location = new Point( 3, 278 );
            ma0347.Name = "ma0347";
            ma0347.Size = new Size( 87, 19 );
            ma0347.TabIndex = 26;
            ma0347.Text = "暗闇の術:壱";
            ma0347.UseVisualStyleBackColor = true;
            // 
            // ma0348
            // 
            ma0348.AutoSize = true;
            ma0348.Location = new Point( 96, 278 );
            ma0348.Name = "ma0348";
            ma0348.Size = new Size( 87, 19 );
            ma0348.TabIndex = 27;
            ma0348.Text = "暗闇の術:弐";
            ma0348.UseVisualStyleBackColor = true;
            // 
            // ma0350
            // 
            ma0350.AutoSize = true;
            ma0350.Location = new Point( 3, 303 );
            ma0350.Name = "ma0350";
            ma0350.Size = new Size( 87, 19 );
            ma0350.TabIndex = 28;
            ma0350.Text = "毒盛の術:壱";
            ma0350.UseVisualStyleBackColor = true;
            // 
            // ma0353
            // 
            ma0353.AutoSize = true;
            ma0353.Location = new Point( 3, 328 );
            ma0353.Name = "ma0353";
            ma0353.Size = new Size( 87, 19 );
            ma0353.TabIndex = 29;
            ma0353.Text = "遁甲の術:壱";
            ma0353.UseVisualStyleBackColor = true;
            // 
            // ma0354
            // 
            ma0354.AutoSize = true;
            ma0354.Location = new Point( 96, 328 );
            ma0354.Name = "ma0354";
            ma0354.Size = new Size( 87, 19 );
            ma0354.TabIndex = 30;
            ma0354.Text = "遁甲の術:弐";
            ma0354.UseVisualStyleBackColor = true;
            // 
            // ma0505
            // 
            ma0505.AutoSize = true;
            ma0505.Location = new Point( 3, 353 );
            ma0505.Name = "ma0505";
            ma0505.Size = new Size( 87, 19 );
            ma0505.TabIndex = 31;
            ma0505.Text = "月下の術:壱";
            ma0505.UseVisualStyleBackColor = true;
            // 
            // ma0506
            // 
            ma0506.AutoSize = true;
            ma0506.Location = new Point( 3, 378 );
            ma0506.Name = "ma0506";
            ma0506.Size = new Size( 87, 19 );
            ma0506.TabIndex = 32;
            ma0506.Text = "夜陰の術:壱";
            ma0506.UseVisualStyleBackColor = true;
            // 
            // ma0507
            // 
            ma0507.AutoSize = true;
            ma0507.Location = new Point( 3, 403 );
            ma0507.Name = "ma0507";
            ma0507.Size = new Size( 87, 19 );
            ma0507.TabIndex = 33;
            ma0507.Text = "妙手の術:壱";
            ma0507.UseVisualStyleBackColor = true;
            // 
            // ma0508
            // 
            ma0508.AutoSize = true;
            ma0508.Location = new Point( 3, 428 );
            ma0508.Name = "ma0508";
            ma0508.Size = new Size( 87, 19 );
            ma0508.TabIndex = 34;
            ma0508.Text = "幽林の術:壱";
            ma0508.UseVisualStyleBackColor = true;
            // 
            // ma0509
            // 
            ma0509.AutoSize = true;
            ma0509.Location = new Point( 3, 453 );
            ma0509.Name = "ma0509";
            ma0509.Size = new Size( 87, 19 );
            ma0509.TabIndex = 35;
            ma0509.Text = "活火の術:壱";
            ma0509.UseVisualStyleBackColor = true;
            // 
            // ma0510
            // 
            ma0510.AutoSize = true;
            ma0510.Location = new Point( 3, 478 );
            ma0510.Name = "ma0510";
            ma0510.Size = new Size( 87, 19 );
            ma0510.TabIndex = 36;
            ma0510.Text = "身替の術:壱";
            ma0510.UseVisualStyleBackColor = true;
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
            // FormMagicNinjutsu
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size( 784, 561 );
            Controls.Add( label1 );
            Controls.Add( button2 );
            Controls.Add( button1 );
            Controls.Add( tableLayoutPanel1 );
            Controls.Add( menuStrip1 );
            MainMenuStrip = menuStrip1;
            Name = "FormMagicNinjutsu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "魔法/忍術";
            menuStrip1.ResumeLayout( false );
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout( false );
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox ma0318;
        private CheckBox ma0319;
        private CheckBox ma0320;
        private CheckBox ma0321;
        private CheckBox ma0322;
        private CheckBox ma0323;
        private CheckBox ma0324;
        private CheckBox ma0325;
        private CheckBox ma0326;
        private CheckBox ma0327;
        private CheckBox ma0328;
        private CheckBox ma0329;
        private CheckBox ma0330;
        private CheckBox ma0331;
        private CheckBox ma0332;
        private CheckBox ma0333;
        private CheckBox ma0334;
        private CheckBox ma0335;
        private CheckBox ma0336;
        private CheckBox ma0337;
        private CheckBox ma0338;
        private CheckBox ma0339;
        private CheckBox ma0340;
        private CheckBox ma0341;
        private CheckBox ma0344;
        private CheckBox ma0345;
        private CheckBox ma0347;
        private CheckBox ma0348;
        private CheckBox ma0350;
        private CheckBox ma0353;
        private CheckBox ma0354;
        private CheckBox ma0505;
        private CheckBox ma0506;
        private CheckBox ma0507;
        private CheckBox ma0508;
        private CheckBox ma0509;
        private CheckBox ma0510;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}