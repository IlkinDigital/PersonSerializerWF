namespace PersonSerializerWF
{
    public partial class Form1 : Form
    {
        static private Backend.PeopleHandler PersonHandler = new("people_data.json");
        private string CurrentProfileFilepath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            name_textBox.Text = "";
            surname_textBox.Text = "";
            age_numericUpDown.Value = 0;
            profile_pictureBox.BackgroundImage = profile_pictureBox.InitialImage;
            CurrentProfileFilepath = "";
        }

        private bool IsInputDataValid()
        {
            return name_textBox.Text != ""
                && surname_textBox.Text != ""
                && profile_pictureBox.BackgroundImage != profile_pictureBox.InitialImage;
        }

        private void load_button_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.Title = "Select your photo";
            ofd.Filter = "Image File (*.gif; *.jpg; *.jpeg; *.png; *.bmp;) | *.gif; *.jpg; *.jpeg; *.png; *.bmp;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CurrentProfileFilepath = ofd.FileName;
                Bitmap img = new(CurrentProfileFilepath);
                profile_pictureBox.BackgroundImage = img;
            }
        }

        private void reset_button_MouseClick(object sender, MouseEventArgs e)
        {
            Reset();
        }

        private void add_button_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsInputDataValid())
            {
                var person = new Backend.Person(name_textBox.Text, surname_textBox.Text, 
                                                Convert.ToInt32(age_numericUpDown.Value), 
                                                CurrentProfileFilepath);

                PersonHandler.Add(person);
                Reset();
            }
        }
    }
}