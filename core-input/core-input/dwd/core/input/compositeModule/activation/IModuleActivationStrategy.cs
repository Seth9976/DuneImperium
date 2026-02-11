using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.input.compositeModule.activation
{
	// Token: 0x020000A1 RID: 161
	public class IModuleActivationStrategy : Il2CppObjectBase
	{
		// Token: 0x06000757 RID: 1879 RVA: 0x0001EE1C File Offset: 0x0001D01C
		// Note: this type is marked as 'beforefieldinit'.
		static IModuleActivationStrategy()
		{
			Il2CppClassPointerStore<IModuleActivationStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.activation", "IModuleActivationStrategy");
			IModuleActivationStrategy.NativeMethodInfoPtr_ShouldModuleActivate_Public_Abstract_Virtual_New_Boolean_InputDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModuleActivationStrategy>.NativeClassPtr, 100664210);
			IModuleActivationStrategy.NativeMethodInfoPtr_Activated_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModuleActivationStrategy>.NativeClassPtr, 100664211);
			IModuleActivationStrategy.NativeMethodInfoPtr_Deactivated_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModuleActivationStrategy>.NativeClassPtr, 100664212);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0001EE80 File Offset: 0x0001D080
		[CallerCount(0)]
		public unsafe virtual bool ShouldModuleActivate(InputDetector inputDetector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IModuleActivationStrategy.NativeMethodInfoPtr_ShouldModuleActivate_Public_Abstract_Virtual_New_Boolean_InputDetector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0001EED8 File Offset: 0x0001D0D8
		[CallerCount(0)]
		public unsafe virtual void Activated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IModuleActivationStrategy.NativeMethodInfoPtr_Activated_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0001EF14 File Offset: 0x0001D114
		[CallerCount(0)]
		public unsafe virtual void Deactivated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IModuleActivationStrategy.NativeMethodInfoPtr_Deactivated_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00005D9A File Offset: 0x00003F9A
		public IModuleActivationStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_ShouldModuleActivate_Public_Abstract_Virtual_New_Boolean_InputDetector_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_Activated_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_Deactivated_Public_Abstract_Virtual_New_Void_0;
	}
}
