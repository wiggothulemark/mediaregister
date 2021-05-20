using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaregister
{
    public partial class Form1 : Form
    {

        private List<Media> allMedia = new List<Media>();

        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateInputs(TextBox titleBox, TextBox writerBox, NumericUpDown length)
        {
            bool returnValue = true;
            if (String.IsNullOrWhiteSpace(titleBox.Text))
            {
                titleBox.Text = "";
                returnValue = false;
            }
            if (String.IsNullOrWhiteSpace(writerBox.Text))
            {
                writerBox.Text = "";
                returnValue = false;
            }
            if (length.Value <= 0)
            {
                length.Value = length.Minimum;
                returnValue = false;
            }

            return returnValue;
        }

        private void SendErrorMessage(string message)
        {
            string caption = "Error!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
        }
        private void AddBookButton_Click(object sender, EventArgs e)
        {


            if (ValidateInputs(TitleBook, AuthorBook, PagesBook))
            {
                string title = TitleBook.Text.Trim();
                string author = AuthorBook.Text.Trim();
                int nrPages = (int)PagesBook.Value;
                allMedia.Add(new Book(title, author, nrPages));
                TitleBook.Text = "";
                AuthorBook.Text = "";
                PagesBook.Value = PagesBook.Minimum;
            }
            else
            {
                SendErrorMessage("Ogiltlig input");
            }
            UpdateList();

        }

        private void ButtonAddMovie_Click(object sender, EventArgs e)
        {
            
            if (ValidateInputs(TitleMovie, DirectorMovie, LengthMovie))
            {
                
                string title = TitleMovie.Text.Trim();
                string director = DirectorMovie.Text.Trim();
                int length = (int)LengthMovie.Value;
                allMedia.Add(new Movie(title, director, length));
                TitleMovie.Text = "";
                DirectorMovie.Text = "";
                LengthMovie.Value = LengthMovie.Minimum;

            }
            else
            {
                SendErrorMessage("Error");
            }
            UpdateList();

        }


        private void UpdateList()
        {

            string[] newLines = new string[allMedia.Count]; 
            int index = 0; 

            for (int i = 0; i < newLines.Length; i++)
            {

                Media media = allMedia[i];

                if (
                    RadioButtonMovies.Checked)
                {
                    media = allMedia[i] as Movie; 
                }
                else if (RadioButtonBooks.Checked)
                {
                    media = allMedia[i] as Book;
                }


                if (media != null)
                {
                    newLines[index] = media.ToString();
                    index++;
                }

            }
            ListOfItems.Lines = newLines; 

        }

        

        private void RadioButtonMovies_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
        private void ShowRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void RadioButtonBooks_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        
    }


}
