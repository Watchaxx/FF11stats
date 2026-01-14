namespace FF11stats
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font( "Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128 );
            label1.Location = new Point( 212, 55 );
            label1.Name = "label1";
            label1.Size = new Size( 73, 30 );
            label1.TabIndex = 0;
            label1.Text = "スタート";
            // 
            // button1
            // 
            button1.Location = new Point( 143, 133 );
            button1.Name = "button1";
            button1.Size = new Size( 210, 45 );
            button1.TabIndex = 1;
            button1.Text = "新規作成(&N)";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  Button1_Click ;
            // 
            // button2
            // 
            button2.Location = new Point( 143, 184 );
            button2.Name = "button2";
            button2.Size = new Size( 210, 45 );
            button2.TabIndex = 2;
            button2.Text = "キャラクタ ファイルを開く(&O)";
            button2.UseVisualStyleBackColor = true;
            button2.Click +=  Button2_Click ;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 496, 345 );
            Controls.Add( button2 );
            Controls.Add( button1 );
            Controls.Add( label1 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FF11stats";
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}
