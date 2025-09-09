using System.ComponentModel.DataAnnotations;
using System.IO;
namespace Ucu.Poo.GameOfLife;

//Esta clase solo se dedica a leer un archivo que le pasan. solo tiene una responsabilidad.
public class TextLecture
{
    


    // Para hacer este metodo tuvimos que usar string[] debido a la forma de los datos que vienen en los tipos de archivos "board.txt". Haciendo solo uso del tipo string nos devolvia errores y no devolvia de la misma forma los datos desde donde haciamos el split content en InitializateBoard.cs. con esta nueva implementacion, no tuvimos que usarlo ya que le especificamos los [], con esto no vamos a tener problemas con los saltos de linea del archivo.
    public static string[] ReadTxtFile(string file) // Aca la idea es que si el dia de mañana en vez de "board.txt" me pasan otro archivo llamado "board2.txt", lo unico que tendria que hacer es poner el nombre del archivo cuando se invoca a Text Lecture.
    {
        return File.ReadAllLines(file);
    }
}