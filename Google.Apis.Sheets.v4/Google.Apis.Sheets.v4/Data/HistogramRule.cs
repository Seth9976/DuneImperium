using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200007A RID: 122
	public class HistogramRule : Object
	{
		// Token: 0x06000939 RID: 2361 RVA: 0x0002E184 File Offset: 0x0002C384
		// Note: this type is marked as 'beforefieldinit'.
		static HistogramRule()
		{
			Il2CppClassPointerStore<HistogramRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "HistogramRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr);
			HistogramRule.NativeFieldInfoPtr__End_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, "<End>k__BackingField");
			HistogramRule.NativeFieldInfoPtr__Interval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, "<Interval>k__BackingField");
			HistogramRule.NativeFieldInfoPtr__Start_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, "<Start>k__BackingField");
			HistogramRule.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, "<ETag>k__BackingField");
			HistogramRule.NativeMethodInfoPtr_get_End_Public_Virtual_New_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, 100664640);
			HistogramRule.NativeMethodInfoPtr_set_End_Public_Virtual_New_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, 100664641);
			HistogramRule.NativeMethodInfoPtr_get_Interval_Public_Virtual_New_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, 100664642);
			HistogramRule.NativeMethodInfoPtr_set_Interval_Public_Virtual_New_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, 100664643);
			HistogramRule.NativeMethodInfoPtr_get_Start_Public_Virtual_New_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, 100664644);
			HistogramRule.NativeMethodInfoPtr_set_Start_Public_Virtual_New_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, 100664645);
			HistogramRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, 100664646);
			HistogramRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, 100664647);
			HistogramRule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr, 100664648);
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0002E2B8 File Offset: 0x0002C4B8
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x0002E2FC File Offset: 0x0002C4FC
		public unsafe virtual Nullable<double> End
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramRule.NativeMethodInfoPtr_get_End_Public_Virtual_New_get_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramRule.NativeMethodInfoPtr_set_End_Public_Virtual_New_set_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0002E350 File Offset: 0x0002C550
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x0002E394 File Offset: 0x0002C594
		public unsafe virtual Nullable<double> Interval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramRule.NativeMethodInfoPtr_get_Interval_Public_Virtual_New_get_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramRule.NativeMethodInfoPtr_set_Interval_Public_Virtual_New_set_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0002E3E8 File Offset: 0x0002C5E8
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x0002E42C File Offset: 0x0002C62C
		public unsafe virtual Nullable<double> Start
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramRule.NativeMethodInfoPtr_get_Start_Public_Virtual_New_get_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramRule.NativeMethodInfoPtr_set_Start_Public_Virtual_New_set_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x0002E480 File Offset: 0x0002C680
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x0002E4C4 File Offset: 0x0002C6C4
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramRule.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramRule.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0002E514 File Offset: 0x0002C714
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HistogramRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HistogramRule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HistogramRule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00006701 File Offset: 0x00004901
		public HistogramRule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0002E550 File Offset: 0x0002C750
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x0000670A File Offset: 0x0000490A
		public Nullable<double> _End_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramRule.NativeFieldInfoPtr__End_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramRule.NativeFieldInfoPtr__End_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0002E580 File Offset: 0x0002C780
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00006738 File Offset: 0x00004938
		public Nullable<double> _Interval_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramRule.NativeFieldInfoPtr__Interval_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramRule.NativeFieldInfoPtr__Interval_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0002E5B0 File Offset: 0x0002C7B0
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00006766 File Offset: 0x00004966
		public Nullable<double> _Start_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramRule.NativeFieldInfoPtr__Start_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramRule.NativeFieldInfoPtr__Start_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0002E5E0 File Offset: 0x0002C7E0
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00006794 File Offset: 0x00004994
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramRule.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramRule.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeFieldInfoPtr__End_k__BackingField;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeFieldInfoPtr__Interval_k__BackingField;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr__Start_k__BackingField;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_get_End_Public_Virtual_New_get_Nullable_1_Double_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_set_End_Public_Virtual_New_set_Void_Nullable_1_Double_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_get_Interval_Public_Virtual_New_get_Nullable_1_Double_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_set_Interval_Public_Virtual_New_set_Void_Nullable_1_Double_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_get_Start_Public_Virtual_New_get_Nullable_1_Double_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_set_Start_Public_Virtual_New_set_Void_Nullable_1_Double_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
