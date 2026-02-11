using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

// Token: 0x02000036 RID: 54
public class SyncBundleProvider : AssetBundleProvider
{
	// Token: 0x06000490 RID: 1168 RVA: 0x00025694 File Offset: 0x00023894
	// Note: this type is marked as 'beforefieldinit'.
	static SyncBundleProvider()
	{
		Il2CppClassPointerStore<SyncBundleProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "SyncBundleProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncBundleProvider>.NativeClassPtr);
		SyncBundleProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundleProvider>.NativeClassPtr, 100663958);
		SyncBundleProvider.NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundleProvider>.NativeClassPtr, 100663959);
		SyncBundleProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundleProvider>.NativeClassPtr, 100663960);
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00025700 File Offset: 0x00023900
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856869, XrefRangeEnd = 856899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Provide(ProvideHandle providerInterface)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(providerInterface));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyncBundleProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x00025754 File Offset: 0x00023954
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856899, XrefRangeEnd = 856911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Release(IResourceLocation location, global::Il2CppSystem.Object asset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asset);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyncBundleProvider.NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x000257B4 File Offset: 0x000239B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856911, XrefRangeEnd = 856915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SyncBundleProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncBundleProvider>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncBundleProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00003B47 File Offset: 0x00001D47
	public SyncBundleProvider(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000357 RID: 855
	private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0;

	// Token: 0x04000358 RID: 856
	private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0;

	// Token: 0x04000359 RID: 857
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000240 RID: 576
	public class SyncAssetBundleResource : global::Il2CppSystem.Object
	{
		// Token: 0x06001E9B RID: 7835 RVA: 0x0008BCBC File Offset: 0x00089EBC
		// Note: this type is marked as 'beforefieldinit'.
		static SyncAssetBundleResource()
		{
			Il2CppClassPointerStore<SyncBundleProvider.SyncAssetBundleResource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncBundleProvider>.NativeClassPtr, "SyncAssetBundleResource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncBundleProvider.SyncAssetBundleResource>.NativeClassPtr);
			SyncBundleProvider.SyncAssetBundleResource.NativeFieldInfoPtr_m_AssetBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncBundleProvider.SyncAssetBundleResource>.NativeClassPtr, "m_AssetBundle");
			SyncBundleProvider.SyncAssetBundleResource.NativeMethodInfoPtr_GetAssetBundle_Public_Virtual_Final_New_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundleProvider.SyncAssetBundleResource>.NativeClassPtr, 100663961);
			SyncBundleProvider.SyncAssetBundleResource.NativeMethodInfoPtr_Start_Internal_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundleProvider.SyncAssetBundleResource>.NativeClassPtr, 100663962);
			SyncBundleProvider.SyncAssetBundleResource.NativeMethodInfoPtr_Unload_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundleProvider.SyncAssetBundleResource>.NativeClassPtr, 100663963);
			SyncBundleProvider.SyncAssetBundleResource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBundleProvider.SyncAssetBundleResource>.NativeClassPtr, 100663964);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0008BD4C File Offset: 0x00089F4C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AssetBundle GetAssetBundle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncBundleProvider.SyncAssetBundleResource.NativeMethodInfoPtr_GetAssetBundle_Public_Virtual_Final_New_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0008BD8C File Offset: 0x00089F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856837, XrefRangeEnd = 856863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(ProvideHandle provideHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncBundleProvider.SyncAssetBundleResource.NativeMethodInfoPtr_Start_Internal_Void_ProvideHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0008BDD4 File Offset: 0x00089FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856863, XrefRangeEnd = 856869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncBundleProvider.SyncAssetBundleResource.NativeMethodInfoPtr_Unload_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0008BE08 File Offset: 0x0008A008
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyncAssetBundleResource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncBundleProvider.SyncAssetBundleResource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncBundleProvider.SyncAssetBundleResource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x0000D194 File Offset: 0x0000B394
		public SyncAssetBundleResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x0008BE44 File Offset: 0x0008A044
		// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x0000D19D File Offset: 0x0000B39D
		public unsafe AssetBundle m_AssetBundle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncBundleProvider.SyncAssetBundleResource.NativeFieldInfoPtr_m_AssetBundle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncBundleProvider.SyncAssetBundleResource.NativeFieldInfoPtr_m_AssetBundle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetBundle;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundle_Public_Virtual_Final_New_AssetBundle_0;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeMethodInfoPtr_Start_Internal_Void_ProvideHandle_0;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeMethodInfoPtr_Unload_Internal_Void_0;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
