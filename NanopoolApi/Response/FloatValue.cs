using Newtonsoft.Json;

namespace NanopoolApi.Response
{
	public class DoubleValue : Response
	{
		private double _data { get; set; }

		[JsonProperty("data")]
		public double Data
		{
			get
			{
				return _data;
			}

			set
			{
				if (_data == value) return;

				_data = value;
				OnPropertyChanged(nameof(Data));
			}
		}
	}
}