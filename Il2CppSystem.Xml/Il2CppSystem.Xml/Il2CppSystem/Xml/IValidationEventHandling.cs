using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000029 RID: 41
	public class IValidationEventHandling : Il2CppObjectBase
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00020A3C File Offset: 0x0001EC3C
		// Note: this type is marked as 'beforefieldinit'.
		static IValidationEventHandling()
		{
			Il2CppClassPointerStore<IValidationEventHandling>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IValidationEventHandling");
			IValidationEventHandling.NativeMethodInfoPtr_get_EventHandler_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValidationEventHandling>.NativeClassPtr, 100663671);
			IValidationEventHandling.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Exception_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValidationEventHandling>.NativeClassPtr, 100663672);
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00020A8C File Offset: 0x0001EC8C
		public unsafe virtual Object EventHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValidationEventHandling.NativeMethodInfoPtr_get_EventHandler_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		[CallerCount(0)]
		public unsafe virtual void SendEvent(Exception exception, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValidationEventHandling.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Exception_XmlSeverityType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000300E File Offset: 0x0000120E
		public IValidationEventHandling(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_get_EventHandler_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Exception_XmlSeverityType_0;
	}
}
