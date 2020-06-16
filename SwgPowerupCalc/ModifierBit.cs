namespace SwgPowerupCalc
{
	public struct ModifierBit
	{
		private readonly string name;

		private readonly int ratio;

		public string Name => name + " (" + ratio + ")";

		public int Ratio => ratio;

		public ModifierBit(string name, int ratio)
		{
			this.name = name;
			this.ratio = ratio;
		}
	}
}
