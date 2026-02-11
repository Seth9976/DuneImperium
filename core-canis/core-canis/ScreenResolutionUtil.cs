using System;
using dwd.core.video.settings;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000060 RID: 96
public static class ScreenResolutionUtil : Object
{
	// Token: 0x060006DF RID: 1759 RVA: 0x0002F85C File Offset: 0x0002DA5C
	// Note: this type is marked as 'beforefieldinit'.
	static ScreenResolutionUtil()
	{
		Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "ScreenResolutionUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr);
		ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_FOUR_BY_THREE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, "ASPECT_FOUR_BY_THREE");
		ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_THREE_BY_TWO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, "ASPECT_THREE_BY_TWO");
		ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_SIXTEEN_BY_TEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, "ASPECT_SIXTEEN_BY_TEN");
		ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_FIVE_BY_THREE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, "ASPECT_FIVE_BY_THREE");
		ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_SEVENTEEN_BY_TEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, "ASPECT_SEVENTEEN_BY_TEN");
		ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_SIXTEEN_BY_NINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, "ASPECT_SIXTEEN_BY_NINE");
		ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_NINETEEN_BY_TEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, "ASPECT_NINETEEN_BY_TEN");
		ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_TWO_BY_ONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, "ASPECT_TWO_BY_ONE");
		ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_FIFTEENPOINTFOUR_BY_TEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, "ASPECT_FIFTEENPOINTFOUR_BY_TEN");
		ScreenResolutionUtil.NativeMethodInfoPtr_AspectWithinRange_Public_Static_Boolean_ScreenResolution_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664345);
		ScreenResolutionUtil.NativeMethodInfoPtr_MatchAspectWithRoundedPrecision_Private_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664346);
		ScreenResolutionUtil.NativeMethodInfoPtr_IsResolution_Public_Static_Boolean_EnumResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664347);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is4By3_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664348);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is15Point4By10_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664349);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is3By2_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664350);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is16By10_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664351);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is5By3_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664352);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is17By10_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664353);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is16By9_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664354);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is16By9_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664355);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is19By10_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664356);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is2By1_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664357);
		ScreenResolutionUtil.NativeMethodInfoPtr_Is2By1OrWider_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664358);
		ScreenResolutionUtil.NativeMethodInfoPtr_get_Is4K_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664359);
		ScreenResolutionUtil.NativeMethodInfoPtr_IsNativeAspectRatio_Public_Static_Boolean_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664360);
		ScreenResolutionUtil.NativeMethodInfoPtr_IsNativeAspectRatio_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664361);
		ScreenResolutionUtil.NativeMethodInfoPtr_DefaultFilter_Public_Static_Boolean_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664362);
		ScreenResolutionUtil.NativeMethodInfoPtr_DefaultFilterWithNative_Public_Static_Boolean_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664363);
		ScreenResolutionUtil.NativeMethodInfoPtr_MaxSixteenByNineFilter_Public_Static_Boolean_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664364);
		ScreenResolutionUtil.NativeMethodInfoPtr_Apply_Public_Static_Boolean_ScreenSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664365);
		ScreenResolutionUtil.NativeMethodInfoPtr_Apply_Public_Static_Boolean_ScreenResolution_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664366);
		ScreenResolutionUtil.NativeMethodInfoPtr_Apply_Public_Static_Boolean_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionUtil>.NativeClassPtr, 100664367);
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x0002FB0C File Offset: 0x0002DD0C
	[CallerCount(0)]
	public unsafe static bool AspectWithinRange(ScreenResolution rez, float minAspect, float maxAspect)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rez;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minAspect;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAspect;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_AspectWithinRange_Public_Static_Boolean_ScreenResolution_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x0002FB68 File Offset: 0x0002DD68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860443, XrefRangeEnd = 860445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool MatchAspectWithRoundedPrecision(float width, float height, float aspectRatio)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref width;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aspectRatio;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_MatchAspectWithRoundedPrecision_Private_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x0002FBC4 File Offset: 0x0002DDC4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860449, RefRangeEnd = 860450, XrefRangeStart = 860445, XrefRangeEnd = 860449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsResolution(EnumResolution resolution)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_IsResolution_Public_Static_Boolean_EnumResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x0002FC04 File Offset: 0x0002DE04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860450, XrefRangeEnd = 860454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is4By3()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is4By3_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x0002FC34 File Offset: 0x0002DE34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860454, XrefRangeEnd = 860458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is15Point4By10()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is15Point4By10_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x0002FC64 File Offset: 0x0002DE64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860458, XrefRangeEnd = 860462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is3By2()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is3By2_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x0002FC94 File Offset: 0x0002DE94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860462, XrefRangeEnd = 860466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is16By10()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is16By10_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x0002FCC4 File Offset: 0x0002DEC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860466, XrefRangeEnd = 860470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is5By3()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is5By3_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860470, XrefRangeEnd = 860474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is17By10()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is17By10_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x0002FD24 File Offset: 0x0002DF24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860474, XrefRangeEnd = 860476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is16By9(int width, int height)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref width;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is16By9_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x0002FD70 File Offset: 0x0002DF70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860476, XrefRangeEnd = 860480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is16By9()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is16By9_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x0002FDA0 File Offset: 0x0002DFA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860480, XrefRangeEnd = 860484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is19By10()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is19By10_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x0002FDD0 File Offset: 0x0002DFD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860484, XrefRangeEnd = 860488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is2By1()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is2By1_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x0002FE00 File Offset: 0x0002E000
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860488, XrefRangeEnd = 860492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is2By1OrWider()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Is2By1OrWider_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x060006EE RID: 1774 RVA: 0x0002FE30 File Offset: 0x0002E030
	public unsafe static bool Is4K
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860492, XrefRangeEnd = 860493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_get_Is4K_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x0002FE60 File Offset: 0x0002E060
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860493, XrefRangeEnd = 860498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsNativeAspectRatio(ScreenResolution rez)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rez;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_IsNativeAspectRatio_Public_Static_Boolean_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x0002FEA0 File Offset: 0x0002E0A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860498, XrefRangeEnd = 860503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsNativeAspectRatio(int width, int height)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref width;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_IsNativeAspectRatio_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x0002FEEC File Offset: 0x0002E0EC
	[CallerCount(0)]
	public unsafe static bool DefaultFilter(ScreenResolution rez)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rez;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_DefaultFilter_Public_Static_Boolean_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x0002FF2C File Offset: 0x0002E12C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860503, XrefRangeEnd = 860504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DefaultFilterWithNative(ScreenResolution rez)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rez;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_DefaultFilterWithNative_Public_Static_Boolean_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x0002FF6C File Offset: 0x0002E16C
	[CallerCount(0)]
	public unsafe static bool MaxSixteenByNineFilter(ScreenResolution rez)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rez;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_MaxSixteenByNineFilter_Public_Static_Boolean_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x0002FFAC File Offset: 0x0002E1AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860504, XrefRangeEnd = 860505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Apply(ScreenSettings settings)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref settings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Apply_Public_Static_Boolean_ScreenSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x0002FFEC File Offset: 0x0002E1EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860505, XrefRangeEnd = 860506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Apply(ScreenResolution resolution, bool isWindowed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resolution;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWindowed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Apply_Public_Static_Boolean_ScreenResolution_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00030038 File Offset: 0x0002E238
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 860515, RefRangeEnd = 860517, XrefRangeStart = 860506, XrefRangeEnd = 860515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Apply(int width, int height, bool isWindowed)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref width;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWindowed;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionUtil.NativeMethodInfoPtr_Apply_Public_Static_Boolean_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00004364 File Offset: 0x00002564
	public ScreenResolutionUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00030094 File Offset: 0x0002E294
	// (set) Token: 0x060006F9 RID: 1785 RVA: 0x0000436D File Offset: 0x0000256D
	public unsafe static float ASPECT_FOUR_BY_THREE
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_FOUR_BY_THREE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_FOUR_BY_THREE, (void*)(&value));
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x060006FA RID: 1786 RVA: 0x000300B0 File Offset: 0x0002E2B0
	// (set) Token: 0x060006FB RID: 1787 RVA: 0x0000437B File Offset: 0x0000257B
	public unsafe static float ASPECT_THREE_BY_TWO
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_THREE_BY_TWO, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_THREE_BY_TWO, (void*)(&value));
		}
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x060006FC RID: 1788 RVA: 0x000300CC File Offset: 0x0002E2CC
	// (set) Token: 0x060006FD RID: 1789 RVA: 0x00004389 File Offset: 0x00002589
	public unsafe static float ASPECT_SIXTEEN_BY_TEN
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_SIXTEEN_BY_TEN, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_SIXTEEN_BY_TEN, (void*)(&value));
		}
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x060006FE RID: 1790 RVA: 0x000300E8 File Offset: 0x0002E2E8
	// (set) Token: 0x060006FF RID: 1791 RVA: 0x00004397 File Offset: 0x00002597
	public unsafe static float ASPECT_FIVE_BY_THREE
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_FIVE_BY_THREE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_FIVE_BY_THREE, (void*)(&value));
		}
	}

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x06000700 RID: 1792 RVA: 0x00030104 File Offset: 0x0002E304
	// (set) Token: 0x06000701 RID: 1793 RVA: 0x000043A5 File Offset: 0x000025A5
	public unsafe static float ASPECT_SEVENTEEN_BY_TEN
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_SEVENTEEN_BY_TEN, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_SEVENTEEN_BY_TEN, (void*)(&value));
		}
	}

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x06000702 RID: 1794 RVA: 0x00030120 File Offset: 0x0002E320
	// (set) Token: 0x06000703 RID: 1795 RVA: 0x000043B3 File Offset: 0x000025B3
	public unsafe static float ASPECT_SIXTEEN_BY_NINE
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_SIXTEEN_BY_NINE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_SIXTEEN_BY_NINE, (void*)(&value));
		}
	}

	// Token: 0x170001CF RID: 463
	// (get) Token: 0x06000704 RID: 1796 RVA: 0x0003013C File Offset: 0x0002E33C
	// (set) Token: 0x06000705 RID: 1797 RVA: 0x000043C1 File Offset: 0x000025C1
	public unsafe static float ASPECT_NINETEEN_BY_TEN
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_NINETEEN_BY_TEN, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_NINETEEN_BY_TEN, (void*)(&value));
		}
	}

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06000706 RID: 1798 RVA: 0x00030158 File Offset: 0x0002E358
	// (set) Token: 0x06000707 RID: 1799 RVA: 0x000043CF File Offset: 0x000025CF
	public unsafe static float ASPECT_TWO_BY_ONE
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_TWO_BY_ONE, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_TWO_BY_ONE, (void*)(&value));
		}
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06000708 RID: 1800 RVA: 0x00030174 File Offset: 0x0002E374
	// (set) Token: 0x06000709 RID: 1801 RVA: 0x000043DD File Offset: 0x000025DD
	public unsafe static float ASPECT_FIFTEENPOINTFOUR_BY_TEN
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_FIFTEENPOINTFOUR_BY_TEN, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolutionUtil.NativeFieldInfoPtr_ASPECT_FIFTEENPOINTFOUR_BY_TEN, (void*)(&value));
		}
	}

	// Token: 0x0400053B RID: 1339
	private static readonly IntPtr NativeFieldInfoPtr_ASPECT_FOUR_BY_THREE;

	// Token: 0x0400053C RID: 1340
	private static readonly IntPtr NativeFieldInfoPtr_ASPECT_THREE_BY_TWO;

	// Token: 0x0400053D RID: 1341
	private static readonly IntPtr NativeFieldInfoPtr_ASPECT_SIXTEEN_BY_TEN;

	// Token: 0x0400053E RID: 1342
	private static readonly IntPtr NativeFieldInfoPtr_ASPECT_FIVE_BY_THREE;

	// Token: 0x0400053F RID: 1343
	private static readonly IntPtr NativeFieldInfoPtr_ASPECT_SEVENTEEN_BY_TEN;

	// Token: 0x04000540 RID: 1344
	private static readonly IntPtr NativeFieldInfoPtr_ASPECT_SIXTEEN_BY_NINE;

	// Token: 0x04000541 RID: 1345
	private static readonly IntPtr NativeFieldInfoPtr_ASPECT_NINETEEN_BY_TEN;

	// Token: 0x04000542 RID: 1346
	private static readonly IntPtr NativeFieldInfoPtr_ASPECT_TWO_BY_ONE;

	// Token: 0x04000543 RID: 1347
	private static readonly IntPtr NativeFieldInfoPtr_ASPECT_FIFTEENPOINTFOUR_BY_TEN;

	// Token: 0x04000544 RID: 1348
	private static readonly IntPtr NativeMethodInfoPtr_AspectWithinRange_Public_Static_Boolean_ScreenResolution_Single_Single_0;

	// Token: 0x04000545 RID: 1349
	private static readonly IntPtr NativeMethodInfoPtr_MatchAspectWithRoundedPrecision_Private_Static_Boolean_Single_Single_Single_0;

	// Token: 0x04000546 RID: 1350
	private static readonly IntPtr NativeMethodInfoPtr_IsResolution_Public_Static_Boolean_EnumResolution_0;

	// Token: 0x04000547 RID: 1351
	private static readonly IntPtr NativeMethodInfoPtr_Is4By3_Public_Static_Boolean_0;

	// Token: 0x04000548 RID: 1352
	private static readonly IntPtr NativeMethodInfoPtr_Is15Point4By10_Public_Static_Boolean_0;

	// Token: 0x04000549 RID: 1353
	private static readonly IntPtr NativeMethodInfoPtr_Is3By2_Public_Static_Boolean_0;

	// Token: 0x0400054A RID: 1354
	private static readonly IntPtr NativeMethodInfoPtr_Is16By10_Public_Static_Boolean_0;

	// Token: 0x0400054B RID: 1355
	private static readonly IntPtr NativeMethodInfoPtr_Is5By3_Public_Static_Boolean_0;

	// Token: 0x0400054C RID: 1356
	private static readonly IntPtr NativeMethodInfoPtr_Is17By10_Public_Static_Boolean_0;

	// Token: 0x0400054D RID: 1357
	private static readonly IntPtr NativeMethodInfoPtr_Is16By9_Public_Static_Boolean_Int32_Int32_0;

	// Token: 0x0400054E RID: 1358
	private static readonly IntPtr NativeMethodInfoPtr_Is16By9_Public_Static_Boolean_0;

	// Token: 0x0400054F RID: 1359
	private static readonly IntPtr NativeMethodInfoPtr_Is19By10_Public_Static_Boolean_0;

	// Token: 0x04000550 RID: 1360
	private static readonly IntPtr NativeMethodInfoPtr_Is2By1_Public_Static_Boolean_0;

	// Token: 0x04000551 RID: 1361
	private static readonly IntPtr NativeMethodInfoPtr_Is2By1OrWider_Public_Static_Boolean_0;

	// Token: 0x04000552 RID: 1362
	private static readonly IntPtr NativeMethodInfoPtr_get_Is4K_Public_Static_get_Boolean_0;

	// Token: 0x04000553 RID: 1363
	private static readonly IntPtr NativeMethodInfoPtr_IsNativeAspectRatio_Public_Static_Boolean_ScreenResolution_0;

	// Token: 0x04000554 RID: 1364
	private static readonly IntPtr NativeMethodInfoPtr_IsNativeAspectRatio_Public_Static_Boolean_Int32_Int32_0;

	// Token: 0x04000555 RID: 1365
	private static readonly IntPtr NativeMethodInfoPtr_DefaultFilter_Public_Static_Boolean_ScreenResolution_0;

	// Token: 0x04000556 RID: 1366
	private static readonly IntPtr NativeMethodInfoPtr_DefaultFilterWithNative_Public_Static_Boolean_ScreenResolution_0;

	// Token: 0x04000557 RID: 1367
	private static readonly IntPtr NativeMethodInfoPtr_MaxSixteenByNineFilter_Public_Static_Boolean_ScreenResolution_0;

	// Token: 0x04000558 RID: 1368
	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Static_Boolean_ScreenSettings_0;

	// Token: 0x04000559 RID: 1369
	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Static_Boolean_ScreenResolution_Boolean_0;

	// Token: 0x0400055A RID: 1370
	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Static_Boolean_Int32_Int32_Boolean_0;
}
