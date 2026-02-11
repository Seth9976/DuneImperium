using System;
using Canis.messages.timer;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.timers
{
	// Token: 0x020001FF RID: 511
	public class AddTimeToTimerAction : Action
	{
		// Token: 0x06001597 RID: 5527 RVA: 0x000707D8 File Offset: 0x0006E9D8
		// Note: this type is marked as 'beforefieldinit'.
		static AddTimeToTimerAction()
		{
			Il2CppClassPointerStore<AddTimeToTimerAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.timers", "AddTimeToTimerAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTimeToTimerAction>.NativeClassPtr);
			AddTimeToTimerAction.NativeFieldInfoPtr_secondsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToTimerAction>.NativeClassPtr, "secondsToAdd");
			AddTimeToTimerAction.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToTimerAction>.NativeClassPtr, "TimerID");
			AddTimeToTimerAction.NativeFieldInfoPtr_SetTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToTimerAction>.NativeClassPtr, "SetTimer");
			AddTimeToTimerAction.NativeFieldInfoPtr_CurrentTimers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToTimerAction>.NativeClassPtr, "CurrentTimers");
			AddTimeToTimerAction.NativeMethodInfoPtr__ctor_Public_Void_AddTimeToTimer_Dictionary_2_TimerID_SetTimerAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimerAction>.NativeClassPtr, 100668168);
			AddTimeToTimerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimerAction>.NativeClassPtr, 100668169);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00070880 File Offset: 0x0006EA80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 591500, RefRangeEnd = 591501, XrefRangeStart = 591492, XrefRangeEnd = 591500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddTimeToTimerAction(AddTimeToTimer message, Dictionary<TimerID, SetTimerAction> currentTimers, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTimeToTimerAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTimers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToTimerAction.NativeMethodInfoPtr__ctor_Public_Void_AddTimeToTimer_Dictionary_2_TimerID_SetTimerAction_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x000708F0 File Offset: 0x0006EAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591501, XrefRangeEnd = 591507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddTimeToTimerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0000A69B File Offset: 0x0000889B
		public AddTimeToTimerAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x0007093C File Offset: 0x0006EB3C
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x0000A6A4 File Offset: 0x000088A4
		public unsafe int secondsToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction.NativeFieldInfoPtr_secondsToAdd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction.NativeFieldInfoPtr_secondsToAdd)) = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00070964 File Offset: 0x0006EB64
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x0000A6BF File Offset: 0x000088BF
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00070994 File Offset: 0x0006EB94
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x0000A6DE File Offset: 0x000088DE
		public unsafe SetTimerAction SetTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction.NativeFieldInfoPtr_SetTimer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetTimerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction.NativeFieldInfoPtr_SetTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x000709C4 File Offset: 0x0006EBC4
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x0000A6FD File Offset: 0x000088FD
		public unsafe Dictionary<TimerID, SetTimerAction> CurrentTimers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction.NativeFieldInfoPtr_CurrentTimers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TimerID, SetTimerAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction.NativeFieldInfoPtr_CurrentTimers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeFieldInfoPtr_secondsToAdd;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeFieldInfoPtr_SetTimer;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimers;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddTimeToTimer_Dictionary_2_TimerID_SetTimerAction_Match_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000449 RID: 1097
		[ObfuscatedName("Canis.actions.timers.AddTimeToTimerAction+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06003067 RID: 12391 RVA: 0x000C927C File Offset: 0x000C747C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddTimeToTimerAction>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr);
				AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, "<>1__state");
				AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, "<>2__current");
				AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, "<>l__initialThreadId");
				AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, "<>4__this");
				AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, 100668170);
				AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, 100668171);
				AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, 100668172);
				AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, 100668173);
				AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, 100668174);
				AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, 100668175);
				AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, 100668176);
				AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr, 100668177);
			}

			// Token: 0x06003068 RID: 12392 RVA: 0x000C9398 File Offset: 0x000C7598
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTimeToTimerAction._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003069 RID: 12393 RVA: 0x000C93E0 File Offset: 0x000C75E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600306A RID: 12394 RVA: 0x000C9414 File Offset: 0x000C7614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591432, XrefRangeEnd = 591485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CB0 RID: 3248
			// (get) Token: 0x0600306B RID: 12395 RVA: 0x000C9450 File Offset: 0x000C7650
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600306C RID: 12396 RVA: 0x000C9490 File Offset: 0x000C7690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591485, XrefRangeEnd = 591490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CB1 RID: 3249
			// (get) Token: 0x0600306D RID: 12397 RVA: 0x000C94C4 File Offset: 0x000C76C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600306E RID: 12398 RVA: 0x000C9504 File Offset: 0x000C7704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591490, XrefRangeEnd = 591492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x0600306F RID: 12399 RVA: 0x000C9544 File Offset: 0x000C7744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003070 RID: 12400 RVA: 0x000171C3 File Offset: 0x000153C3
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CAC RID: 3244
			// (get) Token: 0x06003071 RID: 12401 RVA: 0x000C9584 File Offset: 0x000C7784
			// (set) Token: 0x06003072 RID: 12402 RVA: 0x000171CC File Offset: 0x000153CC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CAD RID: 3245
			// (get) Token: 0x06003073 RID: 12403 RVA: 0x000C95AC File Offset: 0x000C77AC
			// (set) Token: 0x06003074 RID: 12404 RVA: 0x000171E7 File Offset: 0x000153E7
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CAE RID: 3246
			// (get) Token: 0x06003075 RID: 12405 RVA: 0x000C95DC File Offset: 0x000C77DC
			// (set) Token: 0x06003076 RID: 12406 RVA: 0x00017206 File Offset: 0x00015406
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000CAF RID: 3247
			// (get) Token: 0x06003077 RID: 12407 RVA: 0x000C9604 File Offset: 0x000C7804
			// (set) Token: 0x06003078 RID: 12408 RVA: 0x00017221 File Offset: 0x00015421
			public unsafe AddTimeToTimerAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddTimeToTimerAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimerAction._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E49 RID: 7753
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E4A RID: 7754
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E4B RID: 7755
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001E4C RID: 7756
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E4D RID: 7757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E4E RID: 7758
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E4F RID: 7759
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E50 RID: 7760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001E51 RID: 7761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E52 RID: 7762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E53 RID: 7763
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001E54 RID: 7764
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
