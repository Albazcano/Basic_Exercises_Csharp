using System;

public class Coche
{
	//Atributos
	public string Marca { get; set; }
	public string Modelo { get; set; }
	public string Color { get; set; }
	public int Cilindrada { get; set; }
	public bool estaArrancado { get; set; }
	public bool estaParado { get; set; }

	//Métodos

	//Default
	public Coche()
	{
		this.Marca = "Peugeot";
		this.Modelo = "407";
		this.Color = "Arena";
		this.Cilindrada = 250;
		this.estaArrancado = false;
		this.estaParado = false;
	}

	//Dandole valores
	public Coche(string Marca, string Modelo, string Color, int cilindrada)
	{
		this.Marca = Marca;
		this.Modelo = Modelo;
		this.Color = Color;
		this.Cilindrada = Cilindrada;
		this.estaArrancado = false;
		this.estaParado = false;
	}

	public void arrancar()
	{
		if (!this.estaArrancado)
		{
			Console.WriteLine("El coche ha arrancado");
			this.estaArrancado = true;
			Console.WriteLine(this.Marca + " " + this.Modelo + " " + this.Color + " " + this.Cilindrada);
		}
		else
		{
			Console.WriteLine("Ya está arrancado");
		}

	}

	public void parar()
	{
		if (!this.estaParado)
		{
			Console.WriteLine("El coche ha parado");
			this.estaParado = true;
			Console.WriteLine(this.Marca + " " + this.Modelo + " " + this.Color + " " + this.Cilindrada);
		}
		else
		{
			Console.WriteLine("Ya está parado");
		}
	}
}

public class Program
{

	public static void Main()
	{
		Coche coche1 = new Coche();
		Coche coche2 = new Coche("Peugeout", "206", "Azul", 250);
		Coche coche3 = new Coche("Renault", "Megane", "Verde", 200);
		Coche coche4 = new Coche("Clio", "Pepito", "Blanco", 200);
		Coche coche5 = new Coche("Wolkswagen", "Passat", "Rojo", 200);
		coche1.arrancar();
		coche1.parar();
		Console.WriteLine(coche1.Marca + " " + coche1.Modelo + " " + coche1.Color + " " + coche1.Cilindrada);
		Console.WriteLine(coche2.Marca + " " + coche2.Modelo + " " + coche2.Color + " " + coche2.Cilindrada);
		Console.WriteLine(coche3.Marca + " " + coche3.Modelo + " " + coche3.Color + " " + coche3.Cilindrada);
		Console.WriteLine(coche4.Marca + " " + coche4.Modelo + " " + coche4.Color + " " + coche4.Cilindrada);
		Console.WriteLine(coche5.Marca + " " + coche5.Modelo + " " + coche5.Color + " " + coche5.Cilindrada);


	}
}