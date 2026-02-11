using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000005 RID: 5
public static class UnixTimeUtil : Object
{
	// Token: 0x0600000F RID: 15 RVA: 0x000047E8 File Offset: 0x000029E8
	// Note: this type is marked as 'beforefieldinit'.
	static UnixTimeUtil()
	{
		Il2CppClassPointerStore<UnixTimeUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "", "UnixTimeUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnixTimeUtil>.NativeClassPtr);
		UnixTimeUtil.NativeFieldInfoPtr_EPOCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnixTimeUtil>.NativeClassPtr, "EPOCH");
		UnixTimeUtil.NativeMethodInfoPtr_Epoch_Public_Static_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixTimeUtil>.NativeClassPtr, 100663301);
		UnixTimeUtil.NativeMethodInfoPtr_ToUnixTimeSeconds_Public_Static_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixTimeUtil>.NativeClassPtr, 100663302);
		UnixTimeUtil.NativeMethodInfoPtr_ToUnixTimeMilliseconds_Public_Static_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixTimeUtil>.NativeClassPtr, 100663303);
		UnixTimeUtil.NativeMethodInfoPtr_DateTimeFromMilliseconds_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixTimeUtil>.NativeClassPtr, 100663304);
		UnixTimeUtil.NativeMethodInfoPtr_ConvertMonthsToUnix_Public_Static_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnixTimeUtil>.NativeClassPtr, 100663305);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00004890 File Offset: 0x00002A90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176254, XrefRangeEnd = 1176258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime Epoch()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixTimeUtil.NativeMethodInfoPtr_Epoch_Public_Static_DateTime_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000048C0 File Offset: 0x00002AC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176258, XrefRangeEnd = 1176270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToUnixTimeSeconds(this DateTime dateTime)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref dateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixTimeUtil.NativeMethodInfoPtr_ToUnixTimeSeconds_Public_Static_Int64_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00004900 File Offset: 0x00002B00
	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 1176282, RefRangeEnd = 1176316, XrefRangeStart = 1176270, XrefRangeEnd = 1176282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToUnixTimeMilliseconds(this DateTime dateTime)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref dateTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixTimeUtil.NativeMethodInfoPtr_ToUnixTimeMilliseconds_Public_Static_Int64_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00004940 File Offset: 0x00002B40
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1176324, RefRangeEnd = 1176332, XrefRangeStart = 1176316, XrefRangeEnd = 1176324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DateTime DateTimeFromMilliseconds(long unixTime)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref unixTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixTimeUtil.NativeMethodInfoPtr_DateTimeFromMilliseconds_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00004980 File Offset: 0x00002B80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176332, XrefRangeEnd = 1176342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ConvertMonthsToUnix(DateTime t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnixTimeUtil.NativeMethodInfoPtr_ConvertMonthsToUnix_Public_Static_Int32_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000020DE File Offset: 0x000002DE
	public UnixTimeUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000016 RID: 22 RVA: 0x000049C0 File Offset: 0x00002BC0
	// (set) Token: 0x06000017 RID: 23 RVA: 0x000020E7 File Offset: 0x000002E7
	public unsafe static DateTime EPOCH
	{
		get
		{
			DateTime dateTime;
			IL2CPP.il2cpp_field_static_get_value(UnixTimeUtil.NativeFieldInfoPtr_EPOCH, (void*)(&dateTime));
			return dateTime;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UnixTimeUtil.NativeFieldInfoPtr_EPOCH, (void*)(&value));
		}
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeFieldInfoPtr_EPOCH;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_Epoch_Public_Static_DateTime_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr_ToUnixTimeSeconds_Public_Static_Int64_DateTime_0;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_ToUnixTimeMilliseconds_Public_Static_Int64_DateTime_0;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr_DateTimeFromMilliseconds_Public_Static_DateTime_Int64_0;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr_ConvertMonthsToUnix_Public_Static_Int32_DateTime_0;
}
