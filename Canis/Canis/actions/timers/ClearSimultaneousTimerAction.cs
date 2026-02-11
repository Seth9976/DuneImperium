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
	// Token: 0x02000200 RID: 512
	public class ClearSimultaneousTimerAction : Action
	{
		// Token: 0x060015A3 RID: 5539 RVA: 0x000709F4 File Offset: 0x0006EBF4
		// Note: this type is marked as 'beforefieldinit'.
		static ClearSimultaneousTimerAction()
		{
			Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.timers", "ClearSimultaneousTimerAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr);
			ClearSimultaneousTimerAction.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr, "TimerID");
			ClearSimultaneousTimerAction.NativeFieldInfoPtr_CurrentTimers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr, "CurrentTimers");
			ClearSimultaneousTimerAction.NativeFieldInfoPtr_SetSimultaneousTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr, "SetSimultaneousTimer");
			ClearSimultaneousTimerAction.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr, "AccountID");
			ClearSimultaneousTimerAction.NativeMethodInfoPtr__ctor_Public_Void_ClearSimultaneousTimer_Dictionary_2_TimerID_SetSimultaneousTimerAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr, 100668178);
			ClearSimultaneousTimerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr, 100668179);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00070A9C File Offset: 0x0006EC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 591610, RefRangeEnd = 591611, XrefRangeStart = 591570, XrefRangeEnd = 591610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClearSimultaneousTimerAction(ClearSimultaneousTimer clearTimer, Dictionary<TimerID, SetSimultaneousTimerAction> currentSimTimers, Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clearTimer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSimTimers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction.NativeMethodInfoPtr__ctor_Public_Void_ClearSimultaneousTimer_Dictionary_2_TimerID_SetSimultaneousTimerAction_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00070B0C File Offset: 0x0006ED0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591611, XrefRangeEnd = 591617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClearSimultaneousTimerAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0000A71C File Offset: 0x0000891C
		public ClearSimultaneousTimerAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00070B58 File Offset: 0x0006ED58
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x0000A725 File Offset: 0x00008925
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00070B88 File Offset: 0x0006ED88
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x0000A744 File Offset: 0x00008944
		public unsafe Dictionary<TimerID, SetSimultaneousTimerAction> CurrentTimers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction.NativeFieldInfoPtr_CurrentTimers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TimerID, SetSimultaneousTimerAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction.NativeFieldInfoPtr_CurrentTimers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x00070BB8 File Offset: 0x0006EDB8
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x0000A763 File Offset: 0x00008963
		public unsafe SetSimultaneousTimerAction SetSimultaneousTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction.NativeFieldInfoPtr_SetSimultaneousTimer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetSimultaneousTimerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction.NativeFieldInfoPtr_SetSimultaneousTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x00070BE8 File Offset: 0x0006EDE8
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x0000A782 File Offset: 0x00008982
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimers;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeFieldInfoPtr_SetSimultaneousTimer;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClearSimultaneousTimer_Dictionary_2_TimerID_SetSimultaneousTimerAction_Match_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0200044A RID: 1098
		[ObfuscatedName("Canis.actions.timers.ClearSimultaneousTimerAction+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003079 RID: 12409 RVA: 0x000C9634 File Offset: 0x000C7834
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ClearSimultaneousTimerAction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearSimultaneousTimerAction.__c>.NativeClassPtr);
				ClearSimultaneousTimerAction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction.__c>.NativeClassPtr, "<>9");
				ClearSimultaneousTimerAction.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction.__c>.NativeClassPtr, "<>9__4_0");
				ClearSimultaneousTimerAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction.__c>.NativeClassPtr, 100668181);
				ClearSimultaneousTimerAction.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_String_KeyValuePair_2_TimerID_SetSimultaneousTimerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction.__c>.NativeClassPtr, 100668182);
			}

			// Token: 0x0600307A RID: 12410 RVA: 0x000C96B0 File Offset: 0x000C78B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearSimultaneousTimerAction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600307B RID: 12411 RVA: 0x000C96EC File Offset: 0x000C78EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591507, XrefRangeEnd = 591512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __ctor_b__4_0(KeyValuePair<TimerID, SetSimultaneousTimerAction> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_String_KeyValuePair_2_TimerID_SetSimultaneousTimerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600307C RID: 12412 RVA: 0x00017240 File Offset: 0x00015440
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CB2 RID: 3250
			// (get) Token: 0x0600307D RID: 12413 RVA: 0x000C973C File Offset: 0x000C793C
			// (set) Token: 0x0600307E RID: 12414 RVA: 0x00017249 File Offset: 0x00015449
			public unsafe static ClearSimultaneousTimerAction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClearSimultaneousTimerAction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClearSimultaneousTimerAction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClearSimultaneousTimerAction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CB3 RID: 3251
			// (get) Token: 0x0600307F RID: 12415 RVA: 0x000C9764 File Offset: 0x000C7964
			// (set) Token: 0x06003080 RID: 12416 RVA: 0x0001725B File Offset: 0x0001545B
			public unsafe static Func<KeyValuePair<TimerID, SetSimultaneousTimerAction>, string> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClearSimultaneousTimerAction.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TimerID, SetSimultaneousTimerAction>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClearSimultaneousTimerAction.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E55 RID: 7765
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001E56 RID: 7766
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001E57 RID: 7767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001E58 RID: 7768
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_0_Internal_String_KeyValuePair_2_TimerID_SetSimultaneousTimerAction_0;
		}

		// Token: 0x0200044B RID: 1099
		[ObfuscatedName("Canis.actions.timers.ClearSimultaneousTimerAction+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06003081 RID: 12417 RVA: 0x000C978C File Offset: 0x000C798C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClearSimultaneousTimerAction>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr);
				ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, "<>1__state");
				ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, "<>2__current");
				ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, "<>l__initialThreadId");
				ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, "<>4__this");
				ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, "<>7__wrap1");
				ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668183);
				ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668184);
				ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668185);
				ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668186);
				ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668187);
				ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668188);
				ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668189);
				ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668190);
				ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr, 100668191);
			}

			// Token: 0x06003082 RID: 12418 RVA: 0x000C98D0 File Offset: 0x000C7AD0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearSimultaneousTimerAction._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003083 RID: 12419 RVA: 0x000C9918 File Offset: 0x000C7B18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 591517, RefRangeEnd = 591518, XrefRangeStart = 591512, XrefRangeEnd = 591517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003084 RID: 12420 RVA: 0x000C994C File Offset: 0x000C7B4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591518, XrefRangeEnd = 591560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003085 RID: 12421 RVA: 0x000C9988 File Offset: 0x000C7B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591560, XrefRangeEnd = 591563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CB9 RID: 3257
			// (get) Token: 0x06003086 RID: 12422 RVA: 0x000C99BC File Offset: 0x000C7BBC
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06003087 RID: 12423 RVA: 0x000C99FC File Offset: 0x000C7BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591563, XrefRangeEnd = 591568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CBA RID: 3258
			// (get) Token: 0x06003088 RID: 12424 RVA: 0x000C9A30 File Offset: 0x000C7C30
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003089 RID: 12425 RVA: 0x000C9A70 File Offset: 0x000C7C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591568, XrefRangeEnd = 591570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x0600308A RID: 12426 RVA: 0x000C9AB0 File Offset: 0x000C7CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimerAction._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600308B RID: 12427 RVA: 0x0001726D File Offset: 0x0001546D
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CB4 RID: 3252
			// (get) Token: 0x0600308C RID: 12428 RVA: 0x000C9AF0 File Offset: 0x000C7CF0
			// (set) Token: 0x0600308D RID: 12429 RVA: 0x00017276 File Offset: 0x00015476
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CB5 RID: 3253
			// (get) Token: 0x0600308E RID: 12430 RVA: 0x000C9B18 File Offset: 0x000C7D18
			// (set) Token: 0x0600308F RID: 12431 RVA: 0x00017291 File Offset: 0x00015491
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CB6 RID: 3254
			// (get) Token: 0x06003090 RID: 12432 RVA: 0x000C9B48 File Offset: 0x000C7D48
			// (set) Token: 0x06003091 RID: 12433 RVA: 0x000172B0 File Offset: 0x000154B0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000CB7 RID: 3255
			// (get) Token: 0x06003092 RID: 12434 RVA: 0x000C9B70 File Offset: 0x000C7D70
			// (set) Token: 0x06003093 RID: 12435 RVA: 0x000172CB File Offset: 0x000154CB
			public unsafe ClearSimultaneousTimerAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClearSimultaneousTimerAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CB8 RID: 3256
			// (get) Token: 0x06003094 RID: 12436 RVA: 0x000C9BA0 File Offset: 0x000C7DA0
			// (set) Token: 0x06003095 RID: 12437 RVA: 0x000172EA File Offset: 0x000154EA
			public unsafe IEnumerator<Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimerAction._execute_d__5.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E59 RID: 7769
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E5A RID: 7770
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E5B RID: 7771
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001E5C RID: 7772
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E5D RID: 7773
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001E5E RID: 7774
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E5F RID: 7775
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E60 RID: 7776
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E61 RID: 7777
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001E62 RID: 7778
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001E63 RID: 7779
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E64 RID: 7780
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E65 RID: 7781
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001E66 RID: 7782
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
