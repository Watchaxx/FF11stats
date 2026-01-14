namespace FF11stats
{
    partial class FormFinder
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
            textBox1 = new TextBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip( components );
            button2 = new Button();
            helpProvider1 = new HelpProvider();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point( 12, 12 );
            textBox1.Name = "textBox1";
            textBox1.Size = new Size( 150, 23 );
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point( 168, 12 );
            button1.Name = "button1";
            button1.Size = new Size( 23, 23 );
            button1.TabIndex = 1;
            button1.Text = "🔍";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  Button1_Click ;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size( 61, 4 );
            // 
            // button2
            // 
            button2.Location = new Point( 197, 12 );
            button2.Name = "button2";
            button2.Size = new Size( 23, 23 );
            button2.TabIndex = 2;
            button2.Text = "×";
            button2.UseVisualStyleBackColor = true;
            button2.Click +=  Button2_Click ;
            // 
            // FormFinder
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size( 233, 51 );
            Controls.Add( button2 );
            Controls.Add( button1 );
            Controls.Add( textBox1 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFinder";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "検索";
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button2;
        private HelpProvider helpProvider1;
    }
}