using System;
using Canis.actions.serialized;
using Canis.hasExecutionStack;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.actions.continuations
{
	// Token: 0x02000225 RID: 549
	public class ExecuteStack : Object
	{
		// Token: 0x060016D5 RID: 5845 RVA: 0x00074F10 File Offset: 0x00073110
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteStack()
		{
			Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "ExecuteStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr);
			ExecuteStack.NativeFieldInfoPtr__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, "_match");
			ExecuteStack.NativeFieldInfoPtr__executeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, "_executeStack");
			ExecuteStack.NativeMethodInfoPtr_get_StackActions_Public_get_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668476);
			ExecuteStack.NativeMethodInfoPtr__ctor_Public_Void_Match_ExecuteStackContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668477);
			ExecuteStack.NativeMethodInfoPtr_NewStack_Public_Static_ExecuteStack_Match_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668478);
			ExecuteStack.NativeMethodInfoPtr_PushSubAction_Public_ExecuteStack_Match_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668479);
			ExecuteStack.NativeMethodInfoPtr_PopToParent_Private_ExecuteStack_Match_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668480);
			ExecuteStack.NativeMethodInfoPtr_HandleExternalReturningAction_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668481);
			ExecuteStack.NativeMethodInfoPtr_FirstAction_Public_TAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668482);
			ExecuteStack.NativeMethodInfoPtr_HaltAtSelection_Private_ExecuteStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668483);
			ExecuteStack.NativeMethodInfoPtr_RunStep_Public_ExecuteStack_IHasExecutionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668484);
			ExecuteStack.NativeMethodInfoPtr_GenContinuation_Public_ActionContinuation_ActionContinuation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668485);
			ExecuteStack.NativeMethodInfoPtr_Serialize_Public_SerializedExecuteStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668486);
			ExecuteStack.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668487);
			ExecuteStack.NativeMethodInfoPtr__Serialize_b__13_0_Private_IEnumerable_1_SerializedAction_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, 100668488);
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x0007506C File Offset: 0x0007326C
		public unsafe IEnumerable<Action> StackActions
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 593875, RefRangeEnd = 593879, XrefRangeStart = 593873, XrefRangeEnd = 593875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr_get_StackActions_Public_get_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000750AC File Offset: 0x000732AC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteStack(Match match, ExecuteStackContainer stack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr__ctor_Public_Void_Match_ExecuteStackContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0007510C File Offset: 0x0007330C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 593898, RefRangeEnd = 593900, XrefRangeStart = 593879, XrefRangeEnd = 593898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExecuteStack NewStack(Match match, Action action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr_NewStack_Public_Static_ExecuteStack_Match_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteStack>(intPtr3) : null;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00075164 File Offset: 0x00073364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 593919, RefRangeEnd = 593921, XrefRangeStart = 593900, XrefRangeEnd = 593919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteStack PushSubAction(Match match, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr_PushSubAction_Public_ExecuteStack_Match_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteStack>(intPtr3) : null;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x000751C8 File Offset: 0x000733C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 593936, RefRangeEnd = 593937, XrefRangeStart = 593921, XrefRangeEnd = 593936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteStack PopToParent(Match match, Action completedAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(completedAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr_PopToParent_Private_ExecuteStack_Match_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteStack>(intPtr3) : null;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x0007522C File Offset: 0x0007342C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 593959, RefRangeEnd = 593960, XrefRangeStart = 593937, XrefRangeEnd = 593959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleExternalReturningAction(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr_HandleExternalReturningAction_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00075270 File Offset: 0x00073470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 593981, RefRangeEnd = 593983, XrefRangeStart = 593960, XrefRangeEnd = 593981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TAction FirstAction<TAction>() where TAction : Action
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.MethodInfoStoreGeneric_FirstAction_Public_TAction_0<TAction>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TAction>(intPtr, false, true);
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x000752AC File Offset: 0x000734AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 594022, RefRangeEnd = 594023, XrefRangeStart = 593983, XrefRangeEnd = 594022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteStack HaltAtSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr_HaltAtSelection_Private_ExecuteStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteStack>(intPtr3) : null;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x000752EC File Offset: 0x000734EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 594074, RefRangeEnd = 594075, XrefRangeStart = 594023, XrefRangeEnd = 594074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteStack RunStep(IHasExecutionStack executingStack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executingStack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr_RunStep_Public_ExecuteStack_IHasExecutionStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteStack>(intPtr3) : null;
			}
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0007533C File Offset: 0x0007353C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 594082, RefRangeEnd = 594083, XrefRangeStart = 594075, XrefRangeEnd = 594082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionContinuation GenContinuation(ActionContinuation continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr_GenContinuation_Public_ActionContinuation_ActionContinuation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr3) : null;
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0007538C File Offset: 0x0007358C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 594101, RefRangeEnd = 594104, XrefRangeStart = 594083, XrefRangeEnd = 594101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedExecuteStack Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr_Serialize_Public_SerializedExecuteStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedExecuteStack>(intPtr3) : null;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x000753CC File Offset: 0x000735CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594104, XrefRangeEnd = 594140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExecuteStack.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00075410 File Offset: 0x00073610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594140, XrefRangeEnd = 594153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<SerializedAction> _Serialize_b__13_0(Action act)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(act);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.NativeMethodInfoPtr__Serialize_b__13_0_Private_IEnumerable_1_SerializedAction_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SerializedAction>>(intPtr3) : null;
			}
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0000AED9 File Offset: 0x000090D9
		public ExecuteStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x00075460 File Offset: 0x00073660
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x0000AEE2 File Offset: 0x000090E2
		public unsafe Match _match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStack.NativeFieldInfoPtr__match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStack.NativeFieldInfoPtr__match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x00075490 File Offset: 0x00073690
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x0000AF01 File Offset: 0x00009101
		public unsafe ExecuteStackContainer _executeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStack.NativeFieldInfoPtr__executeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteStackContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecuteStack.NativeFieldInfoPtr__executeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeFieldInfoPtr__match;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeFieldInfoPtr__executeStack;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_get_StackActions_Public_get_IEnumerable_1_Action_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_ExecuteStackContainer_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_NewStack_Public_Static_ExecuteStack_Match_Action_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_PushSubAction_Public_ExecuteStack_Match_Action_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_PopToParent_Private_ExecuteStack_Match_Action_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_HandleExternalReturningAction_Public_Void_Action_0;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_FirstAction_Public_TAction_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_HaltAtSelection_Private_ExecuteStack_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr_RunStep_Public_ExecuteStack_IHasExecutionStack_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_GenContinuation_Public_ActionContinuation_ActionContinuation_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_SerializedExecuteStack_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr__Serialize_b__13_0_Private_IEnumerable_1_SerializedAction_Action_0;

		// Token: 0x02000467 RID: 1127
		[ObfuscatedName("Canis.actions.continuations.ExecuteStack+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600325E RID: 12894 RVA: 0x000CF234 File Offset: 0x000CD434
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ExecuteStack.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteStack.__c>.NativeClassPtr);
				ExecuteStack.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStack.__c>.NativeClassPtr, "<>9");
				ExecuteStack.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStack.__c>.NativeClassPtr, "<>9__8_0");
				ExecuteStack.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStack.__c>.NativeClassPtr, "<>9__14_0");
				ExecuteStack.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack.__c>.NativeClassPtr, 100668490);
				ExecuteStack.__c.NativeMethodInfoPtr__HandleExternalReturningAction_b__8_0_Internal_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack.__c>.NativeClassPtr, 100668491);
				ExecuteStack.__c.NativeMethodInfoPtr__ToString_b__14_0_Internal_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack.__c>.NativeClassPtr, 100668492);
			}

			// Token: 0x0600325F RID: 12895 RVA: 0x000CF2D8 File Offset: 0x000CD4D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteStack.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003260 RID: 12896 RVA: 0x000CF314 File Offset: 0x000CD514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593868, XrefRangeEnd = 593869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleExternalReturningAction_b__8_0(Action _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.__c.NativeMethodInfoPtr__HandleExternalReturningAction_b__8_0_Internal_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003261 RID: 12897 RVA: 0x000CF364 File Offset: 0x000CD564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593869, XrefRangeEnd = 593871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__14_0(Action _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.__c.NativeMethodInfoPtr__ToString_b__14_0_Internal_String_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003262 RID: 12898 RVA: 0x0001826A File Offset: 0x0001646A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D55 RID: 3413
			// (get) Token: 0x06003263 RID: 12899 RVA: 0x000CF3AC File Offset: 0x000CD5AC
			// (set) Token: 0x06003264 RID: 12900 RVA: 0x00018273 File Offset: 0x00016473
			public unsafe static ExecuteStack.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExecuteStack.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteStack.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExecuteStack.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D56 RID: 3414
			// (get) Token: 0x06003265 RID: 12901 RVA: 0x000CF3D4 File Offset: 0x000CD5D4
			// (set) Token: 0x06003266 RID: 12902 RVA: 0x00018285 File Offset: 0x00016485
			public unsafe static Func<Action, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExecuteStack.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Action, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExecuteStack.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D57 RID: 3415
			// (get) Token: 0x06003267 RID: 12903 RVA: 0x000CF3FC File Offset: 0x000CD5FC
			// (set) Token: 0x06003268 RID: 12904 RVA: 0x00018297 File Offset: 0x00016497
			public unsafe static Func<Action, string> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExecuteStack.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Action, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExecuteStack.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F7F RID: 8063
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001F80 RID: 8064
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04001F81 RID: 8065
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04001F82 RID: 8066
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F83 RID: 8067
			private static readonly IntPtr NativeMethodInfoPtr__HandleExternalReturningAction_b__8_0_Internal_Boolean_Action_0;

			// Token: 0x04001F84 RID: 8068
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__14_0_Internal_String_Action_0;
		}

		// Token: 0x02000468 RID: 1128
		[ObfuscatedName("Canis.actions.continuations.ExecuteStack+<>c__9`1")]
		[Serializable]
		public sealed class __c__9<TAction> : Object where TAction : Action
		{
			// Token: 0x06003269 RID: 12905 RVA: 0x000CF424 File Offset: 0x000CD624
			// Note: this type is marked as 'beforefieldinit'.
			static __c__9()
			{
				Il2CppClassPointerStore<ExecuteStack.__c__9<TAction>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr, "<>c__9`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAction>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteStack.__c__9<TAction>>.NativeClassPtr);
				ExecuteStack.__c__9<TAction>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStack.__c__9<TAction>>.NativeClassPtr, "<>9");
				ExecuteStack.__c__9<TAction>.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteStack.__c__9<TAction>>.NativeClassPtr, "<>9__9_0");
				ExecuteStack.__c__9<TAction>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack.__c__9<TAction>>.NativeClassPtr, 100668494);
				ExecuteStack.__c__9<TAction>.NativeMethodInfoPtr__FirstAction_b__9_0_Internal_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteStack.__c__9<TAction>>.NativeClassPtr, 100668495);
			}

			// Token: 0x0600326A RID: 12906 RVA: 0x000CF4DC File Offset: 0x000CD6DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__9()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteStack.__c__9<TAction>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.__c__9<TAction>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600326B RID: 12907 RVA: 0x000CF518 File Offset: 0x000CD718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593871, XrefRangeEnd = 593873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FirstAction_b__9_0(Action _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteStack.__c__9<TAction>.NativeMethodInfoPtr__FirstAction_b__9_0_Internal_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600326C RID: 12908 RVA: 0x000182A9 File Offset: 0x000164A9
			public __c__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D58 RID: 3416
			// (get) Token: 0x0600326D RID: 12909 RVA: 0x000CF568 File Offset: 0x000CD768
			// (set) Token: 0x0600326E RID: 12910 RVA: 0x000182B2 File Offset: 0x000164B2
			public unsafe static ExecuteStack.__c__9<TAction> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExecuteStack.__c__9<TAction>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteStack.__c__9<TAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExecuteStack.__c__9<TAction>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D59 RID: 3417
			// (get) Token: 0x0600326F RID: 12911 RVA: 0x000CF590 File Offset: 0x000CD790
			// (set) Token: 0x06003270 RID: 12912 RVA: 0x000182C4 File Offset: 0x000164C4
			public unsafe static Func<Action, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExecuteStack.__c__9<TAction>.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Action, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExecuteStack.__c__9<TAction>.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F85 RID: 8069
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001F86 RID: 8070
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001F87 RID: 8071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F88 RID: 8072
			private static readonly IntPtr NativeMethodInfoPtr__FirstAction_b__9_0_Internal_Boolean_Action_0;
		}

		// Token: 0x02000469 RID: 1129
		private sealed class MethodInfoStoreGeneric_FirstAction_Public_TAction_0<TAction>
		{
			// Token: 0x04001F89 RID: 8073
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteStack.NativeMethodInfoPtr_FirstAction_Public_TAction_0, Il2CppClassPointerStore<ExecuteStack>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAction>.NativeClassPtr)) }))));
		}
	}
}
