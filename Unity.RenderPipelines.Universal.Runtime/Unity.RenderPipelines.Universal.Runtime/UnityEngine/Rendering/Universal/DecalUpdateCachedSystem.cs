using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000074 RID: 116
	public class DecalUpdateCachedSystem : Object
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x00037B04 File Offset: 0x00035D04
		// Note: this type is marked as 'beforefieldinit'.
		static DecalUpdateCachedSystem()
		{
			Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalUpdateCachedSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr);
			DecalUpdateCachedSystem.NativeFieldInfoPtr_m_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, "m_EntityManager");
			DecalUpdateCachedSystem.NativeFieldInfoPtr_m_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, "m_Sampler");
			DecalUpdateCachedSystem.NativeFieldInfoPtr_m_SamplerJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, "m_SamplerJob");
			DecalUpdateCachedSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, 100664615);
			DecalUpdateCachedSystem.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, 100664616);
			DecalUpdateCachedSystem.NativeMethodInfoPtr_Execute_Private_Void_DecalEntityChunk_DecalCachedChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, 100664617);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00037BAC File Offset: 0x00035DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607896, RefRangeEnd = 607897, XrefRangeStart = 607881, XrefRangeEnd = 607896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalUpdateCachedSystem(DecalEntityManager entityManager)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCachedSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00037BF8 File Offset: 0x00035DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607911, RefRangeEnd = 607912, XrefRangeStart = 607897, XrefRangeEnd = 607911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCachedSystem.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00037C2C File Offset: 0x00035E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607937, RefRangeEnd = 607938, XrefRangeStart = 607912, XrefRangeEnd = 607937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(DecalEntityChunk entityChunk, DecalCachedChunk cachedChunk, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityChunk);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedChunk);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCachedSystem.NativeMethodInfoPtr_Execute_Private_Void_DecalEntityChunk_DecalCachedChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00006906 File Offset: 0x00004B06
		public DecalUpdateCachedSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00037C90 File Offset: 0x00035E90
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x0000690F File Offset: 0x00004B0F
		public unsafe DecalEntityManager m_EntityManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.NativeFieldInfoPtr_m_EntityManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.NativeFieldInfoPtr_m_EntityManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00037CC0 File Offset: 0x00035EC0
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x0000692E File Offset: 0x00004B2E
		public unsafe ProfilingSampler m_Sampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.NativeFieldInfoPtr_m_Sampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.NativeFieldInfoPtr_m_Sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00037CF0 File Offset: 0x00035EF0
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x0000694D File Offset: 0x00004B4D
		public unsafe ProfilingSampler m_SamplerJob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.NativeFieldInfoPtr_m_SamplerJob);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.NativeFieldInfoPtr_m_SamplerJob), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr_m_EntityManager;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr_m_Sampler;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_m_SamplerJob;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_DecalEntityChunk_DecalCachedChunk_Int32_0;

		// Token: 0x02000184 RID: 388
		public sealed class UpdateTransformsJob : ValueType
		{
			// Token: 0x06001CF0 RID: 7408 RVA: 0x00076420 File Offset: 0x00074620
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateTransformsJob()
			{
				Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalUpdateCachedSystem>.NativeClassPtr, "UpdateTransformsJob");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr);
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_k_MinusYtoZRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "k_MinusYtoZRotation");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "positions");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_rotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "rotations");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_scales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "scales");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "dirty");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_scaleModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "scaleModes");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_sizeOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "sizeOffsets");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_decalToWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "decalToWorlds");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_normalToWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "normalToWorlds");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_boundingSpheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "boundingSpheres");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_minDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, "minDistance");
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeMethodInfoPtr_DistanceBetweenQuaternions_Private_Single_quaternion_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, 100664618);
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, 100664619);
				DecalUpdateCachedSystem.UpdateTransformsJob.NativeMethodInfoPtr_GetDecalProjectBoundingSphere_Private_BoundingSphere_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr, 100664620);
			}

			// Token: 0x06001CF1 RID: 7409 RVA: 0x00076564 File Offset: 0x00074764
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 607832, RefRangeEnd = 607833, XrefRangeStart = 607832, XrefRangeEnd = 607832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float DistanceBetweenQuaternions(quaternion a, quaternion b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCachedSystem.UpdateTransformsJob.NativeMethodInfoPtr_DistanceBetweenQuaternions_Private_Single_quaternion_quaternion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001CF2 RID: 7410 RVA: 0x000765C0 File Offset: 0x000747C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607833, XrefRangeEnd = 607870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Execute(int index, TransformAccess transform)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transform;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCachedSystem.UpdateTransformsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CF3 RID: 7411 RVA: 0x00076614 File Offset: 0x00074814
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 607880, RefRangeEnd = 607881, XrefRangeStart = 607870, XrefRangeEnd = 607880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoundingSphere GetDecalProjectBoundingSphere(Matrix4x4 decalToWorld)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref decalToWorld;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCachedSystem.UpdateTransformsJob.NativeMethodInfoPtr_GetDecalProjectBoundingSphere_Private_BoundingSphere_Matrix4x4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001CF4 RID: 7412 RVA: 0x000108C4 File Offset: 0x0000EAC4
			public UpdateTransformsJob(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CF5 RID: 7413 RVA: 0x000108CD File Offset: 0x0000EACD
			public UpdateTransformsJob()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalUpdateCachedSystem.UpdateTransformsJob>.NativeClassPtr))
			{
			}

			// Token: 0x17000A55 RID: 2645
			// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x00076664 File Offset: 0x00074864
			// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x000108DF File Offset: 0x0000EADF
			public unsafe static quaternion k_MinusYtoZRotation
			{
				get
				{
					quaternion quaternion;
					IL2CPP.il2cpp_field_static_get_value(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_k_MinusYtoZRotation, (void*)(&quaternion));
					return quaternion;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_k_MinusYtoZRotation, (void*)(&value));
				}
			}

			// Token: 0x17000A56 RID: 2646
			// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x00076680 File Offset: 0x00074880
			// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x000108ED File Offset: 0x0000EAED
			public NativeArray<float3> positions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_positions);
					return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_positions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A57 RID: 2647
			// (get) Token: 0x06001CFA RID: 7418 RVA: 0x000766B0 File Offset: 0x000748B0
			// (set) Token: 0x06001CFB RID: 7419 RVA: 0x0001091B File Offset: 0x0000EB1B
			public NativeArray<quaternion> rotations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_rotations);
					return new NativeArray<quaternion>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<quaternion>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_rotations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<quaternion>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A58 RID: 2648
			// (get) Token: 0x06001CFC RID: 7420 RVA: 0x000766E0 File Offset: 0x000748E0
			// (set) Token: 0x06001CFD RID: 7421 RVA: 0x00010949 File Offset: 0x0000EB49
			public NativeArray<float3> scales
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_scales);
					return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_scales), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x06001CFE RID: 7422 RVA: 0x00076710 File Offset: 0x00074910
			// (set) Token: 0x06001CFF RID: 7423 RVA: 0x00010977 File Offset: 0x0000EB77
			public NativeArray<bool> dirty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_dirty);
					return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_dirty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A5A RID: 2650
			// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00076740 File Offset: 0x00074940
			// (set) Token: 0x06001D01 RID: 7425 RVA: 0x000109A5 File Offset: 0x0000EBA5
			public NativeArray<DecalScaleMode> scaleModes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_scaleModes);
					return new NativeArray<DecalScaleMode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<DecalScaleMode>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_scaleModes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<DecalScaleMode>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A5B RID: 2651
			// (get) Token: 0x06001D02 RID: 7426 RVA: 0x00076770 File Offset: 0x00074970
			// (set) Token: 0x06001D03 RID: 7427 RVA: 0x000109D3 File Offset: 0x0000EBD3
			public NativeArray<float4x4> sizeOffsets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_sizeOffsets);
					return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_sizeOffsets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A5C RID: 2652
			// (get) Token: 0x06001D04 RID: 7428 RVA: 0x000767A0 File Offset: 0x000749A0
			// (set) Token: 0x06001D05 RID: 7429 RVA: 0x00010A01 File Offset: 0x0000EC01
			public NativeArray<float4x4> decalToWorlds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_decalToWorlds);
					return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_decalToWorlds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A5D RID: 2653
			// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000767D0 File Offset: 0x000749D0
			// (set) Token: 0x06001D07 RID: 7431 RVA: 0x00010A2F File Offset: 0x0000EC2F
			public NativeArray<float4x4> normalToWorlds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_normalToWorlds);
					return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_normalToWorlds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A5E RID: 2654
			// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00076800 File Offset: 0x00074A00
			// (set) Token: 0x06001D09 RID: 7433 RVA: 0x00010A5D File Offset: 0x0000EC5D
			public NativeArray<BoundingSphere> boundingSpheres
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_boundingSpheres);
					return new NativeArray<BoundingSphere>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<BoundingSphere>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_boundingSpheres), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<BoundingSphere>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A5F RID: 2655
			// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00076830 File Offset: 0x00074A30
			// (set) Token: 0x06001D0B RID: 7435 RVA: 0x00010A8B File Offset: 0x0000EC8B
			public unsafe float minDistance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_minDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCachedSystem.UpdateTransformsJob.NativeFieldInfoPtr_minDistance)) = value;
				}
			}

			// Token: 0x040014F9 RID: 5369
			private static readonly IntPtr NativeFieldInfoPtr_k_MinusYtoZRotation;

			// Token: 0x040014FA RID: 5370
			private static readonly IntPtr NativeFieldInfoPtr_positions;

			// Token: 0x040014FB RID: 5371
			private static readonly IntPtr NativeFieldInfoPtr_rotations;

			// Token: 0x040014FC RID: 5372
			private static readonly IntPtr NativeFieldInfoPtr_scales;

			// Token: 0x040014FD RID: 5373
			private static readonly IntPtr NativeFieldInfoPtr_dirty;

			// Token: 0x040014FE RID: 5374
			private static readonly IntPtr NativeFieldInfoPtr_scaleModes;

			// Token: 0x040014FF RID: 5375
			private static readonly IntPtr NativeFieldInfoPtr_sizeOffsets;

			// Token: 0x04001500 RID: 5376
			private static readonly IntPtr NativeFieldInfoPtr_decalToWorlds;

			// Token: 0x04001501 RID: 5377
			private static readonly IntPtr NativeFieldInfoPtr_normalToWorlds;

			// Token: 0x04001502 RID: 5378
			private static readonly IntPtr NativeFieldInfoPtr_boundingSpheres;

			// Token: 0x04001503 RID: 5379
			private static readonly IntPtr NativeFieldInfoPtr_minDistance;

			// Token: 0x04001504 RID: 5380
			private static readonly IntPtr NativeMethodInfoPtr_DistanceBetweenQuaternions_Private_Single_quaternion_quaternion_0;

			// Token: 0x04001505 RID: 5381
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0;

			// Token: 0x04001506 RID: 5382
			private static readonly IntPtr NativeMethodInfoPtr_GetDecalProjectBoundingSphere_Private_BoundingSphere_Matrix4x4_0;
		}
	}
}
