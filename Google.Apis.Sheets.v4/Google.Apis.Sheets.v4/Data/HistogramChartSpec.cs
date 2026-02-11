using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000079 RID: 121
	public class HistogramChartSpec : Object
	{
		// Token: 0x0600091E RID: 2334 RVA: 0x0002DB00 File Offset: 0x0002BD00
		// Note: this type is marked as 'beforefieldinit'.
		static HistogramChartSpec()
		{
			Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "HistogramChartSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr);
			HistogramChartSpec.NativeFieldInfoPtr__BucketSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, "<BucketSize>k__BackingField");
			HistogramChartSpec.NativeFieldInfoPtr__LegendPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, "<LegendPosition>k__BackingField");
			HistogramChartSpec.NativeFieldInfoPtr__OutlierPercentile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, "<OutlierPercentile>k__BackingField");
			HistogramChartSpec.NativeFieldInfoPtr__Series_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, "<Series>k__BackingField");
			HistogramChartSpec.NativeFieldInfoPtr__ShowItemDividers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, "<ShowItemDividers>k__BackingField");
			HistogramChartSpec.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, "<ETag>k__BackingField");
			HistogramChartSpec.NativeMethodInfoPtr_get_BucketSize_Public_Virtual_New_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664627);
			HistogramChartSpec.NativeMethodInfoPtr_set_BucketSize_Public_Virtual_New_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664628);
			HistogramChartSpec.NativeMethodInfoPtr_get_LegendPosition_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664629);
			HistogramChartSpec.NativeMethodInfoPtr_set_LegendPosition_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664630);
			HistogramChartSpec.NativeMethodInfoPtr_get_OutlierPercentile_Public_Virtual_New_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664631);
			HistogramChartSpec.NativeMethodInfoPtr_set_OutlierPercentile_Public_Virtual_New_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664632);
			HistogramChartSpec.NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_IList_1_HistogramSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664633);
			HistogramChartSpec.NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_IList_1_HistogramSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664634);
			HistogramChartSpec.NativeMethodInfoPtr_get_ShowItemDividers_Public_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664635);
			HistogramChartSpec.NativeMethodInfoPtr_set_ShowItemDividers_Public_Virtual_New_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664636);
			HistogramChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664637);
			HistogramChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664638);
			HistogramChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr, 100664639);
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0002DCAC File Offset: 0x0002BEAC
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
		public unsafe virtual Nullable<double> BucketSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_get_BucketSize_Public_Virtual_New_get_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_set_BucketSize_Public_Virtual_New_set_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0002DD44 File Offset: 0x0002BF44
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x0002DD88 File Offset: 0x0002BF88
		public unsafe virtual string LegendPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_get_LegendPosition_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_set_LegendPosition_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0002DDD8 File Offset: 0x0002BFD8
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x0002DE1C File Offset: 0x0002C01C
		public unsafe virtual Nullable<double> OutlierPercentile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_get_OutlierPercentile_Public_Virtual_New_get_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 755145, RefRangeEnd = 755149, XrefRangeStart = 755145, XrefRangeEnd = 755149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_set_OutlierPercentile_Public_Virtual_New_set_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0002DE70 File Offset: 0x0002C070
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x0002DEBC File Offset: 0x0002C0BC
		public unsafe virtual IList<HistogramSeries> Series
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_IList_1_HistogramSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<HistogramSeries>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_IList_1_HistogramSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0002DF0C File Offset: 0x0002C10C
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x0002DF50 File Offset: 0x0002C150
		public unsafe virtual Nullable<bool> ShowItemDividers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_get_ShowItemDividers_Public_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_set_ShowItemDividers_Public_Virtual_New_set_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0002DFA4 File Offset: 0x0002C1A4
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0002DFE8 File Offset: 0x0002C1E8
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramChartSpec.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0002E038 File Offset: 0x0002C238
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HistogramChartSpec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HistogramChartSpec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HistogramChartSpec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00006611 File Offset: 0x00004811
		public HistogramChartSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0002E074 File Offset: 0x0002C274
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x0000661A File Offset: 0x0000481A
		public Nullable<double> _BucketSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__BucketSize_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__BucketSize_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0002E0A4 File Offset: 0x0002C2A4
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00006648 File Offset: 0x00004848
		public unsafe string _LegendPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__LegendPosition_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__LegendPosition_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0002E0CC File Offset: 0x0002C2CC
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00006667 File Offset: 0x00004867
		public Nullable<double> _OutlierPercentile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__OutlierPercentile_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__OutlierPercentile_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0002E0FC File Offset: 0x0002C2FC
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x00006695 File Offset: 0x00004895
		public unsafe IList<HistogramSeries> _Series_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__Series_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<HistogramSeries>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__Series_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0002E12C File Offset: 0x0002C32C
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x000066B4 File Offset: 0x000048B4
		public Nullable<bool> _ShowItemDividers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__ShowItemDividers_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__ShowItemDividers_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0002E15C File Offset: 0x0002C35C
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x000066E2 File Offset: 0x000048E2
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramChartSpec.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr__BucketSize_k__BackingField;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr__LegendPosition_k__BackingField;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr__OutlierPercentile_k__BackingField;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr__Series_k__BackingField;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeFieldInfoPtr__ShowItemDividers_k__BackingField;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_get_BucketSize_Public_Virtual_New_get_Nullable_1_Double_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_set_BucketSize_Public_Virtual_New_set_Void_Nullable_1_Double_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_get_LegendPosition_Public_Virtual_New_get_String_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_set_LegendPosition_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_get_OutlierPercentile_Public_Virtual_New_get_Nullable_1_Double_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_set_OutlierPercentile_Public_Virtual_New_set_Void_Nullable_1_Double_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_get_Series_Public_Virtual_New_get_IList_1_HistogramSeries_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_set_Series_Public_Virtual_New_set_Void_IList_1_HistogramSeries_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_get_ShowItemDividers_Public_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_set_ShowItemDividers_Public_Virtual_New_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
