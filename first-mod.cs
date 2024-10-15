using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MyMod
{
    public class MyMod : Mod
    {
        public override void Load()
        {
            // Create a new item
            Mod.AddItem("Amazing Strong Sword"), new ModItem());
        }
    }

    // Item definition
    public class MyAwesomeSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amazing Strong Sword"); // Set the item's name
            Tooltip.SetDefault("A very powerful sword"); // Add tooltip text
        }

        public override void SetDefaults()
        {
            // Basic item settings
            item.damage = 50; // Set damage
            item.useTime = 10; // Set swing speed
            item.width = 40; // Set item width
            item.height = 40; // Set item height
            item.useStyle = ItemUseStyleID.Swing; // Set swing animation
            item.knockBack = 6; // Set knockback strength
            item.value = Item.buyPrice(gold: 10); // Set item value (in gold)
            item.rare = ItemRarityID.Blue; // Set item rarity (Blue)
        }
    }
}
