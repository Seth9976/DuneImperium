using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000105 RID: 261
	public class INavigationEvent : Il2CppObjectBase
	{
		// Token: 0x0600147F RID: 5247 RVA: 0x000657E8 File Offset: 0x000639E8
		// Note: this type is marked as 'beforefieldinit'.
		static INavigationEvent()
		{
			Il2CppClassPointerStore<INavigationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "INavigationEvent");
			INavigationEvent.NativeMethodInfoPtr_get_shiftKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INavigationEvent>.NativeClassPtr, 100666283);
			INavigationEvent.NativeMethodInfoPtr_get_altKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INavigationEvent>.NativeClassPtr, 100666284);
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x00065838 File Offset: 0x00063A38
		public unsafe virtual bool shiftKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INavigationEvent.NativeMethodInfoPtr_get_shiftKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x00065880 File Offset: 0x00063A80
		public unsafe virtual bool altKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INavigationEvent.NativeMethodInfoPtr_get_altKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00009BEA File Offset: 0x00007DEA
		public INavigationEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_get_shiftKey_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_get_altKey_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
