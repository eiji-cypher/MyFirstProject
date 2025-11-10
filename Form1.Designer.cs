namespace MyFirstProject
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            btnAdd_Click = new Button();
            buttonEdit = new Button();
            btnDelete_Click = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(231, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(297, 229);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 289);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 23);
            textBox1.TabIndex = 1;
            // 
            // btnAdd_Click
            // 
            btnAdd_Click.Location = new Point(240, 355);
            btnAdd_Click.Name = "btnAdd_Click";
            btnAdd_Click.Size = new Size(75, 23);
            btnAdd_Click.TabIndex = 2;
            btnAdd_Click.Text = "ADD";
            btnAdd_Click.UseVisualStyleBackColor = true;
            btnAdd_Click.Click += button1_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(342, 355);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "EDIT";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonEdit_Click;
            // 
            // btnDelete_Click
            // 
            btnDelete_Click.Location = new Point(453, 355);
            btnDelete_Click.Name = "btnDelete_Click";
            btnDelete_Click.Size = new Size(75, 23);
            btnDelete_Click.TabIndex = 4;
            btnDelete_Click.Text = "DELETE";
            btnDelete_Click.UseVisualStyleBackColor = true;
            btnDelete_Click.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 467);
            Controls.Add(btnDelete_Click);
            Controls.Add(buttonEdit);
            Controls.Add(btnAdd_Click);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "My First Project";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button btnAdd_Click;
        private Button buttonEdit;
        private Button btnDelete_Click;
    }
}
