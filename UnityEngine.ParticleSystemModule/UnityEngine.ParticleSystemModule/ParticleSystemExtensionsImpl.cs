using System;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000031 RID: 49
	public class ParticleSystemExtensionsImpl
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x000020C5 File Offset: 0x000002C5
		public static int GetSafeCollisionEventSize(ParticleSystem ps)
		{
			return ParticleSystemExtensionsImpl.GetSafeCollisionEventSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps));
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000020D7 File Offset: 0x000002D7
		public static int GetSafeTriggerParticlesSize(ParticleSystem ps, int type)
		{
			return ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps), type);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000020EA File Offset: 0x000002EA
		public static int GetTriggerParticles(ParticleSystem ps, int type, List<ParticleSystem.Particle> particles)
		{
			return ParticleSystemExtensionsImpl.GetTriggerParticlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps), type, IL2CPP.Il2CppObjectBaseToPtr(particles));
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002103 File Offset: 0x00000303
		public static void SetTriggerParticles(ParticleSystem ps, int type, List<ParticleSystem.Particle> particles, int offset, int count)
		{
			ParticleSystemExtensionsImpl.SetTriggerParticlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(ps), type, IL2CPP.Il2CppObjectBaseToPtr(particles), offset, count);
		}

		// Token: 0x04000213 RID: 531
		private static readonly ParticleSystemExtensionsImpl.GetSafeCollisionEventSizeDelegate GetSafeCollisionEventSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.GetSafeCollisionEventSizeDelegate>("UnityEngine.ParticleSystemExtensionsImpl::GetSafeCollisionEventSize");

		// Token: 0x04000214 RID: 532
		private static readonly ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSizeDelegate GetSafeTriggerParticlesSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSizeDelegate>("UnityEngine.ParticleSystemExtensionsImpl::GetSafeTriggerParticlesSize");

		// Token: 0x04000215 RID: 533
		private static readonly ParticleSystemExtensionsImpl.GetTriggerParticlesDelegate GetTriggerParticlesDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.GetTriggerParticlesDelegate>("UnityEngine.ParticleSystemExtensionsImpl::GetTriggerParticles");

		// Token: 0x04000216 RID: 534
		private static readonly ParticleSystemExtensionsImpl.SetTriggerParticlesDelegate SetTriggerParticlesDelegateField = IL2CPP.ResolveICall<ParticleSystemExtensionsImpl.SetTriggerParticlesDelegate>("UnityEngine.ParticleSystemExtensionsImpl::SetTriggerParticles");

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000264 RID: 612
		private delegate int GetSafeCollisionEventSizeDelegate(IntPtr ps);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000266 RID: 614
		private delegate int GetSafeTriggerParticlesSizeDelegate(IntPtr ps, int type);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000268 RID: 616
		private delegate int GetTriggerParticlesDelegate(IntPtr ps, int type, IntPtr particles);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600026A RID: 618
		private delegate void SetTriggerParticlesDelegate(IntPtr ps, int type, IntPtr particles, int offset, int count);
	}
}
