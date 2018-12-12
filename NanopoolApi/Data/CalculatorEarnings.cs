using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class CalculatorEarnings : Data
	{
		private double _coins { get; set; }
		private double _dollars { get; set; }
		private double _yuan { get; set; }
		private double _euros { get; set; }
		private double _rubles { get; set; }
		private double _bitcoins { get; set; }

		[JsonProperty("coins")]
		public double Coins
		{
			get
			{
				return _coins;
			}

			set
			{
				if (_coins == value) return;

				_coins = value;
				OnPropertyChanged(nameof(Coins));
			}
		}

		[JsonProperty("dollars")]
		public double Dollars
		{
			get
			{
				return _dollars;
			}

			set
			{
				if (_dollars == value) return;

				_dollars = value;
				OnPropertyChanged(nameof(Dollars));
			}
		}

		[JsonProperty("yuan")]
		public double Yuan
		{
			get
			{
				return _yuan;
			}

			set
			{
				if (_yuan == value) return;

				_yuan = value;
				OnPropertyChanged(nameof(Yuan));
			}
		}

		[JsonProperty("euros")]
		public double Euros
		{
			get
			{
				return _euros;
			}

			set
			{
				if (_euros == value) return;

				_euros = value;
				OnPropertyChanged(nameof(Euros));
			}
		}

		[JsonProperty("rubles")]
		public double Rubles
		{
			get
			{
				return _rubles;
			}

			set
			{
				if (_rubles == value) return;

				_rubles = value;
				OnPropertyChanged(nameof(Rubles));
			}
		}

		[JsonProperty("bitcoins")]
		public double Bitcoins
		{
			get
			{
				return _bitcoins;
			}

			set
			{
				if (_bitcoins == value) return;

				_bitcoins = value;
				OnPropertyChanged(nameof(Bitcoins));
			}
		}
	}
}