using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200004D RID: 77
public static class ColorUtil : global::Il2CppSystem.Object
{
	// Token: 0x060005B2 RID: 1458 RVA: 0x0002A2C8 File Offset: 0x000284C8
	// Note: this type is marked as 'beforefieldinit'.
	static ColorUtil()
	{
		Il2CppClassPointerStore<ColorUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "ColorUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr);
		ColorUtil.NativeMethodInfoPtr_RGB_Public_Static_Color_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664142);
		ColorUtil.NativeMethodInfoPtr_RGB_Public_Static_Color_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664143);
		ColorUtil.NativeMethodInfoPtr_RGB_Public_Static_Color_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664144);
		ColorUtil.NativeMethodInfoPtr_Hex_Public_Static_Color_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664145);
		ColorUtil.NativeMethodInfoPtr_Hex_Public_Static_Color_String_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664146);
		ColorUtil.NativeMethodInfoPtr_Hex_Public_Static_Color_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664147);
		ColorUtil.NativeMethodInfoPtr_Hex_Public_Static_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664148);
		ColorUtil.NativeMethodInfoPtr_ToColor32_Public_Static_Color32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664149);
		ColorUtil.NativeMethodInfoPtr_WithRed_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664150);
		ColorUtil.NativeMethodInfoPtr_WithGreen_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664151);
		ColorUtil.NativeMethodInfoPtr_WithBlue_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664152);
		ColorUtil.NativeMethodInfoPtr_WithAlpha_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664153);
		ColorUtil.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664154);
		ColorUtil.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664155);
		ColorUtil.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Nullable_1_Color32_Nullable_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664156);
		ColorUtil.NativeMethodInfoPtr_ToUint_Public_Static_UInt32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664157);
		ColorUtil.NativeMethodInfoPtr_ToInt_Public_Static_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664158);
		ColorUtil.NativeMethodInfoPtr_ToUint_Public_Static_UInt32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtil>.NativeClassPtr, 100664159);
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x0002A460 File Offset: 0x00028660
	[CallerCount(0)]
	public unsafe static Color RGB(int r, int g, int b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref r;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_RGB_Public_Static_Color_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x0002A4BC File Offset: 0x000286BC
	[CallerCount(0)]
	public unsafe static Color RGB(int r, int g, int b, float alpha)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref r;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_RGB_Public_Static_Color_Int32_Int32_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0002A524 File Offset: 0x00028724
	[CallerCount(0)]
	public unsafe static Color RGB(int r, int g, int b, int alpha)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref r;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_RGB_Public_Static_Color_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x0002A58C File Offset: 0x0002878C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858135, XrefRangeEnd = 858136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color Hex(string r, string g, string b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(r);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(g);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_Hex_Public_Static_Color_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x0002A5F4 File Offset: 0x000287F4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 858145, RefRangeEnd = 858148, XrefRangeStart = 858136, XrefRangeEnd = 858145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color Hex(string r, string g, string b, float alpha)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(r);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(g);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_Hex_Public_Static_Color_String_String_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x0002A668 File Offset: 0x00028868
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858148, XrefRangeEnd = 858157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color Hex(string rgb, float alpha)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(rgb);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_Hex_Public_Static_Color_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x0002A6B8 File Offset: 0x000288B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858157, XrefRangeEnd = 858166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color Hex(string rgb)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(rgb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_Hex_Public_Static_Color_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0002A6FC File Offset: 0x000288FC
	[CallerCount(0)]
	public unsafe static Color32 ToColor32(this Color color)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_ToColor32_Public_Static_Color32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x0002A73C File Offset: 0x0002893C
	[CallerCount(0)]
	public unsafe static Color WithRed(this Color color, float red)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref color;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref red;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_WithRed_Public_Static_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0002A788 File Offset: 0x00028988
	[CallerCount(0)]
	public unsafe static Color WithGreen(this Color color, float green)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref color;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref green;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_WithGreen_Public_Static_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0002A7D4 File Offset: 0x000289D4
	[CallerCount(0)]
	public unsafe static Color WithBlue(this Color color, float blue)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref color;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blue;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_WithBlue_Public_Static_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0002A820 File Offset: 0x00028A20
	[CallerCount(0)]
	public unsafe static Color WithAlpha(this Color color, float alpha)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref color;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alpha;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_WithAlpha_Public_Static_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x0002A86C File Offset: 0x00028A6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858166, XrefRangeEnd = 858170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Equals(Color color, Color other)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref color;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0002A8B8 File Offset: 0x00028AB8
	[CallerCount(0)]
	public unsafe static bool Equals(Color32 color, Color32 other)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref color;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0002A904 File Offset: 0x00028B04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858170, XrefRangeEnd = 858176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Equals(Nullable<Color32> color, Nullable<Color32> other)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(color));
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Nullable_1_Color32_Nullable_1_Color32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x0002A964 File Offset: 0x00028B64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858176, XrefRangeEnd = 858177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUint(this Color color)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_ToUint_Public_Static_UInt32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x0002A9A4 File Offset: 0x00028BA4
	[CallerCount(0)]
	public unsafe static int ToInt(this Color32 color)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_ToInt_Public_Static_Int32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x0002A9E4 File Offset: 0x00028BE4
	[CallerCount(0)]
	public unsafe static uint ToUint(this Color32 color)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtil.NativeMethodInfoPtr_ToUint_Public_Static_UInt32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060005C5 RID: 1477 RVA: 0x00003FC5 File Offset: 0x000021C5
	public ColorUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000442 RID: 1090
	private static readonly IntPtr NativeMethodInfoPtr_RGB_Public_Static_Color_Int32_Int32_Int32_0;

	// Token: 0x04000443 RID: 1091
	private static readonly IntPtr NativeMethodInfoPtr_RGB_Public_Static_Color_Int32_Int32_Int32_Single_0;

	// Token: 0x04000444 RID: 1092
	private static readonly IntPtr NativeMethodInfoPtr_RGB_Public_Static_Color_Int32_Int32_Int32_Int32_0;

	// Token: 0x04000445 RID: 1093
	private static readonly IntPtr NativeMethodInfoPtr_Hex_Public_Static_Color_String_String_String_0;

	// Token: 0x04000446 RID: 1094
	private static readonly IntPtr NativeMethodInfoPtr_Hex_Public_Static_Color_String_String_String_Single_0;

	// Token: 0x04000447 RID: 1095
	private static readonly IntPtr NativeMethodInfoPtr_Hex_Public_Static_Color_String_Single_0;

	// Token: 0x04000448 RID: 1096
	private static readonly IntPtr NativeMethodInfoPtr_Hex_Public_Static_Color_String_0;

	// Token: 0x04000449 RID: 1097
	private static readonly IntPtr NativeMethodInfoPtr_ToColor32_Public_Static_Color32_Color_0;

	// Token: 0x0400044A RID: 1098
	private static readonly IntPtr NativeMethodInfoPtr_WithRed_Public_Static_Color_Color_Single_0;

	// Token: 0x0400044B RID: 1099
	private static readonly IntPtr NativeMethodInfoPtr_WithGreen_Public_Static_Color_Color_Single_0;

	// Token: 0x0400044C RID: 1100
	private static readonly IntPtr NativeMethodInfoPtr_WithBlue_Public_Static_Color_Color_Single_0;

	// Token: 0x0400044D RID: 1101
	private static readonly IntPtr NativeMethodInfoPtr_WithAlpha_Public_Static_Color_Color_Single_0;

	// Token: 0x0400044E RID: 1102
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_Color_Color_0;

	// Token: 0x0400044F RID: 1103
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_Color32_Color32_0;

	// Token: 0x04000450 RID: 1104
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_Nullable_1_Color32_Nullable_1_Color32_0;

	// Token: 0x04000451 RID: 1105
	private static readonly IntPtr NativeMethodInfoPtr_ToUint_Public_Static_UInt32_Color_0;

	// Token: 0x04000452 RID: 1106
	private static readonly IntPtr NativeMethodInfoPtr_ToInt_Public_Static_Int32_Color32_0;

	// Token: 0x04000453 RID: 1107
	private static readonly IntPtr NativeMethodInfoPtr_ToUint_Public_Static_UInt32_Color32_0;
}
