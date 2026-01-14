namespace FF11stats
{
    partial class FormMeritStatus
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            numericUpDown3 = new NumericUpDown();
            label6 = new Label();
            numericUpDown4 = new NumericUpDown();
            label7 = new Label();
            numericUpDown5 = new NumericUpDown();
            label8 = new Label();
            numericUpDown6 = new NumericUpDown();
            label9 = new Label();
            numericUpDown7 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown1 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown2 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown3 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown4 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown5 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown6 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown7 ).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.Controls.Add( label1, 0, 0 );
            tableLayoutPanel1.Controls.Add( label2, 1, 0 );
            tableLayoutPanel1.Controls.Add( label3, 0, 1 );
            tableLayoutPanel1.Controls.Add( numericUpDown1, 1, 1 );
            tableLayoutPanel1.Controls.Add( label4, 0, 2 );
            tableLayoutPanel1.Controls.Add( numericUpDown2, 1, 2 );
            tableLayoutPanel1.Controls.Add( label5, 0, 3 );
            tableLayoutPanel1.Controls.Add( numericUpDown3, 1, 3 );
            tableLayoutPanel1.Controls.Add( label6, 0, 4 );
            tableLayoutPanel1.Controls.Add( numericUpDown4, 1, 4 );
            tableLayoutPanel1.Controls.Add( label7, 0, 5 );
            tableLayoutPanel1.Controls.Add( numericUpDown5, 1, 5 );
            tableLayoutPanel1.Controls.Add( label8, 0, 6 );
            tableLayoutPanel1.Controls.Add( numericUpDown6, 1, 6 );
            tableLayoutPanel1.Controls.Add( label9, 0, 7 );
            tableLayoutPanel1.Controls.Add( numericUpDown7, 1, 7 );
            tableLayoutPanel1.Location = new Point( 12, 12 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.Size = new Size( 135, 222 );
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point( 3, 0 );
            label1.Name = "label1";
            label1.Size = new Size( 60, 15 );
            label1.TabIndex = 0;
            label1.Text = "合計/上限";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point( 69, 0 );
            label2.Name = "label2";
            label2.Size = new Size( 36, 15 );
            label2.TabIndex = 1;
            label2.Text = "0/105";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point( 3, 15 );
            label3.Name = "label3";
            label3.Size = new Size( 26, 15 );
            label3.TabIndex = 2;
            label3.Text = "STR";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point( 69, 18 );
            numericUpDown1.Maximum = new decimal( new int[] { 15, 0, 0, 0 } );
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size( 60, 23 );
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged +=  NumericUpDown1_ValueChanged ;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point( 3, 44 );
            label4.Name = "label4";
            label4.Size = new Size( 28, 15 );
            label4.TabIndex = 4;
            label4.Text = "DEX";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point( 69, 47 );
            numericUpDown2.Maximum = new decimal( new int[] { 15, 0, 0, 0 } );
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size( 60, 23 );
            numericUpDown2.TabIndex = 5;
            numericUpDown2.ValueChanged +=  NumericUpDown1_ValueChanged ;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point( 3, 73 );
            label5.Name = "label5";
            label5.Size = new Size( 23, 15 );
            label5.TabIndex = 6;
            label5.Text = "VIT";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point( 69, 76 );
            numericUpDown3.Maximum = new decimal( new int[] { 15, 0, 0, 0 } );
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size( 60, 23 );
            numericUpDown3.TabIndex = 7;
            numericUpDown3.ValueChanged +=  NumericUpDown1_ValueChanged ;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point( 3, 102 );
            label6.Name = "label6";
            label6.Size = new Size( 26, 15 );
            label6.TabIndex = 8;
            label6.Text = "AGI";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point( 69, 105 );
            numericUpDown4.Maximum = new decimal( new int[] { 15, 0, 0, 0 } );
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size( 60, 23 );
            numericUpDown4.TabIndex = 9;
            numericUpDown4.ValueChanged +=  NumericUpDown1_ValueChanged ;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point( 3, 131 );
            label7.Name = "label7";
            label7.Size = new Size( 25, 15 );
            label7.TabIndex = 10;
            label7.Text = "INT";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point( 69, 134 );
            numericUpDown5.Maximum = new decimal( new int[] { 15, 0, 0, 0 } );
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size( 60, 23 );
            numericUpDown5.TabIndex = 11;
            numericUpDown5.ValueChanged +=  NumericUpDown1_ValueChanged ;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point( 3, 160 );
            label8.Name = "label8";
            label8.Size = new Size( 35, 15 );
            label8.TabIndex = 12;
            label8.Text = "MND";
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point( 69, 163 );
            numericUpDown6.Maximum = new decimal( new int[] { 15, 0, 0, 0 } );
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size( 60, 23 );
            numericUpDown6.TabIndex = 13;
            numericUpDown6.ValueChanged +=  NumericUpDown1_ValueChanged ;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point( 3, 189 );
            label9.Name = "label9";
            label9.Size = new Size( 30, 15 );
            label9.TabIndex = 14;
            label9.Text = "CHR";
            // 
            // numericUpDown7
            // 
            numericUpDown7.Location = new Point( 69, 192 );
            numericUpDown7.Maximum = new decimal( new int[] { 15, 0, 0, 0 } );
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size( 60, 23 );
            numericUpDown7.TabIndex = 15;
            numericUpDown7.ValueChanged +=  NumericUpDown1_ValueChanged ;
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
            button3.Location = new Point( 616, 526 );
            button3.Name = "button3";
            button3.Size = new Size( 75, 23 );
            button3.TabIndex = 3;
            button3.Text = "&OK";
            button3.UseVisualStyleBackColor = true;
            button3.Click +=  Button3_Click ;
            // 
            // button4
            // 
            button4.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Right ;
            button4.Location = new Point( 697, 526 );
            button4.Name = "button4";
            button4.Size = new Size( 75, 23 );
            button4.TabIndex = 4;
            button4.Text = "キャンセル";
            button4.UseVisualStyleBackColor = true;
            button4.Click +=  Button4_Click ;
            // 
            // FormMeritStatus
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
            Name = "FormMeritStatus";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "メリットポイント/ステータス";
            tableLayoutPanel1.ResumeLayout( false );
            tableLayoutPanel1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown1 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown2 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown3 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown4 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown5 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown6 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown7 ).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private NumericUpDown numericUpDown3;
        private Label label6;
        private NumericUpDown numericUpDown4;
        private Label label7;
        private NumericUpDown numericUpDown5;
        private Label label8;
        private NumericUpDown numericUpDown6;
        private Label label9;
        private NumericUpDown numericUpDown7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}