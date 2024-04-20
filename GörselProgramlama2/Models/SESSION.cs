namespace GörselProgramlama2.Models
{
    public partial class Session
    {
        public int id { get; set; }
        public string? movieName { get; set; }
        public string? movieTheaterName { get; set; }
        public DateTime movieDate {  get; set; }
        public TimeSpan movieTime { get; set; }

        public static bool control()
        {
            if (Program.homePage.sFilmNameCombo.SelectedItem == null || Program.homePage.sLoungeNameCombo.SelectedItem == null || Program.homePage.sFilmTimeCombo.SelectedItem == null)
                return false;

            else
                if (Program.homePage.sFilmDateDt.Value < DateTime.Today)
                    return false;

            return true;
        }

        public static void clear()
        {
            Program.homePage.sFilmNameCombo.SelectedItem = null;
            Program.homePage.sLoungeNameCombo.SelectedItem = null;
            Program.homePage.sFilmDateDt.Value = DateTime.Today;
            Program.homePage.sFilmTimeCombo.SelectedItem = null;
            Program.homePage.sFilmTimeCombo.Items.Clear();
        }

        public static void saveDatas(Session session)
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        LOUNGE? movieTheater = context.MovieTheaters.FirstOrDefault(s => s.movieTheaterName == session.movieTheaterName);
                        movieTheater.movieTheaterCapacity--;

                        context.Sessions.Add(session);
                        context.SaveChanges();
                        MessageBox.Show("Datas Saved", "Data Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Customer.listDatas();
                        listDatas();
                        clear();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void listDatas()
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        List<Session> sessions = context.Sessions.ToList();
                        Program.homePage.datasSession.DataSource = sessions;
                    }

                    fillMovie();
                    fillMovieTheaters();

                    LOUNGE.listDatas();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void fillMovie()
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        Program.homePage.sFilmNameCombo.Items.Clear();
                        List<string?> movies = context.Movies.Select(f => f.movieName).ToList();
                        foreach (string? item in movies)
                        {
                            Program.homePage.sFilmNameCombo.Items.Add(item);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void fillMovieTheaters()
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        Program.homePage.sLoungeNameCombo.Items.Clear();
                        List<string?> movieTheaters = context.MovieTheaters.Where(f => f.movieTheaterCapacity > 0).Select(f => f.movieTheaterName).ToList();
                        foreach (string? item in movieTheaters)
                        {
                            Program.homePage.sLoungeNameCombo.Items.Add(item);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void fillMovieTimes()
        {
            if (Program.existsDB() && Program.homePage.sFilmNameCombo.SelectedItem != null)
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        var movieTimes = context.Movies.Where(f => f.movieName == Program.homePage.sFilmNameCombo.SelectedItem.ToString()).Select(f => new { f.timeOne, f.timeTwo, f.timeThree }).FirstOrDefault();

                        if (movieTimes != null)
                        {
                            Program.homePage.sFilmTimeCombo.Items.Clear();
                            Program.homePage.sFilmTimeCombo.Items.Add(movieTimes.timeOne.ToString());
                            Program.homePage.sFilmTimeCombo.Items.Add(movieTimes.timeTwo.ToString());
                            Program.homePage.sFilmTimeCombo.Items.Add(movieTimes.timeThree.ToString());
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void fillSMovieDateDt()
        {
            Program.homePage.sFilmDateDt.Value = DateTime.Today;
        }
    }
}
