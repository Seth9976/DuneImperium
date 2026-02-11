using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005E RID: 94
	public class IScrollHandler : Il2CppObjectBase
	{
		// Token: 0x060009C1 RID: 2497 RVA: 0x0000579D File Offset: 0x0000399D
		// Note: this type is marked as 'beforefieldinit'.
		static IScrollHandler()
		{
			Il2CppClassPointerStore<IScrollHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IScrollHandler");
			IScrollHandler.NativeMethodInfoPtr_OnScroll_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScrollHandler>.NativeClassPtr, 100664904);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0002CFD4 File Offset: 0x0002B1D4
		[CallerCount(0)]
		public unsafe virtual void OnScroll(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScrollHandler.NativeMethodInfoPtr_OnScroll_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000057CC File Offset: 0x000039CC
		public IScrollHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
