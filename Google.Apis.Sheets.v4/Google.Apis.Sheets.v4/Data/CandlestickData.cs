using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000036 RID: 54
	public class CandlestickData : Object
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x0001A234 File Offset: 0x00018434
		// Note: this type is marked as 'beforefieldinit'.
		static CandlestickData()
		{
			Il2CppClassPointerStore<CandlestickData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "CandlestickData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr);
			CandlestickData.NativeFieldInfoPtr__CloseSeries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, "<CloseSeries>k__BackingField");
			CandlestickData.NativeFieldInfoPtr__HighSeries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, "<HighSeries>k__BackingField");
			CandlestickData.NativeFieldInfoPtr__LowSeries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, "<LowSeries>k__BackingField");
			CandlestickData.NativeFieldInfoPtr__OpenSeries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, "<OpenSeries>k__BackingField");
			CandlestickData.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, "<ETag>k__BackingField");
			CandlestickData.NativeMethodInfoPtr_get_CloseSeries_Public_Virtual_New_get_CandlestickSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664002);
			CandlestickData.NativeMethodInfoPtr_set_CloseSeries_Public_Virtual_New_set_Void_CandlestickSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664003);
			CandlestickData.NativeMethodInfoPtr_get_HighSeries_Public_Virtual_New_get_CandlestickSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664004);
			CandlestickData.NativeMethodInfoPtr_set_HighSeries_Public_Virtual_New_set_Void_CandlestickSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664005);
			CandlestickData.NativeMethodInfoPtr_get_LowSeries_Public_Virtual_New_get_CandlestickSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664006);
			CandlestickData.NativeMethodInfoPtr_set_LowSeries_Public_Virtual_New_set_Void_CandlestickSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664007);
			CandlestickData.NativeMethodInfoPtr_get_OpenSeries_Public_Virtual_New_get_CandlestickSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664008);
			CandlestickData.NativeMethodInfoPtr_set_OpenSeries_Public_Virtual_New_set_Void_CandlestickSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664009);
			CandlestickData.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664010);
			CandlestickData.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664011);
			CandlestickData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr, 100664012);
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0001A3A4 File Offset: 0x000185A4
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0001A3F0 File Offset: 0x000185F0
		public unsafe virtual CandlestickSeries CloseSeries
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickData.NativeMethodInfoPtr_get_CloseSeries_Public_Virtual_New_get_CandlestickSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CandlestickSeries>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickData.NativeMethodInfoPtr_set_CloseSeries_Public_Virtual_New_set_Void_CandlestickSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0001A440 File Offset: 0x00018640
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x0001A48C File Offset: 0x0001868C
		public unsafe virtual CandlestickSeries HighSeries
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickData.NativeMethodInfoPtr_get_HighSeries_Public_Virtual_New_get_CandlestickSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CandlestickSeries>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickData.NativeMethodInfoPtr_set_HighSeries_Public_Virtual_New_set_Void_CandlestickSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0001A4DC File Offset: 0x000186DC
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x0001A528 File Offset: 0x00018728
		public unsafe virtual CandlestickSeries LowSeries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickData.NativeMethodInfoPtr_get_LowSeries_Public_Virtual_New_get_CandlestickSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CandlestickSeries>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickData.NativeMethodInfoPtr_set_LowSeries_Public_Virtual_New_set_Void_CandlestickSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0001A578 File Offset: 0x00018778
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x0001A5C4 File Offset: 0x000187C4
		public unsafe virtual CandlestickSeries OpenSeries
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickData.NativeMethodInfoPtr_get_OpenSeries_Public_Virtual_New_get_CandlestickSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CandlestickSeries>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickData.NativeMethodInfoPtr_set_OpenSeries_Public_Virtual_New_set_Void_CandlestickSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0001A614 File Offset: 0x00018814
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x0001A658 File Offset: 0x00018858
		public unsafe virtual string ETag
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickData.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickData.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001A6A8 File Offset: 0x000188A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CandlestickData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CandlestickData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CandlestickData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00003DC4 File Offset: 0x00001FC4
		public CandlestickData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0001A6E4 File Offset: 0x000188E4
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00003DCD File Offset: 0x00001FCD
		public unsafe CandlestickSeries _CloseSeries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickData.NativeFieldInfoPtr__CloseSeries_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CandlestickSeries>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickData.NativeFieldInfoPtr__CloseSeries_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0001A714 File Offset: 0x00018914
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00003DEC File Offset: 0x00001FEC
		public unsafe CandlestickSeries _HighSeries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickData.NativeFieldInfoPtr__HighSeries_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CandlestickSeries>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickData.NativeFieldInfoPtr__HighSeries_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0001A744 File Offset: 0x00018944
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00003E0B File Offset: 0x0000200B
		public unsafe CandlestickSeries _LowSeries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickData.NativeFieldInfoPtr__LowSeries_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CandlestickSeries>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickData.NativeFieldInfoPtr__LowSeries_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001A774 File Offset: 0x00018974
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00003E2A File Offset: 0x0000202A
		public unsafe CandlestickSeries _OpenSeries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickData.NativeFieldInfoPtr__OpenSeries_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CandlestickSeries>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickData.NativeFieldInfoPtr__OpenSeries_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001A7A4 File Offset: 0x000189A4
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00003E49 File Offset: 0x00002049
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickData.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickData.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr__CloseSeries_k__BackingField;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr__HighSeries_k__BackingField;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr__LowSeries_k__BackingField;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr__OpenSeries_k__BackingField;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseSeries_Public_Virtual_New_get_CandlestickSeries_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseSeries_Public_Virtual_New_set_Void_CandlestickSeries_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_get_HighSeries_Public_Virtual_New_get_CandlestickSeries_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_set_HighSeries_Public_Virtual_New_set_Void_CandlestickSeries_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_get_LowSeries_Public_Virtual_New_get_CandlestickSeries_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_set_LowSeries_Public_Virtual_New_set_Void_CandlestickSeries_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenSeries_Public_Virtual_New_get_CandlestickSeries_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenSeries_Public_Virtual_New_set_Void_CandlestickSeries_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
