using System;

using System;
using System.IO;

public class Video
{
    // Properties
    public string FilePath { get; set; }
    public string FileName => Path.GetFileName(FilePath);
    public long FileSize => new FileInfo(FilePath).Length;

    // Constructor
    public Video(string filePath)
    {
        if (File.Exists(filePath))
        {
            FilePath = filePath;
        }
        else
        {
            throw new FileNotFoundException("The specified video file does not exist.");
        }
    }

    // Methods
    public void Load()
    {
        // Logic to load the video file
        Console.WriteLine($"Loading video from {FilePath}");
    }

    public void Save(string destinationPath)
    {
        // Logic to save the video file
        File.Copy(FilePath, destinationPath);
        Console.WriteLine($"Video saved to {destinationPath}");
    }

    public void DisplayInfo()
    {
        // Display video information
        Console.WriteLine($"Video File: {FileName}");
        Console.WriteLine($"File Size: {FileSize} bytes");
    }

    // Additional methods for processing video can be added here
}