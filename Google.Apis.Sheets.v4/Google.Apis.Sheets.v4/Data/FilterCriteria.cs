using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x0200006F RID: 111
	public class FilterCriteria : Object
	{
		// Token: 0x0600080C RID: 2060 RVA: 0x00029870 File Offset: 0x00027A70
		// Note: this type is marked as 'beforefieldinit'.
		static FilterCriteria()
		{
			Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "FilterCriteria");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr);
			FilterCriteria.NativeFieldInfoPtr__Condition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, "<Condition>k__BackingField");
			FilterCriteria.NativeFieldInfoPtr__HiddenValues_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, "<HiddenValues>k__BackingField");
			FilterCriteria.NativeFieldInfoPtr__VisibleBackgroundColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, "<VisibleBackgroundColor>k__BackingField");
			FilterCriteria.NativeFieldInfoPtr__VisibleBackgroundColorStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, "<VisibleBackgroundColorStyle>k__BackingField");
			FilterCriteria.NativeFieldInfoPtr__VisibleForegroundColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, "<VisibleForegroundColor>k__BackingField");
			FilterCriteria.NativeFieldInfoPtr__VisibleForegroundColorStyle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, "<VisibleForegroundColorStyle>k__BackingField");
			FilterCriteria.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, "<ETag>k__BackingField");
			FilterCriteria.NativeMethodInfoPtr_get_Condition_Public_Virtual_New_get_BooleanCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664495);
			FilterCriteria.NativeMethodInfoPtr_set_Condition_Public_Virtual_New_set_Void_BooleanCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664496);
			FilterCriteria.NativeMethodInfoPtr_get_HiddenValues_Public_Virtual_New_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664497);
			FilterCriteria.NativeMethodInfoPtr_set_HiddenValues_Public_Virtual_New_set_Void_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664498);
			FilterCriteria.NativeMethodInfoPtr_get_VisibleBackgroundColor_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664499);
			FilterCriteria.NativeMethodInfoPtr_set_VisibleBackgroundColor_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664500);
			FilterCriteria.NativeMethodInfoPtr_get_VisibleBackgroundColorStyle_Public_Virtual_New_get_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664501);
			FilterCriteria.NativeMethodInfoPtr_set_VisibleBackgroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664502);
			FilterCriteria.NativeMethodInfoPtr_get_VisibleForegroundColor_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664503);
			FilterCriteria.NativeMethodInfoPtr_set_VisibleForegroundColor_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664504);
			FilterCriteria.NativeMethodInfoPtr_get_VisibleForegroundColorStyle_Public_Virtual_New_get_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664505);
			FilterCriteria.NativeMethodInfoPtr_set_VisibleForegroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664506);
			FilterCriteria.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664507);
			FilterCriteria.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664508);
			FilterCriteria.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr, 100664509);
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00029A58 File Offset: 0x00027C58
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00029AA4 File Offset: 0x00027CA4
		public unsafe virtual BooleanCondition Condition
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_get_Condition_Public_Virtual_New_get_BooleanCondition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BooleanCondition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_set_Condition_Public_Virtual_New_set_Void_BooleanCondition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00029AF4 File Offset: 0x00027CF4
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00029B40 File Offset: 0x00027D40
		public unsafe virtual IList<string> HiddenValues
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_get_HiddenValues_Public_Virtual_New_get_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_set_HiddenValues_Public_Virtual_New_set_Void_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00029B90 File Offset: 0x00027D90
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00029BDC File Offset: 0x00027DDC
		public unsafe virtual Color VisibleBackgroundColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_get_VisibleBackgroundColor_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_set_VisibleBackgroundColor_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00029C2C File Offset: 0x00027E2C
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00029C78 File Offset: 0x00027E78
		public unsafe virtual ColorStyle VisibleBackgroundColorStyle
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_get_VisibleBackgroundColorStyle_Public_Virtual_New_get_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_set_VisibleBackgroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00029CC8 File Offset: 0x00027EC8
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00029D14 File Offset: 0x00027F14
		public unsafe virtual Color VisibleForegroundColor
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_get_VisibleForegroundColor_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_set_VisibleForegroundColor_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00029D64 File Offset: 0x00027F64
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00029DB0 File Offset: 0x00027FB0
		public unsafe virtual ColorStyle VisibleForegroundColorStyle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_get_VisibleForegroundColorStyle_Public_Virtual_New_get_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_set_VisibleForegroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00029E00 File Offset: 0x00028000
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00029E44 File Offset: 0x00028044
		public unsafe virtual string ETag
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterCriteria.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00029E94 File Offset: 0x00028094
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterCriteria()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterCriteria>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterCriteria.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00005C92 File Offset: 0x00003E92
		public FilterCriteria(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00029ED0 File Offset: 0x000280D0
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00005C9B File Offset: 0x00003E9B
		public unsafe BooleanCondition _Condition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__Condition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BooleanCondition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__Condition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00029F00 File Offset: 0x00028100
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00005CBA File Offset: 0x00003EBA
		public unsafe IList<string> _HiddenValues_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__HiddenValues_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__HiddenValues_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00029F30 File Offset: 0x00028130
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00005CD9 File Offset: 0x00003ED9
		public unsafe Color _VisibleBackgroundColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__VisibleBackgroundColor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__VisibleBackgroundColor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00029F60 File Offset: 0x00028160
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public unsafe ColorStyle _VisibleBackgroundColorStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__VisibleBackgroundColorStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__VisibleBackgroundColorStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00029F90 File Offset: 0x00028190
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00005D17 File Offset: 0x00003F17
		public unsafe Color _VisibleForegroundColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__VisibleForegroundColor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__VisibleForegroundColor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00029FC0 File Offset: 0x000281C0
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00005D36 File Offset: 0x00003F36
		public unsafe ColorStyle _VisibleForegroundColorStyle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__VisibleForegroundColorStyle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__VisibleForegroundColorStyle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00029FF0 File Offset: 0x000281F0
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00005D55 File Offset: 0x00003F55
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterCriteria.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr__Condition_k__BackingField;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr__HiddenValues_k__BackingField;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr__VisibleBackgroundColor_k__BackingField;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeFieldInfoPtr__VisibleBackgroundColorStyle_k__BackingField;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr__VisibleForegroundColor_k__BackingField;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr__VisibleForegroundColorStyle_k__BackingField;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_get_Condition_Public_Virtual_New_get_BooleanCondition_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_set_Condition_Public_Virtual_New_set_Void_BooleanCondition_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_get_HiddenValues_Public_Virtual_New_get_IList_1_String_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_set_HiddenValues_Public_Virtual_New_set_Void_IList_1_String_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_get_VisibleBackgroundColor_Public_Virtual_New_get_Color_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_set_VisibleBackgroundColor_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_get_VisibleBackgroundColorStyle_Public_Virtual_New_get_ColorStyle_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_set_VisibleBackgroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_get_VisibleForegroundColor_Public_Virtual_New_get_Color_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_set_VisibleForegroundColor_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_get_VisibleForegroundColorStyle_Public_Virtual_New_get_ColorStyle_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_set_VisibleForegroundColorStyle_Public_Virtual_New_set_Void_ColorStyle_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
