using Notes.Properties;
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
using System.Xml.Linq;

namespace Notes
{
    public partial class MainForm : Form
    {
        private List<Note> notes;
        private Note selectedNote;

        /// <summary>
        /// Инициализирует главную форму и настраивает ComboBox с категориями
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            noteCategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
        }

        /// <summary>
        /// Выгружает заметки при запуске приложения
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            notes = DataService.Load();
            RefreshNoteList();
        }

        /// <summary>
        /// Сохраняет заметки при закрытии приложения
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataService.Save(notes);
        }

        /// <summary>
        /// Обновляет отображение выбранной заметки при изменении выбора в списке
        /// </summary>
        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            noteTitleTextBox.BackColor = SystemColors.Window;

            if (notesListBox.SelectedItem is Note note)
            {
                selectedNote = note;
                noteTitleTextBox.Text = note.Title;
                noteTextTextBox.Text = note.Text;
                noteCreateTimeTextBox.Text = note.CreatedAt.ToString();
                noteCategoryComboBox.SelectedItem = note.Category;
            }
        }

        /// <summary>
        /// Создает новую заметку с параметрами по умолчанию
        /// </summary>
        private void noteAddButton_Click(object sender, EventArgs e)
        {
            noteTitleTextBox.BackColor = SystemColors.Window;

            selectedNote = new Note
            {
                Title = "Новая заметка",
                Text = "",
                Category = NoteCategory.Дом,
                LastEdited = DateTime.Now
            };

            notes.Add(selectedNote);

            RefreshNoteList();
            notesListBox.SelectedItem = selectedNote;

            noteTitleTextBox.Text = selectedNote.Title;
            noteTextTextBox.Text = selectedNote.Text;
            noteCategoryComboBox.SelectedItem = selectedNote.Category;
        }

        /// <summary>
        /// Удаляет выбранную заметку
        /// </summary>
        private void noteDeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedNote != null)
            {
                notes.Remove(selectedNote);
                selectedNote = null;
                RefreshNoteList();

                if (notes.Count == 0)
                {
                    noteTitleTextBox.Text = "";
                    noteTextTextBox.Text = "";
                    noteCategoryComboBox.SelectedIndex = -1;
                    noteCreateTimeTextBox.Text = "";
                }
            }
        }

        /// <summary>
        /// Сохраняет изменения в текущей заметке или создает новую
        /// </summary>
        private void noteSaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            if (selectedNote == null)
            {
                selectedNote = new Note();
                notes.Add(selectedNote);
            }

            selectedNote.Title = noteTitleTextBox.Text;
            selectedNote.Text = noteTextTextBox.Text;
            selectedNote.Category = (NoteCategory)noteCategoryComboBox.SelectedItem;
            selectedNote.LastEdited = DateTime.Now;

            RefreshNoteList();
            notesListBox.SelectedItem = selectedNote;
        }

        /// <summary>
        /// Обновляет список заметок, сортируя по дате последнего изменения
        /// </summary>
        private void RefreshNoteList()
        {
            notes = notes.OrderByDescending(n => n.LastEdited).ToList();
            notesListBox.DataSource = null;
            notesListBox.DataSource = notes;
            notesListBox.DisplayMember = "Title";
        }

        /// <summary>
        /// Проверяет корректность введенных данных
        /// </summary>
        /// <returns>True если данные валидны, иначе False</returns>
        private bool ValidateFields()
        {
            try
            {
                Validator.AssertNotEmpty(noteTitleTextBox.Text, nameof(noteTitleTextBox.Text));
                Validator.AssertMaxLength(noteTitleTextBox.Text, 100, nameof(noteTitleTextBox.Text));
                noteTitleTextBox.BackColor = SystemColors.Window;
            }

            catch
            {
                noteTitleTextBox.BackColor = System.Drawing.Color.FromArgb(255, 255, 127, 127);
                return false;
            }

            return true;
        }
    }
}