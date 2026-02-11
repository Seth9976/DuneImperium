using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000499 RID: 1177
	[Serializable]
	public class RegionInfo : Object
	{
		// Token: 0x0600493C RID: 18748 RVA: 0x00153F64 File Offset: 0x00152164
		// Note: this type is marked as 'beforefieldinit'.
		static RegionInfo()
		{
			Il2CppClassPointerStore<RegionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "RegionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr);
			RegionInfo.NativeFieldInfoPtr_currentRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currentRegion");
			RegionInfo.NativeFieldInfoPtr_regionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "regionId");
			RegionInfo.NativeFieldInfoPtr_iso2Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "iso2Name");
			RegionInfo.NativeFieldInfoPtr_iso3Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "iso3Name");
			RegionInfo.NativeFieldInfoPtr_win3Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "win3Name");
			RegionInfo.NativeFieldInfoPtr_englishName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "englishName");
			RegionInfo.NativeFieldInfoPtr_nativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "nativeName");
			RegionInfo.NativeFieldInfoPtr_currencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currencySymbol");
			RegionInfo.NativeFieldInfoPtr_isoCurrencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "isoCurrencySymbol");
			RegionInfo.NativeFieldInfoPtr_currencyEnglishName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currencyEnglishName");
			RegionInfo.NativeFieldInfoPtr_currencyNativeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, "currencyNativeName");
			RegionInfo.NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_RegionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673977);
			RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673978);
			RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673979);
			RegionInfo.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673980);
			RegionInfo.NativeMethodInfoPtr_GetByTerritory_Private_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673981);
			RegionInfo.NativeMethodInfoPtr_construct_internal_region_from_name_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673982);
			RegionInfo.NativeMethodInfoPtr_get_CurrencyEnglishName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673983);
			RegionInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673984);
			RegionInfo.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673985);
			RegionInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673986);
			RegionInfo.NativeMethodInfoPtr_get_GeoId_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673987);
			RegionInfo.NativeMethodInfoPtr_get_IsMetric_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673988);
			RegionInfo.NativeMethodInfoPtr_get_ISOCurrencySymbol_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673989);
			RegionInfo.NativeMethodInfoPtr_get_NativeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673990);
			RegionInfo.NativeMethodInfoPtr_get_CurrencyNativeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673991);
			RegionInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673992);
			RegionInfo.NativeMethodInfoPtr_get_ThreeLetterISORegionName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673993);
			RegionInfo.NativeMethodInfoPtr_get_ThreeLetterWindowsRegionName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673994);
			RegionInfo.NativeMethodInfoPtr_get_TwoLetterISORegionName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673995);
			RegionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673996);
			RegionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673997);
			RegionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673998);
			RegionInfo.NativeMethodInfoPtr_ClearCachedData_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr, 100673999);
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x0600493D RID: 18749 RVA: 0x0015423C File Offset: 0x0015243C
		public unsafe static RegionInfo CurrentRegion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414150, XrefRangeEnd = 1414163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_RegionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegionInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x00154270 File Offset: 0x00152470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414163, XrefRangeEnd = 1414170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionInfo(int culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref culture;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x001542B8 File Offset: 0x001524B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414170, XrefRangeEnd = 1414179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionInfo(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x00154304 File Offset: 0x00152504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414217, RefRangeEnd = 1414218, XrefRangeStart = 1414179, XrefRangeEnd = 1414217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegionInfo(CultureInfo ci)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ci);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x00154350 File Offset: 0x00152550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414218, XrefRangeEnd = 1414220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetByTerritory(CultureInfo ci)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ci);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_GetByTerritory_Private_Boolean_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x001543A0 File Offset: 0x001525A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414220, XrefRangeEnd = 1414221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool construct_internal_region_from_name(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_construct_internal_region_from_name_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06004943 RID: 18755 RVA: 0x001543F0 File Offset: 0x001525F0
		public unsafe virtual string CurrencyEnglishName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_CurrencyEnglishName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06004944 RID: 18756 RVA: 0x00154434 File Offset: 0x00152634
		public unsafe virtual string CurrencySymbol
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06004945 RID: 18757 RVA: 0x00154478 File Offset: 0x00152678
		public unsafe virtual string DisplayName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06004946 RID: 18758 RVA: 0x001544BC File Offset: 0x001526BC
		public unsafe virtual string EnglishName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06004947 RID: 18759 RVA: 0x00154500 File Offset: 0x00152700
		public unsafe virtual int GeoId
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_GeoId_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06004948 RID: 18760 RVA: 0x00154548 File Offset: 0x00152748
		public unsafe virtual bool IsMetric
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414221, XrefRangeEnd = 1414227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_IsMetric_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x00154590 File Offset: 0x00152790
		public unsafe virtual string ISOCurrencySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_ISOCurrencySymbol_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x0600494A RID: 18762 RVA: 0x001545D4 File Offset: 0x001527D4
		public unsafe virtual string NativeName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_NativeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x00154618 File Offset: 0x00152818
		public unsafe virtual string CurrencyNativeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_CurrencyNativeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x0015465C File Offset: 0x0015285C
		public unsafe virtual string Name
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x001546A0 File Offset: 0x001528A0
		public unsafe virtual string ThreeLetterISORegionName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_ThreeLetterISORegionName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x0600494E RID: 18766 RVA: 0x001546E4 File Offset: 0x001528E4
		public unsafe virtual string ThreeLetterWindowsRegionName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_ThreeLetterWindowsRegionName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x0600494F RID: 18767 RVA: 0x00154728 File Offset: 0x00152928
		public unsafe virtual string TwoLetterISORegionName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_get_TwoLetterISORegionName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x0015476C File Offset: 0x0015296C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414227, XrefRangeEnd = 1414231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x001547C4 File Offset: 0x001529C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414231, XrefRangeEnd = 1414232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x0015480C File Offset: 0x00152A0C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 308626, RefRangeEnd = 308638, XrefRangeStart = 308626, XrefRangeEnd = 308638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x00154850 File Offset: 0x00152A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414232, XrefRangeEnd = 1414236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCachedData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegionInfo.NativeMethodInfoPtr_ClearCachedData_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x0001ABA3 File Offset: 0x00018DA3
		public RegionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x00154878 File Offset: 0x00152A78
		// (set) Token: 0x06004956 RID: 18774 RVA: 0x0001ABAC File Offset: 0x00018DAC
		public unsafe static RegionInfo currentRegion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegionInfo.NativeFieldInfoPtr_currentRegion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegionInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegionInfo.NativeFieldInfoPtr_currentRegion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x001548A0 File Offset: 0x00152AA0
		// (set) Token: 0x06004958 RID: 18776 RVA: 0x0001ABBE File Offset: 0x00018DBE
		public unsafe int regionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_regionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_regionId)) = value;
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06004959 RID: 18777 RVA: 0x001548C8 File Offset: 0x00152AC8
		// (set) Token: 0x0600495A RID: 18778 RVA: 0x0001ABD9 File Offset: 0x00018DD9
		public unsafe string iso2Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso2Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso2Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x0600495B RID: 18779 RVA: 0x001548F0 File Offset: 0x00152AF0
		// (set) Token: 0x0600495C RID: 18780 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		public unsafe string iso3Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso3Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_iso3Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x0600495D RID: 18781 RVA: 0x00154918 File Offset: 0x00152B18
		// (set) Token: 0x0600495E RID: 18782 RVA: 0x0001AC17 File Offset: 0x00018E17
		public unsafe string win3Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_win3Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_win3Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x00154940 File Offset: 0x00152B40
		// (set) Token: 0x06004960 RID: 18784 RVA: 0x0001AC36 File Offset: 0x00018E36
		public unsafe string englishName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_englishName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_englishName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06004961 RID: 18785 RVA: 0x00154968 File Offset: 0x00152B68
		// (set) Token: 0x06004962 RID: 18786 RVA: 0x0001AC55 File Offset: 0x00018E55
		public unsafe string nativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_nativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_nativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06004963 RID: 18787 RVA: 0x00154990 File Offset: 0x00152B90
		// (set) Token: 0x06004964 RID: 18788 RVA: 0x0001AC74 File Offset: 0x00018E74
		public unsafe string currencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x001549B8 File Offset: 0x00152BB8
		// (set) Token: 0x06004966 RID: 18790 RVA: 0x0001AC93 File Offset: 0x00018E93
		public unsafe string isoCurrencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_isoCurrencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_isoCurrencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06004967 RID: 18791 RVA: 0x001549E0 File Offset: 0x00152BE0
		// (set) Token: 0x06004968 RID: 18792 RVA: 0x0001ACB2 File Offset: 0x00018EB2
		public unsafe string currencyEnglishName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyEnglishName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyEnglishName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06004969 RID: 18793 RVA: 0x00154A08 File Offset: 0x00152C08
		// (set) Token: 0x0600496A RID: 18794 RVA: 0x0001ACD1 File Offset: 0x00018ED1
		public unsafe string currencyNativeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyNativeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegionInfo.NativeFieldInfoPtr_currencyNativeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C1B RID: 15387
		private static readonly IntPtr NativeFieldInfoPtr_currentRegion;

		// Token: 0x04003C1C RID: 15388
		private static readonly IntPtr NativeFieldInfoPtr_regionId;

		// Token: 0x04003C1D RID: 15389
		private static readonly IntPtr NativeFieldInfoPtr_iso2Name;

		// Token: 0x04003C1E RID: 15390
		private static readonly IntPtr NativeFieldInfoPtr_iso3Name;

		// Token: 0x04003C1F RID: 15391
		private static readonly IntPtr NativeFieldInfoPtr_win3Name;

		// Token: 0x04003C20 RID: 15392
		private static readonly IntPtr NativeFieldInfoPtr_englishName;

		// Token: 0x04003C21 RID: 15393
		private static readonly IntPtr NativeFieldInfoPtr_nativeName;

		// Token: 0x04003C22 RID: 15394
		private static readonly IntPtr NativeFieldInfoPtr_currencySymbol;

		// Token: 0x04003C23 RID: 15395
		private static readonly IntPtr NativeFieldInfoPtr_isoCurrencySymbol;

		// Token: 0x04003C24 RID: 15396
		private static readonly IntPtr NativeFieldInfoPtr_currencyEnglishName;

		// Token: 0x04003C25 RID: 15397
		private static readonly IntPtr NativeFieldInfoPtr_currencyNativeName;

		// Token: 0x04003C26 RID: 15398
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRegion_Public_Static_get_RegionInfo_0;

		// Token: 0x04003C27 RID: 15399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003C28 RID: 15400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003C29 RID: 15401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0;

		// Token: 0x04003C2A RID: 15402
		private static readonly IntPtr NativeMethodInfoPtr_GetByTerritory_Private_Boolean_CultureInfo_0;

		// Token: 0x04003C2B RID: 15403
		private static readonly IntPtr NativeMethodInfoPtr_construct_internal_region_from_name_Private_Boolean_String_0;

		// Token: 0x04003C2C RID: 15404
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyEnglishName_Public_Virtual_New_get_String_0;

		// Token: 0x04003C2D RID: 15405
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencySymbol_Public_Virtual_New_get_String_0;

		// Token: 0x04003C2E RID: 15406
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_New_get_String_0;

		// Token: 0x04003C2F RID: 15407
		private static readonly IntPtr NativeMethodInfoPtr_get_EnglishName_Public_Virtual_New_get_String_0;

		// Token: 0x04003C30 RID: 15408
		private static readonly IntPtr NativeMethodInfoPtr_get_GeoId_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003C31 RID: 15409
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMetric_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003C32 RID: 15410
		private static readonly IntPtr NativeMethodInfoPtr_get_ISOCurrencySymbol_Public_Virtual_New_get_String_0;

		// Token: 0x04003C33 RID: 15411
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeName_Public_Virtual_New_get_String_0;

		// Token: 0x04003C34 RID: 15412
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyNativeName_Public_Virtual_New_get_String_0;

		// Token: 0x04003C35 RID: 15413
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x04003C36 RID: 15414
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreeLetterISORegionName_Public_Virtual_New_get_String_0;

		// Token: 0x04003C37 RID: 15415
		private static readonly IntPtr NativeMethodInfoPtr_get_ThreeLetterWindowsRegionName_Public_Virtual_New_get_String_0;

		// Token: 0x04003C38 RID: 15416
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoLetterISORegionName_Public_Virtual_New_get_String_0;

		// Token: 0x04003C39 RID: 15417
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003C3A RID: 15418
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003C3B RID: 15419
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003C3C RID: 15420
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedData_Internal_Static_Void_0;
	}
}
