using Q1_Fall22.Models;

namespace Q1_Fall22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadListBox();
        }

        private void LoadComboBox()
        {
            using (var context = new PE_PRN_Fall22B1Context())
            {
                List<Producer> producerList = context.Producers.ToList();
                cbProducer.DisplayMember = "Name";
                cbProducer.DataSource = producerList;
                cbProducer.ValueMember = "Id";
            }
        }

        private void LoadListBox()
        {
            using (var context = new PE_PRN_Fall22B1Context())
            {
                List<Genre> genres = context.Genres.ToList();
                listBox1.DataSource = genres;
                listBox1.DisplayMember = "Title";
                listBox1.ValueMember = "Id";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new PE_PRN_Fall22B1Context())
            {
                Movie movie = new Movie();
                movie.Title = tbTitle.Text;
                movie.Description = tbDescription.Text;
                movie.ReleaseDate = dateTimePicker1.Value;
                movie.Language = tbLanguage.Text;
                Producer p = cbProducer.SelectedItem as Producer;
                movie.ProducerId = p.Id;
                List<Genre> selectedGenres = listBox1.SelectedItems.Cast<Genre>().ToList();
                foreach (var genre in selectedGenres)
                {
                    if (!context.Genres.Local.Contains(genre))
                    {
                        context.Genres.Attach(genre);
                    }
                }
                foreach (var genre in selectedGenres)
                {
                    movie.Genres.Add(genre);
                }
                context.Movies.Add(movie);
                context.SaveChanges();
                MessageBox.Show("Add new movie successfully");
            }
        }


    }
}