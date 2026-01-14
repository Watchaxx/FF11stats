namespace FF11stats
{
    partial class FormMeritOthers
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
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown1 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown2 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown3 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown4 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown5 ).BeginInit();
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
            tableLayoutPanel1.Location = new Point( 12, 12 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.Size = new Size( 180, 162 );
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
            label2.Location = new Point( 116, 0 );
            label2.Name = "label2";
            label2.Size = new Size( 30, 15 );
            label2.TabIndex = 1;
            label2.Text = "0/10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point( 3, 15 );
            label3.Name = "label3";
            label3.Size = new Size( 51, 15 );
            label3.TabIndex = 2;
            label3.Text = "敵対心+";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point( 116, 18 );
            numericUpDown1.Maximum = new decimal( new int[] { 5, 0, 0, 0 } );
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
            label4.Size = new Size( 48, 15 );
            label4.TabIndex = 4;
            label4.Text = "敵対心-";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point( 116, 47 );
            numericUpDown2.Maximum = new decimal( new int[] { 5, 0, 0, 0 } );
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
            label5.Size = new Size( 95, 15 );
            label5.TabIndex = 6;
            label5.Text = "クリティカルヒット率";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point( 116, 76 );
            numericUpDown3.Maximum = new decimal( new int[] { 5, 0, 0, 0 } );
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
            label6.Size = new Size( 107, 15 );
            label6.TabIndex = 8;
            label6.Text = "被クリティカルヒット率";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point( 116, 105 );
            numericUpDown4.Maximum = new decimal( new int[] { 5, 0, 0, 0 } );
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
            label7.Size = new Size( 67, 15 );
            label7.TabIndex = 10;
            label7.Text = "詠唱中断率";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point( 116, 134 );
            numericUpDown5.Maximum = new decimal( new int[] { 5, 0, 0, 0 } );
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size( 60, 23 );
            numericUpDown5.TabIndex = 11;
            numericUpDown5.ValueChanged +=  NumericUpDown1_ValueChanged ;
            // 
            // button1
            // 
            button1.Anchor =  AnchorStyles.Bottom  |  AnchorStyles.Right ;
            button1.Location = new Point( 616, 526 );
            button1.Name = "button1";
            button1.Size = new Size( 75, 23 );
            button1.TabIndex = 1;
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
            button2.TabIndex = 2;
            button2.Text = "キャンセル";
            button2.UseVisualStyleBackColor = true;
            button2.Click +=  Button2_Click ;
            // 
            // FormMeritOthers
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size( 784, 561 );
            Controls.Add( button2 );
            Controls.Add( button1 );
            Controls.Add( tableLayoutPanel1 );
            Name = "FormMeritOthers";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "メリットポイント/その他";
            tableLayoutPanel1.ResumeLayout( false );
            tableLayoutPanel1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown1 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown2 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown3 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown4 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)numericUpDown5 ).EndInit();
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
        private Button button1;
        private Button button2;
    }
}