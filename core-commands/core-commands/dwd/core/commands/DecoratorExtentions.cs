using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace dwd.core.commands
{
	// Token: 0x02000015 RID: 21
	public static class DecoratorExtentions : global::Il2CppSystem.Object
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x000074E0 File Offset: 0x000056E0
		// Note: this type is marked as 'beforefieldinit'.
		static DecoratorExtentions()
		{
			Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "DecoratorExtentions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr);
			DecoratorExtentions.NativeMethodInfoPtr_AsAsync_Public_Static_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663450);
			DecoratorExtentions.NativeMethodInfoPtr_AsCommand_Public_Static_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663451);
			DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663452);
			DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663453);
			DecoratorExtentions.NativeMethodInfoPtr_DelayFor_Public_Static_Command_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663454);
			DecoratorExtentions.NativeMethodInfoPtr_DelayFor_Public_Static_Command_AtomicAction_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663455);
			DecoratorExtentions.NativeMethodInfoPtr_WithInterrupt_Public_Static_InterruptableCommand_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663456);
			DecoratorExtentions.NativeMethodInfoPtr_InterruptAfter_Public_Static_IFailable_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663457);
			DecoratorExtentions.NativeMethodInfoPtr_InterruptAfter_Public_Static_IFailable_InterruptableCommand_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663458);
			DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663459);
			DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663460);
			DecoratorExtentions.NativeMethodInfoPtr_ThenEither_Public_Static_Command_T_Func_2_T_Boolean_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663461);
			DecoratorExtentions.NativeMethodInfoPtr_ThenEither_Public_Static_Command_T_Func_2_T_Boolean_Func_2_T_IEnumerator_Func_2_T_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663462);
			DecoratorExtentions.NativeMethodInfoPtr_ThenEither_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_1_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663463);
			DecoratorExtentions.NativeMethodInfoPtr_ThenEither_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663464);
			DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663465);
			DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663466);
			DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663467);
			DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Func_2_T_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663468);
			DecoratorExtentions.NativeMethodInfoPtr_ThenLog_Public_Static_IEnumerator_IEnumerator_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663469);
			DecoratorExtentions.NativeMethodInfoPtr_ThenMaybeLog_Public_Static_IFailable_IFailable_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663470);
			DecoratorExtentions.NativeMethodInfoPtr_ThenMaybeLog_Public_Static_IFailable_TCommand_Func_2_TCommand_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663471);
			DecoratorExtentions.NativeMethodInfoPtr_WarningAfter_Public_Static_TimedWarningCommand_IEnumerator_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663472);
			DecoratorExtentions.NativeMethodInfoPtr_WarningAfter_Public_Static_TimedWarningCommand_Command_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663473);
			DecoratorExtentions.NativeMethodInfoPtr_WaitFor_Public_Static_Command_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663474);
			DecoratorExtentions.NativeMethodInfoPtr_WithActivatedObject_Public_Static_Command_IEnumerator_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663475);
			DecoratorExtentions.NativeMethodInfoPtr_WithActivatedObject_Public_Static_Command_IEnumerator_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663476);
			DecoratorExtentions.NativeMethodInfoPtr_WithAnimationParameter_Public_Static_WithAnimationParameter_1_T_T_Animator_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663477);
			DecoratorExtentions.NativeMethodInfoPtr_Parallel_Public_Static_Command_Il2CppReferenceArray_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663478);
			DecoratorExtentions.NativeMethodInfoPtr_Parallel_Public_Static_Command_IEnumerable_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663479);
			DecoratorExtentions.NativeMethodInfoPtr_Parallel_Public_Static_Command_IEnumerable_1_Command_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663480);
			DecoratorExtentions.NativeMethodInfoPtr_ThenParallel_Public_Static_Command_IEnumerator_Il2CppReferenceArray_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663481);
			DecoratorExtentions.NativeMethodInfoPtr_ThenParallel_Public_Static_Command_IEnumerator_IEnumerable_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, 100663482);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000077A4 File Offset: 0x000059A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207668, XrefRangeEnd = 1207678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command AsAsync(this IEnumerator command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_AsAsync_Public_Static_Command_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000077E8 File Offset: 0x000059E8
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 1207690, RefRangeEnd = 1207731, XrefRangeStart = 1207678, XrefRangeEnd = 1207690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command AsCommand(this IEnumerator enumerator)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_AsCommand_Public_Static_Command_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000782C File Offset: 0x00005A2C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1207736, RefRangeEnd = 1207750, XrefRangeStart = 1207731, XrefRangeEnd = 1207736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Then<T>(this T command, Action<T> action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000078B8 File Offset: 0x00005AB8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1207760, RefRangeEnd = 1207780, XrefRangeStart = 1207750, XrefRangeEnd = 1207760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Then<T>(this T command, Action action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Action_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00007944 File Offset: 0x00005B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207780, XrefRangeEnd = 1207784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command DelayFor(this IEnumerator delayed, float delay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delayed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_DelayFor_Public_Static_Command_IEnumerator_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00007998 File Offset: 0x00005B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207784, XrefRangeEnd = 1207788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command DelayFor(this AtomicAction action, float delay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_DelayFor_Public_Static_Command_AtomicAction_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000079EC File Offset: 0x00005BEC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1207792, RefRangeEnd = 1207799, XrefRangeStart = 1207788, XrefRangeEnd = 1207792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InterruptableCommand WithInterrupt(this IEnumerator interruptable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interruptable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_WithInterrupt_Public_Static_InterruptableCommand_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InterruptableCommand>(intPtr3) : null;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00007A30 File Offset: 0x00005C30
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1207812, RefRangeEnd = 1207822, XrefRangeStart = 1207799, XrefRangeEnd = 1207812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable InterruptAfter(this IEnumerator toInterrupt, float interruptAfter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toInterrupt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interruptAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_InterruptAfter_Public_Static_IFailable_IEnumerator_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00007A84 File Offset: 0x00005C84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1207831, RefRangeEnd = 1207832, XrefRangeStart = 1207822, XrefRangeEnd = 1207831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable InterruptAfter(this InterruptableCommand toInterrupt, float interruptAfter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toInterrupt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interruptAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_InterruptAfter_Public_Static_IFailable_InterruptableCommand_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00007AD8 File Offset: 0x00005CD8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1207838, RefRangeEnd = 1207858, XrefRangeStart = 1207832, XrefRangeEnd = 1207838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Then(this IEnumerator command, IEnumerator then)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(then);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_IEnumerator_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00007B30 File Offset: 0x00005D30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1207864, RefRangeEnd = 1207871, XrefRangeStart = 1207858, XrefRangeEnd = 1207864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Then<T>(this T command, Func<T, IEnumerator> thenGenerator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thenGenerator);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Func_2_T_IEnumerator_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00007BBC File Offset: 0x00005DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207871, XrefRangeEnd = 1207884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command ThenEither<T>(this T command, Func<T, bool> either, IEnumerator trueCommand, IEnumerator falseCommand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(either);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trueCommand);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(falseCommand);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_ThenEither_Public_Static_Command_T_Func_2_T_Boolean_IEnumerator_IEnumerator_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Command>(intPtr4) : null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00007C6C File Offset: 0x00005E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207884, XrefRangeEnd = 1207889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command ThenEither<T>(this T command, Func<T, bool> either, Func<T, IEnumerator> trueCommand, Func<T, IEnumerator> falseCommand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(either);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trueCommand);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(falseCommand);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_ThenEither_Public_Static_Command_T_Func_2_T_Boolean_Func_2_T_IEnumerator_Func_2_T_IEnumerator_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Command>(intPtr4) : null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00007D1C File Offset: 0x00005F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207889, XrefRangeEnd = 1207902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator ThenEither<T>(this T command, Func<T, bool> either, Action<T> trueCommand, Action<T> falseCommand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(either);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trueCommand);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(falseCommand);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_ThenEither_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_1_T_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00007DCC File Offset: 0x00005FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator ThenEither<T>(this T command, Func<T, bool> either, Action trueCommand, Action falseCommand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(either);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trueCommand);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(falseCommand);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_ThenEither_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_Action_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00007E7C File Offset: 0x0000607C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207902, XrefRangeEnd = 1207910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Then<T>(this T command, Func<T, bool> either, IEnumerator trueCommand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(either);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trueCommand);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_IEnumerator_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00007F1C File Offset: 0x0000611C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1207925, RefRangeEnd = 1207927, XrefRangeStart = 1207910, XrefRangeEnd = 1207925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Then<T>(this T command, Func<T, bool> either, Action<T> trueGenerator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(either);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trueGenerator);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00007FBC File Offset: 0x000061BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Then<T>(this T command, Func<T, bool> either, Action trueGenerator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(either);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trueGenerator);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000805C File Offset: 0x0000625C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207927, XrefRangeEnd = 1207934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Then<T>(this T command, Func<T, bool> either, Func<T, IEnumerator> trueGenerator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(either);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trueGenerator);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Func_2_T_IEnumerator_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000080FC File Offset: 0x000062FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207934, XrefRangeEnd = 1207942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator ThenLog(this IEnumerator command, global::Il2CppSystem.Object message, bool loggingEnabled = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loggingEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_ThenLog_Public_Static_IEnumerator_IEnumerator_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00008160 File Offset: 0x00006360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207942, XrefRangeEnd = 1207954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable ThenMaybeLog(this IFailable command, global::Il2CppSystem.Object message, bool loggingEnabled = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loggingEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_ThenMaybeLog_Public_Static_IFailable_IFailable_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000081C4 File Offset: 0x000063C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207954, XrefRangeEnd = 1207968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable ThenMaybeLog<TCommand>(this TCommand command, Func<TCommand, global::Il2CppSystem.Object> messageGenerator, bool loggingEnabled = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TCommand).IsValueType)
				{
					TCommand tcommand = command;
					intPtr = ((tcommand is string) ? IL2CPP.ManagedStringToIl2Cpp(tcommand as string) : IL2CPP.Il2CppObjectBaseToPtr(tcommand as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageGenerator);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loggingEnabled;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_ThenMaybeLog_Public_Static_IFailable_TCommand_Func_2_TCommand_Object_Boolean_0<TCommand>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr4) : null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00008260 File Offset: 0x00006460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207968, XrefRangeEnd = 1207979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimedWarningCommand WarningAfter(this IEnumerator command, float warnAfter, string message, bool asError = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warnAfter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_WarningAfter_Public_Static_TimedWarningCommand_IEnumerator_Single_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimedWarningCommand>(intPtr3) : null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000082D4 File Offset: 0x000064D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207979, XrefRangeEnd = 1207989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimedWarningCommand WarningAfter(this Command command, float warnAfter, string message, bool asError = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warnAfter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_WarningAfter_Public_Static_TimedWarningCommand_Command_Single_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimedWarningCommand>(intPtr3) : null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00008348 File Offset: 0x00006548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207989, XrefRangeEnd = 1207998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command WaitFor(this Command toAwait)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toAwait);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_WaitFor_Public_Static_Command_Command_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000838C File Offset: 0x0000658C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207998, XrefRangeEnd = 1208008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command WithActivatedObject(this IEnumerator command, GameObject spinner)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_WithActivatedObject_Public_Static_Command_IEnumerator_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000083E4 File Offset: 0x000065E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208008, XrefRangeEnd = 1208018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command WithActivatedObject(this IEnumerator command, GameObject spinner, float after)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_WithActivatedObject_Public_Static_Command_IEnumerator_GameObject_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00008448 File Offset: 0x00006648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1208022, RefRangeEnd = 1208024, XrefRangeStart = 1208018, XrefRangeEnd = 1208022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WithAnimationParameter<T> WithAnimationParameter<T>(this T command, Animator animator, string parameterName, bool state = true, int minDuration = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = command;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref command;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(animator);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDuration;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.MethodInfoStoreGeneric_WithAnimationParameter_Public_Static_WithAnimationParameter_1_T_T_Animator_String_Boolean_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<WithAnimationParameter<T>>(intPtr4) : null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00008504 File Offset: 0x00006704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208024, XrefRangeEnd = 1208028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command Parallel([Optional] Il2CppReferenceArray<Command> commands)
		{
			if (commands == null)
			{
				commands = new Il2CppReferenceArray<Command>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commands);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_Parallel_Public_Static_Command_Il2CppReferenceArray_1_Command_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00008558 File Offset: 0x00006758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1208032, RefRangeEnd = 1208033, XrefRangeStart = 1208028, XrefRangeEnd = 1208032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command Parallel(this IEnumerable<Command> commands)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commands);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_Parallel_Public_Static_Command_IEnumerable_1_Command_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000859C File Offset: 0x0000679C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208033, XrefRangeEnd = 1208048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command Parallel(this IEnumerable<Command> commands, float staggerTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(commands);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref staggerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_Parallel_Public_Static_Command_IEnumerable_1_Command_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000085F0 File Offset: 0x000067F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208048, XrefRangeEnd = 1208063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command ThenParallel(this IEnumerator command, [Optional] Il2CppReferenceArray<Command> commands)
		{
			if (commands == null)
			{
				commands = new Il2CppReferenceArray<Command>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commands);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_ThenParallel_Public_Static_Command_IEnumerator_Il2CppReferenceArray_1_Command_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00008654 File Offset: 0x00006854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208063, XrefRangeEnd = 1208078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command ThenParallel(this IEnumerator command, IEnumerable<Command> commands)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commands);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.NativeMethodInfoPtr_ThenParallel_Public_Static_Command_IEnumerator_IEnumerable_1_Command_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002547 File Offset: 0x00000747
		public static Command Parallel(params Command[] commands)
		{
			return DecoratorExtentions.Parallel(new Il2CppReferenceArray<Command>(commands));
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002554 File Offset: 0x00000754
		public static Command ThenParallel(IEnumerator command, params Command[] commands)
		{
			return command.ThenParallel(new Il2CppReferenceArray<Command>(commands));
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002562 File Offset: 0x00000762
		public DecoratorExtentions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_AsAsync_Public_Static_Command_IEnumerator_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_AsCommand_Public_Static_Command_IEnumerator_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Action_1_T_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Action_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_DelayFor_Public_Static_Command_IEnumerator_Single_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_DelayFor_Public_Static_Command_AtomicAction_Single_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_WithInterrupt_Public_Static_InterruptableCommand_IEnumerator_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_InterruptAfter_Public_Static_IFailable_IEnumerator_Single_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_InterruptAfter_Public_Static_IFailable_InterruptableCommand_Single_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Static_IEnumerator_IEnumerator_IEnumerator_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_IEnumerator_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_ThenEither_Public_Static_Command_T_Func_2_T_Boolean_IEnumerator_IEnumerator_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_ThenEither_Public_Static_Command_T_Func_2_T_Boolean_Func_2_T_IEnumerator_Func_2_T_IEnumerator_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_ThenEither_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_1_T_Action_1_T_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_ThenEither_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_Action_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_IEnumerator_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_1_T_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Func_2_T_IEnumerator_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_ThenLog_Public_Static_IEnumerator_IEnumerator_Object_Boolean_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_ThenMaybeLog_Public_Static_IFailable_IFailable_Object_Boolean_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_ThenMaybeLog_Public_Static_IFailable_TCommand_Func_2_TCommand_Object_Boolean_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_WarningAfter_Public_Static_TimedWarningCommand_IEnumerator_Single_String_Boolean_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_WarningAfter_Public_Static_TimedWarningCommand_Command_Single_String_Boolean_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_WaitFor_Public_Static_Command_Command_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_WithActivatedObject_Public_Static_Command_IEnumerator_GameObject_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_WithActivatedObject_Public_Static_Command_IEnumerator_GameObject_Single_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_WithAnimationParameter_Public_Static_WithAnimationParameter_1_T_T_Animator_String_Boolean_Int32_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_Parallel_Public_Static_Command_Il2CppReferenceArray_1_Command_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_Parallel_Public_Static_Command_IEnumerable_1_Command_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_Parallel_Public_Static_Command_IEnumerable_1_Command_Single_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_ThenParallel_Public_Static_Command_IEnumerator_Il2CppReferenceArray_1_Command_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_ThenParallel_Public_Static_Command_IEnumerator_IEnumerable_1_Command_0;

		// Token: 0x02000046 RID: 70
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<>c__DisplayClass11_0`1")]
		public sealed class __c__DisplayClass11_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060002C5 RID: 709 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass11_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<>c__DisplayClass11_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass11_0<T>>.NativeClassPtr);
				DecoratorExtentions.__c__DisplayClass11_0<T>.NativeFieldInfoPtr_trueCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass11_0<T>>.NativeClassPtr, "trueCommand");
				DecoratorExtentions.__c__DisplayClass11_0<T>.NativeFieldInfoPtr_falseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass11_0<T>>.NativeClassPtr, "falseCommand");
				DecoratorExtentions.__c__DisplayClass11_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass11_0<T>>.NativeClassPtr, 100663483);
				DecoratorExtentions.__c__DisplayClass11_0<T>.NativeMethodInfoPtr__ThenEither_b__0_Internal_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass11_0<T>>.NativeClassPtr, 100663484);
				DecoratorExtentions.__c__DisplayClass11_0<T>.NativeMethodInfoPtr__ThenEither_b__1_Internal_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass11_0<T>>.NativeClassPtr, 100663485);
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x0000EE70 File Offset: 0x0000D070
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass11_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass11_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x0000EEAC File Offset: 0x0000D0AC
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _ThenEither_b__0(T c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = c;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass11_0<T>.NativeMethodInfoPtr__ThenEither_b__0_Internal_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
				}
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x0000EF34 File Offset: 0x0000D134
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _ThenEither_b__1(T c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = c;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass11_0<T>.NativeMethodInfoPtr__ThenEither_b__1_Internal_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
				}
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x00003369 File Offset: 0x00001569
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060002CA RID: 714 RVA: 0x0000EFBC File Offset: 0x0000D1BC
			// (set) Token: 0x060002CB RID: 715 RVA: 0x00003372 File Offset: 0x00001572
			public unsafe IEnumerator trueCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass11_0<T>.NativeFieldInfoPtr_trueCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass11_0<T>.NativeFieldInfoPtr_trueCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x060002CC RID: 716 RVA: 0x0000EFEC File Offset: 0x0000D1EC
			// (set) Token: 0x060002CD RID: 717 RVA: 0x00003391 File Offset: 0x00001591
			public unsafe IEnumerator falseCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass11_0<T>.NativeFieldInfoPtr_falseCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass11_0<T>.NativeFieldInfoPtr_falseCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001B5 RID: 437
			private static readonly IntPtr NativeFieldInfoPtr_trueCommand;

			// Token: 0x040001B6 RID: 438
			private static readonly IntPtr NativeFieldInfoPtr_falseCommand;

			// Token: 0x040001B7 RID: 439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001B8 RID: 440
			private static readonly IntPtr NativeMethodInfoPtr__ThenEither_b__0_Internal_IEnumerator_T_0;

			// Token: 0x040001B9 RID: 441
			private static readonly IntPtr NativeMethodInfoPtr__ThenEither_b__1_Internal_IEnumerator_T_0;
		}

		// Token: 0x02000047 RID: 71
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<>c__DisplayClass13_0`1")]
		public sealed class __c__DisplayClass13_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060002CE RID: 718 RVA: 0x0000F01C File Offset: 0x0000D21C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass13_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<>c__DisplayClass13_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass13_0<T>>.NativeClassPtr);
				DecoratorExtentions.__c__DisplayClass13_0<T>.NativeFieldInfoPtr_trueCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass13_0<T>>.NativeClassPtr, "trueCommand");
				DecoratorExtentions.__c__DisplayClass13_0<T>.NativeFieldInfoPtr_falseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass13_0<T>>.NativeClassPtr, "falseCommand");
				DecoratorExtentions.__c__DisplayClass13_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass13_0<T>>.NativeClassPtr, 100663486);
				DecoratorExtentions.__c__DisplayClass13_0<T>.NativeMethodInfoPtr__ThenEither_b__0_Internal_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass13_0<T>>.NativeClassPtr, 100663487);
				DecoratorExtentions.__c__DisplayClass13_0<T>.NativeMethodInfoPtr__ThenEither_b__1_Internal_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass13_0<T>>.NativeClassPtr, 100663488);
			}

			// Token: 0x060002CF RID: 719 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass13_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass13_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x0000F124 File Offset: 0x0000D324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207601, XrefRangeEnd = 1207605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _ThenEither_b__0(T c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = c;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass13_0<T>.NativeMethodInfoPtr__ThenEither_b__0_Internal_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
				}
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x0000F1AC File Offset: 0x0000D3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207605, XrefRangeEnd = 1207609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _ThenEither_b__1(T c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = c;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass13_0<T>.NativeMethodInfoPtr__ThenEither_b__1_Internal_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
				}
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x000033B0 File Offset: 0x000015B0
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000F234 File Offset: 0x0000D434
			// (set) Token: 0x060002D4 RID: 724 RVA: 0x000033B9 File Offset: 0x000015B9
			public unsafe Action<T> trueCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass13_0<T>.NativeFieldInfoPtr_trueCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass13_0<T>.NativeFieldInfoPtr_trueCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000F264 File Offset: 0x0000D464
			// (set) Token: 0x060002D6 RID: 726 RVA: 0x000033D8 File Offset: 0x000015D8
			public unsafe Action<T> falseCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass13_0<T>.NativeFieldInfoPtr_falseCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass13_0<T>.NativeFieldInfoPtr_falseCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001BA RID: 442
			private static readonly IntPtr NativeFieldInfoPtr_trueCommand;

			// Token: 0x040001BB RID: 443
			private static readonly IntPtr NativeFieldInfoPtr_falseCommand;

			// Token: 0x040001BC RID: 444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001BD RID: 445
			private static readonly IntPtr NativeMethodInfoPtr__ThenEither_b__0_Internal_IEnumerator_T_0;

			// Token: 0x040001BE RID: 446
			private static readonly IntPtr NativeMethodInfoPtr__ThenEither_b__1_Internal_IEnumerator_T_0;
		}

		// Token: 0x02000048 RID: 72
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<>c__DisplayClass14_0`1")]
		public sealed class __c__DisplayClass14_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060002D7 RID: 727 RVA: 0x0000F294 File Offset: 0x0000D494
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass14_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<>c__DisplayClass14_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass14_0<T>>.NativeClassPtr);
				DecoratorExtentions.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_trueCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass14_0<T>>.NativeClassPtr, "trueCommand");
				DecoratorExtentions.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_falseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass14_0<T>>.NativeClassPtr, "falseCommand");
				DecoratorExtentions.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass14_0<T>>.NativeClassPtr, 100663489);
				DecoratorExtentions.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__ThenEither_b__0_Internal_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass14_0<T>>.NativeClassPtr, 100663490);
				DecoratorExtentions.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__ThenEither_b__1_Internal_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass14_0<T>>.NativeClassPtr, 100663491);
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x0000F360 File Offset: 0x0000D560
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass14_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x0000F39C File Offset: 0x0000D59C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207609, XrefRangeEnd = 1207613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _ThenEither_b__0(T c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = c;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__ThenEither_b__0_Internal_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
				}
			}

			// Token: 0x060002DA RID: 730 RVA: 0x0000F424 File Offset: 0x0000D624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207613, XrefRangeEnd = 1207617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _ThenEither_b__1(T c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = c;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass14_0<T>.NativeMethodInfoPtr__ThenEither_b__1_Internal_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
				}
			}

			// Token: 0x060002DB RID: 731 RVA: 0x000033F7 File Offset: 0x000015F7
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x060002DC RID: 732 RVA: 0x0000F4AC File Offset: 0x0000D6AC
			// (set) Token: 0x060002DD RID: 733 RVA: 0x00003400 File Offset: 0x00001600
			public unsafe Action trueCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_trueCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_trueCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x060002DE RID: 734 RVA: 0x0000F4DC File Offset: 0x0000D6DC
			// (set) Token: 0x060002DF RID: 735 RVA: 0x0000341F File Offset: 0x0000161F
			public unsafe Action falseCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_falseCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass14_0<T>.NativeFieldInfoPtr_falseCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001BF RID: 447
			private static readonly IntPtr NativeFieldInfoPtr_trueCommand;

			// Token: 0x040001C0 RID: 448
			private static readonly IntPtr NativeFieldInfoPtr_falseCommand;

			// Token: 0x040001C1 RID: 449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001C2 RID: 450
			private static readonly IntPtr NativeMethodInfoPtr__ThenEither_b__0_Internal_IEnumerator_T_0;

			// Token: 0x040001C3 RID: 451
			private static readonly IntPtr NativeMethodInfoPtr__ThenEither_b__1_Internal_IEnumerator_T_0;
		}

		// Token: 0x02000049 RID: 73
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<>c__DisplayClass15_0`1")]
		public sealed class __c__DisplayClass15_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060002E0 RID: 736 RVA: 0x0000F50C File Offset: 0x0000D70C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass15_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<>c__DisplayClass15_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass15_0<T>>.NativeClassPtr);
				DecoratorExtentions.__c__DisplayClass15_0<T>.NativeFieldInfoPtr_trueCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass15_0<T>>.NativeClassPtr, "trueCommand");
				DecoratorExtentions.__c__DisplayClass15_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass15_0<T>>.NativeClassPtr, 100663492);
				DecoratorExtentions.__c__DisplayClass15_0<T>.NativeMethodInfoPtr__Then_b__0_Internal_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass15_0<T>>.NativeClassPtr, 100663493);
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x0000F5B0 File Offset: 0x0000D7B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass15_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass15_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x0000F5EC File Offset: 0x0000D7EC
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _Then_b__0(T c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = c;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass15_0<T>.NativeMethodInfoPtr__Then_b__0_Internal_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
				}
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x0000343E File Offset: 0x0000163E
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000F674 File Offset: 0x0000D874
			// (set) Token: 0x060002E5 RID: 741 RVA: 0x00003447 File Offset: 0x00001647
			public unsafe IEnumerator trueCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass15_0<T>.NativeFieldInfoPtr_trueCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass15_0<T>.NativeFieldInfoPtr_trueCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001C4 RID: 452
			private static readonly IntPtr NativeFieldInfoPtr_trueCommand;

			// Token: 0x040001C5 RID: 453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001C6 RID: 454
			private static readonly IntPtr NativeMethodInfoPtr__Then_b__0_Internal_IEnumerator_T_0;
		}

		// Token: 0x0200004A RID: 74
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<>c__DisplayClass16_0`1")]
		public sealed class __c__DisplayClass16_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060002E6 RID: 742 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass16_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<>c__DisplayClass16_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass16_0<T>>.NativeClassPtr);
				DecoratorExtentions.__c__DisplayClass16_0<T>.NativeFieldInfoPtr_trueGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass16_0<T>>.NativeClassPtr, "trueGenerator");
				DecoratorExtentions.__c__DisplayClass16_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass16_0<T>>.NativeClassPtr, 100663494);
				DecoratorExtentions.__c__DisplayClass16_0<T>.NativeMethodInfoPtr__Then_b__0_Internal_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass16_0<T>>.NativeClassPtr, 100663495);
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0000F748 File Offset: 0x0000D948
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass16_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass16_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x0000F784 File Offset: 0x0000D984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207617, XrefRangeEnd = 1207620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _Then_b__0(T c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = c;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass16_0<T>.NativeMethodInfoPtr__Then_b__0_Internal_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
				}
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x00003466 File Offset: 0x00001666
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x060002EA RID: 746 RVA: 0x0000F80C File Offset: 0x0000DA0C
			// (set) Token: 0x060002EB RID: 747 RVA: 0x0000346F File Offset: 0x0000166F
			public unsafe Action<T> trueGenerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass16_0<T>.NativeFieldInfoPtr_trueGenerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass16_0<T>.NativeFieldInfoPtr_trueGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001C7 RID: 455
			private static readonly IntPtr NativeFieldInfoPtr_trueGenerator;

			// Token: 0x040001C8 RID: 456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001C9 RID: 457
			private static readonly IntPtr NativeMethodInfoPtr__Then_b__0_Internal_IEnumerator_T_0;
		}

		// Token: 0x0200004B RID: 75
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<>c__DisplayClass17_0`1")]
		public sealed class __c__DisplayClass17_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060002EC RID: 748 RVA: 0x0000F83C File Offset: 0x0000DA3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass17_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<>c__DisplayClass17_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass17_0<T>>.NativeClassPtr);
				DecoratorExtentions.__c__DisplayClass17_0<T>.NativeFieldInfoPtr_trueGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass17_0<T>>.NativeClassPtr, "trueGenerator");
				DecoratorExtentions.__c__DisplayClass17_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass17_0<T>>.NativeClassPtr, 100663496);
				DecoratorExtentions.__c__DisplayClass17_0<T>.NativeMethodInfoPtr__Then_b__0_Internal_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass17_0<T>>.NativeClassPtr, 100663497);
			}

			// Token: 0x060002ED RID: 749 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass17_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass17_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EE RID: 750 RVA: 0x0000F91C File Offset: 0x0000DB1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207620, XrefRangeEnd = 1207624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _Then_b__0(T c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = c;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass17_0<T>.NativeMethodInfoPtr__Then_b__0_Internal_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
				}
			}

			// Token: 0x060002EF RID: 751 RVA: 0x0000348E File Offset: 0x0000168E
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
			// (set) Token: 0x060002F1 RID: 753 RVA: 0x00003497 File Offset: 0x00001697
			public unsafe Action trueGenerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass17_0<T>.NativeFieldInfoPtr_trueGenerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass17_0<T>.NativeFieldInfoPtr_trueGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001CA RID: 458
			private static readonly IntPtr NativeFieldInfoPtr_trueGenerator;

			// Token: 0x040001CB RID: 459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001CC RID: 460
			private static readonly IntPtr NativeMethodInfoPtr__Then_b__0_Internal_IEnumerator_T_0;
		}

		// Token: 0x0200004C RID: 76
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060002F2 RID: 754 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass19_0>.NativeClassPtr);
				DecoratorExtentions.__c__DisplayClass19_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass19_0>.NativeClassPtr, "message");
				DecoratorExtentions.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass19_0>.NativeClassPtr, 100663498);
				DecoratorExtentions.__c__DisplayClass19_0.NativeMethodInfoPtr__ThenLog_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass19_0>.NativeClassPtr, 100663499);
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x0000FA3C File Offset: 0x0000DC3C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F4 RID: 756 RVA: 0x0000FA78 File Offset: 0x0000DC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207624, XrefRangeEnd = 1207628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThenLog_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass19_0.NativeMethodInfoPtr__ThenLog_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x000034B6 File Offset: 0x000016B6
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000FAAC File Offset: 0x0000DCAC
			// (set) Token: 0x060002F7 RID: 759 RVA: 0x000034BF File Offset: 0x000016BF
			public unsafe global::Il2CppSystem.Object message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass19_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass19_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001CD RID: 461
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x040001CE RID: 462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001CF RID: 463
			private static readonly IntPtr NativeMethodInfoPtr__ThenLog_b__0_Internal_Void_0;
		}

		// Token: 0x0200004D RID: 77
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060002F8 RID: 760 RVA: 0x0000FADC File Offset: 0x0000DCDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass20_0>.NativeClassPtr);
				DecoratorExtentions.__c__DisplayClass20_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass20_0>.NativeClassPtr, "message");
				DecoratorExtentions.__c__DisplayClass20_0.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass20_0>.NativeClassPtr, "command");
				DecoratorExtentions.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass20_0>.NativeClassPtr, 100663500);
				DecoratorExtentions.__c__DisplayClass20_0.NativeMethodInfoPtr__ThenMaybeLog_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass20_0>.NativeClassPtr, 100663501);
				DecoratorExtentions.__c__DisplayClass20_0.NativeMethodInfoPtr__ThenMaybeLog_b__1_Internal_ErrorInfo_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass20_0>.NativeClassPtr, 100663502);
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x0000FB6C File Offset: 0x0000DD6C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002FA RID: 762 RVA: 0x0000FBA8 File Offset: 0x0000DDA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207628, XrefRangeEnd = 1207632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThenMaybeLog_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass20_0.NativeMethodInfoPtr__ThenMaybeLog_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002FB RID: 763 RVA: 0x0000FBDC File Offset: 0x0000DDDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207632, XrefRangeEnd = 1207635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _ThenMaybeLog_b__1(IEnumerator _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass20_0.NativeMethodInfoPtr__ThenMaybeLog_b__1_Internal_ErrorInfo_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060002FC RID: 764 RVA: 0x000034DE File Offset: 0x000016DE
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x060002FD RID: 765 RVA: 0x0000FC24 File Offset: 0x0000DE24
			// (set) Token: 0x060002FE RID: 766 RVA: 0x000034E7 File Offset: 0x000016E7
			public unsafe global::Il2CppSystem.Object message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass20_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass20_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x060002FF RID: 767 RVA: 0x0000FC54 File Offset: 0x0000DE54
			// (set) Token: 0x06000300 RID: 768 RVA: 0x00003506 File Offset: 0x00001706
			public unsafe IFailable command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass20_0.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass20_0.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D0 RID: 464
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x040001D1 RID: 465
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040001D2 RID: 466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001D3 RID: 467
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybeLog_b__0_Internal_Void_0;

			// Token: 0x040001D4 RID: 468
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybeLog_b__1_Internal_ErrorInfo_IEnumerator_0;
		}

		// Token: 0x0200004E RID: 78
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<>c__DisplayClass21_0`1")]
		public sealed class __c__DisplayClass21_0<TCommand> : global::Il2CppSystem.Object
		{
			// Token: 0x06000301 RID: 769 RVA: 0x0000FC84 File Offset: 0x0000DE84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass21_0<TCommand>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<>c__DisplayClass21_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCommand>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass21_0<TCommand>>.NativeClassPtr);
				DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeFieldInfoPtr_messageGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass21_0<TCommand>>.NativeClassPtr, "messageGenerator");
				DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass21_0<TCommand>>.NativeClassPtr, "command");
				DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass21_0<TCommand>>.NativeClassPtr, 100663503);
				DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeMethodInfoPtr__ThenMaybeLog_b__0_Internal_Void_TCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass21_0<TCommand>>.NativeClassPtr, 100663504);
				DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeMethodInfoPtr__ThenMaybeLog_b__1_Internal_ErrorInfo_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass21_0<TCommand>>.NativeClassPtr, 100663505);
			}

			// Token: 0x06000302 RID: 770 RVA: 0x0000FD50 File Offset: 0x0000DF50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions.__c__DisplayClass21_0<TCommand>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000303 RID: 771 RVA: 0x0000FD8C File Offset: 0x0000DF8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207635, XrefRangeEnd = 1207642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThenMaybeLog_b__0(TCommand c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TCommand).IsValueType)
					{
						TCommand tcommand = c;
						intPtr = ((tcommand is string) ? IL2CPP.ManagedStringToIl2Cpp(tcommand as string) : IL2CPP.Il2CppObjectBaseToPtr(tcommand as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeMethodInfoPtr__ThenMaybeLog_b__0_Internal_Void_TCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06000304 RID: 772 RVA: 0x0000FE04 File Offset: 0x0000E004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207642, XrefRangeEnd = 1207647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _ThenMaybeLog_b__1(IFailable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeMethodInfoPtr__ThenMaybeLog_b__1_Internal_ErrorInfo_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x06000305 RID: 773 RVA: 0x00003525 File Offset: 0x00001725
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000306 RID: 774 RVA: 0x0000FE4C File Offset: 0x0000E04C
			// (set) Token: 0x06000307 RID: 775 RVA: 0x0000352E File Offset: 0x0000172E
			public unsafe Func<TCommand, global::Il2CppSystem.Object> messageGenerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeFieldInfoPtr_messageGenerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TCommand, global::Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeFieldInfoPtr_messageGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000308 RID: 776 RVA: 0x0000FE7C File Offset: 0x0000E07C
			// (set) Token: 0x06000309 RID: 777 RVA: 0x0000FEA4 File Offset: 0x0000E0A4
			public unsafe TCommand command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeFieldInfoPtr_command);
					return IL2CPP.PointerToValueGeneric<TCommand>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions.__c__DisplayClass21_0<TCommand>.NativeFieldInfoPtr_command);
					Type typeFromHandle = typeof(TCommand);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x040001D5 RID: 469
			private static readonly IntPtr NativeFieldInfoPtr_messageGenerator;

			// Token: 0x040001D6 RID: 470
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040001D7 RID: 471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001D8 RID: 472
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybeLog_b__0_Internal_Void_TCommand_0;

			// Token: 0x040001D9 RID: 473
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybeLog_b__1_Internal_ErrorInfo_IFailable_0;
		}

		// Token: 0x0200004F RID: 79
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<Then>d__10`1")]
		public sealed class _Then_d__10<T> : global::Il2CppSystem.Object
		{
			// Token: 0x0600030A RID: 778 RVA: 0x0000FF4C File Offset: 0x0000E14C
			// Note: this type is marked as 'beforefieldinit'.
			static _Then_d__10()
			{
				Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<Then>d__10`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr);
				DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, "<>1__state");
				DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, "<>2__current");
				DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, "command");
				DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr_thenGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, "thenGenerator");
				DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr__then_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, "<then>5__2");
				DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, 100663506);
				DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, 100663507);
				DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, 100663508);
				DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, 100663509);
				DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, 100663510);
				DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr, 100663511);
			}

			// Token: 0x0600030B RID: 779 RVA: 0x00010090 File Offset: 0x0000E290
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Then_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions._Then_d__10<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600030C RID: 780 RVA: 0x000100D8 File Offset: 0x0000E2D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600030D RID: 781 RVA: 0x0001010C File Offset: 0x0000E30C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207647, XrefRangeEnd = 1207648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600030E RID: 782 RVA: 0x00010148 File Offset: 0x0000E348
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600030F RID: 783 RVA: 0x00010188 File Offset: 0x0000E388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000310 RID: 784 RVA: 0x000101BC File Offset: 0x0000E3BC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__10<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000311 RID: 785 RVA: 0x0000354D File Offset: 0x0000174D
			public _Then_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000312 RID: 786 RVA: 0x000101FC File Offset: 0x0000E3FC
			// (set) Token: 0x06000313 RID: 787 RVA: 0x00003556 File Offset: 0x00001756
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000314 RID: 788 RVA: 0x00010224 File Offset: 0x0000E424
			// (set) Token: 0x06000315 RID: 789 RVA: 0x00003571 File Offset: 0x00001771
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000316 RID: 790 RVA: 0x00010254 File Offset: 0x0000E454
			// (set) Token: 0x06000317 RID: 791 RVA: 0x0001027C File Offset: 0x0000E47C
			public unsafe T command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr_command);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr_command);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000318 RID: 792 RVA: 0x00010324 File Offset: 0x0000E524
			// (set) Token: 0x06000319 RID: 793 RVA: 0x00003590 File Offset: 0x00001790
			public unsafe Func<T, IEnumerator> thenGenerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr_thenGenerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr_thenGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x0600031A RID: 794 RVA: 0x00010354 File Offset: 0x0000E554
			// (set) Token: 0x0600031B RID: 795 RVA: 0x000035AF File Offset: 0x000017AF
			public unsafe IEnumerator _then_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr__then_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__10<T>.NativeFieldInfoPtr__then_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001DA RID: 474
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001DC RID: 476
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040001DD RID: 477
			private static readonly IntPtr NativeFieldInfoPtr_thenGenerator;

			// Token: 0x040001DE RID: 478
			private static readonly IntPtr NativeFieldInfoPtr__then_5__2;

			// Token: 0x040001DF RID: 479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001E0 RID: 480
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001E1 RID: 481
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001E2 RID: 482
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001E3 RID: 483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001E4 RID: 484
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000050 RID: 80
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<Then>d__18`1")]
		public sealed class _Then_d__18<T> : global::Il2CppSystem.Object
		{
			// Token: 0x0600031C RID: 796 RVA: 0x00010384 File Offset: 0x0000E584
			// Note: this type is marked as 'beforefieldinit'.
			static _Then_d__18()
			{
				Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<Then>d__18`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr);
				DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, "<>1__state");
				DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, "<>2__current");
				DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, "command");
				DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr_either = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, "either");
				DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr_trueGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, "trueGenerator");
				DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr__trueCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, "<trueCommand>5__2");
				DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, 100663512);
				DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, 100663513);
				DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, 100663514);
				DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, 100663515);
				DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, 100663516);
				DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr, 100663517);
			}

			// Token: 0x0600031D RID: 797 RVA: 0x000104DC File Offset: 0x0000E6DC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Then_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions._Then_d__18<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600031E RID: 798 RVA: 0x00010524 File Offset: 0x0000E724
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600031F RID: 799 RVA: 0x00010558 File Offset: 0x0000E758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207648, XrefRangeEnd = 1207655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x06000320 RID: 800 RVA: 0x00010594 File Offset: 0x0000E794
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000321 RID: 801 RVA: 0x000105D4 File Offset: 0x0000E7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x06000322 RID: 802 RVA: 0x00010608 File Offset: 0x0000E808
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__18<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000323 RID: 803 RVA: 0x000035CE File Offset: 0x000017CE
			public _Then_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000324 RID: 804 RVA: 0x00010648 File Offset: 0x0000E848
			// (set) Token: 0x06000325 RID: 805 RVA: 0x000035D7 File Offset: 0x000017D7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x06000326 RID: 806 RVA: 0x00010670 File Offset: 0x0000E870
			// (set) Token: 0x06000327 RID: 807 RVA: 0x000035F2 File Offset: 0x000017F2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x06000328 RID: 808 RVA: 0x000106A0 File Offset: 0x0000E8A0
			// (set) Token: 0x06000329 RID: 809 RVA: 0x000106C8 File Offset: 0x0000E8C8
			public unsafe T command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr_command);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr_command);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x0600032A RID: 810 RVA: 0x00010770 File Offset: 0x0000E970
			// (set) Token: 0x0600032B RID: 811 RVA: 0x00003611 File Offset: 0x00001811
			public unsafe Func<T, bool> either
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr_either);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr_either), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x0600032C RID: 812 RVA: 0x000107A0 File Offset: 0x0000E9A0
			// (set) Token: 0x0600032D RID: 813 RVA: 0x00003630 File Offset: 0x00001830
			public unsafe Func<T, IEnumerator> trueGenerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr_trueGenerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr_trueGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x0600032E RID: 814 RVA: 0x000107D0 File Offset: 0x0000E9D0
			// (set) Token: 0x0600032F RID: 815 RVA: 0x0000364F File Offset: 0x0000184F
			public unsafe IEnumerator _trueCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr__trueCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__18<T>.NativeFieldInfoPtr__trueCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001E5 RID: 485
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001E6 RID: 486
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001E7 RID: 487
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040001E8 RID: 488
			private static readonly IntPtr NativeFieldInfoPtr_either;

			// Token: 0x040001E9 RID: 489
			private static readonly IntPtr NativeFieldInfoPtr_trueGenerator;

			// Token: 0x040001EA RID: 490
			private static readonly IntPtr NativeFieldInfoPtr__trueCommand_5__2;

			// Token: 0x040001EB RID: 491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001EC RID: 492
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001ED RID: 493
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001EE RID: 494
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001EF RID: 495
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001F0 RID: 496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000051 RID: 81
		[ObfuscatedName("dwd.core.commands.DecoratorExtentions+<Then>d__9")]
		public sealed class _Then_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06000330 RID: 816 RVA: 0x00010800 File Offset: 0x0000EA00
			// Note: this type is marked as 'beforefieldinit'.
			static _Then_d__9()
			{
				Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr, "<Then>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr);
				DecoratorExtentions._Then_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr, "<>1__state");
				DecoratorExtentions._Then_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr, "<>2__current");
				DecoratorExtentions._Then_d__9.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr, "command");
				DecoratorExtentions._Then_d__9.NativeFieldInfoPtr_then = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr, "then");
				DecoratorExtentions._Then_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr, 100663518);
				DecoratorExtentions._Then_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr, 100663519);
				DecoratorExtentions._Then_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr, 100663520);
				DecoratorExtentions._Then_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr, 100663521);
				DecoratorExtentions._Then_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr, 100663522);
				DecoratorExtentions._Then_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr, 100663523);
			}

			// Token: 0x06000331 RID: 817 RVA: 0x000108F4 File Offset: 0x0000EAF4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Then_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtentions._Then_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000332 RID: 818 RVA: 0x0001093C File Offset: 0x0000EB3C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000333 RID: 819 RVA: 0x00010970 File Offset: 0x0000EB70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207655, XrefRangeEnd = 1207663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000334 RID: 820 RVA: 0x000109AC File Offset: 0x0000EBAC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000335 RID: 821 RVA: 0x000109EC File Offset: 0x0000EBEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207663, XrefRangeEnd = 1207668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000336 RID: 822 RVA: 0x00010A20 File Offset: 0x0000EC20
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtentions._Then_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000337 RID: 823 RVA: 0x0000366E File Offset: 0x0000186E
			public _Then_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000338 RID: 824 RVA: 0x00010A60 File Offset: 0x0000EC60
			// (set) Token: 0x06000339 RID: 825 RVA: 0x00003677 File Offset: 0x00001877
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x0600033A RID: 826 RVA: 0x00010A88 File Offset: 0x0000EC88
			// (set) Token: 0x0600033B RID: 827 RVA: 0x00003692 File Offset: 0x00001892
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x0600033C RID: 828 RVA: 0x00010AB8 File Offset: 0x0000ECB8
			// (set) Token: 0x0600033D RID: 829 RVA: 0x000036B1 File Offset: 0x000018B1
			public unsafe IEnumerator command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__9.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__9.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x0600033E RID: 830 RVA: 0x00010AE8 File Offset: 0x0000ECE8
			// (set) Token: 0x0600033F RID: 831 RVA: 0x000036D0 File Offset: 0x000018D0
			public unsafe IEnumerator then
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__9.NativeFieldInfoPtr_then);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtentions._Then_d__9.NativeFieldInfoPtr_then), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001F1 RID: 497
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001F2 RID: 498
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001F3 RID: 499
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040001F4 RID: 500
			private static readonly IntPtr NativeFieldInfoPtr_then;

			// Token: 0x040001F5 RID: 501
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001F6 RID: 502
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001F7 RID: 503
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001F8 RID: 504
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001F9 RID: 505
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001FA RID: 506
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000052 RID: 82
		private sealed class MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Action_1_T_0<T>
		{
			// Token: 0x040001FB RID: 507
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Action_1_T_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000053 RID: 83
		private sealed class MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Action_0<T>
		{
			// Token: 0x040001FC RID: 508
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Action_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000054 RID: 84
		private sealed class MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Func_2_T_IEnumerator_0<T>
		{
			// Token: 0x040001FD RID: 509
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_IEnumerator_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000055 RID: 85
		private sealed class MethodInfoStoreGeneric_ThenEither_Public_Static_Command_T_Func_2_T_Boolean_IEnumerator_IEnumerator_0<T>
		{
			// Token: 0x040001FE RID: 510
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_ThenEither_Public_Static_Command_T_Func_2_T_Boolean_IEnumerator_IEnumerator_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000056 RID: 86
		private sealed class MethodInfoStoreGeneric_ThenEither_Public_Static_Command_T_Func_2_T_Boolean_Func_2_T_IEnumerator_Func_2_T_IEnumerator_0<T>
		{
			// Token: 0x040001FF RID: 511
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_ThenEither_Public_Static_Command_T_Func_2_T_Boolean_Func_2_T_IEnumerator_Func_2_T_IEnumerator_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000057 RID: 87
		private sealed class MethodInfoStoreGeneric_ThenEither_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_1_T_Action_1_T_0<T>
		{
			// Token: 0x04000200 RID: 512
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_ThenEither_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_1_T_Action_1_T_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000058 RID: 88
		private sealed class MethodInfoStoreGeneric_ThenEither_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_Action_0<T>
		{
			// Token: 0x04000201 RID: 513
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_ThenEither_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_Action_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000059 RID: 89
		private sealed class MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_IEnumerator_0<T>
		{
			// Token: 0x04000202 RID: 514
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_IEnumerator_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005A RID: 90
		private sealed class MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_1_T_0<T>
		{
			// Token: 0x04000203 RID: 515
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_1_T_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005B RID: 91
		private sealed class MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_0<T>
		{
			// Token: 0x04000204 RID: 516
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Action_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005C RID: 92
		private sealed class MethodInfoStoreGeneric_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Func_2_T_IEnumerator_0<T>
		{
			// Token: 0x04000205 RID: 517
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_Then_Public_Static_IEnumerator_T_Func_2_T_Boolean_Func_2_T_IEnumerator_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005D RID: 93
		private sealed class MethodInfoStoreGeneric_ThenMaybeLog_Public_Static_IFailable_TCommand_Func_2_TCommand_Object_Boolean_0<TCommand>
		{
			// Token: 0x04000206 RID: 518
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_ThenMaybeLog_Public_Static_IFailable_TCommand_Func_2_TCommand_Object_Boolean_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCommand>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005E RID: 94
		private sealed class MethodInfoStoreGeneric_WithAnimationParameter_Public_Static_WithAnimationParameter_1_T_T_Animator_String_Boolean_Int32_0<T>
		{
			// Token: 0x04000207 RID: 519
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtentions.NativeMethodInfoPtr_WithAnimationParameter_Public_Static_WithAnimationParameter_1_T_T_Animator_String_Boolean_Int32_0, Il2CppClassPointerStore<DecoratorExtentions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
