using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kal_Quests_Tracker.Models;
using Newtonsoft.Json;

namespace Kal_Quests_Tracker
{
    public partial class Form1 : Form
    {
        private List<Quest> allQuests;
        private List<Quest> filteredQuests;
        private CharacterProfile currentProfile;
        private string profilesDirectory;

        public Form1()
        {
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            allQuests = new List<Quest>();
            filteredQuests = new List<Quest>();
            profilesDirectory = Path.Combine(Application.StartupPath, "Profiles");

            if (!Directory.Exists(profilesDirectory))
            {
                Directory.CreateDirectory(profilesDirectory);
            }

            // Set default values
            comboBoxQuestType.SelectedIndex = 0; // "All Types"

            // Apply dark theme colors
            ApplyDarkTheme();
        }

        private void ApplyDarkTheme()
        {
            // Set form colors
            this.BackColor = Color.FromArgb(37, 37, 38);

            // Set panel colors
            panelTop.BackColor = Color.FromArgb(27, 27, 28);
            panelMain.BackColor = Color.FromArgb(37, 37, 38);
            panelLeft.BackColor = Color.FromArgb(37, 37, 38);
            panelRight.BackColor = Color.FromArgb(37, 37, 38);
            panelQuestFilters.BackColor = Color.FromArgb(37, 37, 38);
            panelQuestDetails.BackColor = Color.FromArgb(37, 37, 38);

            // Add some visual enhancements
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadQuestData();
            LoadDefaultProfile();
            RefreshQuestList();
            ShowWelcomeMessage();
        }

        private void ShowWelcomeMessage()
        {
            currentSelectedQuest = null;
            checkBoxQuestCompleted.CheckedChanged -= checkBoxQuestCompleted_CheckedChanged;
            checkBoxQuestCompleted.Checked = false;
            checkBoxQuestCompleted.CheckedChanged += checkBoxQuestCompleted_CheckedChanged;

            richTextBoxQuestDetails.Clear();
            
            AppendColoredText("Welcome to KalOnline Quest Tracker!\n\n", Color.Gold, true);
            AppendColoredText("Getting Started:\n", Color.Yellow, true);
            AppendColoredText("1. Enter your character name above\n", Color.White, false);

            AppendColoredText("2. Select a quest from the list to view details\n", Color.White, false);
            AppendColoredText("3. Use the '✓ Completed' checkbox or double-click to mark quests as done\n", Color.White, false);
            AppendColoredText("4. Use filters to find specific quest types\n\n", Color.White, false);

            AppendColoredText("Features:\n", Color.Yellow, true);
            AppendColoredText("• ", Color.White, false);
            AppendColoredText("NPCs", Color.LightBlue, false);
            AppendColoredText(" are highlighted in blue\n", Color.White, false);
            AppendColoredText("• ", Color.White, false);
            AppendColoredText("Items", Color.Orange, false);
            AppendColoredText(" are highlighted in orange\n", Color.White, false);
            AppendColoredText("• ", Color.White, false);
            AppendColoredText("Monsters", Color.IndianRed, false);
            AppendColoredText(" are highlighted in red\n", Color.White, false);
            AppendColoredText("• ", Color.White, false);
            AppendColoredText("Locations", Color.Cyan, false);
            AppendColoredText(" are highlighted in cyan\n", Color.White, false);
            AppendColoredText("• Completed quests appear in ", Color.White, false);
            AppendColoredText("green", Color.LightGreen, false);
            AppendColoredText(" with checkmarks ✓\n\n", Color.White, false);

            AppendColoredText("Select a quest to begin!", Color.LightGreen, true);
        }

