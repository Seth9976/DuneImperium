using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022F RID: 559
	public class IVisualElementScheduler : Il2CppObjectBase
	{
		// Token: 0x06002972 RID: 10610 RVA: 0x000B54D4 File Offset: 0x000B36D4
		// Note: this type is marked as 'beforefieldinit'.
		static IVisualElementScheduler()
		{
			Il2CppClassPointerStore<IVisualElementScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IVisualElementScheduler");
			IVisualElementScheduler.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Action_1_TimerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementScheduler>.NativeClassPtr, 100669526);
			IVisualElementScheduler.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementScheduler>.NativeClassPtr, 100669527);
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000B5524 File Offset: 0x000B3724
		[CallerCount(0)]
		public unsafe virtual IVisualElementScheduledItem Execute(Action<TimerState> timerUpdateEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timerUpdateEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementScheduler.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Action_1_TimerState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr3) : null;
			}
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000B5580 File Offset: 0x000B3780
		[CallerCount(0)]
		public unsafe virtual IVisualElementScheduledItem Execute(Action updateEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updateEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementScheduler.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr3) : null;
			}
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00010B18 File Offset: 0x0000ED18
		public IVisualElementScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Action_1_TimerState_0;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Action_0;
	}
}
