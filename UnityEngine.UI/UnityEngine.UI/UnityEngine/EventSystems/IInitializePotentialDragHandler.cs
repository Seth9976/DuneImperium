using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005A RID: 90
	public class IInitializePotentialDragHandler : Il2CppObjectBase
	{
		// Token: 0x060009B5 RID: 2485 RVA: 0x000056BD File Offset: 0x000038BD
		// Note: this type is marked as 'beforefieldinit'.
		static IInitializePotentialDragHandler()
		{
			Il2CppClassPointerStore<IInitializePotentialDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IInitializePotentialDragHandler");
			IInitializePotentialDragHandler.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInitializePotentialDragHandler>.NativeClassPtr, 100664900);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0002CE94 File Offset: 0x0002B094
		[CallerCount(0)]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInitializePotentialDragHandler.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000056EC File Offset: 0x000038EC
		public IInitializePotentialDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
