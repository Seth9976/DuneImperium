using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000141 RID: 321
	public class IComponent : Il2CppObjectBase
	{
		// Token: 0x060012F7 RID: 4855 RVA: 0x00008A19 File Offset: 0x00006C19
		// Note: this type is marked as 'beforefieldinit'.
		static IComponent()
		{
			Il2CppClassPointerStore<IComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "IComponent");
			IComponent.NativeMethodInfoPtr_get_Site_Public_Abstract_Virtual_New_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponent>.NativeClassPtr, 100666059);
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00065410 File Offset: 0x00063610
		public unsafe virtual ISite Site
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComponent.NativeMethodInfoPtr_get_Site_Public_Abstract_Virtual_New_get_ISite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00008A48 File Offset: 0x00006C48
		public IComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Abstract_Virtual_New_get_ISite_0;
	}
}
