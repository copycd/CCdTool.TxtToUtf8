// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");


static void ConvertToUtf8(string inputFilePath, string outputFilePath) 
{ 
    // 파일을 읽을 때 사용할 인코딩 (예: 기본 인코딩)
    Encoding sourceEncoding = Encoding.Default; 
    // 원본 파일 내용을 읽기
    string content; 
    using (StreamReader reader = new StreamReader(inputFilePath, sourceEncoding)) { content = reader.ReadToEnd(); }
    // UTF-8 인코딩으로 파일을 쓰기
    using (StreamWriter writer = new StreamWriter(outputFilePath, false, Encoding.UTF8)) { writer.Write(content); } 
}

string targetDir = "D:\\gitHub\\Assimp";

var files = Directory.GetFiles(targetDir, "*.hpp", SearchOption.AllDirectories );
foreach (var file in files)
{
    ConvertToUtf8(file, file);
}


Console.WriteLine("성공!!");