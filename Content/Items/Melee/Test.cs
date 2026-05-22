using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Oneiric.Content.Items.Melee
{
    public class Test : ModItem
    {
        public override string Texture => OPTConstant.Item_Melee + "Test";
        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.crit = 100;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = Item.buyPrice(platinum: 999);
            Item.rare = ItemRarityID.Master;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.mana = 10; 
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.StoneBlock, 999);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
