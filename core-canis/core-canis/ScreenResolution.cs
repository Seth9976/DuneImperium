using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200005E RID: 94
[StructLayout(2)]
public struct ScreenResolution
{
	// Token: 0x060006C6 RID: 1734 RVA: 0x0002F158 File Offset: 0x0002D358
	// Note: this type is marked as 'beforefieldinit'.
	static ScreenResolution()
	{
		Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "ScreenResolution");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr);
		ScreenResolution.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, "Width");
		ScreenResolution.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, "Height");
		ScreenResolution.NativeFieldInfoPtr_Aspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, "Aspect");
		ScreenResolution.NativeFieldInfoPtr_WindowedScreens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, "WindowedScreens");
		ScreenResolution.NativeFieldInfoPtr_reportedBadDPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, "reportedBadDPI");
		ScreenResolution.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664325);
		ScreenResolution.NativeMethodInfoPtr_get_FullScreens_Public_Static_get_IEnumerable_1_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664326);
		ScreenResolution.NativeMethodInfoPtr_resToSRes_Private_Static_ScreenResolution_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664327);
		ScreenResolution.NativeMethodInfoPtr_get_Current_Public_Static_get_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664328);
		ScreenResolution.NativeMethodInfoPtr_get_Native_Public_Static_get_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664329);
		ScreenResolution.NativeMethodInfoPtr_get_DPI_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664330);
		ScreenResolution.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664331);
		ScreenResolution.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664332);
		ScreenResolution.NativeMethodInfoPtr_Equals_Public_Boolean_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664333);
		ScreenResolution.NativeMethodInfoPtr_Equals_Public_Boolean_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664334);
		ScreenResolution.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenResolution_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664335);
		ScreenResolution.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenResolution_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664336);
		ScreenResolution.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Resolution_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664337);
		ScreenResolution.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenResolution_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664338);
		ScreenResolution.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenResolution_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664339);
		ScreenResolution.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Resolution_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664340);
		ScreenResolution.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664341);
		ScreenResolution.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664342);
		ScreenResolution.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, 100664343);
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x0002F368 File Offset: 0x0002D568
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 860339, RefRangeEnd = 860341, XrefRangeStart = 860339, XrefRangeEnd = 860339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenResolution(int width, int height)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref width;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0002F3A8 File Offset: 0x0002D5A8
	public unsafe static IEnumerable<ScreenResolution> FullScreens
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 860359, RefRangeEnd = 860361, XrefRangeStart = 860341, XrefRangeEnd = 860359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_get_FullScreens_Public_Static_get_IEnumerable_1_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ScreenResolution>>(intPtr3) : null;
		}
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x0002F3DC File Offset: 0x0002D5DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860361, XrefRangeEnd = 860363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenResolution resToSRes(Resolution resolution)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_resToSRes_Private_Static_ScreenResolution_Resolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x060006CA RID: 1738 RVA: 0x0002F41C File Offset: 0x0002D61C
	public unsafe static ScreenResolution Current
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 860365, RefRangeEnd = 860369, XrefRangeStart = 860363, XrefRangeEnd = 860365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_get_Current_Public_Static_get_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x060006CB RID: 1739 RVA: 0x0002F44C File Offset: 0x0002D64C
	public unsafe static ScreenResolution Native
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 860371, RefRangeEnd = 860376, XrefRangeStart = 860369, XrefRangeEnd = 860371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_get_Native_Public_Static_get_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x060006CC RID: 1740 RVA: 0x0002F47C File Offset: 0x0002D67C
	public unsafe static float DPI
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 860384, RefRangeEnd = 860389, XrefRangeStart = 860376, XrefRangeEnd = 860384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_get_DPI_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x0002F4AC File Offset: 0x0002D6AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860389, XrefRangeEnd = 860391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x0002F4DC File Offset: 0x0002D6DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860391, XrefRangeEnd = 860400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(global::Il2CppSystem.Object obj)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x0002F520 File Offset: 0x0002D720
	[CallerCount(0)]
	public unsafe bool Equals(ScreenResolution other)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_Equals_Public_Boolean_ScreenResolution_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x0002F560 File Offset: 0x0002D760
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860400, XrefRangeEnd = 860401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Resolution other)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_Equals_Public_Boolean_Resolution_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x0002F5A0 File Offset: 0x0002D7A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860404, RefRangeEnd = 860405, XrefRangeStart = 860401, XrefRangeEnd = 860404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(ScreenResolution a, ScreenResolution b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenResolution_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x0002F5EC File Offset: 0x0002D7EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860405, XrefRangeEnd = 860409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(ScreenResolution a, Resolution b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenResolution_Resolution_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x0002F638 File Offset: 0x0002D838
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860409, XrefRangeEnd = 860413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(Resolution a, ScreenResolution b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Resolution_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x0002F684 File Offset: 0x0002D884
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860416, RefRangeEnd = 860417, XrefRangeStart = 860413, XrefRangeEnd = 860416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(ScreenResolution a, ScreenResolution b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenResolution_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x0002F6D0 File Offset: 0x0002D8D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860417, XrefRangeEnd = 860421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(ScreenResolution a, Resolution b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenResolution_Resolution_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x0002F71C File Offset: 0x0002D91C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860421, XrefRangeEnd = 860425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(Resolution a, ScreenResolution b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Resolution_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x0002F768 File Offset: 0x0002D968
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860433, RefRangeEnd = 860434, XrefRangeStart = 860425, XrefRangeEnd = 860433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x0002F794 File Offset: 0x0002D994
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860434, XrefRangeEnd = 860441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CompareTo(global::Il2CppSystem.Object obj)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x0002F7D8 File Offset: 0x0002D9D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860441, XrefRangeEnd = 860443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CompareTo(ScreenResolution other)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolution.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenResolution_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00004332 File Offset: 0x00002532
	public global::Il2CppSystem.Object BoxIl2CppObject()
	{
		return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, ref this));
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x060006DB RID: 1755 RVA: 0x0002F818 File Offset: 0x0002DA18
	// (set) Token: 0x060006DC RID: 1756 RVA: 0x00004344 File Offset: 0x00002544
	public unsafe static List<ScreenResolution> WindowedScreens
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolution.NativeFieldInfoPtr_WindowedScreens, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScreenResolution>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolution.NativeFieldInfoPtr_WindowedScreens, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x060006DD RID: 1757 RVA: 0x0002F840 File Offset: 0x0002DA40
	// (set) Token: 0x060006DE RID: 1758 RVA: 0x00004356 File Offset: 0x00002556
	public unsafe static bool reportedBadDPI
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(ScreenResolution.NativeFieldInfoPtr_reportedBadDPI, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenResolution.NativeFieldInfoPtr_reportedBadDPI, (void*)(&value));
		}
	}

	// Token: 0x04000514 RID: 1300
	private static readonly IntPtr NativeFieldInfoPtr_Width;

	// Token: 0x04000515 RID: 1301
	private static readonly IntPtr NativeFieldInfoPtr_Height;

	// Token: 0x04000516 RID: 1302
	private static readonly IntPtr NativeFieldInfoPtr_Aspect;

	// Token: 0x04000517 RID: 1303
	private static readonly IntPtr NativeFieldInfoPtr_WindowedScreens;

	// Token: 0x04000518 RID: 1304
	private static readonly IntPtr NativeFieldInfoPtr_reportedBadDPI;

	// Token: 0x04000519 RID: 1305
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	// Token: 0x0400051A RID: 1306
	private static readonly IntPtr NativeMethodInfoPtr_get_FullScreens_Public_Static_get_IEnumerable_1_ScreenResolution_0;

	// Token: 0x0400051B RID: 1307
	private static readonly IntPtr NativeMethodInfoPtr_resToSRes_Private_Static_ScreenResolution_Resolution_0;

	// Token: 0x0400051C RID: 1308
	private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_ScreenResolution_0;

	// Token: 0x0400051D RID: 1309
	private static readonly IntPtr NativeMethodInfoPtr_get_Native_Public_Static_get_ScreenResolution_0;

	// Token: 0x0400051E RID: 1310
	private static readonly IntPtr NativeMethodInfoPtr_get_DPI_Public_Static_get_Single_0;

	// Token: 0x0400051F RID: 1311
	private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	// Token: 0x04000520 RID: 1312
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	// Token: 0x04000521 RID: 1313
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ScreenResolution_0;

	// Token: 0x04000522 RID: 1314
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Resolution_0;

	// Token: 0x04000523 RID: 1315
	private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenResolution_ScreenResolution_0;

	// Token: 0x04000524 RID: 1316
	private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenResolution_Resolution_0;

	// Token: 0x04000525 RID: 1317
	private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Resolution_ScreenResolution_0;

	// Token: 0x04000526 RID: 1318
	private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenResolution_ScreenResolution_0;

	// Token: 0x04000527 RID: 1319
	private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenResolution_Resolution_0;

	// Token: 0x04000528 RID: 1320
	private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Resolution_ScreenResolution_0;

	// Token: 0x04000529 RID: 1321
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	// Token: 0x0400052A RID: 1322
	private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

	// Token: 0x0400052B RID: 1323
	private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenResolution_0;

	// Token: 0x0400052C RID: 1324
	[FieldOffset(0)]
	public readonly int Width;

	// Token: 0x0400052D RID: 1325
	[FieldOffset(4)]
	public readonly int Height;

	// Token: 0x0400052E RID: 1326
	[FieldOffset(8)]
	public readonly float Aspect;

	// Token: 0x0200027A RID: 634
	[ObfuscatedName("ScreenResolution+<>O")]
	public static class __O : global::Il2CppSystem.Object
	{
		// Token: 0x06001EDC RID: 7900 RVA: 0x0000D1BC File Offset: 0x0000B3BC
		// Note: this type is marked as 'beforefieldinit'.
		static __O()
		{
			Il2CppClassPointerStore<ScreenResolution.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenResolution>.NativeClassPtr, "<>O");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenResolution.__O>.NativeClassPtr);
			ScreenResolution.__O.NativeFieldInfoPtr__0___resToSRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolution.__O>.NativeClassPtr, "<0>__resToSRes");
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		public __O(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x0008D128 File Offset: 0x0008B328
		// (set) Token: 0x06001EDF RID: 7903 RVA: 0x0000D1F9 File Offset: 0x0000B3F9
		public unsafe static Func<Resolution, ScreenResolution> _0___resToSRes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenResolution.__O.NativeFieldInfoPtr__0___resToSRes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Resolution, ScreenResolution>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenResolution.__O.NativeFieldInfoPtr__0___resToSRes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeFieldInfoPtr__0___resToSRes;
	}
}
