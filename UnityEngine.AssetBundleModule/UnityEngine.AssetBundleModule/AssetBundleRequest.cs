using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public class AssetBundleRequest : ResourceRequest
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00003520 File Offset: 0x00001720
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleRequest()
		{
			Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr);
			AssetBundleRequest.NativeMethodInfoPtr_GetResult_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100663327);
			AssetBundleRequest.NativeMethodInfoPtr_get_asset_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100663328);
			AssetBundleRequest.NativeMethodInfoPtr_get_allAssets_Public_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100663329);
			AssetBundleRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr, 100663330);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000035A0 File Offset: 0x000017A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270128, XrefRangeEnd = 1270130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleRequest.NativeMethodInfoPtr_GetResult_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000035EC File Offset: 0x000017EC
		public new unsafe Object asset
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 660290, RefRangeEnd = 660296, XrefRangeStart = 660290, XrefRangeEnd = 660296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_get_asset_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000362C File Offset: 0x0000182C
		public unsafe Il2CppReferenceArray<Object> allAssets
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1270132, RefRangeEnd = 1270135, XrefRangeStart = 1270130, XrefRangeEnd = 1270132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr_get_allAssets_Public_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000366C File Offset: 0x0000186C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002104 File Offset: 0x00000304
		public AssetBundleRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Protected_Virtual_Object_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_get_Object_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_allAssets_Public_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
