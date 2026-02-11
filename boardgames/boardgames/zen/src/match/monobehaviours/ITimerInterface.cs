using System;
using Canis.messages.timer;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace zen.src.match.monobehaviours
{
	// Token: 0x0200006C RID: 108
	public class ITimerInterface : Il2CppObjectBase
	{
		// Token: 0x060005D4 RID: 1492 RVA: 0x00022EC8 File Offset: 0x000210C8
		// Note: this type is marked as 'beforefieldinit'.
		static ITimerInterface()
		{
			Il2CppClassPointerStore<ITimerInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "ITimerInterface");
			ITimerInterface.NativeMethodInfoPtr_GetTimerForAccount_Public_Abstract_Virtual_New_DataComposition_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimerInterface>.NativeClassPtr, 100664226);
			ITimerInterface.NativeMethodInfoPtr_DisplayTimer_Public_Abstract_Virtual_New_IEnumerator_DisplayTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimerInterface>.NativeClassPtr, 100664227);
			ITimerInterface.NativeMethodInfoPtr_HideTimer_Public_Abstract_Virtual_New_Void_TimerID_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITimerInterface>.NativeClassPtr, 100664228);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00022F2C File Offset: 0x0002112C
		[CallerCount(0)]
		public unsafe virtual DataComposition GetTimerForAccount(AccountID accountId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimerInterface.NativeMethodInfoPtr_GetTimerForAccount_Public_Abstract_Virtual_New_DataComposition_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00022F88 File Offset: 0x00021188
		[CallerCount(0)]
		public unsafe virtual IEnumerator DisplayTimer(DisplayTimer displayTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayTimer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimerInterface.NativeMethodInfoPtr_DisplayTimer_Public_Abstract_Virtual_New_IEnumerator_DisplayTimer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00022FE4 File Offset: 0x000211E4
		[CallerCount(0)]
		public unsafe virtual void HideTimer(TimerID timerID, AccountID accountId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timerID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITimerInterface.NativeMethodInfoPtr_HideTimer_Public_Abstract_Virtual_New_Void_TimerID_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00004AB5 File Offset: 0x00002CB5
		public ITimerInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_GetTimerForAccount_Public_Abstract_Virtual_New_DataComposition_AccountID_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_DisplayTimer_Public_Abstract_Virtual_New_IEnumerator_DisplayTimer_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_HideTimer_Public_Abstract_Virtual_New_Void_TimerID_AccountID_0;
	}
}
