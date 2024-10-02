using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeteoriteSpawnerMod.Items
{ 
	public class CosmicRadio : ModItem
	{
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 40;
            Item.rare = 2;
            Item.useAnimation = 10;
            Item.useTime = 10;
            Item.value = 50000;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.autoReuse = false;
        }

        public override bool CanUseItem(Player player)
		{
			return true;
		}

		public override bool? UseItem(Player player)
		{
            SoundEngine.PlaySound(new SoundStyle("MeteoriteSpawnerMod/Sounds/CosmicRadio"), player.position);
			WorldGen.dropMeteor();
			return base.ConsumeItem(player);
		}
	}
}