using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages.outgoing;
using Networking.selection.targetresponse;
using worm.canis.abilities;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x0200028E RID: 654
	public class RunCombatSelection : global::Canis.actions.Action
	{
		// Token: 0x06001B56 RID: 6998 RVA: 0x000C31EC File Offset: 0x000C13EC
		// Note: this type is marked as 'beforefieldinit'.
		static RunCombatSelection()
		{
			Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "RunCombatSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr);
			RunCombatSelection.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr, "wormMatch");
			RunCombatSelection.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr, "selectingPlayer");
			RunCombatSelection.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr, 100668709);
			RunCombatSelection.NativeMethodInfoPtr__ctor_Public_Void_SerializedRunCombatSelection_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr, 100668710);
			RunCombatSelection.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr, 100668711);
			RunCombatSelection.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr, 100668712);
			RunCombatSelection.NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr, 100668713);
			RunCombatSelection.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr, 100668714);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x000C32BC File Offset: 0x000C14BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146394, RefRangeEnd = 146397, XrefRangeStart = 146385, XrefRangeEnd = 146394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunCombatSelection(WormPlayer selectingPlayer, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x000C331C File Offset: 0x000C151C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146397, XrefRangeEnd = 146403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunCombatSelection(SerializedRunCombatSelection serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection.NativeMethodInfoPtr__ctor_Public_Void_SerializedRunCombatSelection_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x000C337C File Offset: 0x000C157C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146403, XrefRangeEnd = 146409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunCombatSelection.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x000C33C8 File Offset: 0x000C15C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146409, XrefRangeEnd = 146411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(global::Canis.actions.Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunCombatSelection.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x000C3418 File Offset: 0x000C1618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146411, XrefRangeEnd = 146415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual global::Canis.actions.Action OnSkip(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection.NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x000C3468 File Offset: 0x000C1668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146415, XrefRangeEnd = 146420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunCombatSelection.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0000BAED File Offset: 0x00009CED
		public RunCombatSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x000C34C4 File Offset: 0x000C16C4
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x0000BAF6 File Offset: 0x00009CF6
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x000C34F4 File Offset: 0x000C16F4
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x0000BB15 File Offset: 0x00009D15
		public unsafe WormPlayer selectingPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection.NativeFieldInfoPtr_selectingPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedRunCombatSelection_WormMatch_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006D9 RID: 1753
		[ObfuscatedName("worm.canis.actions.RunCombatSelection+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06005DAD RID: 23981 RVA: 0x001D172C File Offset: 0x001CF92C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<RunCombatSelection.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunCombatSelection.__c__DisplayClass4_0>.NativeClassPtr);
				RunCombatSelection.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				RunCombatSelection.__c__DisplayClass4_0.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection.__c__DisplayClass4_0>.NativeClassPtr, "selection");
				RunCombatSelection.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection.__c__DisplayClass4_0>.NativeClassPtr, 100668715);
				RunCombatSelection.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection.__c__DisplayClass4_0>.NativeClassPtr, 100668716);
				RunCombatSelection.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection.__c__DisplayClass4_0>.NativeClassPtr, 100668717);
				RunCombatSelection.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__2_Internal_String_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection.__c__DisplayClass4_0>.NativeClassPtr, 100668718);
			}

			// Token: 0x06005DAE RID: 23982 RVA: 0x001D17D0 File Offset: 0x001CF9D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCombatSelection.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DAF RID: 23983 RVA: 0x001D180C File Offset: 0x001CFA0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146172, XrefRangeEnd = 146173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__0(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DB0 RID: 23984 RVA: 0x001D185C File Offset: 0x001CFA5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146173, XrefRangeEnd = 146210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__1(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DB1 RID: 23985 RVA: 0x001D18AC File Offset: 0x001CFAAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146210, XrefRangeEnd = 146212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _execute_b__2(TargetResponse tr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection.__c__DisplayClass4_0.NativeMethodInfoPtr__execute_b__2_Internal_String_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005DB2 RID: 23986 RVA: 0x0002335A File Offset: 0x0002155A
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001883 RID: 6275
			// (get) Token: 0x06005DB3 RID: 23987 RVA: 0x001D18F4 File Offset: 0x001CFAF4
			// (set) Token: 0x06005DB4 RID: 23988 RVA: 0x00023363 File Offset: 0x00021563
			public unsafe RunCombatSelection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunCombatSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001884 RID: 6276
			// (get) Token: 0x06005DB5 RID: 23989 RVA: 0x001D1924 File Offset: 0x001CFB24
			// (set) Token: 0x06005DB6 RID: 23990 RVA: 0x00023382 File Offset: 0x00021582
			public unsafe EntityIDTargetResponses selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection.__c__DisplayClass4_0.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityIDTargetResponses>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection.__c__DisplayClass4_0.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CD7 RID: 15575
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CD8 RID: 15576
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x04003CD9 RID: 15577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003CDA RID: 15578
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04003CDB RID: 15579
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04003CDC RID: 15580
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_Internal_String_TargetResponse_0;
		}

		// Token: 0x020006DA RID: 1754
		[ObfuscatedName("worm.canis.actions.RunCombatSelection+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06005DB7 RID: 23991 RVA: 0x001D1954 File Offset: 0x001CFB54
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunCombatSelection>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr);
				RunCombatSelection._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, "<>1__state");
				RunCombatSelection._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, "<>2__current");
				RunCombatSelection._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
				RunCombatSelection._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, "<>4__this");
				RunCombatSelection._execute_d__4.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, "<>8__1");
				RunCombatSelection._execute_d__4.NativeFieldInfoPtr__selectedAbility_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, "<selectedAbility>5__2");
				RunCombatSelection._execute_d__4.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, "<>7__wrap2");
				RunCombatSelection._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, 100668719);
				RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, 100668720);
				RunCombatSelection._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, 100668721);
				RunCombatSelection._execute_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, 100668722);
				RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, 100668723);
				RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, 100668724);
				RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, 100668725);
				RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, 100668726);
				RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr, 100668727);
			}

			// Token: 0x06005DB8 RID: 23992 RVA: 0x001D1AC0 File Offset: 0x001CFCC0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunCombatSelection._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DB9 RID: 23993 RVA: 0x001D1B08 File Offset: 0x001CFD08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146212, XrefRangeEnd = 146217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DBA RID: 23994 RVA: 0x001D1B3C File Offset: 0x001CFD3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146217, XrefRangeEnd = 146375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005DBB RID: 23995 RVA: 0x001D1B78 File Offset: 0x001CFD78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146375, XrefRangeEnd = 146378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection._execute_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700188C RID: 6284
			// (get) Token: 0x06005DBC RID: 23996 RVA: 0x001D1BAC File Offset: 0x001CFDAC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005DBD RID: 23997 RVA: 0x001D1BEC File Offset: 0x001CFDEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146378, XrefRangeEnd = 146383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700188D RID: 6285
			// (get) Token: 0x06005DBE RID: 23998 RVA: 0x001D1C20 File Offset: 0x001CFE20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005DBF RID: 23999 RVA: 0x001D1C60 File Offset: 0x001CFE60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146383, XrefRangeEnd = 146385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005DC0 RID: 24000 RVA: 0x001D1CA0 File Offset: 0x001CFEA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunCombatSelection._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005DC1 RID: 24001 RVA: 0x000233A1 File Offset: 0x000215A1
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001885 RID: 6277
			// (get) Token: 0x06005DC2 RID: 24002 RVA: 0x001D1CE0 File Offset: 0x001CFEE0
			// (set) Token: 0x06005DC3 RID: 24003 RVA: 0x000233AA File Offset: 0x000215AA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001886 RID: 6278
			// (get) Token: 0x06005DC4 RID: 24004 RVA: 0x001D1D08 File Offset: 0x001CFF08
			// (set) Token: 0x06005DC5 RID: 24005 RVA: 0x000233C5 File Offset: 0x000215C5
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001887 RID: 6279
			// (get) Token: 0x06005DC6 RID: 24006 RVA: 0x001D1D38 File Offset: 0x001CFF38
			// (set) Token: 0x06005DC7 RID: 24007 RVA: 0x000233E4 File Offset: 0x000215E4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001888 RID: 6280
			// (get) Token: 0x06005DC8 RID: 24008 RVA: 0x001D1D60 File Offset: 0x001CFF60
			// (set) Token: 0x06005DC9 RID: 24009 RVA: 0x000233FF File Offset: 0x000215FF
			public unsafe RunCombatSelection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunCombatSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001889 RID: 6281
			// (get) Token: 0x06005DCA RID: 24010 RVA: 0x001D1D90 File Offset: 0x001CFF90
			// (set) Token: 0x06005DCB RID: 24011 RVA: 0x0002341E File Offset: 0x0002161E
			public unsafe RunCombatSelection.__c__DisplayClass4_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunCombatSelection.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700188A RID: 6282
			// (get) Token: 0x06005DCC RID: 24012 RVA: 0x001D1DC0 File Offset: 0x001CFFC0
			// (set) Token: 0x06005DCD RID: 24013 RVA: 0x0002343D File Offset: 0x0002163D
			public unsafe WormAbilityDefinition _selectedAbility_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr__selectedAbility_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr__selectedAbility_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700188B RID: 6283
			// (get) Token: 0x06005DCE RID: 24014 RVA: 0x001D1DF0 File Offset: 0x001CFFF0
			// (set) Token: 0x06005DCF RID: 24015 RVA: 0x0002345C File Offset: 0x0002165C
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunCombatSelection._execute_d__4.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CDD RID: 15581
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CDE RID: 15582
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CDF RID: 15583
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003CE0 RID: 15584
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CE1 RID: 15585
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003CE2 RID: 15586
			private static readonly IntPtr NativeFieldInfoPtr__selectedAbility_5__2;

			// Token: 0x04003CE3 RID: 15587
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04003CE4 RID: 15588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CE5 RID: 15589
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CE6 RID: 15590
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CE7 RID: 15591
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003CE8 RID: 15592
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003CE9 RID: 15593
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CEA RID: 15594
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CEB RID: 15595
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003CEC RID: 15596
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
