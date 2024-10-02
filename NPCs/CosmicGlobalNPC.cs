using MeteoriteSpawnerMod.Items;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace MeteoriteSpawnerMod.NPCs
{
	public class CosmicGlobalNPC : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            Conditions.NotExpert notExpert = new Conditions.NotExpert();

			if (npc.type == NPCID.BrainofCthulhu)
            {
				npcLoot.Add(ItemDropRule.ByCondition(notExpert, ModContent.ItemType<CosmicRadio>(), 4));
			}

            if (System.Array.IndexOf(new int[] { NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail }, npc.type) > -1)
            {
                LeadingConditionRule leadingConditionRule = new(new Conditions.LegacyHack_IsABoss());
                leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(notExpert, ModContent.ItemType<CosmicRadio>(), 4));
                npcLoot.Add(leadingConditionRule);
            }
		}
    }
}