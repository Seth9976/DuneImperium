using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000064 RID: 100
	public class ICancelHandler : Il2CppObjectBase
	{
		// Token: 0x060009D3 RID: 2515 RVA: 0x000058ED File Offset: 0x00003AED
		// Note: this type is marked as 'beforefieldinit'.
		static ICancelHandler()
		{
			Il2CppClassPointerStore<ICancelHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ICancelHandler");
			ICancelHandler.NativeMethodInfoPtr_OnCancel_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICancelHandler>.NativeClassPtr, 100664910);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0002D1B4 File Offset: 0x0002B3B4
		[CallerCount(0)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICancelHandler.NativeMethodInfoPtr_OnCancel_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0000591C File Offset: 0x00003B1C
		public ICancelHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
