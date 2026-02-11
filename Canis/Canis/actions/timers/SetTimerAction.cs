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
	// Token: 0x02000204 RID: 516
	public class SetTimerAction : Action
	{
		// Token: 0x060015DA RID: 5594 RVA: 0x0007154C File Offset: 0x0006F74C
		// Note: this type is marked as 'beforefieldinit'.
		static SetTimerAction()
		{
			Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.timers", "SetTimerAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr);
			SetTimerAction.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "Message");
			SetTimerAction.NativeFieldInfoPtr_Wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "Wait");
			SetTimerAction.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "AccountID");
			SetTimerAction.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "TimerID");
			SetTimerAction.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "buffer");
			SetTimerAction.NativeFieldInfoPtr_cancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "cancellationTokenSource");
			SetTimerAction.NativeFieldInfoPtr_canceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "canceled");
			SetTimerAction.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "startTime");
			SetTimerAction.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "endTime");
			SetTimerAction.NativeMethodInfoPtr__ctor_Public_Void_SetTimer_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, 100668253);
			SetTimerAction.NativeMethodInfoPtr__ctor_Public_Void_SetTimerAction_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, 100668254);
			SetTimerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, 100668255);
			SetTimerAction.NativeMethodInfoPtr_waitForTime_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, 100668256);
			SetTimerAction.NativeMethodInfoPtr__execute_b__11_0_Private_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, 100668257);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00071694 File Offset: 0x0006F894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 592600, RefRangeEnd = 592601, XrefRangeStart = 592590, XrefRangeEnd = 592600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTimerAction(SetTimer setTimer, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(setTimer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction.NativeMethodInfoPtr__ctor_Public_Void_SetTimer_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000716F4 File Offset: 0x0006F8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 592611, RefRangeEnd = 592612, XrefRangeStart = 592601, XrefRangeEnd = 592611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTimerAction(SetTimerAction action, int newWaitTime, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction.NativeMethodInfoPtr__ctor_Public_Void_SetTimerAction_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00071760 File Offset: 0x0006F960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592612, XrefRangeEnd = 592618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetTimerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x000717AC File Offset: 0x0006F9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592618, XrefRangeEnd = 592628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task waitForTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction.NativeMethodInfoPtr_waitForTime_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x000717EC File Offset: 0x0006F9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592628, XrefRangeEnd = 592633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _execute_b__11_0(PlayerEntity _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction.NativeMethodInfoPtr__execute_b__11_0_Private_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0000A905 File Offset: 0x00008B05
		public SetTimerAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0007183C File Offset: 0x0006FA3C
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x0000A90E File Offset: 0x00008B0E
		public unsafe SelectionMessage Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0007186C File Offset: 0x0006FA6C
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x0000A92D File Offset: 0x00008B2D
		public unsafe int Wait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_Wait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_Wait)) = value;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00071894 File Offset: 0x0006FA94
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x0000A948 File Offset: 0x00008B48
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x000718C4 File Offset: 0x0006FAC4
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0000A967 File Offset: 0x00008B67
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000718F4 File Offset: 0x0006FAF4
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x0000A986 File Offset: 0x00008B86
		public unsafe float buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_buffer)) = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x0007191C File Offset: 0x0006FB1C
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x0000A9A1 File Offset: 0x00008BA1
		public unsafe CancellationTokenSource cancellationTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_cancellationTokenSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_cancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x0007194C File Offset: 0x0006FB4C
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x0000A9C0 File Offset: 0x00008BC0
		public unsafe bool canceled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_canceled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_canceled)) = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00071974 File Offset: 0x0006FB74
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000A9DB File Offset: 0x00008BDB
		public unsafe DateTime startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0007199C File Offset: 0x0006FB9C
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x0000A9F6 File Offset: 0x00008BF6
		public unsafe DateTime endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_endTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction.NativeFieldInfoPtr_endTime)) = value;
			}
		}

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeFieldInfoPtr_Wait;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeFieldInfoPtr_cancellationTokenSource;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeFieldInfoPtr_canceled;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SetTimer_Match_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SetTimerAction_Int32_Match_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_waitForTime_Private_Task_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__11_0_Private_Boolean_PlayerEntity_0;

		// Token: 0x02000453 RID: 1107
		[ObfuscatedName("Canis.actions.timers.SetTimerAction+<execute>d__11")]
		public sealed class _execute_d__11 : Object
		{
			// Token: 0x06003110 RID: 12560 RVA: 0x000CB328 File Offset: 0x000C9528
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__11()
			{
				Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "<execute>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr);
				SetTimerAction._execute_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, "<>1__state");
				SetTimerAction._execute_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, "<>2__current");
				SetTimerAction._execute_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, "<>l__initialThreadId");
				SetTimerAction._execute_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, "<>4__this");
				SetTimerAction._execute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, 100668258);
				SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, 100668259);
				SetTimerAction._execute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, 100668260);
				SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, 100668261);
				SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, 100668262);
				SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, 100668263);
				SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, 100668264);
				SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr, 100668265);
			}

			// Token: 0x06003111 RID: 12561 RVA: 0x000CB444 File Offset: 0x000C9644
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTimerAction._execute_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction._execute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003112 RID: 12562 RVA: 0x000CB48C File Offset: 0x000C968C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003113 RID: 12563 RVA: 0x000CB4C0 File Offset: 0x000C96C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592372, XrefRangeEnd = 592390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction._execute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CE8 RID: 3304
			// (get) Token: 0x06003114 RID: 12564 RVA: 0x000CB4FC File Offset: 0x000C96FC
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06003115 RID: 12565 RVA: 0x000CB53C File Offset: 0x000C973C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592390, XrefRangeEnd = 592395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CE9 RID: 3305
			// (get) Token: 0x06003116 RID: 12566 RVA: 0x000CB570 File Offset: 0x000C9770
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003117 RID: 12567 RVA: 0x000CB5B0 File Offset: 0x000C97B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592395, XrefRangeEnd = 592397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06003118 RID: 12568 RVA: 0x000CB5F0 File Offset: 0x000C97F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003119 RID: 12569 RVA: 0x00017715 File Offset: 0x00015915
			public _execute_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CE4 RID: 3300
			// (get) Token: 0x0600311A RID: 12570 RVA: 0x000CB630 File Offset: 0x000C9830
			// (set) Token: 0x0600311B RID: 12571 RVA: 0x0001771E File Offset: 0x0001591E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._execute_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._execute_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CE5 RID: 3301
			// (get) Token: 0x0600311C RID: 12572 RVA: 0x000CB658 File Offset: 0x000C9858
			// (set) Token: 0x0600311D RID: 12573 RVA: 0x00017739 File Offset: 0x00015939
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._execute_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._execute_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CE6 RID: 3302
			// (get) Token: 0x0600311E RID: 12574 RVA: 0x000CB688 File Offset: 0x000C9888
			// (set) Token: 0x0600311F RID: 12575 RVA: 0x00017758 File Offset: 0x00015958
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._execute_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._execute_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000CE7 RID: 3303
			// (get) Token: 0x06003120 RID: 12576 RVA: 0x000CB6B0 File Offset: 0x000C98B0
			// (set) Token: 0x06003121 RID: 12577 RVA: 0x00017773 File Offset: 0x00015973
			public unsafe SetTimerAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._execute_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetTimerAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._execute_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EB3 RID: 7859
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EB4 RID: 7860
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001EB5 RID: 7861
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001EB6 RID: 7862
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EB7 RID: 7863
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001EB8 RID: 7864
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EB9 RID: 7865
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001EBA RID: 7866
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001EBB RID: 7867
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EBC RID: 7868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001EBD RID: 7869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001EBE RID: 7870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000454 RID: 1108
		[ObfuscatedName("Canis.actions.timers.SetTimerAction+<waitForTime>d__12")]
		public sealed class _waitForTime_d__12 : ValueType
		{
			// Token: 0x06003122 RID: 12578 RVA: 0x000CB6E0 File Offset: 0x000C98E0
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForTime_d__12()
			{
				Il2CppClassPointerStore<SetTimerAction._waitForTime_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetTimerAction>.NativeClassPtr, "<waitForTime>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTimerAction._waitForTime_d__12>.NativeClassPtr);
				SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction._waitForTime_d__12>.NativeClassPtr, "<>1__state");
				SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction._waitForTime_d__12>.NativeClassPtr, "<>t__builder");
				SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction._waitForTime_d__12>.NativeClassPtr, "<>4__this");
				SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimerAction._waitForTime_d__12>.NativeClassPtr, "<>u__1");
				SetTimerAction._waitForTime_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction._waitForTime_d__12>.NativeClassPtr, 100668266);
				SetTimerAction._waitForTime_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimerAction._waitForTime_d__12>.NativeClassPtr, 100668267);
			}

			// Token: 0x06003123 RID: 12579 RVA: 0x000CB784 File Offset: 0x000C9984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592397, XrefRangeEnd = 592586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction._waitForTime_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003124 RID: 12580 RVA: 0x000CB7BC File Offset: 0x000C99BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 592586, XrefRangeEnd = 592590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimerAction._waitForTime_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003125 RID: 12581 RVA: 0x00017792 File Offset: 0x00015992
			public _waitForTime_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003126 RID: 12582 RVA: 0x0001779B File Offset: 0x0001599B
			public _waitForTime_d__12()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTimerAction._waitForTime_d__12>.NativeClassPtr))
			{
			}

			// Token: 0x17000CEA RID: 3306
			// (get) Token: 0x06003127 RID: 12583 RVA: 0x000CB804 File Offset: 0x000C9A04
			// (set) Token: 0x06003128 RID: 12584 RVA: 0x000177AD File Offset: 0x000159AD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CEB RID: 3307
			// (get) Token: 0x06003129 RID: 12585 RVA: 0x000CB82C File Offset: 0x000C9A2C
			// (set) Token: 0x0600312A RID: 12586 RVA: 0x000177C8 File Offset: 0x000159C8
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000CEC RID: 3308
			// (get) Token: 0x0600312B RID: 12587 RVA: 0x000CB85C File Offset: 0x000C9A5C
			// (set) Token: 0x0600312C RID: 12588 RVA: 0x000177F6 File Offset: 0x000159F6
			public unsafe SetTimerAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetTimerAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CED RID: 3309
			// (get) Token: 0x0600312D RID: 12589 RVA: 0x000CB88C File Offset: 0x000C9A8C
			// (set) Token: 0x0600312E RID: 12590 RVA: 0x00017815 File Offset: 0x00015A15
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimerAction._waitForTime_d__12.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001EBF RID: 7871
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EC0 RID: 7872
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001EC1 RID: 7873
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EC2 RID: 7874
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001EC3 RID: 7875
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EC4 RID: 7876
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
