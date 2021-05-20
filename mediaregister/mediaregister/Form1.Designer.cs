
namespace mediaregister
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.PagesBook = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorBook = new System.Windows.Forms.TextBox();
            this.TitleBook = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonAddMovie = new System.Windows.Forms.Button();
            this.LengthMovie = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DirectorMovie = new System.Windows.Forms.TextBox();
            this.TitleMovie = new System.Windows.Forms.TextBox();
            this.ListOfItems = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonMovies = new System.Windows.Forms.RadioButton();
            this.RadioButtonBooks = new System.Windows.Forms.RadioButton();
            this.RadioButtonAll = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PagesBook)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthMovie)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(305, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddBookButton);
            this.tabPage1.Controls.Add(this.PagesBook);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AuthorBook);
            this.tabPage1.Controls.Add(this.TitleBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(297, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lägg till bok";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(134, 261);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(130, 34);
            this.AddBookButton.TabIndex = 6;
            this.AddBookButton.Text = "Lägg till bok";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // PagesBook
            // 
            this.PagesBook.Location = new System.Drawing.Point(112, 165);
            this.PagesBook.Name = "PagesBook";
            this.PagesBook.Size = new System.Drawing.Size(150, 31);
            this.PagesBook.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Antal sidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Författare:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titel:";
            // 
            // AuthorBook
            // 
            this.AuthorBook.Location = new System.Drawing.Point(112, 111);
            this.AuthorBook.Name = "AuthorBook";
            this.AuthorBook.Size = new System.Drawing.Size(150, 31);
            this.AuthorBook.TabIndex = 1;
            // 
            // TitleBook
            // 
            this.TitleBook.Location = new System.Drawing.Point(112, 62);
            this.TitleBook.Name = "TitleBook";
            this.TitleBook.Size = new System.Drawing.Size(150, 31);
            this.TitleBook.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonAddMovie);
            this.tabPage2.Controls.Add(this.LengthMovie);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.DirectorMovie);
            this.tabPage2.Controls.Add(this.TitleMovie);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(297, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lägg till film";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonAddMovie
            // 
            this.ButtonAddMovie.Location = new System.Drawing.Point(136, 262);
            this.ButtonAddMovie.Name = "ButtonAddMovie";
            this.ButtonAddMovie.Size = new System.Drawing.Size(130, 34);
            this.ButtonAddMovie.TabIndex = 13;
            this.ButtonAddMovie.Text = "Lägg till film";
            this.ButtonAddMovie.UseVisualStyleBackColor = true;
            this.ButtonAddMovie.Click += new System.EventHandler(this.ButtonAddMovie_Click);
            // 
            // LengthMovie
            // 
            this.LengthMovie.Location = new System.Drawing.Point(116, 162);
            this.LengthMovie.Name = "LengthMovie";
            this.LengthMovie.Size = new System.Drawing.Size(150, 31);
            this.LengthMovie.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Spellängd:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Regissör:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Titel:";
            // 
            // DirectorMovie
            // 
            this.DirectorMovie.Location = new System.Drawing.Point(116, 112);
            this.DirectorMovie.Name = "DirectorMovie";
            this.DirectorMovie.Size = new System.Drawing.Size(150, 31);
            this.DirectorMovie.TabIndex = 8;
            // 
            // TitleMovie
            // 
            this.TitleMovie.Location = new System.Drawing.Point(116, 63);
            this.TitleMovie.Name = "TitleMovie";
            this.TitleMovie.Size = new System.Drawing.Size(150, 31);
            this.TitleMovie.TabIndex = 7;
            // 
            // ListOfItems
            // 
            this.ListOfItems.Location = new System.Drawing.Point(335, 34);
            this.ListOfItems.Multiline = true;
            this.ListOfItems.Name = "ListOfItems";
            this.ListOfItems.Size = new System.Drawing.Size(262, 323);
            this.ListOfItems.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonMovies);
            this.groupBox1.Controls.Add(this.RadioButtonBooks);
            this.groupBox1.Controls.Add(this.RadioButtonAll);
            this.groupBox1.Location = new System.Drawing.Point(297, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visa";
            // 
            // RadioButtonMovies
            // 
            this.RadioButtonMovies.AutoSize = true;
            this.RadioButtonMovies.Location = new System.Drawing.Point(189, 68);
            this.RadioButtonMovies.Name = "RadioButtonMovies";
            this.RadioButtonMovies.Size = new System.Drawing.Size(85, 29);
            this.RadioButtonMovies.TabIndex = 2;
            this.RadioButtonMovies.Text = "Filmer";
            this.RadioButtonMovies.UseVisualStyleBackColor = true;
            this.RadioButtonMovies.CheckedChanged += new System.EventHandler(this.RadioButtonMovies_CheckedChanged);
            // 
            // RadioButtonBooks
            // 
            this.RadioButtonBooks.AutoSize = true;
            this.RadioButtonBooks.Location = new System.Drawing.Point(87, 68);
            this.RadioButtonBooks.Name = "RadioButtonBooks";
            this.RadioButtonBooks.Size = new System.Drawing.Size(90, 29);
            this.RadioButtonBooks.TabIndex = 1;
            this.RadioButtonBooks.TabStop = true;
            this.RadioButtonBooks.Text = "Böcker";
            this.RadioButtonBooks.UseVisualStyleBackColor = true;
            this.RadioButtonBooks.CheckedChanged += new System.EventHandler(this.RadioButtonBooks_CheckedChanged);
            // 
            // RadioButtonAll
            // 
            this.RadioButtonAll.AutoSize = true;
            this.RadioButtonAll.Location = new System.Drawing.Point(15, 68);
            this.RadioButtonAll.Name = "RadioButtonAll";
            this.RadioButtonAll.Size = new System.Drawing.Size(66, 29);
            this.RadioButtonAll.TabIndex = 0;
            this.RadioButtonAll.TabStop = true;
            this.RadioButtonAll.Text = "Alla";
            this.RadioButtonAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListOfItems);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PagesBook)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LengthMovie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox ListOfItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AuthorBook;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonMovies;
        private System.Windows.Forms.RadioButton RadioButtonBooks;
        private System.Windows.Forms.RadioButton RadioButtonAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.NumericUpDown PagesBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtonAddMovie;
        private System.Windows.Forms.NumericUpDown LengthMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DirectorMovie;
        private System.Windows.Forms.TextBox TitleMovie;
        private System.Windows.Forms.TextBox TitleBook;
    }
}

