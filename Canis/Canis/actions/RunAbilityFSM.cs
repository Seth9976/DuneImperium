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
	// Token: 0x020001CF RID: 463
	public class RunAbilityFSM : Action
	{
		// Token: 0x06001376 RID: 4982 RVA: 0x00068348 File Offset: 0x00066548
		// Note: this type is marked as 'beforefieldinit'.
		static RunAbilityFSM()
		{
			Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "RunAbilityFSM");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr);
			RunAbilityFSM.NativeFieldInfoPtr_runCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr, "runCost");
			RunAbilityFSM.NativeFieldInfoPtr__SelectedAbility_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr, "<SelectedAbility>k__BackingField");
			RunAbilityFSM.NativeFieldInfoPtr_currentSubState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr, "currentSubState");
			RunAbilityFSM.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr, 100667539);
			RunAbilityFSM.NativeMethodInfoPtr_get_SelectedAbility_Public_get_IAbilityStateMachineDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr, 100667540);
			RunAbilityFSM.NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_IAbilityStateMachineDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr, 100667541);
			RunAbilityFSM.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr, 100667542);
			RunAbilityFSM.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr, 100667543);
			RunAbilityFSM.NativeMethodInfoPtr_Deserialize_Public_Static_RunAbilityFSM_Match_SerializedRunAbilityFSM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr, 100667544);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0006842C File Offset: 0x0006662C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587148, XrefRangeEnd = 587149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunAbilityFSM(Match m, bool runCost = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref runCost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM.NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00068488 File Offset: 0x00066688
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x000684C8 File Offset: 0x000666C8
		public unsafe IAbilityStateMachineDefinition SelectedAbility
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM.NativeMethodInfoPtr_get_SelectedAbility_Public_get_IAbilityStateMachineDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAbilityStateMachineDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM.NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_IAbilityStateMachineDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0006850C File Offset: 0x0006670C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587149, XrefRangeEnd = 587155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunAbilityFSM.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00068558 File Offset: 0x00066758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587155, XrefRangeEnd = 587170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunAbilityFSM.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x000685B4 File Offset: 0x000667B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587170, XrefRangeEnd = 587191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RunAbilityFSM Deserialize(Match match, SerializedRunAbilityFSM serialized)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM.NativeMethodInfoPtr_Deserialize_Public_Static_RunAbilityFSM_Match_SerializedRunAbilityFSM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunAbilityFSM>(intPtr3) : null;
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00009803 File Offset: 0x00007A03
		public RunAbilityFSM(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x0006860C File Offset: 0x0006680C
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x0000980C File Offset: 0x00007A0C
		public unsafe bool runCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM.NativeFieldInfoPtr_runCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM.NativeFieldInfoPtr_runCost)) = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x00068634 File Offset: 0x00066834
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x00009827 File Offset: 0x00007A27
		public unsafe IAbilityStateMachineDefinition _SelectedAbility_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM.NativeFieldInfoPtr__SelectedAbility_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAbilityStateMachineDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM.NativeFieldInfoPtr__SelectedAbility_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x00068664 File Offset: 0x00066864
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x00009846 File Offset: 0x00007A46
		public unsafe RunAbilityFSM.RunAbilityFSMSubState currentSubState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM.NativeFieldInfoPtr_currentSubState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM.NativeFieldInfoPtr_currentSubState)) = value;
			}
		}

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeFieldInfoPtr_runCost;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr__SelectedAbility_k__BackingField;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_currentSubState;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Boolean_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedAbility_Public_get_IAbilityStateMachineDefinition_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_IAbilityStateMachineDefinition_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_RunAbilityFSM_Match_SerializedRunAbilityFSM_0;

		// Token: 0x02000408 RID: 1032
		public enum RunAbilityFSMSubState
		{
			// Token: 0x04001BF4 RID: 7156
			Starting,
			// Token: 0x04001BF5 RID: 7157
			RanAbility
		}

		// Token: 0x02000409 RID: 1033
		[ObfuscatedName("Canis.actions.RunAbilityFSM+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06002CB4 RID: 11444 RVA: 0x000BD5D0 File Offset: 0x000BB7D0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunAbilityFSM>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr);
				RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, "<>1__state");
				RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, "<>2__current");
				RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, "<>l__initialThreadId");
				RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, "<>4__this");
				RunAbilityFSM._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, 100667545);
				RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, 100667546);
				RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, 100667547);
				RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, 100667548);
				RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, 100667549);
				RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, 100667550);
				RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, 100667551);
				RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr, 100667552);
			}

			// Token: 0x06002CB5 RID: 11445 RVA: 0x000BD6EC File Offset: 0x000BB8EC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunAbilityFSM._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CB6 RID: 11446 RVA: 0x000BD734 File Offset: 0x000BB934
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CB7 RID: 11447 RVA: 0x000BD768 File Offset: 0x000BB968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587101, XrefRangeEnd = 587141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x000BD7A4 File Offset: 0x000BB9A4
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002CB9 RID: 11449 RVA: 0x000BD7E4 File Offset: 0x000BB9E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587141, XrefRangeEnd = 587146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B89 RID: 2953
			// (get) Token: 0x06002CBA RID: 11450 RVA: 0x000BD818 File Offset: 0x000BBA18
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CBB RID: 11451 RVA: 0x000BD858 File Offset: 0x000BBA58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587146, XrefRangeEnd = 587148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002CBC RID: 11452 RVA: 0x000BD898 File Offset: 0x000BBA98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAbilityFSM._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002CBD RID: 11453 RVA: 0x000155CA File Offset: 0x000137CA
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x06002CBE RID: 11454 RVA: 0x000BD8D8 File Offset: 0x000BBAD8
			// (set) Token: 0x06002CBF RID: 11455 RVA: 0x000155D3 File Offset: 0x000137D3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x000BD900 File Offset: 0x000BBB00
			// (set) Token: 0x06002CC1 RID: 11457 RVA: 0x000155EE File Offset: 0x000137EE
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B86 RID: 2950
			// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x000BD930 File Offset: 0x000BBB30
			// (set) Token: 0x06002CC3 RID: 11459 RVA: 0x0001560D File Offset: 0x0001380D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B87 RID: 2951
			// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x000BD958 File Offset: 0x000BBB58
			// (set) Token: 0x06002CC5 RID: 11461 RVA: 0x00015628 File Offset: 0x00013828
			public unsafe RunAbilityFSM __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunAbilityFSM>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAbilityFSM._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BF6 RID: 7158
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BF7 RID: 7159
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BF8 RID: 7160
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001BF9 RID: 7161
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BFA RID: 7162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BFB RID: 7163
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BFC RID: 7164
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BFD RID: 7165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001BFE RID: 7166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BFF RID: 7167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C00 RID: 7168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001C01 RID: 7169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
