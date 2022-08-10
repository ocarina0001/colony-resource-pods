using Verse;
using RimWorld;

namespace ColonyResourcePod
{
    public class ColonyResourcePod_Large : Building
    {
        public override void Destroy(DestroyMode mode = DestroyMode.Vanish)
        {
            Map map = Map;
            Util.DropThing(map, Position, ThingDefOf.MealSurvivalPack, 25);
            Util.DropThing(map, Position, ThingDefOf.ComponentIndustrial, 15);
            Util.DropThing(map, Position, ThingDefOf.MedicineIndustrial, 15);
            Util.DropThing(map, Position, ThingDefOf.Silver, 400);
            Util.DropThing(map, Position, ThingDefOf.Steel, 225);
            Util.DropThing(map, Position, ThingDefOf.WoodLog, 150);
            Util.DropThing(map, Position, ThingDefOf.Synthread, 75);
            base.Destroy();
        }
    }
    public class ColonyResourcePod_Small : Building
    {
        public override void Destroy(DestroyMode mode = DestroyMode.Vanish)
        {
            Map map = Map;
            Util.DropThing(map, Position, ThingDefOf.MealSurvivalPack, 5);
            Util.DropThing(map, Position, ThingDefOf.ComponentIndustrial, 5);
            Util.DropThing(map, Position, ThingDefOf.MedicineIndustrial, 5);
            Util.DropThing(map, Position, ThingDefOf.Silver, 100);
            Util.DropThing(map, Position, ThingDefOf.Steel, 75);
            Util.DropThing(map, Position, ThingDefOf.WoodLog, 75);
            base.Destroy();
        }
    }
}
