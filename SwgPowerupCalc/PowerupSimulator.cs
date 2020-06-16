using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SwgPowerupCalc
{
	public class PowerupSimulator
	{
		public struct SimulationResult
		{
			public int power_min;
			public int power_max;
			public int power_avg;
			public int amount_min;
			public int amount_max;
			public int amount_avg;
			public int ratio;
		}

		private Random r;

        //All modifier bits in the game
		public static readonly IList<ModifierBit> modBits = new ReadOnlyCollection<ModifierBit>(new ModifierBit[145]
		{
			new ModifierBit("1-H Critical Chance", 10),
			new ModifierBit("1-Handed Melee Damage", 14),
			new ModifierBit("Advanced Assembly", 3),
			new ModifierBit("Advanced Component Experimentation", 4),
			new ModifierBit("Agility", 1),
			new ModifierBit("Armor Assembly", 3),
			new ModifierBit("Armor Experimentation", 4),
			new ModifierBit("Artisan Assembly", 3),
			new ModifierBit("Artisan Experimentation", 4),
			new ModifierBit("Assassinate Action Cost", 8),
			new ModifierBit("Assassinate Critical Chance", 8),
			new ModifierBit("Assassinate Damage", 8),
			new ModifierBit("Assassinate Freeshot Chance", 8),
			new ModifierBit("Assault Action Cost", 8),
			new ModifierBit("Assault Critical Chance", 8),
			new ModifierBit("Assault Damage", 8),
			new ModifierBit("Assault Freeshot Chance", 8),
			new ModifierBit("Beast Expertise Bonus", 7),
			new ModifierBit("Bleeding Absorption", 4),
			new ModifierBit("Bleeding Resistance", 4),
			new ModifierBit("Block Chance", 4),
			new ModifierBit("Block Value", 1),
			new ModifierBit("Booster Assembly", 3),
			new ModifierBit("Booster Experimentation", 4),
			new ModifierBit("Camouflage", 1),
			new ModifierBit("Carbine Action Cost", 10),
			new ModifierBit("Carbine Critical Chance", 10),
			new ModifierBit("Carbine Damage", 14),
			new ModifierBit("Chassis Assembly", 3),
			new ModifierBit("Chassis Experimentation", 4),
			new ModifierBit("Clothing Assembly", 3),
			new ModifierBit("Clothing Experimentation", 4),
			new ModifierBit("Combat Offense: Strikethrough Value", 4),
			new ModifierBit("Constitution", 1),
			new ModifierBit("Creature Critical Chance", 10),
			new ModifierBit("Critical Chance Increase", 15),
			new ModifierBit("Critical Hit Reduction", 4),
			new ModifierBit("Cybernetic Assembly", 3),
			new ModifierBit("Cybernetic Experimentation", 4),
			new ModifierBit("Dance Knowledge", 3),
			new ModifierBit("Dance Prop Assembly", 3),
			new ModifierBit("Dancing Enhancement", 3),
			new ModifierBit("Detect Camoflage", 3),
			new ModifierBit("Devastation", 15),
			new ModifierBit("Disease Absorption", 4),
			new ModifierBit("Disease Resistance", 4),
			new ModifierBit("Dodge Chance", 8),
			new ModifierBit("Dodge Reduction", 8),
			new ModifierBit("Droid Assembly", 3),
			new ModifierBit("Droid Critical Chance", 10),
			new ModifierBit("Droid Experimentation", 4),
			new ModifierBit("Droid Speed", 3),
			new ModifierBit("Elemental Penetration: Acid", 10),
			new ModifierBit("Elemental Penetration: Cold", 10),
			new ModifierBit("Elemental Penetration: Electricity", 10),
			new ModifierBit("Elemental Penetration: Heat", 10),
			new ModifierBit("Engine Assembly", 3),
			new ModifierBit("Engine Experimentation", 4),
			new ModifierBit("Evasion Chance", 3),
			new ModifierBit("Evasion Value", 4),
			new ModifierBit("Fast Draw Critical Chance", 8),
			new ModifierBit("Fast Draw Damage", 8),
			new ModifierBit("Fast Draw/Precision Strike Action Cost", 8),
			new ModifierBit("Fast Draw/Precision Strike Freeshot Chance", 8),
			new ModifierBit("Fervent Mutation", 10),
			new ModifierBit("Fire Absorption", 4),
			new ModifierBit("Fire Resistance", 4),
			new ModifierBit("Focused Enzyme Manipulation", 10),
			new ModifierBit("Focused Fire Action", 8),
			new ModifierBit("Focused Fire Critical Chance", 8),
			new ModifierBit("Focused Fire Damage", 8),
			new ModifierBit("Focused Fire Freeshot Chance", 8),
			new ModifierBit("Food Assembly", 3),
			new ModifierBit("Food Experimentation", 4),
			new ModifierBit("Glancing Blow Increase", 18),
			new ModifierBit("Glancing Blow Increase (Melee)", 14),
			new ModifierBit("Glancing Blow Increase (Ranged)", 14),
			new ModifierBit("Heal Action Cost Reduction", 10),
			new ModifierBit("Healing Potency", 8),
			new ModifierBit("Heavy Weapon Action Cost", 10),
			new ModifierBit("Heavy Weapon Critical Chance", 10),
			new ModifierBit("Heavy Weapon Damage", 14),
			new ModifierBit("Humanoid Critical Chance", 10),
			new ModifierBit("Incubation Time Reduction", 3),
			new ModifierBit("Instrument Assembly", 3),
			new ModifierBit("Jedi Strike Action Cost", 8),
			new ModifierBit("Jedi Strike Critical Chance", 8),
			new ModifierBit("Jedi Strike Freeshot Chance", 8),
			new ModifierBit("Lightsaber Assembly", 3),
			new ModifierBit("Lightsaber Experimentation", 5),
			new ModifierBit("Luck", 1),
			new ModifierBit("Music Knowledge", 3),
			new ModifierBit("Musical Enhancement", 3),
			new ModifierBit("One-Hand Lightsaber Damage", 14),
			new ModifierBit("One-Hand Melee Action Cost", 10),
			new ModifierBit("One-Handed Lightsaber Action Cost", 10),
			new ModifierBit("Parry Rating", 6),
			new ModifierBit("Parry Reduction", 6),
			new ModifierBit("Pistol Action Cost", 10),
			new ModifierBit("Pistol Critical Chance", 10),
			new ModifierBit("Pistol Damage", 14),
			new ModifierBit("Poison Absorption", 4),
			new ModifierBit("Poison Resistance", 4),
			new ModifierBit("Polearm Action Cost", 10),
			new ModifierBit("Polearm Critical Chance", 10),
			new ModifierBit("Polearm Damage", 14),
			new ModifierBit("Polearm Lightsaber Action Cost", 10),
			new ModifierBit("Polearm Lightsaber Damage", 14),
			new ModifierBit("Power Systems Assembly", 3),
			new ModifierBit("Power Systems Experimentation", 4),
			new ModifierBit("Precision", 1),
			new ModifierBit("PVP Critical Chance", 10),
			new ModifierBit("Reverse Engineering Chance", 10),
			new ModifierBit("Rifle Action Cost", 10),
			new ModifierBit("Rifle Critical Chance", 10),
			new ModifierBit("Rifle Damage", 14),
			new ModifierBit("Shield Experimentation", 4),
			new ModifierBit("Shields Assembly", 3),
			new ModifierBit("Stamina", 1),
			new ModifierBit("Strength", 1),
			new ModifierBit("Strike Damage", 8),
			new ModifierBit("Strikethrough Chance", 6),
			new ModifierBit("Structure Assembly", 3),
			new ModifierBit("Structure Experimentation", 4),
			new ModifierBit("Sure Shot Action Cost", 8),
			new ModifierBit("Sure Shot Critical Chance", 8),
			new ModifierBit("Sure Shot Damage", 8),
			new ModifierBit("Sure Shot Freeshot Chance", 8),
			new ModifierBit("Tracking Droids", 4),
			new ModifierBit("Two-Hand Lightsaber Action Cost", 10),
			new ModifierBit("Two-Hand Melee Action Cost", 10),
			new ModifierBit("Two-Handed Lightsaber Damage", 14),
			new ModifierBit("Two-Handed Melee Critical Chance", 10),
			new ModifierBit("Two-Handed Melee Damage", 14),
			new ModifierBit("Unarmed Action Cost", 10),
			new ModifierBit("Unarmed Critical Chance", 10),
			new ModifierBit("Unarmed Damage", 14),
			new ModifierBit("Vital Strike Action Cost", 8),
			new ModifierBit("Vital Strike Critical Chance", 8),
			new ModifierBit("Vital Strike Damage", 8),
			new ModifierBit("Vital Strike Freeshot Chance", 8),
			new ModifierBit("Weapon Assembly", 3),
			new ModifierBit("Weapon Experimentation", 4),
			new ModifierBit("Weapon Systems", 3),
			new ModifierBit("Weapon Systems Experimentation", 4)
		});

		public PowerupSimulator()
		{
			r = new Random();
		}

		private float rand(float min, float max)
		{
			return Convert.ToSingle(r.NextDouble()) * (max - min) + min;
		}

		private Tuple<int, int> createPowerup(int _ratio, float _tool, int _powerbit, float _rechance, float _quality)
		{
			float num = _rechance;
			int num2 = _powerbit;
			num += _tool;
			float min = 0.85f;
            float quality = _quality;

            min += 0.15f * (quality / 100.0f);

            num2 = (int)((num * rand(min, 1.25f) / 100f + rand(1f, 1.25f)) * (float)num2 / (float)_ratio);
			int item = (int)(num / 11.5f * (num * rand(0.85f, 1.25f) / 11.5f) + 20f);
			return Tuple.Create(num2, item);
		}

		public SimulationResult Simulate(int ratio, float tool, int powerbit, float rechance, float quality, long simcount)
		{
			int num = 0;
			int num2 = 99999;
			long num3 = 0L;
			int num4 = 0;
			int num5 = 99999;
			long num6 = 0L;
			SimulationResult result = default(SimulationResult);

			if (ratio <= 0)
			{
				throw new ArgumentException("Ratio cannot be zero.");
			}
			if (powerbit <= 0 || powerbit > 35)
			{
				throw new ArgumentException("Powerbit value must be between (1 - 35)");
			}
			if (rechance <= 0f)
			{
				throw new ArgumentException("Reverse engineering skillmod cannot be zero.");
			}
            if (quality < 0f)
            {
                throw new ArgumentException("RE Enchancement Module cannot be negative.");
            }
            for (long num7 = 0L; num7 < simcount; num7++)
			{
				Tuple<int, int> tuple = createPowerup(ratio, tool, powerbit, rechance, quality);
				int item = tuple.Item1;
				int item2 = tuple.Item2;
				if (item < num2)
				{
					num2 = item;
				}
				if (item > num)
				{
					num = item;
				}
				if (item2 > num4)
				{
					num4 = item2;
				}
				if (item2 < num5)
				{
					num5 = item2;
				}
				num3 += item;
				num6 += item2;
			}
			result.power_min = num2;
			result.power_max = num;
			result.amount_min = num5;
			result.amount_max = num4;
			if (simcount > 1)
			{
				result.power_avg = (int)(num3 / simcount);
				result.amount_avg = (int)(num6 / simcount);
			}
			else
			{
				result.power_avg = num;
				result.amount_avg = num4;
			}
			return result;
		}
	}
}
