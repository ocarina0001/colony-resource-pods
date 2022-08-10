using RimWorld;
using Verse;

namespace ColonyResourcePod
{
    public class ColonyDropPodIncoming : Skyfaller
    {
		protected override void Impact()
		{
			for (int i = 0; i < 6; i++)
			{
				FleckMaker.ThrowDustPuff(base.Position.ToVector3Shifted() + Gen.RandomHorizontalVector(1f), base.Map, 1.2f);
			}
			FleckMaker.ThrowLightningGlow(base.Position.ToVector3Shifted(), base.Map, 2f);
			GenClamor.DoClamor(this, 15f, ClamorDefOf.Impact);
			base.Impact();
		}
	}
}
