using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000060 RID: 96
	public class ISelectHandler : Il2CppObjectBase
	{
		// Token: 0x060009C7 RID: 2503 RVA: 0x0000580D File Offset: 0x00003A0D
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectHandler()
		{
			Il2CppClassPointerStore<ISelectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ISelectHandler");
			ISelectHandler.NativeMethodInfoPtr_OnSelect_Public_Abstract_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectHandler>.NativeClassPtr, 100664906);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0002D074 File Offset: 0x0002B274
		[CallerCount(0)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectHandler.NativeMethodInfoPtr_OnSelect_Public_Abstract_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0000583C File Offset: 0x00003A3C
		public ISelectHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Abstract_Virtual_New_Void_BaseEventData_0;
	}
}
