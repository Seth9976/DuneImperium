using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000037 RID: 55
	public class CandlestickDomain : Object
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x0001A7CC File Offset: 0x000189CC
		// Note: this type is marked as 'beforefieldinit'.
		static CandlestickDomain()
		{
			Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "CandlestickDomain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr);
			CandlestickDomain.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr, "<Data>k__BackingField");
			CandlestickDomain.NativeFieldInfoPtr__Reversed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr, "<Reversed>k__BackingField");
			CandlestickDomain.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr, "<ETag>k__BackingField");
			CandlestickDomain.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr, 100664013);
			CandlestickDomain.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr, 100664014);
			CandlestickDomain.NativeMethodInfoPtr_get_Reversed_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr, 100664015);
			CandlestickDomain.NativeMethodInfoPtr_set_Reversed_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr, 100664016);
			CandlestickDomain.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr, 100664017);
			CandlestickDomain.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr, 100664018);
			CandlestickDomain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr, 100664019);
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0001A8C4 File Offset: 0x00018AC4
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0001A910 File Offset: 0x00018B10
		public unsafe virtual ChartData Data
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickDomain.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickDomain.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0001A960 File Offset: 0x00018B60
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0001A9A4 File Offset: 0x00018BA4
		public unsafe virtual Nullable<bool> Reversed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickDomain.NativeMethodInfoPtr_get_Reversed_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickDomain.NativeMethodInfoPtr_set_Reversed_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0001A9F8 File Offset: 0x00018BF8
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0001AA3C File Offset: 0x00018C3C
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickDomain.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickDomain.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0001AA8C File Offset: 0x00018C8C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CandlestickDomain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CandlestickDomain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CandlestickDomain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00003E68 File Offset: 0x00002068
		public CandlestickDomain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00003E71 File Offset: 0x00002071
		public unsafe ChartData _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickDomain.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickDomain.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0001AAF8 File Offset: 0x00018CF8
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00003E90 File Offset: 0x00002090
		public Nullable<bool> _Reversed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickDomain.NativeFieldInfoPtr__Reversed_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickDomain.NativeFieldInfoPtr__Reversed_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0001AB28 File Offset: 0x00018D28
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00003EBE File Offset: 0x000020BE
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickDomain.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickDomain.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr__Reversed_k__BackingField;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_get_Reversed_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_set_Reversed_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
