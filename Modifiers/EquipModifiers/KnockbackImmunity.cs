﻿using Loot.Core;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace Loot.Modifiers.EquipModifiers
{
	public class KnockbackImmunity : EquipModifier
	{
		public override ModifierTooltipLine[] TooltipLines => new[]
		{
			new ModifierTooltipLine {Text = $"Knockback immunity", Color = Color.LimeGreen},
		};

		public override ModifierProperties GetModifierProperties(Item item)
		{
			return base.GetModifierProperties(item).Set(rollChance: .333f, rarityLevel: 3f, uniqueRoll: true);
		}

		public override bool CanRoll(ModifierContext ctx)
		{
			// Don't roll on items that already provide knockback immunity
			switch (ctx.Item.type)
			{
				case (ItemID.CobaltShield):
				case (ItemID.ObsidianShield):
				case (ItemID.AnkhShield):
					return false;
			}

			return base.CanRoll(ctx);
		}

		public override void UpdateEquip(Item item, Player player)
		{
			player.noKnockback = true;
		}

	}
}
