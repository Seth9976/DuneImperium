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
	// Token: 0x020001FE RID: 510
	public class AddTimeToSimultaneousTimerAction : Action
	{
		// Token: 0x0600158B RID: 5515 RVA: 0x000705BC File Offset: 0x0006E7BC
		// Note: this type is marked as 'beforefieldinit'.
		static AddTimeToSimultaneousTimerAction()
		{
			Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.timers", "AddTimeToSimultaneousTimerAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction>.NativeClassPtr);
			AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_secondsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction>.NativeClassPtr, "secondsToAdd");
			AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction>.NativeClassPtr, "TimerID");
			AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_SetSimultaneousTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction>.NativeClassPtr, "SetSimultaneousTimer");
			AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_CurrentTimers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction>.NativeClassPtr, "CurrentTimers");
			AddTimeToSimultaneousTimerAction.NativeMethodInfoPtr__ctor_Public_Void_AddTimeToSimultaneousTimer_Dictionary_2_TimerID_SetSimultaneousTimerAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction>.NativeClassPtr, 100668158);
			AddTimeToSimultaneousTimerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction>.NativeClassPtr, 100668159);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00070664 File Offset: 0x0006E864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 591425, RefRangeEnd = 591426, XrefRangeStart = 591418, XrefRangeEnd = 591425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddTimeToSimultaneousTimerAction(AddTimeToSimultaneousTimer message, Dictionary<TimerID, SetSimultaneousTimerAction> currentSimTimers, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSimTimers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToSimultaneousTimerAction.NativeMethodInfoPtr__ctor_Public_Void_AddTimeToSimultaneousTimer_Dictionary_2_TimerID_SetSimultaneousTimerAction_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x000706D4 File Offset: 0x0006E8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591426, XrefRangeEnd = 591432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddTimeToSimultaneousTimerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0000A61A File Offset: 0x0000881A
		public AddTimeToSimultaneousTimerAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x00070720 File Offset: 0x0006E920
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x0000A623 File Offset: 0x00008823
		public unsafe int secondsToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_secondsToAdd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_secondsToAdd)) = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00070748 File Offset: 0x0006E948
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x0000A63E File Offset: 0x0000883E
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00070778 File Offset: 0x0006E978
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x0000A65D File Offset: 0x0000885D
		public unsafe SetSimultaneousTimerAction SetSimultaneousTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_SetSimultaneousTimer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetSimultaneousTimerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_SetSimultaneousTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x000707A8 File Offset: 0x0006E9A8
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x0000A67C File Offset: 0x0000887C
		public unsafe Dictionary<TimerID, SetSimultaneousTimerAction> CurrentTimers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_CurrentTimers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TimerID, SetSimultaneousTimerAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction.NativeFieldInfoPtr_CurrentTimers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeFieldInfoPtr_secondsToAdd;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeFieldInfoPtr_SetSimultaneousTimer;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimers;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddTimeToSimultaneousTimer_Dictionary_2_TimerID_SetSimultaneousTimerAction_Match_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000448 RID: 1096
		[ObfuscatedName("Canis.actions.timers.AddTimeToSimultaneousTimerAction+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06003055 RID: 12373 RVA: 0x000C8EC4 File Offset: 0x000C70C4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr);
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, "<>1__state");
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, "<>2__current");
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, "<>l__initialThreadId");
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, "<>4__this");
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668160);
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668161);
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668162);
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668163);
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668164);
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668165);
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668166);
				AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668167);
			}

			// Token: 0x06003056 RID: 12374 RVA: 0x000C8FE0 File Offset: 0x000C71E0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTimeToSimultaneousTimerAction._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003057 RID: 12375 RVA: 0x000C9028 File Offset: 0x000C7228
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003058 RID: 12376 RVA: 0x000C905C File Offset: 0x000C725C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591369, XrefRangeEnd = 591411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CAA RID: 3242
			// (get) Token: 0x06003059 RID: 12377 RVA: 0x000C9098 File Offset: 0x000C7298
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600305A RID: 12378 RVA: 0x000C90D8 File Offset: 0x000C72D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591411, XrefRangeEnd = 591416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CAB RID: 3243
			// (get) Token: 0x0600305B RID: 12379 RVA: 0x000C910C File Offset: 0x000C730C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600305C RID: 12380 RVA: 0x000C914C File Offset: 0x000C734C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591416, XrefRangeEnd = 591418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x0600305D RID: 12381 RVA: 0x000C918C File Offset: 0x000C738C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600305E RID: 12382 RVA: 0x00017146 File Offset: 0x00015346
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CA6 RID: 3238
			// (get) Token: 0x0600305F RID: 12383 RVA: 0x000C91CC File Offset: 0x000C73CC
			// (set) Token: 0x06003060 RID: 12384 RVA: 0x0001714F File Offset: 0x0001534F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CA7 RID: 3239
			// (get) Token: 0x06003061 RID: 12385 RVA: 0x000C91F4 File Offset: 0x000C73F4
			// (set) Token: 0x06003062 RID: 12386 RVA: 0x0001716A File Offset: 0x0001536A
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA8 RID: 3240
			// (get) Token: 0x06003063 RID: 12387 RVA: 0x000C9224 File Offset: 0x000C7424
			// (set) Token: 0x06003064 RID: 12388 RVA: 0x00017189 File Offset: 0x00015389
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000CA9 RID: 3241
			// (get) Token: 0x06003065 RID: 12389 RVA: 0x000C924C File Offset: 0x000C744C
			// (set) Token: 0x06003066 RID: 12390 RVA: 0x000171A4 File Offset: 0x000153A4
			public unsafe AddTimeToSimultaneousTimerAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddTimeToSimultaneousTimerAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E3D RID: 7741
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E3E RID: 7742
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E3F RID: 7743
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001E40 RID: 7744
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E41 RID: 7745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E42 RID: 7746
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E43 RID: 7747
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E44 RID: 7748
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001E45 RID: 7749
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E46 RID: 7750
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E47 RID: 7751
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001E48 RID: 7752
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
