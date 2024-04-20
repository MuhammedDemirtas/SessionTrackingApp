namespace GörselProgramlama2.Models
{
    public partial class FILM
    {
        public int id { get; set; }
        public string? movieName { get; set; }
        public TimeSpan timeOne { get; set; }
        public TimeSpan timeTwo { get; set; }
        public TimeSpan timeThree { get; set; }

        public static bool control()
        {
            if (Program.homePage.FilmNameTxt.Text == string.Empty)
                    return false;

            return true;
        }

        public static void clear()
        {
            Program.homePage.FilmNameTxt.Text = string.Empty;
            Program.homePage.FilmTime1Dt.Value = DateTime.Parse("00:00:00");
            Program.homePage.FilmTime2Dt.Value = DateTime.Parse("00:00:00");
            Program.homePage.FilmTime3Dt.Value = DateTime.Parse("00:00:00");
        }

        public static void saveDatas(FILM movie)
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        context.Movies.Add(movie);
                        context.SaveChanges();
                        MessageBox.Show("Datas Saved", "Data Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        List<FILM> movie = context.Movies.ToList();
                        Program.homePage.datasFilm.DataSource = movie;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
