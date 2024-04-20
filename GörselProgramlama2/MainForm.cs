using GörselProgramlama2.Models;


namespace GörselProgramlama2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void saveMovieBtn_Click(object sender, EventArgs e)
        {
            if (FILM.control())
            {
                FILM movie = new FILM()
                {
                    movieName = FilmNameTxt.Text,
                    timeOne = FilmTime1Dt.Value.TimeOfDay,
                    timeTwo = FilmTime2Dt.Value.TimeOfDay,
                    timeThree = FilmTime3Dt.Value.TimeOfDay,
                };

                FILM.saveDatas(movie);
                Session.fillMovie();
            }
            else
            {
                MessageBox.Show("Do Not Leave Blank Fields or Enter Valid Data Format.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveMovieTheaterBtn_Click(object sender, EventArgs e)
        {
            if (LOUNGE.control())
            {
                LOUNGE movieTheater = new LOUNGE()
                {
                    movieTheaterName = LoungeNameTxt.Text,
                    movieTheaterCapacity = int.Parse(LoungeCapacityTxt.Text)
                };

                LOUNGE.saveDatas(movieTheater);
                Session.fillMovieTheaters();
            }
            else
            {
                MessageBox.Show("Do Not Leave Blank Fields or Enter Valid Data Format.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveSessionBtn_Click(object sender, EventArgs e)
        {
            if (Session.control())
            {
                Session session = new Session()
                {
                    movieName = sFilmNameCombo.SelectedItem.ToString(),
                    movieTheaterName = sLoungeNameCombo.SelectedItem.ToString(),
                    movieDate = sFilmDateDt.Value.Date,
                    movieTime = TimeSpan.Parse(sFilmTimeCombo.SelectedItem.ToString())
                };

                Session.saveDatas(session);
            }
            else
            {
                MessageBox.Show("Do Not Leave Blank Fields or Enter Valid Data Format.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveCustomerBtn_Click(object sender, EventArgs e)
        {
            if (Customer.control())
            {
                Customer customer = new Customer()
                {
                    sessionID = Convert.ToInt32(datasSessions.SelectedRows[0].Cells[0].Value),
                    customerName = customerNameTxt.Text,
                    customerSurname = customerSurnameTxt.Text,
                    cardNumber = cardNumberTxt.Text,
                    validityMonth = int.Parse(validityMonthCombo.SelectedItem.ToString()),
                    validityYear = int.Parse(validityYearCombo.SelectedItem.ToString()),
                    securityCode = int.Parse(securityCodeTxt.Text)
                };

                Customer.saveDatas(customer);
            }
            else
            {
                MessageBox.Show("Do Not Leave Blank Fields or Enter Valid Data Format.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void HomePage_Load(object sender, EventArgs e)
        {
            Session.fillSMovieDateDt();

            Customer.fillValidityMonthCombo();
            Customer.fillValidityYearCombo();

            FILM.listDatas();
            LOUNGE.listDatas();
            Session.fillMovie();
            Session.fillMovieTheaters();
            Session.listDatas();
            Customer.listDatas();
        }

        private void HomePage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }




        private void datasMovie_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Program.existsDB())
            {
                datasFilm.Columns[0].HeaderText = "ID";
                datasFilm.Columns[1].HeaderText = "Film Name";
                datasFilm.Columns[2].HeaderText = "Film Time 1";
                datasFilm.Columns[3].HeaderText = "Film Time 2";
                datasFilm.Columns[4].HeaderText = "Film Time 3";

                datasFilm.Columns[0].Visible = false;
            }
        }

        private void datasMovieTheater_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Program.existsDB())
            {
                datasLounge.Columns[0].HeaderText = "ID";
                datasLounge.Columns[1].HeaderText = "Lounge Name";
                datasLounge.Columns[2].HeaderText = "Lounge Capasity";

                datasLounge.Columns[0].Visible = false;
            }
        }

        private void datasSession_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Program.existsDB())
            {
                datasSession.Columns[0].HeaderText = "ID";
                datasSession.Columns[1].HeaderText = "Film Name";
                datasSession.Columns[2].HeaderText = "Lounge Name";
                datasSession.Columns[3].HeaderText = "Film Date";
                datasSession.Columns[4].HeaderText = "Film Time";

                datasSession.Columns[0].Visible = false;
            }
        }

        private void datasSessions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Program.existsDB())
            {
                datasSessions.Columns[0].HeaderText = "ID";
                datasSessions.Columns[1].HeaderText = "Film Name";
                datasSessions.Columns[2].HeaderText = "Lounge Name";
                datasSessions.Columns[3].HeaderText = "Film Date";
                datasSessions.Columns[4].HeaderText = "Film Time";

                datasSessions.Columns[0].Visible = false;
            }
        }


        private void sMovieNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.fillMovieTimes();
        }

        private void movieTimeFourLbl_Click(object sender, EventArgs e)
        {

        }

        private void sMovieTheaterNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void FilmNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void LoungeCapacityLbl_Click(object sender, EventArgs e)
        {

        }

        private void cardNumberLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
