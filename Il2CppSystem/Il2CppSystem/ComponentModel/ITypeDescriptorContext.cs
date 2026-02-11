using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000114 RID: 276
	public class ITypeDescriptorContext : Il2CppObjectBase
	{
		// Token: 0x06001124 RID: 4388 RVA: 0x000080F7 File Offset: 0x000062F7
		// Note: this type is marked as 'beforefieldinit'.
		static ITypeDescriptorContext()
		{
			Il2CppClassPointerStore<ITypeDescriptorContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ITypeDescriptorContext");
			ITypeDescriptorContext.NativeMethodInfoPtr_get_Container_Public_Abstract_Virtual_New_get_IContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITypeDescriptorContext>.NativeClassPtr, 100665791);
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0005D6F8 File Offset: 0x0005B8F8
		public unsafe virtual IContainer Container
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITypeDescriptorContext.NativeMethodInfoPtr_get_Container_Public_Abstract_Virtual_New_get_IContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IContainer>(intPtr3) : null;
			}
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00008126 File Offset: 0x00006326
		public ITypeDescriptorContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_get_Container_Public_Abstract_Virtual_New_get_IContainer_0;
	}
}
