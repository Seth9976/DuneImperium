using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000042 RID: 66
[StructLayout(2)]
public struct ScreenRect
{
	// Token: 0x0600052D RID: 1325 RVA: 0x00028098 File Offset: 0x00026298
	// Note: this type is marked as 'beforefieldinit'.
	static ScreenRect()
	{
		Il2CppClassPointerStore<ScreenRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "ScreenRect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr);
		ScreenRect.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, "X");
		ScreenRect.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, "Y");
		ScreenRect.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, "Width");
		ScreenRect.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, "Height");
		ScreenRect.NativeMethodInfoPtr_op_Explicit_Public_Static_ScreenRect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664057);
		ScreenRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664058);
		ScreenRect.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664059);
		ScreenRect.NativeMethodInfoPtr__ctor_Public_Void_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664060);
		ScreenRect.NativeMethodInfoPtr_get_XMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664061);
		ScreenRect.NativeMethodInfoPtr_get_XMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664062);
		ScreenRect.NativeMethodInfoPtr_get_Left_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664063);
		ScreenRect.NativeMethodInfoPtr_get_Right_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664064);
		ScreenRect.NativeMethodInfoPtr_get_YMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664065);
		ScreenRect.NativeMethodInfoPtr_get_YMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664066);
		ScreenRect.NativeMethodInfoPtr_get_Bottom_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664067);
		ScreenRect.NativeMethodInfoPtr_get_Top_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664068);
		ScreenRect.NativeMethodInfoPtr_get_Center_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664069);
		ScreenRect.NativeMethodInfoPtr_get_Size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664070);
		ScreenRect.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664071);
		ScreenRect.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664072);
		ScreenRect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664073);
		ScreenRect.NativeMethodInfoPtr_Encapsulate_Public_Void_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664074);
		ScreenRect.NativeMethodInfoPtr_SetFromTransformedBoundsInCamera_Public_Void_Bounds_GlobalTransform_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664075);
		ScreenRect.NativeMethodInfoPtr_SetFromPoints_Public_Void_IList_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664076);
		ScreenRect.NativeMethodInfoPtr_SetFromPoints_Public_Void_IList_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664077);
		ScreenRect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664078);
		ScreenRect.NativeMethodInfoPtr_Intersects_Public_Static_Boolean_ScreenRect_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664079);
		ScreenRect.NativeMethodInfoPtr_Intersection_Public_Static_ScreenRect_ScreenRect_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664080);
		ScreenRect.NativeMethodInfoPtr_RectContainingPoints_Public_Static_ScreenRect_IList_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664081);
		ScreenRect.NativeMethodInfoPtr_RectContainingPoints_Public_Static_ScreenRect_IList_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664082);
		ScreenRect.NativeMethodInfoPtr_FromRectTransform_Public_Static_ScreenRect_RectTransform_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664083);
		ScreenRect.NativeMethodInfoPtr_FromWorldBoundsInCamera_Public_Static_ScreenRect_Bounds_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664084);
		ScreenRect.NativeMethodInfoPtr_FromTransformedBoundsInCamera_Public_Static_ScreenRect_Bounds_GlobalTransform_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664085);
		ScreenRect.NativeMethodInfoPtr_Encapsulating_Public_Static_ScreenRect_List_1_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664086);
		ScreenRect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100664087);
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x00028384 File Offset: 0x00026584
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 857686, RefRangeEnd = 857689, XrefRangeStart = 857686, XrefRangeEnd = 857686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator ScreenRect(Rect rect)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_op_Explicit_Public_Static_ScreenRect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x000283C4 File Offset: 0x000265C4
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenRect(float x, float y, float width, float height)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00028420 File Offset: 0x00026620
	[CallerCount(0)]
	public unsafe ScreenRect(Vector2 center, Vector2 dimensions)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref center;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimensions;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00028460 File Offset: 0x00026660
	[CallerCount(0)]
	public unsafe ScreenRect(ScreenRect otherRect)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref otherRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr__ctor_Public_Void_ScreenRect_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000532 RID: 1330 RVA: 0x00028494 File Offset: 0x00026694
	public unsafe float XMin
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 857689, RefRangeEnd = 857700, XrefRangeStart = 857689, XrefRangeEnd = 857689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_XMin_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000533 RID: 1331 RVA: 0x000284C4 File Offset: 0x000266C4
	public unsafe float XMax
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 857700, RefRangeEnd = 857711, XrefRangeStart = 857700, XrefRangeEnd = 857700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_XMax_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000534 RID: 1332 RVA: 0x000284F4 File Offset: 0x000266F4
	public unsafe float Left
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 857689, RefRangeEnd = 857700, XrefRangeStart = 857689, XrefRangeEnd = 857700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_Left_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06000535 RID: 1333 RVA: 0x00028524 File Offset: 0x00026724
	public unsafe float Right
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 857700, RefRangeEnd = 857711, XrefRangeStart = 857700, XrefRangeEnd = 857711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_Right_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000536 RID: 1334 RVA: 0x00028554 File Offset: 0x00026754
	public unsafe float YMin
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 857711, RefRangeEnd = 857722, XrefRangeStart = 857711, XrefRangeEnd = 857711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_YMin_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06000537 RID: 1335 RVA: 0x00028584 File Offset: 0x00026784
	public unsafe float YMax
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 857722, RefRangeEnd = 857733, XrefRangeStart = 857722, XrefRangeEnd = 857722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_YMax_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06000538 RID: 1336 RVA: 0x000285B4 File Offset: 0x000267B4
	public unsafe float Bottom
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 857711, RefRangeEnd = 857722, XrefRangeStart = 857711, XrefRangeEnd = 857722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_Bottom_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06000539 RID: 1337 RVA: 0x000285E4 File Offset: 0x000267E4
	public unsafe float Top
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 857722, RefRangeEnd = 857733, XrefRangeStart = 857722, XrefRangeEnd = 857733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_Top_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x0600053A RID: 1338 RVA: 0x00028614 File Offset: 0x00026814
	public unsafe Vector2 Center
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 857733, RefRangeEnd = 857747, XrefRangeStart = 857733, XrefRangeEnd = 857733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_Center_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x0600053B RID: 1339 RVA: 0x00028644 File Offset: 0x00026844
	public unsafe Vector2 Size
	{
		[CallerCount(0)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_Size_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x0600053C RID: 1340 RVA: 0x00028674 File Offset: 0x00026874
	// (set) Token: 0x0600053D RID: 1341 RVA: 0x000286A4 File Offset: 0x000268A4
	public unsafe Vector2 Position
	{
		[CallerCount(0)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x000286D8 File Offset: 0x000268D8
	[CallerCount(0)]
	public unsafe bool Contains(Vector2 point)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00028718 File Offset: 0x00026918
	[CallerCount(0)]
	public unsafe void Encapsulate(ScreenRect otherRect)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref otherRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_Encapsulate_Public_Void_ScreenRect_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0002874C File Offset: 0x0002694C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 857760, RefRangeEnd = 857762, XrefRangeStart = 857747, XrefRangeEnd = 857760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFromTransformedBoundsInCamera(Bounds bounds, GlobalTransform boundsTransform, Camera camera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boundsTransform;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_SetFromTransformedBoundsInCamera_Public_Void_Bounds_GlobalTransform_Camera_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x000287A0 File Offset: 0x000269A0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 857771, RefRangeEnd = 857774, XrefRangeStart = 857762, XrefRangeEnd = 857771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFromPoints(IList<Vector3> points)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_SetFromPoints_Public_Void_IList_1_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x000287D8 File Offset: 0x000269D8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 857783, RefRangeEnd = 857784, XrefRangeStart = 857774, XrefRangeEnd = 857783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFromPoints(IList<Vector2> points)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_SetFromPoints_Public_Void_IList_1_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00028810 File Offset: 0x00026A10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857784, XrefRangeEnd = 857807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0002883C File Offset: 0x00026A3C
	[CallerCount(0)]
	public unsafe static bool Intersects(ScreenRect a, ScreenRect b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_Intersects_Public_Static_Boolean_ScreenRect_ScreenRect_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00028888 File Offset: 0x00026A88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 857807, RefRangeEnd = 857808, XrefRangeStart = 857807, XrefRangeEnd = 857807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect Intersection(ScreenRect a, ScreenRect b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_Intersection_Public_Static_ScreenRect_ScreenRect_ScreenRect_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x000288D4 File Offset: 0x00026AD4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 857809, RefRangeEnd = 857812, XrefRangeStart = 857808, XrefRangeEnd = 857809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect RectContainingPoints(IList<Vector3> points)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_RectContainingPoints_Public_Static_ScreenRect_IList_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00028918 File Offset: 0x00026B18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857812, XrefRangeEnd = 857813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect RectContainingPoints(IList<Vector2> points)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_RectContainingPoints_Public_Static_ScreenRect_IList_1_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0002895C File Offset: 0x00026B5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857813, XrefRangeEnd = 857823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect FromRectTransform(RectTransform rectTransform, Camera screenCamera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(screenCamera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_FromRectTransform_Public_Static_ScreenRect_RectTransform_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x000289B0 File Offset: 0x00026BB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857823, XrefRangeEnd = 857828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect FromWorldBoundsInCamera(Bounds worldSpaceBounds, Camera camera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref worldSpaceBounds;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_FromWorldBoundsInCamera_Public_Static_ScreenRect_Bounds_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00028A00 File Offset: 0x00026C00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857828, XrefRangeEnd = 857829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect FromTransformedBoundsInCamera(Bounds bounds, GlobalTransform boundsTransform, Camera camera)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boundsTransform;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_FromTransformedBoundsInCamera_Public_Static_ScreenRect_Bounds_GlobalTransform_Camera_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00028A60 File Offset: 0x00026C60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857829, XrefRangeEnd = 857836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenRect Encapsulating(List<ScreenRect> rects)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_Encapsulating_Public_Static_ScreenRect_List_1_ScreenRect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00028AA4 File Offset: 0x00026CA4
	[CallerCount(0)]
	public unsafe bool Equals(ScreenRect other)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenRect_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00003DCA File Offset: 0x00001FCA
	public global::Il2CppSystem.Object BoxIl2CppObject()
	{
		return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, ref this));
	}

	// Token: 0x040003C8 RID: 968
	private static readonly IntPtr NativeFieldInfoPtr_X;

	// Token: 0x040003C9 RID: 969
	private static readonly IntPtr NativeFieldInfoPtr_Y;

	// Token: 0x040003CA RID: 970
	private static readonly IntPtr NativeFieldInfoPtr_Width;

	// Token: 0x040003CB RID: 971
	private static readonly IntPtr NativeFieldInfoPtr_Height;

	// Token: 0x040003CC RID: 972
	private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ScreenRect_Rect_0;

	// Token: 0x040003CD RID: 973
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

	// Token: 0x040003CE RID: 974
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

	// Token: 0x040003CF RID: 975
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScreenRect_0;

	// Token: 0x040003D0 RID: 976
	private static readonly IntPtr NativeMethodInfoPtr_get_XMin_Public_get_Single_0;

	// Token: 0x040003D1 RID: 977
	private static readonly IntPtr NativeMethodInfoPtr_get_XMax_Public_get_Single_0;

	// Token: 0x040003D2 RID: 978
	private static readonly IntPtr NativeMethodInfoPtr_get_Left_Public_get_Single_0;

	// Token: 0x040003D3 RID: 979
	private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Single_0;

	// Token: 0x040003D4 RID: 980
	private static readonly IntPtr NativeMethodInfoPtr_get_YMin_Public_get_Single_0;

	// Token: 0x040003D5 RID: 981
	private static readonly IntPtr NativeMethodInfoPtr_get_YMax_Public_get_Single_0;

	// Token: 0x040003D6 RID: 982
	private static readonly IntPtr NativeMethodInfoPtr_get_Bottom_Public_get_Single_0;

	// Token: 0x040003D7 RID: 983
	private static readonly IntPtr NativeMethodInfoPtr_get_Top_Public_get_Single_0;

	// Token: 0x040003D8 RID: 984
	private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector2_0;

	// Token: 0x040003D9 RID: 985
	private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector2_0;

	// Token: 0x040003DA RID: 986
	private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector2_0;

	// Token: 0x040003DB RID: 987
	private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0;

	// Token: 0x040003DC RID: 988
	private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0;

	// Token: 0x040003DD RID: 989
	private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_ScreenRect_0;

	// Token: 0x040003DE RID: 990
	private static readonly IntPtr NativeMethodInfoPtr_SetFromTransformedBoundsInCamera_Public_Void_Bounds_GlobalTransform_Camera_0;

	// Token: 0x040003DF RID: 991
	private static readonly IntPtr NativeMethodInfoPtr_SetFromPoints_Public_Void_IList_1_Vector3_0;

	// Token: 0x040003E0 RID: 992
	private static readonly IntPtr NativeMethodInfoPtr_SetFromPoints_Public_Void_IList_1_Vector2_0;

	// Token: 0x040003E1 RID: 993
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	// Token: 0x040003E2 RID: 994
	private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Static_Boolean_ScreenRect_ScreenRect_0;

	// Token: 0x040003E3 RID: 995
	private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_Static_ScreenRect_ScreenRect_ScreenRect_0;

	// Token: 0x040003E4 RID: 996
	private static readonly IntPtr NativeMethodInfoPtr_RectContainingPoints_Public_Static_ScreenRect_IList_1_Vector3_0;

	// Token: 0x040003E5 RID: 997
	private static readonly IntPtr NativeMethodInfoPtr_RectContainingPoints_Public_Static_ScreenRect_IList_1_Vector2_0;

	// Token: 0x040003E6 RID: 998
	private static readonly IntPtr NativeMethodInfoPtr_FromRectTransform_Public_Static_ScreenRect_RectTransform_Camera_0;

	// Token: 0x040003E7 RID: 999
	private static readonly IntPtr NativeMethodInfoPtr_FromWorldBoundsInCamera_Public_Static_ScreenRect_Bounds_Camera_0;

	// Token: 0x040003E8 RID: 1000
	private static readonly IntPtr NativeMethodInfoPtr_FromTransformedBoundsInCamera_Public_Static_ScreenRect_Bounds_GlobalTransform_Camera_0;

	// Token: 0x040003E9 RID: 1001
	private static readonly IntPtr NativeMethodInfoPtr_Encapsulating_Public_Static_ScreenRect_List_1_ScreenRect_0;

	// Token: 0x040003EA RID: 1002
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenRect_0;

	// Token: 0x040003EB RID: 1003
	[FieldOffset(0)]
	public float X;

	// Token: 0x040003EC RID: 1004
	[FieldOffset(4)]
	public float Y;

	// Token: 0x040003ED RID: 1005
	[FieldOffset(8)]
	public float Width;

	// Token: 0x040003EE RID: 1006
	[FieldOffset(12)]
	public float Height;
}
