using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000048 RID: 72
	public class IBindable : Il2CppObjectBase
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x000375AC File Offset: 0x000357AC
		// Note: this type is marked as 'beforefieldinit'.
		static IBindable()
		{
			Il2CppClassPointerStore<IBindable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IBindable");
			IBindable.NativeMethodInfoPtr_get_binding_Public_Abstract_Virtual_New_get_IBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindable>.NativeClassPtr, 100664287);
			IBindable.NativeMethodInfoPtr_set_bindingPath_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindable>.NativeClassPtr, 100664288);
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x000375FC File Offset: 0x000357FC
		public unsafe virtual IBinding binding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindable.NativeMethodInfoPtr_get_binding_Public_Abstract_Virtual_New_get_IBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBinding>(intPtr3) : null;
			}
		}

		// Token: 0x17000200 RID: 512
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00037648 File Offset: 0x00035848
		public unsafe virtual string bindingPath
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindable.NativeMethodInfoPtr_set_bindingPath_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000047DD File Offset: 0x000029DD
		public IBindable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_get_binding_Public_Abstract_Virtual_New_get_IBinding_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_set_bindingPath_Public_Abstract_Virtual_New_set_Void_String_0;
	}
}
