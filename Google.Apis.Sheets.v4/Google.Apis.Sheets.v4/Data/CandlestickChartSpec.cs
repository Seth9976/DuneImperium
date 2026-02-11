using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000035 RID: 53
	public class CandlestickChartSpec : Object
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00019EAC File Offset: 0x000180AC
		// Note: this type is marked as 'beforefieldinit'.
		static CandlestickChartSpec()
		{
			Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "CandlestickChartSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr);
			CandlestickChartSpec.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr, "<Data>k__BackingField");
			CandlestickChartSpec.NativeFieldInfoPtr__Domain_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr, "<Domain>k__BackingField");
			CandlestickChartSpec.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr, "<ETag>k__BackingField");
			CandlestickChartSpec.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_CandlestickData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr, 100663995);
			CandlestickChartSpec.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_CandlestickData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr, 100663996);
			CandlestickChartSpec.NativeMethodInfoPtr_get_Domain_Public_Virtual_New_get_CandlestickDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr, 100663997);
			CandlestickChartSpec.NativeMethodInfoPtr_set_Domain_Public_Virtual_New_set_Void_CandlestickDomain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr, 100663998);
			CandlestickChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr, 100663999);
			CandlestickChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr, 100664000);
			CandlestickChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr, 100664001);
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00019FA4 File Offset: 0x000181A4
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00019FF0 File Offset: 0x000181F0
		public unsafe virtual IList<CandlestickData> Data
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickChartSpec.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_CandlestickData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CandlestickData>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickChartSpec.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_CandlestickData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0001A040 File Offset: 0x00018240
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x0001A08C File Offset: 0x0001828C
		public unsafe virtual CandlestickDomain Domain
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickChartSpec.NativeMethodInfoPtr_get_Domain_Public_Virtual_New_get_CandlestickDomain_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CandlestickDomain>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickChartSpec.NativeMethodInfoPtr_set_Domain_Public_Virtual_New_set_Void_CandlestickDomain_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0001A0DC File Offset: 0x000182DC
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0001A120 File Offset: 0x00018320
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CandlestickChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001A170 File Offset: 0x00018370
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CandlestickChartSpec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CandlestickChartSpec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CandlestickChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00003D5E File Offset: 0x00001F5E
		public CandlestickChartSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0001A1AC File Offset: 0x000183AC
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00003D67 File Offset: 0x00001F67
		public unsafe IList<CandlestickData> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickChartSpec.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<CandlestickData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickChartSpec.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0001A1DC File Offset: 0x000183DC
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00003D86 File Offset: 0x00001F86
		public unsafe CandlestickDomain _Domain_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickChartSpec.NativeFieldInfoPtr__Domain_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CandlestickDomain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickChartSpec.NativeFieldInfoPtr__Domain_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0001A20C File Offset: 0x0001840C
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00003DA5 File Offset: 0x00001FA5
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickChartSpec.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CandlestickChartSpec.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr__Domain_k__BackingField;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IList_1_CandlestickData_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_IList_1_CandlestickData_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_get_Domain_Public_Virtual_New_get_CandlestickDomain_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_Virtual_New_set_Void_CandlestickDomain_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
