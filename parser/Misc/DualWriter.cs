using System;
using System.IO;
using System.Text;

public class DualWriter : TextWriter
{
    private readonly TextWriter _consoleWriter;
    private readonly TextWriter _fileWriter;

    public DualWriter(string filePath)
    {
        _consoleWriter = Console.Out;
        _fileWriter = new StreamWriter(filePath, append: false) { AutoFlush = true };
    }

    public override void WriteLine(string? value)
    {
        _consoleWriter.WriteLine(value); // Вывод в консоль
        _fileWriter.WriteLine(value);   // Запись в файл
    }

    public override Encoding Encoding => Encoding.UTF8;

    public override void Flush()
    {
        _consoleWriter.Flush();
        _fileWriter.Flush();
        base.Flush();
    }

    protected override void Dispose(bool disposing)
    {
        _fileWriter.Dispose();
        base.Dispose(disposing);
    }
}
