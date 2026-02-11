using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005F RID: 95
	public class IUpdateSelectedHandler : Il2CppObjectBase
	{
		// Token: 0x060009C4 RID: 2500 RVA: 0x000057D5 File Offset: 0x000039D5
		// Note: this type is marked as 'beforefieldinit'.
		static IUpdateSelectedHandler()
		{
			Il2CppClassPointerStore<IUpdateSelectedHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IUpdateSelectedHandler");
			IUpdateSelectedHandler.NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpdateSelectedHandler>.NativeClassPtr, 100664905);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0002D024 File Offset: 0x0002B224
		[CallerCount(0)]
		public unsafe virtual void OnUpdateSelected(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUpdateSelectedHandler.NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00005804 File Offset: 0x00003A04
		public IUpdateSelectedHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateSelected_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
