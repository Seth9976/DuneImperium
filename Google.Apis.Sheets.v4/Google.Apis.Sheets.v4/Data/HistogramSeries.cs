using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200007B RID: 123
	public class HistogramSeries : Object
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x0002E608 File Offset: 0x0002C808
		// Note: this type is marked as 'beforefieldinit'.
		static HistogramSeries()
		{
			Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "HistogramSeries");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr);
			HistogramSeries.NativeFieldInfoPtr__BarColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, "<BarColor>k__BackingField");
			HistogramSeries.NativeFieldInfoPtr__BarColorStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, "<BarColorStyle>k__BackingField");
			HistogramSeries.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, "<Data>k__BackingField");
			HistogramSeries.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, "<ETag>k__BackingField");
			HistogramSeries.NativeMethodInfoPtr_get_BarColor_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, 100664649);
			HistogramSeries.NativeMethodInfoPtr_set_BarColor_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, 100664650);
			HistogramSeries.NativeMethodInfoPtr_get_BarColorStyle_Public_Virtual_New_get_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, 100664651);
			HistogramSeries.NativeMethodInfoPtr_set_BarColorStyle_Public_Virtual_New_set_Void_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, 100664652);
			HistogramSeries.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, 100664653);
			HistogramSeries.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, 100664654);
			HistogramSeries.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, 100664655);
			HistogramSeries.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, 100664656);
			HistogramSeries.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr, 100664657);
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0002E73C File Offset: 0x0002C93C
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x0002E788 File Offset: 0x0002C988
		public unsafe virtual Color BarColor
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramSeries.NativeMethodInfoPtr_get_BarColor_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramSeries.NativeMethodInfoPtr_set_BarColor_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0002E7D8 File Offset: 0x0002C9D8
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x0002E824 File Offset: 0x0002CA24
		public unsafe virtual ColorStyle BarColorStyle
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramSeries.NativeMethodInfoPtr_get_BarColorStyle_Public_Virtual_New_get_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramSeries.NativeMethodInfoPtr_set_BarColorStyle_Public_Virtual_New_set_Void_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0002E874 File Offset: 0x0002CA74
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x0002E8C0 File Offset: 0x0002CAC0
		public unsafe virtual ChartData Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramSeries.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramSeries.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0002E910 File Offset: 0x0002CB10
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x0002E954 File Offset: 0x0002CB54
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramSeries.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HistogramSeries.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0002E9A4 File Offset: 0x0002CBA4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HistogramSeries()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HistogramSeries>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HistogramSeries.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000067B3 File Offset: 0x000049B3
		public HistogramSeries(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x000067BC File Offset: 0x000049BC
		public unsafe Color _BarColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramSeries.NativeFieldInfoPtr__BarColor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramSeries.NativeFieldInfoPtr__BarColor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0002EA10 File Offset: 0x0002CC10
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x000067DB File Offset: 0x000049DB
		public unsafe ColorStyle _BarColorStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramSeries.NativeFieldInfoPtr__BarColorStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramSeries.NativeFieldInfoPtr__BarColorStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0002EA40 File Offset: 0x0002CC40
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x000067FA File Offset: 0x000049FA
		public unsafe ChartData _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramSeries.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChartData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramSeries.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0002EA70 File Offset: 0x0002CC70
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00006819 File Offset: 0x00004A19
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramSeries.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HistogramSeries.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr__BarColor_k__BackingField;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr__BarColorStyle_k__BackingField;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_get_BarColor_Public_Virtual_New_get_Color_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_set_BarColor_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_get_BarColorStyle_Public_Virtual_New_get_ColorStyle_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_set_BarColorStyle_Public_Virtual_New_set_Void_ColorStyle_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_ChartData_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_ChartData_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
