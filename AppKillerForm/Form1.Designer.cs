namespace AppKillerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            checkedListBoxCurrentProcess = new CheckedListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(430, 177);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCurrentProcess
            // 
            checkedListBoxCurrentProcess.FormattingEnabled = true;
            checkedListBoxCurrentProcess.Location = new Point(12, 12);
            checkedListBoxCurrentProcess.Name = "checkedListBoxCurrentProcess";
            checkedListBoxCurrentProcess.Size = new Size(257, 220);
            checkedListBoxCurrentProcess.TabIndex = 2;
            checkedListBoxCurrentProcess.SelectedIndexChanged += checkedListBoxCurrentProcess_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 450);
            Controls.Add(textBox1);
            Controls.Add(checkedListBoxCurrentProcess);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Блокировщик задач";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckedListBox checkedListBoxCurrentProcess;
        private TextBox textBox1;
    }
}
