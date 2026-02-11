using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000050 RID: 80
public static class GizmosUtil : global::Il2CppSystem.Object
{
	// Token: 0x06000621 RID: 1569 RVA: 0x0002C890 File Offset: 0x0002AA90
	// Note: this type is marked as 'beforefieldinit'.
	static GizmosUtil()
	{
		Il2CppClassPointerStore<GizmosUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "GizmosUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmosUtil>.NativeClassPtr);
		GizmosUtil.NativeFieldInfoPtr_DEFAULT_CIRCLE_RESOLUTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmosUtil>.NativeClassPtr, "DEFAULT_CIRCLE_RESOLUTION");
		GizmosUtil.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Transform_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmosUtil>.NativeClassPtr, 100664236);
		GizmosUtil.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_GlobalTransform_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmosUtil>.NativeClassPtr, 100664237);
		GizmosUtil.NativeMethodInfoPtr_DrawWireCircle_Public_Static_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmosUtil>.NativeClassPtr, 100664238);
		GizmosUtil.NativeMethodInfoPtr_DrawWireCircle_Public_Static_Void_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmosUtil>.NativeClassPtr, 100664239);
		GizmosUtil.NativeMethodInfoPtr_DrawPlane_Public_Static_Void_Plane_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmosUtil>.NativeClassPtr, 100664240);
		GizmosUtil.NativeMethodInfoPtr_DrawScreenRect_Public_Static_Void_Camera_ScreenRect_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmosUtil>.NativeClassPtr, 100664241);
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x0002C94C File Offset: 0x0002AB4C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 859358, RefRangeEnd = 859361, XrefRangeStart = 859340, XrefRangeEnd = 859358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawWireCube(Transform transform, Vector3 size, Vector3 offset, Color color)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmosUtil.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Transform_Vector3_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x0002C9AC File Offset: 0x0002ABAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859361, XrefRangeEnd = 859382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawWireCube(GlobalTransform transform, Vector3 size, Vector3 offset, Color color)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref transform;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmosUtil.NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_GlobalTransform_Vector3_Vector3_Color_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x0002CA08 File Offset: 0x0002AC08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859382, XrefRangeEnd = 859386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawWireCircle(Vector3 center, Vector3 axis, float radius)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref center;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmosUtil.NativeMethodInfoPtr_DrawWireCircle_Public_Static_Void_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x0002CA58 File Offset: 0x0002AC58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859386, XrefRangeEnd = 859390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawWireCircle(Vector3 center, Vector3 axis, float radius, int resolution)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref center;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmosUtil.NativeMethodInfoPtr_DrawWireCircle_Public_Static_Void_Vector3_Vector3_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x0002CAB4 File Offset: 0x0002ACB4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859413, RefRangeEnd = 859414, XrefRangeStart = 859390, XrefRangeEnd = 859413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawPlane(this Plane plane, Vector3 position, float size)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref plane;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmosUtil.NativeMethodInfoPtr_DrawPlane_Public_Static_Void_Plane_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x0002CB04 File Offset: 0x0002AD04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859414, XrefRangeEnd = 859439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawScreenRect(Camera camera, ScreenRect screenRect, Nullable<Color> color = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenRect;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(color));
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmosUtil.NativeMethodInfoPtr_DrawScreenRect_Public_Static_Void_Camera_ScreenRect_Nullable_1_Color_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x0000404C File Offset: 0x0000224C
	public GizmosUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000629 RID: 1577 RVA: 0x0002CB60 File Offset: 0x0002AD60
	// (set) Token: 0x0600062A RID: 1578 RVA: 0x00004055 File Offset: 0x00002255
	public unsafe static int DEFAULT_CIRCLE_RESOLUTION
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(GizmosUtil.NativeFieldInfoPtr_DEFAULT_CIRCLE_RESOLUTION, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GizmosUtil.NativeFieldInfoPtr_DEFAULT_CIRCLE_RESOLUTION, (void*)(&value));
		}
	}

	// Token: 0x040004A5 RID: 1189
	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_CIRCLE_RESOLUTION;

	// Token: 0x040004A6 RID: 1190
	private static readonly IntPtr NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_Transform_Vector3_Vector3_Color_0;

	// Token: 0x040004A7 RID: 1191
	private static readonly IntPtr NativeMethodInfoPtr_DrawWireCube_Public_Static_Void_GlobalTransform_Vector3_Vector3_Color_0;

	// Token: 0x040004A8 RID: 1192
	private static readonly IntPtr NativeMethodInfoPtr_DrawWireCircle_Public_Static_Void_Vector3_Vector3_Single_0;

	// Token: 0x040004A9 RID: 1193
	private static readonly IntPtr NativeMethodInfoPtr_DrawWireCircle_Public_Static_Void_Vector3_Vector3_Single_Int32_0;

	// Token: 0x040004AA RID: 1194
	private static readonly IntPtr NativeMethodInfoPtr_DrawPlane_Public_Static_Void_Plane_Vector3_Single_0;

	// Token: 0x040004AB RID: 1195
	private static readonly IntPtr NativeMethodInfoPtr_DrawScreenRect_Public_Static_Void_Camera_ScreenRect_Nullable_1_Color_0;
}
