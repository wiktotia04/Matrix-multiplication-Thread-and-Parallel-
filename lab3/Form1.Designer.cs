namespace lab3
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
            button1 = new Button();
            matrixa = new DataGridView();
            matrixb = new DataGridView();
            matrixc = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)matrixa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrixb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrixc).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1693, 822);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // matrixa
            // 
            matrixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixa.Location = new Point(40, 12);
            matrixa.Name = "matrixa";
            matrixa.RowHeadersWidth = 82;
            matrixa.Size = new Size(509, 445);
            matrixa.TabIndex = 1;
            // 
            // matrixb
            // 
            matrixb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixb.Location = new Point(40, 479);
            matrixb.Name = "matrixb";
            matrixb.RowHeadersWidth = 82;
            matrixb.Size = new Size(557, 445);
            matrixb.TabIndex = 2;
            // 
            // matrixc
            // 
            matrixc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixc.Location = new Point(864, 94);
            matrixc.Name = "matrixc";
            matrixc.RowHeadersWidth = 82;
            matrixc.Size = new Size(670, 564);
            matrixc.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(958, 768);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(958, 839);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1919, 950);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(matrixc);
            Controls.Add(matrixb);
            Controls.Add(matrixa);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)matrixa).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrixb).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrixc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView matrixa;
        private DataGridView matrixb;
        private DataGridView matrixc;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
