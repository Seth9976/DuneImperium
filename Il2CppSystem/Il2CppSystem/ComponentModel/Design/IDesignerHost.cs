using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel.Design
{
	// Token: 0x0200014F RID: 335
	public class IDesignerHost : Il2CppObjectBase
	{
		// Token: 0x06001474 RID: 5236 RVA: 0x0006B718 File Offset: 0x00069918
		// Note: this type is marked as 'beforefieldinit'.
		static IDesignerHost()
		{
			Il2CppClassPointerStore<IDesignerHost>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design", "IDesignerHost");
			IDesignerHost.NativeMethodInfoPtr_get_RootComponent_Public_Abstract_Virtual_New_get_IComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDesignerHost>.NativeClassPtr, 100666349);
			IDesignerHost.NativeMethodInfoPtr_GetDesigner_Public_Abstract_Virtual_New_IDesigner_IComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDesignerHost>.NativeClassPtr, 100666350);
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0006B768 File Offset: 0x00069968
		public unsafe virtual IComponent RootComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDesignerHost.NativeMethodInfoPtr_get_RootComponent_Public_Abstract_Virtual_New_get_IComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0006B7B4 File Offset: 0x000699B4
		[CallerCount(0)]
		public unsafe virtual IDesigner GetDesigner(IComponent component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDesignerHost.NativeMethodInfoPtr_GetDesigner_Public_Abstract_Virtual_New_IDesigner_IComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDesigner>(intPtr3) : null;
			}
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00009184 File Offset: 0x00007384
		public IDesignerHost(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_get_RootComponent_Public_Abstract_Virtual_New_get_IComponent_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_GetDesigner_Public_Abstract_Virtual_New_IDesigner_IComponent_0;
	}
}
