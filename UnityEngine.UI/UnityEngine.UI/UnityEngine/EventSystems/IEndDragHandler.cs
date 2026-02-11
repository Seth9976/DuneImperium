using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005C RID: 92
	public class IEndDragHandler : Il2CppObjectBase
	{
		// Token: 0x060009BB RID: 2491 RVA: 0x0000572D File Offset: 0x0000392D
		// Note: this type is marked as 'beforefieldinit'.
		static IEndDragHandler()
		{
			Il2CppClassPointerStore<IEndDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IEndDragHandler");
			IEndDragHandler.NativeMethodInfoPtr_OnEndDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEndDragHandler>.NativeClassPtr, 100664902);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0002CF34 File Offset: 0x0002B134
		[CallerCount(0)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEndDragHandler.NativeMethodInfoPtr_OnEndDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0000575C File Offset: 0x0000395C
		public IEndDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
