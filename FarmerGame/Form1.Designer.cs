namespace FarmerGame
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
            listBoxLeft = new ListBox();
            listBoxRight = new ListBox();
            botton1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listBoxLeft
            // 
            listBoxLeft.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            listBoxLeft.FormattingEnabled = true;
            listBoxLeft.Location = new Point(107, 120);
            listBoxLeft.Name = "listBoxLeft";
            listBoxLeft.SelectionMode = SelectionMode.MultiSimple;
            listBoxLeft.Size = new Size(180, 124);
            listBoxLeft.TabIndex = 0;
            // 
            // listBoxRight
            // 
            listBoxRight.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            listBoxRight.FormattingEnabled = true;
            listBoxRight.Location = new Point(512, 120);
            listBoxRight.Name = "listBoxRight";
            listBoxRight.SelectionMode = SelectionMode.MultiSimple;
            listBoxRight.Size = new Size(180, 124);
            listBoxRight.TabIndex = 1;
            listBoxRight.SelectedIndexChanged += listBoxRight_SelectedIndexChanged;
            // 
            // botton1
            // 
            botton1.Location = new Point(344, 140);
            botton1.Name = "botton1";
            botton1.Size = new Size(112, 34);
            botton1.TabIndex = 2;
            botton1.Text = "過河->";
            botton1.UseVisualStyleBackColor = true;
            botton1.Click += btnMoveRight_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 210);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "<-返回";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnMoveLeft_Click;
            // 
            // button3
            // 
            button3.Location = new Point(265, 318);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "回上一步";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnUndo_Click;
            // 
            // button4
            // 
            button4.Location = new Point(430, 318);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 5;
            button4.Text = "重新開始";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(botton1);
            Controls.Add(listBoxRight);
            Controls.Add(listBoxLeft);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxLeft;
        private ListBox listBoxRight;
        private Button botton1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
