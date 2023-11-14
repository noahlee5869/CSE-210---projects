using System;
using System.Collections.Generic;
using System.IO;

class CsvFileHandler : Base
{
    private const string DefaultFilePath = "default/path/to/your/file.csv";

    public void SaveToCsv(List<string> data)
    {
        SaveToCsv(data, DefaultFilePath);
    }

    public void SaveToCsv(List<string> data, string filePath)
    {
        try
        {
            // Check if the file already exists and delete it
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            // Create a new CSV file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var line in data)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine($"Data has been successfully saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data to CSV: {ex.Message}");
        }
    }
}
