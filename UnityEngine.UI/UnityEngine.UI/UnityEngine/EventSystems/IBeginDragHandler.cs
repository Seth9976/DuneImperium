using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000059 RID: 89
	public class IBeginDragHandler : Il2CppObjectBase
	{
		// Token: 0x060009B2 RID: 2482 RVA: 0x00005685 File Offset: 0x00003885
		// Note: this type is marked as 'beforefieldinit'.
		static IBeginDragHandler()
		{
			Il2CppClassPointerStore<IBeginDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IBeginDragHandler");
			IBeginDragHandler.NativeMethodInfoPtr_OnBeginDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBeginDragHandler>.NativeClassPtr, 100664899);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0002CE44 File Offset: 0x0002B044
		[CallerCount(0)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBeginDragHandler.NativeMethodInfoPtr_OnBeginDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000056B4 File Offset: 0x000038B4
		public IBeginDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
