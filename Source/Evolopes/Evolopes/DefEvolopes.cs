using RimWorld;
using Verse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolopes
{
    public class EvolopesDefOf : DefOf
    {
        public static PawnKindDef Boomalope;
        public static PawnKindDef EvoChocolope;
        public static PawnKindDef EvoDevilope;
        public static PawnKindDef EvoJellope;
        public static PawnKindDef EvoMilkalope;
        public static PawnKindDef EvoNeutroalope;
        public static PawnKindDef EvoMegaBoomalope;
        public static PawnKindDef EvoMegaLuciferope;
        public static ThingDef EmptyMechSerum;
        public static ThingDef BoomMechSerum;
        public static ThingDef ChocoMechSerum;
        public static ThingDef DevilMechSerum;
        public static ThingDef JellyMechSerum;
        public static ThingDef MilkMechSerum;
        public static ThingDef NeutroMechSerum;
        public static ThingDef LuciMechSerum;
        public static JobDef Inject;
        static EvolopesDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(EvolopesDefOf));
        }
    }
}