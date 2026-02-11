using System;
using Canis.actions.serialized;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001D9 RID: 473
	public class TargetAccumulator : Action
	{
		// Token: 0x06001412 RID: 5138 RVA: 0x0006A568 File Offset: 0x00068768
		// Note: this type is marked as 'beforefieldinit'.
		static TargetAccumulator()
		{
			Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "TargetAccumulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr);
			TargetAccumulator.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr, "player");
			TargetAccumulator.NativeFieldInfoPtr_abilityToRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr, "abilityToRun");
			TargetAccumulator.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr, "activeAbility");
			TargetAccumulator.NativeMethodInfoPtr__ctor_Public_Void_PlayerEntity_IAbilityStateMachineDefinition_ActiveAbility_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr, 100667707);
			TargetAccumulator.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr, 100667708);
			TargetAccumulator.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr, 100667709);
			TargetAccumulator.NativeMethodInfoPtr_Deserialize_Public_Static_TargetAccumulator_Match_SerializedTargetAccumulator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr, 100667710);
			TargetAccumulator.NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr, 100667711);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0006A638 File Offset: 0x00068838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 588561, RefRangeEnd = 588562, XrefRangeStart = 588557, XrefRangeEnd = 588561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetAccumulator(PlayerEntity player, IAbilityStateMachineDefinition abilityToRun, ActiveAbility activeAbility, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilityToRun);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator.NativeMethodInfoPtr__ctor_Public_Void_PlayerEntity_IAbilityStateMachineDefinition_ActiveAbility_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0006A6BC File Offset: 0x000688BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588562, XrefRangeEnd = 588568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetAccumulator.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0006A708 File Offset: 0x00068908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588568, XrefRangeEnd = 588578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetAccumulator.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0006A764 File Offset: 0x00068964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 588601, RefRangeEnd = 588602, XrefRangeStart = 588578, XrefRangeEnd = 588601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TargetAccumulator Deserialize(Match match, SerializedTargetAccumulator serialized)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator.NativeMethodInfoPtr_Deserialize_Public_Static_TargetAccumulator_Match_SerializedTargetAccumulator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetAccumulator>(intPtr3) : null;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0006A7BC File Offset: 0x000689BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588602, XrefRangeEnd = 588607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action OnSkip(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator.NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00009C9E File Offset: 0x00007E9E
		public TargetAccumulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x0006A80C File Offset: 0x00068A0C
		// (set) Token: 0x0600141A RID: 5146 RVA: 0x00009CA7 File Offset: 0x00007EA7
		public unsafe PlayerEntity player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x0006A83C File Offset: 0x00068A3C
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x00009CC6 File Offset: 0x00007EC6
		public unsafe IAbilityStateMachineDefinition abilityToRun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator.NativeFieldInfoPtr_abilityToRun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAbilityStateMachineDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator.NativeFieldInfoPtr_abilityToRun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x0006A86C File Offset: 0x00068A6C
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x00009CE5 File Offset: 0x00007EE5
		public unsafe ActiveAbility activeAbility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator.NativeFieldInfoPtr_activeAbility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActiveAbility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeFieldInfoPtr_abilityToRun;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerEntity_IAbilityStateMachineDefinition_ActiveAbility_Match_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_TargetAccumulator_Match_SerializedTargetAccumulator_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0;

		// Token: 0x02000416 RID: 1046
		[ObfuscatedName("Canis.actions.TargetAccumulator+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06002DCD RID: 11725 RVA: 0x000C0C7C File Offset: 0x000BEE7C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetAccumulator>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr);
				TargetAccumulator._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, "<>1__state");
				TargetAccumulator._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, "<>2__current");
				TargetAccumulator._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
				TargetAccumulator._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, "<>4__this");
				TargetAccumulator._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, 100667712);
				TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, 100667713);
				TargetAccumulator._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, 100667714);
				TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, 100667715);
				TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, 100667716);
				TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, 100667717);
				TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, 100667718);
				TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr, 100667719);
			}

			// Token: 0x06002DCE RID: 11726 RVA: 0x000C0D98 File Offset: 0x000BEF98
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetAccumulator._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002DCF RID: 11727 RVA: 0x000C0DE0 File Offset: 0x000BEFE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DD0 RID: 11728 RVA: 0x000C0E14 File Offset: 0x000BF014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588536, XrefRangeEnd = 588550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BE9 RID: 3049
			// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x000C0E50 File Offset: 0x000BF050
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002DD2 RID: 11730 RVA: 0x000C0E90 File Offset: 0x000BF090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588550, XrefRangeEnd = 588555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BEA RID: 3050
			// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x000C0EC4 File Offset: 0x000BF0C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002DD4 RID: 11732 RVA: 0x000C0F04 File Offset: 0x000BF104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588555, XrefRangeEnd = 588557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002DD5 RID: 11733 RVA: 0x000C0F44 File Offset: 0x000BF144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetAccumulator._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002DD6 RID: 11734 RVA: 0x00015EC7 File Offset: 0x000140C7
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BE5 RID: 3045
			// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x000C0F84 File Offset: 0x000BF184
			// (set) Token: 0x06002DD8 RID: 11736 RVA: 0x00015ED0 File Offset: 0x000140D0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BE6 RID: 3046
			// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x000C0FAC File Offset: 0x000BF1AC
			// (set) Token: 0x06002DDA RID: 11738 RVA: 0x00015EEB File Offset: 0x000140EB
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE7 RID: 3047
			// (get) Token: 0x06002DDB RID: 11739 RVA: 0x000C0FDC File Offset: 0x000BF1DC
			// (set) Token: 0x06002DDC RID: 11740 RVA: 0x00015F0A File Offset: 0x0001410A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000BE8 RID: 3048
			// (get) Token: 0x06002DDD RID: 11741 RVA: 0x000C1004 File Offset: 0x000BF204
			// (set) Token: 0x06002DDE RID: 11742 RVA: 0x00015F25 File Offset: 0x00014125
			public unsafe TargetAccumulator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetAccumulator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetAccumulator._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CB0 RID: 7344
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CB1 RID: 7345
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CB2 RID: 7346
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001CB3 RID: 7347
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CB4 RID: 7348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CB5 RID: 7349
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CB6 RID: 7350
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CB7 RID: 7351
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001CB8 RID: 7352
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CB9 RID: 7353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CBA RID: 7354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001CBB RID: 7355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
