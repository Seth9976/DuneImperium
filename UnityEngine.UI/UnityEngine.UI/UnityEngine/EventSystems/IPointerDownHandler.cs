using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000056 RID: 86
	public class IPointerDownHandler : Il2CppObjectBase
	{
		// Token: 0x060009A9 RID: 2473 RVA: 0x000055DD File Offset: 0x000037DD
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerDownHandler()
		{
			Il2CppClassPointerStore<IPointerDownHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerDownHandler");
			IPointerDownHandler.NativeMethodInfoPtr_OnPointerDown_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerDownHandler>.NativeClassPtr, 100664896);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0002CD54 File Offset: 0x0002AF54
		[CallerCount(0)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerDownHandler.NativeMethodInfoPtr_OnPointerDown_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0000560C File Offset: 0x0000380C
		public IPointerDownHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
