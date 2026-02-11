using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public class Path : global::Il2CppSystem.Object
	{
		// Token: 0x060003E0 RID: 992 RVA: 0x00018718 File Offset: 0x00016918
		// Note: this type is marked as 'beforefieldinit'.
		static Path()
		{
			Il2CppClassPointerStore<Path>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Core.PathCore", "Path");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Path>.NativeClassPtr);
			Path.NativeFieldInfoPtr__catmullRomDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_catmullRomDecoder");
			Path.NativeFieldInfoPtr__linearDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_linearDecoder");
			Path.NativeFieldInfoPtr_wpLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "wpLengths");
			Path.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "type");
			Path.NativeFieldInfoPtr_subdivisionsXSegment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "subdivisionsXSegment");
			Path.NativeFieldInfoPtr_subdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "subdivisions");
			Path.NativeFieldInfoPtr_wps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "wps");
			Path.NativeFieldInfoPtr_controlPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "controlPoints");
			Path.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "length");
			Path.NativeFieldInfoPtr_isFinalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "isFinalized");
			Path.NativeFieldInfoPtr_timesTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "timesTable");
			Path.NativeFieldInfoPtr_lengthsTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "lengthsTable");
			Path.NativeFieldInfoPtr_linearWPIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "linearWPIndex");
			Path.NativeFieldInfoPtr__incrementalClone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_incrementalClone");
			Path.NativeFieldInfoPtr__incrementalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_incrementalIndex");
			Path.NativeFieldInfoPtr__decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_decoder");
			Path.NativeFieldInfoPtr__changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "_changed");
			Path.NativeFieldInfoPtr_nonLinearDrawWps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "nonLinearDrawWps");
			Path.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "targetPosition");
			Path.NativeFieldInfoPtr_lookAtPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "lookAtPosition");
			Path.NativeFieldInfoPtr_gizmoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "gizmoColor");
			Path.NativeMethodInfoPtr__ctor_Public_Void_PathType_Il2CppStructArray_1_Vector3_Int32_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664128);
			Path.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664129);
			Path.NativeMethodInfoPtr_FinalizePath_Internal_Void_Boolean_AxisConstraint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664130);
			Path.NativeMethodInfoPtr_GetPoint_Internal_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664131);
			Path.NativeMethodInfoPtr_ConvertToConstantPathPerc_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664132);
			Path.NativeMethodInfoPtr_GetWaypointIndexFromPerc_Internal_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664133);
			Path.NativeMethodInfoPtr_GetDrawPoints_Internal_Static_Il2CppStructArray_1_Vector3_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664134);
			Path.NativeMethodInfoPtr_RefreshNonLinearDrawWps_Internal_Static_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664135);
			Path.NativeMethodInfoPtr_Destroy_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664136);
			Path.NativeMethodInfoPtr_CloneIncremental_Internal_Path_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664137);
			Path.NativeMethodInfoPtr_AssignWaypoints_Internal_Void_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664138);
			Path.NativeMethodInfoPtr_AssignDecoder_Internal_Void_PathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664139);
			Path.NativeMethodInfoPtr_Draw_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664140);
			Path.NativeMethodInfoPtr_Draw_Private_Static_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100664141);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00018A04 File Offset: 0x00016C04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1132966, RefRangeEnd = 1132970, XrefRangeStart = 1132922, XrefRangeEnd = 1132966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Path(PathType type, Il2CppStructArray<Vector3> waypoints, int subdivisionsXSegment, Nullable<Color> gizmoColor = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Path>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(waypoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subdivisionsXSegment;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gizmoColor));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr__ctor_Public_Void_PathType_Il2CppStructArray_1_Vector3_Int32_Nullable_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00018A84 File Offset: 0x00016C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132970, XrefRangeEnd = 1132971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Path()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Path>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00018AC0 File Offset: 0x00016CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132971, XrefRangeEnd = 1132975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isClosedPath;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockPositionAxes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currTargetVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_FinalizePath_Internal_Void_Boolean_AxisConstraint_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00018B1C File Offset: 0x00016D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132976, RefRangeEnd = 1132977, XrefRangeStart = 1132975, XrefRangeEnd = 1132976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPoint(float perc, bool convertToConstantPerc = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref convertToConstantPerc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetPoint_Internal_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00018B74 File Offset: 0x00016D74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1132977, RefRangeEnd = 1132979, XrefRangeStart = 1132977, XrefRangeEnd = 1132977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ConvertToConstantPathPerc(float perc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_ConvertToConstantPathPerc_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00018BC0 File Offset: 0x00016DC0
		[CallerCount(0)]
		public unsafe int GetWaypointIndexFromPerc(float perc, bool isMovingForward)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref perc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMovingForward;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetWaypointIndexFromPerc_Internal_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00018C18 File Offset: 0x00016E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132982, RefRangeEnd = 1132983, XrefRangeStart = 1132979, XrefRangeEnd = 1132982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector3> GetDrawPoints(Path p, int drawSubdivisionsXSegment)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawSubdivisionsXSegment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetDrawPoints_Internal_Static_Il2CppStructArray_1_Vector3_Path_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00018C6C File Offset: 0x00016E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132983, XrefRangeEnd = 1132987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshNonLinearDrawWps(Path p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_RefreshNonLinearDrawWps_Internal_Static_Void_Path_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00018CA4 File Offset: 0x00016EA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1133007, RefRangeEnd = 1133009, XrefRangeStart = 1132987, XrefRangeEnd = 1133007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Destroy_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00018CD8 File Offset: 0x00016ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133047, RefRangeEnd = 1133048, XrefRangeStart = 1133009, XrefRangeEnd = 1133047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Path CloneIncremental(int loopIncrement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loopIncrement;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CloneIncremental_Internal_Path_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Path>(intPtr3) : null;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00018D24 File Offset: 0x00016F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133048, XrefRangeEnd = 1133050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignWaypoints(Il2CppStructArray<Vector3> newWps, bool cloneWps = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newWps);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cloneWps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_AssignWaypoints_Internal_Void_Il2CppStructArray_1_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00018D74 File Offset: 0x00016F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133050, XrefRangeEnd = 1133070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDecoder(PathType pathType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pathType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_AssignDecoder_Internal_Void_PathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00018DB4 File Offset: 0x00016FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133070, XrefRangeEnd = 1133071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Draw_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00018DE8 File Offset: 0x00016FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133085, RefRangeEnd = 1133086, XrefRangeStart = 1133071, XrefRangeEnd = 1133085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Draw(Path p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Draw_Private_Static_Void_Path_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003273 File Offset: 0x00001473
		public Path(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00018E20 File Offset: 0x00017020
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0000327C File Offset: 0x0000147C
		public unsafe static CatmullRomDecoder _catmullRomDecoder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr__catmullRomDecoder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CatmullRomDecoder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr__catmullRomDecoder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00018E48 File Offset: 0x00017048
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0000328E File Offset: 0x0000148E
		public unsafe static LinearDecoder _linearDecoder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr__linearDecoder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinearDecoder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr__linearDecoder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00018E70 File Offset: 0x00017070
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000032A0 File Offset: 0x000014A0
		public unsafe Il2CppStructArray<float> wpLengths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_wpLengths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_wpLengths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00018EA0 File Offset: 0x000170A0
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000032BF File Offset: 0x000014BF
		public unsafe PathType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00018EC8 File Offset: 0x000170C8
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x000032DA File Offset: 0x000014DA
		public unsafe int subdivisionsXSegment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_subdivisionsXSegment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_subdivisionsXSegment)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00018EF0 File Offset: 0x000170F0
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x000032F5 File Offset: 0x000014F5
		public unsafe int subdivisions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_subdivisions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_subdivisions)) = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00018F18 File Offset: 0x00017118
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003310 File Offset: 0x00001510
		public unsafe Il2CppStructArray<Vector3> wps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_wps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_wps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00018F48 File Offset: 0x00017148
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x0000332F File Offset: 0x0000152F
		public unsafe Il2CppStructArray<ControlPoint> controlPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_controlPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ControlPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_controlPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00018F78 File Offset: 0x00017178
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x0000334E File Offset: 0x0000154E
		public unsafe float length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00018FA0 File Offset: 0x000171A0
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00003369 File Offset: 0x00001569
		public unsafe bool isFinalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_isFinalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_isFinalized)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00018FC8 File Offset: 0x000171C8
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00003384 File Offset: 0x00001584
		public unsafe Il2CppStructArray<float> timesTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_timesTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_timesTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00018FF8 File Offset: 0x000171F8
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000033A3 File Offset: 0x000015A3
		public unsafe Il2CppStructArray<float> lengthsTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_lengthsTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_lengthsTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00019028 File Offset: 0x00017228
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x000033C2 File Offset: 0x000015C2
		public unsafe int linearWPIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_linearWPIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_linearWPIndex)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00019050 File Offset: 0x00017250
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x000033DD File Offset: 0x000015DD
		public unsafe Path _incrementalClone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__incrementalClone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__incrementalClone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00019080 File Offset: 0x00017280
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x000033FC File Offset: 0x000015FC
		public unsafe int _incrementalIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__incrementalIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__incrementalIndex)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x000190A8 File Offset: 0x000172A8
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00003417 File Offset: 0x00001617
		public unsafe ABSPathDecoder _decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ABSPathDecoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x000190D8 File Offset: 0x000172D8
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00003436 File Offset: 0x00001636
		public unsafe bool _changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr__changed)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00019100 File Offset: 0x00017300
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00003451 File Offset: 0x00001651
		public unsafe Il2CppStructArray<Vector3> nonLinearDrawWps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_nonLinearDrawWps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_nonLinearDrawWps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00019130 File Offset: 0x00017330
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00003470 File Offset: 0x00001670
		public unsafe Vector3 targetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_targetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_targetPosition)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00019158 File Offset: 0x00017358
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x0000348B File Offset: 0x0000168B
		public Nullable<Vector3> lookAtPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_lookAtPosition);
				return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_lookAtPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00019188 File Offset: 0x00017388
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x000034B9 File Offset: 0x000016B9
		public unsafe Color gizmoColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_gizmoColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Path.NativeFieldInfoPtr_gizmoColor)) = value;
			}
		}

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr__catmullRomDecoder;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr__linearDecoder;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr_wpLengths;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeFieldInfoPtr_subdivisionsXSegment;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr_subdivisions;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr_wps;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_controlPoints;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr_isFinalized;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeFieldInfoPtr_timesTable;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeFieldInfoPtr_lengthsTable;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeFieldInfoPtr_linearWPIndex;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeFieldInfoPtr__incrementalClone;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeFieldInfoPtr__incrementalIndex;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeFieldInfoPtr__decoder;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeFieldInfoPtr__changed;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeFieldInfoPtr_nonLinearDrawWps;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr_lookAtPosition;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeFieldInfoPtr_gizmoColor;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PathType_Il2CppStructArray_1_Vector3_Int32_Nullable_1_Color_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_FinalizePath_Internal_Void_Boolean_AxisConstraint_Vector3_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Internal_Vector3_Single_Boolean_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToConstantPathPerc_Internal_Single_Single_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_GetWaypointIndexFromPerc_Internal_Int32_Single_Boolean_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_GetDrawPoints_Internal_Static_Il2CppStructArray_1_Vector3_Path_Int32_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNonLinearDrawWps_Internal_Static_Void_Path_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Internal_Void_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_CloneIncremental_Internal_Path_Int32_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_AssignWaypoints_Internal_Void_Il2CppStructArray_1_Vector3_Boolean_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_AssignDecoder_Internal_Void_PathType_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Internal_Void_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Private_Static_Void_Path_0;
	}
}
