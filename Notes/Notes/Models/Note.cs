using System;

/// <summary>
/// Перечисление категорий заметок.
/// </summary>
public enum NoteCategory
{
    Дом,
    Работа,
    Спорт,
    Финансы
}

/// <summary>
/// Представляет одну заметку пользователя.
/// </summary>
public class Note
{
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; }
    public NoteCategory Category { get; set; }
    public DateTime LastEdited { get; set; }

    public Note()
    {
        CreatedAt = DateTime.Now;
        LastEdited = CreatedAt;
    }

    /// <summary>
    /// Создает новую заметку с заданными параметрами.
    /// </summary>
    /// <param name="title">Заголовок заметки (до 100 символов).</param>
    /// <param name="text">Текст заметки.</param>
    /// <param name="category">Категория заметки.</param>
    public Note(string title, string text, NoteCategory category)
    {
        Title = title;
        Text = text;
        Category = category;
        CreatedAt = DateTime.Now;
        LastEdited = DateTime.Now;
    }

    public override string ToString() => Title;
}