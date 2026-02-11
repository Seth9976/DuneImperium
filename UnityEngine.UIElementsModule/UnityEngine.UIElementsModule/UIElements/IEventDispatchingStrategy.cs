using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E6 RID: 230
	public class IEventDispatchingStrategy : Il2CppObjectBase
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x00060F68 File Offset: 0x0005F168
		// Note: this type is marked as 'beforefieldinit'.
		static IEventDispatchingStrategy()
		{
			Il2CppClassPointerStore<IEventDispatchingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IEventDispatchingStrategy");
			IEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Abstract_Virtual_New_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatchingStrategy>.NativeClassPtr, 100666042);
			IEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Abstract_Virtual_New_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatchingStrategy>.NativeClassPtr, 100666043);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00060FB8 File Offset: 0x0005F1B8
		[CallerCount(0)]
		public unsafe virtual bool CanDispatchEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventDispatchingStrategy.NativeMethodInfoPtr_CanDispatchEvent_Public_Abstract_Virtual_New_Boolean_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00061010 File Offset: 0x0005F210
		[CallerCount(0)]
		public unsafe virtual void DispatchEvent(EventBase evt, IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventDispatchingStrategy.NativeMethodInfoPtr_DispatchEvent_Public_Abstract_Virtual_New_Void_EventBase_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0000979D File Offset: 0x0000799D
		public IEventDispatchingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_CanDispatchEvent_Public_Abstract_Virtual_New_Boolean_EventBase_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Abstract_Virtual_New_Void_EventBase_IPanel_0;
	}
}
