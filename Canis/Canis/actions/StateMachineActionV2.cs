using System;
using Canis.actions.serialized;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001F1 RID: 497
	public class StateMachineActionV2 : Action
	{
		// Token: 0x06001504 RID: 5380 RVA: 0x0006E158 File Offset: 0x0006C358
		// Note: this type is marked as 'beforefieldinit'.
		static StateMachineActionV2()
		{
			Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "StateMachineActionV2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr);
			StateMachineActionV2.NativeFieldInfoPtr_StateBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "StateBindings");
			StateMachineActionV2.NativeFieldInfoPtr_Advance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "Advance");
			StateMachineActionV2.NativeFieldInfoPtr_initialState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "initialState");
			StateMachineActionV2.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "currentState");
			StateMachineActionV2.NativeFieldInfoPtr_lastAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "lastAction");
			StateMachineActionV2.NativeMethodInfoPtr_get_CurrentState_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667968);
			StateMachineActionV2.NativeMethodInfoPtr_set_CurrentState_Protected_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667969);
			StateMachineActionV2.NativeMethodInfoPtr_get_InitialState_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667970);
			StateMachineActionV2.NativeMethodInfoPtr__ctor_Protected_Void_Match_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667971);
			StateMachineActionV2.NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineActionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667972);
			StateMachineActionV2.NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667973);
			StateMachineActionV2.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667974);
			StateMachineActionV2.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667975);
			StateMachineActionV2.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667976);
			StateMachineActionV2.NativeMethodInfoPtr_InitializeFromSerialized_Public_Void_SerializedStateMachineActionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667977);
			StateMachineActionV2.NativeMethodInfoPtr_BehaviorFor_Private_StateBehavior_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667978);
			StateMachineActionV2.NativeMethodInfoPtr_AddBinding_Protected_Void_Int32_StateBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667979);
			StateMachineActionV2.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Abstract_Virtual_New_SerializedStateMachineActionV2_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, 100667980);
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0006E2F0 File Offset: 0x0006C4F0
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x0006E338 File Offset: 0x0006C538
		public unsafe virtual int CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineActionV2.NativeMethodInfoPtr_get_CurrentState_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineActionV2.NativeMethodInfoPtr_set_CurrentState_Protected_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x0006E384 File Offset: 0x0006C584
		public unsafe int InitialState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.NativeMethodInfoPtr_get_InitialState_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0006E3C0 File Offset: 0x0006C5C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 590463, RefRangeEnd = 590464, XrefRangeStart = 590449, XrefRangeEnd = 590463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineActionV2(Match m, int initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.NativeMethodInfoPtr__ctor_Protected_Void_Match_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0006E41C File Offset: 0x0006C61C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 590479, RefRangeEnd = 590480, XrefRangeStart = 590464, XrefRangeEnd = 590479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineActionV2(Match m, SerializedStateMachineActionV2 serialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineActionV2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0006E47C File Offset: 0x0006C67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590480, XrefRangeEnd = 590486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0006E4BC File Offset: 0x0006C6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590486, XrefRangeEnd = 590487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineActionV2.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0006E4F8 File Offset: 0x0006C6F8
		[CallerCount(0)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0006E548 File Offset: 0x0006C748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineActionV2.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0006E598 File Offset: 0x0006C798
		[CallerCount(0)]
		public unsafe void InitializeFromSerialized(SerializedStateMachineActionV2 serialized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.NativeMethodInfoPtr_InitializeFromSerialized_Public_Void_SerializedStateMachineActionV2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0006E5DC File Offset: 0x0006C7DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 590490, RefRangeEnd = 590492, XrefRangeStart = 590487, XrefRangeEnd = 590490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineActionV2.StateBehavior BehaviorFor(int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.NativeMethodInfoPtr_BehaviorFor_Private_StateBehavior_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0006E628 File Offset: 0x0006C828
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 590496, RefRangeEnd = 590500, XrefRangeStart = 590492, XrefRangeEnd = 590496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinding(int state, StateMachineActionV2.StateBehavior behavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(behavior);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.NativeMethodInfoPtr_AddBinding_Protected_Void_Int32_StateBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0006E678 File Offset: 0x0006C878
		[CallerCount(0)]
		public unsafe virtual SerializedStateMachineActionV2 MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineActionV2.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Abstract_Virtual_New_SerializedStateMachineActionV2_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineActionV2>(intPtr3) : null;
			}
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0000A2E2 File Offset: 0x000084E2
		public StateMachineActionV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x0006E6D4 File Offset: 0x0006C8D4
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x0000A2EB File Offset: 0x000084EB
		public unsafe Dictionary<int, StateMachineActionV2.StateBehavior> StateBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.NativeFieldInfoPtr_StateBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, StateMachineActionV2.StateBehavior>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.NativeFieldInfoPtr_StateBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x0006E704 File Offset: 0x0006C904
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x0000A30A File Offset: 0x0000850A
		public unsafe StateMachineActionV2.AdvanceStateMachine Advance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.NativeFieldInfoPtr_Advance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2.AdvanceStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.NativeFieldInfoPtr_Advance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x0006E734 File Offset: 0x0006C934
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0000A329 File Offset: 0x00008529
		public unsafe int initialState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.NativeFieldInfoPtr_initialState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.NativeFieldInfoPtr_initialState)) = value;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x0006E75C File Offset: 0x0006C95C
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x0000A344 File Offset: 0x00008544
		public unsafe int currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0006E784 File Offset: 0x0006C984
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x0000A35F File Offset: 0x0000855F
		public unsafe Action lastAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.NativeFieldInfoPtr_lastAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.NativeFieldInfoPtr_lastAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr_StateBindings;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr_Advance;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeFieldInfoPtr_initialState;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeFieldInfoPtr_lastAction;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Protected_Virtual_New_get_Int32_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentState_Protected_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialState_Public_get_Int32_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_Int32_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineActionV2_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFromSerialized_Public_Void_SerializedStateMachineActionV2_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_BehaviorFor_Private_StateBehavior_Int32_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Protected_Void_Int32_StateBehavior_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Abstract_Virtual_New_SerializedStateMachineActionV2_Match_0;

		// Token: 0x0200042F RID: 1071
		public class AdvanceStateMachine : Action
		{
			// Token: 0x06002F2E RID: 12078 RVA: 0x000C5328 File Offset: 0x000C3528
			// Note: this type is marked as 'beforefieldinit'.
			static AdvanceStateMachine()
			{
				Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "AdvanceStateMachine");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine>.NativeClassPtr);
				StateMachineActionV2.AdvanceStateMachine.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine>.NativeClassPtr, 100667981);
				StateMachineActionV2.AdvanceStateMachine.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine>.NativeClassPtr, 100667982);
			}

			// Token: 0x06002F2F RID: 12079 RVA: 0x000C537C File Offset: 0x000C357C
			[CallerCount(191)]
			[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdvanceStateMachine(Match m)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.AdvanceStateMachine.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F30 RID: 12080 RVA: 0x000C53C8 File Offset: 0x000C35C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590348, XrefRangeEnd = 590353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Action> execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineActionV2.AdvanceStateMachine.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}

			// Token: 0x06002F31 RID: 12081 RVA: 0x000168EB File Offset: 0x00014AEB
			public AdvanceStateMachine(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001D90 RID: 7568
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

			// Token: 0x04001D91 RID: 7569
			private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

			// Token: 0x02000491 RID: 1169
			[ObfuscatedName("Canis.actions.StateMachineActionV2+AdvanceStateMachine+<execute>d__1")]
			public sealed class _execute_d__1 : Object
			{
				// Token: 0x06003546 RID: 13638 RVA: 0x000D7C08 File Offset: 0x000D5E08
				// Note: this type is marked as 'beforefieldinit'.
				static _execute_d__1()
				{
					Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine>.NativeClassPtr, "<execute>d__1");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr);
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, "<>1__state");
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, "<>2__current");
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, "<>l__initialThreadId");
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667983);
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667984);
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667985);
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667986);
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667987);
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667988);
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667989);
					StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667990);
				}

				// Token: 0x06003547 RID: 13639 RVA: 0x000D7D10 File Offset: 0x000D5F10
				[CallerCount(126)]
				[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _execute_d__1(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2.AdvanceStateMachine._execute_d__1>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06003548 RID: 13640 RVA: 0x000D7D58 File Offset: 0x000D5F58
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003549 RID: 13641 RVA: 0x000D7D8C File Offset: 0x000D5F8C
				[CallerCount(0)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000E55 RID: 3669
				// (get) Token: 0x0600354A RID: 13642 RVA: 0x000D7DC8 File Offset: 0x000D5FC8
				public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
					}
				}

				// Token: 0x0600354B RID: 13643 RVA: 0x000D7E08 File Offset: 0x000D6008
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590341, XrefRangeEnd = 590346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000E56 RID: 3670
				// (get) Token: 0x0600354C RID: 13644 RVA: 0x000D7E3C File Offset: 0x000D603C
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600354D RID: 13645 RVA: 0x000D7E7C File Offset: 0x000D607C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590346, XrefRangeEnd = 590348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
				}

				// Token: 0x0600354E RID: 13646 RVA: 0x000D7EBC File Offset: 0x000D60BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x0600354F RID: 13647 RVA: 0x00019C8A File Offset: 0x00017E8A
				public _execute_d__1(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000E52 RID: 3666
				// (get) Token: 0x06003550 RID: 13648 RVA: 0x000D7EFC File Offset: 0x000D60FC
				// (set) Token: 0x06003551 RID: 13649 RVA: 0x00019C93 File Offset: 0x00017E93
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000E53 RID: 3667
				// (get) Token: 0x06003552 RID: 13650 RVA: 0x000D7F24 File Offset: 0x000D6124
				// (set) Token: 0x06003553 RID: 13651 RVA: 0x00019CAE File Offset: 0x00017EAE
				public unsafe Action __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E54 RID: 3668
				// (get) Token: 0x06003554 RID: 13652 RVA: 0x000D7F54 File Offset: 0x000D6154
				// (set) Token: 0x06003555 RID: 13653 RVA: 0x00019CCD File Offset: 0x00017ECD
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x0400213E RID: 8510
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400213F RID: 8511
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04002140 RID: 8512
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x04002141 RID: 8513
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04002142 RID: 8514
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04002143 RID: 8515
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04002144 RID: 8516
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

				// Token: 0x04002145 RID: 8517
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04002146 RID: 8518
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04002147 RID: 8519
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

				// Token: 0x04002148 RID: 8520
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}

		// Token: 0x02000430 RID: 1072
		public class BroadcastStateChange : Action
		{
			// Token: 0x06002F32 RID: 12082 RVA: 0x000C5414 File Offset: 0x000C3614
			// Note: this type is marked as 'beforefieldinit'.
			static BroadcastStateChange()
			{
				Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "BroadcastStateChange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange>.NativeClassPtr);
				StateMachineActionV2.BroadcastStateChange.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange>.NativeClassPtr, "attribute");
				StateMachineActionV2.BroadcastStateChange.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange>.NativeClassPtr, 100667991);
				StateMachineActionV2.BroadcastStateChange.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange>.NativeClassPtr, 100667992);
			}

			// Token: 0x06002F33 RID: 12083 RVA: 0x000C547C File Offset: 0x000C367C
			[CallerCount(106)]
			[CachedScanResults(RefRangeStart = 139275, RefRangeEnd = 139381, XrefRangeStart = 139275, XrefRangeEnd = 139381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BroadcastStateChange(IAttribute attribute, Match m)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.BroadcastStateChange.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F34 RID: 12084 RVA: 0x000C54DC File Offset: 0x000C36DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590396, XrefRangeEnd = 590402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Action> execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineActionV2.BroadcastStateChange.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}

			// Token: 0x06002F35 RID: 12085 RVA: 0x000168F4 File Offset: 0x00014AF4
			public BroadcastStateChange(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C55 RID: 3157
			// (get) Token: 0x06002F36 RID: 12086 RVA: 0x000C5528 File Offset: 0x000C3728
			// (set) Token: 0x06002F37 RID: 12087 RVA: 0x000168FD File Offset: 0x00014AFD
			public unsafe IAttribute attribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.BroadcastStateChange.NativeFieldInfoPtr_attribute);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.BroadcastStateChange.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D92 RID: 7570
			private static readonly IntPtr NativeFieldInfoPtr_attribute;

			// Token: 0x04001D93 RID: 7571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_Match_0;

			// Token: 0x04001D94 RID: 7572
			private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

			// Token: 0x02000492 RID: 1170
			[ObfuscatedName("Canis.actions.StateMachineActionV2+BroadcastStateChange+<execute>d__2")]
			public sealed class _execute_d__2 : Object
			{
				// Token: 0x06003556 RID: 13654 RVA: 0x000D7F7C File Offset: 0x000D617C
				// Note: this type is marked as 'beforefieldinit'.
				static _execute_d__2()
				{
					Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange>.NativeClassPtr, "<execute>d__2");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr);
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, "<>1__state");
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, "<>2__current");
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, "<>4__this");
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667993);
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667994);
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667995);
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667996);
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667997);
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667998);
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667999);
					StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100668000);
				}

				// Token: 0x06003557 RID: 13655 RVA: 0x000D8098 File Offset: 0x000D6298
				[CallerCount(126)]
				[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _execute_d__2(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2.BroadcastStateChange._execute_d__2>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06003558 RID: 13656 RVA: 0x000D80E0 File Offset: 0x000D62E0
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003559 RID: 13657 RVA: 0x000D8114 File Offset: 0x000D6314
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590353, XrefRangeEnd = 590389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000E5B RID: 3675
				// (get) Token: 0x0600355A RID: 13658 RVA: 0x000D8150 File Offset: 0x000D6350
				public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
					}
				}

				// Token: 0x0600355B RID: 13659 RVA: 0x000D8190 File Offset: 0x000D6390
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590389, XrefRangeEnd = 590394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000E5C RID: 3676
				// (get) Token: 0x0600355C RID: 13660 RVA: 0x000D81C4 File Offset: 0x000D63C4
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600355D RID: 13661 RVA: 0x000D8204 File Offset: 0x000D6404
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590394, XrefRangeEnd = 590396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
				}

				// Token: 0x0600355E RID: 13662 RVA: 0x000D8244 File Offset: 0x000D6444
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x0600355F RID: 13663 RVA: 0x00019CE8 File Offset: 0x00017EE8
				public _execute_d__2(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000E57 RID: 3671
				// (get) Token: 0x06003560 RID: 13664 RVA: 0x000D8284 File Offset: 0x000D6484
				// (set) Token: 0x06003561 RID: 13665 RVA: 0x00019CF1 File Offset: 0x00017EF1
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000E58 RID: 3672
				// (get) Token: 0x06003562 RID: 13666 RVA: 0x000D82AC File Offset: 0x000D64AC
				// (set) Token: 0x06003563 RID: 13667 RVA: 0x00019D0C File Offset: 0x00017F0C
				public unsafe Action __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E59 RID: 3673
				// (get) Token: 0x06003564 RID: 13668 RVA: 0x000D82DC File Offset: 0x000D64DC
				// (set) Token: 0x06003565 RID: 13669 RVA: 0x00019D2B File Offset: 0x00017F2B
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x17000E5A RID: 3674
				// (get) Token: 0x06003566 RID: 13670 RVA: 0x000D8304 File Offset: 0x000D6504
				// (set) Token: 0x06003567 RID: 13671 RVA: 0x00019D46 File Offset: 0x00017F46
				public unsafe StateMachineActionV2.BroadcastStateChange __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2.BroadcastStateChange>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002149 RID: 8521
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400214A RID: 8522
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400214B RID: 8523
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x0400214C RID: 8524
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400214D RID: 8525
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400214E RID: 8526
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400214F RID: 8527
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04002150 RID: 8528
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

				// Token: 0x04002151 RID: 8529
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04002152 RID: 8530
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04002153 RID: 8531
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

				// Token: 0x04002154 RID: 8532
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}

		// Token: 0x02000431 RID: 1073
		public class StateBehavior : Object
		{
			// Token: 0x06002F38 RID: 12088 RVA: 0x000C5558 File Offset: 0x000C3758
			// Note: this type is marked as 'beforefieldinit'.
			static StateBehavior()
			{
				Il2CppClassPointerStore<StateMachineActionV2.StateBehavior>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "StateBehavior");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineActionV2.StateBehavior>.NativeClassPtr);
				StateMachineActionV2.StateBehavior.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2.StateBehavior>.NativeClassPtr, "Action");
				StateMachineActionV2.StateBehavior.NativeFieldInfoPtr_Transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2.StateBehavior>.NativeClassPtr, "Transition");
				StateMachineActionV2.StateBehavior.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.StateBehavior>.NativeClassPtr, 100668001);
			}

			// Token: 0x06002F39 RID: 12089 RVA: 0x000C55C0 File Offset: 0x000C37C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateBehavior()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2.StateBehavior>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.StateBehavior.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F3A RID: 12090 RVA: 0x0001691C File Offset: 0x00014B1C
			public StateBehavior(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C56 RID: 3158
			// (get) Token: 0x06002F3B RID: 12091 RVA: 0x000C55FC File Offset: 0x000C37FC
			// (set) Token: 0x06002F3C RID: 12092 RVA: 0x00016925 File Offset: 0x00014B25
			public unsafe StateMachineActionV2.StateAction Action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.StateBehavior.NativeFieldInfoPtr_Action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2.StateAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.StateBehavior.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C57 RID: 3159
			// (get) Token: 0x06002F3D RID: 12093 RVA: 0x000C562C File Offset: 0x000C382C
			// (set) Token: 0x06002F3E RID: 12094 RVA: 0x00016944 File Offset: 0x00014B44
			public unsafe StateMachineActionV2.Transition Transition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.StateBehavior.NativeFieldInfoPtr_Transition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2.Transition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2.StateBehavior.NativeFieldInfoPtr_Transition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D95 RID: 7573
			private static readonly IntPtr NativeFieldInfoPtr_Action;

			// Token: 0x04001D96 RID: 7574
			private static readonly IntPtr NativeFieldInfoPtr_Transition;

			// Token: 0x04001D97 RID: 7575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000432 RID: 1074
		public sealed class StateAction : MulticastDelegate
		{
			// Token: 0x06002F3F RID: 12095 RVA: 0x000C565C File Offset: 0x000C385C
			// Note: this type is marked as 'beforefieldinit'.
			static StateAction()
			{
				Il2CppClassPointerStore<StateMachineActionV2.StateAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "StateAction");
				StateMachineActionV2.StateAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.StateAction>.NativeClassPtr, 100668002);
				StateMachineActionV2.StateAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.StateAction>.NativeClassPtr, 100668003);
				StateMachineActionV2.StateAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.StateAction>.NativeClassPtr, 100668004);
				StateMachineActionV2.StateAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Action_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.StateAction>.NativeClassPtr, 100668005);
			}

			// Token: 0x06002F40 RID: 12096 RVA: 0x000C56D0 File Offset: 0x000C38D0
			[CallerCount(210)]
			[CachedScanResults(RefRangeStart = 320759, RefRangeEnd = 320969, XrefRangeStart = 320759, XrefRangeEnd = 320969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateAction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2.StateAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.StateAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F41 RID: 12097 RVA: 0x000C572C File Offset: 0x000C392C
			[CallerCount(0)]
			public unsafe Action Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.StateAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}

			// Token: 0x06002F42 RID: 12098 RVA: 0x000C576C File Offset: 0x000C396C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.StateAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F43 RID: 12099 RVA: 0x000C57D0 File Offset: 0x000C39D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Action EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.StateAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Action_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002F44 RID: 12100 RVA: 0x00016963 File Offset: 0x00014B63
			public StateAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F45 RID: 12101 RVA: 0x0001696C File Offset: 0x00014B6C
			public static implicit operator StateMachineActionV2.StateAction(Func<Action> A_0)
			{
				return DelegateSupport.ConvertDelegate<StateMachineActionV2.StateAction>(A_0);
			}

			// Token: 0x06002F46 RID: 12102 RVA: 0x00016974 File Offset: 0x00014B74
			public static StateMachineActionV2.StateAction operator +(StateMachineActionV2.StateAction A_0, StateMachineActionV2.StateAction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StateMachineActionV2.StateAction>();
			}

			// Token: 0x06002F47 RID: 12103 RVA: 0x00016982 File Offset: 0x00014B82
			public static StateMachineActionV2.StateAction operator -(StateMachineActionV2.StateAction A_0, StateMachineActionV2.StateAction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StateMachineActionV2.StateAction>();
				}
				return delegate2;
			}

			// Token: 0x04001D98 RID: 7576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001D99 RID: 7577
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Action_0;

			// Token: 0x04001D9A RID: 7578
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001D9B RID: 7579
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Action_IAsyncResult_0;
		}

		// Token: 0x02000433 RID: 1075
		public sealed class Transition : MulticastDelegate
		{
			// Token: 0x06002F48 RID: 12104 RVA: 0x000C5820 File Offset: 0x000C3A20
			// Note: this type is marked as 'beforefieldinit'.
			static Transition()
			{
				Il2CppClassPointerStore<StateMachineActionV2.Transition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "Transition");
				StateMachineActionV2.Transition.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.Transition>.NativeClassPtr, 100668006);
				StateMachineActionV2.Transition.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Nullable_1_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.Transition>.NativeClassPtr, 100668007);
				StateMachineActionV2.Transition.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.Transition>.NativeClassPtr, 100668008);
				StateMachineActionV2.Transition.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Nullable_1_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2.Transition>.NativeClassPtr, 100668009);
			}

			// Token: 0x06002F49 RID: 12105 RVA: 0x000C5894 File Offset: 0x000C3A94
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 554431, RefRangeEnd = 554456, XrefRangeStart = 554431, XrefRangeEnd = 554456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Transition(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2.Transition>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.Transition.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F4A RID: 12106 RVA: 0x000C58F0 File Offset: 0x000C3AF0
			[CallerCount(0)]
			public unsafe Nullable<int> Invoke(Action lastAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.Transition.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Nullable_1_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06002F4B RID: 12107 RVA: 0x000C5938 File Offset: 0x000C3B38
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Action lastAction, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.Transition.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F4C RID: 12108 RVA: 0x000C59AC File Offset: 0x000C3BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590402, XrefRangeEnd = 590404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2.Transition.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Nullable_1_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06002F4D RID: 12109 RVA: 0x00016993 File Offset: 0x00014B93
			public Transition(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F4E RID: 12110 RVA: 0x0001699C File Offset: 0x00014B9C
			public static implicit operator StateMachineActionV2.Transition(Func<Action, Nullable<int>> A_0)
			{
				return DelegateSupport.ConvertDelegate<StateMachineActionV2.Transition>(A_0);
			}

			// Token: 0x06002F4F RID: 12111 RVA: 0x000169A4 File Offset: 0x00014BA4
			public static StateMachineActionV2.Transition operator +(StateMachineActionV2.Transition A_0, StateMachineActionV2.Transition A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StateMachineActionV2.Transition>();
			}

			// Token: 0x06002F50 RID: 12112 RVA: 0x000169B2 File Offset: 0x00014BB2
			public static StateMachineActionV2.Transition operator -(StateMachineActionV2.Transition A_0, StateMachineActionV2.Transition A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StateMachineActionV2.Transition>();
				}
				return delegate2;
			}

			// Token: 0x04001D9C RID: 7580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001D9D RID: 7581
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Nullable_1_Int32_Action_0;

			// Token: 0x04001D9E RID: 7582
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_AsyncCallback_Object_0;

			// Token: 0x04001D9F RID: 7583
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Nullable_1_Int32_IAsyncResult_0;
		}

		// Token: 0x02000434 RID: 1076
		[ObfuscatedName("Canis.actions.StateMachineActionV2+<execute>d__17")]
		public sealed class _execute_d__17 : Object
		{
			// Token: 0x06002F51 RID: 12113 RVA: 0x000C59F4 File Offset: 0x000C3BF4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__17()
			{
				Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2>.NativeClassPtr, "<execute>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr);
				StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, "<>1__state");
				StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, "<>2__current");
				StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, "<>l__initialThreadId");
				StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, "<>4__this");
				StateMachineActionV2._execute_d__17.NativeFieldInfoPtr__nextState_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, "<nextState>5__2");
				StateMachineActionV2._execute_d__17.NativeFieldInfoPtr__behavior_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, "<behavior>5__3");
				StateMachineActionV2._execute_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, 100668010);
				StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, 100668011);
				StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, 100668012);
				StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, 100668013);
				StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, 100668014);
				StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, 100668015);
				StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, 100668016);
				StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr, 100668017);
			}

			// Token: 0x06002F52 RID: 12114 RVA: 0x000C5B38 File Offset: 0x000C3D38
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2._execute_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2._execute_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F53 RID: 12115 RVA: 0x000C5B80 File Offset: 0x000C3D80
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F54 RID: 12116 RVA: 0x000C5BB4 File Offset: 0x000C3DB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590404, XrefRangeEnd = 590442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C5E RID: 3166
			// (get) Token: 0x06002F55 RID: 12117 RVA: 0x000C5BF0 File Offset: 0x000C3DF0
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002F56 RID: 12118 RVA: 0x000C5C30 File Offset: 0x000C3E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590442, XrefRangeEnd = 590447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C5F RID: 3167
			// (get) Token: 0x06002F57 RID: 12119 RVA: 0x000C5C64 File Offset: 0x000C3E64
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F58 RID: 12120 RVA: 0x000C5CA4 File Offset: 0x000C3EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590447, XrefRangeEnd = 590449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002F59 RID: 12121 RVA: 0x000C5CE4 File Offset: 0x000C3EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2._execute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002F5A RID: 12122 RVA: 0x000169C3 File Offset: 0x00014BC3
			public _execute_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C58 RID: 3160
			// (get) Token: 0x06002F5B RID: 12123 RVA: 0x000C5D24 File Offset: 0x000C3F24
			// (set) Token: 0x06002F5C RID: 12124 RVA: 0x000169CC File Offset: 0x00014BCC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C59 RID: 3161
			// (get) Token: 0x06002F5D RID: 12125 RVA: 0x000C5D4C File Offset: 0x000C3F4C
			// (set) Token: 0x06002F5E RID: 12126 RVA: 0x000169E7 File Offset: 0x00014BE7
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C5A RID: 3162
			// (get) Token: 0x06002F5F RID: 12127 RVA: 0x000C5D7C File Offset: 0x000C3F7C
			// (set) Token: 0x06002F60 RID: 12128 RVA: 0x00016A06 File Offset: 0x00014C06
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000C5B RID: 3163
			// (get) Token: 0x06002F61 RID: 12129 RVA: 0x000C5DA4 File Offset: 0x000C3FA4
			// (set) Token: 0x06002F62 RID: 12130 RVA: 0x00016A21 File Offset: 0x00014C21
			public unsafe StateMachineActionV2 __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C5C RID: 3164
			// (get) Token: 0x06002F63 RID: 12131 RVA: 0x000C5DD4 File Offset: 0x000C3FD4
			// (set) Token: 0x06002F64 RID: 12132 RVA: 0x00016A40 File Offset: 0x00014C40
			public Nullable<int> _nextState_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr__nextState_5__2);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr__nextState_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C5D RID: 3165
			// (get) Token: 0x06002F65 RID: 12133 RVA: 0x000C5E04 File Offset: 0x000C4004
			// (set) Token: 0x06002F66 RID: 12134 RVA: 0x00016A6E File Offset: 0x00014C6E
			public unsafe StateMachineActionV2.StateBehavior _behavior_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr__behavior_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2.StateBehavior>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2._execute_d__17.NativeFieldInfoPtr__behavior_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DA0 RID: 7584
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DA1 RID: 7585
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DA2 RID: 7586
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001DA3 RID: 7587
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DA4 RID: 7588
			private static readonly IntPtr NativeFieldInfoPtr__nextState_5__2;

			// Token: 0x04001DA5 RID: 7589
			private static readonly IntPtr NativeFieldInfoPtr__behavior_5__3;

			// Token: 0x04001DA6 RID: 7590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DA7 RID: 7591
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DA8 RID: 7592
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DA9 RID: 7593
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001DAA RID: 7594
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DAB RID: 7595
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DAC RID: 7596
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001DAD RID: 7597
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
