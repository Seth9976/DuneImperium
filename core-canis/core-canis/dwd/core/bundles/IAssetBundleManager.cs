using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.bundles
{
	// Token: 0x02000201 RID: 513
	public class IAssetBundleManager : Il2CppObjectBase
	{
		// Token: 0x06001C7A RID: 7290 RVA: 0x000845A0 File Offset: 0x000827A0
		// Note: this type is marked as 'beforefieldinit'.
		static IAssetBundleManager()
		{
			Il2CppClassPointerStore<IAssetBundleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "IAssetBundleManager");
			IAssetBundleManager.NativeMethodInfoPtr_GetLocales_Public_Abstract_Virtual_New_IList_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleManager>.NativeClassPtr, 100667828);
			IAssetBundleManager.NativeMethodInfoPtr_AssetsInBundle_Public_Abstract_Virtual_New_IList_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleManager>.NativeClassPtr, 100667829);
			IAssetBundleManager.NativeMethodInfoPtr_DoesBundleExitsInManifest_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleManager>.NativeClassPtr, 100667830);
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00084604 File Offset: 0x00082804
		[CallerCount(0)]
		public unsafe virtual IList<string> GetLocales(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleManager.NativeMethodInfoPtr_GetLocales_Public_Abstract_Virtual_New_IList_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00084660 File Offset: 0x00082860
		[CallerCount(0)]
		public unsafe virtual IList<string> AssetsInBundle(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleManager.NativeMethodInfoPtr_AssetsInBundle_Public_Abstract_Virtual_New_IList_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x000846BC File Offset: 0x000828BC
		[CallerCount(0)]
		public unsafe virtual bool DoesBundleExitsInManifest(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleManager.NativeMethodInfoPtr_DoesBundleExitsInManifest_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		public IAssetBundleManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_GetLocales_Public_Abstract_Virtual_New_IList_1_String_String_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_AssetsInBundle_Public_Abstract_Virtual_New_IList_1_String_String_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_DoesBundleExitsInManifest_Public_Abstract_Virtual_New_Boolean_String_0;
	}
}
