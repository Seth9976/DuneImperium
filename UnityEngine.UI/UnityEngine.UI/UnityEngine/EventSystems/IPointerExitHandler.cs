using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000055 RID: 85
	public class IPointerExitHandler : Il2CppObjectBase
	{
		// Token: 0x060009A6 RID: 2470 RVA: 0x000055A5 File Offset: 0x000037A5
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerExitHandler()
		{
			Il2CppClassPointerStore<IPointerExitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerExitHandler");
			IPointerExitHandler.NativeMethodInfoPtr_OnPointerExit_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerExitHandler>.NativeClassPtr, 100664895);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0002CD04 File Offset: 0x0002AF04
		[CallerCount(0)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerExitHandler.NativeMethodInfoPtr_OnPointerExit_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000055D4 File Offset: 0x000037D4
		public IPointerExitHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
