using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000053 RID: 83
	public class IPointerMoveHandler : Il2CppObjectBase
	{
		// Token: 0x060009A0 RID: 2464 RVA: 0x00005535 File Offset: 0x00003735
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerMoveHandler()
		{
			Il2CppClassPointerStore<IPointerMoveHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IPointerMoveHandler");
			IPointerMoveHandler.NativeMethodInfoPtr_OnPointerMove_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerMoveHandler>.NativeClassPtr, 100664893);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0002CC64 File Offset: 0x0002AE64
		[CallerCount(0)]
		public unsafe virtual void OnPointerMove(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerMoveHandler.NativeMethodInfoPtr_OnPointerMove_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00005564 File Offset: 0x00003764
		public IPointerMoveHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
