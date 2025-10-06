using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Collections;
using static System.Collections.Specialized.BitVector32;

namespace TrialsDocumentCreator
{
    public partial class Form1 : Form
    {
        private string TrialsJson;
        private string MKJson;

        private string RigsJson;
        private string ToolsJson;
        private string SkillsJson;
        private string MedicinesJson;

        private List<TrialInfo> TrialsList;
        private List<TrialInfo> MKList;

        private List<Difficulty> DifficultyList;

        private List<string> RigsList;
        private List<string> ToolsList;
        private List<string> SkillsList;
        private List<string> MedicinesList;

        public Form1()
        {
            InitializeComponent();

            LoadTrialLists();

            TrialTypeComboBox.Items.AddRange(new[] { "Trial", "MK-Challenge", "Both" });
            TrialTypeComboBox.SelectedIndex = 2;

#pragma warning disable CS0168 // Переменная объявлена, но не используется
            try
            {
                string[] lines = File.ReadAllLines("data.txt");
                TrialTypeComboBox.SelectedIndex = Convert.ToInt32(lines[0]);
                PlayersTextBox.Text = lines[1];
                SavePathTextBox.Text = lines[2];
            }
            
            catch (Exception e) { }
#pragma warning restore CS0168 // Переменная объявлена, но не используется
        }

        private void LoadTrialLists()
        {
            TrialsJson = File.ReadAllText("../../Trials/Trials.json");
            MKJson = File.ReadAllText("../../Trials/MKChallenges.json");

            RigsJson = File.ReadAllText("../../Reagent/Rigs.json");
            ToolsJson = File.ReadAllText("../../Reagent/Tool.json");
            SkillsJson = File.ReadAllText("../../Reagent/Skill.json");
            MedicinesJson = File.ReadAllText("../../Reagent/Medicine.json");


            TrialsList = JsonConvert.DeserializeObject<List<TrialInfo>>(TrialsJson);
            MKList = JsonConvert.DeserializeObject<List<TrialInfo>>(MKJson);

            DifficultyList.AddRange((Difficulty[])Enum.GetValues(typeof(Difficulty)));

            RigsList = JsonConvert.DeserializeObject<List<string>>(RigsJson);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            List<TrialInfo> trials = new List<TrialInfo>();

            Random rnd = new Random();

            if (TrialTypeComboBox.SelectedIndex == 0 || TrialTypeComboBox.SelectedIndex == 2) trials.AddRange(TrialsList);

            if (TrialTypeComboBox.SelectedIndex == 1 || TrialTypeComboBox.SelectedIndex == 2) trials.AddRange(MKList);

            int trial = rnd.Next(trials.Count);

            TrialInfo currentTrial = trials[trial];

            DateTime date = DateTime.Now.AddYears(1959 - DateTime.Now.Year);

            var difficulty = Enum.GetValues(typeof(Difficulty));

            string rig_json = File.ReadAllText("../../Reagent/Rigs.json");
            string[] rigs = JsonConvert.DeserializeObject<string[]>(rig_json);

            string tool_json = File.ReadAllText("../../Reagent/Tool.json");
            string[] tools = JsonConvert.DeserializeObject<string[]>(tool_json);

            string skill_json = File.ReadAllText("../../Reagent/Skill.json");
            string[] skills = JsonConvert.DeserializeObject<string[]>(skill_json);

            string medicine_json = File.ReadAllText("../../Reagent/Medicine.json");
            string[] medicines = JsonConvert.DeserializeObject<string[]>(medicine_json);

            Document document = new Document();
            document.LoadFromFile("../../Document/doc.docx");

            Spire.Doc.Section lastSection = document.Sections[document.Sections.Count - 1];

            Dictionary<string, string> rDict = new Dictionary<string, string>();

            rDict.Add("#time#", date.ToString("yyyy-MM-dd HH:mm:ss"));
            rDict.Add("#type#", currentTrial.Type);
            rDict.Add("#location#", currentTrial.Location);
            rDict.Add("#mission#", currentTrial.Story);
            rDict.Add("#difficulty#", difficulty.GetValue(rnd.Next(difficulty.Length)).ToString());

            foreach(KeyValuePair<string, string> kvp in rDict)
            {
                document.Replace(kvp.Key, kvp.Value,true,true);
            }

            ParagraphStyle style = new ParagraphStyle(document);
            style.Name = "paraStyle";
            style.CharacterFormat.FontName = "Courier New";
            style.CharacterFormat.FontSize = 14f;
            document.Styles.Add(style);

            ParagraphStyle proj_style = new ParagraphStyle(document);
            proj_style.Name = "projStyle";
            proj_style.CharacterFormat.FontName = "Courier New";
            proj_style.CharacterFormat.FontSize = 14f;
            proj_style.CharacterFormat.Bold = true;
            document.Styles.Add(proj_style);

            for (int i = 0; i < Convert.ToInt32(PlayersTextBox.Text); i++)
            {
                Paragraph reagent_para = lastSection.AddParagraph();
                reagent_para.AppendText($"\nOBJECT: REAGENT No. {i + 1}\nRIG: {rigs[rnd.Next(rigs.Length)]}\nTOOL: {tools[rnd.Next(tools.Length)]}\nSKILL: {skills[rnd.Next(skills.Length)]}\nMEDICINE: {medicines[rnd.Next(medicines.Length)]}");
                reagent_para.ApplyStyle("paraStyle");
            }

            Paragraph proj_para = lastSection.AddParagraph();
            proj_para.AppendText("\nProject Lathe Document.Strictly Confidential.");
            proj_para.ApplyStyle("projStyle");

            Paragraph end_para = lastSection.AddParagraph();
            end_para.AppendText($"\n\nCommence The Trial.\nDr. Easterman _______________\n{date.ToString("yyyy-MM-dd")}");
            end_para.ApplyStyle("paraStyle");

            string outPath = $@"{SavePathTextBox.Text}\Trial Document {date.ToString("yyyy-MM-dd HH-mm-ss")}.docx";

            document.SaveToFile(outPath, FileFormat.Docx);
            document.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> lines = new List<string>
            {
                $"{TrialTypeComboBox.SelectedIndex}",
                $"{PlayersTextBox.Text}",
                $"{SavePathTextBox.Text}"
            };

            File.WriteAllLines("data.txt", lines);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog
            {
                Description = "Выберите папку",
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderDialog.SelectedPath;
                SavePathTextBox.Text = selectedPath;
            }
        }
    }
}