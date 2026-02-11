using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine.Events;

namespace UnityEngine.Rendering
{
	// Token: 0x02000082 RID: 130
	public class ProbeBrickIndex : Object
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x0002DBE0 File Offset: 0x0002BDE0
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeBrickIndex()
		{
			Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeBrickIndex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr);
			ProbeBrickIndex.NativeFieldInfoPtr_kMaxSubdivisionLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "kMaxSubdivisionLevels");
			ProbeBrickIndex.NativeFieldInfoPtr_kIndexChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "kIndexChunkSize");
			ProbeBrickIndex.NativeFieldInfoPtr_m_IndexChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_IndexChunks");
			ProbeBrickIndex.NativeFieldInfoPtr_m_IndexInChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_IndexInChunks");
			ProbeBrickIndex.NativeFieldInfoPtr_m_NextFreeChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_NextFreeChunk");
			ProbeBrickIndex.NativeFieldInfoPtr_m_AvailableChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_AvailableChunkCount");
			ProbeBrickIndex.NativeFieldInfoPtr_m_PhysicalIndexBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_PhysicalIndexBuffer");
			ProbeBrickIndex.NativeFieldInfoPtr_m_PhysicalIndexBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_PhysicalIndexBufferData");
			ProbeBrickIndex.NativeFieldInfoPtr__estimatedVMemCost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "<estimatedVMemCost>k__BackingField");
			ProbeBrickIndex.NativeFieldInfoPtr_m_CenterRS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_CenterRS");
			ProbeBrickIndex.NativeFieldInfoPtr_m_VoxelToBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_VoxelToBricks");
			ProbeBrickIndex.NativeFieldInfoPtr_m_BricksToVoxels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_BricksToVoxels");
			ProbeBrickIndex.NativeFieldInfoPtr_m_BrickMetaPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_BrickMetaPool");
			ProbeBrickIndex.NativeFieldInfoPtr_m_VoxelMetaListPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_VoxelMetaListPool");
			ProbeBrickIndex.NativeFieldInfoPtr_m_VoxelMetaPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_VoxelMetaPool");
			ProbeBrickIndex.NativeFieldInfoPtr_m_NeedUpdateIndexComputeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_NeedUpdateIndexComputeBuffer");
			ProbeBrickIndex.NativeFieldInfoPtr_m_UpdateMinIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_UpdateMinIndex");
			ProbeBrickIndex.NativeFieldInfoPtr_m_UpdateMaxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "m_UpdateMaxIndex");
			ProbeBrickIndex.NativeFieldInfoPtr_g_Cell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "g_Cell");
			ProbeBrickIndex.NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664653);
			ProbeBrickIndex.NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664654);
			ProbeBrickIndex.NativeMethodInfoPtr_GetVoxelSubdivLevel_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664655);
			ProbeBrickIndex.NativeMethodInfoPtr_SizeOfPhysicalIndexFromBudget_Private_Int32_ProbeVolumeTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664656);
			ProbeBrickIndex.NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664657);
			ProbeBrickIndex.NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664658);
			ProbeBrickIndex.NativeMethodInfoPtr_UploadIndexData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664659);
			ProbeBrickIndex.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664660);
			ProbeBrickIndex.NativeMethodInfoPtr_MapBrickToVoxels_Private_Void_Brick_HashSet_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664661);
			ProbeBrickIndex.NativeMethodInfoPtr_ClearVoxel_Private_Void_Vector3Int_CellIndexUpdateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664662);
			ProbeBrickIndex.NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664663);
			ProbeBrickIndex.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664664);
			ProbeBrickIndex.NativeMethodInfoPtr_MergeIndex_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664665);
			ProbeBrickIndex.NativeMethodInfoPtr_AssignIndexChunksToCell_Internal_Boolean_Int32_byref_CellIndexUpdateInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664666);
			ProbeBrickIndex.NativeMethodInfoPtr_AddBricks_Public_Void_Cell_NativeArray_1_Brick_List_1_BrickChunkAlloc_Int32_Int32_Int32_CellIndexUpdateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664667);
			ProbeBrickIndex.NativeMethodInfoPtr_RemoveBricks_Public_Void_CellInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664668);
			ProbeBrickIndex.NativeMethodInfoPtr_UpdateIndexForVoxel_Private_Void_Vector3Int_CellIndexUpdateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664669);
			ProbeBrickIndex.NativeMethodInfoPtr_UpdatePhysicalIndex_Private_Void_Vector3Int_Vector3Int_Int32_CellIndexUpdateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664670);
			ProbeBrickIndex.NativeMethodInfoPtr_ClipToIndexSpace_Private_Void_Vector3Int_Int32_byref_Vector3Int_byref_Vector3Int_CellIndexUpdateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664671);
			ProbeBrickIndex.NativeMethodInfoPtr_UpdateIndexForVoxel_Private_Void_Vector3Int_List_1_ReservedBrick_List_1_UInt16_CellIndexUpdateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, 100664672);
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0002DF1C File Offset: 0x0002C11C
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x0002DF58 File Offset: 0x0002C158
		public unsafe int estimatedVMemCost
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0002DF98 File Offset: 0x0002C198
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 966048, RefRangeEnd = 966052, XrefRangeStart = 966041, XrefRangeEnd = 966048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVoxelSubdivLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_GetVoxelSubdivLevel_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0002DFD4 File Offset: 0x0002C1D4
		[CallerCount(0)]
		public unsafe int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref memoryBudget;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_SizeOfPhysicalIndexFromBudget_Private_Int32_ProbeVolumeTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0002E020 File Offset: 0x0002C220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966152, RefRangeEnd = 966153, XrefRangeStart = 966052, XrefRangeEnd = 966152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref memoryBudget;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0002E068 File Offset: 0x0002C268
		[CallerCount(0)]
		public unsafe int GetRemainingChunkCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0002E0A4 File Offset: 0x0002C2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966153, XrefRangeEnd = 966154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UploadIndexData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_UploadIndexData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0002E0D8 File Offset: 0x0002C2D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966219, RefRangeEnd = 966221, XrefRangeStart = 966154, XrefRangeEnd = 966219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0002E10C File Offset: 0x0002C30C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966245, RefRangeEnd = 966246, XrefRangeStart = 966221, XrefRangeEnd = 966245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MapBrickToVoxels(ProbeBrickIndex.Brick brick, HashSet<Vector3Int> voxels)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref brick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(voxels);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_MapBrickToVoxels_Private_Void_Brick_HashSet_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0002E15C File Offset: 0x0002C35C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966249, RefRangeEnd = 966251, XrefRangeStart = 966246, XrefRangeEnd = 966249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearVoxel(Vector3Int pos, ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_ClearVoxel_Private_Void_Vector3Int_CellIndexUpdateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0002E1A8 File Offset: 0x0002C3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966251, XrefRangeEnd = 966254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(rr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0002E1EC File Offset: 0x0002C3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966254, XrefRangeEnd = 966259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0002E220 File Offset: 0x0002C420
		[CallerCount(0)]
		public unsafe int MergeIndex(int index, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_MergeIndex_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0002E278 File Offset: 0x0002C478
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966271, RefRangeEnd = 966273, XrefRangeStart = 966259, XrefRangeEnd = 966271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AssignIndexChunksToCell(int bricksCount, ref ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bricksCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cellUpdateInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrorLog;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_AssignIndexChunksToCell_Internal_Boolean_Int32_byref_CellIndexUpdateInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0002E2E0 File Offset: 0x0002C4E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966364, RefRangeEnd = 966365, XrefRangeStart = 966273, XrefRangeEnd = 966364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBricks(ProbeReferenceVolume.Cell cell, NativeArray<ProbeBrickIndex.Brick> bricks, List<ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cell);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bricks));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allocations);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocationSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poolWidth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref poolHeight;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_AddBricks_Public_Void_Cell_NativeArray_1_Brick_List_1_BrickChunkAlloc_Int32_Int32_Int32_CellIndexUpdateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0002E384 File Offset: 0x0002C584
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 966436, RefRangeEnd = 966439, XrefRangeStart = 966365, XrefRangeEnd = 966436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBricks(ProbeReferenceVolume.CellInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cellInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_RemoveBricks_Public_Void_CellInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966461, RefRangeEnd = 966463, XrefRangeStart = 966439, XrefRangeEnd = 966461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIndexForVoxel(Vector3Int voxel, ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref voxel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_UpdateIndexForVoxel_Private_Void_Vector3Int_CellIndexUpdateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0002E414 File Offset: 0x0002C614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966482, RefRangeEnd = 966484, XrefRangeStart = 966463, XrefRangeEnd = 966482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePhysicalIndex(Vector3Int brickMin, Vector3Int brickMax, int value, ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref brickMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref brickMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_UpdatePhysicalIndex_Private_Void_Vector3Int_Vector3Int_Int32_CellIndexUpdateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0002E47C File Offset: 0x0002C67C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 966490, RefRangeEnd = 966492, XrefRangeStart = 966484, XrefRangeEnd = 966490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClipToIndexSpace(Vector3Int pos, int subdiv, out Vector3Int outMinpos, out Vector3Int outMaxpos, ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subdiv;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outMinpos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outMaxpos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_ClipToIndexSpace_Private_Void_Vector3Int_Int32_byref_Vector3Int_byref_Vector3Int_CellIndexUpdateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0002E4F4 File Offset: 0x0002C6F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966515, RefRangeEnd = 966516, XrefRangeStart = 966492, XrefRangeEnd = 966515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIndexForVoxel(Vector3Int voxel, List<ProbeBrickIndex.ReservedBrick> bricks, List<ushort> indices, ProbeBrickIndex.CellIndexUpdateInfo cellInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref voxel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bricks);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.NativeMethodInfoPtr_UpdateIndexForVoxel_Private_Void_Vector3Int_List_1_ReservedBrick_List_1_UInt16_CellIndexUpdateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0000562E File Offset: 0x0000382E
		public ProbeBrickIndex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0002E564 File Offset: 0x0002C764
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x00005637 File Offset: 0x00003837
		public unsafe static int kMaxSubdivisionLevels
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickIndex.NativeFieldInfoPtr_kMaxSubdivisionLevels, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickIndex.NativeFieldInfoPtr_kMaxSubdivisionLevels, (void*)(&value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x0002E580 File Offset: 0x0002C780
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00005645 File Offset: 0x00003845
		public unsafe static int kIndexChunkSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickIndex.NativeFieldInfoPtr_kIndexChunkSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickIndex.NativeFieldInfoPtr_kIndexChunkSize, (void*)(&value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0002E59C File Offset: 0x0002C79C
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00005653 File Offset: 0x00003853
		public unsafe BitArray m_IndexChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_IndexChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_IndexChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x0002E5CC File Offset: 0x0002C7CC
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00005672 File Offset: 0x00003872
		public unsafe int m_IndexInChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_IndexInChunks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_IndexInChunks)) = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x0000568D File Offset: 0x0000388D
		public unsafe int m_NextFreeChunk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_NextFreeChunk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_NextFreeChunk)) = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0002E61C File Offset: 0x0002C81C
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x000056A8 File Offset: 0x000038A8
		public unsafe int m_AvailableChunkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_AvailableChunkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_AvailableChunkCount)) = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0002E644 File Offset: 0x0002C844
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x000056C3 File Offset: 0x000038C3
		public unsafe ComputeBuffer m_PhysicalIndexBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_PhysicalIndexBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_PhysicalIndexBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0002E674 File Offset: 0x0002C874
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x000056E2 File Offset: 0x000038E2
		public unsafe Il2CppStructArray<int> m_PhysicalIndexBufferData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_PhysicalIndexBufferData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_PhysicalIndexBufferData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0002E6A4 File Offset: 0x0002C8A4
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00005701 File Offset: 0x00003901
		public unsafe int _estimatedVMemCost_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr__estimatedVMemCost_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr__estimatedVMemCost_k__BackingField)) = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0002E6CC File Offset: 0x0002C8CC
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x0000571C File Offset: 0x0000391C
		public unsafe Vector3Int m_CenterRS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_CenterRS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_CenterRS)) = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0002E6F4 File Offset: 0x0002C8F4
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00005737 File Offset: 0x00003937
		public unsafe Dictionary<Vector3Int, List<ProbeBrickIndex.VoxelMeta>> m_VoxelToBricks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_VoxelToBricks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, List<ProbeBrickIndex.VoxelMeta>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_VoxelToBricks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0002E724 File Offset: 0x0002C924
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00005756 File Offset: 0x00003956
		public unsafe Dictionary<ProbeReferenceVolume.Cell, ProbeBrickIndex.BrickMeta> m_BricksToVoxels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_BricksToVoxels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProbeReferenceVolume.Cell, ProbeBrickIndex.BrickMeta>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_BricksToVoxels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0002E754 File Offset: 0x0002C954
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00005775 File Offset: 0x00003975
		public unsafe ObjectPool<ProbeBrickIndex.BrickMeta> m_BrickMetaPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_BrickMetaPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<ProbeBrickIndex.BrickMeta>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_BrickMetaPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0002E784 File Offset: 0x0002C984
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00005794 File Offset: 0x00003994
		public unsafe ObjectPool<List<ProbeBrickIndex.VoxelMeta>> m_VoxelMetaListPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_VoxelMetaListPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<List<ProbeBrickIndex.VoxelMeta>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_VoxelMetaListPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0002E7B4 File Offset: 0x0002C9B4
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x000057B3 File Offset: 0x000039B3
		public unsafe ObjectPool<ProbeBrickIndex.VoxelMeta> m_VoxelMetaPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_VoxelMetaPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<ProbeBrickIndex.VoxelMeta>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_VoxelMetaPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x0002E7E4 File Offset: 0x0002C9E4
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x000057D2 File Offset: 0x000039D2
		public unsafe bool m_NeedUpdateIndexComputeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_NeedUpdateIndexComputeBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_NeedUpdateIndexComputeBuffer)) = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0002E80C File Offset: 0x0002CA0C
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x000057ED File Offset: 0x000039ED
		public unsafe int m_UpdateMinIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_UpdateMinIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_UpdateMinIndex)) = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0002E834 File Offset: 0x0002CA34
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00005808 File Offset: 0x00003A08
		public unsafe int m_UpdateMaxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_UpdateMaxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.NativeFieldInfoPtr_m_UpdateMaxIndex)) = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0002E85C File Offset: 0x0002CA5C
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00005823 File Offset: 0x00003A23
		public unsafe static ProbeReferenceVolume.Cell g_Cell
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProbeBrickIndex.NativeFieldInfoPtr_g_Cell, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.Cell>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeBrickIndex.NativeFieldInfoPtr_g_Cell, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeFieldInfoPtr_kMaxSubdivisionLevels;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr_kIndexChunkSize;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_m_IndexChunks;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_m_IndexInChunks;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr_m_NextFreeChunk;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableChunkCount;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr_m_PhysicalIndexBuffer;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeFieldInfoPtr_m_PhysicalIndexBufferData;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeFieldInfoPtr__estimatedVMemCost_k__BackingField;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeFieldInfoPtr_m_CenterRS;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeFieldInfoPtr_m_VoxelToBricks;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr_m_BricksToVoxels;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeFieldInfoPtr_m_BrickMetaPool;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeFieldInfoPtr_m_VoxelMetaListPool;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeFieldInfoPtr_m_VoxelMetaPool;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedUpdateIndexComputeBuffer;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateMinIndex;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateMaxIndex;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeFieldInfoPtr_g_Cell;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_GetVoxelSubdivLevel_Private_Int32_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_SizeOfPhysicalIndexFromBudget_Private_Int32_ProbeVolumeTextureMemoryBudget_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_UploadIndexData_Internal_Void_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_MapBrickToVoxels_Private_Void_Brick_HashSet_1_Vector3Int_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_ClearVoxel_Private_Void_Vector3Int_CellIndexUpdateInfo_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_MergeIndex_Private_Int32_Int32_Int32_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_AssignIndexChunksToCell_Internal_Boolean_Int32_byref_CellIndexUpdateInfo_Boolean_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_AddBricks_Public_Void_Cell_NativeArray_1_Brick_List_1_BrickChunkAlloc_Int32_Int32_Int32_CellIndexUpdateInfo_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBricks_Public_Void_CellInfo_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIndexForVoxel_Private_Void_Vector3Int_CellIndexUpdateInfo_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePhysicalIndex_Private_Void_Vector3Int_Vector3Int_Int32_CellIndexUpdateInfo_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_ClipToIndexSpace_Private_Void_Vector3Int_Int32_byref_Vector3Int_byref_Vector3Int_CellIndexUpdateInfo_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIndexForVoxel_Private_Void_Vector3Int_List_1_ReservedBrick_List_1_UInt16_CellIndexUpdateInfo_0;

		// Token: 0x020001BB RID: 443
		[Serializable]
		[StructLayout(2)]
		public struct Brick
		{
			// Token: 0x0600186A RID: 6250 RVA: 0x000677EC File Offset: 0x000659EC
			// Note: this type is marked as 'beforefieldinit'.
			static Brick()
			{
				Il2CppClassPointerStore<ProbeBrickIndex.Brick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "Brick");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickIndex.Brick>.NativeClassPtr);
				ProbeBrickIndex.Brick.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.Brick>.NativeClassPtr, "position");
				ProbeBrickIndex.Brick.NativeFieldInfoPtr_subdivisionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.Brick>.NativeClassPtr, "subdivisionLevel");
				ProbeBrickIndex.Brick.NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.Brick>.NativeClassPtr, 100664673);
				ProbeBrickIndex.Brick.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Brick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.Brick>.NativeClassPtr, 100664674);
			}

			// Token: 0x0600186B RID: 6251 RVA: 0x00067868 File Offset: 0x00065A68
			[CallerCount(0)]
			public unsafe Brick(Vector3Int position, int subdivisionLevel)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref position;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subdivisionLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.Brick.NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600186C RID: 6252 RVA: 0x000678A8 File Offset: 0x00065AA8
			[CallerCount(0)]
			public unsafe bool Equals(ProbeBrickIndex.Brick other)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref other;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.Brick.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Brick_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600186D RID: 6253 RVA: 0x0000C202 File Offset: 0x0000A402
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeBrickIndex.Brick>.NativeClassPtr, ref this));
			}

			// Token: 0x040011A8 RID: 4520
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x040011A9 RID: 4521
			private static readonly IntPtr NativeFieldInfoPtr_subdivisionLevel;

			// Token: 0x040011AA RID: 4522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Int32_0;

			// Token: 0x040011AB RID: 4523
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Brick_0;

			// Token: 0x040011AC RID: 4524
			[FieldOffset(0)]
			public Vector3Int position;

			// Token: 0x040011AD RID: 4525
			[FieldOffset(12)]
			public int subdivisionLevel;
		}

		// Token: 0x020001BC RID: 444
		[StructLayout(2)]
		public struct ReservedBrick
		{
			// Token: 0x0600186E RID: 6254 RVA: 0x000678E8 File Offset: 0x00065AE8
			// Note: this type is marked as 'beforefieldinit'.
			static ReservedBrick()
			{
				Il2CppClassPointerStore<ProbeBrickIndex.ReservedBrick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "ReservedBrick");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickIndex.ReservedBrick>.NativeClassPtr);
				ProbeBrickIndex.ReservedBrick.NativeFieldInfoPtr_brick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.ReservedBrick>.NativeClassPtr, "brick");
				ProbeBrickIndex.ReservedBrick.NativeFieldInfoPtr_flattenedIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.ReservedBrick>.NativeClassPtr, "flattenedIdx");
			}

			// Token: 0x0600186F RID: 6255 RVA: 0x0000C214 File Offset: 0x0000A414
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeBrickIndex.ReservedBrick>.NativeClassPtr, ref this));
			}

			// Token: 0x040011AE RID: 4526
			private static readonly IntPtr NativeFieldInfoPtr_brick;

			// Token: 0x040011AF RID: 4527
			private static readonly IntPtr NativeFieldInfoPtr_flattenedIdx;

			// Token: 0x040011B0 RID: 4528
			[FieldOffset(0)]
			public ProbeBrickIndex.Brick brick;

			// Token: 0x040011B1 RID: 4529
			[FieldOffset(16)]
			public int flattenedIdx;
		}

		// Token: 0x020001BD RID: 445
		public class VoxelMeta : Object
		{
			// Token: 0x06001870 RID: 6256 RVA: 0x0006793C File Offset: 0x00065B3C
			// Note: this type is marked as 'beforefieldinit'.
			static VoxelMeta()
			{
				Il2CppClassPointerStore<ProbeBrickIndex.VoxelMeta>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "VoxelMeta");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickIndex.VoxelMeta>.NativeClassPtr);
				ProbeBrickIndex.VoxelMeta.NativeFieldInfoPtr_cell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.VoxelMeta>.NativeClassPtr, "cell");
				ProbeBrickIndex.VoxelMeta.NativeFieldInfoPtr_brickIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.VoxelMeta>.NativeClassPtr, "brickIndices");
				ProbeBrickIndex.VoxelMeta.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.VoxelMeta>.NativeClassPtr, 100664675);
				ProbeBrickIndex.VoxelMeta.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.VoxelMeta>.NativeClassPtr, 100664676);
			}

			// Token: 0x06001871 RID: 6257 RVA: 0x000679B8 File Offset: 0x00065BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965996, XrefRangeEnd = 965998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.VoxelMeta.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001872 RID: 6258 RVA: 0x000679EC File Offset: 0x00065BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965998, XrefRangeEnd = 966010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VoxelMeta()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeBrickIndex.VoxelMeta>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.VoxelMeta.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001873 RID: 6259 RVA: 0x0000C226 File Offset: 0x0000A426
			public VoxelMeta(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x06001874 RID: 6260 RVA: 0x00067A28 File Offset: 0x00065C28
			// (set) Token: 0x06001875 RID: 6261 RVA: 0x0000C22F File Offset: 0x0000A42F
			public unsafe ProbeReferenceVolume.Cell cell
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.VoxelMeta.NativeFieldInfoPtr_cell);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.Cell>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.VoxelMeta.NativeFieldInfoPtr_cell), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x06001876 RID: 6262 RVA: 0x00067A58 File Offset: 0x00065C58
			// (set) Token: 0x06001877 RID: 6263 RVA: 0x0000C24E File Offset: 0x0000A44E
			public unsafe List<ushort> brickIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.VoxelMeta.NativeFieldInfoPtr_brickIndices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ushort>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.VoxelMeta.NativeFieldInfoPtr_brickIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011B2 RID: 4530
			private static readonly IntPtr NativeFieldInfoPtr_cell;

			// Token: 0x040011B3 RID: 4531
			private static readonly IntPtr NativeFieldInfoPtr_brickIndices;

			// Token: 0x040011B4 RID: 4532
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x040011B5 RID: 4533
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001BE RID: 446
		public class BrickMeta : Object
		{
			// Token: 0x06001878 RID: 6264 RVA: 0x00067A88 File Offset: 0x00065C88
			// Note: this type is marked as 'beforefieldinit'.
			static BrickMeta()
			{
				Il2CppClassPointerStore<ProbeBrickIndex.BrickMeta>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "BrickMeta");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickIndex.BrickMeta>.NativeClassPtr);
				ProbeBrickIndex.BrickMeta.NativeFieldInfoPtr_voxels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.BrickMeta>.NativeClassPtr, "voxels");
				ProbeBrickIndex.BrickMeta.NativeFieldInfoPtr_bricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.BrickMeta>.NativeClassPtr, "bricks");
				ProbeBrickIndex.BrickMeta.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.BrickMeta>.NativeClassPtr, 100664677);
				ProbeBrickIndex.BrickMeta.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.BrickMeta>.NativeClassPtr, 100664678);
			}

			// Token: 0x06001879 RID: 6265 RVA: 0x00067B04 File Offset: 0x00065D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966010, XrefRangeEnd = 966014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.BrickMeta.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600187A RID: 6266 RVA: 0x00067B38 File Offset: 0x00065D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966014, XrefRangeEnd = 966029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BrickMeta()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeBrickIndex.BrickMeta>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.BrickMeta.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600187B RID: 6267 RVA: 0x0000C26D File Offset: 0x0000A46D
			public BrickMeta(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x0600187C RID: 6268 RVA: 0x00067B74 File Offset: 0x00065D74
			// (set) Token: 0x0600187D RID: 6269 RVA: 0x0000C276 File Offset: 0x0000A476
			public unsafe HashSet<Vector3Int> voxels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.BrickMeta.NativeFieldInfoPtr_voxels);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Vector3Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.BrickMeta.NativeFieldInfoPtr_voxels), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DF RID: 1759
			// (get) Token: 0x0600187E RID: 6270 RVA: 0x00067BA4 File Offset: 0x00065DA4
			// (set) Token: 0x0600187F RID: 6271 RVA: 0x0000C295 File Offset: 0x0000A495
			public unsafe List<ProbeBrickIndex.ReservedBrick> bricks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.BrickMeta.NativeFieldInfoPtr_bricks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProbeBrickIndex.ReservedBrick>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeBrickIndex.BrickMeta.NativeFieldInfoPtr_bricks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011B6 RID: 4534
			private static readonly IntPtr NativeFieldInfoPtr_voxels;

			// Token: 0x040011B7 RID: 4535
			private static readonly IntPtr NativeFieldInfoPtr_bricks;

			// Token: 0x040011B8 RID: 4536
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x040011B9 RID: 4537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001BF RID: 447
		[StructLayout(2)]
		public struct CellIndexUpdateInfo
		{
			// Token: 0x06001880 RID: 6272 RVA: 0x00067BD4 File Offset: 0x00065DD4
			// Note: this type is marked as 'beforefieldinit'.
			static CellIndexUpdateInfo()
			{
				Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "CellIndexUpdateInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr);
				ProbeBrickIndex.CellIndexUpdateInfo.NativeFieldInfoPtr_firstChunkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr, "firstChunkIndex");
				ProbeBrickIndex.CellIndexUpdateInfo.NativeFieldInfoPtr_numberOfChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr, "numberOfChunks");
				ProbeBrickIndex.CellIndexUpdateInfo.NativeFieldInfoPtr_minSubdivInCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr, "minSubdivInCell");
				ProbeBrickIndex.CellIndexUpdateInfo.NativeFieldInfoPtr_minValidBrickIndexForCellAtMaxRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr, "minValidBrickIndexForCellAtMaxRes");
				ProbeBrickIndex.CellIndexUpdateInfo.NativeFieldInfoPtr_maxValidBrickIndexForCellAtMaxResPlusOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr, "maxValidBrickIndexForCellAtMaxResPlusOne");
				ProbeBrickIndex.CellIndexUpdateInfo.NativeFieldInfoPtr_cellPositionInBricksAtMaxRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr, "cellPositionInBricksAtMaxRes");
			}

			// Token: 0x06001881 RID: 6273 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeBrickIndex.CellIndexUpdateInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x040011BA RID: 4538
			private static readonly IntPtr NativeFieldInfoPtr_firstChunkIndex;

			// Token: 0x040011BB RID: 4539
			private static readonly IntPtr NativeFieldInfoPtr_numberOfChunks;

			// Token: 0x040011BC RID: 4540
			private static readonly IntPtr NativeFieldInfoPtr_minSubdivInCell;

			// Token: 0x040011BD RID: 4541
			private static readonly IntPtr NativeFieldInfoPtr_minValidBrickIndexForCellAtMaxRes;

			// Token: 0x040011BE RID: 4542
			private static readonly IntPtr NativeFieldInfoPtr_maxValidBrickIndexForCellAtMaxResPlusOne;

			// Token: 0x040011BF RID: 4543
			private static readonly IntPtr NativeFieldInfoPtr_cellPositionInBricksAtMaxRes;

			// Token: 0x040011C0 RID: 4544
			[FieldOffset(0)]
			public int firstChunkIndex;

			// Token: 0x040011C1 RID: 4545
			[FieldOffset(4)]
			public int numberOfChunks;

			// Token: 0x040011C2 RID: 4546
			[FieldOffset(8)]
			public int minSubdivInCell;

			// Token: 0x040011C3 RID: 4547
			[FieldOffset(12)]
			public Vector3Int minValidBrickIndexForCellAtMaxRes;

			// Token: 0x040011C4 RID: 4548
			[FieldOffset(24)]
			public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne;

			// Token: 0x040011C5 RID: 4549
			[FieldOffset(36)]
			public Vector3Int cellPositionInBricksAtMaxRes;
		}

		// Token: 0x020001C0 RID: 448
		[ObfuscatedName("UnityEngine.Rendering.ProbeBrickIndex+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001882 RID: 6274 RVA: 0x00067C78 File Offset: 0x00065E78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickIndex>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr);
				ProbeBrickIndex.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, "<>9");
				ProbeBrickIndex.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, "<>9__28_0");
				ProbeBrickIndex.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, "<>9__28_1");
				ProbeBrickIndex.__c.NativeFieldInfoPtr___9__28_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, "<>9__28_2");
				ProbeBrickIndex.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, "<>9__39_0");
				ProbeBrickIndex.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, "<>9__40_0");
				ProbeBrickIndex.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, 100664680);
				ProbeBrickIndex.__c.NativeMethodInfoPtr___ctor_b__28_0_Internal_Void_BrickMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, 100664681);
				ProbeBrickIndex.__c.NativeMethodInfoPtr___ctor_b__28_1_Internal_Void_List_1_VoxelMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, 100664682);
				ProbeBrickIndex.__c.NativeMethodInfoPtr___ctor_b__28_2_Internal_Void_VoxelMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, 100664683);
				ProbeBrickIndex.__c.NativeMethodInfoPtr__AddBricks_b__39_0_Internal_Boolean_VoxelMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, 100664684);
				ProbeBrickIndex.__c.NativeMethodInfoPtr__RemoveBricks_b__40_0_Internal_Boolean_VoxelMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr, 100664685);
			}

			// Token: 0x06001883 RID: 6275 RVA: 0x00067D94 File Offset: 0x00065F94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeBrickIndex.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001884 RID: 6276 RVA: 0x00067DD0 File Offset: 0x00065FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966029, XrefRangeEnd = 966033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__28_0(ProbeBrickIndex.BrickMeta x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.__c.NativeMethodInfoPtr___ctor_b__28_0_Internal_Void_BrickMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001885 RID: 6277 RVA: 0x00067E14 File Offset: 0x00066014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966033, XrefRangeEnd = 966035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__28_1(List<ProbeBrickIndex.VoxelMeta> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.__c.NativeMethodInfoPtr___ctor_b__28_1_Internal_Void_List_1_VoxelMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001886 RID: 6278 RVA: 0x00067E58 File Offset: 0x00066058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966035, XrefRangeEnd = 966037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__28_2(ProbeBrickIndex.VoxelMeta x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.__c.NativeMethodInfoPtr___ctor_b__28_2_Internal_Void_VoxelMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001887 RID: 6279 RVA: 0x00067E9C File Offset: 0x0006609C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966037, XrefRangeEnd = 966039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddBricks_b__39_0(ProbeBrickIndex.VoxelMeta lhs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.__c.NativeMethodInfoPtr__AddBricks_b__39_0_Internal_Boolean_VoxelMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001888 RID: 6280 RVA: 0x00067EEC File Offset: 0x000660EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966039, XrefRangeEnd = 966041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveBricks_b__40_0(ProbeBrickIndex.VoxelMeta lhs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeBrickIndex.__c.NativeMethodInfoPtr__RemoveBricks_b__40_0_Internal_Boolean_VoxelMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001889 RID: 6281 RVA: 0x0000C2C6 File Offset: 0x0000A4C6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E0 RID: 1760
			// (get) Token: 0x0600188A RID: 6282 RVA: 0x00067F3C File Offset: 0x0006613C
			// (set) Token: 0x0600188B RID: 6283 RVA: 0x0000C2CF File Offset: 0x0000A4CF
			public unsafe static ProbeBrickIndex.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProbeBrickIndex.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x0600188C RID: 6284 RVA: 0x00067F64 File Offset: 0x00066164
			// (set) Token: 0x0600188D RID: 6285 RVA: 0x0000C2E1 File Offset: 0x0000A4E1
			public unsafe static UnityAction<ProbeBrickIndex.BrickMeta> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ProbeBrickIndex.BrickMeta>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E2 RID: 1762
			// (get) Token: 0x0600188E RID: 6286 RVA: 0x00067F8C File Offset: 0x0006618C
			// (set) Token: 0x0600188F RID: 6287 RVA: 0x0000C2F3 File Offset: 0x0000A4F3
			public unsafe static UnityAction<List<ProbeBrickIndex.VoxelMeta>> __9__28_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<List<ProbeBrickIndex.VoxelMeta>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x06001890 RID: 6288 RVA: 0x00067FB4 File Offset: 0x000661B4
			// (set) Token: 0x06001891 RID: 6289 RVA: 0x0000C305 File Offset: 0x0000A505
			public unsafe static UnityAction<ProbeBrickIndex.VoxelMeta> __9__28_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9__28_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ProbeBrickIndex.VoxelMeta>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9__28_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E4 RID: 1764
			// (get) Token: 0x06001892 RID: 6290 RVA: 0x00067FDC File Offset: 0x000661DC
			// (set) Token: 0x06001893 RID: 6291 RVA: 0x0000C317 File Offset: 0x0000A517
			public unsafe static Predicate<ProbeBrickIndex.VoxelMeta> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ProbeBrickIndex.VoxelMeta>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x06001894 RID: 6292 RVA: 0x00068004 File Offset: 0x00066204
			// (set) Token: 0x06001895 RID: 6293 RVA: 0x0000C329 File Offset: 0x0000A529
			public unsafe static Predicate<ProbeBrickIndex.VoxelMeta> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ProbeBrickIndex.VoxelMeta>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeBrickIndex.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011C6 RID: 4550
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040011C7 RID: 4551
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x040011C8 RID: 4552
			private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

			// Token: 0x040011C9 RID: 4553
			private static readonly IntPtr NativeFieldInfoPtr___9__28_2;

			// Token: 0x040011CA RID: 4554
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040011CB RID: 4555
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x040011CC RID: 4556
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011CD RID: 4557
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__28_0_Internal_Void_BrickMeta_0;

			// Token: 0x040011CE RID: 4558
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__28_1_Internal_Void_List_1_VoxelMeta_0;

			// Token: 0x040011CF RID: 4559
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__28_2_Internal_Void_VoxelMeta_0;

			// Token: 0x040011D0 RID: 4560
			private static readonly IntPtr NativeMethodInfoPtr__AddBricks_b__39_0_Internal_Boolean_VoxelMeta_0;

			// Token: 0x040011D1 RID: 4561
			private static readonly IntPtr NativeMethodInfoPtr__RemoveBricks_b__40_0_Internal_Boolean_VoxelMeta_0;
		}
	}
}
