using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.loader.caching
{
	// Token: 0x02000189 RID: 393
	public class IAssetReference<T> : Il2CppObjectBase where T : global::UnityEngine.Object
	{
		// Token: 0x06001647 RID: 5703 RVA: 0x0006D778 File Offset: 0x0006B978
		// Note: this type is marked as 'beforefieldinit'.
		static IAssetReference()
		{
			Il2CppClassPointerStore<IAssetReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "IAssetReference`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IAssetReference<T>.NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAssetReference<T>>.NativeClassPtr, 100666709);
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x0006D7F0 File Offset: 0x0006B9F0
		public unsafe virtual T Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAssetReference<T>.NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00009B9D File Offset: 0x00007D9D
		public IAssetReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Abstract_Virtual_New_get_T_0;
	}
}
