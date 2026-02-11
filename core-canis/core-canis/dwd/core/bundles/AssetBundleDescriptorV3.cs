using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using localization;

namespace dwd.core.bundles
{
	// Token: 0x020001F2 RID: 498
	[Serializable]
	public class AssetBundleDescriptorV3 : Object
	{
		// Token: 0x06001B10 RID: 6928 RVA: 0x0007F29C File Offset: 0x0007D49C
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleDescriptorV3()
		{
			Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "AssetBundleDescriptorV3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr);
			AssetBundleDescriptorV3.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "name");
			AssetBundleDescriptorV3.NativeFieldInfoPtr_assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "assets");
			AssetBundleDescriptorV3.NativeFieldInfoPtr_versionings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "versionings");
			AssetBundleDescriptorV3.NativeFieldInfoPtr_precached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "precached");
			AssetBundleDescriptorV3.NativeFieldInfoPtr_timesensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "timesensitive");
			AssetBundleDescriptorV3.NativeFieldInfoPtr_pathMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "pathMap");
			AssetBundleDescriptorV3.NativeFieldInfoPtr_alt_pathMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "alt_pathMap");
			AssetBundleDescriptorV3.NativeFieldInfoPtr_Locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "Locale");
			AssetBundleDescriptorV3.NativeMethodInfoPtr_GetAltVersionForLocale_Public_Int32_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, 100667589);
			AssetBundleDescriptorV3.NativeMethodInfoPtr_HasLocale_Public_Boolean_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, 100667590);
			AssetBundleDescriptorV3.NativeMethodInfoPtr_GetPrecachedPlatformVersioning_Public_PrecachedPlatformVersioning_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, 100667591);
			AssetBundleDescriptorV3.NativeMethodInfoPtr_GetListingPlatformVersioning_Public_ListingPlatformVersioning_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, 100667592);
			AssetBundleDescriptorV3.NativeMethodInfoPtr_GetLocales_Public_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, 100667593);
			AssetBundleDescriptorV3.NativeMethodInfoPtr_dwd_core_bundles_IAssetBundle_get_versionings_Private_Virtual_Final_New_get_IEnumerable_1_ListingPlatformVersioning_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, 100667594);
			AssetBundleDescriptorV3.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, 100667595);
			AssetBundleDescriptorV3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, 100667596);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0007F40C File Offset: 0x0007D60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884148, XrefRangeEnd = 884151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAltVersionForLocale(TextLocalization.Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.NativeMethodInfoPtr_GetAltVersionForLocale_Public_Int32_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0007F458 File Offset: 0x0007D658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 884165, RefRangeEnd = 884167, XrefRangeStart = 884151, XrefRangeEnd = 884165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasLocale(TextLocalization.Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.NativeMethodInfoPtr_HasLocale_Public_Boolean_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0007F4A4 File Offset: 0x0007D6A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 884181, RefRangeEnd = 884183, XrefRangeStart = 884167, XrefRangeEnd = 884181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrecachedPlatformVersioning GetPrecachedPlatformVersioning(TextLocalization.Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.NativeMethodInfoPtr_GetPrecachedPlatformVersioning_Public_PrecachedPlatformVersioning_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrecachedPlatformVersioning>(intPtr3) : null;
			}
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0007F4F0 File Offset: 0x0007D6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884183, XrefRangeEnd = 884197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListingPlatformVersioning GetListingPlatformVersioning(TextLocalization.Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.NativeMethodInfoPtr_GetListingPlatformVersioning_Public_ListingPlatformVersioning_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ListingPlatformVersioning>(intPtr3) : null;
			}
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0007F53C File Offset: 0x0007D73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884197, XrefRangeEnd = 884218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<string> GetLocales()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.NativeMethodInfoPtr_GetLocales_Public_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0007F57C File Offset: 0x0007D77C
		public unsafe virtual IEnumerable<ListingPlatformVersioning> dwd.core.bundles.IAssetBundle.versionings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.NativeMethodInfoPtr_dwd_core_bundles_IAssetBundle_get_versionings_Private_Virtual_Final_New_get_IEnumerable_1_ListingPlatformVersioning_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ListingPlatformVersioning>>(intPtr3) : null;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x0007F5BC File Offset: 0x0007D7BC
		public unsafe virtual string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0007F5F4 File Offset: 0x0007D7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884218, XrefRangeEnd = 884226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleDescriptorV3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0000BA70 File Offset: 0x00009C70
		public AssetBundleDescriptorV3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x0007F630 File Offset: 0x0007D830
		// (set) Token: 0x06001B1B RID: 6939 RVA: 0x0000BA79 File Offset: 0x00009C79
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x0007F658 File Offset: 0x0007D858
		// (set) Token: 0x06001B1D RID: 6941 RVA: 0x0000BA98 File Offset: 0x00009C98
		public unsafe Il2CppReferenceArray<Asset> assets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_assets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Asset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_assets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0007F688 File Offset: 0x0007D888
		// (set) Token: 0x06001B1F RID: 6943 RVA: 0x0000BAB7 File Offset: 0x00009CB7
		public unsafe Il2CppReferenceArray<ListingPlatformVersioning> versionings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_versionings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ListingPlatformVersioning>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_versionings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0007F6B8 File Offset: 0x0007D8B8
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x0000BAD6 File Offset: 0x00009CD6
		public unsafe Il2CppReferenceArray<PrecachedPlatformVersioning> precached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_precached);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PrecachedPlatformVersioning>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_precached), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0007F6E8 File Offset: 0x0007D8E8
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x0000BAF5 File Offset: 0x00009CF5
		public unsafe long timesensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_timesensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_timesensitive)) = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0007F710 File Offset: 0x0007D910
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x0000BB10 File Offset: 0x00009D10
		public unsafe string pathMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_pathMap);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_pathMap), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x0007F738 File Offset: 0x0007D938
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0000BB2F File Offset: 0x00009D2F
		public unsafe string alt_pathMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_alt_pathMap);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_alt_pathMap), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x0007F760 File Offset: 0x0007D960
		// (set) Token: 0x06001B29 RID: 6953 RVA: 0x0000BB4E File Offset: 0x00009D4E
		public unsafe TextLocalization.Locale Locale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_Locale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.NativeFieldInfoPtr_Locale)) = value;
			}
		}

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeFieldInfoPtr_assets;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeFieldInfoPtr_versionings;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr_precached;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeFieldInfoPtr_timesensitive;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeFieldInfoPtr_pathMap;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeFieldInfoPtr_alt_pathMap;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeFieldInfoPtr_Locale;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_GetAltVersionForLocale_Public_Int32_Locale_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_HasLocale_Public_Boolean_Locale_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_GetPrecachedPlatformVersioning_Public_PrecachedPlatformVersioning_Locale_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_GetListingPlatformVersioning_Public_ListingPlatformVersioning_Locale_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_GetLocales_Public_IList_1_String_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_bundles_IAssetBundle_get_versionings_Private_Virtual_Final_New_get_IEnumerable_1_ListingPlatformVersioning_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000382 RID: 898
		[ObfuscatedName("dwd.core.bundles.AssetBundleDescriptorV3+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600281F RID: 10271 RVA: 0x000A9B40 File Offset: 0x000A7D40
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AssetBundleDescriptorV3.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c>.NativeClassPtr);
				AssetBundleDescriptorV3.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c>.NativeClassPtr, "<>9");
				AssetBundleDescriptorV3.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c>.NativeClassPtr, "<>9__12_0");
				AssetBundleDescriptorV3.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c>.NativeClassPtr, 100667598);
				AssetBundleDescriptorV3.__c.NativeMethodInfoPtr__GetLocales_b__12_0_Internal_String_ListingPlatformVersioning_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c>.NativeClassPtr, 100667599);
			}

			// Token: 0x06002820 RID: 10272 RVA: 0x000A9BBC File Offset: 0x000A7DBC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002821 RID: 10273 RVA: 0x000A9BF8 File Offset: 0x000A7DF8
			[CallerCount(0)]
			public unsafe string _GetLocales_b__12_0(ListingPlatformVersioning x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.__c.NativeMethodInfoPtr__GetLocales_b__12_0_Internal_String_ListingPlatformVersioning_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002822 RID: 10274 RVA: 0x0001230B File Offset: 0x0001050B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B59 RID: 2905
			// (get) Token: 0x06002823 RID: 10275 RVA: 0x000A9C40 File Offset: 0x000A7E40
			// (set) Token: 0x06002824 RID: 10276 RVA: 0x00012314 File Offset: 0x00010514
			public unsafe static AssetBundleDescriptorV3.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AssetBundleDescriptorV3.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleDescriptorV3.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AssetBundleDescriptorV3.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B5A RID: 2906
			// (get) Token: 0x06002825 RID: 10277 RVA: 0x000A9C68 File Offset: 0x000A7E68
			// (set) Token: 0x06002826 RID: 10278 RVA: 0x00012326 File Offset: 0x00010526
			public unsafe static Func<ListingPlatformVersioning, string> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AssetBundleDescriptorV3.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ListingPlatformVersioning, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AssetBundleDescriptorV3.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B40 RID: 6976
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001B41 RID: 6977
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04001B42 RID: 6978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B43 RID: 6979
			private static readonly IntPtr NativeMethodInfoPtr__GetLocales_b__12_0_Internal_String_ListingPlatformVersioning_0;
		}

		// Token: 0x02000383 RID: 899
		[ObfuscatedName("dwd.core.bundles.AssetBundleDescriptorV3+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06002827 RID: 10279 RVA: 0x000A9C90 File Offset: 0x000A7E90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass10_0>.NativeClassPtr);
				AssetBundleDescriptorV3.__c__DisplayClass10_0.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass10_0>.NativeClassPtr, "locale");
				AssetBundleDescriptorV3.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass10_0>.NativeClassPtr, 100667600);
				AssetBundleDescriptorV3.__c__DisplayClass10_0.NativeMethodInfoPtr__GetPrecachedPlatformVersioning_b__0_Internal_Boolean_PrecachedPlatformVersioning_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass10_0>.NativeClassPtr, 100667601);
			}

			// Token: 0x06002828 RID: 10280 RVA: 0x000A9CF8 File Offset: 0x000A7EF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002829 RID: 10281 RVA: 0x000A9D34 File Offset: 0x000A7F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884146, XrefRangeEnd = 884147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPrecachedPlatformVersioning_b__0(PrecachedPlatformVersioning x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.__c__DisplayClass10_0.NativeMethodInfoPtr__GetPrecachedPlatformVersioning_b__0_Internal_Boolean_PrecachedPlatformVersioning_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600282A RID: 10282 RVA: 0x00012338 File Offset: 0x00010538
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B5B RID: 2907
			// (get) Token: 0x0600282B RID: 10283 RVA: 0x000A9D84 File Offset: 0x000A7F84
			// (set) Token: 0x0600282C RID: 10284 RVA: 0x00012341 File Offset: 0x00010541
			public unsafe TextLocalization.Locale locale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.__c__DisplayClass10_0.NativeFieldInfoPtr_locale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.__c__DisplayClass10_0.NativeFieldInfoPtr_locale)) = value;
				}
			}

			// Token: 0x04001B44 RID: 6980
			private static readonly IntPtr NativeFieldInfoPtr_locale;

			// Token: 0x04001B45 RID: 6981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B46 RID: 6982
			private static readonly IntPtr NativeMethodInfoPtr__GetPrecachedPlatformVersioning_b__0_Internal_Boolean_PrecachedPlatformVersioning_0;
		}

		// Token: 0x02000384 RID: 900
		[ObfuscatedName("dwd.core.bundles.AssetBundleDescriptorV3+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600282D RID: 10285 RVA: 0x000A9DAC File Offset: 0x000A7FAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass11_0>.NativeClassPtr);
				AssetBundleDescriptorV3.__c__DisplayClass11_0.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass11_0>.NativeClassPtr, "locale");
				AssetBundleDescriptorV3.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass11_0>.NativeClassPtr, 100667602);
				AssetBundleDescriptorV3.__c__DisplayClass11_0.NativeMethodInfoPtr__GetListingPlatformVersioning_b__0_Internal_Boolean_ListingPlatformVersioning_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass11_0>.NativeClassPtr, 100667603);
			}

			// Token: 0x0600282E RID: 10286 RVA: 0x000A9E14 File Offset: 0x000A8014
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600282F RID: 10287 RVA: 0x000A9E50 File Offset: 0x000A8050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884147, XrefRangeEnd = 884148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetListingPlatformVersioning_b__0(ListingPlatformVersioning x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.__c__DisplayClass11_0.NativeMethodInfoPtr__GetListingPlatformVersioning_b__0_Internal_Boolean_ListingPlatformVersioning_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002830 RID: 10288 RVA: 0x0001235C File Offset: 0x0001055C
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B5C RID: 2908
			// (get) Token: 0x06002831 RID: 10289 RVA: 0x000A9EA0 File Offset: 0x000A80A0
			// (set) Token: 0x06002832 RID: 10290 RVA: 0x00012365 File Offset: 0x00010565
			public unsafe TextLocalization.Locale locale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.__c__DisplayClass11_0.NativeFieldInfoPtr_locale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.__c__DisplayClass11_0.NativeFieldInfoPtr_locale)) = value;
				}
			}

			// Token: 0x04001B47 RID: 6983
			private static readonly IntPtr NativeFieldInfoPtr_locale;

			// Token: 0x04001B48 RID: 6984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B49 RID: 6985
			private static readonly IntPtr NativeMethodInfoPtr__GetListingPlatformVersioning_b__0_Internal_Boolean_ListingPlatformVersioning_0;
		}

		// Token: 0x02000385 RID: 901
		[ObfuscatedName("dwd.core.bundles.AssetBundleDescriptorV3+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06002833 RID: 10291 RVA: 0x000A9EC8 File Offset: 0x000A80C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleDescriptorV3>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass9_0>.NativeClassPtr);
				AssetBundleDescriptorV3.__c__DisplayClass9_0.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass9_0>.NativeClassPtr, "locale");
				AssetBundleDescriptorV3.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass9_0>.NativeClassPtr, 100667604);
				AssetBundleDescriptorV3.__c__DisplayClass9_0.NativeMethodInfoPtr__HasLocale_b__0_Internal_Boolean_ListingPlatformVersioning_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass9_0>.NativeClassPtr, 100667605);
			}

			// Token: 0x06002834 RID: 10292 RVA: 0x000A9F30 File Offset: 0x000A8130
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleDescriptorV3.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002835 RID: 10293 RVA: 0x000A9F6C File Offset: 0x000A816C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasLocale_b__0(ListingPlatformVersioning x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleDescriptorV3.__c__DisplayClass9_0.NativeMethodInfoPtr__HasLocale_b__0_Internal_Boolean_ListingPlatformVersioning_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002836 RID: 10294 RVA: 0x00012380 File Offset: 0x00010580
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x06002837 RID: 10295 RVA: 0x000A9FBC File Offset: 0x000A81BC
			// (set) Token: 0x06002838 RID: 10296 RVA: 0x00012389 File Offset: 0x00010589
			public unsafe TextLocalization.Locale locale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.__c__DisplayClass9_0.NativeFieldInfoPtr_locale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleDescriptorV3.__c__DisplayClass9_0.NativeFieldInfoPtr_locale)) = value;
				}
			}

			// Token: 0x04001B4A RID: 6986
			private static readonly IntPtr NativeFieldInfoPtr_locale;

			// Token: 0x04001B4B RID: 6987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B4C RID: 6988
			private static readonly IntPtr NativeMethodInfoPtr__HasLocale_b__0_Internal_Boolean_ListingPlatformVersioning_0;
		}
	}
}
