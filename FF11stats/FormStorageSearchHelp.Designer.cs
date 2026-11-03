namespace FF11stats
{
    partial class FormStorageSearchHelp
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point( 12, 9 );
            label1.Name = "label1";
            label1.Size = new Size( 168, 45 );
            label1.TabIndex = 1;
            label1.Text = "・完全一致で検索します\r\n・大文字と小文字は区別しません\r\n・英数字は半角で入力してください";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point( 12, 54 );
            label2.Name = "label2";
            label2.Size = new Size( 335, 30 );
            label2.TabIndex = 2;
            label2.Text = "・踊り子専用装備など男女で分かれている同名装備は，\r\n  男性の場合は　　を，女性の場合は　　を語尾に付与してください";
            // 
            // textBox1
            // 
            textBox1.Location = new Point( 90, 70 );
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size( 23, 23 );
            textBox1.TabIndex = 3;
            textBox1.Text = "♂";
            // 
            // textBox2
            // 
            textBox2.Location = new Point( 203, 70 );
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size( 23, 23 );
            textBox2.TabIndex = 4;
            textBox2.Text = "♀";
            // 
            // button1
            // 
            button1.Location = new Point( 141, 106 );
            button1.Name = "button1";
            button1.Size = new Size( 75, 23 );
            button1.TabIndex = 0;
            button1.Text = "&OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  Button1_Click ;
            // 
            // FormStorageSearchHelp
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size( 356, 141 );
            ControlBox = false;
            Controls.Add( button1 );
            Controls.Add( textBox2 );
            Controls.Add( textBox1 );
            Controls.Add( label2 );
            Controls.Add( label1 );
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormStorageSearchHelp";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "アイテム検索";
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}