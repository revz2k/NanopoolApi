using Newtonsoft.Json;

namespace NanopoolApi.Data
{
	public class AverageHashrate : Data
	{
		private double _h1 { get; set; }
		private double _h3 { get; set; }
		private double _h6 { get; set; }
		private double _h12 { get; set; }
		private double _h24 { get; set; }

		[JsonProperty("h1")]
		public double H1
		{
			get
			{
				return _h1;
			}

			set
			{
				if (_h1 == value) return;

				_h1 = value;
				OnPropertyChanged(nameof(H1));
			}
		}

		[JsonProperty("h3")]
		public double H3
		{
			get
			{
				return _h3;
			}

			set
			{
				if (_h3 == value) return;

				_h3 = value;
				OnPropertyChanged(nameof(H3));
			}
		}

		[JsonProperty("h6")]
		public double H6
		{
			get
			{
				return _h6;
			}

			set
			{
				if (_h6 == value) return;

				_h6 = value;
				OnPropertyChanged(nameof(H6));
			}
		}

		[JsonProperty("h12")]
		public double H12
		{
			get
			{
				return _h12;
			}

			set
			{
				if (_h12 == value) return;

				_h12 = value;
				OnPropertyChanged(nameof(H12));
			}
		}

		[JsonProperty("h24")]
		public double H24
		{
			get
			{
				return _h24;
			}

			set
			{
				if (_h24 == value) return;

				_h24 = value;
				OnPropertyChanged(nameof(H24));
			}
		}
	}
}