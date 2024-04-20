using RimWorld;
using Verse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace Evolopes
{

    public class Hediff_InjectSerumBoom : HediffWithComps
    {

        public override void Tick()
        {

            base.Tick();
            if (Severity < 0.99)
            {
                return;
            }
            IntVec3 position = pawn.Position;
            Map map = pawn.Map;
            Gender gender = pawn.gender;
            Faction ofPlayer = Find.FactionManager.OfPlayer;
            if (pawn.Map == null)
            {
                return;
            }

            if (pawn.kindDef == EvolopesDefOf.Boomalope || pawn.kindDef == EvolopesDefOf.EvoChocolope || pawn.kindDef == EvolopesDefOf.EvoDevilope || pawn.kindDef == EvolopesDefOf.EvoMilkalope || pawn.kindDef == EvolopesDefOf.EvoNeutroalope)
            {
                Pawn obj1 = PawnGenerator.GeneratePawn(EvolopesDefOf.Boomalope, ofPlayer);
                obj1.gender = gender;
                obj1.ageTracker = pawn.ageTracker;
                GenSpawn.Spawn(obj1, position, map);
            }
            {
                Thing obj2 = ThingMaker.MakeThing(EvolopesDefOf.EmptyMechSerum);
                GenSpawn.Spawn(obj2, position, map);
            }
            FilthMaker.TryMakeFilth(position, map, ThingDefOf.Filth_Fuel, new IntRange(2, 4).RandomInRange, FilthSourceFlags.None);
            pawn.Destroy();
        }
    }

    public class Hediff_InjectSerumChoco : HediffWithComps
    {
        public override void Tick()
        {
            base.Tick();
            if ((double)Severity < 0.99)
            {
                return;
            }
            IntVec3 position = pawn.Position;
            Map map = pawn.Map;
            Gender gender = pawn.gender;
            Faction ofPlayer = Find.FactionManager.OfPlayer;
            if (pawn.Map == null)
            {
                return;
            }

            if (pawn.kindDef == EvolopesDefOf.Boomalope || pawn.kindDef == EvolopesDefOf.EvoChocolope || pawn.kindDef == EvolopesDefOf.EvoDevilope || pawn.kindDef == EvolopesDefOf.EvoMilkalope || pawn.kindDef == EvolopesDefOf.EvoNeutroalope)
            {
                Pawn obj1 = PawnGenerator.GeneratePawn(EvolopesDefOf.EvoChocolope, ofPlayer);
                obj1.gender = gender;
                obj1.ageTracker = pawn.ageTracker;
                GenSpawn.Spawn(obj1, position, map);
            }
            {
                Thing obj2 = ThingMaker.MakeThing(EvolopesDefOf.EmptyMechSerum);
                GenSpawn.Spawn(obj2, position, map);
            }

            FilthMaker.TryMakeFilth(position, map, ThingDefOf.Filth_Slime, new IntRange(2, 4).RandomInRange, FilthSourceFlags.None);
            pawn.Destroy();
        }
    }

    public class Hediff_InjectSerumDevil : HediffWithComps
    {
        public override void Tick()
        {

            base.Tick();
            if ((double)Severity < 0.99)
            {
                return;
            }
            IntVec3 position = pawn.Position;
            Map map = pawn.Map;
            Gender gender = pawn.gender;
            Faction ofPlayer = Find.FactionManager.OfPlayer;
            if (pawn.Map == null)
            {
                return;
            }

            if (pawn.kindDef == EvolopesDefOf.Boomalope || pawn.kindDef == EvolopesDefOf.EvoChocolope || pawn.kindDef == EvolopesDefOf.EvoJellope || pawn.kindDef == EvolopesDefOf.EvoMilkalope || pawn.kindDef == EvolopesDefOf.EvoNeutroalope)
            {
                Pawn obj1 = PawnGenerator.GeneratePawn(EvolopesDefOf.EvoDevilope, ofPlayer);
                obj1.gender = gender;
                obj1.ageTracker = pawn.ageTracker;
                GenSpawn.Spawn(obj1, position, map);
            }
            {
                Thing obj2 = ThingMaker.MakeThing(EvolopesDefOf.EmptyMechSerum);
                GenSpawn.Spawn(obj2, position, map);
            }

            FilthMaker.TryMakeFilth(position, map, ThingDefOf.Filth_Slime, new IntRange(3, 6).RandomInRange, FilthSourceFlags.None);
            pawn.Destroy();
        }
    }

    public class Hediff_InjectSerumJelly : HediffWithComps
    {
        public override void Tick()
        {
            base.Tick();
            if ((double)Severity < 0.99)
            {
                return;
            }
            IntVec3 position = pawn.Position;
            Map map = pawn.Map;
            Gender gender = pawn.gender;
            Faction ofPlayer = Find.FactionManager.OfPlayer;
            if (pawn.Map == null)
            {
                return;
            }

            if (pawn.kindDef == EvolopesDefOf.Boomalope || pawn.kindDef == EvolopesDefOf.EvoChocolope || pawn.kindDef == EvolopesDefOf.EvoDevilope || pawn.kindDef == EvolopesDefOf.EvoMilkalope || pawn.kindDef == EvolopesDefOf.EvoNeutroalope)
            {
                Pawn obj1 = PawnGenerator.GeneratePawn(EvolopesDefOf.EvoDevilope, ofPlayer);
                obj1.gender = gender;
                obj1.ageTracker = pawn.ageTracker;
                GenSpawn.Spawn(obj1, position, map);
            }
            {
                Thing obj2 = ThingMaker.MakeThing(EvolopesDefOf.EmptyMechSerum);
                GenSpawn.Spawn(obj2, position, map);
            }

            FilthMaker.TryMakeFilth(position, map, ThingDefOf.Filth_BloodInsect, new IntRange(3, 6).RandomInRange, FilthSourceFlags.None);
            pawn.Destroy();
        }
    }

    public class Hediff_InjectSerumMilk : HediffWithComps
    {
        public override void Tick()
        {
            base.Tick();
            if ((double)Severity < 0.99)
            {
                return;
            }
            IntVec3 position = pawn.Position;
            Map map = pawn.Map;
            Gender gender = pawn.gender;
            Pawn_AgeTracker age = pawn.ageTracker;
            Faction ofPlayer = Find.FactionManager.OfPlayer;
            if (pawn.Map == null)
            {
                return;
            }

            if (pawn.kindDef == EvolopesDefOf.Boomalope || pawn.kindDef == EvolopesDefOf.EvoChocolope || pawn.kindDef == EvolopesDefOf.EvoDevilope || pawn.kindDef == EvolopesDefOf.EvoJellope || pawn.kindDef == EvolopesDefOf.EvoNeutroalope)
            {
                Pawn obj1 = PawnGenerator.GeneratePawn(EvolopesDefOf.EvoMilkalope, ofPlayer);
                obj1.gender = gender;
                obj1.ageTracker = age;
                GenSpawn.Spawn(obj1, position, map);
            }
            {
                Thing obj2 = ThingMaker.MakeThing(EvolopesDefOf.EmptyMechSerum);
                GenSpawn.Spawn(obj2, position, map);
            }
            FilthMaker.TryMakeFilth(position, map, ThingDefOf.Filth_Slime, new IntRange(3, 6).RandomInRange, FilthSourceFlags.None);
            pawn.Destroy();
        }
    }

    public class Hediff_InjectSerumNeutro : HediffWithComps
    {
        public override void Tick()
        {
            base.Tick();
            if ((double)Severity < 0.99)
            {
                return;
            }
            IntVec3 position = pawn.Position;
            Map map = pawn.Map;
            Gender gender = pawn.gender;
            Pawn_AgeTracker age = pawn.ageTracker;
            Faction ofPlayer = Find.FactionManager.OfPlayer;
            if (pawn.Map == null)
            {
                return;
            }

            if (pawn.kindDef == EvolopesDefOf.Boomalope || pawn.kindDef == EvolopesDefOf.EvoChocolope || pawn.kindDef == EvolopesDefOf.EvoDevilope || pawn.kindDef == EvolopesDefOf.EvoJellope || pawn.kindDef == EvolopesDefOf.EvoMilkalope)
            {
                Pawn obj1 = PawnGenerator.GeneratePawn(EvolopesDefOf.EvoNeutroalope, ofPlayer);
                obj1.gender = gender;
                obj1.ageTracker = age;
                GenSpawn.Spawn(obj1, position, map);
            }
            {
                Thing obj2 = ThingMaker.MakeThing(EvolopesDefOf.EmptyMechSerum);
                GenSpawn.Spawn(obj2, position, map);
            }
            FilthMaker.TryMakeFilth(position, map, ThingDefOf.Filth_Water, new IntRange(3, 6).RandomInRange, FilthSourceFlags.None);
            pawn.Destroy();
        }
    }
    public class Hediff_InjectSerumLuci : HediffWithComps
    {
        public override void Tick()
        {
            base.Tick();
            if ((double)Severity < 0.99)
            {
                return;
            }
            IntVec3 position = pawn.Position;
            Map map = pawn.Map;
            Gender gender = pawn.gender;
            Pawn_AgeTracker age = pawn.ageTracker;
            Faction ofPlayer = Find.FactionManager.OfPlayer;
            if (pawn.Map == null)
            {
                return;
            }

            if (pawn.kindDef == EvolopesDefOf.Boomalope || pawn.kindDef == EvolopesDefOf.EvoChocolope || pawn.kindDef == EvolopesDefOf.EvoDevilope || pawn.kindDef == EvolopesDefOf.EvoJellope || pawn.kindDef == EvolopesDefOf.EvoMilkalope || pawn.kindDef == EvolopesDefOf.EvoNeutroalope)
            {
                Pawn obj1 = PawnGenerator.GeneratePawn(EvolopesDefOf.EvoMegaLuciferope, ofPlayer);
                obj1.gender = gender;
                obj1.ageTracker = age;
                GenSpawn.Spawn(obj1, position, map);
            }
            {
                Thing obj2 = ThingMaker.MakeThing(EvolopesDefOf.EmptyMechSerum);
                GenSpawn.Spawn(obj2, position, map);
            }
            FilthMaker.TryMakeFilth(position, map, ThingDefOf.Filth_Water, new IntRange(3, 6).RandomInRange, FilthSourceFlags.None);
            pawn.Destroy();

        }
    }
}