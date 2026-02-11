using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	public static class ParticlePhysicsExtensions
	{
		// Token: 0x060000EE RID: 238 RVA: 0x000081D4 File Offset: 0x000063D4
		public static int GetSafeCollisionEventSize(ParticleSystem ps)
		{
			return ParticleSystemExtensionsImpl.GetSafeCollisionEventSize(ps);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000081EC File Offset: 0x000063EC
		public static int GetSafeTriggerParticlesSize(ParticleSystem ps, ParticleSystemTriggerEventType type)
		{
			return ParticleSystemExtensionsImpl.GetSafeTriggerParticlesSize(ps, (int)type);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00008208 File Offset: 0x00006408
		public static int GetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles)
		{
			return ParticleSystemExtensionsImpl.GetTriggerParticles(ps, (int)type, particles);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00008224 File Offset: 0x00006424
		public static void SetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles, int offset, int count)
		{
			bool flag = particles == null;
			if (flag)
			{
				throw new ArgumentNullException("particles");
			}
			bool flag2 = offset >= particles.Count;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("offset", "offset should be smaller than the size of the particles list.");
			}
			bool flag3 = offset + count >= particles.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("count", "offset+count should be smaller than the size of the particles list.");
			}
			ParticleSystemExtensionsImpl.SetTriggerParticles(ps, (int)type, particles, offset, count);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002074 File Offset: 0x00000274
		public static void SetTriggerParticles(ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles)
		{
			ParticleSystemExtensionsImpl.SetTriggerParticles(ps, (int)type, particles, 0, particles.Count);
		}
	}
}
