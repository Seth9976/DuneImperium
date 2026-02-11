using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000021 RID: 33
	public class ClipperBase : Object
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00019664 File Offset: 0x00017864
		// Note: this type is marked as 'beforefieldinit'.
		static ClipperBase()
		{
			Il2CppClassPointerStore<ClipperBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ClipperBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr);
			ClipperBase.NativeFieldInfoPtr_horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "horizontal");
			ClipperBase.NativeFieldInfoPtr_Skip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "Skip");
			ClipperBase.NativeFieldInfoPtr_Unassigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "Unassigned");
			ClipperBase.NativeFieldInfoPtr_tolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "tolerance");
			ClipperBase.NativeFieldInfoPtr_loRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "loRange");
			ClipperBase.NativeFieldInfoPtr_hiRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "hiRange");
			ClipperBase.NativeFieldInfoPtr_m_MinimaList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "m_MinimaList");
			ClipperBase.NativeFieldInfoPtr_m_CurrentLM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "m_CurrentLM");
			ClipperBase.NativeFieldInfoPtr_m_edges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "m_edges");
			ClipperBase.NativeFieldInfoPtr_m_Scanbeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "m_Scanbeam");
			ClipperBase.NativeFieldInfoPtr_m_PolyOuts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "m_PolyOuts");
			ClipperBase.NativeFieldInfoPtr_m_ActiveEdges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "m_ActiveEdges");
			ClipperBase.NativeFieldInfoPtr_m_UseFullRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "m_UseFullRange");
			ClipperBase.NativeFieldInfoPtr_m_HasOpenPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "m_HasOpenPaths");
			ClipperBase.NativeFieldInfoPtr__PreserveCollinear_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, "<PreserveCollinear>k__BackingField");
			ClipperBase.NativeMethodInfoPtr_near_zero_Internal_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663437);
			ClipperBase.NativeMethodInfoPtr_get_PreserveCollinear_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663438);
			ClipperBase.NativeMethodInfoPtr_set_PreserveCollinear_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663439);
			ClipperBase.NativeMethodInfoPtr_Swap_Public_Void_byref_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663440);
			ClipperBase.NativeMethodInfoPtr_IsHorizontal_Internal_Static_Boolean_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663441);
			ClipperBase.NativeMethodInfoPtr_PointIsVertex_Internal_Boolean_IntPoint_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663442);
			ClipperBase.NativeMethodInfoPtr_PointOnLineSegment_Internal_Boolean_IntPoint_IntPoint_IntPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663443);
			ClipperBase.NativeMethodInfoPtr_PointOnPolygon_Internal_Boolean_IntPoint_OutPt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663444);
			ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_TEdge_TEdge_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663445);
			ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663446);
			ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_IntPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663447);
			ClipperBase.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663448);
			ClipperBase.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663449);
			ClipperBase.NativeMethodInfoPtr_DisposeLocalMinimaList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663450);
			ClipperBase.NativeMethodInfoPtr_RangeTest_Private_Void_IntPoint_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663451);
			ClipperBase.NativeMethodInfoPtr_InitEdge_Private_Void_TEdge_TEdge_TEdge_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663452);
			ClipperBase.NativeMethodInfoPtr_InitEdge2_Private_Void_TEdge_PolyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663453);
			ClipperBase.NativeMethodInfoPtr_FindNextLocMin_Private_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663454);
			ClipperBase.NativeMethodInfoPtr_ProcessBound_Private_TEdge_TEdge_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663455);
			ClipperBase.NativeMethodInfoPtr_AddPath_Public_Boolean_List_1_IntPoint_PolyType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663456);
			ClipperBase.NativeMethodInfoPtr_AddPaths_Public_Boolean_List_1_List_1_IntPoint_PolyType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663457);
			ClipperBase.NativeMethodInfoPtr_Pt2IsBetweenPt1AndPt3_Internal_Boolean_IntPoint_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663458);
			ClipperBase.NativeMethodInfoPtr_RemoveEdge_Private_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663459);
			ClipperBase.NativeMethodInfoPtr_SetDx_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663460);
			ClipperBase.NativeMethodInfoPtr_InsertLocalMinima_Private_Void_LocalMinima_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663461);
			ClipperBase.NativeMethodInfoPtr_PopLocalMinima_Internal_Boolean_Int64_byref_LocalMinima_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663462);
			ClipperBase.NativeMethodInfoPtr_ReverseHorizontal_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663463);
			ClipperBase.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663464);
			ClipperBase.NativeMethodInfoPtr_GetBounds_Public_Static_IntRect_List_1_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663465);
			ClipperBase.NativeMethodInfoPtr_InsertScanbeam_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663466);
			ClipperBase.NativeMethodInfoPtr_PopScanbeam_Internal_Boolean_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663467);
			ClipperBase.NativeMethodInfoPtr_LocalMinimaPending_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663468);
			ClipperBase.NativeMethodInfoPtr_CreateOutRec_Internal_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663469);
			ClipperBase.NativeMethodInfoPtr_DisposeOutRec_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663470);
			ClipperBase.NativeMethodInfoPtr_UpdateEdgeIntoAEL_Internal_Void_byref_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663471);
			ClipperBase.NativeMethodInfoPtr_SwapPositionsInAEL_Internal_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663472);
			ClipperBase.NativeMethodInfoPtr_DeleteFromAEL_Internal_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr, 100663473);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00019AA4 File Offset: 0x00017CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 597047, RefRangeEnd = 597048, XrefRangeStart = 597047, XrefRangeEnd = 597047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool near_zero(double val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_near_zero_Internal_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00019AE4 File Offset: 0x00017CE4
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00019B20 File Offset: 0x00017D20
		public unsafe bool PreserveCollinear
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_get_PreserveCollinear_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_set_PreserveCollinear_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00019B60 File Offset: 0x00017D60
		[CallerCount(0)]
		public unsafe void Swap(ref long val1, ref long val2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_Swap_Public_Void_byref_Int64_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00019BAC File Offset: 0x00017DAC
		[CallerCount(0)]
		public unsafe static bool IsHorizontal(TEdge e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_IsHorizontal_Internal_Static_Boolean_TEdge_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00019BF0 File Offset: 0x00017DF0
		[CallerCount(0)]
		public unsafe bool PointIsVertex(IntPoint pt, OutPt pp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_PointIsVertex_Internal_Boolean_IntPoint_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00019C4C File Offset: 0x00017E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597048, XrefRangeEnd = 597060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointOnLineSegment(IntPoint pt, IntPoint linePt1, IntPoint linePt2, bool UseFullRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePt1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePt2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UseFullRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_PointOnLineSegment_Internal_Boolean_IntPoint_IntPoint_IntPoint_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00019CC0 File Offset: 0x00017EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597060, XrefRangeEnd = 597070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointOnPolygon(IntPoint pt, OutPt pp, bool UseFullRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pp);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UseFullRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_PointOnPolygon_Internal_Boolean_IntPoint_OutPt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00019D2C File Offset: 0x00017F2C
		[CallerCount(0)]
		public unsafe static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UseFullRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_TEdge_TEdge_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00019D90 File Offset: 0x00017F90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597080, RefRangeEnd = 597082, XrefRangeStart = 597070, XrefRangeEnd = 597080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UseFullRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00019DF8 File Offset: 0x00017FF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 597092, RefRangeEnd = 597097, XrefRangeStart = 597082, XrefRangeEnd = 597092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UseFullRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_IntPoint_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00019E70 File Offset: 0x00018070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597097, XrefRangeEnd = 597107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipperBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00019EAC File Offset: 0x000180AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597107, XrefRangeEnd = 597128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipperBase.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00019EE8 File Offset: 0x000180E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597128, XrefRangeEnd = 597132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeLocalMinimaList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_DisposeLocalMinimaList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00019F1C File Offset: 0x0001811C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 597133, RefRangeEnd = 597137, XrefRangeStart = 597132, XrefRangeEnd = 597133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RangeTest(IntPoint Pt, ref bool useFullRange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &useFullRange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_RangeTest_Private_Void_IntPoint_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00019F68 File Offset: 0x00018168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597137, XrefRangeEnd = 597139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eNext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ePrev);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_InitEdge_Private_Void_TEdge_TEdge_TEdge_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00019FDC File Offset: 0x000181DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597139, XrefRangeEnd = 597140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEdge2(TEdge e, PolyType polyType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref polyType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_InitEdge2_Private_Void_TEdge_PolyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0001A02C File Offset: 0x0001822C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597140, XrefRangeEnd = 597142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEdge FindNextLocMin(TEdge E)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(E);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_FindNextLocMin_Private_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr3) : null;
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0001A07C File Offset: 0x0001827C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 597147, RefRangeEnd = 597151, XrefRangeStart = 597142, XrefRangeEnd = 597147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEdge ProcessBound(TEdge E, bool LeftBoundIsForward)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(E);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref LeftBoundIsForward;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_ProcessBound_Private_TEdge_TEdge_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr3) : null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0001A0DC File Offset: 0x000182DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 597335, RefRangeEnd = 597341, XrefRangeStart = 597151, XrefRangeEnd = 597335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref polyType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Closed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_AddPath_Public_Boolean_List_1_IntPoint_PolyType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0001A148 File Offset: 0x00018348
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 597347, RefRangeEnd = 597352, XrefRangeStart = 597341, XrefRangeEnd = 597347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ppg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref polyType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_AddPaths_Public_Boolean_List_1_List_1_IntPoint_PolyType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0001A1B4 File Offset: 0x000183B4
		[CallerCount(0)]
		public unsafe bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_Pt2IsBetweenPt1AndPt3_Internal_Boolean_IntPoint_IntPoint_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0001A21C File Offset: 0x0001841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597352, XrefRangeEnd = 597355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEdge RemoveEdge(TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_RemoveEdge_Private_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr3) : null;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001A26C File Offset: 0x0001846C
		[CallerCount(0)]
		public unsafe void SetDx(TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_SetDx_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001A2B0 File Offset: 0x000184B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 597362, RefRangeEnd = 597363, XrefRangeStart = 597355, XrefRangeEnd = 597362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertLocalMinima(LocalMinima newLm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newLm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_InsertLocalMinima_Private_Void_LocalMinima_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001A2F4 File Offset: 0x000184F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597363, XrefRangeEnd = 597365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PopLocalMinima(long Y, out LocalMinima current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Y;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_PopLocalMinima_Internal_Boolean_Int64_byref_LocalMinima_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			current = ((intPtr4 == 0) ? null : new LocalMinima(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001A360 File Offset: 0x00018560
		[CallerCount(0)]
		public unsafe void ReverseHorizontal(TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_ReverseHorizontal_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001A3A4 File Offset: 0x000185A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597365, XrefRangeEnd = 597386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipperBase.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0001A3E0 File Offset: 0x000185E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597433, RefRangeEnd = 597435, XrefRangeStart = 597386, XrefRangeEnd = 597433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntRect GetBounds(List<List<IntPoint>> paths)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_GetBounds_Public_Static_IntRect_List_1_List_1_IntPoint_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0001A424 File Offset: 0x00018624
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 597441, RefRangeEnd = 597446, XrefRangeStart = 597435, XrefRangeEnd = 597441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertScanbeam(long Y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_InsertScanbeam_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0001A464 File Offset: 0x00018664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597446, XrefRangeEnd = 597447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PopScanbeam(out long Y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &Y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_PopScanbeam_Internal_Boolean_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0001A4B0 File Offset: 0x000186B0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 318072, RefRangeEnd = 318096, XrefRangeStart = 318072, XrefRangeEnd = 318096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LocalMinimaPending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_LocalMinimaPending_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001A4EC File Offset: 0x000186EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597461, RefRangeEnd = 597463, XrefRangeStart = 597447, XrefRangeEnd = 597461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutRec CreateOutRec()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_CreateOutRec_Internal_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OutRec>(intPtr3) : null;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0001A52C File Offset: 0x0001872C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597463, XrefRangeEnd = 597471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeOutRec(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_DisposeOutRec_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0001A56C File Offset: 0x0001876C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 597478, RefRangeEnd = 597481, XrefRangeStart = 597471, XrefRangeEnd = 597478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEdgeIntoAEL(ref TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(e);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_UpdateEdgeIntoAEL_Internal_Void_byref_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				e = ((intPtr4 == 0) ? null : new TEdge(intPtr4));
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0001A5C4 File Offset: 0x000187C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 597502, RefRangeEnd = 597505, XrefRangeStart = 597481, XrefRangeEnd = 597502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapPositionsInAEL(TEdge edge1, TEdge edge2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edge1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(edge2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_SwapPositionsInAEL_Internal_Void_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0001A618 File Offset: 0x00018818
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 597510, RefRangeEnd = 597512, XrefRangeStart = 597505, XrefRangeEnd = 597510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteFromAEL(TEdge e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperBase.NativeMethodInfoPtr_DeleteFromAEL_Internal_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002B12 File Offset: 0x00000D12
		public ClipperBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0001A65C File Offset: 0x0001885C
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002B1B File Offset: 0x00000D1B
		public unsafe static double horizontal
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(ClipperBase.NativeFieldInfoPtr_horizontal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipperBase.NativeFieldInfoPtr_horizontal, (void*)(&value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0001A678 File Offset: 0x00018878
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002B29 File Offset: 0x00000D29
		public unsafe static int Skip
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClipperBase.NativeFieldInfoPtr_Skip, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipperBase.NativeFieldInfoPtr_Skip, (void*)(&value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0001A694 File Offset: 0x00018894
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002B37 File Offset: 0x00000D37
		public unsafe static int Unassigned
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClipperBase.NativeFieldInfoPtr_Unassigned, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipperBase.NativeFieldInfoPtr_Unassigned, (void*)(&value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0001A6B0 File Offset: 0x000188B0
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002B45 File Offset: 0x00000D45
		public unsafe static double tolerance
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(ClipperBase.NativeFieldInfoPtr_tolerance, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipperBase.NativeFieldInfoPtr_tolerance, (void*)(&value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0001A6CC File Offset: 0x000188CC
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002B53 File Offset: 0x00000D53
		public unsafe static long loRange
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(ClipperBase.NativeFieldInfoPtr_loRange, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipperBase.NativeFieldInfoPtr_loRange, (void*)(&value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0001A6E8 File Offset: 0x000188E8
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002B61 File Offset: 0x00000D61
		public unsafe static long hiRange
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(ClipperBase.NativeFieldInfoPtr_hiRange, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipperBase.NativeFieldInfoPtr_hiRange, (void*)(&value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0001A704 File Offset: 0x00018904
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002B6F File Offset: 0x00000D6F
		public unsafe LocalMinima m_MinimaList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_MinimaList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalMinima>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_MinimaList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0001A734 File Offset: 0x00018934
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002B8E File Offset: 0x00000D8E
		public unsafe LocalMinima m_CurrentLM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_CurrentLM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalMinima>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_CurrentLM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0001A764 File Offset: 0x00018964
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002BAD File Offset: 0x00000DAD
		public unsafe List<List<TEdge>> m_edges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_edges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<List<TEdge>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_edges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0001A794 File Offset: 0x00018994
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002BCC File Offset: 0x00000DCC
		public unsafe Scanbeam m_Scanbeam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_Scanbeam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scanbeam>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_Scanbeam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0001A7C4 File Offset: 0x000189C4
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00002BEB File Offset: 0x00000DEB
		public unsafe List<OutRec> m_PolyOuts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_PolyOuts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<OutRec>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_PolyOuts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0001A7F4 File Offset: 0x000189F4
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00002C0A File Offset: 0x00000E0A
		public unsafe TEdge m_ActiveEdges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_ActiveEdges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TEdge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_ActiveEdges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0001A824 File Offset: 0x00018A24
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002C29 File Offset: 0x00000E29
		public unsafe bool m_UseFullRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_UseFullRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_UseFullRange)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0001A84C File Offset: 0x00018A4C
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002C44 File Offset: 0x00000E44
		public unsafe bool m_HasOpenPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_HasOpenPaths);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr_m_HasOpenPaths)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0001A874 File Offset: 0x00018A74
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002C5F File Offset: 0x00000E5F
		public unsafe bool _PreserveCollinear_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr__PreserveCollinear_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperBase.NativeFieldInfoPtr__PreserveCollinear_k__BackingField)) = value;
			}
		}

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_horizontal;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_Skip;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_Unassigned;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_tolerance;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_loRange;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_hiRange;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_m_MinimaList;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentLM;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_m_edges;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_m_Scanbeam;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_m_PolyOuts;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveEdges;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_m_UseFullRange;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_m_HasOpenPaths;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr__PreserveCollinear_k__BackingField;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_near_zero_Internal_Static_Boolean_Double_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveCollinear_Public_get_Boolean_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_set_PreserveCollinear_Public_set_Void_Boolean_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Public_Void_byref_Int64_byref_Int64_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_IsHorizontal_Internal_Static_Boolean_TEdge_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_PointIsVertex_Internal_Boolean_IntPoint_OutPt_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_PointOnLineSegment_Internal_Boolean_IntPoint_IntPoint_IntPoint_Boolean_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_PointOnPolygon_Internal_Boolean_IntPoint_OutPt_Boolean_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_TEdge_TEdge_Boolean_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_Boolean_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_IntPoint_Boolean_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_DisposeLocalMinimaList_Private_Void_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_RangeTest_Private_Void_IntPoint_byref_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_InitEdge_Private_Void_TEdge_TEdge_TEdge_IntPoint_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_InitEdge2_Private_Void_TEdge_PolyType_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_FindNextLocMin_Private_TEdge_TEdge_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBound_Private_TEdge_TEdge_Boolean_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_AddPath_Public_Boolean_List_1_IntPoint_PolyType_Boolean_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_AddPaths_Public_Boolean_List_1_List_1_IntPoint_PolyType_Boolean_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_Pt2IsBetweenPt1AndPt3_Internal_Boolean_IntPoint_IntPoint_IntPoint_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEdge_Private_TEdge_TEdge_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_SetDx_Private_Void_TEdge_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_InsertLocalMinima_Private_Void_LocalMinima_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_PopLocalMinima_Internal_Boolean_Int64_byref_LocalMinima_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_ReverseHorizontal_Private_Void_TEdge_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_GetBounds_Public_Static_IntRect_List_1_List_1_IntPoint_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_InsertScanbeam_Internal_Void_Int64_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_PopScanbeam_Internal_Boolean_byref_Int64_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_LocalMinimaPending_Internal_Boolean_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_CreateOutRec_Internal_OutRec_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_DisposeOutRec_Internal_Void_Int32_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEdgeIntoAEL_Internal_Void_byref_TEdge_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_SwapPositionsInAEL_Internal_Void_TEdge_TEdge_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFromAEL_Internal_Void_TEdge_0;
	}
}
