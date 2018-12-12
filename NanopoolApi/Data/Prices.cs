using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class Prices : Data
	{
		private double _btc { get; set; }
		private double _usd { get; set; }
		private double _eur { get; set; }
		private double _rur { get; set; }
		private double _cny { get; set; }

		[JsonProperty("price_btc")]
		public double Btc
		{
			get
			{
				return _btc;
			}

			set
			{
				if (_btc == value) return;

				_btc = value;
				OnPropertyChanged(nameof(Btc));
			}
		}

		[JsonProperty("price_usd")]
		public double Usd
		{
			get
			{
				return _usd;
			}

			set
			{
				if (_usd == value) return;

				_usd = value;
				OnPropertyChanged(nameof(Usd));
			}
		}

		[JsonProperty("price_eur")]
		public double Eur
		{
			get
			{
				return _eur;
			}

			set
			{
				if (_eur == value) return;

				_eur = value;
				OnPropertyChanged(nameof(Eur));
			}
		}

		[JsonProperty("price_rur")]
		public double Rur
		{
			get
			{
				return _rur;
			}

			set
			{
				if (_rur == value) return;

				_rur = value;
				OnPropertyChanged(nameof(Rur));
			}
		}

		[JsonProperty("price_cny")]
		public double Cny
		{
			get
			{
				return _cny;
			}

			set
			{
				if (_cny == value) return;

				_cny = value;
				OnPropertyChanged(nameof(Cny));
			}
		}
	}
}