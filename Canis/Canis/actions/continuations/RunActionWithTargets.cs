using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.continuations
{
	// Token: 0x0200022A RID: 554
	public class RunActionWithTargets : Action
	{
		// Token: 0x06001700 RID: 5888 RVA: 0x000759C4 File Offset: 0x00073BC4
		// Note: this type is marked as 'beforefieldinit'.
		static RunActionWithTargets()
		{
			Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.continuations", "RunActionWithTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr);
			RunActionWithTargets.NativeFieldInfoPtr_parentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, "parentStack");
			RunActionWithTargets.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, "actions");
			RunActionWithTargets.NativeFieldInfoPtr__currentTargetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, "_currentTargetIndex");
			RunActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_ExecuteStack_ActionAcrossTargets_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, 100668508);
			RunActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_SerializedRunActionWithTargets_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, 100668509);
			RunActionWithTargets.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, 100668510);
			RunActionWithTargets.NativeMethodInfoPtr_runSkipAction_Private_IEnumerable_1_Action_Skip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, 100668511);
			RunActionWithTargets.NativeMethodInfoPtr_runActionOnEachTarget_Private_IEnumerable_1_Action_Targeted_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, 100668512);
			RunActionWithTargets.NativeMethodInfoPtr_get_CompletedAction_Public_Virtual_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, 100668513);
			RunActionWithTargets.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, 100668514);
			RunActionWithTargets.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, 100668515);
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00075AD0 File Offset: 0x00073CD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 594317, RefRangeEnd = 594319, XrefRangeStart = 594314, XrefRangeEnd = 594317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunActionWithTargets(ExecuteStack stack, ActionAcrossTargets actions, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_ExecuteStack_ActionAcrossTargets_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00075B40 File Offset: 0x00073D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594319, XrefRangeEnd = 594324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunActionWithTargets(SerializedRunActionWithTargets serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_SerializedRunActionWithTargets_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00075BA0 File Offset: 0x00073DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594324, XrefRangeEnd = 594354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunActionWithTargets.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00075BEC File Offset: 0x00073DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594354, XrefRangeEnd = 594361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> runSkipAction(ActionAcrossTargets.Skip acts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets.NativeMethodInfoPtr_runSkipAction_Private_IEnumerable_1_Action_Skip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00075C3C File Offset: 0x00073E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594361, XrefRangeEnd = 594368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> runActionOnEachTarget(ActionAcrossTargets.Targeted acts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets.NativeMethodInfoPtr_runActionOnEachTarget_Private_IEnumerable_1_Action_Targeted_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x00075C8C File Offset: 0x00073E8C
		public unsafe override Action CompletedAction
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunActionWithTargets.NativeMethodInfoPtr_get_CompletedAction_Public_Virtual_get_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00075CD8 File Offset: 0x00073ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594368, XrefRangeEnd = 594376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunActionWithTargets.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00075D28 File Offset: 0x00073F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594376, XrefRangeEnd = 594420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunActionWithTargets.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0000AFFF File Offset: 0x000091FF
		public RunActionWithTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x00075D84 File Offset: 0x00073F84
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x0000B008 File Offset: 0x00009208
		public unsafe ExecuteStack parentStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets.NativeFieldInfoPtr_parentStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets.NativeFieldInfoPtr_parentStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x00075DB4 File Offset: 0x00073FB4
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x0000B027 File Offset: 0x00009227
		public unsafe ActionAcrossTargets actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets.NativeFieldInfoPtr_actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x00075DE4 File Offset: 0x00073FE4
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x0000B046 File Offset: 0x00009246
		public unsafe int _currentTargetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets.NativeFieldInfoPtr__currentTargetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets.NativeFieldInfoPtr__currentTargetIndex)) = value;
			}
		}

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeFieldInfoPtr_parentStack;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeFieldInfoPtr_actions;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeFieldInfoPtr__currentTargetIndex;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExecuteStack_ActionAcrossTargets_Match_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedRunActionWithTargets_Match_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_runSkipAction_Private_IEnumerable_1_Action_Skip_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_runActionOnEachTarget_Private_IEnumerable_1_Action_Targeted_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedAction_Public_Virtual_get_Action_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0200046B RID: 1131
		[ObfuscatedName("Canis.actions.continuations.RunActionWithTargets+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003278 RID: 12920 RVA: 0x000CF728 File Offset: 0x000CD928
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr);
				RunActionWithTargets.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr, "<>9");
				RunActionWithTargets.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr, "<>9__5_0");
				RunActionWithTargets.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr, "<>9__11_0");
				RunActionWithTargets.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr, "<>9__11_1");
				RunActionWithTargets.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr, 100668517);
				RunActionWithTargets.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_IEnumerable_1_Action_Noop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr, 100668518);
				RunActionWithTargets.__c.NativeMethodInfoPtr__MakeSerializedAction_b__11_0_Internal_SerializedAction_Noop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr, 100668519);
				RunActionWithTargets.__c.NativeMethodInfoPtr__MakeSerializedAction_b__11_1_Internal_SerializedAction_Skip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr, 100668520);
			}

			// Token: 0x06003279 RID: 12921 RVA: 0x000CF7F4 File Offset: 0x000CD9F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunActionWithTargets.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600327A RID: 12922 RVA: 0x000CF830 File Offset: 0x000CDA30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594232, XrefRangeEnd = 594235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Action> _execute_b__5_0(ActionAcrossTargets.Noop n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_IEnumerable_1_Action_Noop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
				}
			}

			// Token: 0x0600327B RID: 12923 RVA: 0x000CF880 File Offset: 0x000CDA80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594235, XrefRangeEnd = 594239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedAction _MakeSerializedAction_b__11_0(ActionAcrossTargets.Noop n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets.__c.NativeMethodInfoPtr__MakeSerializedAction_b__11_0_Internal_SerializedAction_Noop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
				}
			}

			// Token: 0x0600327C RID: 12924 RVA: 0x000CF8D0 File Offset: 0x000CDAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594239, XrefRangeEnd = 594243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedAction _MakeSerializedAction_b__11_1(ActionAcrossTargets.Skip skip)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(skip);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets.__c.NativeMethodInfoPtr__MakeSerializedAction_b__11_1_Internal_SerializedAction_Skip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
				}
			}

			// Token: 0x0600327D RID: 12925 RVA: 0x000182FE File Offset: 0x000164FE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D5B RID: 3419
			// (get) Token: 0x0600327E RID: 12926 RVA: 0x000CF920 File Offset: 0x000CDB20
			// (set) Token: 0x0600327F RID: 12927 RVA: 0x00018307 File Offset: 0x00016507
			public unsafe static RunActionWithTargets.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunActionWithTargets.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunActionWithTargets.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunActionWithTargets.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5C RID: 3420
			// (get) Token: 0x06003280 RID: 12928 RVA: 0x000CF948 File Offset: 0x000CDB48
			// (set) Token: 0x06003281 RID: 12929 RVA: 0x00018319 File Offset: 0x00016519
			public unsafe static Func<ActionAcrossTargets.Noop, IEnumerable<Action>> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunActionWithTargets.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ActionAcrossTargets.Noop, IEnumerable<Action>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunActionWithTargets.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5D RID: 3421
			// (get) Token: 0x06003282 RID: 12930 RVA: 0x000CF970 File Offset: 0x000CDB70
			// (set) Token: 0x06003283 RID: 12931 RVA: 0x0001832B File Offset: 0x0001652B
			public unsafe static Func<ActionAcrossTargets.Noop, SerializedAction> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunActionWithTargets.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ActionAcrossTargets.Noop, SerializedAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunActionWithTargets.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5E RID: 3422
			// (get) Token: 0x06003284 RID: 12932 RVA: 0x000CF998 File Offset: 0x000CDB98
			// (set) Token: 0x06003285 RID: 12933 RVA: 0x0001833D File Offset: 0x0001653D
			public unsafe static Func<ActionAcrossTargets.Skip, SerializedAction> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunActionWithTargets.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ActionAcrossTargets.Skip, SerializedAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunActionWithTargets.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F8D RID: 8077
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001F8E RID: 8078
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001F8F RID: 8079
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04001F90 RID: 8080
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x04001F91 RID: 8081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F92 RID: 8082
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_0_Internal_IEnumerable_1_Action_Noop_0;

			// Token: 0x04001F93 RID: 8083
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedAction_b__11_0_Internal_SerializedAction_Noop_0;

			// Token: 0x04001F94 RID: 8084
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedAction_b__11_1_Internal_SerializedAction_Skip_0;
		}

		// Token: 0x0200046C RID: 1132
		[ObfuscatedName("Canis.actions.continuations.RunActionWithTargets+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06003286 RID: 12934 RVA: 0x000CF9C0 File Offset: 0x000CDBC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<RunActionWithTargets.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunActionWithTargets.__c__DisplayClass11_0>.NativeClassPtr);
				RunActionWithTargets.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				RunActionWithTargets.__c__DisplayClass11_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets.__c__DisplayClass11_0>.NativeClassPtr, "match");
				RunActionWithTargets.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets.__c__DisplayClass11_0>.NativeClassPtr, 100668521);
				RunActionWithTargets.__c__DisplayClass11_0.NativeMethodInfoPtr__MakeSerializedAction_b__2_Internal_SerializedAction_Targeted_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets.__c__DisplayClass11_0>.NativeClassPtr, 100668522);
			}

			// Token: 0x06003287 RID: 12935 RVA: 0x000CFA3C File Offset: 0x000CDC3C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunActionWithTargets.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003288 RID: 12936 RVA: 0x000CFA78 File Offset: 0x000CDC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594243, XrefRangeEnd = 594278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedAction _MakeSerializedAction_b__2(ActionAcrossTargets.Targeted acts)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(acts);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets.__c__DisplayClass11_0.NativeMethodInfoPtr__MakeSerializedAction_b__2_Internal_SerializedAction_Targeted_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
				}
			}

			// Token: 0x06003289 RID: 12937 RVA: 0x0001834F File Offset: 0x0001654F
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D5F RID: 3423
			// (get) Token: 0x0600328A RID: 12938 RVA: 0x000CFAC8 File Offset: 0x000CDCC8
			// (set) Token: 0x0600328B RID: 12939 RVA: 0x00018358 File Offset: 0x00016558
			public unsafe RunActionWithTargets __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunActionWithTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D60 RID: 3424
			// (get) Token: 0x0600328C RID: 12940 RVA: 0x000CFAF8 File Offset: 0x000CDCF8
			// (set) Token: 0x0600328D RID: 12941 RVA: 0x00018377 File Offset: 0x00016577
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets.__c__DisplayClass11_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets.__c__DisplayClass11_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F95 RID: 8085
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001F96 RID: 8086
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001F97 RID: 8087
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F98 RID: 8088
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedAction_b__2_Internal_SerializedAction_Targeted_0;
		}

		// Token: 0x0200046D RID: 1133
		[ObfuscatedName("Canis.actions.continuations.RunActionWithTargets+<runActionOnEachTarget>d__7")]
		public sealed class _runActionOnEachTarget_d__7 : Object
		{
			// Token: 0x0600328E RID: 12942 RVA: 0x000CFB28 File Offset: 0x000CDD28
			// Note: this type is marked as 'beforefieldinit'.
			static _runActionOnEachTarget_d__7()
			{
				Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, "<runActionOnEachTarget>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr);
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, "<>1__state");
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, "<>2__current");
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, "<>l__initialThreadId");
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr_acts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, "acts");
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___3__acts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, "<>3__acts");
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, "<>4__this");
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, 100668523);
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, 100668524);
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, 100668525);
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, 100668526);
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, 100668527);
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, 100668528);
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, 100668529);
				RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr, 100668530);
			}

			// Token: 0x0600328F RID: 12943 RVA: 0x000CFC6C File Offset: 0x000CDE6C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runActionOnEachTarget_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunActionWithTargets._runActionOnEachTarget_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003290 RID: 12944 RVA: 0x000CFCB4 File Offset: 0x000CDEB4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003291 RID: 12945 RVA: 0x000CFCE8 File Offset: 0x000CDEE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594278, XrefRangeEnd = 594284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D67 RID: 3431
			// (get) Token: 0x06003292 RID: 12946 RVA: 0x000CFD24 File Offset: 0x000CDF24
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06003293 RID: 12947 RVA: 0x000CFD64 File Offset: 0x000CDF64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594284, XrefRangeEnd = 594289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D68 RID: 3432
			// (get) Token: 0x06003294 RID: 12948 RVA: 0x000CFD98 File Offset: 0x000CDF98
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003295 RID: 12949 RVA: 0x000CFDD8 File Offset: 0x000CDFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594289, XrefRangeEnd = 594298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06003296 RID: 12950 RVA: 0x000CFE18 File Offset: 0x000CE018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runActionOnEachTarget_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003297 RID: 12951 RVA: 0x00018396 File Offset: 0x00016596
			public _runActionOnEachTarget_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D61 RID: 3425
			// (get) Token: 0x06003298 RID: 12952 RVA: 0x000CFE58 File Offset: 0x000CE058
			// (set) Token: 0x06003299 RID: 12953 RVA: 0x0001839F File Offset: 0x0001659F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D62 RID: 3426
			// (get) Token: 0x0600329A RID: 12954 RVA: 0x000CFE80 File Offset: 0x000CE080
			// (set) Token: 0x0600329B RID: 12955 RVA: 0x000183BA File Offset: 0x000165BA
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D63 RID: 3427
			// (get) Token: 0x0600329C RID: 12956 RVA: 0x000CFEB0 File Offset: 0x000CE0B0
			// (set) Token: 0x0600329D RID: 12957 RVA: 0x000183D9 File Offset: 0x000165D9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D64 RID: 3428
			// (get) Token: 0x0600329E RID: 12958 RVA: 0x000CFED8 File Offset: 0x000CE0D8
			// (set) Token: 0x0600329F RID: 12959 RVA: 0x000183F4 File Offset: 0x000165F4
			public unsafe ActionAcrossTargets.Targeted acts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr_acts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets.Targeted>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr_acts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D65 RID: 3429
			// (get) Token: 0x060032A0 RID: 12960 RVA: 0x000CFF08 File Offset: 0x000CE108
			// (set) Token: 0x060032A1 RID: 12961 RVA: 0x00018413 File Offset: 0x00016613
			public unsafe ActionAcrossTargets.Targeted __3__acts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___3__acts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets.Targeted>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___3__acts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D66 RID: 3430
			// (get) Token: 0x060032A2 RID: 12962 RVA: 0x000CFF38 File Offset: 0x000CE138
			// (set) Token: 0x060032A3 RID: 12963 RVA: 0x00018432 File Offset: 0x00016632
			public unsafe RunActionWithTargets __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunActionWithTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runActionOnEachTarget_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F99 RID: 8089
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F9A RID: 8090
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F9B RID: 8091
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001F9C RID: 8092
			private static readonly IntPtr NativeFieldInfoPtr_acts;

			// Token: 0x04001F9D RID: 8093
			private static readonly IntPtr NativeFieldInfoPtr___3__acts;

			// Token: 0x04001F9E RID: 8094
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001F9F RID: 8095
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FA0 RID: 8096
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FA1 RID: 8097
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FA2 RID: 8098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001FA3 RID: 8099
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FA4 RID: 8100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FA5 RID: 8101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001FA6 RID: 8102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200046E RID: 1134
		[ObfuscatedName("Canis.actions.continuations.RunActionWithTargets+<runSkipAction>d__6")]
		public sealed class _runSkipAction_d__6 : Object
		{
			// Token: 0x060032A4 RID: 12964 RVA: 0x000CFF68 File Offset: 0x000CE168
			// Note: this type is marked as 'beforefieldinit'.
			static _runSkipAction_d__6()
			{
				Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunActionWithTargets>.NativeClassPtr, "<runSkipAction>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr);
				RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, "<>1__state");
				RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, "<>2__current");
				RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, "<>l__initialThreadId");
				RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr_acts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, "acts");
				RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___3__acts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, "<>3__acts");
				RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, "<>4__this");
				RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, 100668531);
				RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, 100668532);
				RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, 100668533);
				RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, 100668534);
				RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, 100668535);
				RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, 100668536);
				RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, 100668537);
				RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr, 100668538);
			}

			// Token: 0x060032A5 RID: 12965 RVA: 0x000D00AC File Offset: 0x000CE2AC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runSkipAction_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunActionWithTargets._runSkipAction_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032A6 RID: 12966 RVA: 0x000D00F4 File Offset: 0x000CE2F4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032A7 RID: 12967 RVA: 0x000D0128 File Offset: 0x000CE328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594298, XrefRangeEnd = 594300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D6F RID: 3439
			// (get) Token: 0x060032A8 RID: 12968 RVA: 0x000D0164 File Offset: 0x000CE364
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060032A9 RID: 12969 RVA: 0x000D01A4 File Offset: 0x000CE3A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594300, XrefRangeEnd = 594305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D70 RID: 3440
			// (get) Token: 0x060032AA RID: 12970 RVA: 0x000D01D8 File Offset: 0x000CE3D8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060032AB RID: 12971 RVA: 0x000D0218 File Offset: 0x000CE418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 594305, XrefRangeEnd = 594314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060032AC RID: 12972 RVA: 0x000D0258 File Offset: 0x000CE458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunActionWithTargets._runSkipAction_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060032AD RID: 12973 RVA: 0x00018451 File Offset: 0x00016651
			public _runSkipAction_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D69 RID: 3433
			// (get) Token: 0x060032AE RID: 12974 RVA: 0x000D0298 File Offset: 0x000CE498
			// (set) Token: 0x060032AF RID: 12975 RVA: 0x0001845A File Offset: 0x0001665A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D6A RID: 3434
			// (get) Token: 0x060032B0 RID: 12976 RVA: 0x000D02C0 File Offset: 0x000CE4C0
			// (set) Token: 0x060032B1 RID: 12977 RVA: 0x00018475 File Offset: 0x00016675
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6B RID: 3435
			// (get) Token: 0x060032B2 RID: 12978 RVA: 0x000D02F0 File Offset: 0x000CE4F0
			// (set) Token: 0x060032B3 RID: 12979 RVA: 0x00018494 File Offset: 0x00016694
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000D6C RID: 3436
			// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000D0318 File Offset: 0x000CE518
			// (set) Token: 0x060032B5 RID: 12981 RVA: 0x000184AF File Offset: 0x000166AF
			public unsafe ActionAcrossTargets.Skip acts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr_acts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets.Skip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr_acts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6D RID: 3437
			// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000D0348 File Offset: 0x000CE548
			// (set) Token: 0x060032B7 RID: 12983 RVA: 0x000184CE File Offset: 0x000166CE
			public unsafe ActionAcrossTargets.Skip __3__acts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___3__acts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionAcrossTargets.Skip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___3__acts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D6E RID: 3438
			// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000D0378 File Offset: 0x000CE578
			// (set) Token: 0x060032B9 RID: 12985 RVA: 0x000184ED File Offset: 0x000166ED
			public unsafe RunActionWithTargets __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunActionWithTargets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunActionWithTargets._runSkipAction_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FA7 RID: 8103
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FA8 RID: 8104
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FA9 RID: 8105
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001FAA RID: 8106
			private static readonly IntPtr NativeFieldInfoPtr_acts;

			// Token: 0x04001FAB RID: 8107
			private static readonly IntPtr NativeFieldInfoPtr___3__acts;

			// Token: 0x04001FAC RID: 8108
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FAD RID: 8109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FAE RID: 8110
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FAF RID: 8111
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FB0 RID: 8112
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001FB1 RID: 8113
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FB2 RID: 8114
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FB3 RID: 8115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001FB4 RID: 8116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
