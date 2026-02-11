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
	// Token: 0x020001EE RID: 494
	public class StateMachineAction : Action
	{
		// Token: 0x060014D5 RID: 5333 RVA: 0x0006D3A0 File Offset: 0x0006B5A0
		// Note: this type is marked as 'beforefieldinit'.
		static StateMachineAction()
		{
			Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "StateMachineAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr);
			StateMachineAction.NativeFieldInfoPtr_Advance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, "Advance");
			StateMachineAction.NativeFieldInfoPtr_initialState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, "initialState");
			StateMachineAction.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, "currentState");
			StateMachineAction.NativeFieldInfoPtr_lastAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, "lastAction");
			StateMachineAction.NativeMethodInfoPtr_get_CurrentState_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667907);
			StateMachineAction.NativeMethodInfoPtr_set_CurrentState_Protected_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667908);
			StateMachineAction.NativeMethodInfoPtr_get_InitialState_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667909);
			StateMachineAction.NativeMethodInfoPtr__ctor_Protected_Void_Match_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667910);
			StateMachineAction.NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667911);
			StateMachineAction.NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667912);
			StateMachineAction.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667913);
			StateMachineAction.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667914);
			StateMachineAction.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667915);
			StateMachineAction.NativeMethodInfoPtr_InitializeFromSerialized_Public_Virtual_New_Void_SerializedStateMachineAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667916);
			StateMachineAction.NativeMethodInfoPtr_DetermineNextState_Protected_Abstract_Virtual_New_Nullable_1_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667917);
			StateMachineAction.NativeMethodInfoPtr_BehaviorFor_Protected_Abstract_Virtual_New_StateBehavior_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667918);
			StateMachineAction.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Abstract_Virtual_New_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, 100667919);
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0006D524 File Offset: 0x0006B724
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x0006D56C File Offset: 0x0006B76C
		public unsafe virtual int CurrentState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction.NativeMethodInfoPtr_get_CurrentState_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction.NativeMethodInfoPtr_set_CurrentState_Protected_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0006D5B8 File Offset: 0x0006B7B8
		public unsafe int InitialState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.NativeMethodInfoPtr_get_InitialState_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0006D5F4 File Offset: 0x0006B7F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 590164, RefRangeEnd = 590167, XrefRangeStart = 590157, XrefRangeEnd = 590164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineAction(Match m, int initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.NativeMethodInfoPtr__ctor_Protected_Void_Match_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0006D650 File Offset: 0x0006B850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 590175, RefRangeEnd = 590176, XrefRangeStart = 590167, XrefRangeEnd = 590175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineAction(Match m, SerializedStateMachineAction serialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0006D6B0 File Offset: 0x0006B8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590176, XrefRangeEnd = 590182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0006D6F0 File Offset: 0x0006B8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590182, XrefRangeEnd = 590183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0006D72C File Offset: 0x0006B92C
		[CallerCount(0)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0006D77C File Offset: 0x0006B97C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0006D7CC File Offset: 0x0006B9CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 590183, RefRangeEnd = 590184, XrefRangeStart = 590183, XrefRangeEnd = 590183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeFromSerialized(SerializedStateMachineAction serialized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction.NativeMethodInfoPtr_InitializeFromSerialized_Public_Virtual_New_Void_SerializedStateMachineAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0006D81C File Offset: 0x0006BA1C
		[CallerCount(0)]
		public unsafe virtual Nullable<int> DetermineNextState(Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction.NativeMethodInfoPtr_DetermineNextState_Protected_Abstract_Virtual_New_Nullable_1_Int32_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0006D870 File Offset: 0x0006BA70
		[CallerCount(0)]
		public unsafe virtual StateMachineAction.StateBehavior BehaviorFor(int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction.NativeMethodInfoPtr_BehaviorFor_Protected_Abstract_Virtual_New_StateBehavior_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0006D8C8 File Offset: 0x0006BAC8
		[CallerCount(0)]
		public unsafe virtual SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Abstract_Virtual_New_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0000A20B File Offset: 0x0000840B
		public StateMachineAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x0006D924 File Offset: 0x0006BB24
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x0000A214 File Offset: 0x00008414
		public unsafe StateMachineAction.AdvanceStateMachine Advance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.NativeFieldInfoPtr_Advance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineAction.AdvanceStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.NativeFieldInfoPtr_Advance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0006D954 File Offset: 0x0006BB54
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x0000A233 File Offset: 0x00008433
		public unsafe int initialState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.NativeFieldInfoPtr_initialState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.NativeFieldInfoPtr_initialState)) = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0006D97C File Offset: 0x0006BB7C
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x0000A24E File Offset: 0x0000844E
		public unsafe int currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x0006D9A4 File Offset: 0x0006BBA4
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x0000A269 File Offset: 0x00008469
		public unsafe Action lastAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.NativeFieldInfoPtr_lastAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.NativeFieldInfoPtr_lastAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeFieldInfoPtr_Advance;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeFieldInfoPtr_initialState;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeFieldInfoPtr_lastAction;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Protected_Virtual_New_get_Int32_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentState_Protected_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialState_Public_get_Int32_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_Int32_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineAction_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_Final_SerializedAction_Match_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFromSerialized_Public_Virtual_New_Void_SerializedStateMachineAction_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextState_Protected_Abstract_Virtual_New_Nullable_1_Int32_Action_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_BehaviorFor_Protected_Abstract_Virtual_New_StateBehavior_Int32_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Abstract_Virtual_New_SerializedStateMachineAction_Match_0;

		// Token: 0x0200042B RID: 1067
		public class AdvanceStateMachine : Action
		{
			// Token: 0x06002F04 RID: 12036 RVA: 0x000C4AAC File Offset: 0x000C2CAC
			// Note: this type is marked as 'beforefieldinit'.
			static AdvanceStateMachine()
			{
				Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, "AdvanceStateMachine");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine>.NativeClassPtr);
				StateMachineAction.AdvanceStateMachine.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine>.NativeClassPtr, 100667920);
				StateMachineAction.AdvanceStateMachine.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine>.NativeClassPtr, 100667921);
			}

			// Token: 0x06002F05 RID: 12037 RVA: 0x000C4B00 File Offset: 0x000C2D00
			[CallerCount(191)]
			[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdvanceStateMachine(Match m)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.AdvanceStateMachine.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F06 RID: 12038 RVA: 0x000C4B4C File Offset: 0x000C2D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590035, XrefRangeEnd = 590040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Action> execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction.AdvanceStateMachine.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}

			// Token: 0x06002F07 RID: 12039 RVA: 0x000167C0 File Offset: 0x000149C0
			public AdvanceStateMachine(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001D78 RID: 7544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

			// Token: 0x04001D79 RID: 7545
			private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

			// Token: 0x0200048F RID: 1167
			[ObfuscatedName("Canis.actions.StateMachineAction+AdvanceStateMachine+<execute>d__1")]
			public sealed class _execute_d__1 : Object
			{
				// Token: 0x06003524 RID: 13604 RVA: 0x000D74DC File Offset: 0x000D56DC
				// Note: this type is marked as 'beforefieldinit'.
				static _execute_d__1()
				{
					Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine>.NativeClassPtr, "<execute>d__1");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr);
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, "<>1__state");
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, "<>2__current");
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, "<>l__initialThreadId");
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667922);
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667923);
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667924);
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667925);
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667926);
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667927);
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667928);
					StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr, 100667929);
				}

				// Token: 0x06003525 RID: 13605 RVA: 0x000D75E4 File Offset: 0x000D57E4
				[CallerCount(126)]
				[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _execute_d__1(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAction.AdvanceStateMachine._execute_d__1>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06003526 RID: 13606 RVA: 0x000D762C File Offset: 0x000D582C
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003527 RID: 13607 RVA: 0x000D7660 File Offset: 0x000D5860
				[CallerCount(0)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000E4A RID: 3658
				// (get) Token: 0x06003528 RID: 13608 RVA: 0x000D769C File Offset: 0x000D589C
				public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
					}
				}

				// Token: 0x06003529 RID: 13609 RVA: 0x000D76DC File Offset: 0x000D58DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590028, XrefRangeEnd = 590033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000E4B RID: 3659
				// (get) Token: 0x0600352A RID: 13610 RVA: 0x000D7710 File Offset: 0x000D5910
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600352B RID: 13611 RVA: 0x000D7750 File Offset: 0x000D5950
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590033, XrefRangeEnd = 590035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
				}

				// Token: 0x0600352C RID: 13612 RVA: 0x000D7790 File Offset: 0x000D5990
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x0600352D RID: 13613 RVA: 0x00019BAF File Offset: 0x00017DAF
				public _execute_d__1(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000E47 RID: 3655
				// (get) Token: 0x0600352E RID: 13614 RVA: 0x000D77D0 File Offset: 0x000D59D0
				// (set) Token: 0x0600352F RID: 13615 RVA: 0x00019BB8 File Offset: 0x00017DB8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000E48 RID: 3656
				// (get) Token: 0x06003530 RID: 13616 RVA: 0x000D77F8 File Offset: 0x000D59F8
				// (set) Token: 0x06003531 RID: 13617 RVA: 0x00019BD3 File Offset: 0x00017DD3
				public unsafe Action __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E49 RID: 3657
				// (get) Token: 0x06003532 RID: 13618 RVA: 0x000D7828 File Offset: 0x000D5A28
				// (set) Token: 0x06003533 RID: 13619 RVA: 0x00019BF2 File Offset: 0x00017DF2
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.AdvanceStateMachine._execute_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x04002127 RID: 8487
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04002128 RID: 8488
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04002129 RID: 8489
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x0400212A RID: 8490
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400212B RID: 8491
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400212C RID: 8492
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400212D RID: 8493
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

				// Token: 0x0400212E RID: 8494
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400212F RID: 8495
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04002130 RID: 8496
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

				// Token: 0x04002131 RID: 8497
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}

		// Token: 0x0200042C RID: 1068
		public class BroadcastStateChange : Action
		{
			// Token: 0x06002F08 RID: 12040 RVA: 0x000C4B98 File Offset: 0x000C2D98
			// Note: this type is marked as 'beforefieldinit'.
			static BroadcastStateChange()
			{
				Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, "BroadcastStateChange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange>.NativeClassPtr);
				StateMachineAction.BroadcastStateChange.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange>.NativeClassPtr, "attribute");
				StateMachineAction.BroadcastStateChange.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange>.NativeClassPtr, 100667930);
				StateMachineAction.BroadcastStateChange.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange>.NativeClassPtr, 100667931);
			}

			// Token: 0x06002F09 RID: 12041 RVA: 0x000C4C00 File Offset: 0x000C2E00
			[CallerCount(106)]
			[CachedScanResults(RefRangeStart = 139275, RefRangeEnd = 139381, XrefRangeStart = 139275, XrefRangeEnd = 139381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BroadcastStateChange(IAttribute attribute, Match m)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.BroadcastStateChange.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F0A RID: 12042 RVA: 0x000C4C60 File Offset: 0x000C2E60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590083, XrefRangeEnd = 590089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Action> execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction.BroadcastStateChange.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}

			// Token: 0x06002F0B RID: 12043 RVA: 0x000167C9 File Offset: 0x000149C9
			public BroadcastStateChange(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C4C RID: 3148
			// (get) Token: 0x06002F0C RID: 12044 RVA: 0x000C4CAC File Offset: 0x000C2EAC
			// (set) Token: 0x06002F0D RID: 12045 RVA: 0x000167D2 File Offset: 0x000149D2
			public unsafe IAttribute attribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.BroadcastStateChange.NativeFieldInfoPtr_attribute);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.BroadcastStateChange.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D7A RID: 7546
			private static readonly IntPtr NativeFieldInfoPtr_attribute;

			// Token: 0x04001D7B RID: 7547
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_Match_0;

			// Token: 0x04001D7C RID: 7548
			private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

			// Token: 0x02000490 RID: 1168
			[ObfuscatedName("Canis.actions.StateMachineAction+BroadcastStateChange+<execute>d__2")]
			public sealed class _execute_d__2 : Object
			{
				// Token: 0x06003534 RID: 13620 RVA: 0x000D7850 File Offset: 0x000D5A50
				// Note: this type is marked as 'beforefieldinit'.
				static _execute_d__2()
				{
					Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange>.NativeClassPtr, "<execute>d__2");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr);
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, "<>1__state");
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, "<>2__current");
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, "<>4__this");
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667932);
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667933);
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667934);
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667935);
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667936);
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667937);
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667938);
					StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr, 100667939);
				}

				// Token: 0x06003535 RID: 13621 RVA: 0x000D796C File Offset: 0x000D5B6C
				[CallerCount(126)]
				[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _execute_d__2(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAction.BroadcastStateChange._execute_d__2>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06003536 RID: 13622 RVA: 0x000D79B4 File Offset: 0x000D5BB4
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003537 RID: 13623 RVA: 0x000D79E8 File Offset: 0x000D5BE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590040, XrefRangeEnd = 590076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000E50 RID: 3664
				// (get) Token: 0x06003538 RID: 13624 RVA: 0x000D7A24 File Offset: 0x000D5C24
				public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
					}
				}

				// Token: 0x06003539 RID: 13625 RVA: 0x000D7A64 File Offset: 0x000D5C64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590076, XrefRangeEnd = 590081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000E51 RID: 3665
				// (get) Token: 0x0600353A RID: 13626 RVA: 0x000D7A98 File Offset: 0x000D5C98
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600353B RID: 13627 RVA: 0x000D7AD8 File Offset: 0x000D5CD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590081, XrefRangeEnd = 590083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
				}

				// Token: 0x0600353C RID: 13628 RVA: 0x000D7B18 File Offset: 0x000D5D18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.BroadcastStateChange._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x0600353D RID: 13629 RVA: 0x00019C0D File Offset: 0x00017E0D
				public _execute_d__2(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000E4C RID: 3660
				// (get) Token: 0x0600353E RID: 13630 RVA: 0x000D7B58 File Offset: 0x000D5D58
				// (set) Token: 0x0600353F RID: 13631 RVA: 0x00019C16 File Offset: 0x00017E16
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000E4D RID: 3661
				// (get) Token: 0x06003540 RID: 13632 RVA: 0x000D7B80 File Offset: 0x000D5D80
				// (set) Token: 0x06003541 RID: 13633 RVA: 0x00019C31 File Offset: 0x00017E31
				public unsafe Action __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E4E RID: 3662
				// (get) Token: 0x06003542 RID: 13634 RVA: 0x000D7BB0 File Offset: 0x000D5DB0
				// (set) Token: 0x06003543 RID: 13635 RVA: 0x00019C50 File Offset: 0x00017E50
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x17000E4F RID: 3663
				// (get) Token: 0x06003544 RID: 13636 RVA: 0x000D7BD8 File Offset: 0x000D5DD8
				// (set) Token: 0x06003545 RID: 13637 RVA: 0x00019C6B File Offset: 0x00017E6B
				public unsafe StateMachineAction.BroadcastStateChange __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineAction.BroadcastStateChange>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction.BroadcastStateChange._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002132 RID: 8498
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04002133 RID: 8499
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04002134 RID: 8500
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x04002135 RID: 8501
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04002136 RID: 8502
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04002137 RID: 8503
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04002138 RID: 8504
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04002139 RID: 8505
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

				// Token: 0x0400213A RID: 8506
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400213B RID: 8507
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400213C RID: 8508
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

				// Token: 0x0400213D RID: 8509
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}

		// Token: 0x0200042D RID: 1069
		public sealed class StateBehavior : MulticastDelegate
		{
			// Token: 0x06002F0E RID: 12046 RVA: 0x000C4CDC File Offset: 0x000C2EDC
			// Note: this type is marked as 'beforefieldinit'.
			static StateBehavior()
			{
				Il2CppClassPointerStore<StateMachineAction.StateBehavior>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, "StateBehavior");
				StateMachineAction.StateBehavior.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.StateBehavior>.NativeClassPtr, 100667940);
				StateMachineAction.StateBehavior.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.StateBehavior>.NativeClassPtr, 100667941);
				StateMachineAction.StateBehavior.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.StateBehavior>.NativeClassPtr, 100667942);
				StateMachineAction.StateBehavior.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_Action_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction.StateBehavior>.NativeClassPtr, 100667943);
			}

			// Token: 0x06002F0F RID: 12047 RVA: 0x000C4D50 File Offset: 0x000C2F50
			[CallerCount(210)]
			[CachedScanResults(RefRangeStart = 320759, RefRangeEnd = 320969, XrefRangeStart = 320759, XrefRangeEnd = 320969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateBehavior(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAction.StateBehavior>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.StateBehavior.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F10 RID: 12048 RVA: 0x000C4DAC File Offset: 0x000C2FAC
			[CallerCount(0)]
			public unsafe IEnumerable<Action> Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.StateBehavior.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}

			// Token: 0x06002F11 RID: 12049 RVA: 0x000C4DEC File Offset: 0x000C2FEC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.StateBehavior.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F12 RID: 12050 RVA: 0x000C4E50 File Offset: 0x000C3050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Action> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction.StateBehavior.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_Action_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
				}
			}

			// Token: 0x06002F13 RID: 12051 RVA: 0x000167F1 File Offset: 0x000149F1
			public StateBehavior(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F14 RID: 12052 RVA: 0x000167FA File Offset: 0x000149FA
			public static implicit operator StateMachineAction.StateBehavior(Func<IEnumerable<Action>> A_0)
			{
				return DelegateSupport.ConvertDelegate<StateMachineAction.StateBehavior>(A_0);
			}

			// Token: 0x06002F15 RID: 12053 RVA: 0x00016802 File Offset: 0x00014A02
			public static StateMachineAction.StateBehavior operator +(StateMachineAction.StateBehavior A_0, StateMachineAction.StateBehavior A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StateMachineAction.StateBehavior>();
			}

			// Token: 0x06002F16 RID: 12054 RVA: 0x00016810 File Offset: 0x00014A10
			public static StateMachineAction.StateBehavior operator -(StateMachineAction.StateBehavior A_0, StateMachineAction.StateBehavior A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StateMachineAction.StateBehavior>();
				}
				return delegate2;
			}

			// Token: 0x04001D7D RID: 7549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001D7E RID: 7550
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_Action_0;

			// Token: 0x04001D7F RID: 7551
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001D80 RID: 7552
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_Action_IAsyncResult_0;
		}

		// Token: 0x0200042E RID: 1070
		[ObfuscatedName("Canis.actions.StateMachineAction+<execute>d__14")]
		public sealed class _execute_d__14 : Object
		{
			// Token: 0x06002F17 RID: 12055 RVA: 0x000C4EA0 File Offset: 0x000C30A0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__14()
			{
				Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineAction>.NativeClassPtr, "<execute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr);
				StateMachineAction._execute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, "<>1__state");
				StateMachineAction._execute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, "<>2__current");
				StateMachineAction._execute_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, "<>l__initialThreadId");
				StateMachineAction._execute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, "<>4__this");
				StateMachineAction._execute_d__14.NativeFieldInfoPtr__nextState_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, "<nextState>5__2");
				StateMachineAction._execute_d__14.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, "<>7__wrap2");
				StateMachineAction._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, 100667944);
				StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, 100667945);
				StateMachineAction._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, 100667946);
				StateMachineAction._execute_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, 100667947);
				StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, 100667948);
				StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, 100667949);
				StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, 100667950);
				StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, 100667951);
				StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr, 100667952);
			}

			// Token: 0x06002F18 RID: 12056 RVA: 0x000C4FF8 File Offset: 0x000C31F8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAction._execute_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F19 RID: 12057 RVA: 0x000C5040 File Offset: 0x000C3240
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 590094, RefRangeEnd = 590095, XrefRangeStart = 590089, XrefRangeEnd = 590094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F1A RID: 12058 RVA: 0x000C5074 File Offset: 0x000C3274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590095, XrefRangeEnd = 590147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F1B RID: 12059 RVA: 0x000C50B0 File Offset: 0x000C32B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590147, XrefRangeEnd = 590150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction._execute_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C53 RID: 3155
			// (get) Token: 0x06002F1C RID: 12060 RVA: 0x000C50E4 File Offset: 0x000C32E4
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002F1D RID: 12061 RVA: 0x000C5124 File Offset: 0x000C3324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590150, XrefRangeEnd = 590155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C54 RID: 3156
			// (get) Token: 0x06002F1E RID: 12062 RVA: 0x000C5158 File Offset: 0x000C3358
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F1F RID: 12063 RVA: 0x000C5198 File Offset: 0x000C3398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590155, XrefRangeEnd = 590157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002F20 RID: 12064 RVA: 0x000C51D8 File Offset: 0x000C33D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002F21 RID: 12065 RVA: 0x00016821 File Offset: 0x00014A21
			public _execute_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C4D RID: 3149
			// (get) Token: 0x06002F22 RID: 12066 RVA: 0x000C5218 File Offset: 0x000C3418
			// (set) Token: 0x06002F23 RID: 12067 RVA: 0x0001682A File Offset: 0x00014A2A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C4E RID: 3150
			// (get) Token: 0x06002F24 RID: 12068 RVA: 0x000C5240 File Offset: 0x000C3440
			// (set) Token: 0x06002F25 RID: 12069 RVA: 0x00016845 File Offset: 0x00014A45
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C4F RID: 3151
			// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000C5270 File Offset: 0x000C3470
			// (set) Token: 0x06002F27 RID: 12071 RVA: 0x00016864 File Offset: 0x00014A64
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000C50 RID: 3152
			// (get) Token: 0x06002F28 RID: 12072 RVA: 0x000C5298 File Offset: 0x000C3498
			// (set) Token: 0x06002F29 RID: 12073 RVA: 0x0001687F File Offset: 0x00014A7F
			public unsafe StateMachineAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C51 RID: 3153
			// (get) Token: 0x06002F2A RID: 12074 RVA: 0x000C52C8 File Offset: 0x000C34C8
			// (set) Token: 0x06002F2B RID: 12075 RVA: 0x0001689E File Offset: 0x00014A9E
			public Nullable<int> _nextState_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr__nextState_5__2);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr__nextState_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C52 RID: 3154
			// (get) Token: 0x06002F2C RID: 12076 RVA: 0x000C52F8 File Offset: 0x000C34F8
			// (set) Token: 0x06002F2D RID: 12077 RVA: 0x000168CC File Offset: 0x00014ACC
			public unsafe IEnumerator<Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineAction._execute_d__14.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D81 RID: 7553
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D82 RID: 7554
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D83 RID: 7555
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001D84 RID: 7556
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D85 RID: 7557
			private static readonly IntPtr NativeFieldInfoPtr__nextState_5__2;

			// Token: 0x04001D86 RID: 7558
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001D87 RID: 7559
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D88 RID: 7560
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D89 RID: 7561
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D8A RID: 7562
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001D8B RID: 7563
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001D8C RID: 7564
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D8D RID: 7565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D8E RID: 7566
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001D8F RID: 7567
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
