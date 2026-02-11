using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002BA RID: 698
	public class DeckSetupPhase : StateMachineAction<DeckSetupState>
	{
		// Token: 0x06001CE5 RID: 7397 RVA: 0x000C92F8 File Offset: 0x000C74F8
		// Note: this type is marked as 'beforefieldinit'.
		static DeckSetupPhase()
		{
			Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "DeckSetupPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr);
			DeckSetupPhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, "wormMatch");
			DeckSetupPhase.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, "player");
			DeckSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, 100669429);
			DeckSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedDeckSetupPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, 100669430);
			DeckSetupPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_DeckSetupState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, 100669431);
			DeckSetupPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_DeckSetupState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, 100669432);
			DeckSetupPhase.NativeMethodInfoPtr_BeginDeckSetup_Protected_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, 100669433);
			DeckSetupPhase.NativeMethodInfoPtr_Selection_Protected_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, 100669434);
			DeckSetupPhase.NativeMethodInfoPtr_CompleteDeckSetup_Protected_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, 100669435);
			DeckSetupPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, 100669436);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x000C93F0 File Offset: 0x000C75F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155526, RefRangeEnd = 155528, XrefRangeStart = 155518, XrefRangeEnd = 155526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeckSetupPhase(WormPlayer p, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x000C9450 File Offset: 0x000C7650
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 155546, RefRangeEnd = 155552, XrefRangeStart = 155528, XrefRangeEnd = 155546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeckSetupPhase(SerializedDeckSetupPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedDeckSetupPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x000C94B0 File Offset: 0x000C76B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155552, XrefRangeEnd = 155558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<DeckSetupState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeckSetupPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_DeckSetupState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DeckSetupState>(intPtr);
			}
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000C9504 File Offset: 0x000C7704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155558, XrefRangeEnd = 155562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(DeckSetupState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeckSetupPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_DeckSetupState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x000C955C File Offset: 0x000C775C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155562, XrefRangeEnd = 155568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> BeginDeckSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeckSetupPhase.NativeMethodInfoPtr_BeginDeckSetup_Protected_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x000C95A8 File Offset: 0x000C77A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155568, XrefRangeEnd = 155574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> Selection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeckSetupPhase.NativeMethodInfoPtr_Selection_Protected_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x000C95F4 File Offset: 0x000C77F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155574, XrefRangeEnd = 155580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> CompleteDeckSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeckSetupPhase.NativeMethodInfoPtr_CompleteDeckSetup_Protected_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000C9640 File Offset: 0x000C7840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155580, XrefRangeEnd = 155585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeckSetupPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0000C42B File Offset: 0x0000A62B
		public DeckSetupPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x000C969C File Offset: 0x000C789C
		// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x0000C434 File Offset: 0x0000A634
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x000C96CC File Offset: 0x000C78CC
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0000C453 File Offset: 0x0000A653
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedDeckSetupPhase_WormMatch_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_DeckSetupState_Action_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_DeckSetupState_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_BeginDeckSetup_Protected_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_Selection_Protected_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDeckSetup_Protected_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x02000720 RID: 1824
		[ObfuscatedName("worm.canis.actions.phases.DeckSetupPhase+<BeginDeckSetup>d__6")]
		public sealed class _BeginDeckSetup_d__6 : Object
		{
			// Token: 0x06006417 RID: 25623 RVA: 0x001E4C9C File Offset: 0x001E2E9C
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginDeckSetup_d__6()
			{
				Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, "<BeginDeckSetup>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr);
				DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, "<>1__state");
				DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, "<>2__current");
				DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, "<>l__initialThreadId");
				DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, "<>4__this");
				DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, 100669437);
				DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, 100669438);
				DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, 100669439);
				DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, 100669440);
				DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, 100669441);
				DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, 100669442);
				DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, 100669443);
				DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr, 100669444);
			}

			// Token: 0x06006418 RID: 25624 RVA: 0x001E4DB8 File Offset: 0x001E2FB8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginDeckSetup_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckSetupPhase._BeginDeckSetup_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006419 RID: 25625 RVA: 0x001E4E00 File Offset: 0x001E3000
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600641A RID: 25626 RVA: 0x001E4E34 File Offset: 0x001E3034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001AD1 RID: 6865
			// (get) Token: 0x0600641B RID: 25627 RVA: 0x001E4E70 File Offset: 0x001E3070
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600641C RID: 25628 RVA: 0x001E4EB0 File Offset: 0x001E30B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155497, XrefRangeEnd = 155502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AD2 RID: 6866
			// (get) Token: 0x0600641D RID: 25629 RVA: 0x001E4EE4 File Offset: 0x001E30E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600641E RID: 25630 RVA: 0x001E4F24 File Offset: 0x001E3124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155502, XrefRangeEnd = 155504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600641F RID: 25631 RVA: 0x001E4F64 File Offset: 0x001E3164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._BeginDeckSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006420 RID: 25632 RVA: 0x00026C14 File Offset: 0x00024E14
			public _BeginDeckSetup_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ACD RID: 6861
			// (get) Token: 0x06006421 RID: 25633 RVA: 0x001E4FA4 File Offset: 0x001E31A4
			// (set) Token: 0x06006422 RID: 25634 RVA: 0x00026C1D File Offset: 0x00024E1D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001ACE RID: 6862
			// (get) Token: 0x06006423 RID: 25635 RVA: 0x001E4FCC File Offset: 0x001E31CC
			// (set) Token: 0x06006424 RID: 25636 RVA: 0x00026C38 File Offset: 0x00024E38
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ACF RID: 6863
			// (get) Token: 0x06006425 RID: 25637 RVA: 0x001E4FFC File Offset: 0x001E31FC
			// (set) Token: 0x06006426 RID: 25638 RVA: 0x00026C57 File Offset: 0x00024E57
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001AD0 RID: 6864
			// (get) Token: 0x06006427 RID: 25639 RVA: 0x001E5024 File Offset: 0x001E3224
			// (set) Token: 0x06006428 RID: 25640 RVA: 0x00026C72 File Offset: 0x00024E72
			public unsafe DeckSetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeckSetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._BeginDeckSetup_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040CF RID: 16591
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040040D0 RID: 16592
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040040D1 RID: 16593
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040040D2 RID: 16594
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040040D3 RID: 16595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040040D4 RID: 16596
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040D5 RID: 16597
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040040D6 RID: 16598
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040040D7 RID: 16599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040D8 RID: 16600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040040D9 RID: 16601
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040040DA RID: 16602
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000721 RID: 1825
		[ObfuscatedName("worm.canis.actions.phases.DeckSetupPhase+<CompleteDeckSetup>d__8")]
		public sealed class _CompleteDeckSetup_d__8 : Object
		{
			// Token: 0x06006429 RID: 25641 RVA: 0x001E5054 File Offset: 0x001E3254
			// Note: this type is marked as 'beforefieldinit'.
			static _CompleteDeckSetup_d__8()
			{
				Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, "<CompleteDeckSetup>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr);
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, "<>1__state");
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, "<>2__current");
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, "<>l__initialThreadId");
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, "<>4__this");
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, 100669445);
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, 100669446);
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, 100669447);
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, 100669448);
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, 100669449);
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, 100669450);
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, 100669451);
				DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr, 100669452);
			}

			// Token: 0x0600642A RID: 25642 RVA: 0x001E5170 File Offset: 0x001E3370
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CompleteDeckSetup_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckSetupPhase._CompleteDeckSetup_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600642B RID: 25643 RVA: 0x001E51B8 File Offset: 0x001E33B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600642C RID: 25644 RVA: 0x001E51EC File Offset: 0x001E33EC
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001AD7 RID: 6871
			// (get) Token: 0x0600642D RID: 25645 RVA: 0x001E5228 File Offset: 0x001E3428
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600642E RID: 25646 RVA: 0x001E5268 File Offset: 0x001E3468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155504, XrefRangeEnd = 155509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001AD8 RID: 6872
			// (get) Token: 0x0600642F RID: 25647 RVA: 0x001E529C File Offset: 0x001E349C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006430 RID: 25648 RVA: 0x001E52DC File Offset: 0x001E34DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155509, XrefRangeEnd = 155511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006431 RID: 25649 RVA: 0x001E531C File Offset: 0x001E351C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._CompleteDeckSetup_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006432 RID: 25650 RVA: 0x00026C91 File Offset: 0x00024E91
			public _CompleteDeckSetup_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AD3 RID: 6867
			// (get) Token: 0x06006433 RID: 25651 RVA: 0x001E535C File Offset: 0x001E355C
			// (set) Token: 0x06006434 RID: 25652 RVA: 0x00026C9A File Offset: 0x00024E9A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AD4 RID: 6868
			// (get) Token: 0x06006435 RID: 25653 RVA: 0x001E5384 File Offset: 0x001E3584
			// (set) Token: 0x06006436 RID: 25654 RVA: 0x00026CB5 File Offset: 0x00024EB5
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AD5 RID: 6869
			// (get) Token: 0x06006437 RID: 25655 RVA: 0x001E53B4 File Offset: 0x001E35B4
			// (set) Token: 0x06006438 RID: 25656 RVA: 0x00026CD4 File Offset: 0x00024ED4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001AD6 RID: 6870
			// (get) Token: 0x06006439 RID: 25657 RVA: 0x001E53DC File Offset: 0x001E35DC
			// (set) Token: 0x0600643A RID: 25658 RVA: 0x00026CEF File Offset: 0x00024EEF
			public unsafe DeckSetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeckSetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._CompleteDeckSetup_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040DB RID: 16603
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040040DC RID: 16604
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040040DD RID: 16605
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040040DE RID: 16606
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040040DF RID: 16607
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040040E0 RID: 16608
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040E1 RID: 16609
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040040E2 RID: 16610
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040040E3 RID: 16611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040E4 RID: 16612
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040040E5 RID: 16613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040040E6 RID: 16614
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000722 RID: 1826
		[ObfuscatedName("worm.canis.actions.phases.DeckSetupPhase+<Selection>d__7")]
		public sealed class _Selection_d__7 : Object
		{
			// Token: 0x0600643B RID: 25659 RVA: 0x001E540C File Offset: 0x001E360C
			// Note: this type is marked as 'beforefieldinit'.
			static _Selection_d__7()
			{
				Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeckSetupPhase>.NativeClassPtr, "<Selection>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr);
				DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, "<>1__state");
				DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, "<>2__current");
				DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, "<>l__initialThreadId");
				DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, "<>4__this");
				DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, 100669453);
				DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, 100669454);
				DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, 100669455);
				DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, 100669456);
				DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, 100669457);
				DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, 100669458);
				DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, 100669459);
				DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr, 100669460);
			}

			// Token: 0x0600643C RID: 25660 RVA: 0x001E5528 File Offset: 0x001E3728
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Selection_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeckSetupPhase._Selection_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600643D RID: 25661 RVA: 0x001E5570 File Offset: 0x001E3770
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600643E RID: 25662 RVA: 0x001E55A4 File Offset: 0x001E37A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001ADD RID: 6877
			// (get) Token: 0x0600643F RID: 25663 RVA: 0x001E55E0 File Offset: 0x001E37E0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006440 RID: 25664 RVA: 0x001E5620 File Offset: 0x001E3820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155511, XrefRangeEnd = 155516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001ADE RID: 6878
			// (get) Token: 0x06006441 RID: 25665 RVA: 0x001E5654 File Offset: 0x001E3854
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006442 RID: 25666 RVA: 0x001E5694 File Offset: 0x001E3894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155516, XrefRangeEnd = 155518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006443 RID: 25667 RVA: 0x001E56D4 File Offset: 0x001E38D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeckSetupPhase._Selection_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006444 RID: 25668 RVA: 0x00026D0E File Offset: 0x00024F0E
			public _Selection_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AD9 RID: 6873
			// (get) Token: 0x06006445 RID: 25669 RVA: 0x001E5714 File Offset: 0x001E3914
			// (set) Token: 0x06006446 RID: 25670 RVA: 0x00026D17 File Offset: 0x00024F17
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001ADA RID: 6874
			// (get) Token: 0x06006447 RID: 25671 RVA: 0x001E573C File Offset: 0x001E393C
			// (set) Token: 0x06006448 RID: 25672 RVA: 0x00026D32 File Offset: 0x00024F32
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ADB RID: 6875
			// (get) Token: 0x06006449 RID: 25673 RVA: 0x001E576C File Offset: 0x001E396C
			// (set) Token: 0x0600644A RID: 25674 RVA: 0x00026D51 File Offset: 0x00024F51
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001ADC RID: 6876
			// (get) Token: 0x0600644B RID: 25675 RVA: 0x001E5794 File Offset: 0x001E3994
			// (set) Token: 0x0600644C RID: 25676 RVA: 0x00026D6C File Offset: 0x00024F6C
			public unsafe DeckSetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeckSetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeckSetupPhase._Selection_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040040E7 RID: 16615
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040040E8 RID: 16616
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040040E9 RID: 16617
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040040EA RID: 16618
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040040EB RID: 16619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040040EC RID: 16620
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040ED RID: 16621
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040040EE RID: 16622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040040EF RID: 16623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040040F0 RID: 16624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040040F1 RID: 16625
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040040F2 RID: 16626
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