        private void LoadQuestData()
        {
            try
            {
                string questDataPath = Path.Combine(Application.StartupPath, "QuestsData.json");
                if (File.Exists(questDataPath))
                {
                    string jsonContent = File.ReadAllText(questDataPath);
                    var questData = JsonConvert.DeserializeObject<QuestData>(jsonContent);
                    allQuests = questData.Quests ?? new List<Quest>();

                    // Debug: Check if we loaded quests properly
                    if (allQuests.Count == 0)
                    {
                        MessageBox.Show("No quests were loaded from the JSON file. Please check the file format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    // Sort quests by level, then by type, then by quest ID 
                    allQuests = allQuests.OrderBy(q => q.Level)
                                       .ThenBy(q => q.Type)
                                       .ThenBy(q => q.QuestIdString)
                                       .ToList();
                }
                else
                {
                    MessageBox.Show("QuestsData.json file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quest data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadDefaultProfile()
        {
            //this will load the last used character name and load the profile if it exists
            try
            {
                string defaultProfilePath = Path.Combine(profilesDirectory, "default.json");
                if (File.Exists(defaultProfilePath))
                {
                    string jsonContent = File.ReadAllText(defaultProfilePath);
                    var defaultSettings = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonContent);

                    if (defaultSettings != null && defaultSettings.ContainsKey("CharacterName"))
                    {
                        string lastCharacterName = defaultSettings["CharacterName"].ToString();

                        string profilePath = Path.Combine(profilesDirectory, lastCharacterName + ".json");
                        if (File.Exists(profilePath))
                        {
                            string profileJson = File.ReadAllText(profilePath);
                            currentProfile = JsonConvert.DeserializeObject<CharacterProfile>(profileJson);
                            textBoxCharacterName.Text = currentProfile.CharacterName;
                        }
                        else
                        {
                            currentProfile = new CharacterProfile(lastCharacterName);
                            textBoxCharacterName.Text = lastCharacterName;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // If there's an error loading the default profile, just continue with no profile
                currentProfile = null;
                textBoxCharacterName.Text = "";
            }
        }

        private void RefreshQuestList()
        {
            filteredQuests.Clear();

            string selectedType = comboBoxQuestType.SelectedItem?.ToString();
            bool showCompleted = checkBoxShowCompleted.Checked;

            foreach (var quest in allQuests)
            {
                // Filter by type
                if (selectedType != "All Types" && quest.Type != selectedType)
                    continue;

                // Filter by completion status
                if (!showCompleted && IsQuestCompleted(quest))
                    continue;

                filteredQuests.Add(quest);
            }

            listBoxQuests.Items.Clear();
            foreach (var quest in filteredQuests)
            {
                listBoxQuests.Items.Add(quest);
            }
        }

        private bool IsQuestCompleted(Quest quest)
        {
            if (currentProfile == null) return false;
            return currentProfile.IsQuestCompleted(currentProfile.GetQuestKey(quest));
        }

        private void listBoxQuests_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var quest = (Quest)listBoxQuests.Items[e.Index];
            bool isCompleted = IsQuestCompleted(quest);
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Background color
            Color backgroundColor;
            if (isSelected)
            {
                backgroundColor = Color.FromArgb(51, 153, 255);
            }
            else if (isCompleted)
            {
                backgroundColor = Color.FromArgb(40, 80, 40); // Dark green for completed
            }
            else
            {
                backgroundColor = Color.FromArgb(45, 45, 48);
            }

            using (var brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            // Text colors
            Color textColor = isCompleted ? Color.LightGreen : Color.White;
            Color typeColor = quest.Type == "QUEST" ? Color.LightBlue : Color.Orange;

            // Draw quest info
            using (var textBrush = new SolidBrush(textColor))
            using (var typeBrush = new SolidBrush(typeColor))
            using (var font = new Font("Segoe UI", 9F))
            using (var boldFont = new Font("Segoe UI", 9F, FontStyle.Bold))
            {
                int x = e.Bounds.X + 5;
                int y = e.Bounds.Y + 2;

                // Draw type
                e.Graphics.DrawString(quest.Type, boldFont, typeBrush, x, y);

                // Draw quest ID and level
                string questInfo = quest.QuestIdString + " (Lv." + quest.Level + ")";
                var typeSize = e.Graphics.MeasureString(quest.Type, boldFont);
                e.Graphics.DrawString(questInfo, font, textBrush, x + typeSize.Width + 10, y);

                // Draw completion indicator
                if (isCompleted)
                {
                    using (var completedBrush = new SolidBrush(Color.LightGreen))
                    {
                        e.Graphics.DrawString("✓", boldFont, completedBrush, e.Bounds.Right - 25, y);
                    }
                }
            }

            e.DrawFocusRectangle();
        }

        private void listBoxQuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxQuests.SelectedItem is Quest selectedQuest)
            {
                DisplayQuestDetails(selectedQuest);
            }
        }

        private Quest currentSelectedQuest;

        private void DisplayQuestDetails(Quest quest)
        {
            currentSelectedQuest = quest;
            labelQuestTitle.Text = quest.Type + " " + quest.QuestIdString + " - Level " + quest.Level;

            // Update completion checkbox
            checkBoxQuestCompleted.CheckedChanged -= checkBoxQuestCompleted_CheckedChanged; // Temporarily remove handler
            checkBoxQuestCompleted.Checked = IsQuestCompleted(quest);
            checkBoxQuestCompleted.CheckedChanged += checkBoxQuestCompleted_CheckedChanged; // Re-add handler

            richTextBoxQuestDetails.Clear();

            // Add steps section
            AppendColoredText("STEPS:\n", Color.Yellow, true);
            for (int i = 0; i < quest.Steps.Count; i++)
            {
                AppendColoredText((i + 1) + ". ", Color.White, false);
                AppendStepWithColors(quest.Steps[i]);
                AppendColoredText("\n", Color.White, false);
            }

            AppendColoredText("\n", Color.White, false);

            // Add rewards section
            AppendColoredText("REWARDS:\n", Color.Gold, true);
            foreach (var reward in quest.Rewards)
            {
                AppendColoredText("• ", Color.White, false);
                AppendColoredText(reward + "\n", Color.LightGreen, false);
            }
        }
        
        private void AppendStepWithColors(string step)
        {
            // Clean the step first - remove duplicate text and parentheses numbers
            string cleanedStep = CleanStepText(step);

            //FUCK MY LIFE THIS WAS HARD
            // Patterns for different elements 
            var patterns = new List<(Regex regex, Color color, string type)>
            {
                // Monsters in "Kill X" statements FUCK REGEX I HATE THIS SHIT
                (new Regex(@"Kill\s+\d+\s+""([^""]+)""", RegexOptions.IgnoreCase), Color.IndianRed, "kill_monster"),

                // Monsters after "by"
                (new Regex(@"by\s+""([^""]+)""", RegexOptions.IgnoreCase), Color.IndianRed, "monster"),

                // Items (in quotes, typically dropped items or quest items)
                (new Regex(@"""([^""]+)"",?\s*which\s+(is|are)\s+dropped", RegexOptions.IgnoreCase), Color.Orange, "item"),

                // Cities and locations (in quotes after "Go to" or similar)
                (new Regex(@"(Go to|city|Pojdi v)\s+""([^""]+)""", RegexOptions.IgnoreCase), Color.Cyan, "location"),

                // NPCs and characters (in quotes)
                (new Regex(@"""([^""]+)""", RegexOptions.IgnoreCase), Color.LightBlue, "npc"),

                // Special characters in brackets
                (new Regex(@"\[([^\]]+)\]", RegexOptions.IgnoreCase), Color.Magenta, "special")
            };

            var matches = new List<(int start, int length, Color color)>();

            // Find all matches
            foreach (var (regex, color, type) in patterns)
            {
                var regexMatches = regex.Matches(cleanedStep);

                foreach (Match match in regexMatches)
                {
                    switch (type)
                    {
                        case "kill_monster":
                        case "monster":
                        case "item":
                            var contentGroup = match.Groups[1];
                            matches.Add((contentGroup.Index, contentGroup.Length, color));
                            break;
                        case "location":
                            var locationGroup = match.Groups[2];
                            matches.Add((locationGroup.Index, locationGroup.Length, color));
                            break;
                        case "npc":

                            var npcGroup = match.Groups[1];

                            bool alreadyCovered = matches.Any(m =>
                                m.start <= npcGroup.Index &&
                                m.start + m.length >= npcGroup.Index + npcGroup.Length);
                            if (!alreadyCovered)
                            {
                                matches.Add((npcGroup.Index, npcGroup.Length, color));
                            }
                            break;
                        case "special":
                            var specialGroup = match.Groups[1];
                            matches.Add((specialGroup.Index, specialGroup.Length, color));
                            break;
                    }
                }
            }

            // Sort matches by position and remove overlaps
            matches = matches.OrderBy(m => m.start).ToList();
            var finalMatches = new List<(int start, int length, Color color)>();

            foreach (var match in matches)
            {
                bool overlaps = finalMatches.Any(m =>
                    (match.start >= m.start && match.start < m.start + m.length) ||
                    (match.start + match.length > m.start && match.start + match.length <= m.start + m.length) ||
                    (match.start <= m.start && match.start + match.length >= m.start + m.length));

                if (!overlaps)
                {
                    finalMatches.Add(match);
                }
            }

            // Apply colors
            int currentIndex = 0;
            foreach (var match in finalMatches.OrderBy(m => m.start))
            {
                // Add text before the match
                if (match.start > currentIndex)
                {
                    string beforeText = cleanedStep.Substring(currentIndex, match.start - currentIndex);
                    AppendColoredText(beforeText, Color.White, false);
                }

                // Add the colored match
                string matchText = cleanedStep.Substring(match.start, match.length);
                AppendColoredText(matchText, match.color, false);

                currentIndex = match.start + match.length;
            }

            // Add remaining text
            if (currentIndex < cleanedStep.Length)
            {
                string remainingText = cleanedStep.Substring(currentIndex);
                AppendColoredText(remainingText, Color.White, false);
            }
        }

        private string CleanStepText(string step)
        {
            if (string.IsNullOrEmpty(step)) return step;

            // Remove duplicate quoted text (like "Narootuh"Narootuh")
            step = Regex.Replace(step, @"""([^""]+)""\1""", @"""$1""", RegexOptions.IgnoreCase);

            // Remove duplicate parentheses numbers (like (24)(24))
            step = Regex.Replace(step, @"\((\d+)\)\1\)", @"", RegexOptions.IgnoreCase);

            // Remove single parentheses numbers (like (24))
            step = Regex.Replace(step, @"\s*\(\d+\)", "", RegexOptions.IgnoreCase);

            return step;
        }

        private void AppendColoredText(string text, Color color, bool bold = false)
        {
            int start = richTextBoxQuestDetails.TextLength;
            richTextBoxQuestDetails.AppendText(text);
            int end = richTextBoxQuestDetails.TextLength;

            richTextBoxQuestDetails.Select(start, end - start);
            richTextBoxQuestDetails.SelectionColor = color;
            if (bold)
            {
                richTextBoxQuestDetails.SelectionFont = new Font(richTextBoxQuestDetails.Font, FontStyle.Bold);
            }
            richTextBoxQuestDetails.Select(end, 0);

        }

        private void listBoxQuests_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxQuests.SelectedItem is Quest selectedQuest)
            {
                ToggleQuestCompletion(selectedQuest);
            }
        }

        private void ToggleQuestCompletion(Quest selectedQuest)
        {
            if (currentProfile == null)
            {
                MessageBox.Show("Please enter a character name first!", "No Character", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string questKey = currentProfile.GetQuestKey(selectedQuest);

            if (currentProfile.IsQuestCompleted(questKey))
            {
                currentProfile.MarkQuestIncomplete(questKey);
            }
            else
            {
                currentProfile.MarkQuestCompleted(questKey);
            }

            // Refresh the list to show updated completion status
            listBoxQuests.Invalidate();
        }

        private void comboBoxQuestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshQuestList();
        }

        private void checkBoxShowCompleted_CheckedChanged(object sender, EventArgs e)
        {
            RefreshQuestList();
        }

        private void checkBoxQuestCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (currentSelectedQuest != null && currentProfile != null)
            {
                string questKey = currentProfile.GetQuestKey(currentSelectedQuest);

                if (checkBoxQuestCompleted.Checked)
                {
                    currentProfile.MarkQuestCompleted(questKey);
                }
                else
                {
                    currentProfile.MarkQuestIncomplete(questKey);
                }

                // Refresh the quest list to show updated completion status
                listBoxQuests.Invalidate();
            }
            else if (currentProfile == null)
            {
                // Reset checkbox if no profile
                checkBoxQuestCompleted.CheckedChanged -= checkBoxQuestCompleted_CheckedChanged;
                checkBoxQuestCompleted.Checked = false;
                checkBoxQuestCompleted.CheckedChanged += checkBoxQuestCompleted_CheckedChanged;

                MessageBox.Show("Please enter a character name first!", "No Character", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSaveProfile_Click(object sender, EventArgs e)
        {
            string characterName = textBoxCharacterName.Text.Trim();
            if (string.IsNullOrEmpty(characterName))
            {
                MessageBox.Show("Please enter a character name!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (currentProfile == null)
                {
                    currentProfile = new CharacterProfile(characterName);
                }
                else
                {
                    currentProfile.CharacterName = characterName;
                    currentProfile.LastModified = DateTime.Now;
                }

                string profilePath = Path.Combine(profilesDirectory, $"{characterName}.json");
                string jsonContent = JsonConvert.SerializeObject(currentProfile, Formatting.Indented);
                File.WriteAllText(profilePath, jsonContent);
                SaveDefaultProfile(characterName);

                MessageBox.Show("Profile saved successfully for " + characterName + "!", "Profile Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadProfile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = profilesDirectory;
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Select Character Profile";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(openFileDialog.FileName);
                        currentProfile = JsonConvert.DeserializeObject<CharacterProfile>(jsonContent);

                        if (currentProfile != null)
                        {
                            textBoxCharacterName.Text = currentProfile.CharacterName;
                            RefreshQuestList();
                            SaveDefaultProfile(currentProfile.CharacterName);
                            MessageBox.Show("Profile loaded successfully for " + currentProfile.CharacterName + "!", "Profile Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Additional helper methods for better user experience
        private void CreateNewProfile()
        {
            string characterName = textBoxCharacterName.Text.Trim();
            if (!string.IsNullOrEmpty(characterName))
            {
                currentProfile = new CharacterProfile(characterName);
                RefreshQuestList();
                SaveDefaultProfile(characterName);
            }
        }

        private void SaveDefaultProfile(string characterName)
        {
            try
            {
                string defaultProfilePath = Path.Combine(profilesDirectory, "default.json");
                var defaultSettings = new Dictionary<string, object>
                {
                    { "CharacterName", characterName }
                };
                string jsonContent = JsonConvert.SerializeObject(defaultSettings, Formatting.Indented);
                File.WriteAllText(defaultProfilePath, jsonContent);
            }
            catch (Exception ex)
            {
                // Silently ignore errors when saving default profile
                // We don't want to interrupt the user's workflow
            }
        }

        private void textBoxCharacterName_TextChanged(object sender, EventArgs e)
        {
            // Auto-create profile when user types a name
            if (!string.IsNullOrEmpty(textBoxCharacterName.Text.Trim()) && currentProfile == null)
            {
                CreateNewProfile();
            }
        }

        private void textBoxCharacterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Create profile on Enter key
            if (e.KeyChar == (char)Keys.Enter)
            {
                CreateNewProfile();
                e.Handled = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Auto-save current profile if character name is entered
            if (currentProfile != null && !string.IsNullOrEmpty(textBoxCharacterName.Text.Trim()))
            {
                try
                {
                    string characterName = textBoxCharacterName.Text.Trim();
                    currentProfile.CharacterName = characterName;
                    currentProfile.LastModified = DateTime.Now;

                    string profilePath = Path.Combine(profilesDirectory, characterName + ".json");
                    string jsonContent = JsonConvert.SerializeObject(currentProfile, Formatting.Indented);
                    File.WriteAllText(profilePath, jsonContent);
                    SaveDefaultProfile(characterName);
                }
                catch
                {
                    // Ignore save errors on close
                }
            }

            base.OnFormClosing(e);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (currentProfile != null)
            {
                // Ask for confirmation first
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to reset the completion status of all quests?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    allQuests = new List<Quest>();
                    filteredQuests = new List<Quest>();
                    currentProfile = null;
                    textBoxCharacterName.Text = "";
                    LoadQuestData();
                    RefreshQuestList();
                    // Refresh the quest list to show updated completion status
                    listBoxQuests.Invalidate();
                }
            }
            else if (currentProfile == null)
            {


                MessageBox.Show("Please enter a character name first!", "No Character", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
