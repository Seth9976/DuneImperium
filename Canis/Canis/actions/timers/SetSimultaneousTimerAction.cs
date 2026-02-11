using System;
using Canis.entities;
using Canis.messages.timer;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using Networking.selection.messages;

namespace Canis.actions.timers
{
	// Token: 0x02000203 RID: 515
	public class SetSimultaneousTimerAction : Action
	{
		// Token: 0x060015BF RID: 5567 RVA: 0x00070F2C File Offset: 0x0006F12C
		// Note: this type is marked as 'beforefieldinit'.
		static SetSimultaneousTimerAction()
		{
			Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.timers", "SetSimultaneousTimerAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr);
			SetSimultaneousTimerAction.NativeFieldInfoPtr_timerMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "timerMessage");
			SetSimultaneousTimerAction.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "TimerID");
			SetSimultaneousTimerAction.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "buffer");
			SetSimultaneousTimerAction.NativeFieldInfoPtr_cancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "cancellationTokenSource");
			SetSimultaneousTimerAction.NativeFieldInfoPtr_canceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "canceled");
			SetSimultaneousTimerAction.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "startTime");
			SetSimultaneousTimerAction.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "endTime");
			SetSimultaneousTimerAction.NativeMethodInfoPtr__ctor_Public_Void_SetSimultaneousTimer_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668213);
			SetSimultaneousTimerAction.NativeMethodInfoPtr__ctor_Public_Void_SetSimultaneousTimerAction_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668214);
			SetSimultaneousTimerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668215);
			SetSimultaneousTimerAction.NativeMethodInfoPtr_get_AllCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668216);
			SetSimultaneousTimerAction.NativeMethodInfoPtr_ClearTimerForAccount_Public_IEnumerable_1_Action_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668217);
			SetSimultaneousTimerAction.NativeMethodInfoPtr_ClearTimers_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668218);
			SetSimultaneousTimerAction.NativeMethodInfoPtr_CancelAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668219);
			SetSimultaneousTimerAction.NativeMethodInfoPtr_waitForTime_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668220);
			SetSimultaneousTimerAction.NativeMethodInfoPtr__execute_b__9_1_Private_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668221);
			SetSimultaneousTimerAction.NativeMethodInfoPtr__get_AllCanceled_b__11_0_Private_Boolean_KeyValuePair_2_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668222);
			SetSimultaneousTimerAction.NativeMethodInfoPtr__waitForTime_b__15_0_Private_Boolean_KeyValuePair_2_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, 100668223);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000710C4 File Offset: 0x0006F2C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 592281, RefRangeEnd = 592282, XrefRangeStart = 592265, XrefRangeEnd = 592281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetSimultaneousTimerAction(SetSimultaneousTimer message, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.NativeMethodInfoPtr__ctor_Public_Void_SetSimultaneousTimer_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00071124 File Offset: 0x0006F324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 592297, RefRangeEnd = 592298, XrefRangeStart = 592282, XrefRangeEnd = 592297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetSimultaneousTimerAction(SetSimultaneousTimerAction action, int newWaitTime, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newWaitTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.NativeMethodInfoPtr__ctor_Public_Void_SetSimultaneousTimerAction_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00071190 File Offset: 0x0006F390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592298, XrefRangeEnd = 592304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetSimultaneousTimerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x000711DC File Offset: 0x0006F3DC
		public unsafe bool AllCanceled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 592314, RefRangeEnd = 592315, XrefRangeStart = 592304, XrefRangeEnd = 592314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.NativeMethodInfoPtr_get_AllCanceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00071218 File Offset: 0x0006F418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 592322, RefRangeEnd = 592323, XrefRangeStart = 592315, XrefRangeEnd = 592322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> ClearTimerForAccount(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.NativeMethodInfoPtr_ClearTimerForAccount_Public_IEnumerable_1_Action_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00071268 File Offset: 0x0006F468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 592328, RefRangeEnd = 592329, XrefRangeStart = 592323, XrefRangeEnd = 592328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ClearTimers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.NativeMethodInfoPtr_ClearTimers_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000712A8 File Offset: 0x0006F4A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 592349, RefRangeEnd = 592350, XrefRangeStart = 592329, XrefRangeEnd = 592349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.NativeMethodInfoPtr_CancelAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000712DC File Offset: 0x0006F4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592350, XrefRangeEnd = 592360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task waitForTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.NativeMethodInfoPtr_waitForTime_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0007131C File Offset: 0x0006F51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592360, XrefRangeEnd = 592363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _execute_b__9_1(PlayerEntity _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.NativeMethodInfoPtr__execute_b__9_1_Private_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0007136C File Offset: 0x0006F56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592363, XrefRangeEnd = 592368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_AllCanceled_b__11_0(KeyValuePair<AccountID, SelectionMessage> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.NativeMethodInfoPtr__get_AllCanceled_b__11_0_Private_Boolean_KeyValuePair_2_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x000713C0 File Offset: 0x0006F5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592368, XrefRangeEnd = 592372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _waitForTime_b__15_0(KeyValuePair<AccountID, SelectionMessage> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.NativeMethodInfoPtr__waitForTime_b__15_0_Private_Boolean_KeyValuePair_2_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0000A82F File Offset: 0x00008A2F
		public SetSimultaneousTimerAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00071414 File Offset: 0x0006F614
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x0000A838 File Offset: 0x00008A38
		public unsafe SetSimultaneousTimer timerMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_timerMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetSimultaneousTimer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_timerMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x00071444 File Offset: 0x0006F644
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x0000A857 File Offset: 0x00008A57
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x00071474 File Offset: 0x0006F674
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x0000A876 File Offset: 0x00008A76
		public unsafe float buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_buffer)) = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x0007149C File Offset: 0x0006F69C
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x0000A891 File Offset: 0x00008A91
		public unsafe CancellationTokenSource cancellationTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_cancellationTokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_cancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x000714CC File Offset: 0x0006F6CC
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x0000A8B0 File Offset: 0x00008AB0
		public unsafe List<AccountID> canceled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_canceled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_canceled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x000714FC File Offset: 0x0006F6FC
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0000A8CF File Offset: 0x00008ACF
		public unsafe DateTime startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00071524 File Offset: 0x0006F724
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0000A8EA File Offset: 0x00008AEA
		public unsafe DateTime endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_endTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction.NativeFieldInfoPtr_endTime)) = value;
			}
		}

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeFieldInfoPtr_timerMessage;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeFieldInfoPtr_cancellationTokenSource;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeFieldInfoPtr_canceled;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SetSimultaneousTimer_Match_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SetSimultaneousTimerAction_Int32_Match_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_get_AllCanceled_Public_get_Boolean_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_ClearTimerForAccount_Public_IEnumerable_1_Action_AccountID_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_ClearTimers_Public_IEnumerator_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_CancelAll_Public_Void_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_waitForTime_Private_Task_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__9_1_Private_Boolean_PlayerEntity_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr__get_AllCanceled_b__11_0_Private_Boolean_KeyValuePair_2_AccountID_SelectionMessage_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr__waitForTime_b__15_0_Private_Boolean_KeyValuePair_2_AccountID_SelectionMessage_0;

		// Token: 0x0200044E RID: 1102
		[ObfuscatedName("Canis.actions.timers.SetSimultaneousTimerAction+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060030BF RID: 12479 RVA: 0x000CA410 File Offset: 0x000C8610
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SetSimultaneousTimerAction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSimultaneousTimerAction.__c>.NativeClassPtr);
				SetSimultaneousTimerAction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction.__c>.NativeClassPtr, "<>9");
				SetSimultaneousTimerAction.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction.__c>.NativeClassPtr, "<>9__9_0");
				SetSimultaneousTimerAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction.__c>.NativeClassPtr, 100668225);
				SetSimultaneousTimerAction.__c.NativeMethodInfoPtr__execute_b__9_0_Internal_ValueTuple_2_AccountID_SelectionMessage_KeyValuePair_2_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction.__c>.NativeClassPtr, 100668226);
			}

			// Token: 0x060030C0 RID: 12480 RVA: 0x000CA48C File Offset: 0x000C868C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSimultaneousTimerAction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030C1 RID: 12481 RVA: 0x000CA4C8 File Offset: 0x000C86C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591816, XrefRangeEnd = 591821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<AccountID, SelectionMessage> _execute_b__9_0(KeyValuePair<AccountID, SelectionMessage> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction.__c.NativeMethodInfoPtr__execute_b__9_0_Internal_ValueTuple_2_AccountID_SelectionMessage_KeyValuePair_2_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<AccountID, SelectionMessage>(intPtr);
				}
			}

			// Token: 0x060030C2 RID: 12482 RVA: 0x00017441 File Offset: 0x00015641
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CC9 RID: 3273
			// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000CA518 File Offset: 0x000C8718
			// (set) Token: 0x060030C4 RID: 12484 RVA: 0x0001744A File Offset: 0x0001564A
			public unsafe static SetSimultaneousTimerAction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetSimultaneousTimerAction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetSimultaneousTimerAction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetSimultaneousTimerAction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CCA RID: 3274
			// (get) Token: 0x060030C5 RID: 12485 RVA: 0x000CA540 File Offset: 0x000C8740
			// (set) Token: 0x060030C6 RID: 12486 RVA: 0x0001745C File Offset: 0x0001565C
			public unsafe static Func<KeyValuePair<AccountID, SelectionMessage>, ValueTuple<AccountID, SelectionMessage>> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetSimultaneousTimerAction.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<AccountID, SelectionMessage>, ValueTuple<AccountID, SelectionMessage>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetSimultaneousTimerAction.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E82 RID: 7810
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001E83 RID: 7811
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001E84 RID: 7812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001E85 RID: 7813
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__9_0_Internal_ValueTuple_2_AccountID_SelectionMessage_KeyValuePair_2_AccountID_SelectionMessage_0;
		}

		// Token: 0x0200044F RID: 1103
		[ObfuscatedName("Canis.actions.timers.SetSimultaneousTimerAction+<ClearTimerForAccount>d__12")]
		public sealed class _ClearTimerForAccount_d__12 : Object
		{
			// Token: 0x060030C7 RID: 12487 RVA: 0x000CA568 File Offset: 0x000C8768
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearTimerForAccount_d__12()
			{
				Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "<ClearTimerForAccount>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr);
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, "<>1__state");
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, "<>2__current");
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, "<>l__initialThreadId");
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, "accountID");
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___3__accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, "<>3__accountID");
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, "<>4__this");
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, 100668227);
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, 100668228);
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, 100668229);
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, 100668230);
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, 100668231);
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, 100668232);
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, 100668233);
				SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr, 100668234);
			}

			// Token: 0x060030C8 RID: 12488 RVA: 0x000CA6AC File Offset: 0x000C88AC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClearTimerForAccount_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimerForAccount_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030C9 RID: 12489 RVA: 0x000CA6F4 File Offset: 0x000C88F4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030CA RID: 12490 RVA: 0x000CA728 File Offset: 0x000C8928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591821, XrefRangeEnd = 591867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CD1 RID: 3281
			// (get) Token: 0x060030CB RID: 12491 RVA: 0x000CA764 File Offset: 0x000C8964
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060030CC RID: 12492 RVA: 0x000CA7A4 File Offset: 0x000C89A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591867, XrefRangeEnd = 591872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CD2 RID: 3282
			// (get) Token: 0x060030CD RID: 12493 RVA: 0x000CA7D8 File Offset: 0x000C89D8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030CE RID: 12494 RVA: 0x000CA818 File Offset: 0x000C8A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591872, XrefRangeEnd = 591881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060030CF RID: 12495 RVA: 0x000CA858 File Offset: 0x000C8A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060030D0 RID: 12496 RVA: 0x0001746E File Offset: 0x0001566E
			public _ClearTimerForAccount_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CCB RID: 3275
			// (get) Token: 0x060030D1 RID: 12497 RVA: 0x000CA898 File Offset: 0x000C8A98
			// (set) Token: 0x060030D2 RID: 12498 RVA: 0x00017477 File Offset: 0x00015677
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CCC RID: 3276
			// (get) Token: 0x060030D3 RID: 12499 RVA: 0x000CA8C0 File Offset: 0x000C8AC0
			// (set) Token: 0x060030D4 RID: 12500 RVA: 0x00017492 File Offset: 0x00015692
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CCD RID: 3277
			// (get) Token: 0x060030D5 RID: 12501 RVA: 0x000CA8F0 File Offset: 0x000C8AF0
			// (set) Token: 0x060030D6 RID: 12502 RVA: 0x000174B1 File Offset: 0x000156B1
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000CCE RID: 3278
			// (get) Token: 0x060030D7 RID: 12503 RVA: 0x000CA918 File Offset: 0x000C8B18
			// (set) Token: 0x060030D8 RID: 12504 RVA: 0x000174CC File Offset: 0x000156CC
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CCF RID: 3279
			// (get) Token: 0x060030D9 RID: 12505 RVA: 0x000CA948 File Offset: 0x000C8B48
			// (set) Token: 0x060030DA RID: 12506 RVA: 0x000174EB File Offset: 0x000156EB
			public unsafe AccountID __3__accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___3__accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___3__accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD0 RID: 3280
			// (get) Token: 0x060030DB RID: 12507 RVA: 0x000CA978 File Offset: 0x000C8B78
			// (set) Token: 0x060030DC RID: 12508 RVA: 0x0001750A File Offset: 0x0001570A
			public unsafe SetSimultaneousTimerAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetSimultaneousTimerAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimerForAccount_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E86 RID: 7814
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E87 RID: 7815
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E88 RID: 7816
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001E89 RID: 7817
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04001E8A RID: 7818
			private static readonly IntPtr NativeFieldInfoPtr___3__accountID;

			// Token: 0x04001E8B RID: 7819
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E8C RID: 7820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E8D RID: 7821
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E8E RID: 7822
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E8F RID: 7823
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001E90 RID: 7824
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E91 RID: 7825
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E92 RID: 7826
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001E93 RID: 7827
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000450 RID: 1104
		[ObfuscatedName("Canis.actions.timers.SetSimultaneousTimerAction+<ClearTimers>d__13")]
		public sealed class _ClearTimers_d__13 : Object
		{
			// Token: 0x060030DD RID: 12509 RVA: 0x000CA9A8 File Offset: 0x000C8BA8
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearTimers_d__13()
			{
				Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "<ClearTimers>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr);
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, "<>1__state");
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, "<>2__current");
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, "<>4__this");
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, "<>7__wrap1");
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, 100668235);
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, 100668236);
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, 100668237);
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, 100668238);
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, 100668239);
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, 100668240);
				SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr, 100668241);
			}

			// Token: 0x060030DE RID: 12510 RVA: 0x000CAAB0 File Offset: 0x000C8CB0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClearTimers_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSimultaneousTimerAction._ClearTimers_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030DF RID: 12511 RVA: 0x000CAAF8 File Offset: 0x000C8CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591881, XrefRangeEnd = 591886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030E0 RID: 12512 RVA: 0x000CAB2C File Offset: 0x000C8D2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591886, XrefRangeEnd = 591910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060030E1 RID: 12513 RVA: 0x000CAB68 File Offset: 0x000C8D68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591910, XrefRangeEnd = 591913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CD7 RID: 3287
			// (get) Token: 0x060030E2 RID: 12514 RVA: 0x000CAB9C File Offset: 0x000C8D9C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030E3 RID: 12515 RVA: 0x000CABDC File Offset: 0x000C8DDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591913, XrefRangeEnd = 591918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CD8 RID: 3288
			// (get) Token: 0x060030E4 RID: 12516 RVA: 0x000CAC10 File Offset: 0x000C8E10
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._ClearTimers_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030E5 RID: 12517 RVA: 0x00017529 File Offset: 0x00015729
			public _ClearTimers_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CD3 RID: 3283
			// (get) Token: 0x060030E6 RID: 12518 RVA: 0x000CAC50 File Offset: 0x000C8E50
			// (set) Token: 0x060030E7 RID: 12519 RVA: 0x00017532 File Offset: 0x00015732
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CD4 RID: 3284
			// (get) Token: 0x060030E8 RID: 12520 RVA: 0x000CAC78 File Offset: 0x000C8E78
			// (set) Token: 0x060030E9 RID: 12521 RVA: 0x0001754D File Offset: 0x0001574D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD5 RID: 3285
			// (get) Token: 0x060030EA RID: 12522 RVA: 0x000CACA8 File Offset: 0x000C8EA8
			// (set) Token: 0x060030EB RID: 12523 RVA: 0x0001756C File Offset: 0x0001576C
			public unsafe SetSimultaneousTimerAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetSimultaneousTimerAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD6 RID: 3286
			// (get) Token: 0x060030EC RID: 12524 RVA: 0x000CACD8 File Offset: 0x000C8ED8
			// (set) Token: 0x060030ED RID: 12525 RVA: 0x0001758B File Offset: 0x0001578B
			public Dictionary<AccountID, SelectionMessage>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<AccountID, SelectionMessage>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<AccountID, SelectionMessage>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._ClearTimers_d__13.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<AccountID, SelectionMessage>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001E94 RID: 7828
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E95 RID: 7829
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E96 RID: 7830
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E97 RID: 7831
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001E98 RID: 7832
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E99 RID: 7833
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E9A RID: 7834
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E9B RID: 7835
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001E9C RID: 7836
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E9D RID: 7837
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E9E RID: 7838
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000451 RID: 1105
		[ObfuscatedName("Canis.actions.timers.SetSimultaneousTimerAction+<execute>d__9")]
		public sealed class _execute_d__9 : Object
		{
			// Token: 0x060030EE RID: 12526 RVA: 0x000CAD08 File Offset: 0x000C8F08
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr);
				SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, "<>1__state");
				SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, "<>2__current");
				SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, "<>l__initialThreadId");
				SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, "<>4__this");
				SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, "<>7__wrap1");
				SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, 100668242);
				SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, 100668243);
				SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, 100668244);
				SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, 100668245);
				SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, 100668246);
				SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, 100668247);
				SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, 100668248);
				SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, 100668249);
				SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr, 100668250);
			}

			// Token: 0x060030EF RID: 12527 RVA: 0x000CAE4C File Offset: 0x000C904C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSimultaneousTimerAction._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030F0 RID: 12528 RVA: 0x000CAE94 File Offset: 0x000C9094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591918, XrefRangeEnd = 591923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030F1 RID: 12529 RVA: 0x000CAEC8 File Offset: 0x000C90C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591923, XrefRangeEnd = 592024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060030F2 RID: 12530 RVA: 0x000CAF04 File Offset: 0x000C9104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592024, XrefRangeEnd = 592027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CDE RID: 3294
			// (get) Token: 0x060030F3 RID: 12531 RVA: 0x000CAF38 File Offset: 0x000C9138
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060030F4 RID: 12532 RVA: 0x000CAF78 File Offset: 0x000C9178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592027, XrefRangeEnd = 592032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CDF RID: 3295
			// (get) Token: 0x060030F5 RID: 12533 RVA: 0x000CAFAC File Offset: 0x000C91AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030F6 RID: 12534 RVA: 0x000CAFEC File Offset: 0x000C91EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592032, XrefRangeEnd = 592034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060030F7 RID: 12535 RVA: 0x000CB02C File Offset: 0x000C922C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060030F8 RID: 12536 RVA: 0x000175B9 File Offset: 0x000157B9
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CD9 RID: 3289
			// (get) Token: 0x060030F9 RID: 12537 RVA: 0x000CB06C File Offset: 0x000C926C
			// (set) Token: 0x060030FA RID: 12538 RVA: 0x000175C2 File Offset: 0x000157C2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CDA RID: 3290
			// (get) Token: 0x060030FB RID: 12539 RVA: 0x000CB094 File Offset: 0x000C9294
			// (set) Token: 0x060030FC RID: 12540 RVA: 0x000175DD File Offset: 0x000157DD
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDB RID: 3291
			// (get) Token: 0x060030FD RID: 12541 RVA: 0x000CB0C4 File Offset: 0x000C92C4
			// (set) Token: 0x060030FE RID: 12542 RVA: 0x000175FC File Offset: 0x000157FC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000CDC RID: 3292
			// (get) Token: 0x060030FF RID: 12543 RVA: 0x000CB0EC File Offset: 0x000C92EC
			// (set) Token: 0x06003100 RID: 12544 RVA: 0x00017617 File Offset: 0x00015817
			public unsafe SetSimultaneousTimerAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetSimultaneousTimerAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDD RID: 3293
			// (get) Token: 0x06003101 RID: 12545 RVA: 0x000CB11C File Offset: 0x000C931C
			// (set) Token: 0x06003102 RID: 12546 RVA: 0x00017636 File Offset: 0x00015836
			public Dictionary<AccountID, SelectionMessage>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<AccountID, SelectionMessage>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<AccountID, SelectionMessage>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._execute_d__9.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<AccountID, SelectionMessage>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001E9F RID: 7839
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EA0 RID: 7840
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001EA1 RID: 7841
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001EA2 RID: 7842
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EA3 RID: 7843
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001EA4 RID: 7844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001EA5 RID: 7845
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EA6 RID: 7846
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001EA7 RID: 7847
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001EA8 RID: 7848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001EA9 RID: 7849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EAA RID: 7850
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001EAB RID: 7851
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001EAC RID: 7852
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000452 RID: 1106
		[ObfuscatedName("Canis.actions.timers.SetSimultaneousTimerAction+<waitForTime>d__15")]
		public sealed class _waitForTime_d__15 : ValueType
		{
			// Token: 0x06003103 RID: 12547 RVA: 0x000CB14C File Offset: 0x000C934C
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForTime_d__15()
			{
				Il2CppClassPointerStore<SetSimultaneousTimerAction._waitForTime_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSimultaneousTimerAction>.NativeClassPtr, "<waitForTime>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSimultaneousTimerAction._waitForTime_d__15>.NativeClassPtr);
				SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._waitForTime_d__15>.NativeClassPtr, "<>1__state");
				SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._waitForTime_d__15>.NativeClassPtr, "<>t__builder");
				SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._waitForTime_d__15>.NativeClassPtr, "<>4__this");
				SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSimultaneousTimerAction._waitForTime_d__15>.NativeClassPtr, "<>u__1");
				SetSimultaneousTimerAction._waitForTime_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._waitForTime_d__15>.NativeClassPtr, 100668251);
				SetSimultaneousTimerAction._waitForTime_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSimultaneousTimerAction._waitForTime_d__15>.NativeClassPtr, 100668252);
			}

			// Token: 0x06003104 RID: 12548 RVA: 0x000CB1F0 File Offset: 0x000C93F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592034, XrefRangeEnd = 592261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._waitForTime_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003105 RID: 12549 RVA: 0x000CB228 File Offset: 0x000C9428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592261, XrefRangeEnd = 592265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetSimultaneousTimerAction._waitForTime_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003106 RID: 12550 RVA: 0x00017664 File Offset: 0x00015864
			public _waitForTime_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003107 RID: 12551 RVA: 0x0001766D File Offset: 0x0001586D
			public _waitForTime_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSimultaneousTimerAction._waitForTime_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x17000CE0 RID: 3296
			// (get) Token: 0x06003108 RID: 12552 RVA: 0x000CB270 File Offset: 0x000C9470
			// (set) Token: 0x06003109 RID: 12553 RVA: 0x0001767F File Offset: 0x0001587F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CE1 RID: 3297
			// (get) Token: 0x0600310A RID: 12554 RVA: 0x000CB298 File Offset: 0x000C9498
			// (set) Token: 0x0600310B RID: 12555 RVA: 0x0001769A File Offset: 0x0001589A
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000CE2 RID: 3298
			// (get) Token: 0x0600310C RID: 12556 RVA: 0x000CB2C8 File Offset: 0x000C94C8
			// (set) Token: 0x0600310D RID: 12557 RVA: 0x000176C8 File Offset: 0x000158C8
			public unsafe SetSimultaneousTimerAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetSimultaneousTimerAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CE3 RID: 3299
			// (get) Token: 0x0600310E RID: 12558 RVA: 0x000CB2F8 File Offset: 0x000C94F8
			// (set) Token: 0x0600310F RID: 12559 RVA: 0x000176E7 File Offset: 0x000158E7
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetSimultaneousTimerAction._waitForTime_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001EAD RID: 7853
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EAE RID: 7854
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001EAF RID: 7855
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EB0 RID: 7856
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001EB1 RID: 7857
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EB2 RID: 7858
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
