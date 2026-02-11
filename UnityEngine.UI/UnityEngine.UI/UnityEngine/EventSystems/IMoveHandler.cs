using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000062 RID: 98
	public class IMoveHandler : Il2CppObjectBase
	{
		// Token: 0x060009CD RID: 2509 RVA: 0x0000587D File Offset: 0x00003A7D
		// Note: this type is marked as 'beforefieldinit'.
		static IMoveHandler()
		{
			Il2CppClassPointerStore<IMoveHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "IMoveHandler");
			IMoveHandler.NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMoveHandler>.NativeClassPtr, 100664908);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0002D114 File Offset: 0x0002B314
		[CallerCount(0)]
		public unsafe virtual void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMoveHandler.NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000058AC File Offset: 0x00003AAC
		public IMoveHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Abstract_Virtual_New_Void_AxisEventData_0;
	}
}
