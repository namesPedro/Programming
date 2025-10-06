using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Класс для загрузки и сохранения данных о заметках.
/// </summary>
public static class DataService
{
    /// <summary>
    /// Путь к файлу, в котором сохраняются данные.
    /// </summary>
    private static readonly string filePath = "notes.json";

    /// <summary>
    /// Сохраняет список заметок в файл.
    /// </summary>
    /// <param name="notes">Список заметок для сохранения.</param>
    public static void Save(List<Note> notes)
    {
        var json = JsonConvert.SerializeObject(notes, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    /// <summary>
    /// Загружает список заметок из файла.
    /// </summary>
    /// <returns>Список заметок. Если файл отсутствует или пустой — возвращает пустой список.</returns>
    public static List<Note> Load()
    {
        if (!File.Exists(filePath))
            return new List<Note>();

        var json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<Note>>(json) ?? new List<Note>();
    }
}