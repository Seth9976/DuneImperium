using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005D RID: 93
	public class IDropHandler : Il2CppObjectBase
	{
		// Token: 0x060009BE RID: 2494 RVA: 0x00005765 File Offset: 0x00003965
		// Note: this type is marked as 'beforefieldinit'.
		static IDropHandler()
		{
			Il2CppClassPointerStore<IDropHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IDropHandler");
			IDropHandler.NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDropHandler>.NativeClassPtr, 100664903);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0002CF84 File Offset: 0x0002B184
		[CallerCount(0)]
		public unsafe virtual void OnDrop(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDropHandler.NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00005794 File Offset: 0x00003994
		public IDropHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
