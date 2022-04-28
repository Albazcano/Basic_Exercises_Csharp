using System;

public class Puerta
{
	//Atributos
	public int Ancho { get; set; }
	public int Alto { get; set; }
	public string Color { get; set; }
	public bool estaAbierta { get; set; }
	public bool estaCerrada { get; set; }


	//Métodos
	//Default
	public Puerta(int Ancho, int Alto, string Color)
	{
		this.Ancho = Ancho;
		this.Alto = Alto;
		this.Color = Color;
		this.estaAbierta = true;
		this.estaCerrada = false;
	}

	//Dando valores
	public Puerta()
	{
		this.Ancho = 104;
		this.Alto = 215;
		this.Color = "Roble";
		this.estaAbierta = true;
	}

	public void abierta()
	{
		if (!this.estaAbierta)
		{
			Console.WriteLine("La puerta está abierta");
			this.estaAbierta = true;
			Console.WriteLine(this.Ancho + " " + this.Alto + " " + this.Color);
		}
		else
		{
			Console.WriteLine("Ya está abierta");
		}
	}

	public void cerrada()
	{
		if (!this.estaCerrada)
		{
			Console.WriteLine("La puerta está cerrada");
			this.estaCerrada = true;
			Console.WriteLine(this.Ancho + " " + this.Alto + " " + this.Color);
		}
		else
		{
			Console.WriteLine("Ya está cerrada");
		}
	}
}

public class Program
{

	public static void Main()
	{
		Puerta puerta1 = new Puerta(123, 209, "Castaño");
		Puerta puerta2 = new Puerta();

		puerta1.abierta();
		puerta2.cerrada();
		puerta2.abierta();
		Console.WriteLine(puerta1.Ancho + " " + puerta1.Alto + " " + puerta1.Color + " ");
		Console.WriteLine(puerta2.Ancho + " " + puerta2.Alto + " " + puerta2.Color + " ");
	}
}