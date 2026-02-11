using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class AssetBundleManifest : Object
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00003244 File Offset: 0x00001444
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleManifest()
		{
			Il2CppClassPointerStore<AssetBundleManifest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleManifest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleManifest>.NativeClassPtr);
			AssetBundleManifest.NativeMethodInfoPtr_GetAssetBundleHash_Public_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManifest>.NativeClassPtr, 100663325);
			AssetBundleManifest.NativeMethodInfoPtr_GetAssetBundleHash_Injected_Private_Void_String_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleManifest>.NativeClassPtr, 100663326);
			AssetBundleManifest.GetAllAssetBundlesDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetAllAssetBundlesDelegate>("UnityEngine.AssetBundleManifest::GetAllAssetBundles");
			AssetBundleManifest.GetAllAssetBundlesWithVariantDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetAllAssetBundlesWithVariantDelegate>("UnityEngine.AssetBundleManifest::GetAllAssetBundlesWithVariant");
			AssetBundleManifest.GetDirectDependenciesDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetDirectDependenciesDelegate>("UnityEngine.AssetBundleManifest::GetDirectDependencies");
			AssetBundleManifest.GetAllDependenciesDelegateField = IL2CPP.ResolveICall<AssetBundleManifest.GetAllDependenciesDelegate>("UnityEngine.AssetBundleManifest::GetAllDependencies");
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000032D8 File Offset: 0x000014D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270124, XrefRangeEnd = 1270126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hash128 GetAssetBundleHash(string assetBundleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManifest.NativeMethodInfoPtr_GetAssetBundleHash_Public_Hash128_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003328 File Offset: 0x00001528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270126, XrefRangeEnd = 1270128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAssetBundleHash_Injected(string assetBundleName, out Hash128 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleManifest.NativeMethodInfoPtr_GetAssetBundleHash_Injected_Private_Void_String_byref_Hash128_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000020CE File Offset: 0x000002CE
		public AssetBundleManifest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003378 File Offset: 0x00001578
		public Il2CppStringArray GetAllAssetBundles()
		{
			IntPtr intPtr = AssetBundleManifest.GetAllAssetBundlesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000033A4 File Offset: 0x000015A4
		public Il2CppStringArray GetAllAssetBundlesWithVariant()
		{
			IntPtr intPtr = AssetBundleManifest.GetAllAssetBundlesWithVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000033D0 File Offset: 0x000015D0
		public Il2CppStringArray GetDirectDependencies(string assetBundleName)
		{
			IntPtr intPtr = AssetBundleManifest.GetDirectDependenciesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(assetBundleName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003404 File Offset: 0x00001604
		public Il2CppStringArray GetAllDependencies(string assetBundleName)
		{
			IntPtr intPtr = AssetBundleManifest.GetAllDependenciesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(assetBundleName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundleHash_Public_Hash128_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundleHash_Injected_Private_Void_String_byref_Hash128_0;

		// Token: 0x04000029 RID: 41
		private static readonly AssetBundleManifest.GetAllAssetBundlesDelegate GetAllAssetBundlesDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly AssetBundleManifest.GetAllAssetBundlesWithVariantDelegate GetAllAssetBundlesWithVariantDelegateField;

		// Token: 0x0400002B RID: 43
		private static readonly AssetBundleManifest.GetDirectDependenciesDelegate GetDirectDependenciesDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly AssetBundleManifest.GetAllDependenciesDelegate GetAllDependenciesDelegateField;

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000086 RID: 134
		private delegate IntPtr GetAllAssetBundlesDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000088 RID: 136
		private delegate IntPtr GetAllAssetBundlesWithVariantDelegate(IntPtr @this);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600008A RID: 138
		private delegate IntPtr GetDirectDependenciesDelegate(IntPtr @this, IntPtr assetBundleName);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600008C RID: 140
		private delegate IntPtr GetAllDependenciesDelegate(IntPtr @this, IntPtr assetBundleName);
	}
}
