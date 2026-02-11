using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000057 RID: 87
	public class IPointerUpHandler : Il2CppObjectBase
	{
		// Token: 0x060009AC RID: 2476 RVA: 0x00005615 File Offset: 0x00003815
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerUpHandler()
		{
			Il2CppClassPointerStore<IPointerUpHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerUpHandler");
			IPointerUpHandler.NativeMethodInfoPtr_OnPointerUp_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerUpHandler>.NativeClassPtr, 100664897);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0002CDA4 File Offset: 0x0002AFA4
		[CallerCount(0)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerUpHandler.NativeMethodInfoPtr_OnPointerUp_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00005644 File Offset: 0x00003844
		public IPointerUpHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
