using System;

public class Socio
{
	//Atributos
	public string Nombre { get; set; }
	public string Apellido { get; set; }
	public string Ciudad { get; set; }
	public int AñoAlta { get; set; }
	public int Antigüedad { get; set; }

	//Métodos

	//Default 
	public Socio()
	{
		this.Nombre = "Alba";
		this.Apellido = "Azcano";
		this.Ciudad = "Gijón";
		this.AñoAlta = 1992;
	}

	//Dando valores
	public Socio(string Nombre, string Apellido, string Ciudad, int AñoAlta)
	{
		this.Nombre = Nombre;
		this.Apellido = Apellido;
		this.Ciudad = Ciudad;
		this.AñoAlta = AñoAlta;
	}

}

public class Club
{
	//Atributos
	public Socio Socio1;
	public Socio Socio2;
	public Socio Socio3;

	//Métodos
	//Default
	public Club()
	{
		this.Socio1 = new Socio();
		this.Socio2 = new Socio("Pepito", "Fernández", "Oviedo", 1986);
		this.Socio3 = new Socio("Juanito", "Gonzalez", "Avilés", 2010);
	}

	public void Antigüedad()
	{
		if (this.Socio1.AñoAlta < this.Socio2.AñoAlta && this.Socio1.AñoAlta < this.Socio3.AñoAlta)
		{
			Console.WriteLine("El socio 1 es el más antiguo");
		}
		else if (this.Socio2.AñoAlta < this.Socio1.AñoAlta && this.Socio2.AñoAlta < this.Socio3.AñoAlta)
		{
			Console.WriteLine("El socio {0} {1}  es el más antiguo, su antigüedad es {2} años", this.Socio2.Nombre, this.Socio2.Apellido, 2022 - this.Socio2.AñoAlta);
		}
		else if (this.Socio3.AñoAlta < this.Socio1.AñoAlta && this.Socio3.AñoAlta < this.Socio2.AñoAlta)
		{
			Console.WriteLine("El socio 3 es el más antiguo");
		}
	}

	public override string ToString()
	{
		return "Socio1: " + this.Socio1.Nombre + " , " + this.Socio1.Apellido + " , " + this.Socio1.AñoAlta + " \n" +
			"Socio2: " + this.Socio2.Nombre + " , " + this.Socio2.Apellido + " , " + this.Socio2.AñoAlta + " \n" +
			"Socio3: " + this.Socio3.Nombre + " , " + this.Socio3.Apellido + " , " + this.Socio3.AñoAlta + " \n";
	}
}
public class Program
{
	public static void Main(string Nombre, string Apellido, string Ciudad, int AñoAlta)
	{
		Socio socio1 = new Socio();
		Socio socio2 = new Socio("bbbbbb", "ddd", "Oviedo", 1986);
		Socio socio3 = new Socio("aaaaa", "ccccc", "Avilés", 2010);

		Console.WriteLine(socio1.Nombre + " " + socio1.Apellido + " " + socio1.Ciudad + " " + socio1.AñoAlta);
		Console.WriteLine(socio2.Nombre + " " + socio2.Apellido + " " + socio2.Ciudad + " " + socio2.AñoAlta);
		Console.WriteLine(socio3.Nombre + " " + socio3.Apellido + " " + socio3.Ciudad + " " + socio3.AñoAlta);

		Club club1 = new Club();
		Console.WriteLine(club1.Socio2.Nombre + " " + club1.Socio2.Apellido + " " + club1.Socio2.Ciudad + " " + club1.Socio2.AñoAlta);
		Console.WriteLine(club1.Socio3.Nombre + " " + club1.Socio3.Apellido + " " + club1.Socio3.Ciudad + " " + club1.Socio3.AñoAlta);
		Console.WriteLine();
		Console.WriteLine(club1.ToString());
		club1.Antigüedad();

	}
}