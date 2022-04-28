using System;

public class Libro
{
	//Atributos
	public string Autor { get; set; }
	public string Titulo { get; set; }
	public string Ubicación { get; set; }

	//Métodos
	//Default
	public Libro()
	{
		this.Autor = "Don Winslow";
		this.Titulo = "El poder del Perro";
		this.Ubicación = "Pasillo 3";
	}

	//Dandole valores
	public Libro(string Autor, string Titulo, string Ubicación)
	{
		this.Autor = Autor;
		this.Titulo = Titulo;
		this.Ubicación = Ubicación;
	}
}

public class Program
{

	public static void Main()
	{
		Libro Libro1 = new Libro();
		Libro Libro2 = new Libro("Don Winslow", "La frontera", "Pasillo 5");
		Libro Libro3 = new Libro("Don Winslow", "El Cartel", "Pasillo 1");



		Console.WriteLine(Libro1.Autor + " " + Libro1.Titulo + " " + Libro1.Ubicación);
		Console.WriteLine(Libro2.Autor + " " + Libro2.Titulo + " " + Libro2.Ubicación);
		Console.WriteLine(Libro3.Autor + " " + Libro3.Titulo + " " + Libro3.Ubicación);

	}
}