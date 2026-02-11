using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace InControl
{
	// Token: 0x0200000E RID: 14
	public class BindingSourceListener : Il2CppObjectBase
	{
		// Token: 0x06000079 RID: 121 RVA: 0x000090E0 File Offset: 0x000072E0
		// Note: this type is marked as 'beforefieldinit'.
		static BindingSourceListener()
		{
			Il2CppClassPointerStore<BindingSourceListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "BindingSourceListener");
			BindingSourceListener.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSourceListener>.NativeClassPtr, 100663365);
			BindingSourceListener.NativeMethodInfoPtr_Listen_Public_Abstract_Virtual_New_BindingSource_BindingListenOptions_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingSourceListener>.NativeClassPtr, 100663366);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009130 File Offset: 0x00007330
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BindingSourceListener.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000916C File Offset: 0x0000736C
		[CallerCount(0)]
		public unsafe virtual BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listenOptions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BindingSourceListener.NativeMethodInfoPtr_Listen_Public_Abstract_Virtual_New_BindingSource_BindingListenOptions_InputDevice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingSource>(intPtr3) : null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000022D5 File Offset: 0x000004D5
		public BindingSourceListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_Listen_Public_Abstract_Virtual_New_BindingSource_BindingListenOptions_InputDevice_0;
	}
}
