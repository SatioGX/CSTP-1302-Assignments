namespace Ch5_Q14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    int total = 0;
                    int count = 0;

                    foreach (string line in lines)
                    {
                        int number;
                        if (int.TryParse(line, out number))
                        {
                            listBox1.Items.Add(number);
                            total += number;
                            count++;
                        }
                    }

                    sumNumbers.Text = "Total: " + total.ToString();
                    totalNumbers.Text = "Count: " + count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while reading the file: {ex.Message}");
                }
            }
        }

        private void sumNumbers_Click(object sender, EventArgs e)
        {

        }

        private void totalNumbers_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}