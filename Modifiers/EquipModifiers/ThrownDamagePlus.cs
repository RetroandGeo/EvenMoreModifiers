﻿using Loot.System;
using Microsoft.Xna.Framework;
using Terraria;

namespace Loot.Modifiers.EquipModifiers
{
	public class ThrownDamagePlus : EquipModifier
	{
		public override ModifierTooltipLine[] Description => new[]
		{
			new ModifierTooltipLine { Text = $"+{Properties.RoundedPower}% thrown damage", Color =  Color.LimeGreen},
		};

		public override ModifierProperties GetModifierProperties(Item item)
		{
			return base.GetModifierProperties(item).Set(maxMagnitude: 8f);
		}

		public override void UpdateEquip(Item item, Player player)
		{
			player.thrownDamage += Properties.RoundedPower / 100;
		}
	}
}