using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x0200002E RID: 46
	public class IAssetBundleResource : Il2CppObjectBase
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00002E7D File Offset: 0x0000107D
		// Note: this type is marked as 'beforefieldinit'.
		static IAssetBundleResource()
		{
			Il2CppClassPointerStore<IAssetBundleResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "IAssetBundleResource");
			IAssetBundleResource.NativeMethodInfoPtr_GetAssetBundle_Public_Abstract_Virtual_New_AssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetBundleResource>.NativeClassPtr, 100663675);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000DA6C File Offset: 0x0000BC6C
		[CallerCount(0)]
		public unsafe virtual AssetBundle GetAssetBundle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetBundleResource.NativeMethodInfoPtr_GetAssetBundle_Public_Abstract_Virtual_New_AssetBundle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr3) : null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002EAC File Offset: 0x000010AC
		public IAssetBundleResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetBundle_Public_Abstract_Virtual_New_AssetBundle_0;
	}
}
