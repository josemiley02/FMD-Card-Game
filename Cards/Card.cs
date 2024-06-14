using System.Diagnostics.CodeAnalysis;

namespace FMD
{
    public struct Card
    {
        public Card(string name, int atk, int cost, int energy, int ID, params Effect[] effect)
        {
            this.ID = ID;
            Name = name;
            ATK = atk;
            OriginalATK = atk;
            Cost = cost;
            Energy = energy;
            OriginalEnergy = energy;
            EffectCard = effect;
        }
        public int ID { get; private set; }
        public string Name { get; private set;}
        public int ATK { get; set;}
        private int OriginalATK;
        public int Cost { get; set;}
        public int Energy {get; set;}
        private int OriginalEnergy;
        public Effect[] EffectCard { get; set; }

        public void SetOrigin()
        {
            ATK = OriginalATK;
            Energy = OriginalEnergy;
        }
        public override string ToString()
        {
            return Name;
        }
        public bool Equals(Card other)
        {
            return ID == other.ID;
        }
    }
}