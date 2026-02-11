using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000085 RID: 133
	public class ProbeCellIndices : Object
	{
		// Token: 0x06000957 RID: 2391 RVA: 0x000300F8 File Offset: 0x0002E2F8
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeCellIndices()
		{
			Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeCellIndices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr);
			ProbeCellIndices.NativeFieldInfoPtr_kUintPerEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, "kUintPerEntry");
			ProbeCellIndices.NativeFieldInfoPtr__estimatedVMemCost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, "<estimatedVMemCost>k__BackingField");
			ProbeCellIndices.NativeFieldInfoPtr_m_IndexOfIndicesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, "m_IndexOfIndicesBuffer");
			ProbeCellIndices.NativeFieldInfoPtr_m_IndexOfIndicesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, "m_IndexOfIndicesData");
			ProbeCellIndices.NativeFieldInfoPtr_m_CellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, "m_CellCount");
			ProbeCellIndices.NativeFieldInfoPtr_m_CellMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, "m_CellMin");
			ProbeCellIndices.NativeFieldInfoPtr_m_CellSizeInMinBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, "m_CellSizeInMinBricks");
			ProbeCellIndices.NativeFieldInfoPtr_m_NeedUpdateComputeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, "m_NeedUpdateComputeBuffer");
			ProbeCellIndices.NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664729);
			ProbeCellIndices.NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664730);
			ProbeCellIndices.NativeMethodInfoPtr_GetCellIndexDimension_Internal_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664731);
			ProbeCellIndices.NativeMethodInfoPtr_GetCellMinPosition_Internal_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664732);
			ProbeCellIndices.NativeMethodInfoPtr_GetFlatIndex_Private_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664733);
			ProbeCellIndices.NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664734);
			ProbeCellIndices.NativeMethodInfoPtr_GetFlatIdxForCell_Internal_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664735);
			ProbeCellIndices.NativeMethodInfoPtr_UpdateCell_Internal_Void_Int32_CellIndexUpdateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664736);
			ProbeCellIndices.NativeMethodInfoPtr_MarkCellAsUnloaded_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664737);
			ProbeCellIndices.NativeMethodInfoPtr_PushComputeData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664738);
			ProbeCellIndices.NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664739);
			ProbeCellIndices.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, 100664740);
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x000302B8 File Offset: 0x0002E4B8
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x000302F4 File Offset: 0x0002E4F4
		public unsafe int estimatedVMemCost
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00030334 File Offset: 0x0002E534
		[CallerCount(0)]
		public unsafe Vector3Int GetCellIndexDimension()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_GetCellIndexDimension_Internal_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00030370 File Offset: 0x0002E570
		[CallerCount(0)]
		public unsafe Vector3Int GetCellMinPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_GetCellMinPosition_Internal_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000303AC File Offset: 0x0002E5AC
		[CallerCount(0)]
		public unsafe int GetFlatIndex(Vector3Int normalizedPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref normalizedPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_GetFlatIndex_Private_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000303F8 File Offset: 0x0002E5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966952, XrefRangeEnd = 966964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeCellIndices(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cellMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellSizeInMinBricks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0003045C File Offset: 0x0002E65C
		[CallerCount(0)]
		public unsafe int GetFlatIdxForCell(Vector3Int cellPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cellPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_GetFlatIdxForCell_Internal_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000304A8 File Offset: 0x0002E6A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 966976, RefRangeEnd = 966977, XrefRangeStart = 966964, XrefRangeEnd = 966976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCell(int cellFlatIdx, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cellFlatIdx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cellUpdateInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_UpdateCell_Internal_Void_Int32_CellIndexUpdateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x000304F4 File Offset: 0x0002E6F4
		[CallerCount(0)]
		public unsafe void MarkCellAsUnloaded(int cellFlatIdx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cellFlatIdx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_MarkCellAsUnloaded_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00030534 File Offset: 0x0002E734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966977, XrefRangeEnd = 966978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushComputeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_PushComputeData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00030568 File Offset: 0x0002E768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966978, XrefRangeEnd = 966981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(rr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000305AC File Offset: 0x0002E7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966981, XrefRangeEnd = 966986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00005B7F File Offset: 0x00003D7F
		public ProbeCellIndices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x000305E0 File Offset: 0x0002E7E0
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00005B88 File Offset: 0x00003D88
		public unsafe static int kUintPerEntry
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ProbeCellIndices.NativeFieldInfoPtr_kUintPerEntry, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProbeCellIndices.NativeFieldInfoPtr_kUintPerEntry, (void*)(&value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x000305FC File Offset: 0x0002E7FC
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00005B96 File Offset: 0x00003D96
		public unsafe int _estimatedVMemCost_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr__estimatedVMemCost_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr__estimatedVMemCost_k__BackingField)) = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00030624 File Offset: 0x0002E824
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00005BB1 File Offset: 0x00003DB1
		public unsafe ComputeBuffer m_IndexOfIndicesBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_IndexOfIndicesBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_IndexOfIndicesBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x00030654 File Offset: 0x0002E854
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x00005BD0 File Offset: 0x00003DD0
		public unsafe Il2CppStructArray<uint> m_IndexOfIndicesData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_IndexOfIndicesData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_IndexOfIndicesData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00030684 File Offset: 0x0002E884
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00005BEF File Offset: 0x00003DEF
		public unsafe Vector3Int m_CellCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_CellCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_CellCount)) = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x000306AC File Offset: 0x0002E8AC
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x00005C0A File Offset: 0x00003E0A
		public unsafe Vector3Int m_CellMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_CellMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_CellMin)) = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x000306D4 File Offset: 0x0002E8D4
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00005C25 File Offset: 0x00003E25
		public unsafe int m_CellSizeInMinBricks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_CellSizeInMinBricks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_CellSizeInMinBricks)) = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x000306FC File Offset: 0x0002E8FC
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00005C40 File Offset: 0x00003E40
		public unsafe bool m_NeedUpdateComputeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_NeedUpdateComputeBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeCellIndices.NativeFieldInfoPtr_m_NeedUpdateComputeBuffer)) = value;
			}
		}

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr_kUintPerEntry;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr__estimatedVMemCost_k__BackingField;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_m_IndexOfIndicesBuffer;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_m_IndexOfIndicesData;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_m_CellCount;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_m_CellMin;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_m_CellSizeInMinBricks;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedUpdateComputeBuffer;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_GetCellIndexDimension_Internal_Vector3Int_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_GetCellMinPosition_Internal_Vector3Int_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_GetFlatIndex_Private_Int32_Vector3Int_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Vector3Int_Vector3Int_Int32_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_GetFlatIdxForCell_Internal_Int32_Vector3Int_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCell_Internal_Void_Int32_CellIndexUpdateInfo_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_MarkCellAsUnloaded_Internal_Void_Int32_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_PushComputeData_Internal_Void_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		// Token: 0x020001C3 RID: 451
		[StructLayout(2)]
		public struct IndexMetaData
		{
			// Token: 0x060018B3 RID: 6323 RVA: 0x00068440 File Offset: 0x00066640
			// Note: this type is marked as 'beforefieldinit'.
			static IndexMetaData()
			{
				Il2CppClassPointerStore<ProbeCellIndices.IndexMetaData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeCellIndices>.NativeClassPtr, "IndexMetaData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeCellIndices.IndexMetaData>.NativeClassPtr);
				ProbeCellIndices.IndexMetaData.NativeFieldInfoPtr_s_PackedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices.IndexMetaData>.NativeClassPtr, "s_PackedValues");
				ProbeCellIndices.IndexMetaData.NativeFieldInfoPtr_minLocalIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices.IndexMetaData>.NativeClassPtr, "minLocalIdx");
				ProbeCellIndices.IndexMetaData.NativeFieldInfoPtr_maxLocalIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices.IndexMetaData>.NativeClassPtr, "maxLocalIdx");
				ProbeCellIndices.IndexMetaData.NativeFieldInfoPtr_firstChunkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices.IndexMetaData>.NativeClassPtr, "firstChunkIndex");
				ProbeCellIndices.IndexMetaData.NativeFieldInfoPtr_minSubdiv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeCellIndices.IndexMetaData>.NativeClassPtr, "minSubdiv");
				ProbeCellIndices.IndexMetaData.NativeMethodInfoPtr_Pack_Internal_Void_byref_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeCellIndices.IndexMetaData>.NativeClassPtr, 100664741);
			}

			// Token: 0x060018B4 RID: 6324 RVA: 0x000684E4 File Offset: 0x000666E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966947, XrefRangeEnd = 966952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Pack(out Il2CppStructArray<uint> vals)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ProbeCellIndices.IndexMetaData.NativeMethodInfoPtr_Pack_Internal_Void_byref_Il2CppStructArray_1_UInt32_0, ref this, (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					vals = ((intPtr4 == 0) ? null : new Il2CppStructArray<uint>(intPtr4));
				}
			}

			// Token: 0x060018B5 RID: 6325 RVA: 0x0000C4B1 File Offset: 0x0000A6B1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProbeCellIndices.IndexMetaData>.NativeClassPtr, ref this));
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x060018B6 RID: 6326 RVA: 0x0006852C File Offset: 0x0006672C
			// (set) Token: 0x060018B7 RID: 6327 RVA: 0x0000C4C3 File Offset: 0x0000A6C3
			public unsafe static Il2CppStructArray<uint> s_PackedValues
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProbeCellIndices.IndexMetaData.NativeFieldInfoPtr_s_PackedValues, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProbeCellIndices.IndexMetaData.NativeFieldInfoPtr_s_PackedValues, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011E5 RID: 4581
			private static readonly IntPtr NativeFieldInfoPtr_s_PackedValues;

			// Token: 0x040011E6 RID: 4582
			private static readonly IntPtr NativeFieldInfoPtr_minLocalIdx;

			// Token: 0x040011E7 RID: 4583
			private static readonly IntPtr NativeFieldInfoPtr_maxLocalIdx;

			// Token: 0x040011E8 RID: 4584
			private static readonly IntPtr NativeFieldInfoPtr_firstChunkIndex;

			// Token: 0x040011E9 RID: 4585
			private static readonly IntPtr NativeFieldInfoPtr_minSubdiv;

			// Token: 0x040011EA RID: 4586
			private static readonly IntPtr NativeMethodInfoPtr_Pack_Internal_Void_byref_Il2CppStructArray_1_UInt32_0;

			// Token: 0x040011EB RID: 4587
			[FieldOffset(0)]
			public Vector3Int minLocalIdx;

			// Token: 0x040011EC RID: 4588
			[FieldOffset(12)]
			public Vector3Int maxLocalIdx;

			// Token: 0x040011ED RID: 4589
			[FieldOffset(24)]
			public int firstChunkIndex;

			// Token: 0x040011EE RID: 4590
			[FieldOffset(28)]
			public int minSubdiv;
		}
	}
}
