namespace GörselProgramlama2
{
    partial class MainForm
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


        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pages = new TabControl();
            moviePage = new TabPage();
            FilmNameLbl = new Label();
            FilmTime1Lbl = new Label();
            FilmTime2Lbl = new Label();
            FilmTime3Lbl = new Label();
            FilmAddBtn = new Button();
            FilmNameTxt = new TextBox();
            FilmTime1Dt = new DateTimePicker();
            FilmTime2Dt = new DateTimePicker();
            FilmTime3Dt = new DateTimePicker();
            datasFilm = new DataGridView();
            movieTheaterPage = new TabPage();
            LoungeNameLbl = new Label();
            LoungeCapacityLbl = new Label();
            LoungeBtn = new Button();
            LoungeNameTxt = new TextBox();
            LoungeCapacityTxt = new MaskedTextBox();
            datasLounge = new DataGridView();
            sessionPage = new TabPage();
            sFilmNameLbl = new Label();
            sLoungeNameLbl = new Label();
            sFilmDateLbl = new Label();
            sFilmTimeLbl = new Label();
            saveSessionBtn = new Button();
            sFilmNameCombo = new ComboBox();
            sLoungeNameCombo = new ComboBox();
            sFilmDateDt = new DateTimePicker();
            sFilmTimeCombo = new ComboBox();
            datasSession = new DataGridView();
            customerPage = new TabPage();
            customerNameLbl = new Label();
            customerSurnameLbl = new Label();
            cardNumberLbl = new Label();
            validityPeriodLbl = new Label();
            securityCodeLbl = new Label();
            saveCustomerBtn = new Button();
            customerNameTxt = new TextBox();
            customerSurnameTxt = new TextBox();
            cardNumberTxt = new MaskedTextBox();
            securityCodeTxt = new MaskedTextBox();
            validityMonthCombo = new ComboBox();
            validityYearCombo = new ComboBox();
            datasSessions = new DataGridView();
            Pages.SuspendLayout();
            moviePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasFilm).BeginInit();
            movieTheaterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasLounge).BeginInit();
            sessionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasSession).BeginInit();
            customerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasSessions).BeginInit();
            SuspendLayout();
            // 
            // Pages
            // 
            Pages.Controls.Add(moviePage);
            Pages.Controls.Add(movieTheaterPage);
            Pages.Controls.Add(sessionPage);
            Pages.Controls.Add(customerPage);
            Pages.Location = new Point(12, 12);
            Pages.Name = "Pages";
            Pages.SelectedIndex = 0;
            Pages.Size = new Size(912, 433);
            Pages.TabIndex = 0;
            // 
            // moviePage
            // 
            moviePage.BackColor = Color.FromArgb(255, 192, 128);
            moviePage.Controls.Add(FilmNameLbl);
            moviePage.Controls.Add(FilmTime1Lbl);
            moviePage.Controls.Add(FilmTime2Lbl);
            moviePage.Controls.Add(FilmTime3Lbl);
            moviePage.Controls.Add(FilmAddBtn);
            moviePage.Controls.Add(FilmNameTxt);
            moviePage.Controls.Add(FilmTime1Dt);
            moviePage.Controls.Add(FilmTime2Dt);
            moviePage.Controls.Add(FilmTime3Dt);
            moviePage.Controls.Add(datasFilm);
            moviePage.ForeColor = Color.Black;
            moviePage.Location = new Point(4, 24);
            moviePage.Name = "moviePage";
            moviePage.Padding = new Padding(3);
            moviePage.Size = new Size(904, 405);
            moviePage.TabIndex = 0;
            moviePage.Text = "FILMS";
            // 
            // FilmNameLbl
            // 
            FilmNameLbl.AutoSize = true;
            FilmNameLbl.BackColor = Color.Sienna;
            FilmNameLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FilmNameLbl.Location = new Point(6, 40);
            FilmNameLbl.Name = "FilmNameLbl";
            FilmNameLbl.Size = new Size(98, 18);
            FilmNameLbl.TabIndex = 0;
            FilmNameLbl.Text = "FILM NAME";
            FilmNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            FilmNameLbl.Click += FilmNameLbl_Click;
            // 
            // FilmTime1Lbl
            // 
            FilmTime1Lbl.AutoSize = true;
            FilmTime1Lbl.BackColor = Color.Sienna;
            FilmTime1Lbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FilmTime1Lbl.Location = new Point(441, 11);
            FilmTime1Lbl.Name = "FilmTime1Lbl";
            FilmTime1Lbl.Size = new Size(103, 18);
            FilmTime1Lbl.TabIndex = 2;
            FilmTime1Lbl.Text = "FILM TIME 1";
            FilmTime1Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FilmTime2Lbl
            // 
            FilmTime2Lbl.AutoSize = true;
            FilmTime2Lbl.BackColor = Color.Sienna;
            FilmTime2Lbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FilmTime2Lbl.Location = new Point(441, 40);
            FilmTime2Lbl.Name = "FilmTime2Lbl";
            FilmTime2Lbl.Size = new Size(103, 18);
            FilmTime2Lbl.TabIndex = 4;
            FilmTime2Lbl.Text = "FILM TIME 2";
            FilmTime2Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FilmTime3Lbl
            // 
            FilmTime3Lbl.AutoSize = true;
            FilmTime3Lbl.BackColor = Color.Sienna;
            FilmTime3Lbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FilmTime3Lbl.Location = new Point(441, 69);
            FilmTime3Lbl.Name = "FilmTime3Lbl";
            FilmTime3Lbl.Size = new Size(103, 18);
            FilmTime3Lbl.TabIndex = 6;
            FilmTime3Lbl.Text = "FILM TIME 3";
            FilmTime3Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FilmAddBtn
            // 
            FilmAddBtn.BackColor = Color.FromArgb(255, 128, 0);
            FilmAddBtn.FlatStyle = FlatStyle.Popup;
            FilmAddBtn.ForeColor = Color.Black;
            FilmAddBtn.Location = new Point(302, 98);
            FilmAddBtn.Name = "FilmAddBtn";
            FilmAddBtn.Size = new Size(280, 30);
            FilmAddBtn.TabIndex = 10;
            FilmAddBtn.Text = "ADD";
            FilmAddBtn.UseVisualStyleBackColor = false;
            FilmAddBtn.Click += saveMovieBtn_Click;
            // 
            // FilmNameTxt
            // 
            FilmNameTxt.Location = new Point(133, 40);
            FilmNameTxt.Name = "FilmNameTxt";
            FilmNameTxt.Size = new Size(302, 23);
            FilmNameTxt.TabIndex = 1;
            FilmNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // FilmTime1Dt
            // 
            FilmTime1Dt.Format = DateTimePickerFormat.Time;
            FilmTime1Dt.Location = new Point(588, 8);
            FilmTime1Dt.Name = "FilmTime1Dt";
            FilmTime1Dt.Size = new Size(280, 23);
            FilmTime1Dt.TabIndex = 3;
            FilmTime1Dt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // FilmTime2Dt
            // 
            FilmTime2Dt.Format = DateTimePickerFormat.Time;
            FilmTime2Dt.Location = new Point(588, 37);
            FilmTime2Dt.Name = "FilmTime2Dt";
            FilmTime2Dt.Size = new Size(280, 23);
            FilmTime2Dt.TabIndex = 5;
            FilmTime2Dt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // FilmTime3Dt
            // 
            FilmTime3Dt.Format = DateTimePickerFormat.Time;
            FilmTime3Dt.Location = new Point(588, 66);
            FilmTime3Dt.Name = "FilmTime3Dt";
            FilmTime3Dt.Size = new Size(280, 23);
            FilmTime3Dt.TabIndex = 7;
            FilmTime3Dt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // datasFilm
            // 
            datasFilm.AllowUserToAddRows = false;
            datasFilm.AllowUserToDeleteRows = false;
            datasFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasFilm.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasFilm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasFilm.GridColor = Color.Sienna;
            datasFilm.Location = new Point(32, 134);
            datasFilm.Name = "datasFilm";
            datasFilm.ReadOnly = true;
            datasFilm.RowHeadersWidth = 51;
            datasFilm.Size = new Size(836, 265);
            datasFilm.TabIndex = 11;
            datasFilm.DataBindingComplete += datasMovie_DataBindingComplete;
            // 
            // movieTheaterPage
            // 
            movieTheaterPage.BackColor = Color.FromArgb(255, 192, 128);
            movieTheaterPage.Controls.Add(LoungeNameLbl);
            movieTheaterPage.Controls.Add(LoungeCapacityLbl);
            movieTheaterPage.Controls.Add(LoungeBtn);
            movieTheaterPage.Controls.Add(LoungeNameTxt);
            movieTheaterPage.Controls.Add(LoungeCapacityTxt);
            movieTheaterPage.Controls.Add(datasLounge);
            movieTheaterPage.ForeColor = Color.Black;
            movieTheaterPage.Location = new Point(4, 24);
            movieTheaterPage.Name = "movieTheaterPage";
            movieTheaterPage.Padding = new Padding(3);
            movieTheaterPage.Size = new Size(904, 405);
            movieTheaterPage.TabIndex = 1;
            movieTheaterPage.Text = "LOUNGE";
            // 
            // LoungeNameLbl
            // 
            LoungeNameLbl.AutoSize = true;
            LoungeNameLbl.BackColor = Color.Sienna;
            LoungeNameLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoungeNameLbl.ForeColor = SystemColors.ActiveCaptionText;
            LoungeNameLbl.Location = new Point(6, 143);
            LoungeNameLbl.Name = "LoungeNameLbl";
            LoungeNameLbl.Size = new Size(131, 18);
            LoungeNameLbl.TabIndex = 0;
            LoungeNameLbl.Text = "LOUNGE NAME";
            LoungeNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoungeCapacityLbl
            // 
            LoungeCapacityLbl.AutoSize = true;
            LoungeCapacityLbl.BackColor = Color.Sienna;
            LoungeCapacityLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoungeCapacityLbl.ForeColor = SystemColors.ActiveCaptionText;
            LoungeCapacityLbl.Location = new Point(6, 175);
            LoungeCapacityLbl.Name = "LoungeCapacityLbl";
            LoungeCapacityLbl.Size = new Size(92, 18);
            LoungeCapacityLbl.TabIndex = 2;
            LoungeCapacityLbl.Text = "CAPACITY";
            LoungeCapacityLbl.TextAlign = ContentAlignment.MiddleCenter;
            LoungeCapacityLbl.Click += LoungeCapacityLbl_Click;
            // 
            // LoungeBtn
            // 
            LoungeBtn.BackColor = Color.FromArgb(255, 128, 0);
            LoungeBtn.FlatStyle = FlatStyle.Popup;
            LoungeBtn.ForeColor = Color.Black;
            LoungeBtn.Location = new Point(87, 218);
            LoungeBtn.Name = "LoungeBtn";
            LoungeBtn.Size = new Size(280, 30);
            LoungeBtn.TabIndex = 4;
            LoungeBtn.Text = "ADD";
            LoungeBtn.UseVisualStyleBackColor = false;
            LoungeBtn.Click += saveMovieTheaterBtn_Click;
            // 
            // LoungeNameTxt
            // 
            LoungeNameTxt.Location = new Point(173, 144);
            LoungeNameTxt.Name = "LoungeNameTxt";
            LoungeNameTxt.Size = new Size(343, 23);
            LoungeNameTxt.TabIndex = 1;
            LoungeNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // LoungeCapacityTxt
            // 
            LoungeCapacityTxt.Location = new Point(173, 176);
            LoungeCapacityTxt.Mask = "0000";
            LoungeCapacityTxt.Name = "LoungeCapacityTxt";
            LoungeCapacityTxt.Size = new Size(343, 23);
            LoungeCapacityTxt.TabIndex = 3;
            LoungeCapacityTxt.TextAlign = HorizontalAlignment.Center;
            LoungeCapacityTxt.ValidatingType = typeof(int);
            // 
            // datasLounge
            // 
            datasLounge.AllowUserToAddRows = false;
            datasLounge.AllowUserToDeleteRows = false;
            datasLounge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasLounge.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasLounge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasLounge.Location = new Point(518, 25);
            datasLounge.Name = "datasLounge";
            datasLounge.ReadOnly = true;
            datasLounge.RowHeadersWidth = 51;
            datasLounge.Size = new Size(380, 353);
            datasLounge.TabIndex = 5;
            datasLounge.DataBindingComplete += datasMovieTheater_DataBindingComplete;
            // 
            // sessionPage
            // 
            sessionPage.BackColor = Color.FromArgb(255, 192, 128);
            sessionPage.Controls.Add(sFilmNameLbl);
            sessionPage.Controls.Add(sLoungeNameLbl);
            sessionPage.Controls.Add(sFilmDateLbl);
            sessionPage.Controls.Add(sFilmTimeLbl);
            sessionPage.Controls.Add(saveSessionBtn);
            sessionPage.Controls.Add(sFilmNameCombo);
            sessionPage.Controls.Add(sLoungeNameCombo);
            sessionPage.Controls.Add(sFilmDateDt);
            sessionPage.Controls.Add(sFilmTimeCombo);
            sessionPage.Controls.Add(datasSession);
            sessionPage.ForeColor = Color.Black;
            sessionPage.Location = new Point(4, 24);
            sessionPage.Name = "sessionPage";
            sessionPage.Size = new Size(904, 405);
            sessionPage.TabIndex = 2;
            sessionPage.Text = "SESSION";
            // 
            // sFilmNameLbl
            // 
            sFilmNameLbl.AutoSize = true;
            sFilmNameLbl.BackColor = Color.Sienna;
            sFilmNameLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sFilmNameLbl.Location = new Point(16, 112);
            sFilmNameLbl.Name = "sFilmNameLbl";
            sFilmNameLbl.Size = new Size(98, 18);
            sFilmNameLbl.TabIndex = 0;
            sFilmNameLbl.Text = "FILM NAME";
            sFilmNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sLoungeNameLbl
            // 
            sLoungeNameLbl.AutoSize = true;
            sLoungeNameLbl.BackColor = Color.Sienna;
            sLoungeNameLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sLoungeNameLbl.Location = new Point(16, 156);
            sLoungeNameLbl.Name = "sLoungeNameLbl";
            sLoungeNameLbl.Size = new Size(131, 18);
            sLoungeNameLbl.TabIndex = 2;
            sLoungeNameLbl.Text = "LOUNGE NAME";
            sLoungeNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            sLoungeNameLbl.Click += sMovieTheaterNameLbl_Click;
            // 
            // sFilmDateLbl
            // 
            sFilmDateLbl.AutoSize = true;
            sFilmDateLbl.BackColor = Color.Sienna;
            sFilmDateLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sFilmDateLbl.Location = new Point(16, 195);
            sFilmDateLbl.Name = "sFilmDateLbl";
            sFilmDateLbl.Size = new Size(95, 18);
            sFilmDateLbl.TabIndex = 4;
            sFilmDateLbl.Text = "FILM DATE";
            sFilmDateLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sFilmTimeLbl
            // 
            sFilmTimeLbl.AutoSize = true;
            sFilmTimeLbl.BackColor = Color.Sienna;
            sFilmTimeLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sFilmTimeLbl.Location = new Point(16, 237);
            sFilmTimeLbl.Name = "sFilmTimeLbl";
            sFilmTimeLbl.Size = new Size(89, 18);
            sFilmTimeLbl.TabIndex = 6;
            sFilmTimeLbl.Text = "FILM TIME";
            sFilmTimeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveSessionBtn
            // 
            saveSessionBtn.BackColor = Color.FromArgb(255, 128, 0);
            saveSessionBtn.FlatStyle = FlatStyle.Popup;
            saveSessionBtn.ForeColor = Color.Black;
            saveSessionBtn.Location = new Point(90, 293);
            saveSessionBtn.Name = "saveSessionBtn";
            saveSessionBtn.Size = new Size(250, 30);
            saveSessionBtn.TabIndex = 8;
            saveSessionBtn.Text = "ADD";
            saveSessionBtn.UseVisualStyleBackColor = false;
            saveSessionBtn.Click += saveSessionBtn_Click;
            // 
            // sFilmNameCombo
            // 
            sFilmNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sFilmNameCombo.FormattingEnabled = true;
            sFilmNameCombo.IntegralHeight = false;
            sFilmNameCombo.Location = new Point(183, 109);
            sFilmNameCombo.MaxDropDownItems = 3;
            sFilmNameCombo.Name = "sFilmNameCombo";
            sFilmNameCombo.Size = new Size(250, 23);
            sFilmNameCombo.Sorted = true;
            sFilmNameCombo.TabIndex = 1;
            sFilmNameCombo.SelectedIndexChanged += sMovieNameCombo_SelectedIndexChanged;
            // 
            // sLoungeNameCombo
            // 
            sLoungeNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sLoungeNameCombo.FormattingEnabled = true;
            sLoungeNameCombo.IntegralHeight = false;
            sLoungeNameCombo.Location = new Point(183, 153);
            sLoungeNameCombo.MaxDropDownItems = 3;
            sLoungeNameCombo.Name = "sLoungeNameCombo";
            sLoungeNameCombo.Size = new Size(250, 23);
            sLoungeNameCombo.Sorted = true;
            sLoungeNameCombo.TabIndex = 3;
            // 
            // sFilmDateDt
            // 
            sFilmDateDt.Format = DateTimePickerFormat.Short;
            sFilmDateDt.Location = new Point(183, 195);
            sFilmDateDt.Name = "sFilmDateDt";
            sFilmDateDt.Size = new Size(250, 23);
            sFilmDateDt.TabIndex = 5;
            sFilmDateDt.Value = new DateTime(2024, 4, 17, 0, 0, 0, 0);
            // 
            // sFilmTimeCombo
            // 
            sFilmTimeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sFilmTimeCombo.FormattingEnabled = true;
            sFilmTimeCombo.IntegralHeight = false;
            sFilmTimeCombo.Location = new Point(183, 234);
            sFilmTimeCombo.MaxDropDownItems = 3;
            sFilmTimeCombo.Name = "sFilmTimeCombo";
            sFilmTimeCombo.Size = new Size(250, 23);
            sFilmTimeCombo.Sorted = true;
            sFilmTimeCombo.TabIndex = 7;
            // 
            // datasSession
            // 
            datasSession.AllowUserToAddRows = false;
            datasSession.AllowUserToDeleteRows = false;
            datasSession.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasSession.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasSession.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasSession.Location = new Point(439, 3);
            datasSession.Name = "datasSession";
            datasSession.ReadOnly = true;
            datasSession.RowHeadersWidth = 51;
            datasSession.Size = new Size(462, 393);
            datasSession.TabIndex = 9;
            datasSession.DataBindingComplete += datasSession_DataBindingComplete;
            // 
            // customerPage
            // 
            customerPage.BackColor = Color.FromArgb(255, 192, 128);
            customerPage.Controls.Add(customerNameLbl);
            customerPage.Controls.Add(customerSurnameLbl);
            customerPage.Controls.Add(cardNumberLbl);
            customerPage.Controls.Add(validityPeriodLbl);
            customerPage.Controls.Add(securityCodeLbl);
            customerPage.Controls.Add(saveCustomerBtn);
            customerPage.Controls.Add(customerNameTxt);
            customerPage.Controls.Add(customerSurnameTxt);
            customerPage.Controls.Add(cardNumberTxt);
            customerPage.Controls.Add(securityCodeTxt);
            customerPage.Controls.Add(validityMonthCombo);
            customerPage.Controls.Add(validityYearCombo);
            customerPage.Controls.Add(datasSessions);
            customerPage.ForeColor = Color.Black;
            customerPage.Location = new Point(4, 24);
            customerPage.Name = "customerPage";
            customerPage.Size = new Size(904, 405);
            customerPage.TabIndex = 3;
            customerPage.Text = "CUSTOMER PAGE";
            // 
            // customerNameLbl
            // 
            customerNameLbl.AutoSize = true;
            customerNameLbl.BackColor = Color.Sienna;
            customerNameLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameLbl.Location = new Point(16, 99);
            customerNameLbl.Name = "customerNameLbl";
            customerNameLbl.Size = new Size(56, 18);
            customerNameLbl.TabIndex = 1;
            customerNameLbl.Text = "NAME";
            customerNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerSurnameLbl
            // 
            customerSurnameLbl.AutoSize = true;
            customerSurnameLbl.BackColor = Color.Sienna;
            customerSurnameLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerSurnameLbl.Location = new Point(16, 130);
            customerSurnameLbl.Name = "customerSurnameLbl";
            customerSurnameLbl.Size = new Size(91, 18);
            customerSurnameLbl.TabIndex = 3;
            customerSurnameLbl.Text = "SURNAME";
            customerSurnameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardNumberLbl
            // 
            cardNumberLbl.AutoSize = true;
            cardNumberLbl.BackColor = Color.Sienna;
            cardNumberLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cardNumberLbl.Location = new Point(16, 168);
            cardNumberLbl.Name = "cardNumberLbl";
            cardNumberLbl.Size = new Size(108, 18);
            cardNumberLbl.TabIndex = 7;
            cardNumberLbl.Text = "BANK CARD";
            cardNumberLbl.TextAlign = ContentAlignment.MiddleCenter;
            cardNumberLbl.Click += cardNumberLbl_Click;
            // 
            // validityPeriodLbl
            // 
            validityPeriodLbl.AutoSize = true;
            validityPeriodLbl.BackColor = Color.Sienna;
            validityPeriodLbl.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            validityPeriodLbl.Location = new Point(16, 253);
            validityPeriodLbl.Name = "validityPeriodLbl";
            validityPeriodLbl.Size = new Size(101, 17);
            validityPeriodLbl.TabIndex = 9;
            validityPeriodLbl.Text = "EXPIRATION";
            validityPeriodLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // securityCodeLbl
            // 
            securityCodeLbl.AutoSize = true;
            securityCodeLbl.BackColor = Color.Sienna;
            securityCodeLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            securityCodeLbl.Location = new Point(16, 210);
            securityCodeLbl.Name = "securityCodeLbl";
            securityCodeLbl.Size = new Size(43, 18);
            securityCodeLbl.TabIndex = 12;
            securityCodeLbl.Text = "CVC";
            securityCodeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveCustomerBtn
            // 
            saveCustomerBtn.BackColor = Color.FromArgb(255, 128, 0);
            saveCustomerBtn.FlatStyle = FlatStyle.Popup;
            saveCustomerBtn.ForeColor = Color.Black;
            saveCustomerBtn.Location = new Point(54, 327);
            saveCustomerBtn.Name = "saveCustomerBtn";
            saveCustomerBtn.Size = new Size(230, 30);
            saveCustomerBtn.TabIndex = 14;
            saveCustomerBtn.Text = "ADD";
            saveCustomerBtn.UseVisualStyleBackColor = false;
            saveCustomerBtn.Click += saveCustomerBtn_Click;
            // 
            // customerNameTxt
            // 
            customerNameTxt.Location = new Point(133, 99);
            customerNameTxt.Name = "customerNameTxt";
            customerNameTxt.Size = new Size(230, 23);
            customerNameTxt.TabIndex = 2;
            customerNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // customerSurnameTxt
            // 
            customerSurnameTxt.CharacterCasing = CharacterCasing.Upper;
            customerSurnameTxt.Location = new Point(133, 131);
            customerSurnameTxt.Name = "customerSurnameTxt";
            customerSurnameTxt.Size = new Size(230, 23);
            customerSurnameTxt.TabIndex = 4;
            customerSurnameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // cardNumberTxt
            // 
            cardNumberTxt.Location = new Point(133, 168);
            cardNumberTxt.Mask = "0000 0000 0000 0000";
            cardNumberTxt.Name = "cardNumberTxt";
            cardNumberTxt.Size = new Size(230, 23);
            cardNumberTxt.TabIndex = 8;
            cardNumberTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // securityCodeTxt
            // 
            securityCodeTxt.Location = new Point(133, 210);
            securityCodeTxt.Mask = "000";
            securityCodeTxt.Name = "securityCodeTxt";
            securityCodeTxt.Size = new Size(151, 23);
            securityCodeTxt.TabIndex = 13;
            securityCodeTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // validityMonthCombo
            // 
            validityMonthCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            validityMonthCombo.FormattingEnabled = true;
            validityMonthCombo.IntegralHeight = false;
            validityMonthCombo.Location = new Point(133, 253);
            validityMonthCombo.MaxDropDownItems = 3;
            validityMonthCombo.Name = "validityMonthCombo";
            validityMonthCombo.Size = new Size(110, 23);
            validityMonthCombo.TabIndex = 10;
            // 
            // validityYearCombo
            // 
            validityYearCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            validityYearCombo.FormattingEnabled = true;
            validityYearCombo.IntegralHeight = false;
            validityYearCombo.Location = new Point(253, 253);
            validityYearCombo.MaxDropDownItems = 3;
            validityYearCombo.Name = "validityYearCombo";
            validityYearCombo.Size = new Size(110, 23);
            validityYearCombo.TabIndex = 11;
            // 
            // datasSessions
            // 
            datasSessions.AllowUserToAddRows = false;
            datasSessions.AllowUserToDeleteRows = false;
            datasSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasSessions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasSessions.Location = new Point(369, 3);
            datasSessions.Name = "datasSessions";
            datasSessions.ReadOnly = true;
            datasSessions.RowHeadersWidth = 51;
            datasSessions.Size = new Size(535, 392);
            datasSessions.TabIndex = 0;
            datasSessions.DataBindingComplete += datasSessions_DataBindingComplete;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(936, 457);
            Controls.Add(Pages);
            Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SESSION TRACKING";
            Load += HomePage_Load;
            KeyDown += HomePage_KeyDown;
            Pages.ResumeLayout(false);
            moviePage.ResumeLayout(false);
            moviePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasFilm).EndInit();
            movieTheaterPage.ResumeLayout(false);
            movieTheaterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasLounge).EndInit();
            sessionPage.ResumeLayout(false);
            sessionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasSession).EndInit();
            customerPage.ResumeLayout(false);
            customerPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasSessions).EndInit();
            ResumeLayout(false);
        }

        private TabControl Pages;
        private TabPage moviePage;
        private TabPage movieTheaterPage;
        private TabPage sessionPage;
        private TabPage customerPage;
        private Label FilmNameLbl;
        private Label FilmTime1Lbl;
        private Label FilmTime2Lbl;
        private Label FilmTime3Lbl;
        private Label LoungeNameLbl;
        private Label LoungeCapacityLbl;
        private Label sFilmNameLbl;
        private Label sLoungeNameLbl;
        private Label sFilmDateLbl;
        private Label sFilmTimeLbl;
        private Label customerNameLbl;
        private Label customerSurnameLbl;
        private Label cardNumberLbl;
        private Label validityPeriodLbl;
        private Label securityCodeLbl;
        private Button FilmAddBtn;
        private Button LoungeBtn;
        private Button saveSessionBtn;
        private Button saveCustomerBtn;
        public TextBox FilmNameTxt;
        public TextBox LoungeNameTxt;
        public TextBox customerNameTxt;
        public TextBox customerSurnameTxt;
        public MaskedTextBox LoungeCapacityTxt;
        public MaskedTextBox cardNumberTxt;
        public MaskedTextBox securityCodeTxt;
        public DateTimePicker FilmTime1Dt;
        public DateTimePicker FilmTime2Dt;
        public DateTimePicker FilmTime3Dt;
        public DateTimePicker sFilmDateDt;
        public ComboBox sFilmNameCombo;
        public ComboBox sLoungeNameCombo;
        public ComboBox sFilmTimeCombo;
        public ComboBox validityMonthCombo;
        public ComboBox validityYearCombo;
        public DataGridView datasFilm;
        public DataGridView datasLounge;
        public DataGridView datasSession;
        public DataGridView datasSessions;
    }
}
