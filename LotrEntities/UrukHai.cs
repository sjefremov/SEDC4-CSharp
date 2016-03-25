using LotrEntities.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotrEntities.Armors;
using LotrEntities.Weapons;

namespace LotrEntities
{
    internal class UrukHai : IMortal, IWarrior
    {
        public int HealthPoints { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public IUrukHaiMaster Master { get; set; }

        public bool IsAlive
        {
            get
            {
                return HealthPoints > 0;
            }
        }

        public IArmor MainArmor { get; set; }

        public IArmor SideArmor { get; set; }

        public IWeapon Weapon { get; set; }

        public override string ToString()
        {
            return $"{Name} ({HealthPoints}) owned by {Master.Name}";
        }

        public void Attack(IWarrior target)
        {
            var r = new Random();
            List<IArmor> armors = new List<IArmor> { target.MainArmor, target.SideArmor };
            var armorType = BattleHelper.GetNeededArmorType(Weapon);

            var defense = armors
                .Where(a => a != null && a.Type == armorType)
                .Sum(a => a.Defense);

            var actualDamage = Weapon.Damage - defense;
            target.HealthPoints -= (int)(actualDamage * (0.8 + r.NextDouble() * 0.4));
        }
    }
}
