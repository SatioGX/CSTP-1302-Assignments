namespace Ch5_Q13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count;
            if (!int.TryParse(textBox1.Text, out count) || count <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer for the number of random numbers.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                try
                {
                    Random random = new Random();
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int randomNumber = random.Next(1, 101);
                            writer.WriteLine(randomNumber);
                        }
                    }

                    MessageBox.Show("Random numbers saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the random numbers: {ex.Message}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}