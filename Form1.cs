using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.Json;

namespace MyFirstProject
{
    public partial class Form1 : Form
    {
        //to avoid hardcoding path every time, we declare a variable
        private string filePath = "C:\\Users\\2024-0252\\Downloads\\test.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    List<string>? items = JsonSerializer.Deserialize<List<string>>(jsonString);

                    if (items != null)
                    {
                        listBox1.Items.AddRange(items.ToArray());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                listBox1.Items.Add("Sean");
                listBox1.Items.Add("Karl");
                listBox1.Items.Add("Sharlot");
                listBox1.Items.Add("JayEm");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveItems();
            base.OnFormClosing(e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveItems();
        }

        private void SaveItems()
        {
            try
            {
                string? dir = Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                List<string> items = new List<string>();
                foreach (var item in listBox1.Items)
                {
                    if (item != null)
                        items.Add(item.ToString() ?? string.Empty);
                }

                string jsonString = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newItem = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(newItem))
            {
                listBox1.Items.Add(newItem);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Add text to continue!", "TARUNGA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index != -1)
            {
                string updatedText = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(updatedText))
                {
                    listBox1.Items[index] = updatedText;
                    MessageBox.Show("Item edited successfully!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox1.Clear();
                    listBox1.ClearSelected();
                }
                else
                {
                    MessageBox.Show("Please enter new text before editing.", "TARUNGA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list to edit.", "TARUNGA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("select an item to delete.", "TARUNGA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
