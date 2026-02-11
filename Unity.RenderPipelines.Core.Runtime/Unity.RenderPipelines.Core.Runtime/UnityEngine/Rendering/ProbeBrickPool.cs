using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x02000083 RID: 131
	public class ProbeBrickPool : Object
	{
		// Token: 0x060008D3 RID: 2259 RVA: 0x0002E884 File Offset: 0x0002CA84
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeBrickPool()
		{
			Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeBrickPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr);
			ProbeBrickPool.NativeFieldInfoPtr_kProbePoolChunkSizeInBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kProbePoolChunkSizeInBricks");
			ProbeBrickPool.NativeFieldInfoPtr_kBrickCellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kBrickCellCount");
			ProbeBrickPool.NativeFieldInfoPtr_kBrickProbeCountPerDim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kBrickProbeCountPerDim");
			ProbeBrickPool.NativeFieldInfoPtr_kBrickProbeCountTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kBrickProbeCountTotal");
			ProbeBrickPool.NativeFieldInfoPtr_kChunkProbeCountPerDim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kChunkProbeCountPerDim");
			ProbeBrickPool.NativeFieldInfoPtr__estimatedVMemCost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "<estimatedVMemCost>k__BackingField");
			ProbeBrickPool.NativeFieldInfoPtr_kMaxPoolWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kMaxPoolWidth");
			ProbeBrickPool.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_Pool");
			ProbeBrickPool.NativeFieldInfoPtr_m_NextFreeChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_NextFreeChunk");
			ProbeBrickPool.NativeFieldInfoPtr_m_FreeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_FreeList");
			ProbeBrickPool.NativeFieldInfoPtr_m_AvailableChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_AvailableChunkCount");
			ProbeBrickPool.NativeFieldInfoPtr_m_SHBands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_SHBands");
			ProbeBrickPool.NativeFieldInfoPtr_m_ContainsValidity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_ContainsValidity");
			ProbeBrickPool.NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664686);
			ProbeBrickPool.NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664687);
			ProbeBrickPool.NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_ProbeVolumeSHBands_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664688);
			ProbeBrickPool.NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664689);
			ProbeBrickPool.NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664690);
			ProbeBrickPool.NativeMethodInfoPtr_GetChunkSizeInBrickCount_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664691);
			ProbeBrickPool.NativeMethodInfoPtr_GetChunkSizeInProbeCount_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664692);
			ProbeBrickPool.NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664693);
			ProbeBrickPool.NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664694);
			ProbeBrickPool.NativeMethodInfoPtr_GetPoolDimensions_Internal_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664695);
			ProbeBrickPool.NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664696);
			ProbeBrickPool.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664697);
			ProbeBrickPool.NativeMethodInfoPtr_GetChunkCount_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664698);
			ProbeBrickPool.NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664699);
			ProbeBrickPool.NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664700);
			ProbeBrickPool.NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664701);
			ProbeBrickPool.NativeMethodInfoPtr_UpdateValidity_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664702);
			ProbeBrickPool.NativeMethodInfoPtr_ProbeCountToDataLocSize_Internal_Static_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664703);
			ProbeBrickPool.NativeMethodInfoPtr_CreateDataTexture_Public_Static_Texture_Int32_Int32_Int32_GraphicsFormat_String_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664704);
			ProbeBrickPool.NativeMethodInfoPtr_CreateDataLocation_Public_Static_DataLocation_Int32_Boolean_ProbeVolumeSHBands_String_Boolean_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664705);
			ProbeBrickPool.NativeMethodInfoPtr_DerivePoolSizeFromBudget_Private_Void_ProbeVolumeTextureMemoryBudget_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664706);
			ProbeBrickPool.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100664707);
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0002EB70 File Offset: 0x0002CD70
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x0002EBAC File Offset: 0x0002CDAC
		public unsafe int estimatedVMemCost
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0002EBEC File Offset: 0x0002CDEC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 966556, RefRangeEnd = 966563, XrefRangeStart = 966544, XrefRangeEnd = 966556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeBrickPool(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool allocateValidityData = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref memoryBudget;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shBands;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocateValidityData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_ProbeVolumeSHBands_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0002EC50 File Offset: 0x0002CE50
		[CallerCount(0)]
		public unsafe int GetRemainingChunkCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0002EC8C File Offset: 0x0002CE8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 966572, RefRangeEnd = 966577, XrefRangeStart = 966563, XrefRangeEnd = 966572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureTextureValidity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0002ECC0 File Offset: 0x0002CEC0
		[CallerCount(0)]
		public unsafe static int GetChunkSizeInBrickCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_GetChunkSizeInBrickCount_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0002ECF0 File Offset: 0x0002CEF0
		[CallerCount(0)]
		public unsafe static int GetChunkSizeInProbeCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_GetChunkSizeInProbeCount_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0002ED20 File Offset: 0x0002CF20
		[CallerCount(0)]
		public unsafe int GetPoolWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0002ED5C File Offset: 0x0002CF5C
		[CallerCount(0)]
		public unsafe int GetPoolHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0002ED98 File Offset: 0x0002CF98
		[CallerCount(0)]
		public unsafe Vector3Int GetPoolDimensions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_GetPoolDimensions_Internal_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0002EDD4 File Offset: 0x0002CFD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966621, RefRangeEnd = 966622, XrefRangeStart = 966577, XrefRangeEnd = 966621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(rr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0002EE18 File Offset: 0x0002D018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966622, XrefRangeEnd = 966625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0002EE4C File Offset: 0x0002D04C
		[CallerCount(0)]
		public unsafe static int GetChunkCount(int brickCount, int chunkSizeInBricks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref brickCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chunkSizeInBricks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_GetChunkCount_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0002EE98 File Offset: 0x0002D098
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 966638, RefRangeEnd = 966641, XrefRangeStart = 966625, XrefRangeEnd = 966638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Allocate(int numberOfBrickChunks, List<ProbeBrickPool.BrickChunkAlloc> outAllocations, bool ignoreErrorLog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numberOfBrickChunks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outAllocations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrorLog;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0002EF04 File Offset: 0x0002D104
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 966659, RefRangeEnd = 966666, XrefRangeStart = 966641, XrefRangeEnd = 966659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deallocate(List<ProbeBrickPool.BrickChunkAlloc> allocations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allocations);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0002EF48 File Offset: 0x0002D148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966688, RefRangeEnd = 966690, XrefRangeStart = 966666, XrefRangeEnd = 966688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(srcLocations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dstLocations);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destStartIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bands;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0002EFD0 File Offset: 0x0002D1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966690, XrefRangeEnd = 966701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValidity(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(srcLocations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dstLocations);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destStartIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_UpdateValidity_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0002F04C File Offset: 0x0002D24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966701, XrefRangeEnd = 966702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3Int ProbeCountToDataLocSize(int numProbes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numProbes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_ProbeCountToDataLocSize_Internal_Static_Vector3Int_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0002F08C File Offset: 0x0002D28C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 966718, RefRangeEnd = 966725, XrefRangeStart = 966702, XrefRangeEnd = 966718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Texture CreateDataTexture(int width, int height, int depth, GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocateRendertexture;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allocatedBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_CreateDataTexture_Public_Static_Texture_Int32_Int32_Int32_GraphicsFormat_String_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0002F128 File Offset: 0x0002D328
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 966781, RefRangeEnd = 966784, XrefRangeStart = 966725, XrefRangeEnd = 966781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProbeBrickPool.DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, out int allocatedBytes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numProbes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bands;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocateRendertexture;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocateValidityData;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allocatedBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_CreateDataLocation_Public_Static_DataLocation_Int32_Boolean_ProbeVolumeSHBands_String_Boolean_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ProbeBrickPool.DataLocation(intPtr);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0002F1BC File Offset: 0x0002D3BC
		[CallerCount(0)]
		public unsafe void DerivePoolSizeFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref memoryBudget;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_DerivePoolSizeFromBudget_Private_Void_ProbeVolumeTextureMemoryBudget_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0002F228 File Offset: 0x0002D428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966784, XrefRangeEnd = 966785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00005835 File Offset: 0x00003A35
		public ProbeBrickPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x0002F25C File Offset: 0x0002D45C
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x0000583E File Offset: 0x00003A3E
		public unsafe static int kProbePoolChunkSizeInBricks
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickPool.NativeFieldInfoPtr_kProbePoolChunkSizeInBricks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickPool.NativeFieldInfoPtr_kProbePoolChunkSizeInBricks, (void*)(&value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0002F278 File Offset: 0x0002D478
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x0000584C File Offset: 0x00003A4C
		public unsafe static int kBrickCellCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickPool.NativeFieldInfoPtr_kBrickCellCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickPool.NativeFieldInfoPtr_kBrickCellCount, (void*)(&value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0002F294 File Offset: 0x0002D494
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x0000585A File Offset: 0x00003A5A
		public unsafe static int kBrickProbeCountPerDim
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickPool.NativeFieldInfoPtr_kBrickProbeCountPerDim, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickPool.NativeFieldInfoPtr_kBrickProbeCountPerDim, (void*)(&value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0002F2B0 File Offset: 0x0002D4B0
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00005868 File Offset: 0x00003A68
		public unsafe static int kBrickProbeCountTotal
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickPool.NativeFieldInfoPtr_kBrickProbeCountTotal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickPool.NativeFieldInfoPtr_kBrickProbeCountTotal, (void*)(&value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0002F2CC File Offset: 0x0002D4CC
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00005876 File Offset: 0x00003A76
		public unsafe static int kChunkProbeCountPerDim
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickPool.NativeFieldInfoPtr_kChunkProbeCountPerDim, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickPool.NativeFieldInfoPtr_kChunkProbeCountPerDim, (void*)(&value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0002F2E8 File Offset: 0x0002D4E8
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00005884 File Offset: 0x00003A84
		public unsafe int _estimatedVMemCost_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr__estimatedVMemCost_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr__estimatedVMemCost_k__BackingField)) = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0002F310 File Offset: 0x0002D510
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x0000589F File Offset: 0x00003A9F
		public unsafe static int kMaxPoolWidth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickPool.NativeFieldInfoPtr_kMaxPoolWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickPool.NativeFieldInfoPtr_kMaxPoolWidth, (void*)(&value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0002F32C File Offset: 0x0002D52C
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x000058AD File Offset: 0x00003AAD
		public ProbeBrickPool.DataLocation m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_Pool);
				return new ProbeBrickPool.DataLocation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_Pool), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0002F35C File Offset: 0x0002D55C
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x000058DB File Offset: 0x00003ADB
		public unsafe ProbeBrickPool.BrickChunkAlloc m_NextFreeChunk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_NextFreeChunk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_NextFreeChunk)) = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0002F384 File Offset: 0x0002D584
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x000058F6 File Offset: 0x00003AF6
		public unsafe Stack<ProbeBrickPool.BrickChunkAlloc> m_FreeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_FreeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ProbeBrickPool.BrickChunkAlloc>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_FreeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x0002F3B4 File Offset: 0x0002D5B4
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00005915 File Offset: 0x00003B15
		public unsafe int m_AvailableChunkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_AvailableChunkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_AvailableChunkCount)) = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x0002F3DC File Offset: 0x0002D5DC
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00005930 File Offset: 0x00003B30
		public unsafe ProbeVolumeSHBands m_SHBands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_SHBands);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_SHBands)) = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x0002F404 File Offset: 0x0002D604
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x0000594B File Offset: 0x00003B4B
		public unsafe bool m_ContainsValidity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_ContainsValidity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.NativeFieldInfoPtr_m_ContainsValidity)) = value;
			}
		}

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeFieldInfoPtr_kProbePoolChunkSizeInBricks;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeFieldInfoPtr_kBrickCellCount;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeFieldInfoPtr_kBrickProbeCountPerDim;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeFieldInfoPtr_kBrickProbeCountTotal;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeFieldInfoPtr_kChunkProbeCountPerDim;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeFieldInfoPtr__estimatedVMemCost_k__BackingField;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeFieldInfoPtr_kMaxPoolWidth;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeFieldInfoPtr_m_NextFreeChunk;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_m_FreeList;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableChunkCount;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeFieldInfoPtr_m_SHBands;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeFieldInfoPtr_m_ContainsValidity;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_ProbeVolumeSHBands_Boolean_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_GetChunkSizeInBrickCount_Internal_Static_Int32_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_GetChunkSizeInProbeCount_Internal_Static_Int32_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_GetPoolDimensions_Internal_Vector3Int_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_GetChunkCount_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_Boolean_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValidity_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_ProbeCountToDataLocSize_Internal_Static_Vector3Int_Int32_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_CreateDataTexture_Public_Static_Texture_Int32_Int32_Int32_GraphicsFormat_String_Boolean_byref_Int32_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_CreateDataLocation_Public_Static_DataLocation_Int32_Boolean_ProbeVolumeSHBands_String_Boolean_Boolean_byref_Int32_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_DerivePoolSizeFromBudget_Private_Void_ProbeVolumeTextureMemoryBudget_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		// Token: 0x020001C1 RID: 449
		[StructLayout(2)]
		public struct BrickChunkAlloc
		{
			// Token: 0x06001896 RID: 6294 RVA: 0x0006802C File Offset: 0x0006622C
			// Note: this type is marked as 'beforefieldinit'.
			static BrickChunkAlloc()
			{
				Il2CppClassPointerStore<ProbeBrickPool.BrickChunkAlloc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "BrickChunkAlloc");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickPool.BrickChunkAlloc>.NativeClassPtr);
				ProbeBrickPool.BrickChunkAlloc.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.BrickChunkAlloc>.NativeClassPtr, "x");
				ProbeBrickPool.BrickChunkAlloc.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.BrickChunkAlloc>.NativeClassPtr, "y");
				ProbeBrickPool.BrickChunkAlloc.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.BrickChunkAlloc>.NativeClassPtr, "z");
				ProbeBrickPool.BrickChunkAlloc.NativeMethodInfoPtr_flattenIndex_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool.BrickChunkAlloc>.NativeClassPtr, 100664708);
			}

			// Token: 0x06001897 RID: 6295 RVA: 0x000680A8 File Offset: 0x000662A8
			[CallerCount(0)]
			public unsafe int flattenIndex(int sx, int sy)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sx;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.BrickChunkAlloc.NativeMethodInfoPtr_flattenIndex_Internal_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001898 RID: 6296 RVA: 0x0000C33B File Offset: 0x0000A53B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeBrickPool.BrickChunkAlloc>.NativeClassPtr, ref this));
			}

			// Token: 0x040011D2 RID: 4562
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x040011D3 RID: 4563
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x040011D4 RID: 4564
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x040011D5 RID: 4565
			private static readonly IntPtr NativeMethodInfoPtr_flattenIndex_Internal_Int32_Int32_Int32_0;

			// Token: 0x040011D6 RID: 4566
			[FieldOffset(0)]
			public int x;

			// Token: 0x040011D7 RID: 4567
			[FieldOffset(4)]
			public int y;

			// Token: 0x040011D8 RID: 4568
			[FieldOffset(8)]
			public int z;
		}

		// Token: 0x020001C2 RID: 450
		public sealed class DataLocation : ValueType
		{
			// Token: 0x06001899 RID: 6297 RVA: 0x000680F4 File Offset: 0x000662F4
			// Note: this type is marked as 'beforefieldinit'.
			static DataLocation()
			{
				Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "DataLocation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr);
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL0_L1rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "TexL0_L1rx");
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL1_G_ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "TexL1_G_ry");
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL1_B_rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "TexL1_B_rz");
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "TexL2_0");
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "TexL2_1");
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "TexL2_2");
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "TexL2_3");
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexValidity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "TexValidity");
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "width");
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "height");
				ProbeBrickPool.DataLocation.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, "depth");
				ProbeBrickPool.DataLocation.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr, 100664709);
			}

			// Token: 0x0600189A RID: 6298 RVA: 0x00068210 File Offset: 0x00066410
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 966535, RefRangeEnd = 966544, XrefRangeStart = 966516, XrefRangeEnd = 966535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Cleanup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickPool.DataLocation.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600189B RID: 6299 RVA: 0x0000C34D File Offset: 0x0000A54D
			public DataLocation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600189C RID: 6300 RVA: 0x0000C356 File Offset: 0x0000A556
			public DataLocation()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeBrickPool.DataLocation>.NativeClassPtr))
			{
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x0600189D RID: 6301 RVA: 0x00068248 File Offset: 0x00066448
			// (set) Token: 0x0600189E RID: 6302 RVA: 0x0000C368 File Offset: 0x0000A568
			public unsafe Texture TexL0_L1rx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL0_L1rx);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL0_L1rx), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x0600189F RID: 6303 RVA: 0x00068278 File Offset: 0x00066478
			// (set) Token: 0x060018A0 RID: 6304 RVA: 0x0000C387 File Offset: 0x0000A587
			public unsafe Texture TexL1_G_ry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL1_G_ry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL1_G_ry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x060018A1 RID: 6305 RVA: 0x000682A8 File Offset: 0x000664A8
			// (set) Token: 0x060018A2 RID: 6306 RVA: 0x0000C3A6 File Offset: 0x0000A5A6
			public unsafe Texture TexL1_B_rz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL1_B_rz);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL1_B_rz), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x060018A3 RID: 6307 RVA: 0x000682D8 File Offset: 0x000664D8
			// (set) Token: 0x060018A4 RID: 6308 RVA: 0x0000C3C5 File Offset: 0x0000A5C5
			public unsafe Texture TexL2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EA RID: 1770
			// (get) Token: 0x060018A5 RID: 6309 RVA: 0x00068308 File Offset: 0x00066508
			// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0000C3E4 File Offset: 0x0000A5E4
			public unsafe Texture TexL2_1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EB RID: 1771
			// (get) Token: 0x060018A7 RID: 6311 RVA: 0x00068338 File Offset: 0x00066538
			// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0000C403 File Offset: 0x0000A603
			public unsafe Texture TexL2_2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EC RID: 1772
			// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00068368 File Offset: 0x00066568
			// (set) Token: 0x060018AA RID: 6314 RVA: 0x0000C422 File Offset: 0x0000A622
			public unsafe Texture TexL2_3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexL2_3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006ED RID: 1773
			// (get) Token: 0x060018AB RID: 6315 RVA: 0x00068398 File Offset: 0x00066598
			// (set) Token: 0x060018AC RID: 6316 RVA: 0x0000C441 File Offset: 0x0000A641
			public unsafe Texture3D TexValidity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexValidity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_TexValidity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006EE RID: 1774
			// (get) Token: 0x060018AD RID: 6317 RVA: 0x000683C8 File Offset: 0x000665C8
			// (set) Token: 0x060018AE RID: 6318 RVA: 0x0000C460 File Offset: 0x0000A660
			public unsafe int width
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_width);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_width)) = value;
				}
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x060018AF RID: 6319 RVA: 0x000683F0 File Offset: 0x000665F0
			// (set) Token: 0x060018B0 RID: 6320 RVA: 0x0000C47B File Offset: 0x0000A67B
			public unsafe int height
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_height);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_height)) = value;
				}
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x060018B1 RID: 6321 RVA: 0x00068418 File Offset: 0x00066618
			// (set) Token: 0x060018B2 RID: 6322 RVA: 0x0000C496 File Offset: 0x0000A696
			public unsafe int depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickPool.DataLocation.NativeFieldInfoPtr_depth)) = value;
				}
			}

			// Token: 0x040011D9 RID: 4569
			private static readonly IntPtr NativeFieldInfoPtr_TexL0_L1rx;

			// Token: 0x040011DA RID: 4570
			private static readonly IntPtr NativeFieldInfoPtr_TexL1_G_ry;

			// Token: 0x040011DB RID: 4571
			private static readonly IntPtr NativeFieldInfoPtr_TexL1_B_rz;

			// Token: 0x040011DC RID: 4572
			private static readonly IntPtr NativeFieldInfoPtr_TexL2_0;

			// Token: 0x040011DD RID: 4573
			private static readonly IntPtr NativeFieldInfoPtr_TexL2_1;

			// Token: 0x040011DE RID: 4574
			private static readonly IntPtr NativeFieldInfoPtr_TexL2_2;

			// Token: 0x040011DF RID: 4575
			private static readonly IntPtr NativeFieldInfoPtr_TexL2_3;

			// Token: 0x040011E0 RID: 4576
			private static readonly IntPtr NativeFieldInfoPtr_TexValidity;

			// Token: 0x040011E1 RID: 4577
			private static readonly IntPtr NativeFieldInfoPtr_width;

			// Token: 0x040011E2 RID: 4578
			private static readonly IntPtr NativeFieldInfoPtr_height;

			// Token: 0x040011E3 RID: 4579
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x040011E4 RID: 4580
			private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;
		}
	}
}
