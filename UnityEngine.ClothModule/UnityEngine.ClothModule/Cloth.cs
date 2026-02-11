using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class Cloth : Component
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002768 File Offset: 0x00000968
		public Il2CppStructArray<Vector3> vertices
		{
			get
			{
				IntPtr intPtr = Cloth.get_verticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002794 File Offset: 0x00000994
		public Il2CppStructArray<Vector3> normals
		{
			get
			{
				IntPtr intPtr = Cloth.get_normalsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000027C0 File Offset: 0x000009C0
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public Il2CppReferenceArray<CapsuleCollider> capsuleColliders
		{
			get
			{
				IntPtr intPtr = Cloth.get_capsuleCollidersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CapsuleCollider>>(intPtr2) : null;
			}
			set
			{
				Cloth.set_capsuleCollidersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000207A File Offset: 0x0000027A
		public float sleepThreshold
		{
			get
			{
				return Cloth.get_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_sleepThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000208D File Offset: 0x0000028D
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000209F File Offset: 0x0000029F
		public float bendingStiffness
		{
			get
			{
				return Cloth.get_bendingStiffnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_bendingStiffnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020C4 File Offset: 0x000002C4
		public float stretchingStiffness
		{
			get
			{
				return Cloth.get_stretchingStiffnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_stretchingStiffnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020D7 File Offset: 0x000002D7
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020E9 File Offset: 0x000002E9
		public float damping
		{
			get
			{
				return Cloth.get_dampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_dampingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000027EC File Offset: 0x000009EC
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020FC File Offset: 0x000002FC
		public Vector3 externalAcceleration
		{
			get
			{
				Vector3 vector;
				this.get_externalAcceleration_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_externalAcceleration_Injected(ref value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002804 File Offset: 0x00000A04
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002106 File Offset: 0x00000306
		public Vector3 randomAcceleration
		{
			get
			{
				Vector3 vector;
				this.get_randomAcceleration_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_randomAcceleration_Injected(ref value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002110 File Offset: 0x00000310
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002122 File Offset: 0x00000322
		public bool useGravity
		{
			get
			{
				return Cloth.get_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_useGravityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002135 File Offset: 0x00000335
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002147 File Offset: 0x00000347
		public bool enabled
		{
			get
			{
				return Cloth.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000215A File Offset: 0x0000035A
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000216C File Offset: 0x0000036C
		public float friction
		{
			get
			{
				return Cloth.get_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_frictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000217F File Offset: 0x0000037F
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002191 File Offset: 0x00000391
		public float collisionMassScale
		{
			get
			{
				return Cloth.get_collisionMassScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_collisionMassScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000021A4 File Offset: 0x000003A4
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000021B6 File Offset: 0x000003B6
		public bool enableContinuousCollision
		{
			get
			{
				return Cloth.get_enableContinuousCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_enableContinuousCollisionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000021C9 File Offset: 0x000003C9
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000021DB File Offset: 0x000003DB
		public float useVirtualParticles
		{
			get
			{
				return Cloth.get_useVirtualParticlesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_useVirtualParticlesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000021EE File Offset: 0x000003EE
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002200 File Offset: 0x00000400
		public float worldVelocityScale
		{
			get
			{
				return Cloth.get_worldVelocityScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_worldVelocityScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002213 File Offset: 0x00000413
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002225 File Offset: 0x00000425
		public float worldAccelerationScale
		{
			get
			{
				return Cloth.get_worldAccelerationScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_worldAccelerationScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000224A File Offset: 0x0000044A
		public float clothSolverFrequency
		{
			get
			{
				return Cloth.get_clothSolverFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_clothSolverFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000281C File Offset: 0x00000A1C
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000225D File Offset: 0x0000045D
		public bool solverFrequency
		{
			get
			{
				return this.clothSolverFrequency > 0f;
			}
			set
			{
				this.clothSolverFrequency = (value ? 120f : 0f);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002276 File Offset: 0x00000476
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002288 File Offset: 0x00000488
		public bool useTethers
		{
			get
			{
				return Cloth.get_useTethersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_useTethersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000229B File Offset: 0x0000049B
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000022AD File Offset: 0x000004AD
		public float stiffnessFrequency
		{
			get
			{
				return Cloth.get_stiffnessFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_stiffnessFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000022C0 File Offset: 0x000004C0
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000022D2 File Offset: 0x000004D2
		public float selfCollisionDistance
		{
			get
			{
				return Cloth.get_selfCollisionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_selfCollisionDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000022E5 File Offset: 0x000004E5
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000022F7 File Offset: 0x000004F7
		public float selfCollisionStiffness
		{
			get
			{
				return Cloth.get_selfCollisionStiffnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cloth.set_selfCollisionStiffnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000230A File Offset: 0x0000050A
		public void ClearTransformMotion()
		{
			Cloth.ClearTransformMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000231C File Offset: 0x0000051C
		public void GetSelfAndInterCollisionIndices(List<uint> indices)
		{
			Cloth.GetSelfAndInterCollisionIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indices));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002334 File Offset: 0x00000534
		public void SetSelfAndInterCollisionIndices(List<uint> indices)
		{
			Cloth.SetSelfAndInterCollisionIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indices));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000234C File Offset: 0x0000054C
		public void GetVirtualParticleIndices(List<uint> indicesOutList)
		{
			Cloth.GetVirtualParticleIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indicesOutList));
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002364 File Offset: 0x00000564
		public void SetVirtualParticleIndices(List<uint> indicesIn)
		{
			Cloth.SetVirtualParticleIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indicesIn));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000237C File Offset: 0x0000057C
		public void GetVirtualParticleWeights(List<Vector3> weightsOutList)
		{
			Cloth.GetVirtualParticleWeightsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(weightsOutList));
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002394 File Offset: 0x00000594
		public void SetVirtualParticleWeights(List<Vector3> weights)
		{
			Cloth.SetVirtualParticleWeightsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(weights));
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000023AC File Offset: 0x000005AC
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000023B9 File Offset: 0x000005B9
		public float useContinuousCollision
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000023C6 File Offset: 0x000005C6
		public bool selfCollision
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000023D3 File Offset: 0x000005D3
		public void SetEnabledFading(bool enabled, float interpolationTime)
		{
			Cloth.SetEnabledFadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), enabled, interpolationTime);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000023E7 File Offset: 0x000005E7
		public void SetEnabledFading(bool enabled)
		{
			this.SetEnabledFading(enabled, 0.5f);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000283C File Offset: 0x00000A3C
		public RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
		{
			RaycastHit raycastHit;
			this.Raycast_Injected(ref ray, maxDistance, ref hasHit, out raycastHit);
			return raycastHit;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000023F7 File Offset: 0x000005F7
		public void get_externalAcceleration_Injected(out Vector3 ret)
		{
			Cloth.get_externalAcceleration_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000240A File Offset: 0x0000060A
		public void set_externalAcceleration_Injected(ref Vector3 value)
		{
			Cloth.set_externalAcceleration_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000241D File Offset: 0x0000061D
		public void get_randomAcceleration_Injected(out Vector3 ret)
		{
			Cloth.get_randomAcceleration_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002430 File Offset: 0x00000630
		public void set_randomAcceleration_Injected(ref Vector3 value)
		{
			Cloth.set_randomAcceleration_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002443 File Offset: 0x00000643
		public void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret)
		{
			Cloth.Raycast_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref ray, maxDistance, ref hasHit, out ret);
		}

		// Token: 0x04000001 RID: 1
		private static readonly Cloth.get_verticesDelegate get_verticesDelegateField = IL2CPP.ResolveICall<Cloth.get_verticesDelegate>("UnityEngine.Cloth::get_vertices");

		// Token: 0x04000002 RID: 2
		private static readonly Cloth.get_normalsDelegate get_normalsDelegateField = IL2CPP.ResolveICall<Cloth.get_normalsDelegate>("UnityEngine.Cloth::get_normals");

		// Token: 0x04000003 RID: 3
		private static readonly Cloth.get_capsuleCollidersDelegate get_capsuleCollidersDelegateField = IL2CPP.ResolveICall<Cloth.get_capsuleCollidersDelegate>("UnityEngine.Cloth::get_capsuleColliders");

		// Token: 0x04000004 RID: 4
		private static readonly Cloth.set_capsuleCollidersDelegate set_capsuleCollidersDelegateField = IL2CPP.ResolveICall<Cloth.set_capsuleCollidersDelegate>("UnityEngine.Cloth::set_capsuleColliders");

		// Token: 0x04000005 RID: 5
		private static readonly Cloth.get_sleepThresholdDelegate get_sleepThresholdDelegateField = IL2CPP.ResolveICall<Cloth.get_sleepThresholdDelegate>("UnityEngine.Cloth::get_sleepThreshold");

		// Token: 0x04000006 RID: 6
		private static readonly Cloth.set_sleepThresholdDelegate set_sleepThresholdDelegateField = IL2CPP.ResolveICall<Cloth.set_sleepThresholdDelegate>("UnityEngine.Cloth::set_sleepThreshold");

		// Token: 0x04000007 RID: 7
		private static readonly Cloth.get_bendingStiffnessDelegate get_bendingStiffnessDelegateField = IL2CPP.ResolveICall<Cloth.get_bendingStiffnessDelegate>("UnityEngine.Cloth::get_bendingStiffness");

		// Token: 0x04000008 RID: 8
		private static readonly Cloth.set_bendingStiffnessDelegate set_bendingStiffnessDelegateField = IL2CPP.ResolveICall<Cloth.set_bendingStiffnessDelegate>("UnityEngine.Cloth::set_bendingStiffness");

		// Token: 0x04000009 RID: 9
		private static readonly Cloth.get_stretchingStiffnessDelegate get_stretchingStiffnessDelegateField = IL2CPP.ResolveICall<Cloth.get_stretchingStiffnessDelegate>("UnityEngine.Cloth::get_stretchingStiffness");

		// Token: 0x0400000A RID: 10
		private static readonly Cloth.set_stretchingStiffnessDelegate set_stretchingStiffnessDelegateField = IL2CPP.ResolveICall<Cloth.set_stretchingStiffnessDelegate>("UnityEngine.Cloth::set_stretchingStiffness");

		// Token: 0x0400000B RID: 11
		private static readonly Cloth.get_dampingDelegate get_dampingDelegateField = IL2CPP.ResolveICall<Cloth.get_dampingDelegate>("UnityEngine.Cloth::get_damping");

		// Token: 0x0400000C RID: 12
		private static readonly Cloth.set_dampingDelegate set_dampingDelegateField = IL2CPP.ResolveICall<Cloth.set_dampingDelegate>("UnityEngine.Cloth::set_damping");

		// Token: 0x0400000D RID: 13
		private static readonly Cloth.get_useGravityDelegate get_useGravityDelegateField = IL2CPP.ResolveICall<Cloth.get_useGravityDelegate>("UnityEngine.Cloth::get_useGravity");

		// Token: 0x0400000E RID: 14
		private static readonly Cloth.set_useGravityDelegate set_useGravityDelegateField = IL2CPP.ResolveICall<Cloth.set_useGravityDelegate>("UnityEngine.Cloth::set_useGravity");

		// Token: 0x0400000F RID: 15
		private static readonly Cloth.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<Cloth.get_enabledDelegate>("UnityEngine.Cloth::get_enabled");

		// Token: 0x04000010 RID: 16
		private static readonly Cloth.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<Cloth.set_enabledDelegate>("UnityEngine.Cloth::set_enabled");

		// Token: 0x04000011 RID: 17
		private static readonly Cloth.get_frictionDelegate get_frictionDelegateField = IL2CPP.ResolveICall<Cloth.get_frictionDelegate>("UnityEngine.Cloth::get_friction");

		// Token: 0x04000012 RID: 18
		private static readonly Cloth.set_frictionDelegate set_frictionDelegateField = IL2CPP.ResolveICall<Cloth.set_frictionDelegate>("UnityEngine.Cloth::set_friction");

		// Token: 0x04000013 RID: 19
		private static readonly Cloth.get_collisionMassScaleDelegate get_collisionMassScaleDelegateField = IL2CPP.ResolveICall<Cloth.get_collisionMassScaleDelegate>("UnityEngine.Cloth::get_collisionMassScale");

		// Token: 0x04000014 RID: 20
		private static readonly Cloth.set_collisionMassScaleDelegate set_collisionMassScaleDelegateField = IL2CPP.ResolveICall<Cloth.set_collisionMassScaleDelegate>("UnityEngine.Cloth::set_collisionMassScale");

		// Token: 0x04000015 RID: 21
		private static readonly Cloth.get_enableContinuousCollisionDelegate get_enableContinuousCollisionDelegateField = IL2CPP.ResolveICall<Cloth.get_enableContinuousCollisionDelegate>("UnityEngine.Cloth::get_enableContinuousCollision");

		// Token: 0x04000016 RID: 22
		private static readonly Cloth.set_enableContinuousCollisionDelegate set_enableContinuousCollisionDelegateField = IL2CPP.ResolveICall<Cloth.set_enableContinuousCollisionDelegate>("UnityEngine.Cloth::set_enableContinuousCollision");

		// Token: 0x04000017 RID: 23
		private static readonly Cloth.get_useVirtualParticlesDelegate get_useVirtualParticlesDelegateField = IL2CPP.ResolveICall<Cloth.get_useVirtualParticlesDelegate>("UnityEngine.Cloth::get_useVirtualParticles");

		// Token: 0x04000018 RID: 24
		private static readonly Cloth.set_useVirtualParticlesDelegate set_useVirtualParticlesDelegateField = IL2CPP.ResolveICall<Cloth.set_useVirtualParticlesDelegate>("UnityEngine.Cloth::set_useVirtualParticles");

		// Token: 0x04000019 RID: 25
		private static readonly Cloth.get_worldVelocityScaleDelegate get_worldVelocityScaleDelegateField = IL2CPP.ResolveICall<Cloth.get_worldVelocityScaleDelegate>("UnityEngine.Cloth::get_worldVelocityScale");

		// Token: 0x0400001A RID: 26
		private static readonly Cloth.set_worldVelocityScaleDelegate set_worldVelocityScaleDelegateField = IL2CPP.ResolveICall<Cloth.set_worldVelocityScaleDelegate>("UnityEngine.Cloth::set_worldVelocityScale");

		// Token: 0x0400001B RID: 27
		private static readonly Cloth.get_worldAccelerationScaleDelegate get_worldAccelerationScaleDelegateField = IL2CPP.ResolveICall<Cloth.get_worldAccelerationScaleDelegate>("UnityEngine.Cloth::get_worldAccelerationScale");

		// Token: 0x0400001C RID: 28
		private static readonly Cloth.set_worldAccelerationScaleDelegate set_worldAccelerationScaleDelegateField = IL2CPP.ResolveICall<Cloth.set_worldAccelerationScaleDelegate>("UnityEngine.Cloth::set_worldAccelerationScale");

		// Token: 0x0400001D RID: 29
		private static readonly Cloth.get_clothSolverFrequencyDelegate get_clothSolverFrequencyDelegateField = IL2CPP.ResolveICall<Cloth.get_clothSolverFrequencyDelegate>("UnityEngine.Cloth::get_clothSolverFrequency");

		// Token: 0x0400001E RID: 30
		private static readonly Cloth.set_clothSolverFrequencyDelegate set_clothSolverFrequencyDelegateField = IL2CPP.ResolveICall<Cloth.set_clothSolverFrequencyDelegate>("UnityEngine.Cloth::set_clothSolverFrequency");

		// Token: 0x0400001F RID: 31
		private static readonly Cloth.get_useTethersDelegate get_useTethersDelegateField = IL2CPP.ResolveICall<Cloth.get_useTethersDelegate>("UnityEngine.Cloth::get_useTethers");

		// Token: 0x04000020 RID: 32
		private static readonly Cloth.set_useTethersDelegate set_useTethersDelegateField = IL2CPP.ResolveICall<Cloth.set_useTethersDelegate>("UnityEngine.Cloth::set_useTethers");

		// Token: 0x04000021 RID: 33
		private static readonly Cloth.get_stiffnessFrequencyDelegate get_stiffnessFrequencyDelegateField = IL2CPP.ResolveICall<Cloth.get_stiffnessFrequencyDelegate>("UnityEngine.Cloth::get_stiffnessFrequency");

		// Token: 0x04000022 RID: 34
		private static readonly Cloth.set_stiffnessFrequencyDelegate set_stiffnessFrequencyDelegateField = IL2CPP.ResolveICall<Cloth.set_stiffnessFrequencyDelegate>("UnityEngine.Cloth::set_stiffnessFrequency");

		// Token: 0x04000023 RID: 35
		private static readonly Cloth.get_selfCollisionDistanceDelegate get_selfCollisionDistanceDelegateField = IL2CPP.ResolveICall<Cloth.get_selfCollisionDistanceDelegate>("UnityEngine.Cloth::get_selfCollisionDistance");

		// Token: 0x04000024 RID: 36
		private static readonly Cloth.set_selfCollisionDistanceDelegate set_selfCollisionDistanceDelegateField = IL2CPP.ResolveICall<Cloth.set_selfCollisionDistanceDelegate>("UnityEngine.Cloth::set_selfCollisionDistance");

		// Token: 0x04000025 RID: 37
		private static readonly Cloth.get_selfCollisionStiffnessDelegate get_selfCollisionStiffnessDelegateField = IL2CPP.ResolveICall<Cloth.get_selfCollisionStiffnessDelegate>("UnityEngine.Cloth::get_selfCollisionStiffness");

		// Token: 0x04000026 RID: 38
		private static readonly Cloth.set_selfCollisionStiffnessDelegate set_selfCollisionStiffnessDelegateField = IL2CPP.ResolveICall<Cloth.set_selfCollisionStiffnessDelegate>("UnityEngine.Cloth::set_selfCollisionStiffness");

		// Token: 0x04000027 RID: 39
		private static readonly Cloth.ClearTransformMotionDelegate ClearTransformMotionDelegateField = IL2CPP.ResolveICall<Cloth.ClearTransformMotionDelegate>("UnityEngine.Cloth::ClearTransformMotion");

		// Token: 0x04000028 RID: 40
		private static readonly Cloth.GetSelfAndInterCollisionIndicesDelegate GetSelfAndInterCollisionIndicesDelegateField = IL2CPP.ResolveICall<Cloth.GetSelfAndInterCollisionIndicesDelegate>("UnityEngine.Cloth::GetSelfAndInterCollisionIndices");

		// Token: 0x04000029 RID: 41
		private static readonly Cloth.SetSelfAndInterCollisionIndicesDelegate SetSelfAndInterCollisionIndicesDelegateField = IL2CPP.ResolveICall<Cloth.SetSelfAndInterCollisionIndicesDelegate>("UnityEngine.Cloth::SetSelfAndInterCollisionIndices");

		// Token: 0x0400002A RID: 42
		private static readonly Cloth.GetVirtualParticleIndicesDelegate GetVirtualParticleIndicesDelegateField = IL2CPP.ResolveICall<Cloth.GetVirtualParticleIndicesDelegate>("UnityEngine.Cloth::GetVirtualParticleIndices");

		// Token: 0x0400002B RID: 43
		private static readonly Cloth.SetVirtualParticleIndicesDelegate SetVirtualParticleIndicesDelegateField = IL2CPP.ResolveICall<Cloth.SetVirtualParticleIndicesDelegate>("UnityEngine.Cloth::SetVirtualParticleIndices");

		// Token: 0x0400002C RID: 44
		private static readonly Cloth.GetVirtualParticleWeightsDelegate GetVirtualParticleWeightsDelegateField = IL2CPP.ResolveICall<Cloth.GetVirtualParticleWeightsDelegate>("UnityEngine.Cloth::GetVirtualParticleWeights");

		// Token: 0x0400002D RID: 45
		private static readonly Cloth.SetVirtualParticleWeightsDelegate SetVirtualParticleWeightsDelegateField = IL2CPP.ResolveICall<Cloth.SetVirtualParticleWeightsDelegate>("UnityEngine.Cloth::SetVirtualParticleWeights");

		// Token: 0x0400002E RID: 46
		private static readonly Cloth.SetEnabledFadingDelegate SetEnabledFadingDelegateField = IL2CPP.ResolveICall<Cloth.SetEnabledFadingDelegate>("UnityEngine.Cloth::SetEnabledFading");

		// Token: 0x0400002F RID: 47
		private static readonly Cloth.get_externalAcceleration_InjectedDelegate get_externalAcceleration_InjectedDelegateField = IL2CPP.ResolveICall<Cloth.get_externalAcceleration_InjectedDelegate>("UnityEngine.Cloth::get_externalAcceleration_Injected");

		// Token: 0x04000030 RID: 48
		private static readonly Cloth.set_externalAcceleration_InjectedDelegate set_externalAcceleration_InjectedDelegateField = IL2CPP.ResolveICall<Cloth.set_externalAcceleration_InjectedDelegate>("UnityEngine.Cloth::set_externalAcceleration_Injected");

		// Token: 0x04000031 RID: 49
		private static readonly Cloth.get_randomAcceleration_InjectedDelegate get_randomAcceleration_InjectedDelegateField = IL2CPP.ResolveICall<Cloth.get_randomAcceleration_InjectedDelegate>("UnityEngine.Cloth::get_randomAcceleration_Injected");

		// Token: 0x04000032 RID: 50
		private static readonly Cloth.set_randomAcceleration_InjectedDelegate set_randomAcceleration_InjectedDelegateField = IL2CPP.ResolveICall<Cloth.set_randomAcceleration_InjectedDelegate>("UnityEngine.Cloth::set_randomAcceleration_Injected");

		// Token: 0x04000033 RID: 51
		private static readonly Cloth.Raycast_InjectedDelegate Raycast_InjectedDelegateField = IL2CPP.ResolveICall<Cloth.Raycast_InjectedDelegate>("UnityEngine.Cloth::Raycast_Injected");

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000041 RID: 65
		private delegate IntPtr get_verticesDelegate(IntPtr @this);

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000043 RID: 67
		private delegate IntPtr get_normalsDelegate(IntPtr @this);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000045 RID: 69
		private delegate IntPtr get_capsuleCollidersDelegate(IntPtr @this);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000047 RID: 71
		private delegate void set_capsuleCollidersDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000049 RID: 73
		private delegate float get_sleepThresholdDelegate(IntPtr @this);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600004B RID: 75
		private delegate void set_sleepThresholdDelegate(IntPtr @this, float value);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600004D RID: 77
		private delegate float get_bendingStiffnessDelegate(IntPtr @this);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600004F RID: 79
		private delegate void set_bendingStiffnessDelegate(IntPtr @this, float value);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000051 RID: 81
		private delegate float get_stretchingStiffnessDelegate(IntPtr @this);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000053 RID: 83
		private delegate void set_stretchingStiffnessDelegate(IntPtr @this, float value);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000055 RID: 85
		private delegate float get_dampingDelegate(IntPtr @this);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000057 RID: 87
		private delegate void set_dampingDelegate(IntPtr @this, float value);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000059 RID: 89
		private delegate bool get_useGravityDelegate(IntPtr @this);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600005B RID: 91
		private delegate void set_useGravityDelegate(IntPtr @this, bool value);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600005D RID: 93
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600005F RID: 95
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000061 RID: 97
		private delegate float get_frictionDelegate(IntPtr @this);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000063 RID: 99
		private delegate void set_frictionDelegate(IntPtr @this, float value);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000065 RID: 101
		private delegate float get_collisionMassScaleDelegate(IntPtr @this);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000067 RID: 103
		private delegate void set_collisionMassScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000069 RID: 105
		private delegate bool get_enableContinuousCollisionDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600006B RID: 107
		private delegate void set_enableContinuousCollisionDelegate(IntPtr @this, bool value);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600006D RID: 109
		private delegate float get_useVirtualParticlesDelegate(IntPtr @this);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600006F RID: 111
		private delegate void set_useVirtualParticlesDelegate(IntPtr @this, float value);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000071 RID: 113
		private delegate float get_worldVelocityScaleDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000073 RID: 115
		private delegate void set_worldVelocityScaleDelegate(IntPtr @this, float value);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000075 RID: 117
		private delegate float get_worldAccelerationScaleDelegate(IntPtr @this);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000077 RID: 119
		private delegate void set_worldAccelerationScaleDelegate(IntPtr @this, float value);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x06000079 RID: 121
		private delegate float get_clothSolverFrequencyDelegate(IntPtr @this);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600007B RID: 123
		private delegate void set_clothSolverFrequencyDelegate(IntPtr @this, float value);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600007D RID: 125
		private delegate bool get_useTethersDelegate(IntPtr @this);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x0600007F RID: 127
		private delegate void set_useTethersDelegate(IntPtr @this, bool value);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000081 RID: 129
		private delegate float get_stiffnessFrequencyDelegate(IntPtr @this);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000083 RID: 131
		private delegate void set_stiffnessFrequencyDelegate(IntPtr @this, float value);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000085 RID: 133
		private delegate float get_selfCollisionDistanceDelegate(IntPtr @this);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000087 RID: 135
		private delegate void set_selfCollisionDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000089 RID: 137
		private delegate float get_selfCollisionStiffnessDelegate(IntPtr @this);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x0600008B RID: 139
		private delegate void set_selfCollisionStiffnessDelegate(IntPtr @this, float value);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600008D RID: 141
		private delegate void ClearTransformMotionDelegate(IntPtr @this);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x0600008F RID: 143
		private delegate void GetSelfAndInterCollisionIndicesDelegate(IntPtr @this, IntPtr indices);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000091 RID: 145
		private delegate void SetSelfAndInterCollisionIndicesDelegate(IntPtr @this, IntPtr indices);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000093 RID: 147
		private delegate void GetVirtualParticleIndicesDelegate(IntPtr @this, IntPtr indicesOutList);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000095 RID: 149
		private delegate void SetVirtualParticleIndicesDelegate(IntPtr @this, IntPtr indicesIn);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000097 RID: 151
		private delegate void GetVirtualParticleWeightsDelegate(IntPtr @this, IntPtr weightsOutList);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000099 RID: 153
		private delegate void SetVirtualParticleWeightsDelegate(IntPtr @this, IntPtr weights);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600009B RID: 155
		private delegate void SetEnabledFadingDelegate(IntPtr @this, bool enabled, float interpolationTime);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600009D RID: 157
		private delegate void get_externalAcceleration_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x0600009F RID: 159
		private delegate void set_externalAcceleration_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060000A1 RID: 161
		private delegate void get_randomAcceleration_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x060000A3 RID: 163
		private delegate void set_randomAcceleration_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060000A5 RID: 165
		private delegate void Raycast_InjectedDelegate(IntPtr @this, IntPtr ray, float maxDistance, IntPtr hasHit, [Out] IntPtr ret);
	}
}
