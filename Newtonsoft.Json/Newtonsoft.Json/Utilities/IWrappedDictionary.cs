using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004F RID: 79
	public class IWrappedDictionary : Il2CppObjectBase
	{
		// Token: 0x06000767 RID: 1895 RVA: 0x000044F0 File Offset: 0x000026F0
		// Note: this type is marked as 'beforefieldinit'.
		static IWrappedDictionary()
		{
			Il2CppClassPointerStore<IWrappedDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "IWrappedDictionary");
			IWrappedDictionary.NativeMethodInfoPtr_get_UnderlyingDictionary_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWrappedDictionary>.NativeClassPtr, 100664695);
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x000348AC File Offset: 0x00032AAC
		public unsafe virtual Object UnderlyingDictionary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWrappedDictionary.NativeMethodInfoPtr_get_UnderlyingDictionary_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0000451F File Offset: 0x0000271F
		public IWrappedDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingDictionary_Public_Abstract_Virtual_New_get_Object_0;
	}
}
