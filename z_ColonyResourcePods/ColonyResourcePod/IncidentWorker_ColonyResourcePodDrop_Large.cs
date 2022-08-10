using RimWorld;
using UnityEngine;
using Verse;

namespace ColonyResourcePod
{
    public class IncidentWorker_ColonyResourcePodDrop_Large : IncidentWorker
    {
		protected override bool CanFireNowSub(IncidentParms parms)
		{
			if (!base.CanFireNowSub(parms))
				return false;
			Map map = (Map)parms.target;
			IntVec3 pos;
			return TryFindColonyResourcePodDropCell(map.Center, map, 999999, out pos);
		}

		protected override bool TryExecuteWorker(IncidentParms parms)
		{
			Map map = (Map)parms.target;
			if (!TryFindColonyResourcePodDropCell(map.Center, map, 999999, out var pos))
				return false;
			SpawnColonyResourcePods(pos, map, 1);
			SendStandardLetter("OKA_LetterLabelColonyResourcePod_Large".Translate(), "OKA_ColonyResourcePodDrop_Large".Translate(), LetterDefOf.PositiveEvent, parms, new TargetInfo(pos, map));
			return true;
		}

		private void SpawnColonyResourcePods(IntVec3 firstChunkPos, Map map, int count)
		{
			SpawnColonyResourcePod(firstChunkPos, map);
			for (int i = 0; i < count - 1; i++)
				if (TryFindColonyResourcePodDropCell(firstChunkPos, map, 5, out var pos))
					SpawnColonyResourcePod(pos, map);
		}

		private void SpawnColonyResourcePod(IntVec3 pos, Map map)
		{
			SkyfallerMaker.SpawnSkyfaller(ThingDefOf.OKA_ColonyResourcePod_LargeIncoming, ThingDefOf.OKA_ColonyResourcePod_Large, pos, map);
		}

		private bool TryFindColonyResourcePodDropCell(IntVec3 nearLoc, Map map, int maxDist, out IntVec3 pos)
		{
			return CellFinderLoose.TryFindSkyfallerCell(ThingDefOf.OKA_ColonyResourcePod_LargeIncoming, map, out pos, 10, nearLoc, maxDist);
		}
	}
}
