using Heroes.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Models.Heroes
{
    public abstract class Hero : IHero
    {
        private string name;
        private int health;
        private int armor;
        private bool isAlive;
        private IWeapon weapon;

        public Hero(string name, int health, int armour)
        {
            Name = name;
            Health = health;
            Armour = armour;
            isAlive = true;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hero name cannot be null or empty.");
                }
                name = value;
            }
        }

        public int Health
        {
            get { return health; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero health cannot be below 0.");
                }
                health = value;
            }
        }

        public int Armour
        {
            get { return armor; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero armour cannot be below 0.");
                }
                armor = value;
            }
        }

        public IWeapon Weapon
        {
            get
            {
                if (weapon == null)
                {
                    throw new ArgumentException("Weapon cannot be null.");
                }

                return weapon;
            }
        }

        public bool IsAlive
        {
            get => this.isAlive;
            private set
            {
                if (this.health <= 0)
                {
                    value = false;
                }
                else
                {
                    value = true;
                }
            }
        }



        public void AddWeapon(IWeapon weapon)
        {
            if (this.weapon != null)
            {
                this.weapon = weapon;
            }
            
        }

        public void TakeDamage(int points)
        {
            this.Armour -= points;

            if (this.Armour <= 0)
            {
                this.Armour = 0;

                this.Health -= points;

                if (this.Health <= 0)
                {
                    this.Health = 0;
                    this.IsAlive = false;
                }
            }

        }
    }
}
