using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200005D RID: 93
public static class QualityUtil : Object
{
	// Token: 0x060006BF RID: 1727 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
	// Note: this type is marked as 'beforefieldinit'.
	static QualityUtil()
	{
		Il2CppClassPointerStore<QualityUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "QualityUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityUtil>.NativeClassPtr);
		QualityUtil.NativeFieldInfoPtr_availableQualities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityUtil>.NativeClassPtr, "availableQualities");
		QualityUtil.NativeMethodInfoPtr_get_AvailableQualities_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityUtil>.NativeClassPtr, 100664322);
		QualityUtil.NativeMethodInfoPtr_set_AvailableQualities_Public_Static_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityUtil>.NativeClassPtr, 100664323);
		QualityUtil.NativeMethodInfoPtr_Apply_Public_Static_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityUtil>.NativeClassPtr, 100664324);
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0002F078 File Offset: 0x0002D278
	// (set) Token: 0x060006C1 RID: 1729 RVA: 0x0002F0AC File Offset: 0x0002D2AC
	public unsafe static Il2CppStringArray AvailableQualities
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860324, XrefRangeEnd = 860326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityUtil.NativeMethodInfoPtr_get_AvailableQualities_Public_Static_get_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860326, XrefRangeEnd = 860336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityUtil.NativeMethodInfoPtr_set_AvailableQualities_Public_Static_set_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x0002F0E4 File Offset: 0x0002D2E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860338, RefRangeEnd = 860339, XrefRangeStart = 860336, XrefRangeEnd = 860338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Apply(int quality, bool applyExpensiveChanges = true)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref quality;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyExpensiveChanges;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityUtil.NativeMethodInfoPtr_Apply_Public_Static_Boolean_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00004317 File Offset: 0x00002517
	public QualityUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0002F130 File Offset: 0x0002D330
	// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00004320 File Offset: 0x00002520
	public unsafe static Il2CppStringArray availableQualities
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(QualityUtil.NativeFieldInfoPtr_availableQualities, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(QualityUtil.NativeFieldInfoPtr_availableQualities, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000510 RID: 1296
	private static readonly IntPtr NativeFieldInfoPtr_availableQualities;

	// Token: 0x04000511 RID: 1297
	private static readonly IntPtr NativeMethodInfoPtr_get_AvailableQualities_Public_Static_get_Il2CppStringArray_0;

	// Token: 0x04000512 RID: 1298
	private static readonly IntPtr NativeMethodInfoPtr_set_AvailableQualities_Public_Static_set_Void_Il2CppStringArray_0;

	// Token: 0x04000513 RID: 1299
	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Static_Boolean_Int32_Boolean_0;
}
