using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000084 RID: 132
	public class ProbeBrickBlendingPool : Object
	{
		// Token: 0x06000905 RID: 2309 RVA: 0x0002F42C File Offset: 0x0002D62C
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeBrickBlendingPool()
		{
			Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeBrickBlendingPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr);
			ProbeBrickBlendingPool.NativeFieldInfoPtr_stateBlendShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "stateBlendShader");
			ProbeBrickBlendingPool.NativeFieldInfoPtr_scenarioBlendingKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "scenarioBlendingKernel");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__PoolDim_LerpFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_PoolDim_LerpFactor");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__ChunkList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_ChunkList");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L0_L1Rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L0_L1Rx");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L1G_L1Ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L1G_L1Ry");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L1B_L1Rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L1B_L1Rz");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L2_0");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L2_1");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L2_2");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L2_3");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L0_L1Rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L0_L1Rx");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L1G_L1Ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L1G_L1Ry");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L1B_L1Rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L1B_L1Rz");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L2_0");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L2_1");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L2_2");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L2_3");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L0_L1Rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_Out_L0_L1Rx");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L1G_L1Ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_Out_L1G_L1Ry");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L1B_L1Rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_Out_L1B_L1Rz");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_Out_L2_0");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_Out_L2_1");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_Out_L2_2");
			ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_Out_L2_3");
			ProbeBrickBlendingPool.NativeFieldInfoPtr_m_ChunkList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_ChunkList");
			ProbeBrickBlendingPool.NativeFieldInfoPtr_m_MappedChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_MappedChunks");
			ProbeBrickBlendingPool.NativeFieldInfoPtr_m_State0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_State0");
			ProbeBrickBlendingPool.NativeFieldInfoPtr_m_State1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_State1");
			ProbeBrickBlendingPool.NativeFieldInfoPtr_m_MemoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_MemoryBudget");
			ProbeBrickBlendingPool.NativeFieldInfoPtr_m_ShBands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_ShBands");
			ProbeBrickBlendingPool.NativeMethodInfoPtr_get_isSupported_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664710);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_Initialize_Internal_Static_Void_byref_ProbeVolumeSystemParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664711);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_get_isAllocated_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664712);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664713);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664714);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664715);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_GetPoolDepth_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664716);
			ProbeBrickBlendingPool.NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeBlendingTextureMemoryBudget_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664717);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_AllocateResourcesIfNeeded_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664718);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664719);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_DivRoundUp_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664720);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_PerformBlending_Internal_Void_CommandBuffer_Single_ProbeBrickPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664721);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_BlendChunks_Internal_Void_BlendingCellInfo_ProbeBrickPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664722);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664723);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664724);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664725);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664726);
			ProbeBrickBlendingPool.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100664727);
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0002F830 File Offset: 0x0002DA30
		public unsafe static bool isSupported
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 966793, RefRangeEnd = 966794, XrefRangeStart = 966785, XrefRangeEnd = 966793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_get_isSupported_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0002F860 File Offset: 0x0002DA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966794, XrefRangeEnd = 966815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize([In] ref ProbeVolumeSystemParameters parameters)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_Initialize_Internal_Static_Void_byref_ProbeVolumeSystemParameters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0002F898 File Offset: 0x0002DA98
		public unsafe bool isAllocated
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 434802, RefRangeEnd = 434827, XrefRangeStart = 434802, XrefRangeEnd = 434827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_get_isAllocated_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x0002F8D4 File Offset: 0x0002DAD4
		public unsafe int estimatedVMemCost
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0002F910 File Offset: 0x0002DB10
		[CallerCount(0)]
		public unsafe int GetPoolWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0002F94C File Offset: 0x0002DB4C
		[CallerCount(0)]
		public unsafe int GetPoolHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0002F988 File Offset: 0x0002DB88
		[CallerCount(0)]
		public unsafe int GetPoolDepth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_GetPoolDepth_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0002F9C4 File Offset: 0x0002DBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966815, XrefRangeEnd = 966816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeBrickBlendingPool(ProbeVolumeBlendingTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref memoryBudget;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shBands;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeBlendingTextureMemoryBudget_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0002FA1C File Offset: 0x0002DC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966816, XrefRangeEnd = 966829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocateResourcesIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_AllocateResourcesIfNeeded_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0002FA50 File Offset: 0x0002DC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966829, XrefRangeEnd = 966831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands, int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(srcLocations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dstLocations);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destStartIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bands;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0002FAE8 File Offset: 0x0002DCE8
		[CallerCount(0)]
		public unsafe static int DivRoundUp(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_DivRoundUp_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0002FB34 File Offset: 0x0002DD34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966916, RefRangeEnd = 966917, XrefRangeStart = 966831, XrefRangeEnd = 966916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformBlending(CommandBuffer cmd, float factor, ProbeBrickPool dstPool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref factor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dstPool);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_PerformBlending_Internal_Void_CommandBuffer_Single_ProbeBrickPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0002FB98 File Offset: 0x0002DD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966917, XrefRangeEnd = 966924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendChunks(ProbeReferenceVolume.BlendingCellInfo blendingCell, ProbeBrickPool dstPool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendingCell);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dstPool);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_BlendChunks_Internal_Void_BlendingCellInfo_ProbeBrickPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0002FBEC File Offset: 0x0002DDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966924, XrefRangeEnd = 966927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0002FC20 File Offset: 0x0002DE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966927, XrefRangeEnd = 966941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Allocate(int numberOfBrickChunks, List<ProbeBrickPool.BrickChunkAlloc> outAllocations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numberOfBrickChunks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outAllocations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0002FC7C File Offset: 0x0002DE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966941, XrefRangeEnd = 966943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deallocate(List<ProbeBrickPool.BrickChunkAlloc> allocations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allocations);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0002FCC0 File Offset: 0x0002DEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966943, XrefRangeEnd = 966945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureTextureValidity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966945, XrefRangeEnd = 966947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickBlendingPool.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00005966 File Offset: 0x00003B66
		public ProbeBrickBlendingPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0002FD28 File Offset: 0x0002DF28
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x0000596F File Offset: 0x00003B6F
		public unsafe static ComputeShader stateBlendShader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr_stateBlendShader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr_stateBlendShader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0002FD50 File Offset: 0x0002DF50
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00005981 File Offset: 0x00003B81
		public unsafe static int scenarioBlendingKernel
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr_scenarioBlendingKernel, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr_scenarioBlendingKernel, (void*)(&value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0002FD6C File Offset: 0x0002DF6C
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x0000598F File Offset: 0x00003B8F
		public unsafe static int _PoolDim_LerpFactor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__PoolDim_LerpFactor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__PoolDim_LerpFactor, (void*)(&value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0002FD88 File Offset: 0x0002DF88
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x0000599D File Offset: 0x00003B9D
		public unsafe static int _ChunkList
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__ChunkList, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__ChunkList, (void*)(&value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0002FDA4 File Offset: 0x0002DFA4
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000059AB File Offset: 0x00003BAB
		public unsafe static int _State0_L0_L1Rx
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L0_L1Rx, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L0_L1Rx, (void*)(&value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0002FDC0 File Offset: 0x0002DFC0
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x000059B9 File Offset: 0x00003BB9
		public unsafe static int _State0_L1G_L1Ry
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L1G_L1Ry, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L1G_L1Ry, (void*)(&value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0002FDDC File Offset: 0x0002DFDC
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x000059C7 File Offset: 0x00003BC7
		public unsafe static int _State0_L1B_L1Rz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L1B_L1Rz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L1B_L1Rz, (void*)(&value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0002FDF8 File Offset: 0x0002DFF8
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x000059D5 File Offset: 0x00003BD5
		public unsafe static int _State0_L2_0
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_0, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_0, (void*)(&value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0002FE14 File Offset: 0x0002E014
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x000059E3 File Offset: 0x00003BE3
		public unsafe static int _State0_L2_1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_1, (void*)(&value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0002FE30 File Offset: 0x0002E030
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x000059F1 File Offset: 0x00003BF1
		public unsafe static int _State0_L2_2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_2, (void*)(&value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0002FE4C File Offset: 0x0002E04C
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x000059FF File Offset: 0x00003BFF
		public unsafe static int _State0_L2_3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State0_L2_3, (void*)(&value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0002FE68 File Offset: 0x0002E068
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00005A0D File Offset: 0x00003C0D
		public unsafe static int _State1_L0_L1Rx
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L0_L1Rx, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L0_L1Rx, (void*)(&value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0002FE84 File Offset: 0x0002E084
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00005A1B File Offset: 0x00003C1B
		public unsafe static int _State1_L1G_L1Ry
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L1G_L1Ry, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L1G_L1Ry, (void*)(&value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0002FEA0 File Offset: 0x0002E0A0
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x00005A29 File Offset: 0x00003C29
		public unsafe static int _State1_L1B_L1Rz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L1B_L1Rz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L1B_L1Rz, (void*)(&value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0002FEBC File Offset: 0x0002E0BC
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x00005A37 File Offset: 0x00003C37
		public unsafe static int _State1_L2_0
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_0, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_0, (void*)(&value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0002FED8 File Offset: 0x0002E0D8
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x00005A45 File Offset: 0x00003C45
		public unsafe static int _State1_L2_1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_1, (void*)(&value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x00005A53 File Offset: 0x00003C53
		public unsafe static int _State1_L2_2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_2, (void*)(&value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0002FF10 File Offset: 0x0002E110
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00005A61 File Offset: 0x00003C61
		public unsafe static int _State1_L2_3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__State1_L2_3, (void*)(&value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0002FF2C File Offset: 0x0002E12C
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x00005A6F File Offset: 0x00003C6F
		public unsafe static int _Out_L0_L1Rx
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L0_L1Rx, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L0_L1Rx, (void*)(&value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0002FF48 File Offset: 0x0002E148
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x00005A7D File Offset: 0x00003C7D
		public unsafe static int _Out_L1G_L1Ry
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L1G_L1Ry, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L1G_L1Ry, (void*)(&value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0002FF64 File Offset: 0x0002E164
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00005A8B File Offset: 0x00003C8B
		public unsafe static int _Out_L1B_L1Rz
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L1B_L1Rz, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L1B_L1Rz, (void*)(&value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0002FF80 File Offset: 0x0002E180
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x00005A99 File Offset: 0x00003C99
		public unsafe static int _Out_L2_0
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_0, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_0, (void*)(&value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0002FF9C File Offset: 0x0002E19C
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x00005AA7 File Offset: 0x00003CA7
		public unsafe static int _Out_L2_1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_1, (void*)(&value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x00005AB5 File Offset: 0x00003CB5
		public unsafe static int _Out_L2_2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_2, (void*)(&value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0002FFD4 File Offset: 0x0002E1D4
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x00005AC3 File Offset: 0x00003CC3
		public unsafe static int _Out_L2_3
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickBlendingPool.NativeFieldInfoPtr__Out_L2_3, (void*)(&value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0002FFF0 File Offset: 0x0002E1F0
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x00005AD1 File Offset: 0x00003CD1
		public unsafe Il2CppStructArray<Vector4> m_ChunkList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_ChunkList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_ChunkList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x00030020 File Offset: 0x0002E220
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x00005AF0 File Offset: 0x00003CF0
		public unsafe int m_MappedChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_MappedChunks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_MappedChunks)) = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00030048 File Offset: 0x0002E248
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x00005B0B File Offset: 0x00003D0B
		public unsafe ProbeBrickPool m_State0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_State0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeBrickPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_State0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00030078 File Offset: 0x0002E278
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x00005B2A File Offset: 0x00003D2A
		public unsafe ProbeBrickPool m_State1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_State1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeBrickPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_State1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x000300A8 File Offset: 0x0002E2A8
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x00005B49 File Offset: 0x00003D49
		public unsafe ProbeVolumeTextureMemoryBudget m_MemoryBudget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_MemoryBudget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_MemoryBudget)) = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x000300D0 File Offset: 0x0002E2D0
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00005B64 File Offset: 0x00003D64
		public unsafe ProbeVolumeSHBands m_ShBands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_ShBands);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickBlendingPool.NativeFieldInfoPtr_m_ShBands)) = value;
			}
		}

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeFieldInfoPtr_stateBlendShader;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeFieldInfoPtr_scenarioBlendingKernel;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeFieldInfoPtr__PoolDim_LerpFactor;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeFieldInfoPtr__ChunkList;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeFieldInfoPtr__State0_L0_L1Rx;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeFieldInfoPtr__State0_L1G_L1Ry;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr__State0_L1B_L1Rz;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeFieldInfoPtr__State0_L2_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr__State0_L2_1;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr__State0_L2_2;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr__State0_L2_3;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr__State1_L0_L1Rx;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr__State1_L1G_L1Ry;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr__State1_L1B_L1Rz;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr__State1_L2_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr__State1_L2_1;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr__State1_L2_2;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr__State1_L2_3;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr__Out_L0_L1Rx;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr__Out_L1G_L1Ry;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr__Out_L1B_L1Rz;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeFieldInfoPtr__Out_L2_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr__Out_L2_1;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr__Out_L2_2;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr__Out_L2_3;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr_m_ChunkList;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr_m_MappedChunks;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr_m_State0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr_m_State1;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_m_MemoryBudget;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_m_ShBands;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Internal_Static_get_Boolean_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_byref_ProbeVolumeSystemParameters_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_get_isAllocated_Internal_get_Boolean_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_GetPoolDepth_Internal_Int32_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeBlendingTextureMemoryBudget_ProbeVolumeSHBands_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_AllocateResourcesIfNeeded_Internal_Void_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_Int32_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_DivRoundUp_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_PerformBlending_Internal_Void_CommandBuffer_Single_ProbeBrickPool_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_BlendChunks_Internal_Void_BlendingCellInfo_ProbeBrickPool_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;
	}
}
