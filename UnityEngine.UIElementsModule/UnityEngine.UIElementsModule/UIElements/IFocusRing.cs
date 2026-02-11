using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200012F RID: 303
	public class IFocusRing : Il2CppObjectBase
	{
		// Token: 0x06001673 RID: 5747 RVA: 0x0006C854 File Offset: 0x0006AA54
		// Note: this type is marked as 'beforefieldinit'.
		static IFocusRing()
		{
			Il2CppClassPointerStore<IFocusRing>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IFocusRing");
			IFocusRing.NativeMethodInfoPtr_GetFocusChangeDirection_Public_Abstract_Virtual_New_FocusChangeDirection_Focusable_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFocusRing>.NativeClassPtr, 100666654);
			IFocusRing.NativeMethodInfoPtr_GetNextFocusable_Public_Abstract_Virtual_New_Focusable_Focusable_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFocusRing>.NativeClassPtr, 100666655);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0006C8A4 File Offset: 0x0006AAA4
		[CallerCount(0)]
		public unsafe virtual FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFocusRing.NativeMethodInfoPtr_GetFocusChangeDirection_Public_Abstract_Virtual_New_FocusChangeDirection_Focusable_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0006C914 File Offset: 0x0006AB14
		[CallerCount(0)]
		public unsafe virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFocusRing.NativeMethodInfoPtr_GetNextFocusable_Public_Abstract_Virtual_New_Focusable_Focusable_FocusChangeDirection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0000A66D File Offset: 0x0000886D
		public IFocusRing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusChangeDirection_Public_Abstract_Virtual_New_FocusChangeDirection_Focusable_EventBase_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_GetNextFocusable_Public_Abstract_Virtual_New_Focusable_Focusable_FocusChangeDirection_0;
	}
}
