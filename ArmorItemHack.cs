﻿using Loot.Modifiers;
using Terraria;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Loot
{
	public class ArmorItemHack : GlobalItem
	{
		// Forces an accessory tinker
		public override int ChoosePrefix(Item item, UnifiedRandom rand)
		{
			var info = EMMItem.GetItemInfo(item);
			if (info.JustTinkerModified)
				item.accessory = true;
			return -1;
		}

		// Reset accessory state after reforge
		public override void PostReforge(Item item)
		{
			var info = EMMItem.GetItemInfo(item);
			if (info.JustTinkerModified)
				item.accessory = false;
		}
	}
}
