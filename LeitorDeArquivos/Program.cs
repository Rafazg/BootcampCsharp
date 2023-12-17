

using System;
using System.IO;
try
{


string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}

}
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não econtrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Caminho da pasta não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exeção genérica. {ex.Message}");
}
