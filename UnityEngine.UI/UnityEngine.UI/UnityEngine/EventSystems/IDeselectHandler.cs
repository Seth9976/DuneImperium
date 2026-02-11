using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000061 RID: 97
	public class IDeselectHandler : Il2CppObjectBase
	{
		// Token: 0x060009CA RID: 2506 RVA: 0x00005845 File Offset: 0x00003A45
		// Note: this type is marked as 'beforefieldinit'.
		static IDeselectHandler()
		{
			Il2CppClassPointerStore<IDeselectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IDeselectHandler");
			IDeselectHandler.NativeMethodInfoPtr_OnDeselect_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeselectHandler>.NativeClassPtr, 100664907);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0002D0C4 File Offset: 0x0002B2C4
		[CallerCount(0)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeselectHandler.NativeMethodInfoPtr_OnDeselect_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00005874 File Offset: 0x00003A74
		public IDeselectHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
