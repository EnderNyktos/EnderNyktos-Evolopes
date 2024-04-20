using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse.AI;
using Verse;
using Verse.Sound;

namespace Evolopes
{
    public class CompTargetEffect_Evolope : CompTargetEffect
    {
        public override void DoEffectOn(Pawn user, Thing target)
        {
            if (user != null && target != null && user.CanReserveAndReach(target, PathEndMode.Touch, Danger.Deadly))
            {
                Job job = JobMaker.MakeJob(EvolopesDefOf.Inject, target, parent);
                job.count = 1;
                user.jobs.TryTakeOrderedJob(job, JobTag.Misc);
            }
        }
    }
}

namespace Evolopes

{
    internal class JobDriver_Biocode : JobDriver
    {
        private const TargetIndex WeaponIndex = TargetIndex.A;

        private const TargetIndex BiocoderIndex = TargetIndex.B;

        private const int DurationTicks = 600;

        private Thing Weapon => job.GetTarget(TargetIndex.A).Thing;

        private Thing Biocoder => job.GetTarget(TargetIndex.B).Thing;

        public override bool TryMakePreToilReservations(bool errorOnFailed)
        {
            return ReservationUtility.Reserve(pawn, (LocalTargetInfo)Weapon, job, 1, -1, (ReservationLayerDef)null, errorOnFailed) && ReservationUtility.Reserve(pawn, (LocalTargetInfo)Biocoder, job, 1, -1, (ReservationLayerDef)null, errorOnFailed);
        }

        protected override IEnumerable<Toil> MakeNewToils()
        {
            yield return Toils_Goto.GotoThing(TargetIndex.B, PathEndMode.Touch).FailOnDespawnedOrNull(TargetIndex.B).FailOnDespawnedOrNull(TargetIndex.A);
            yield return Toils_Haul.StartCarryThing(TargetIndex.B, false, false, false, true);
            yield return Toils_Goto.GotoThing(TargetIndex.A, PathEndMode.Touch).FailOnDespawnedOrNull(TargetIndex.A);
            Toil useWaitToil = Toils_General.Wait(600);
            useWaitToil.WithProgressBarToilDelay(TargetIndex.A);
            useWaitToil.FailOnDespawnedOrNull(TargetIndex.A);
            useWaitToil.FailOnCannotTouch(TargetIndex.A, PathEndMode.Touch);
            yield return useWaitToil;
            yield return Toils_General.Do(Biocode);
        }

        private void Biocode()
        {
            CompBiocodable compBiocodable = Weapon.TryGetComp<CompBiocodable>();
            if (compBiocodable == null)
            {
                compBiocodable = new CompBiocodable();
            }
            Messages.Message(string.Format("BiocodedToolApplied".Translate(), Weapon.LabelShort, pawn.LabelShort), Weapon, MessageTypeDefOf.PositiveEvent);
            compBiocodable.CodeFor(pawn);
            SoundDefOf.TechMedicineUsed.PlayOneShot(SoundInfo.InMap(Weapon));
            Biocoder.SplitOff(1).Destroy();
        }
    }
}