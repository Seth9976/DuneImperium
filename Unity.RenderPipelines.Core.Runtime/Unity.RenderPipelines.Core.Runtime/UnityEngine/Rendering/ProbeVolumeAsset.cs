using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x02000091 RID: 145
	public class ProbeVolumeAsset : ScriptableObject
	{
		// Token: 0x06000AF1 RID: 2801 RVA: 0x00034FD4 File Offset: 0x000331D4
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeVolumeAsset()
		{
			Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr);
			ProbeVolumeAsset.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "m_Version");
			ProbeVolumeAsset.NativeFieldInfoPtr_cells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "cells");
			ProbeVolumeAsset.NativeFieldInfoPtr_cellCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "cellCounts");
			ProbeVolumeAsset.NativeFieldInfoPtr_totalCellCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "totalCellCounts");
			ProbeVolumeAsset.NativeFieldInfoPtr_maxCellPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "maxCellPosition");
			ProbeVolumeAsset.NativeFieldInfoPtr_minCellPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "minCellPosition");
			ProbeVolumeAsset.NativeFieldInfoPtr_globalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "globalBounds");
			ProbeVolumeAsset.NativeFieldInfoPtr_bands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "bands");
			ProbeVolumeAsset.NativeFieldInfoPtr_chunkSizeInBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "chunkSizeInBricks");
			ProbeVolumeAsset.NativeFieldInfoPtr_m_AssetFullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "m_AssetFullPath");
			ProbeVolumeAsset.NativeFieldInfoPtr_cellSizeInBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "cellSizeInBricks");
			ProbeVolumeAsset.NativeFieldInfoPtr_simplificationLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "simplificationLevels");
			ProbeVolumeAsset.NativeFieldInfoPtr_minDistanceBetweenProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "minDistanceBetweenProbes");
			ProbeVolumeAsset.NativeMethodInfoPtr_get_Version_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664972);
			ProbeVolumeAsset.NativeMethodInfoPtr_get_maxSubdivision_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664973);
			ProbeVolumeAsset.NativeMethodInfoPtr_get_minBrickSize_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664974);
			ProbeVolumeAsset.NativeMethodInfoPtr_CompatibleWith_Internal_Boolean_ProbeVolumeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664975);
			ProbeVolumeAsset.NativeMethodInfoPtr_IsInvalid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664976);
			ProbeVolumeAsset.NativeMethodInfoPtr_GetSerializedFullPath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664977);
			ProbeVolumeAsset.NativeMethodInfoPtr_AlignUp16_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664978);
			ProbeVolumeAsset.NativeMethodInfoPtr_GetSubArray_Private_NativeArray_1_T_NativeArray_1_Byte_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664979);
			ProbeVolumeAsset.NativeMethodInfoPtr_ResolveSharedCellData_Internal_Boolean_TextAsset_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664980);
			ProbeVolumeAsset.NativeMethodInfoPtr_ResolvePerScenarioCellData_Internal_Boolean_TextAsset_TextAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664981);
			ProbeVolumeAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, 100664982);
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000351E4 File Offset: 0x000333E4
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.NativeMethodInfoPtr_get_Version_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00035220 File Offset: 0x00033420
		public unsafe int maxSubdivision
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 969663, RefRangeEnd = 969664, XrefRangeStart = 969663, XrefRangeEnd = 969663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.NativeMethodInfoPtr_get_maxSubdivision_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0003525C File Offset: 0x0003345C
		public unsafe float minBrickSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 969664, RefRangeEnd = 969665, XrefRangeStart = 969664, XrefRangeEnd = 969664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.NativeMethodInfoPtr_get_minBrickSize_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00035298 File Offset: 0x00033498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969665, RefRangeEnd = 969666, XrefRangeStart = 969665, XrefRangeEnd = 969665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompatibleWith(ProbeVolumeAsset otherAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.NativeMethodInfoPtr_CompatibleWith_Internal_Boolean_ProbeVolumeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000352E8 File Offset: 0x000334E8
		[CallerCount(0)]
		public unsafe bool IsInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.NativeMethodInfoPtr_IsInvalid_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00035324 File Offset: 0x00033524
		[CallerCount(0)]
		public unsafe string GetSerializedFullPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.NativeMethodInfoPtr_GetSerializedFullPath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0003535C File Offset: 0x0003355C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 969666, RefRangeEnd = 969667, XrefRangeStart = 969666, XrefRangeEnd = 969666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AlignUp16(int count)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.NativeMethodInfoPtr_AlignUp16_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0003539C File Offset: 0x0003359C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 969674, RefRangeEnd = 969681, XrefRangeStart = 969667, XrefRangeEnd = 969674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<T> GetSubArray<T>(NativeArray<byte> input, int count, ref int offset) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.MethodInfoStoreGeneric_GetSubArray_Private_NativeArray_1_T_NativeArray_1_Byte_Int32_byref_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<T>(intPtr);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00035408 File Offset: 0x00033608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969681, XrefRangeEnd = 969716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveSharedCellData(TextAsset cellSharedDataAsset, TextAsset cellSupportDataAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cellSharedDataAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cellSupportDataAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.NativeMethodInfoPtr_ResolveSharedCellData_Internal_Boolean_TextAsset_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00035468 File Offset: 0x00033668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 969765, RefRangeEnd = 969767, XrefRangeStart = 969716, XrefRangeEnd = 969765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolvePerScenarioCellData(TextAsset cellDataAsset, TextAsset cellOptionalDataAsset, int stateIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cellDataAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cellOptionalDataAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.NativeMethodInfoPtr_ResolvePerScenarioCellData_Internal_Boolean_TextAsset_TextAsset_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000354D8 File Offset: 0x000336D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969767, XrefRangeEnd = 969772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeVolumeAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00006A7F File Offset: 0x00004C7F
		public ProbeVolumeAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x00035514 File Offset: 0x00033714
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x00006A88 File Offset: 0x00004C88
		public unsafe int m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0003553C File Offset: 0x0003373C
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x00006AA3 File Offset: 0x00004CA3
		public unsafe Il2CppReferenceArray<ProbeReferenceVolume.Cell> cells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_cells);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProbeReferenceVolume.Cell>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_cells), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0003556C File Offset: 0x0003376C
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00006AC2 File Offset: 0x00004CC2
		public unsafe Il2CppStructArray<ProbeVolumeAsset.CellCounts> cellCounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_cellCounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ProbeVolumeAsset.CellCounts>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_cellCounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0003559C File Offset: 0x0003379C
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00006AE1 File Offset: 0x00004CE1
		public unsafe ProbeVolumeAsset.CellCounts totalCellCounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_totalCellCounts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_totalCellCounts)) = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x000355C4 File Offset: 0x000337C4
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00006AFC File Offset: 0x00004CFC
		public unsafe Vector3Int maxCellPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_maxCellPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_maxCellPosition)) = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x000355EC File Offset: 0x000337EC
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00006B17 File Offset: 0x00004D17
		public unsafe Vector3Int minCellPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_minCellPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_minCellPosition)) = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00035614 File Offset: 0x00033814
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x00006B32 File Offset: 0x00004D32
		public unsafe Bounds globalBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_globalBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_globalBounds)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0003563C File Offset: 0x0003383C
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00006B4D File Offset: 0x00004D4D
		public unsafe ProbeVolumeSHBands bands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_bands);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_bands)) = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00035664 File Offset: 0x00033864
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00006B68 File Offset: 0x00004D68
		public unsafe int chunkSizeInBricks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_chunkSizeInBricks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_chunkSizeInBricks)) = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0003568C File Offset: 0x0003388C
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00006B83 File Offset: 0x00004D83
		public unsafe string m_AssetFullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_m_AssetFullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_m_AssetFullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x000356B4 File Offset: 0x000338B4
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x00006BA2 File Offset: 0x00004DA2
		public unsafe int cellSizeInBricks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_cellSizeInBricks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_cellSizeInBricks)) = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x000356DC File Offset: 0x000338DC
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00006BBD File Offset: 0x00004DBD
		public unsafe int simplificationLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_simplificationLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_simplificationLevels)) = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00035704 File Offset: 0x00033904
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00006BD8 File Offset: 0x00004DD8
		public unsafe float minDistanceBetweenProbes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_minDistanceBetweenProbes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolumeAsset.NativeFieldInfoPtr_minDistanceBetweenProbes)) = value;
			}
		}

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_cells;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_cellCounts;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_totalCellCounts;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_maxCellPosition;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr_minCellPosition;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr_globalBounds;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeFieldInfoPtr_bands;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeFieldInfoPtr_chunkSizeInBricks;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetFullPath;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeFieldInfoPtr_cellSizeInBricks;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeFieldInfoPtr_simplificationLevels;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeFieldInfoPtr_minDistanceBetweenProbes;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Int32_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSubdivision_Internal_get_Int32_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_get_minBrickSize_Internal_get_Single_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_CompatibleWith_Internal_Boolean_ProbeVolumeAsset_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_IsInvalid_Internal_Boolean_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializedFullPath_Public_String_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_AlignUp16_Private_Static_Int32_Int32_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_GetSubArray_Private_NativeArray_1_T_NativeArray_1_Byte_Int32_byref_Int32_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSharedCellData_Internal_Boolean_TextAsset_TextAsset_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_ResolvePerScenarioCellData_Internal_Boolean_TextAsset_TextAsset_Int32_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001D3 RID: 467
		[Serializable]
		public enum AssetVersion
		{
			// Token: 0x040012BF RID: 4799
			First,
			// Token: 0x040012C0 RID: 4800
			AddProbeVolumesAtlasEncodingModes,
			// Token: 0x040012C1 RID: 4801
			PV2,
			// Token: 0x040012C2 RID: 4802
			ChunkBasedIndex,
			// Token: 0x040012C3 RID: 4803
			BinaryRuntimeDebugSplit,
			// Token: 0x040012C4 RID: 4804
			BinaryTextureData,
			// Token: 0x040012C5 RID: 4805
			Max,
			// Token: 0x040012C6 RID: 4806
			Current = 5
		}

		// Token: 0x020001D4 RID: 468
		[Serializable]
		[StructLayout(2)]
		public struct CellCounts
		{
			// Token: 0x060019CA RID: 6602 RVA: 0x0006BA9C File Offset: 0x00069C9C
			// Note: this type is marked as 'beforefieldinit'.
			static CellCounts()
			{
				Il2CppClassPointerStore<ProbeVolumeAsset.CellCounts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr, "CellCounts");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeAsset.CellCounts>.NativeClassPtr);
				ProbeVolumeAsset.CellCounts.NativeFieldInfoPtr_bricksCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset.CellCounts>.NativeClassPtr, "bricksCount");
				ProbeVolumeAsset.CellCounts.NativeFieldInfoPtr_probesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset.CellCounts>.NativeClassPtr, "probesCount");
				ProbeVolumeAsset.CellCounts.NativeFieldInfoPtr_offsetsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset.CellCounts>.NativeClassPtr, "offsetsCount");
				ProbeVolumeAsset.CellCounts.NativeFieldInfoPtr_chunksCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeAsset.CellCounts>.NativeClassPtr, "chunksCount");
				ProbeVolumeAsset.CellCounts.NativeMethodInfoPtr_Add_Public_Void_CellCounts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeAsset.CellCounts>.NativeClassPtr, 100664983);
			}

			// Token: 0x060019CB RID: 6603 RVA: 0x0006BB2C File Offset: 0x00069D2C
			[CallerCount(0)]
			public unsafe void Add(ProbeVolumeAsset.CellCounts o)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref o;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolumeAsset.CellCounts.NativeMethodInfoPtr_Add_Public_Void_CellCounts_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019CC RID: 6604 RVA: 0x0000CD9A File Offset: 0x0000AF9A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeVolumeAsset.CellCounts>.NativeClassPtr, ref this));
			}

			// Token: 0x040012C7 RID: 4807
			private static readonly IntPtr NativeFieldInfoPtr_bricksCount;

			// Token: 0x040012C8 RID: 4808
			private static readonly IntPtr NativeFieldInfoPtr_probesCount;

			// Token: 0x040012C9 RID: 4809
			private static readonly IntPtr NativeFieldInfoPtr_offsetsCount;

			// Token: 0x040012CA RID: 4810
			private static readonly IntPtr NativeFieldInfoPtr_chunksCount;

			// Token: 0x040012CB RID: 4811
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_CellCounts_0;

			// Token: 0x040012CC RID: 4812
			[FieldOffset(0)]
			public int bricksCount;

			// Token: 0x040012CD RID: 4813
			[FieldOffset(4)]
			public int probesCount;

			// Token: 0x040012CE RID: 4814
			[FieldOffset(8)]
			public int offsetsCount;

			// Token: 0x040012CF RID: 4815
			[FieldOffset(12)]
			public int chunksCount;
		}

		// Token: 0x020001D5 RID: 469
		private sealed class MethodInfoStoreGeneric_GetSubArray_Private_NativeArray_1_T_NativeArray_1_Byte_Int32_byref_Int32_0<T>
		{
			// Token: 0x040012D0 RID: 4816
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ProbeVolumeAsset.NativeMethodInfoPtr_GetSubArray_Private_NativeArray_1_T_NativeArray_1_Byte_Int32_byref_Int32_0, Il2CppClassPointerStore<ProbeVolumeAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
