using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000054 RID: 84
	public class IPointerEnterHandler : Il2CppObjectBase
	{
		// Token: 0x060009A3 RID: 2467 RVA: 0x0000556D File Offset: 0x0000376D
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerEnterHandler()
		{
			Il2CppClassPointerStore<IPointerEnterHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerEnterHandler");
			IPointerEnterHandler.NativeMethodInfoPtr_OnPointerEnter_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEnterHandler>.NativeClassPtr, 100664894);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0002CCB4 File Offset: 0x0002AEB4
		[CallerCount(0)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEnterHandler.NativeMethodInfoPtr_OnPointerEnter_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0000559C File Offset: 0x0000379C
		public IPointerEnterHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
