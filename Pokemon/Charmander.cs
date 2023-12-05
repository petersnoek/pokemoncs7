using System;
namespace Pokemon
{
	public class Charmander
	{
		public string name;
        public string strength;
        public string weakness;

        public Charmander()
		{
            // A charmander has a name, fire as its strength, and water as its weakness.
            this.name = "Charmander 1";
			this.strength = "Fire";
			this.weakness = "Water";
		}

		public void BattleCry()
		{
			Console.WriteLine($"Battlecry: {this.name.ToUpper()} !!!!!");
		}
	}
}

