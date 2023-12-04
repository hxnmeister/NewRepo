namespace ResumeAnalizatorParallel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.FilesLoadedListBox = new System.Windows.Forms.ListBox();
            this.ReportTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoadFileButton.Location = new System.Drawing.Point(153, 165);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(68, 57);
            this.LoadFileButton.TabIndex = 0;
            this.LoadFileButton.Text = "Load File(-s)";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // GetDataButton
            // 
            this.GetDataButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GetDataButton.Location = new System.Drawing.Point(390, 165);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(91, 57);
            this.GetDataButton.TabIndex = 1;
            this.GetDataButton.Text = "Get Data About Candidates";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // FilesLoadedListBox
            // 
            this.FilesLoadedListBox.FormattingEnabled = true;
            this.FilesLoadedListBox.Location = new System.Drawing.Point(15, 25);
            this.FilesLoadedListBox.Name = "FilesLoadedListBox";
            this.FilesLoadedListBox.Size = new System.Drawing.Size(233, 134);
            this.FilesLoadedListBox.TabIndex = 2;
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportTextBox.Location = new System.Drawing.Point(254, 25);
            this.ReportTextBox.Multiline = true;
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.Size = new System.Drawing.Size(355, 134);
            this.ReportTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loaded Files:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 230);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportTextBox);
            this.Controls.Add(this.FilesLoadedListBox);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.LoadFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.ListBox FilesLoadedListBox;
        private System.Windows.Forms.TextBox ReportTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

