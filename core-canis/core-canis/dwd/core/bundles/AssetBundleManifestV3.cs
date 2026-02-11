using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.bundles
{
	// Token: 0x020001F6 RID: 502
	[Serializable]
	public class AssetBundleManifestV3 : Object
	{
		// Token: 0x06001BBC RID: 7100 RVA: 0x00081AE4 File Offset: 0x0007FCE4
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleManifestV3()
		{
			Il2CppClassPointerStore<AssetBundleManifestV3>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "AssetBundleManifestV3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleManifestV3>.NativeClassPtr);
			AssetBundleManifestV3.NativeFieldInfoPtr_platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManifestV3>.NativeClassPtr, "platform");
			AssetBundleManifestV3.NativeFieldInfoPtr_bundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManifestV3>.NativeClassPtr, "bundles");
			AssetBundleManifestV3.NativeFieldInfoPtr_preloadBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManifestV3>.NativeClassPtr, "preloadBundles");
			AssetBundleManifestV3.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManifestV3>.NativeClassPtr, "version");
			AssetBundleManifestV3.NativeFieldInfoPtr_forceloadBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleManifestV3>.NativeClassPtr, "forceloadBundles");
			AssetBundleManifestV3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManifestV3>.NativeClassPtr, 100667708);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00081B8C File Offset: 0x0007FD8C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleManifestV3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleManifestV3>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManifestV3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0000BF22 File Offset: 0x0000A122
		public AssetBundleManifestV3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00081BC8 File Offset: 0x0007FDC8
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x0000BF2B File Offset: 0x0000A12B
		public unsafe string platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManifestV3.NativeFieldInfoPtr_platform);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManifestV3.NativeFieldInfoPtr_platform), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x00081BF0 File Offset: 0x0007FDF0
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x0000BF4A File Offset: 0x0000A14A
		public unsafe Il2CppReferenceArray<AssetBundleDescriptorV3> bundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManifestV3.NativeFieldInfoPtr_bundles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetBundleDescriptorV3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManifestV3.NativeFieldInfoPtr_bundles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00081C20 File Offset: 0x0007FE20
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x0000BF69 File Offset: 0x0000A169
		public unsafe Il2CppStringArray preloadBundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManifestV3.NativeFieldInfoPtr_preloadBundles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManifestV3.NativeFieldInfoPtr_preloadBundles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00081C50 File Offset: 0x0007FE50
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x0000BF88 File Offset: 0x0000A188
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManifestV3.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManifestV3.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00081C78 File Offset: 0x0007FE78
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x0000BFA3 File Offset: 0x0000A1A3
		public unsafe Il2CppStringArray forceloadBundles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManifestV3.NativeFieldInfoPtr_forceloadBundles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleManifestV3.NativeFieldInfoPtr_forceloadBundles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeFieldInfoPtr_platform;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeFieldInfoPtr_bundles;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeFieldInfoPtr_preloadBundles;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeFieldInfoPtr_forceloadBundles;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
