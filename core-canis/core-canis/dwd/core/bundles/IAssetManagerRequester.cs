using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.bundles
{
	// Token: 0x02000202 RID: 514
	public class IAssetManagerRequester : Il2CppObjectBase
	{
		// Token: 0x06001C7F RID: 7295 RVA: 0x00084714 File Offset: 0x00082914
		// Note: this type is marked as 'beforefieldinit'.
		static IAssetManagerRequester()
		{
			Il2CppClassPointerStore<IAssetManagerRequester>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "IAssetManagerRequester");
			IAssetManagerRequester.NativeMethodInfoPtr_RemoveRequest_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetManagerRequester>.NativeClassPtr, 100667831);
			IAssetManagerRequester.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetManagerRequester>.NativeClassPtr, 100667832);
			IAssetManagerRequester.NativeMethodInfoPtr_DoesAssetExistInManifest_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetManagerRequester>.NativeClassPtr, 100667833);
			IAssetManagerRequester.NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetManagerRequester>.NativeClassPtr, 100667834);
			IAssetManagerRequester.NativeMethodInfoPtr_RequestAsset_Public_Abstract_Virtual_New_AssetBundleRequest_String_CleanupHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetManagerRequester>.NativeClassPtr, 100667835);
			IAssetManagerRequester.NativeMethodInfoPtr_RequestManifestBundle_Public_Abstract_Virtual_New_AssetBundleRequest_IAssetBundle_CleanupHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetManagerRequester>.NativeClassPtr, 100667836);
			IAssetManagerRequester.NativeMethodInfoPtr_get_PlatformFolder_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetManagerRequester>.NativeClassPtr, 100667837);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000847C8 File Offset: 0x000829C8
		[CallerCount(0)]
		public unsafe virtual void RemoveRequest(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetManagerRequester.NativeMethodInfoPtr_RemoveRequest_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00084818 File Offset: 0x00082A18
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetManagerRequester.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00084854 File Offset: 0x00082A54
		[CallerCount(0)]
		public unsafe virtual bool DoesAssetExistInManifest(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetManagerRequester.NativeMethodInfoPtr_DoesAssetExistInManifest_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x000848AC File Offset: 0x00082AAC
		[CallerCount(0)]
		public unsafe virtual void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetManagerRequester.NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x000848E8 File Offset: 0x00082AE8
		[CallerCount(0)]
		public unsafe virtual AssetBundleRequest RequestAsset(string name, RefCounted.CleanupHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetManagerRequester.NativeMethodInfoPtr_RequestAsset_Public_Abstract_Virtual_New_AssetBundleRequest_String_CleanupHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00084958 File Offset: 0x00082B58
		[CallerCount(0)]
		public unsafe virtual AssetBundleRequest RequestManifestBundle(IAssetBundle descriptorKey, RefCounted.CleanupHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptorKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetManagerRequester.NativeMethodInfoPtr_RequestManifestBundle_Public_Abstract_Virtual_New_AssetBundleRequest_IAssetBundle_CleanupHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr3) : null;
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x000849C8 File Offset: 0x00082BC8
		public unsafe virtual string PlatformFolder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetManagerRequester.NativeMethodInfoPtr_get_PlatformFolder_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0000C405 File Offset: 0x0000A605
		public IAssetManagerRequester(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRequest_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_DoesAssetExistInManifest_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_RequestAsset_Public_Abstract_Virtual_New_AssetBundleRequest_String_CleanupHandler_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_RequestManifestBundle_Public_Abstract_Virtual_New_AssetBundleRequest_IAssetBundle_CleanupHandler_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformFolder_Public_Abstract_Virtual_New_get_String_0;
	}
}
