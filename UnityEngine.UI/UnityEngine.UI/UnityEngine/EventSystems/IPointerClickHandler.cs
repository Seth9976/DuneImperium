using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000058 RID: 88
	public class IPointerClickHandler : Il2CppObjectBase
	{
		// Token: 0x060009AF RID: 2479 RVA: 0x0000564D File Offset: 0x0000384D
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerClickHandler()
		{
			Il2CppClassPointerStore<IPointerClickHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerClickHandler");
			IPointerClickHandler.NativeMethodInfoPtr_OnPointerClick_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerClickHandler>.NativeClassPtr, 100664898);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0002CDF4 File Offset: 0x0002AFF4
		[CallerCount(0)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerClickHandler.NativeMethodInfoPtr_OnPointerClick_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0000567C File Offset: 0x0000387C
		public IPointerClickHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
