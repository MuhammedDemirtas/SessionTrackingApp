namespace GörselProgramlama2.Models
{
    public partial class LOUNGE
    {
        public int id { get; set; }
        public string? movieTheaterName { get; set; }
        public int movieTheaterCapacity { get; set; }

        public static bool control()
        {
            if (Program.homePage.LoungeNameTxt.Text == string.Empty || Program.homePage.LoungeCapacityTxt.Text == string.Empty)
                    return false;

            else
                if (int.Parse(Program.homePage.LoungeCapacityTxt.Text) <= 0)
                    return false;

            return true;
        }

        public static void clear()
        {
            Program.homePage.LoungeNameTxt.Text = string.Empty;
            Program.homePage.LoungeCapacityTxt.Text = string.Empty;
        }

        public static void saveDatas(LOUNGE movieTheater)
        {
            if (Program.existsDB())
            {
                try
                {
                    using (DBContext context = new DBContext())
                    {
                        context.MovieTheaters.Add(movieTheater);
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
                        List<LOUNGE> moviTheaters = context.MovieTheaters.ToList();
                        Program.homePage.datasLounge.DataSource = moviTheaters;
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
