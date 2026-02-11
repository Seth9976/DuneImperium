using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200005B RID: 91
	public class IDragHandler : Il2CppObjectBase
	{
		// Token: 0x060009B8 RID: 2488 RVA: 0x000056F5 File Offset: 0x000038F5
		// Note: this type is marked as 'beforefieldinit'.
		static IDragHandler()
		{
			Il2CppClassPointerStore<IDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IDragHandler");
			IDragHandler.NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragHandler>.NativeClassPtr, 100664901);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0002CEE4 File Offset: 0x0002B0E4
		[CallerCount(0)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragHandler.NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00005724 File Offset: 0x00003924
		public IDragHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Abstract_Virtual_New_Void_PointerEventData_0;
	}
}
