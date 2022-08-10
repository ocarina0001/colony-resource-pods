using Verse;
using RimWorld;

namespace ColonyResourcePod
{
	public class ColonyResourcePod_Colonist : Building
	{
		public override void Destroy(DestroyMode mode = DestroyMode.Vanish)
		{
			Map map = Map;
			Util.DropThing(map, Position, ThingDefOf.MealSurvivalPack, 10); ; // Without an overstack mod, the resources dropped are capped at its specific stack limit
			Util.DropThing(map, Position, ThingDefOf.MedicineIndustrial, 10);

			PawnKindDef colonist = PawnKindDefOf.Colonist;
			PawnGenerationRequest request = new PawnGenerationRequest(colonist, Faction.OfPlayer, PawnGenerationContext.PlayerStarter, -1, true, false, false, false, true, false, 20f, false, true, true, false, false, false, false);
			Pawn pawn = PawnGenerator.GeneratePawn(request);

			System.Random r = new System.Random();
			int rAge = r.Next(70000000, 140000000); // Age 19 through 38, roughly
			pawn.ageTracker.AgeBiologicalTicks = rAge;
			GenSpawn.Spawn(pawn, Position, Map);

			base.Destroy();
		}
	}
}
