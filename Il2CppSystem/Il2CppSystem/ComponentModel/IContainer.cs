using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000ED RID: 237
	public class IContainer : Il2CppObjectBase
	{
		// Token: 0x06000F84 RID: 3972 RVA: 0x0005672C File Offset: 0x0005492C
		// Note: this type is marked as 'beforefieldinit'.
		static IContainer()
		{
			Il2CppClassPointerStore<IContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "IContainer");
			IContainer.NativeMethodInfoPtr_get_Components_Public_Abstract_Virtual_New_get_ComponentCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainer>.NativeClassPtr, 100665535);
			IContainer.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_IComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainer>.NativeClassPtr, 100665536);
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x0005677C File Offset: 0x0005497C
		public unsafe virtual ComponentCollection Components
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContainer.NativeMethodInfoPtr_get_Components_Public_Abstract_Virtual_New_get_ComponentCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComponentCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000567C8 File Offset: 0x000549C8
		[CallerCount(0)]
		public unsafe virtual void Remove(IComponent component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContainer.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_IComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000079CE File Offset: 0x00005BCE
		public IContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_get_Components_Public_Abstract_Virtual_New_get_ComponentCollection_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_IComponent_0;
	}
}
