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
        public static ThingDef EmptyMechSerum;
        public static ThingDef BoomMechSerum;
        public static ThingDef ChocoMechSerum;
        public static ThingDef DevilMechSerum;
        public static ThingDef JellyMechSerum;
        public static ThingDef MilkMechSerum;
        public static ThingDef NeutroMechSerum;
        static EvolopesDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(EvolopesDefOf));
        }
    }
}
