using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class HashrateAndBalance : Data
	{
		private int _hashrate { get; set; }
		private double _balance { get; set; }

		[JsonProperty("hashrate")]
		public int Hashrate
		{
			get
			{
				return _hashrate;
			}

			set
			{
				if (_hashrate == value) return;

				_hashrate = value;
				OnPropertyChanged(nameof(Hashrate));
			}
		}

		[JsonProperty("balance")]
		public double Balance
		{
			get
			{
				return _balance;
			}

			set
			{
				if (_balance == value) return;

				_balance = value;
				OnPropertyChanged(nameof(Balance));
			}
		}
	}
}