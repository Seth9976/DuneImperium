using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class AssetBundleCreateRequest : AsyncOperation
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003160 File Offset: 0x00001360
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleCreateRequest()
		{
			Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleCreateRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr);
			AssetBundleCreateRequest.NativeMethodInfoPtr_get_assetBundle_Public_get_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr, 100663323);
			AssetBundleCreateRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr, 100663324);
			AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegateField = IL2CPP.ResolveICall<AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegate>("UnityEngine.AssetBundleCreateRequest::SetEnableCompatibilityChecks");
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000031C8 File Offset: 0x000013C8
		public unsafe AssetBundle assetBundle
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1270120, RefRangeEnd = 1270124, XrefRangeStart = 1270118, XrefRangeEnd = 1270120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleCreateRequest.NativeMethodInfoPtr_get_assetBundle_Public_get_AssetBundle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003208 File Offset: 0x00001408
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleCreateRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleCreateRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000020A7 File Offset: 0x000002A7
		public AssetBundleCreateRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000020B0 File Offset: 0x000002B0
		public void SetEnableCompatibilityChecks(bool set)
		{
			AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), set);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000020C3 File Offset: 0x000002C3
		public void DisableCompatibilityChecks()
		{
			this.SetEnableCompatibilityChecks(false);
		}

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_assetBundle_Public_get_AssetBundle_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000026 RID: 38
		private static readonly AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegate SetEnableCompatibilityChecksDelegateField;

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000084 RID: 132
		private delegate void SetEnableCompatibilityChecksDelegate(IntPtr @this, bool set);
	}
}
