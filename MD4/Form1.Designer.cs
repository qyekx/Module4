namespace BookLibraryApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Button buttonReturn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // listBoxBooks
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(12, 12);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(360, 212);
            this.listBoxBooks.TabIndex = 0;

            // buttonCheckout
            this.buttonCheckout.Location = new System.Drawing.Point(12, 240);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(150, 23);
            this.buttonCheckout.TabIndex = 1;
            this.buttonCheckout.Text = "Выдать книгу";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);

            // buttonReturn
            this.buttonReturn.Location = new System.Drawing.Point(222, 240);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(150, 23);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Вернуть книгу";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.listBoxBooks);
            this.Name = "Form1";
            this.Text = "Приложение Библиотека";
            this.ResumeLayout(false);
        }
    }
}
