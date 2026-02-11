using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000023 RID: 35
	public class ClipperOffset : Object
	{
		// Token: 0x06000226 RID: 550 RVA: 0x0001D814 File Offset: 0x0001BA14
		// Note: this type is marked as 'beforefieldinit'.
		static ClipperOffset()
		{
			Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ClipperOffset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr);
			ClipperOffset.NativeFieldInfoPtr_m_destPolys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_destPolys");
			ClipperOffset.NativeFieldInfoPtr_m_srcPoly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_srcPoly");
			ClipperOffset.NativeFieldInfoPtr_m_destPoly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_destPoly");
			ClipperOffset.NativeFieldInfoPtr_m_normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_normals");
			ClipperOffset.NativeFieldInfoPtr_m_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_delta");
			ClipperOffset.NativeFieldInfoPtr_m_sinA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_sinA");
			ClipperOffset.NativeFieldInfoPtr_m_sin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_sin");
			ClipperOffset.NativeFieldInfoPtr_m_cos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_cos");
			ClipperOffset.NativeFieldInfoPtr_m_StepsPerRad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_StepsPerRad");
			ClipperOffset.NativeFieldInfoPtr_m_lowest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_lowest");
			ClipperOffset.NativeFieldInfoPtr_m_polyNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "m_polyNodes");
			ClipperOffset.NativeFieldInfoPtr__ArcTolerance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "<ArcTolerance>k__BackingField");
			ClipperOffset.NativeFieldInfoPtr_two_pi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "two_pi");
			ClipperOffset.NativeFieldInfoPtr_def_arc_tolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, "def_arc_tolerance");
			ClipperOffset.NativeMethodInfoPtr_get_ArcTolerance_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663583);
			ClipperOffset.NativeMethodInfoPtr_set_ArcTolerance_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663584);
			ClipperOffset.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663585);
			ClipperOffset.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663586);
			ClipperOffset.NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663587);
			ClipperOffset.NativeMethodInfoPtr_AddPath_Public_Void_List_1_IntPoint_JoinType_EndType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663588);
			ClipperOffset.NativeMethodInfoPtr_AddPaths_Public_Void_List_1_List_1_IntPoint_JoinType_EndType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663589);
			ClipperOffset.NativeMethodInfoPtr_FixOrientations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663590);
			ClipperOffset.NativeMethodInfoPtr_GetUnitNormal_Internal_Static_DoublePoint_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663591);
			ClipperOffset.NativeMethodInfoPtr_DoOffset_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663592);
			ClipperOffset.NativeMethodInfoPtr_Execute_Public_Void_byref_List_1_List_1_IntPoint_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663593);
			ClipperOffset.NativeMethodInfoPtr_Execute_Public_Void_byref_PolyTree_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663594);
			ClipperOffset.NativeMethodInfoPtr_OffsetPoint_Private_Void_Int32_byref_Int32_JoinType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663595);
			ClipperOffset.NativeMethodInfoPtr_DoSquare_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663596);
			ClipperOffset.NativeMethodInfoPtr_DoMiter_Internal_Void_Int32_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663597);
			ClipperOffset.NativeMethodInfoPtr_DoRound_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr, 100663598);
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0001DA9C File Offset: 0x0001BC9C
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		public unsafe double ArcTolerance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_get_ArcTolerance_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_set_ArcTolerance_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0001DB18 File Offset: 0x0001BD18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 598957, RefRangeEnd = 598959, XrefRangeStart = 598944, XrefRangeEnd = 598957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipperOffset(double arcTolerance = 0.25)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperOffset>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arcTolerance;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0001DB60 File Offset: 0x0001BD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 598959, XrefRangeEnd = 598961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0001DB94 File Offset: 0x0001BD94
		[CallerCount(0)]
		public unsafe static long Round(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0001DBD4 File Offset: 0x0001BDD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 599016, RefRangeEnd = 599019, XrefRangeStart = 598961, XrefRangeEnd = 599016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPath(List<IntPoint> path, JoinType joinType, EndType endType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref joinType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_AddPath_Public_Void_List_1_IntPoint_JoinType_EndType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0001DC34 File Offset: 0x0001BE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599019, XrefRangeEnd = 599034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPaths(List<List<IntPoint>> paths, JoinType joinType, EndType endType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref joinType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_AddPaths_Public_Void_List_1_List_1_IntPoint_JoinType_EndType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0001DC94 File Offset: 0x0001BE94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599053, RefRangeEnd = 599055, XrefRangeStart = 599034, XrefRangeEnd = 599053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixOrientations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_FixOrientations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599061, RefRangeEnd = 599063, XrefRangeStart = 599055, XrefRangeEnd = 599061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_GetUnitNormal_Internal_Static_DoublePoint_IntPoint_IntPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0001DD14 File Offset: 0x0001BF14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599211, RefRangeEnd = 599213, XrefRangeStart = 599063, XrefRangeEnd = 599211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoOffset(double delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_DoOffset_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0001DD54 File Offset: 0x0001BF54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 599252, RefRangeEnd = 599254, XrefRangeStart = 599213, XrefRangeEnd = 599252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(ref List<List<IntPoint>> solution, double delta, int inputSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(solution);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_Execute_Public_Void_byref_List_1_List_1_IntPoint_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			solution = ((intPtr4 == 0) ? null : new List<List<IntPoint>>(intPtr4));
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0001DDC8 File Offset: 0x0001BFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599254, XrefRangeEnd = 599313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(ref PolyTree solution, double delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(solution);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delta;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_Execute_Public_Void_byref_PolyTree_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			solution = ((intPtr4 == 0) ? null : new PolyTree(intPtr4));
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0001DE30 File Offset: 0x0001C030
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 599384, RefRangeEnd = 599389, XrefRangeStart = 599313, XrefRangeEnd = 599384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OffsetPoint(int j, ref int k, JoinType jointype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref j;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &k;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jointype;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_OffsetPoint_Private_Void_Int32_byref_Int32_JoinType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0001DE8C File Offset: 0x0001C08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599389, XrefRangeEnd = 599456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSquare(int j, int k)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref j;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_DoSquare_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0001DED8 File Offset: 0x0001C0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 599456, XrefRangeEnd = 599484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoMiter(int j, int k, double r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref j;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_DoMiter_Internal_Void_Int32_Int32_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0001DF34 File Offset: 0x0001C134
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 599532, RefRangeEnd = 599535, XrefRangeStart = 599484, XrefRangeEnd = 599532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoRound(int j, int k)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref j;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperOffset.NativeMethodInfoPtr_DoRound_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002E3F File Offset: 0x0000103F
		public ClipperOffset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0001DF80 File Offset: 0x0001C180
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002E48 File Offset: 0x00001048
		public unsafe List<List<IntPoint>> m_destPolys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_destPolys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<List<IntPoint>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_destPolys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0001DFB0 File Offset: 0x0001C1B0
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002E67 File Offset: 0x00001067
		public unsafe List<IntPoint> m_srcPoly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_srcPoly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_srcPoly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0001DFE0 File Offset: 0x0001C1E0
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00002E86 File Offset: 0x00001086
		public unsafe List<IntPoint> m_destPoly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_destPoly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IntPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_destPoly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0001E010 File Offset: 0x0001C210
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002EA5 File Offset: 0x000010A5
		public unsafe List<DoublePoint> m_normals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_normals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DoublePoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_normals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0001E040 File Offset: 0x0001C240
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00002EC4 File Offset: 0x000010C4
		public unsafe double m_delta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_delta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_delta)) = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0001E068 File Offset: 0x0001C268
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002EDF File Offset: 0x000010DF
		public unsafe double m_sinA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_sinA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_sinA)) = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0001E090 File Offset: 0x0001C290
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002EFA File Offset: 0x000010FA
		public unsafe double m_sin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_sin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_sin)) = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0001E0B8 File Offset: 0x0001C2B8
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002F15 File Offset: 0x00001115
		public unsafe double m_cos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_cos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_cos)) = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0001E0E0 File Offset: 0x0001C2E0
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002F30 File Offset: 0x00001130
		public unsafe double m_StepsPerRad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_StepsPerRad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_StepsPerRad)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0001E108 File Offset: 0x0001C308
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002F4B File Offset: 0x0000114B
		public unsafe IntPoint m_lowest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_lowest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_lowest)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0001E130 File Offset: 0x0001C330
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002F66 File Offset: 0x00001166
		public unsafe PolyNode m_polyNodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_polyNodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolyNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr_m_polyNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0001E160 File Offset: 0x0001C360
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002F85 File Offset: 0x00001185
		public unsafe double _ArcTolerance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr__ArcTolerance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperOffset.NativeFieldInfoPtr__ArcTolerance_k__BackingField)) = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0001E188 File Offset: 0x0001C388
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002FA0 File Offset: 0x000011A0
		public unsafe static double two_pi
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(ClipperOffset.NativeFieldInfoPtr_two_pi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipperOffset.NativeFieldInfoPtr_two_pi, (void*)(&value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002FAE File Offset: 0x000011AE
		public unsafe static double def_arc_tolerance
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(ClipperOffset.NativeFieldInfoPtr_def_arc_tolerance, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipperOffset.NativeFieldInfoPtr_def_arc_tolerance, (void*)(&value));
			}
		}

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_m_destPolys;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_m_srcPoly;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_m_destPoly;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_m_normals;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_m_delta;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_m_sinA;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_m_sin;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_m_cos;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_m_StepsPerRad;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_m_lowest;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_m_polyNodes;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr__ArcTolerance_k__BackingField;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_two_pi;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_def_arc_tolerance;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_get_ArcTolerance_Public_get_Double_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_set_ArcTolerance_Public_set_Void_Double_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_AddPath_Public_Void_List_1_IntPoint_JoinType_EndType_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_AddPaths_Public_Void_List_1_List_1_IntPoint_JoinType_EndType_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_FixOrientations_Private_Void_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitNormal_Internal_Static_DoublePoint_IntPoint_IntPoint_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_DoOffset_Private_Void_Double_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_byref_List_1_List_1_IntPoint_Double_Int32_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_byref_PolyTree_Double_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_OffsetPoint_Private_Void_Int32_byref_Int32_JoinType_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_DoSquare_Internal_Void_Int32_Int32_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_DoMiter_Internal_Void_Int32_Int32_Double_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_DoRound_Internal_Void_Int32_Int32_0;
	}
}
