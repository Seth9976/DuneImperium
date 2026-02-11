using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000E5 RID: 229
	public class IHasTurnTimers : Il2CppObjectBase
	{
		// Token: 0x06000A52 RID: 2642 RVA: 0x000454D0 File Offset: 0x000436D0
		// Note: this type is marked as 'beforefieldinit'.
		static IHasTurnTimers()
		{
			Il2CppClassPointerStore<IHasTurnTimers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IHasTurnTimers");
			IHasTurnTimers.NativeMethodInfoPtr_InitializeTurnTimer_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTurnTimers>.NativeClassPtr, 100665481);
			IHasTurnTimers.NativeMethodInfoPtr_ResetTurnTimer_Public_Abstract_Virtual_New_IEnumerable_1_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTurnTimers>.NativeClassPtr, 100665482);
			IHasTurnTimers.NativeMethodInfoPtr_UpdateTurnTimer_Public_Abstract_Virtual_New_IEnumerable_1_Action_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTurnTimers>.NativeClassPtr, 100665483);
			IHasTurnTimers.NativeMethodInfoPtr_PadOpponentTime_Public_Abstract_Virtual_New_IEnumerable_1_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTurnTimers>.NativeClassPtr, 100665484);
			IHasTurnTimers.NativeMethodInfoPtr_get_DefaultPlayerTurnPadding_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTurnTimers>.NativeClassPtr, 100665485);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0004555C File Offset: 0x0004375C
		[CallerCount(0)]
		public unsafe virtual void InitializeTurnTimer(int timerLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timerLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasTurnTimers.NativeMethodInfoPtr_InitializeTurnTimer_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000455A8 File Offset: 0x000437A8
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Canis.actions.Action> ResetTurnTimer(int timerLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timerLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasTurnTimers.NativeMethodInfoPtr_ResetTurnTimer_Public_Abstract_Virtual_New_IEnumerable_1_Action_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00045600 File Offset: 0x00043800
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Canis.actions.Action> UpdateTurnTimer(DateTime startTime, DateTime endTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasTurnTimers.NativeMethodInfoPtr_UpdateTurnTimer_Public_Abstract_Virtual_New_IEnumerable_1_Action_DateTime_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00045668 File Offset: 0x00043868
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Canis.actions.Action> PadOpponentTime(int seconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasTurnTimers.NativeMethodInfoPtr_PadOpponentTime_Public_Abstract_Virtual_New_IEnumerable_1_Action_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x000456C0 File Offset: 0x000438C0
		public unsafe virtual int DefaultPlayerTurnPadding
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasTurnTimers.NativeMethodInfoPtr_get_DefaultPlayerTurnPadding_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00005D06 File Offset: 0x00003F06
		public IHasTurnTimers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_InitializeTurnTimer_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_ResetTurnTimer_Public_Abstract_Virtual_New_IEnumerable_1_Action_Int32_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTurnTimer_Public_Abstract_Virtual_New_IEnumerable_1_Action_DateTime_DateTime_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_PadOpponentTime_Public_Abstract_Virtual_New_IEnumerable_1_Action_Int32_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPlayerTurnPadding_Public_Virtual_New_get_Int32_0;
	}
}
