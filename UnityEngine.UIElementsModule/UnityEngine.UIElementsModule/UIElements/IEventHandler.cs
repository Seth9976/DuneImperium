using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DE RID: 222
	public class IEventHandler : Il2CppObjectBase
	{
		// Token: 0x06001310 RID: 4880 RVA: 0x0005FC3C File Offset: 0x0005DE3C
		// Note: this type is marked as 'beforefieldinit'.
		static IEventHandler()
		{
			Il2CppClassPointerStore<IEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IEventHandler");
			IEventHandler.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventHandler>.NativeClassPtr, 100665983);
			IEventHandler.NativeMethodInfoPtr_HandleEvent_Public_Abstract_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventHandler>.NativeClassPtr, 100665984);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0005FC8C File Offset: 0x0005DE8C
		[CallerCount(0)]
		public unsafe virtual void SendEvent(EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventHandler.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0005FCDC File Offset: 0x0005DEDC
		[CallerCount(0)]
		public unsafe virtual void HandleEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventHandler.NativeMethodInfoPtr_HandleEvent_Public_Abstract_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00009688 File Offset: 0x00007888
		public IEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_HandleEvent_Public_Abstract_Virtual_New_Void_EventBase_0;
	}
}
