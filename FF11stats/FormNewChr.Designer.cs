namespace FF11stats
{
    partial class FormNewChr
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            comboBox2 = new ComboBox();
            errorProvider1 = new ErrorProvider( components );
            label4 = new Label();
            comboBox3 = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ( (System.ComponentModel.ISupportInitialize)errorProvider1 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)pictureBox1 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)pictureBox2 ).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point( 30, 30 );
            label1.Name = "label1";
            label1.Size = new Size( 48, 15 );
            label1.TabIndex = 0;
            label1.Text = "名前(&N)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point( 30, 48 );
            textBox1.Name = "textBox1";
            textBox1.Size = new Size( 150, 23 );
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point( 30, 74 );
            label2.Name = "label2";
            label2.Size = new Size( 46, 15 );
            label2.TabIndex = 2;
            label2.Text = "種族(&R)";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange( new object[] { "ヒューム男", "ヒューム女", "エルヴァーン男", "エルヴァーン女", "タルタル男", "タルタル女", "ミスラ", "ガルカ" } );
            comboBox1.Location = new Point( 30, 92 );
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size( 150, 23 );
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged +=  ComboBox1_SelectedIndexChanged ;
            // 
            // button1
            // 
            button1.Location = new Point( 328, 310 );
            button1.Name = "button1";
            button1.Size = new Size( 75, 23 );
            button1.TabIndex = 6;
            button1.Text = "戻る(&B)";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  Button1_Click ;
            // 
            // button2
            // 
            button2.Location = new Point( 409, 310 );
            button2.Name = "button2";
            button2.Size = new Size( 75, 23 );
            button2.TabIndex = 7;
            button2.Text = "決定(&C)";
            button2.UseVisualStyleBackColor = true;
            button2.Click +=  Button2_Click ;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point( 30, 118 );
            label3.Name = "label3";
            label3.Size = new Size( 81, 15 );
            label3.TabIndex = 4;
            label3.Text = "フェイスタイプ(&F)";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange( new object[] { "1A", "1B", "2A", "2B", "3A", "3B", "4A", "4B", "5A", "5B", "6A", "6B", "7A", "7B", "8A", "8B" } );
            comboBox2.Location = new Point( 30, 136 );
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size( 150, 23 );
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged +=  ComboBox1_SelectedIndexChanged ;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point( 30, 162 );
            label4.Name = "label4";
            label4.Size = new Size( 58, 15 );
            label4.TabIndex = 8;
            label4.Text = "所属国(C)";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange( new object[] { "サンドリア王国", "バストゥーク共和国", "ウィンダス連邦" } );
            comboBox3.Location = new Point( 30, 180 );
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size( 150, 23 );
            comboBox3.TabIndex = 9;
            comboBox3.SelectedIndexChanged +=  ComboBox3_SelectedIndexChanged ;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.hm1a;
            pictureBox1.Location = new Point( 186, 92 );
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size( 32, 32 );
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.snd;
            pictureBox2.Location = new Point( 186, 171 );
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size( 32, 32 );
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // FormNewChr
            // 
            AcceptButton = button2;
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button1;
            ClientSize = new Size( 496, 345 );
            Controls.Add( pictureBox2 );
            Controls.Add( pictureBox1 );
            Controls.Add( comboBox3 );
            Controls.Add( label4 );
            Controls.Add( comboBox2 );
            Controls.Add( label3 );
            Controls.Add( button2 );
            Controls.Add( button1 );
            Controls.Add( comboBox1 );
            Controls.Add( label2 );
            Controls.Add( textBox1 );
            Controls.Add( label1 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormNewChr";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "新規作成";
            ( (System.ComponentModel.ISupportInitialize)errorProvider1 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)pictureBox1 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)pictureBox2 ).EndInit();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private ComboBox comboBox2;
        private ErrorProvider errorProvider1;
        private ComboBox comboBox3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}