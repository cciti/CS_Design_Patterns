using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			ICarDealer dealer = new RoskildeCarDealer();

			AbstractCar vwCar = dealer.GetCar("VW");
			Console.WriteLine($"vwCar with name {nameof(vwCar)} costs {vwCar?.Price}");

			vwCar = dealer.GetCar("Audi");
			Console.WriteLine($"vwCar with name {nameof(vwCar)} costs {vwCar?.Price}");

			vwCar = dealer.GetCar("Mercedes");
			Console.WriteLine($"vwCar with name {nameof(vwCar)} costs {vwCar?.Price}");

			Console.ReadLine();
		}

	}

	public abstract class AbstractCar
	{
		public decimal Price { get; set; }
	}

	public class VW:AbstractCar
	{
		public VW()
		{
			Price = 300;
		}
	}

	public class Audi:AbstractCar
	{
		public Audi()
		{
			Price = 450;
		}
	}

	public interface ICarDealer
	{
		AbstractCar GetCar(string name);
	}

	public class RoskildeCarDealer : ICarDealer
	{
		public AbstractCar GetCar(string name)
		{
			if (name == "VW")
				return new VW();
			else if (name == "Audi")
				return new Audi();

			return null;
		}
	}
}
