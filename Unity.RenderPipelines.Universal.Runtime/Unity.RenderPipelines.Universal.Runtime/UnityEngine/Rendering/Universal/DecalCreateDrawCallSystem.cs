using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200006C RID: 108
	public class DecalCreateDrawCallSystem : Object
	{
		// Token: 0x06000956 RID: 2390 RVA: 0x00035770 File Offset: 0x00033970
		// Note: this type is marked as 'beforefieldinit'.
		static DecalCreateDrawCallSystem()
		{
			Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalCreateDrawCallSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr);
			DecalCreateDrawCallSystem.NativeFieldInfoPtr_m_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr, "m_EntityManager");
			DecalCreateDrawCallSystem.NativeFieldInfoPtr_m_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr, "m_Sampler");
			DecalCreateDrawCallSystem.NativeFieldInfoPtr_m_MaxDrawDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr, "m_MaxDrawDistance");
			DecalCreateDrawCallSystem.NativeMethodInfoPtr_get_maxDrawDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr, 100664560);
			DecalCreateDrawCallSystem.NativeMethodInfoPtr_set_maxDrawDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr, 100664561);
			DecalCreateDrawCallSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr, 100664562);
			DecalCreateDrawCallSystem.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr, 100664563);
			DecalCreateDrawCallSystem.NativeMethodInfoPtr_Execute_Private_Void_DecalCachedChunk_DecalCulledChunk_DecalDrawCallChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr, 100664564);
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00035840 File Offset: 0x00033A40
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x0003587C File Offset: 0x00033A7C
		public unsafe float maxDrawDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalCreateDrawCallSystem.NativeMethodInfoPtr_get_maxDrawDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalCreateDrawCallSystem.NativeMethodInfoPtr_set_maxDrawDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000358BC File Offset: 0x00033ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606813, RefRangeEnd = 606814, XrefRangeStart = 606804, XrefRangeEnd = 606813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalCreateDrawCallSystem(DecalEntityManager entityManager, float maxDrawDistance)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDrawDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalCreateDrawCallSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00035918 File Offset: 0x00033B18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 606834, RefRangeEnd = 606836, XrefRangeStart = 606814, XrefRangeEnd = 606834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalCreateDrawCallSystem.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0003594C File Offset: 0x00033B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606836, XrefRangeEnd = 606840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, DecalDrawCallChunk drawCallChunk, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachedChunk);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culledChunk);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drawCallChunk);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalCreateDrawCallSystem.NativeMethodInfoPtr_Execute_Private_Void_DecalCachedChunk_DecalCulledChunk_DecalDrawCallChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00006104 File Offset: 0x00004304
		public DecalCreateDrawCallSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x000359C0 File Offset: 0x00033BC0
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x0000610D File Offset: 0x0000430D
		public unsafe DecalEntityManager m_EntityManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.NativeFieldInfoPtr_m_EntityManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.NativeFieldInfoPtr_m_EntityManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x000359F0 File Offset: 0x00033BF0
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x0000612C File Offset: 0x0000432C
		public unsafe ProfilingSampler m_Sampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.NativeFieldInfoPtr_m_Sampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.NativeFieldInfoPtr_m_Sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00035A20 File Offset: 0x00033C20
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x0000614B File Offset: 0x0000434B
		public unsafe float m_MaxDrawDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.NativeFieldInfoPtr_m_MaxDrawDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.NativeFieldInfoPtr_m_MaxDrawDistance)) = value;
			}
		}

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeFieldInfoPtr_m_EntityManager;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeFieldInfoPtr_m_Sampler;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxDrawDistance;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_get_maxDrawDistance_Public_get_Single_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_set_maxDrawDistance_Public_set_Void_Single_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_Single_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_DecalCachedChunk_DecalCulledChunk_DecalDrawCallChunk_Int32_0;

		// Token: 0x02000180 RID: 384
		public sealed class DrawCallJob : ValueType
		{
			// Token: 0x06001CA7 RID: 7335 RVA: 0x00075A68 File Offset: 0x00073C68
			// Note: this type is marked as 'beforefieldinit'.
			static DrawCallJob()
			{
				Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalCreateDrawCallSystem>.NativeClassPtr, "DrawCallJob");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr);
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_decalToWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "decalToWorlds");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_normalToWorlds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "normalToWorlds");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_sizeOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "sizeOffsets");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_drawDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "drawDistances");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_angleFades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "angleFades");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_uvScaleBiases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "uvScaleBiases");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_layerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "layerMasks");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_sceneLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "sceneLayerMasks");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_fadeFactors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "fadeFactors");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_boundingSpheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "boundingSpheres");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_renderingLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "renderingLayerMasks");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_cameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "cameraPosition");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "sceneCullingMask");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_cullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "cullingMask");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_visibleDecalIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "visibleDecalIndices");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_visibleDecalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "visibleDecalCount");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_maxDrawDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "maxDrawDistance");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_decalToWorldsDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "decalToWorldsDraw");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_normalToDecalsDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "normalToDecalsDraw");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_renderingLayerMasksDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "renderingLayerMasksDraw");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_subCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "subCalls");
				DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_subCallCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, "subCallCount");
				DecalCreateDrawCallSystem.DrawCallJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr, 100664565);
			}

			// Token: 0x06001CA8 RID: 7336 RVA: 0x00075C60 File Offset: 0x00073E60
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 606803, RefRangeEnd = 606804, XrefRangeStart = 606798, XrefRangeEnd = 606803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalCreateDrawCallSystem.DrawCallJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CA9 RID: 7337 RVA: 0x00010408 File Offset: 0x0000E608
			public DrawCallJob(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CAA RID: 7338 RVA: 0x00010411 File Offset: 0x0000E611
			public DrawCallJob()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalCreateDrawCallSystem.DrawCallJob>.NativeClassPtr))
			{
			}

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x06001CAB RID: 7339 RVA: 0x00075C98 File Offset: 0x00073E98
			// (set) Token: 0x06001CAC RID: 7340 RVA: 0x00010423 File Offset: 0x0000E623
			public NativeArray<float4x4> decalToWorlds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_decalToWorlds);
					return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_decalToWorlds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x06001CAD RID: 7341 RVA: 0x00075CC8 File Offset: 0x00073EC8
			// (set) Token: 0x06001CAE RID: 7342 RVA: 0x00010451 File Offset: 0x0000E651
			public NativeArray<float4x4> normalToWorlds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_normalToWorlds);
					return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_normalToWorlds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x06001CAF RID: 7343 RVA: 0x00075CF8 File Offset: 0x00073EF8
			// (set) Token: 0x06001CB0 RID: 7344 RVA: 0x0001047F File Offset: 0x0000E67F
			public NativeArray<float4x4> sizeOffsets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_sizeOffsets);
					return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_sizeOffsets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A3A RID: 2618
			// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x00075D28 File Offset: 0x00073F28
			// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x000104AD File Offset: 0x0000E6AD
			public NativeArray<float2> drawDistances
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_drawDistances);
					return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_drawDistances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A3B RID: 2619
			// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x00075D58 File Offset: 0x00073F58
			// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x000104DB File Offset: 0x0000E6DB
			public NativeArray<float2> angleFades
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_angleFades);
					return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_angleFades), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A3C RID: 2620
			// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x00075D88 File Offset: 0x00073F88
			// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x00010509 File Offset: 0x0000E709
			public NativeArray<float4> uvScaleBiases
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_uvScaleBiases);
					return new NativeArray<float4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_uvScaleBiases), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A3D RID: 2621
			// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x00075DB8 File Offset: 0x00073FB8
			// (set) Token: 0x06001CB8 RID: 7352 RVA: 0x00010537 File Offset: 0x0000E737
			public NativeArray<int> layerMasks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_layerMasks);
					return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_layerMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A3E RID: 2622
			// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x00075DE8 File Offset: 0x00073FE8
			// (set) Token: 0x06001CBA RID: 7354 RVA: 0x00010565 File Offset: 0x0000E765
			public NativeArray<ulong> sceneLayerMasks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_sceneLayerMasks);
					return new NativeArray<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ulong>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_sceneLayerMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ulong>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00075E18 File Offset: 0x00074018
			// (set) Token: 0x06001CBC RID: 7356 RVA: 0x00010593 File Offset: 0x0000E793
			public NativeArray<float> fadeFactors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_fadeFactors);
					return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_fadeFactors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x06001CBD RID: 7357 RVA: 0x00075E48 File Offset: 0x00074048
			// (set) Token: 0x06001CBE RID: 7358 RVA: 0x000105C1 File Offset: 0x0000E7C1
			public NativeArray<BoundingSphere> boundingSpheres
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_boundingSpheres);
					return new NativeArray<BoundingSphere>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<BoundingSphere>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_boundingSpheres), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<BoundingSphere>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00075E78 File Offset: 0x00074078
			// (set) Token: 0x06001CC0 RID: 7360 RVA: 0x000105EF File Offset: 0x0000E7EF
			public NativeArray<uint> renderingLayerMasks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_renderingLayerMasks);
					return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_renderingLayerMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A42 RID: 2626
			// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00075EA8 File Offset: 0x000740A8
			// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x0001061D File Offset: 0x0000E81D
			public unsafe Vector3 cameraPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_cameraPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_cameraPosition)) = value;
				}
			}

			// Token: 0x17000A43 RID: 2627
			// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00075ED0 File Offset: 0x000740D0
			// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x00010638 File Offset: 0x0000E838
			public unsafe ulong sceneCullingMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_sceneCullingMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_sceneCullingMask)) = value;
				}
			}

			// Token: 0x17000A44 RID: 2628
			// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00075EF8 File Offset: 0x000740F8
			// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x00010653 File Offset: 0x0000E853
			public unsafe int cullingMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_cullingMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_cullingMask)) = value;
				}
			}

			// Token: 0x17000A45 RID: 2629
			// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00075F20 File Offset: 0x00074120
			// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x0001066E File Offset: 0x0000E86E
			public NativeArray<int> visibleDecalIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_visibleDecalIndices);
					return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_visibleDecalIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A46 RID: 2630
			// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00075F50 File Offset: 0x00074150
			// (set) Token: 0x06001CCA RID: 7370 RVA: 0x0001069C File Offset: 0x0000E89C
			public unsafe int visibleDecalCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_visibleDecalCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_visibleDecalCount)) = value;
				}
			}

			// Token: 0x17000A47 RID: 2631
			// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00075F78 File Offset: 0x00074178
			// (set) Token: 0x06001CCC RID: 7372 RVA: 0x000106B7 File Offset: 0x0000E8B7
			public unsafe float maxDrawDistance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_maxDrawDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_maxDrawDistance)) = value;
				}
			}

			// Token: 0x17000A48 RID: 2632
			// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00075FA0 File Offset: 0x000741A0
			// (set) Token: 0x06001CCE RID: 7374 RVA: 0x000106D2 File Offset: 0x0000E8D2
			public NativeArray<float4x4> decalToWorldsDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_decalToWorldsDraw);
					return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_decalToWorldsDraw), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x06001CCF RID: 7375 RVA: 0x00075FD0 File Offset: 0x000741D0
			// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x00010700 File Offset: 0x0000E900
			public NativeArray<float4x4> normalToDecalsDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_normalToDecalsDraw);
					return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_normalToDecalsDraw), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x00076000 File Offset: 0x00074200
			// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x0001072E File Offset: 0x0000E92E
			public NativeArray<float> renderingLayerMasksDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_renderingLayerMasksDraw);
					return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_renderingLayerMasksDraw), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A4B RID: 2635
			// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x00076030 File Offset: 0x00074230
			// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x0001075C File Offset: 0x0000E95C
			public NativeArray<DecalSubDrawCall> subCalls
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_subCalls);
					return new NativeArray<DecalSubDrawCall>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<DecalSubDrawCall>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_subCalls), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<DecalSubDrawCall>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A4C RID: 2636
			// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x00076060 File Offset: 0x00074260
			// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x0001078A File Offset: 0x0000E98A
			public NativeArray<int> subCallCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_subCallCount);
					return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalCreateDrawCallSystem.DrawCallJob.NativeFieldInfoPtr_subCallCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014D2 RID: 5330
			private static readonly IntPtr NativeFieldInfoPtr_decalToWorlds;

			// Token: 0x040014D3 RID: 5331
			private static readonly IntPtr NativeFieldInfoPtr_normalToWorlds;

			// Token: 0x040014D4 RID: 5332
			private static readonly IntPtr NativeFieldInfoPtr_sizeOffsets;

			// Token: 0x040014D5 RID: 5333
			private static readonly IntPtr NativeFieldInfoPtr_drawDistances;

			// Token: 0x040014D6 RID: 5334
			private static readonly IntPtr NativeFieldInfoPtr_angleFades;

			// Token: 0x040014D7 RID: 5335
			private static readonly IntPtr NativeFieldInfoPtr_uvScaleBiases;

			// Token: 0x040014D8 RID: 5336
			private static readonly IntPtr NativeFieldInfoPtr_layerMasks;

			// Token: 0x040014D9 RID: 5337
			private static readonly IntPtr NativeFieldInfoPtr_sceneLayerMasks;

			// Token: 0x040014DA RID: 5338
			private static readonly IntPtr NativeFieldInfoPtr_fadeFactors;

			// Token: 0x040014DB RID: 5339
			private static readonly IntPtr NativeFieldInfoPtr_boundingSpheres;

			// Token: 0x040014DC RID: 5340
			private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMasks;

			// Token: 0x040014DD RID: 5341
			private static readonly IntPtr NativeFieldInfoPtr_cameraPosition;

			// Token: 0x040014DE RID: 5342
			private static readonly IntPtr NativeFieldInfoPtr_sceneCullingMask;

			// Token: 0x040014DF RID: 5343
			private static readonly IntPtr NativeFieldInfoPtr_cullingMask;

			// Token: 0x040014E0 RID: 5344
			private static readonly IntPtr NativeFieldInfoPtr_visibleDecalIndices;

			// Token: 0x040014E1 RID: 5345
			private static readonly IntPtr NativeFieldInfoPtr_visibleDecalCount;

			// Token: 0x040014E2 RID: 5346
			private static readonly IntPtr NativeFieldInfoPtr_maxDrawDistance;

			// Token: 0x040014E3 RID: 5347
			private static readonly IntPtr NativeFieldInfoPtr_decalToWorldsDraw;

			// Token: 0x040014E4 RID: 5348
			private static readonly IntPtr NativeFieldInfoPtr_normalToDecalsDraw;

			// Token: 0x040014E5 RID: 5349
			private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMasksDraw;

			// Token: 0x040014E6 RID: 5350
			private static readonly IntPtr NativeFieldInfoPtr_subCalls;

			// Token: 0x040014E7 RID: 5351
			private static readonly IntPtr NativeFieldInfoPtr_subCallCount;

			// Token: 0x040014E8 RID: 5352
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
		}
	}
}
