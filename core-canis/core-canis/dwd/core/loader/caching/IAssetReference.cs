using System;
using dwd.core.loader.loaders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.loader.caching
{
	// Token: 0x02000188 RID: 392
	public class IAssetReference : Il2CppObjectBase
	{
		// Token: 0x06001643 RID: 5699 RVA: 0x0006D67C File Offset: 0x0006B87C
		// Note: this type is marked as 'beforefieldinit'.
		static IAssetReference()
		{
			Il2CppClassPointerStore<IAssetReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "IAssetReference");
			IAssetReference.NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetReference>.NativeClassPtr, 100666707);
			IAssetReference.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetReference>.NativeClassPtr, 100666708);
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x0006D6CC File Offset: 0x0006B8CC
		public unsafe virtual Object Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetReference.NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0006D718 File Offset: 0x0006B918
		[CallerCount(0)]
		public unsafe virtual IEnumerator Load(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetReference.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_IEnumerator_AssetName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00009B94 File Offset: 0x00007D94
		public IAssetReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_IEnumerator_AssetName_0;
	}
}
