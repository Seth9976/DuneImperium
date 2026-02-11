using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000071 RID: 113
	public class DecalEntityManager : Object
	{
		// Token: 0x0600099F RID: 2463 RVA: 0x00036944 File Offset: 0x00034B44
		// Note: this type is marked as 'beforefieldinit'.
		static DecalEntityManager()
		{
			Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalEntityManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr);
			DecalEntityManager.NativeFieldInfoPtr_entityChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "entityChunks");
			DecalEntityManager.NativeFieldInfoPtr_cachedChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "cachedChunks");
			DecalEntityManager.NativeFieldInfoPtr_culledChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "culledChunks");
			DecalEntityManager.NativeFieldInfoPtr_drawCallChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "drawCallChunks");
			DecalEntityManager.NativeFieldInfoPtr_chunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "chunkCount");
			DecalEntityManager.NativeFieldInfoPtr_m_AddDecalSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "m_AddDecalSampler");
			DecalEntityManager.NativeFieldInfoPtr_m_ResizeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "m_ResizeChunks");
			DecalEntityManager.NativeFieldInfoPtr_m_SortChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "m_SortChunks");
			DecalEntityManager.NativeFieldInfoPtr_m_DecalEntityIndexer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "m_DecalEntityIndexer");
			DecalEntityManager.NativeFieldInfoPtr_m_MaterialToChunkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "m_MaterialToChunkIndex");
			DecalEntityManager.NativeFieldInfoPtr_m_CombinedChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "m_CombinedChunks");
			DecalEntityManager.NativeFieldInfoPtr_m_CombinedChunkRemmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "m_CombinedChunkRemmap");
			DecalEntityManager.NativeFieldInfoPtr_m_ErrorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "m_ErrorMaterial");
			DecalEntityManager.NativeFieldInfoPtr_m_DecalProjectorMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "m_DecalProjectorMesh");
			DecalEntityManager.NativeMethodInfoPtr_get_errorMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664593);
			DecalEntityManager.NativeMethodInfoPtr_get_decalProjectorMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664594);
			DecalEntityManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664595);
			DecalEntityManager.NativeMethodInfoPtr_IsValid_Public_Boolean_DecalEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664596);
			DecalEntityManager.NativeMethodInfoPtr_CreateDecalEntity_Public_DecalEntity_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664597);
			DecalEntityManager.NativeMethodInfoPtr_CreateChunkIndex_Private_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664598);
			DecalEntityManager.NativeMethodInfoPtr_UpdateAllDecalEntitiesData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664599);
			DecalEntityManager.NativeMethodInfoPtr_UpdateDecalEntityData_Public_Void_DecalEntity_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664600);
			DecalEntityManager.NativeMethodInfoPtr_DestroyDecalEntity_Public_Void_DecalEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664601);
			DecalEntityManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664602);
			DecalEntityManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, 100664603);
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00036B68 File Offset: 0x00034D68
		public unsafe Material errorMaterial
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 607143, RefRangeEnd = 607146, XrefRangeStart = 607131, XrefRangeEnd = 607143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr_get_errorMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00036BA8 File Offset: 0x00034DA8
		public unsafe Mesh decalProjectorMesh
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 607155, RefRangeEnd = 607159, XrefRangeStart = 607146, XrefRangeEnd = 607155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr_get_decalProjectorMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00036BE8 File Offset: 0x00034DE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607247, RefRangeEnd = 607248, XrefRangeStart = 607159, XrefRangeEnd = 607247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalEntityManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00036C24 File Offset: 0x00034E24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 607250, RefRangeEnd = 607254, XrefRangeStart = 607248, XrefRangeEnd = 607250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid(DecalEntity decalEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref decalEntity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr_IsValid_Public_Boolean_DecalEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00036C70 File Offset: 0x00034E70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 607296, RefRangeEnd = 607299, XrefRangeStart = 607254, XrefRangeEnd = 607296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalEntity CreateDecalEntity(DecalProjector decalProjector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalProjector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr_CreateDecalEntity_Public_DecalEntity_DecalProjector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00036CC0 File Offset: 0x00034EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607320, RefRangeEnd = 607321, XrefRangeStart = 607299, XrefRangeEnd = 607320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CreateChunkIndex(Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr_CreateChunkIndex_Private_Int32_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00036D10 File Offset: 0x00034F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607341, RefRangeEnd = 607342, XrefRangeStart = 607321, XrefRangeEnd = 607341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAllDecalEntitiesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr_UpdateAllDecalEntitiesData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00036D44 File Offset: 0x00034F44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 607373, RefRangeEnd = 607376, XrefRangeStart = 607342, XrefRangeEnd = 607373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDecalEntityData(DecalEntity decalEntity, DecalProjector decalProjector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref decalEntity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decalProjector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr_UpdateDecalEntityData_Public_Void_DecalEntity_DecalProjector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00036D94 File Offset: 0x00034F94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 607407, RefRangeEnd = 607409, XrefRangeStart = 607376, XrefRangeEnd = 607407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDecalEntity(DecalEntity decalEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref decalEntity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr_DestroyDecalEntity_Public_Void_DecalEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00036DD4 File Offset: 0x00034FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607538, RefRangeEnd = 607539, XrefRangeStart = 607409, XrefRangeEnd = 607538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00036E08 File Offset: 0x00035008
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 607661, RefRangeEnd = 607664, XrefRangeStart = 607539, XrefRangeEnd = 607661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00006320 File Offset: 0x00004520
		public DecalEntityManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00036E3C File Offset: 0x0003503C
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00006329 File Offset: 0x00004529
		public unsafe List<DecalEntityChunk> entityChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_entityChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DecalEntityChunk>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_entityChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00036E6C File Offset: 0x0003506C
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x00006348 File Offset: 0x00004548
		public unsafe List<DecalCachedChunk> cachedChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_cachedChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DecalCachedChunk>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_cachedChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00036E9C File Offset: 0x0003509C
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x00006367 File Offset: 0x00004567
		public unsafe List<DecalCulledChunk> culledChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_culledChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DecalCulledChunk>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_culledChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x00036ECC File Offset: 0x000350CC
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x00006386 File Offset: 0x00004586
		public unsafe List<DecalDrawCallChunk> drawCallChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_drawCallChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DecalDrawCallChunk>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_drawCallChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00036EFC File Offset: 0x000350FC
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x000063A5 File Offset: 0x000045A5
		public unsafe int chunkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_chunkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_chunkCount)) = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00036F24 File Offset: 0x00035124
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x000063C0 File Offset: 0x000045C0
		public unsafe ProfilingSampler m_AddDecalSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_AddDecalSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_AddDecalSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00036F54 File Offset: 0x00035154
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x000063DF File Offset: 0x000045DF
		public unsafe ProfilingSampler m_ResizeChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_ResizeChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_ResizeChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00036F84 File Offset: 0x00035184
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x000063FE File Offset: 0x000045FE
		public unsafe ProfilingSampler m_SortChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_SortChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_SortChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00036FB4 File Offset: 0x000351B4
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x0000641D File Offset: 0x0000461D
		public unsafe DecalEntityIndexer m_DecalEntityIndexer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_DecalEntityIndexer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityIndexer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_DecalEntityIndexer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00036FE4 File Offset: 0x000351E4
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x0000643C File Offset: 0x0000463C
		public unsafe Dictionary<Material, int> m_MaterialToChunkIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_MaterialToChunkIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Material, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_MaterialToChunkIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00037014 File Offset: 0x00035214
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x0000645B File Offset: 0x0000465B
		public unsafe List<DecalEntityManager.CombinedChunks> m_CombinedChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_CombinedChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DecalEntityManager.CombinedChunks>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_CombinedChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00037044 File Offset: 0x00035244
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0000647A File Offset: 0x0000467A
		public unsafe List<int> m_CombinedChunkRemmap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_CombinedChunkRemmap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_CombinedChunkRemmap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00037074 File Offset: 0x00035274
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x00006499 File Offset: 0x00004699
		public unsafe Material m_ErrorMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_ErrorMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_ErrorMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x000370A4 File Offset: 0x000352A4
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x000064B8 File Offset: 0x000046B8
		public unsafe Mesh m_DecalProjectorMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_DecalProjectorMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.NativeFieldInfoPtr_m_DecalProjectorMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_entityChunks;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_cachedChunks;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_culledChunks;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeFieldInfoPtr_drawCallChunks;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeFieldInfoPtr_chunkCount;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_m_AddDecalSampler;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr_m_ResizeChunks;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr_m_SortChunks;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalEntityIndexer;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialToChunkIndex;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr_m_CombinedChunks;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr_m_CombinedChunkRemmap;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr_m_ErrorMaterial;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr_m_DecalProjectorMesh;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_get_errorMaterial_Public_get_Material_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_get_decalProjectorMesh_Public_get_Mesh_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_DecalEntity_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecalEntity_Public_DecalEntity_DecalProjector_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_CreateChunkIndex_Private_Int32_Material_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAllDecalEntitiesData_Public_Void_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDecalEntityData_Public_Void_DecalEntity_DecalProjector_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDecalEntity_Public_Void_DecalEntity_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000182 RID: 386
		public sealed class CombinedChunks : ValueType
		{
			// Token: 0x06001CD9 RID: 7385 RVA: 0x000760F8 File Offset: 0x000742F8
			// Note: this type is marked as 'beforefieldinit'.
			static CombinedChunks()
			{
				Il2CppClassPointerStore<DecalEntityManager.CombinedChunks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "CombinedChunks");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalEntityManager.CombinedChunks>.NativeClassPtr);
				DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_entityChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager.CombinedChunks>.NativeClassPtr, "entityChunk");
				DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_cachedChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager.CombinedChunks>.NativeClassPtr, "cachedChunk");
				DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_culledChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager.CombinedChunks>.NativeClassPtr, "culledChunk");
				DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_drawCallChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager.CombinedChunks>.NativeClassPtr, "drawCallChunk");
				DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_previousChunkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager.CombinedChunks>.NativeClassPtr, "previousChunkIndex");
				DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager.CombinedChunks>.NativeClassPtr, "valid");
			}

			// Token: 0x06001CDA RID: 7386 RVA: 0x000107CA File Offset: 0x0000E9CA
			public CombinedChunks(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001CDB RID: 7387 RVA: 0x000107D3 File Offset: 0x0000E9D3
			public CombinedChunks()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalEntityManager.CombinedChunks>.NativeClassPtr))
			{
			}

			// Token: 0x17000A4D RID: 2637
			// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0007619C File Offset: 0x0007439C
			// (set) Token: 0x06001CDD RID: 7389 RVA: 0x000107E5 File Offset: 0x0000E9E5
			public unsafe DecalEntityChunk entityChunk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_entityChunk);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityChunk>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_entityChunk), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A4E RID: 2638
			// (get) Token: 0x06001CDE RID: 7390 RVA: 0x000761CC File Offset: 0x000743CC
			// (set) Token: 0x06001CDF RID: 7391 RVA: 0x00010804 File Offset: 0x0000EA04
			public unsafe DecalCachedChunk cachedChunk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_cachedChunk);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalCachedChunk>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_cachedChunk), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A4F RID: 2639
			// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000761FC File Offset: 0x000743FC
			// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x00010823 File Offset: 0x0000EA23
			public unsafe DecalCulledChunk culledChunk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_culledChunk);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalCulledChunk>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_culledChunk), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A50 RID: 2640
			// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0007622C File Offset: 0x0007442C
			// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x00010842 File Offset: 0x0000EA42
			public unsafe DecalDrawCallChunk drawCallChunk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_drawCallChunk);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalDrawCallChunk>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_drawCallChunk), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A51 RID: 2641
			// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x0007625C File Offset: 0x0007445C
			// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x00010861 File Offset: 0x0000EA61
			public unsafe int previousChunkIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_previousChunkIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_previousChunkIndex)) = value;
				}
			}

			// Token: 0x17000A52 RID: 2642
			// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00076284 File Offset: 0x00074484
			// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0001087C File Offset: 0x0000EA7C
			public unsafe bool valid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_valid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalEntityManager.CombinedChunks.NativeFieldInfoPtr_valid)) = value;
				}
			}

			// Token: 0x040014EF RID: 5359
			private static readonly IntPtr NativeFieldInfoPtr_entityChunk;

			// Token: 0x040014F0 RID: 5360
			private static readonly IntPtr NativeFieldInfoPtr_cachedChunk;

			// Token: 0x040014F1 RID: 5361
			private static readonly IntPtr NativeFieldInfoPtr_culledChunk;

			// Token: 0x040014F2 RID: 5362
			private static readonly IntPtr NativeFieldInfoPtr_drawCallChunk;

			// Token: 0x040014F3 RID: 5363
			private static readonly IntPtr NativeFieldInfoPtr_previousChunkIndex;

			// Token: 0x040014F4 RID: 5364
			private static readonly IntPtr NativeFieldInfoPtr_valid;
		}

		// Token: 0x02000183 RID: 387
		[ObfuscatedName("UnityEngine.Rendering.Universal.DecalEntityManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001CE8 RID: 7400 RVA: 0x000762AC File Offset: 0x000744AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DecalEntityManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalEntityManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalEntityManager.__c>.NativeClassPtr);
				DecalEntityManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager.__c>.NativeClassPtr, "<>9");
				DecalEntityManager.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityManager.__c>.NativeClassPtr, "<>9__26_0");
				DecalEntityManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager.__c>.NativeClassPtr, 100664605);
				DecalEntityManager.__c.NativeMethodInfoPtr__Update_b__26_0_Internal_Int32_CombinedChunks_CombinedChunks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityManager.__c>.NativeClassPtr, 100664606);
			}

			// Token: 0x06001CE9 RID: 7401 RVA: 0x00076328 File Offset: 0x00074528
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalEntityManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CEA RID: 7402 RVA: 0x00076364 File Offset: 0x00074564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607130, XrefRangeEnd = 607131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Update_b__26_0(DecalEntityManager.CombinedChunks a, DecalEntityManager.CombinedChunks b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalEntityManager.__c.NativeMethodInfoPtr__Update_b__26_0_Internal_Int32_CombinedChunks_CombinedChunks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001CEB RID: 7403 RVA: 0x00010897 File Offset: 0x0000EA97
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A53 RID: 2643
			// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000763D0 File Offset: 0x000745D0
			// (set) Token: 0x06001CED RID: 7405 RVA: 0x000108A0 File Offset: 0x0000EAA0
			public unsafe static DecalEntityManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecalEntityManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecalEntityManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A54 RID: 2644
			// (get) Token: 0x06001CEE RID: 7406 RVA: 0x000763F8 File Offset: 0x000745F8
			// (set) Token: 0x06001CEF RID: 7407 RVA: 0x000108B2 File Offset: 0x0000EAB2
			public unsafe static Comparison<DecalEntityManager.CombinedChunks> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecalEntityManager.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<DecalEntityManager.CombinedChunks>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecalEntityManager.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014F5 RID: 5365
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014F6 RID: 5366
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x040014F7 RID: 5367
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014F8 RID: 5368
			private static readonly IntPtr NativeMethodInfoPtr__Update_b__26_0_Internal_Int32_CombinedChunks_CombinedChunks_0;
		}
	}
}
