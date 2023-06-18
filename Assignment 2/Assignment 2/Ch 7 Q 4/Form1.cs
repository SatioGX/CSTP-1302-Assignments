using System.Security.Policy;

namespace Ch_7_Q_4
{
    public partial class Form1 : Form
    {
        private static readonly char[] CorrectAnswers = { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studentAnswers_Click(object sender, EventArgs e)
        {
            IncorrectQuestionsBox.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.Title = "Select Student Answers File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ProcessStudentAnswers(filePath);
            }
        }

        private void ProcessStudentAnswers(string filePath)
        {
            try
            {
                char[] studentAnswers = ReadStudentAnswersFromFile(filePath);

                int correctCount = CalculateCorrectAnswers(studentAnswers);
                int incorrectCount = CorrectAnswers.Length - correctCount;

                correctLabel.Text = "Total Correct Answers: " + correctCount.ToString();
                incorrectLabel.Text = "Total Incorrect Answers: " + incorrectCount.ToString();

                if (correctCount >= 15)
                {
                    resultLabel.Text = "Result: Pass";
                }
                else
                {
                    resultLabel.Text = "Result: Fail";
                }

                if (incorrectCount > 0)
                {
                    incorrectQuestionsLabel.Text = "Questions Answered Incorrectly: ";
                    for (int i = 0; i < studentAnswers.Length; i++)
                    {
                        if (studentAnswers[i] != CorrectAnswers[i])
                        {
                            IncorrectQuestionsBox.Items.Add("Question " + (i + 1) + " Correct Answer: " + (CorrectAnswers[i]));
                        }
                    }

                }
                else
                {
                    IncorrectQuestionsBox.Items.Add("Questions Answered Incorrectly: \n None");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error: File not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private char[] ReadStudentAnswersFromFile(string filePath)
        {
            string answersText = File.ReadAllText(filePath);
            answersText = answersText.Replace(" ", string.Empty);
            return answersText.ToCharArray();
        }

        private int CalculateCorrectAnswers(char[] studentAnswers)
        {
            int count = 0;
            for (int i = 0; i < CorrectAnswers.Length; i++)
            {
                if (studentAnswers[i] == CorrectAnswers[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}