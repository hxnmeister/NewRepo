using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumeAnalizatorParallel
{
    public partial class Form1 : Form
    {
        List<Candidate> candidates = new List<Candidate>();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "Text Files (*.txt) | *.txt",
                Multiselect = true
            };

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                Parallel.ForEach(fileDialog.FileNames, (filePath) =>
                {
                    Candidate candidate = new Candidate();

                    foreach (string line in File.ReadLines(filePath))
                    {
                        if (line.StartsWith("Name:"))
                            candidate.Name = line.Replace("Name:", string.Empty).Trim();
                        else if (line.StartsWith("Age:"))
                            candidate.Age = int.Parse(line.Replace("Age:", string.Empty).Replace("years", string.Empty).Trim());
                        else if (line.StartsWith("Expierence:"))
                            candidate.ExperienceYears = int.Parse(line.Replace("Expierence:", string.Empty).Replace("years", string.Empty).Trim());
                        else if (line.StartsWith("About:"))
                            candidate.About = line.Replace("About:", string.Empty).Trim();
                        else if (line.StartsWith("Salary:"))
                            candidate.Salary = decimal.Parse(line.Replace("Salary:", string.Empty).Replace("$", string.Empty).Trim());
                        else if (line.StartsWith("City:"))
                            candidate.City = line.Replace("City:", string.Empty).Trim();
                    }

                    candidates.Add(candidate);
                });

                FilesLoadedListBox.Items.AddRange(fileDialog.SafeFileNames);
                MessageBox.Show("Files successfully loaded!", "Files Loaded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The file upload has been cancelled!", "Upload Cancelled!" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {

            if(candidates.Count > 1)
            {
                Candidate mostExpierence = candidates.OrderByDescending(x => x.ExperienceYears).FirstOrDefault();
                Candidate leastExpierence = candidates.OrderBy(x => x.ExperienceYears).FirstOrDefault();
                Candidate highestSalary = candidates.OrderByDescending(x => x.Salary).FirstOrDefault();
                Candidate lowestSalary = candidates.OrderBy(x => x.Salary).FirstOrDefault();
                var uniqueCity = candidates.Select(x => x.City).Distinct().ToList();

                ReportTextBox.Text += $"Most expierence: {mostExpierence.ExperienceYears} {mostExpierence.Name}\r\n";
                ReportTextBox.Text += $"Least expierence: {leastExpierence.ExperienceYears} {leastExpierence.Name}\r\n";
                ReportTextBox.Text += $"{(uniqueCity.Count == 1 ? $"All candidates from {uniqueCity.First()}!" : "All candidates from different cities!")}\r\n";
                ReportTextBox.Text += $"Highest salary: {highestSalary.Salary} {highestSalary.Name}\r\n";
                ReportTextBox.Text += $"Lowest expierence: {lowestSalary.Salary} {lowestSalary.Name}\r\n";
            }
            else if(candidates.Count == 1)
            {
                MessageBox.Show("There is only one candidate!", "One Candidate!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No resume loaded!", "No Data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
