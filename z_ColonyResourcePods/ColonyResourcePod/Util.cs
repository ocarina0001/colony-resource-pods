using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;
using UnityEngine;
using Verse.AI.Group;
using Verse.Sound;

namespace ColonyResourcePod
{
    internal class Util
    {
		// https://github.com/UdderlyEvelyn/SoilRelocation/blob/master/1.3/Source/SoilRelocation/Utilities.cs
		public static void DropThing(Map map, IntVec3 cell, ThingDef thingDef, int count, ThingPlaceMode tpm = ThingPlaceMode.Near)
		{
			Thing thing = ThingMaker.MakeThing(thingDef);
			thing.stackCount = count;
			GenPlace.TryPlaceThing(thing, cell, map, tpm);
		}
	}
}
