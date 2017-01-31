using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			ICarDealer herlevDealer = DealerProvider.GetDealer("Herlev");
			ICarDealer roskildeDealer = DealerProvider.GetDealer("Roskilde");

			AbstractCar vwCarHerlev = herlevDealer.GetVWCar();
			Console.WriteLine($"VW with name {nameof(vwCarHerlev)} costs {vwCarHerlev?.Price}");

			AbstractCar audiCarHerlev = herlevDealer.GetAudiCar();
			Console.WriteLine($"Audi with name {nameof(audiCarHerlev)} costs {audiCarHerlev?.Price}");

			AbstractCar vwCarRoskilde = roskildeDealer.GetVWCar();
			Console.WriteLine($"VW with name {nameof(vwCarRoskilde)} costs {vwCarRoskilde?.Price}");

			AbstractCar audiCarRoskilde = roskildeDealer.GetAudiCar();
			Console.WriteLine($"Audi with name {nameof(audiCarRoskilde)} costs {audiCarRoskilde?.Price}");

			Console.ReadLine();
		}

	}

	public abstract class AbstractCar
	{
		public decimal Price { get; set; }
	}

	public class RoskildeVW : AbstractCar
	{
		public RoskildeVW()
		{
			Price = 300;
		}
	}

	public class HerlevVW : AbstractCar
	{
		public HerlevVW()
		{
			Price = 310;
		}
	}

	public class RoskildeAudi : AbstractCar
	{
		public RoskildeAudi()
		{
			Price = 400;
		}
	}

	public class HerlevAudi : AbstractCar
	{
		public HerlevAudi()
		{
			Price = 410;
		}
	}

	public abstract class AbstractTire
	{
		public string Size { get; set; }
	}


	public interface ICarDealer
	{
		AbstractCar GetVWCar();
		AbstractCar GetAudiCar();
	}

	public class RoskildeCarDealer : ICarDealer
	{
		public AbstractCar GetVWCar()
		{
			return new RoskildeVW();
		}

		public AbstractCar GetAudiCar()
		{
			return new RoskildeAudi();
		}
	}

	public class HerlevCarDealer : ICarDealer
	{
		public AbstractCar GetVWCar()
		{
			return new HerlevVW();
		}

		public AbstractCar GetAudiCar()
		{
			return new HerlevAudi();
		}
	}

	public class DealerProvider
	{
		public static ICarDealer GetDealer(string region)
		{
			switch(region)
			{
				case "Herlev":
					{
						return new HerlevCarDealer();
					}
				case "Roskilde":
					{
						return new RoskildeCarDealer();
					}
				default:
					return null;
			}
		}
	}
}
