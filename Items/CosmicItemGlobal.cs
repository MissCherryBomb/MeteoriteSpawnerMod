using MeteoriteSpawnerMod.Items;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeteoriteSpawnerMod.Items
{
    public partial class CosmicItemGlobal : GlobalItem
    {
        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            switch (item.type)
            {
                case ItemID.BrainOfCthulhuBossBag:
					{
						itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CosmicRadio>(), 4));
					}
					break;

                case ItemID.EaterOfWorldsBossBag:
					{
						itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CosmicRadio>(), 4));
					}
					break;
            }
        }
    }
}