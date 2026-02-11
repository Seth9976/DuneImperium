using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000063 RID: 99
	public class ISubmitHandler : Il2CppObjectBase
	{
		// Token: 0x060009D0 RID: 2512 RVA: 0x000058B5 File Offset: 0x00003AB5
		// Note: this type is marked as 'beforefieldinit'.
		static ISubmitHandler()
		{
			Il2CppClassPointerStore<ISubmitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ISubmitHandler");
			ISubmitHandler.NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISubmitHandler>.NativeClassPtr, 100664909);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0002D164 File Offset: 0x0002B364
		[CallerCount(0)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISubmitHandler.NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000058E4 File Offset: 0x00003AE4
		public ISubmitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
