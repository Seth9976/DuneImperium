using System;
using dwd.core.errorInfo;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace dwd.core.commands
{
	// Token: 0x0200001E RID: 30
	public static class DecoratorExtensions : Object
	{
		// Token: 0x06000131 RID: 305 RVA: 0x000097CC File Offset: 0x000079CC
		// Note: this type is marked as 'beforefieldinit'.
		static DecoratorExtensions()
		{
			Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "DecoratorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr);
			DecoratorExtensions.NativeMethodInfoPtr_WithInterruptOnAction_Public_Static_InterruptCommandOnAction_IEnumerator_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663592);
			DecoratorExtensions.NativeMethodInfoPtr_WithExceptionHandling_Public_Static_IFailable_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663593);
			DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_IFailable_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663594);
			DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_IFailable_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663595);
			DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_IFailable_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663596);
			DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663597);
			DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663598);
			DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663599);
			DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_Func_2_ErrorInfo_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663600);
			DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_Action_1_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663601);
			DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663602);
			DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663603);
			DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663604);
			DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Action_1_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663605);
			DecoratorExtensions.NativeMethodInfoPtr_OrHandleError_Public_Static_IFailable_IFailable_IHandleErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663606);
			DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Func_2_ErrorInfo_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663607);
			DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Func_2_ErrorInfo_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663608);
			DecoratorExtensions.NativeMethodInfoPtr_Validate_Public_Static_Validator_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663609);
			DecoratorExtensions.NativeMethodInfoPtr_Validate_Public_Static_Validator_1_T_T_Func_2_T_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663610);
			DecoratorExtensions.NativeMethodInfoPtr_AndValidate_Public_Static_Validator_1_T_T_Func_2_T_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, 100663611);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000998C File Offset: 0x00007B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1208708, RefRangeEnd = 1208709, XrefRangeStart = 1208698, XrefRangeEnd = 1208708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InterruptCommandOnAction WithInterruptOnAction(this IEnumerator interruptable, Func<bool> shouldInterrupt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interruptable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shouldInterrupt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_WithInterruptOnAction_Public_Static_InterruptCommandOnAction_IEnumerator_Func_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InterruptCommandOnAction>(intPtr3) : null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000099E4 File Offset: 0x00007BE4
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1208718, RefRangeEnd = 1208751, XrefRangeStart = 1208709, XrefRangeEnd = 1208718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable WithExceptionHandling(this IEnumerator command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_WithExceptionHandling_Public_Static_IFailable_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00009A28 File Offset: 0x00007C28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1208772, RefRangeEnd = 1208776, XrefRangeStart = 1208751, XrefRangeEnd = 1208772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable ThenMaybe(this IFailable command, Action then)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(then);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_IFailable_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00009A80 File Offset: 0x00007C80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1208797, RefRangeEnd = 1208799, XrefRangeStart = 1208776, XrefRangeEnd = 1208797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable ThenMaybe(this IFailable command, IEnumerator then)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(then);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_IFailable_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00009AD8 File Offset: 0x00007CD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1208820, RefRangeEnd = 1208826, XrefRangeStart = 1208799, XrefRangeEnd = 1208820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable ThenMaybe(this IFailable command, IFailable then)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(then);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_IFailable_IFailable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00009B30 File Offset: 0x00007D30
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1208843, RefRangeEnd = 1208870, XrefRangeStart = 1208826, XrefRangeEnd = 1208843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable ThenMaybe<T>(this T command, Action<T> then)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(then);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.MethodInfoStoreGeneric_ThenMaybe_Public_Static_IFailable_T_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr4) : null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00009BBC File Offset: 0x00007DBC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1208843, RefRangeEnd = 1208870, XrefRangeStart = 1208843, XrefRangeEnd = 1208870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable ThenMaybe<T>(this T command, Func<T, IEnumerator> then)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(then);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.MethodInfoStoreGeneric_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IEnumerator_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr4) : null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00009C48 File Offset: 0x00007E48
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1208843, RefRangeEnd = 1208870, XrefRangeStart = 1208843, XrefRangeEnd = 1208870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable ThenMaybe<T>(this T command, Func<T, IFailable> then)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(then);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.MethodInfoStoreGeneric_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr4) : null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00009CD4 File Offset: 0x00007ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208870, XrefRangeEnd = 1208897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable ThenMaybe<T>(this T command, Func<T, IFailable> then, Func<ErrorInfo, IFailable> orElse)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(then);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orElse);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.MethodInfoStoreGeneric_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_Func_2_ErrorInfo_IFailable_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr4) : null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00009D74 File Offset: 0x00007F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable ThenMaybe<T>(this T command, Func<T, IFailable> then, Action<ErrorInfo> orElse)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(then);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orElse);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.MethodInfoStoreGeneric_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_Action_1_ErrorInfo_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr4) : null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00009E14 File Offset: 0x00008014
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1208910, RefRangeEnd = 1208913, XrefRangeStart = 1208897, XrefRangeEnd = 1208910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable OrElse(this IFailable command, Action orElse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orElse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00009E6C File Offset: 0x0000806C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1208926, RefRangeEnd = 1208928, XrefRangeStart = 1208913, XrefRangeEnd = 1208926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable OrElse(this IFailable command, IEnumerator orElse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orElse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00009EC4 File Offset: 0x000080C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208928, XrefRangeEnd = 1208941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable OrElse(this IFailable command, IFailable orElse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orElse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_IFailable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00009F1C File Offset: 0x0000811C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1208971, RefRangeEnd = 1208995, XrefRangeStart = 1208941, XrefRangeEnd = 1208971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable OrElse(this IFailable command, Action<ErrorInfo> orFail)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orFail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Action_1_ErrorInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00009F74 File Offset: 0x00008174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208995, XrefRangeEnd = 1209025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable OrHandleError(this IFailable command, IHandleErrorInfo handler)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_OrHandleError_Public_Static_IFailable_IFailable_IHandleErrorInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00009FCC File Offset: 0x000081CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1209055, RefRangeEnd = 1209059, XrefRangeStart = 1209025, XrefRangeEnd = 1209055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable OrElse(this IFailable command, Func<ErrorInfo, IEnumerator> orFail)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orFail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Func_2_ErrorInfo_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000A024 File Offset: 0x00008224
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1209089, RefRangeEnd = 1209093, XrefRangeStart = 1209059, XrefRangeEnd = 1209089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IFailable OrElse(this IFailable command, Func<ErrorInfo, IFailable> orFail)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orFail);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Func_2_ErrorInfo_IFailable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000A07C File Offset: 0x0000827C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209093, XrefRangeEnd = 1209115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Validator<T> Validate<T>(this T command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.MethodInfoStoreGeneric_Validate_Public_Static_Validator_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Validator<T>>(intPtr4) : null;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1209119, RefRangeEnd = 1209129, XrefRangeStart = 1209115, XrefRangeEnd = 1209119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Validator<T> Validate<T>(this T command, Func<T, ErrorInfo> validator)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validator);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.MethodInfoStoreGeneric_Validate_Public_Static_Validator_1_T_T_Func_2_T_ErrorInfo_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Validator<T>>(intPtr4) : null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000A184 File Offset: 0x00008384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1209140, RefRangeEnd = 1209141, XrefRangeStart = 1209129, XrefRangeEnd = 1209140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Validator<T> AndValidate<T>(this T command, Func<T, ErrorInfo> validator)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validator);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.MethodInfoStoreGeneric_AndValidate_Public_Static_Validator_1_T_T_Func_2_T_ErrorInfo_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Validator<T>>(intPtr4) : null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002759 File Offset: 0x00000959
		public DecoratorExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_WithInterruptOnAction_Public_Static_InterruptCommandOnAction_IEnumerator_Func_1_Boolean_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_WithExceptionHandling_Public_Static_IFailable_IEnumerator_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_IFailable_Action_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_IFailable_IEnumerator_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_IFailable_IFailable_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Action_1_T_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IEnumerator_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_Func_2_ErrorInfo_IFailable_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_Action_1_ErrorInfo_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Action_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_IEnumerator_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_IFailable_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Action_1_ErrorInfo_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_OrHandleError_Public_Static_IFailable_IFailable_IHandleErrorInfo_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Func_2_ErrorInfo_IEnumerator_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_OrElse_Public_Static_IFailable_IFailable_Func_2_ErrorInfo_IFailable_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Static_Validator_1_T_T_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Static_Validator_1_T_T_Func_2_T_ErrorInfo_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_AndValidate_Public_Static_Validator_1_T_T_Func_2_T_ErrorInfo_0;

		// Token: 0x02000066 RID: 102
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060003B5 RID: 949 RVA: 0x0001245C File Offset: 0x0001065C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr);
				DecoratorExtensions.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__2_2");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__3_2");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__10_1");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__11_1");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__12_1");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__13_0");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__13_3");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__14_0");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__14_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__14_3");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__15_0");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__15_2");
				DecoratorExtensions.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, "<>9__16_0");
				DecoratorExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663613);
				DecoratorExtensions.__c.NativeMethodInfoPtr__ThenMaybe_b__2_2_Internal_ErrorInfo_AtomicAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663614);
				DecoratorExtensions.__c.NativeMethodInfoPtr__ThenMaybe_b__3_2_Internal_ErrorInfo_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663615);
				DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__10_1_Internal_ErrorInfo_AtomicAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663616);
				DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__11_1_Internal_ErrorInfo_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663617);
				DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__12_1_Internal_ErrorInfo_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663618);
				DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__13_0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663619);
				DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__13_3_Internal_ErrorInfo_AtomicAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663620);
				DecoratorExtensions.__c.NativeMethodInfoPtr__OrHandleError_b__14_0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663621);
				DecoratorExtensions.__c.NativeMethodInfoPtr__OrHandleError_b__14_3_Internal_ErrorInfo_AtomicAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663622);
				DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__15_0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663623);
				DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__15_2_Internal_ErrorInfo_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663624);
				DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__16_0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr, 100663625);
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x00012690 File Offset: 0x00010890
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x000126CC File Offset: 0x000108CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208266, XrefRangeEnd = 1208270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _ThenMaybe_b__2_2(AtomicAction _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__ThenMaybe_b__2_2_Internal_ErrorInfo_AtomicAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x00012714 File Offset: 0x00010914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208270, XrefRangeEnd = 1208274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _ThenMaybe_b__3_2(IEnumerator _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__ThenMaybe_b__3_2_Internal_ErrorInfo_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x0001275C File Offset: 0x0001095C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208274, XrefRangeEnd = 1208278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _OrElse_b__10_1(AtomicAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__10_1_Internal_ErrorInfo_AtomicAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060003BA RID: 954 RVA: 0x000127A4 File Offset: 0x000109A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208278, XrefRangeEnd = 1208282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _OrElse_b__11_1(IEnumerator x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__11_1_Internal_ErrorInfo_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060003BB RID: 955 RVA: 0x000127EC File Offset: 0x000109EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208282, XrefRangeEnd = 1208286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _OrElse_b__12_1(IFailable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__12_1_Internal_ErrorInfo_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060003BC RID: 956 RVA: 0x00012834 File Offset: 0x00010A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208286, XrefRangeEnd = 1208299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrElse_b__13_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__13_0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00012874 File Offset: 0x00010A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208299, XrefRangeEnd = 1208303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _OrElse_b__13_3(AtomicAction _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__13_3_Internal_ErrorInfo_AtomicAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060003BE RID: 958 RVA: 0x000128BC File Offset: 0x00010ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208303, XrefRangeEnd = 1208316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrHandleError_b__14_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__OrHandleError_b__14_0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x060003BF RID: 959 RVA: 0x000128FC File Offset: 0x00010AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208316, XrefRangeEnd = 1208320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _OrHandleError_b__14_3(AtomicAction _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__OrHandleError_b__14_3_Internal_ErrorInfo_AtomicAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x00012944 File Offset: 0x00010B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208320, XrefRangeEnd = 1208333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrElse_b__15_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__15_0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x00012984 File Offset: 0x00010B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208333, XrefRangeEnd = 1208337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _OrElse_b__15_2(IEnumerator _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__15_2_Internal_ErrorInfo_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x000129CC File Offset: 0x00010BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208337, XrefRangeEnd = 1208350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrElse_b__16_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c.NativeMethodInfoPtr__OrElse_b__16_0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x000039F2 File Offset: 0x00001BF2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060003C4 RID: 964 RVA: 0x00012A0C File Offset: 0x00010C0C
			// (set) Token: 0x060003C5 RID: 965 RVA: 0x000039FB File Offset: 0x00001BFB
			public unsafe static DecoratorExtensions.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoratorExtensions.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060003C6 RID: 966 RVA: 0x00012A34 File Offset: 0x00010C34
			// (set) Token: 0x060003C7 RID: 967 RVA: 0x00003A0D File Offset: 0x00001C0D
			public unsafe static Func<AtomicAction, ErrorInfo> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AtomicAction, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060003C8 RID: 968 RVA: 0x00012A5C File Offset: 0x00010C5C
			// (set) Token: 0x060003C9 RID: 969 RVA: 0x00003A1F File Offset: 0x00001C1F
			public unsafe static Func<IEnumerator, ErrorInfo> __9__3_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__3_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__3_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x060003CA RID: 970 RVA: 0x00012A84 File Offset: 0x00010C84
			// (set) Token: 0x060003CB RID: 971 RVA: 0x00003A31 File Offset: 0x00001C31
			public unsafe static Func<AtomicAction, ErrorInfo> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AtomicAction, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x060003CC RID: 972 RVA: 0x00012AAC File Offset: 0x00010CAC
			// (set) Token: 0x060003CD RID: 973 RVA: 0x00003A43 File Offset: 0x00001C43
			public unsafe static Func<IEnumerator, ErrorInfo> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x060003CE RID: 974 RVA: 0x00012AD4 File Offset: 0x00010CD4
			// (set) Token: 0x060003CF RID: 975 RVA: 0x00003A55 File Offset: 0x00001C55
			public unsafe static Func<IFailable, ErrorInfo> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IFailable, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x060003D0 RID: 976 RVA: 0x00012AFC File Offset: 0x00010CFC
			// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003A67 File Offset: 0x00001C67
			public unsafe static Func<IFailable> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IFailable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x060003D2 RID: 978 RVA: 0x00012B24 File Offset: 0x00010D24
			// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003A79 File Offset: 0x00001C79
			public unsafe static Func<AtomicAction, ErrorInfo> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AtomicAction, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060003D4 RID: 980 RVA: 0x00012B4C File Offset: 0x00010D4C
			// (set) Token: 0x060003D5 RID: 981 RVA: 0x00003A8B File Offset: 0x00001C8B
			public unsafe static Func<IFailable> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IFailable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x060003D6 RID: 982 RVA: 0x00012B74 File Offset: 0x00010D74
			// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003A9D File Offset: 0x00001C9D
			public unsafe static Func<AtomicAction, ErrorInfo> __9__14_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__14_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AtomicAction, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__14_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060003D8 RID: 984 RVA: 0x00012B9C File Offset: 0x00010D9C
			// (set) Token: 0x060003D9 RID: 985 RVA: 0x00003AAF File Offset: 0x00001CAF
			public unsafe static Func<IFailable> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IFailable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x060003DA RID: 986 RVA: 0x00012BC4 File Offset: 0x00010DC4
			// (set) Token: 0x060003DB RID: 987 RVA: 0x00003AC1 File Offset: 0x00001CC1
			public unsafe static Func<IEnumerator, ErrorInfo> __9__15_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x060003DC RID: 988 RVA: 0x00012BEC File Offset: 0x00010DEC
			// (set) Token: 0x060003DD RID: 989 RVA: 0x00003AD3 File Offset: 0x00001CD3
			public unsafe static Func<IFailable> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IFailable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400024A RID: 586
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400024B RID: 587
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x0400024C RID: 588
			private static readonly IntPtr NativeFieldInfoPtr___9__3_2;

			// Token: 0x0400024D RID: 589
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x0400024E RID: 590
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x0400024F RID: 591
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04000250 RID: 592
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04000251 RID: 593
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x04000252 RID: 594
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04000253 RID: 595
			private static readonly IntPtr NativeFieldInfoPtr___9__14_3;

			// Token: 0x04000254 RID: 596
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04000255 RID: 597
			private static readonly IntPtr NativeFieldInfoPtr___9__15_2;

			// Token: 0x04000256 RID: 598
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04000257 RID: 599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000258 RID: 600
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__2_2_Internal_ErrorInfo_AtomicAction_0;

			// Token: 0x04000259 RID: 601
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__3_2_Internal_ErrorInfo_IEnumerator_0;

			// Token: 0x0400025A RID: 602
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__10_1_Internal_ErrorInfo_AtomicAction_0;

			// Token: 0x0400025B RID: 603
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__11_1_Internal_ErrorInfo_IEnumerator_0;

			// Token: 0x0400025C RID: 604
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__12_1_Internal_ErrorInfo_IFailable_0;

			// Token: 0x0400025D RID: 605
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__13_0_Internal_IFailable_0;

			// Token: 0x0400025E RID: 606
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__13_3_Internal_ErrorInfo_AtomicAction_0;

			// Token: 0x0400025F RID: 607
			private static readonly IntPtr NativeMethodInfoPtr__OrHandleError_b__14_0_Internal_IFailable_0;

			// Token: 0x04000260 RID: 608
			private static readonly IntPtr NativeMethodInfoPtr__OrHandleError_b__14_3_Internal_ErrorInfo_AtomicAction_0;

			// Token: 0x04000261 RID: 609
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__15_0_Internal_IFailable_0;

			// Token: 0x04000262 RID: 610
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__15_2_Internal_ErrorInfo_IEnumerator_0;

			// Token: 0x04000263 RID: 611
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__16_0_Internal_IFailable_0;
		}

		// Token: 0x02000067 RID: 103
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__17`1")]
		[Serializable]
		public sealed class __c__17<T> : Object
		{
			// Token: 0x060003DE RID: 990 RVA: 0x00012C14 File Offset: 0x00010E14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__17()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__17<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__17`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__17<T>>.NativeClassPtr);
				DecoratorExtensions.__c__17<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__17<T>>.NativeClassPtr, "<>9");
				DecoratorExtensions.__c__17<T>.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__17<T>>.NativeClassPtr, "<>9__17_0");
				DecoratorExtensions.__c__17<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__17<T>>.NativeClassPtr, 100663627);
				DecoratorExtensions.__c__17<T>.NativeMethodInfoPtr__Validate_b__17_0_Internal_ErrorInfo_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__17<T>>.NativeClassPtr, 100663628);
			}

			// Token: 0x060003DF RID: 991 RVA: 0x00012CCC File Offset: 0x00010ECC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__17()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__17<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__17<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x00012D08 File Offset: 0x00010F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208350, XrefRangeEnd = 1208354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _Validate_b__17_0(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__17<T>.NativeMethodInfoPtr__Validate_b__17_0_Internal_ErrorInfo_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return new ErrorInfo(intPtr2);
				}
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x00003AE5 File Offset: 0x00001CE5
			public __c__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x060003E2 RID: 994 RVA: 0x00012D88 File Offset: 0x00010F88
			// (set) Token: 0x060003E3 RID: 995 RVA: 0x00003AEE File Offset: 0x00001CEE
			public unsafe static DecoratorExtensions.__c__17<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c__17<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoratorExtensions.__c__17<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c__17<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x00012DB0 File Offset: 0x00010FB0
			// (set) Token: 0x060003E5 RID: 997 RVA: 0x00003B00 File Offset: 0x00001D00
			public unsafe static Func<T, ErrorInfo> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c__17<T>.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c__17<T>.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000264 RID: 612
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000265 RID: 613
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04000266 RID: 614
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000267 RID: 615
			private static readonly IntPtr NativeMethodInfoPtr__Validate_b__17_0_Internal_ErrorInfo_T_0;
		}

		// Token: 0x02000068 RID: 104
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__5`1")]
		[Serializable]
		public sealed class __c__5<T> : Object
		{
			// Token: 0x060003E6 RID: 998 RVA: 0x00012DD8 File Offset: 0x00010FD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__5()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__5<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__5`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__5<T>>.NativeClassPtr);
				DecoratorExtensions.__c__5<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__5<T>>.NativeClassPtr, "<>9");
				DecoratorExtensions.__c__5<T>.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__5<T>>.NativeClassPtr, "<>9__5_3");
				DecoratorExtensions.__c__5<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__5<T>>.NativeClassPtr, 100663630);
				DecoratorExtensions.__c__5<T>.NativeMethodInfoPtr__ThenMaybe_b__5_3_Internal_ErrorInfo_AtomicAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__5<T>>.NativeClassPtr, 100663631);
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x00012E90 File Offset: 0x00011090
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__5()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__5<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__5<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x00012ECC File Offset: 0x000110CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208354, XrefRangeEnd = 1208358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _ThenMaybe_b__5_3(AtomicAction _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__5<T>.NativeMethodInfoPtr__ThenMaybe_b__5_3_Internal_ErrorInfo_AtomicAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x00003B12 File Offset: 0x00001D12
			public __c__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x00012F14 File Offset: 0x00011114
			// (set) Token: 0x060003EB RID: 1003 RVA: 0x00003B1B File Offset: 0x00001D1B
			public unsafe static DecoratorExtensions.__c__5<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c__5<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoratorExtensions.__c__5<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c__5<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x060003EC RID: 1004 RVA: 0x00012F3C File Offset: 0x0001113C
			// (set) Token: 0x060003ED RID: 1005 RVA: 0x00003B2D File Offset: 0x00001D2D
			public unsafe static Func<AtomicAction, ErrorInfo> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c__5<T>.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AtomicAction, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c__5<T>.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000268 RID: 616
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000269 RID: 617
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x0400026A RID: 618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400026B RID: 619
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__5_3_Internal_ErrorInfo_AtomicAction_0;
		}

		// Token: 0x02000069 RID: 105
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__6`1")]
		[Serializable]
		public sealed class __c__6<T> : Object
		{
			// Token: 0x060003EE RID: 1006 RVA: 0x00012F64 File Offset: 0x00011164
			// Note: this type is marked as 'beforefieldinit'.
			static __c__6()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__6<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__6`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__6<T>>.NativeClassPtr);
				DecoratorExtensions.__c__6<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__6<T>>.NativeClassPtr, "<>9");
				DecoratorExtensions.__c__6<T>.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__6<T>>.NativeClassPtr, "<>9__6_2");
				DecoratorExtensions.__c__6<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__6<T>>.NativeClassPtr, 100663633);
				DecoratorExtensions.__c__6<T>.NativeMethodInfoPtr__ThenMaybe_b__6_2_Internal_ErrorInfo_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__6<T>>.NativeClassPtr, 100663634);
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x0001301C File Offset: 0x0001121C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__6()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__6<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__6<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x00013058 File Offset: 0x00011258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208358, XrefRangeEnd = 1208362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _ThenMaybe_b__6_2(IEnumerator _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__6<T>.NativeMethodInfoPtr__ThenMaybe_b__6_2_Internal_ErrorInfo_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x00003B3F File Offset: 0x00001D3F
			public __c__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000130A0 File Offset: 0x000112A0
			// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00003B48 File Offset: 0x00001D48
			public unsafe static DecoratorExtensions.__c__6<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c__6<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoratorExtensions.__c__6<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c__6<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000130C8 File Offset: 0x000112C8
			// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00003B5A File Offset: 0x00001D5A
			public unsafe static Func<IEnumerator, ErrorInfo> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DecoratorExtensions.__c__6<T>.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DecoratorExtensions.__c__6<T>.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400026C RID: 620
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400026D RID: 621
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x0400026E RID: 622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400026F RID: 623
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__6_2_Internal_ErrorInfo_IEnumerator_0;
		}

		// Token: 0x0200006A RID: 106
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x060003F6 RID: 1014 RVA: 0x000130F0 File Offset: 0x000112F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass10_0>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_orElse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass10_0>.NativeClassPtr, "orElse");
				DecoratorExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass10_0>.NativeClassPtr, 100663635);
				DecoratorExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__OrElse_b__0_Internal_IFailable_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass10_0>.NativeClassPtr, 100663636);
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x00013158 File Offset: 0x00011358
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x00013194 File Offset: 0x00011394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208362, XrefRangeEnd = 1208384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrElse_b__0(ErrorInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__OrElse_b__0_Internal_IFailable_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
				}
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x00003B6C File Offset: 0x00001D6C
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x060003FA RID: 1018 RVA: 0x000131EC File Offset: 0x000113EC
			// (set) Token: 0x060003FB RID: 1019 RVA: 0x00003B75 File Offset: 0x00001D75
			public unsafe Action orElse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_orElse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_orElse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000270 RID: 624
			private static readonly IntPtr NativeFieldInfoPtr_orElse;

			// Token: 0x04000271 RID: 625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000272 RID: 626
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__0_Internal_IFailable_ErrorInfo_0;
		}

		// Token: 0x0200006B RID: 107
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x060003FC RID: 1020 RVA: 0x0001321C File Offset: 0x0001141C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass11_0>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_orElse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass11_0>.NativeClassPtr, "orElse");
				DecoratorExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass11_0>.NativeClassPtr, 100663637);
				DecoratorExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__OrElse_b__0_Internal_IFailable_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass11_0>.NativeClassPtr, 100663638);
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x00013284 File Offset: 0x00011484
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x000132C0 File Offset: 0x000114C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208384, XrefRangeEnd = 1208402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrElse_b__0(ErrorInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__OrElse_b__0_Internal_IFailable_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
				}
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x00003B94 File Offset: 0x00001D94
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x00013318 File Offset: 0x00011518
			// (set) Token: 0x06000401 RID: 1025 RVA: 0x00003B9D File Offset: 0x00001D9D
			public unsafe IEnumerator orElse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_orElse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_orElse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000273 RID: 627
			private static readonly IntPtr NativeFieldInfoPtr_orElse;

			// Token: 0x04000274 RID: 628
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000275 RID: 629
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__0_Internal_IFailable_ErrorInfo_0;
		}

		// Token: 0x0200006C RID: 108
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06000402 RID: 1026 RVA: 0x00013348 File Offset: 0x00011548
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass12_0>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass12_0.NativeFieldInfoPtr_orElse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass12_0>.NativeClassPtr, "orElse");
				DecoratorExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass12_0>.NativeClassPtr, 100663639);
				DecoratorExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__OrElse_b__0_Internal_IFailable_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass12_0>.NativeClassPtr, 100663640);
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x000133B0 File Offset: 0x000115B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x000133EC File Offset: 0x000115EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208402, XrefRangeEnd = 1208420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrElse_b__0(ErrorInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass12_0.NativeMethodInfoPtr__OrElse_b__0_Internal_IFailable_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
				}
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x00003BBC File Offset: 0x00001DBC
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000406 RID: 1030 RVA: 0x00013444 File Offset: 0x00011644
			// (set) Token: 0x06000407 RID: 1031 RVA: 0x00003BC5 File Offset: 0x00001DC5
			public unsafe IFailable orElse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass12_0.NativeFieldInfoPtr_orElse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass12_0.NativeFieldInfoPtr_orElse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000276 RID: 630
			private static readonly IntPtr NativeFieldInfoPtr_orElse;

			// Token: 0x04000277 RID: 631
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000278 RID: 632
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__0_Internal_IFailable_ErrorInfo_0;
		}

		// Token: 0x0200006D RID: 109
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06000408 RID: 1032 RVA: 0x00013474 File Offset: 0x00011674
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass13_0>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_orFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass13_0>.NativeClassPtr, "orFail");
				DecoratorExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass13_0>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass13_0>.NativeClassPtr, "<>9__2");
				DecoratorExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100663641);
				DecoratorExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__OrElse_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100663642);
				DecoratorExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__OrElse_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100663643);
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x00013518 File Offset: 0x00011718
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x00013554 File Offset: 0x00011754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208420, XrefRangeEnd = 1208449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrElse_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__OrElse_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x00013594 File Offset: 0x00011794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208449, XrefRangeEnd = 1208452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OrElse_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__OrElse_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x00003BE4 File Offset: 0x00001DE4
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x0600040D RID: 1037 RVA: 0x000135C8 File Offset: 0x000117C8
			// (set) Token: 0x0600040E RID: 1038 RVA: 0x00003BED File Offset: 0x00001DED
			public unsafe Action<ErrorInfo> orFail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_orFail);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_orFail), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x0600040F RID: 1039 RVA: 0x000135F8 File Offset: 0x000117F8
			// (set) Token: 0x06000410 RID: 1040 RVA: 0x00003C0C File Offset: 0x00001E0C
			public unsafe IFailable command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000411 RID: 1041 RVA: 0x00013628 File Offset: 0x00011828
			// (set) Token: 0x06000412 RID: 1042 RVA: 0x00003C2B File Offset: 0x00001E2B
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000279 RID: 633
			private static readonly IntPtr NativeFieldInfoPtr_orFail;

			// Token: 0x0400027A RID: 634
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x0400027B RID: 635
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400027C RID: 636
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400027D RID: 637
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__1_Internal_IFailable_0;

			// Token: 0x0400027E RID: 638
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__2_Internal_Void_0;
		}

		// Token: 0x0200006E RID: 110
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x06000413 RID: 1043 RVA: 0x00013658 File Offset: 0x00011858
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass14_0>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass14_0>.NativeClassPtr, "handler");
				DecoratorExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass14_0>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass14_0>.NativeClassPtr, "<>9__2");
				DecoratorExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100663644);
				DecoratorExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__OrHandleError_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100663645);
				DecoratorExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__OrHandleError_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100663646);
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x000136FC File Offset: 0x000118FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x00013738 File Offset: 0x00011938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208452, XrefRangeEnd = 1208481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrHandleError_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__OrHandleError_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x00013778 File Offset: 0x00011978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208481, XrefRangeEnd = 1208487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OrHandleError_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__OrHandleError_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x00003C4A File Offset: 0x00001E4A
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000418 RID: 1048 RVA: 0x000137AC File Offset: 0x000119AC
			// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003C53 File Offset: 0x00001E53
			public unsafe IHandleErrorInfo handler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_handler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHandleErrorInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x0600041A RID: 1050 RVA: 0x000137DC File Offset: 0x000119DC
			// (set) Token: 0x0600041B RID: 1051 RVA: 0x00003C72 File Offset: 0x00001E72
			public unsafe IFailable command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001380C File Offset: 0x00011A0C
			// (set) Token: 0x0600041D RID: 1053 RVA: 0x00003C91 File Offset: 0x00001E91
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400027F RID: 639
			private static readonly IntPtr NativeFieldInfoPtr_handler;

			// Token: 0x04000280 RID: 640
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x04000281 RID: 641
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04000282 RID: 642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000283 RID: 643
			private static readonly IntPtr NativeMethodInfoPtr__OrHandleError_b__1_Internal_IFailable_0;

			// Token: 0x04000284 RID: 644
			private static readonly IntPtr NativeMethodInfoPtr__OrHandleError_b__2_Internal_Void_0;
		}

		// Token: 0x0200006F RID: 111
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x0600041E RID: 1054 RVA: 0x0001383C File Offset: 0x00011A3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass15_0>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_orFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass15_0>.NativeClassPtr, "orFail");
				DecoratorExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass15_0>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass15_0>.NativeClassPtr, 100663647);
				DecoratorExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__OrElse_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass15_0>.NativeClassPtr, 100663648);
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x000138B8 File Offset: 0x00011AB8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x000138F4 File Offset: 0x00011AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208487, XrefRangeEnd = 1208510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrElse_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass15_0.NativeMethodInfoPtr__OrElse_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00003CB0 File Offset: 0x00001EB0
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000422 RID: 1058 RVA: 0x00013934 File Offset: 0x00011B34
			// (set) Token: 0x06000423 RID: 1059 RVA: 0x00003CB9 File Offset: 0x00001EB9
			public unsafe Func<ErrorInfo, IEnumerator> orFail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_orFail);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ErrorInfo, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_orFail), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000424 RID: 1060 RVA: 0x00013964 File Offset: 0x00011B64
			// (set) Token: 0x06000425 RID: 1061 RVA: 0x00003CD8 File Offset: 0x00001ED8
			public unsafe IFailable command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass15_0.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000285 RID: 645
			private static readonly IntPtr NativeFieldInfoPtr_orFail;

			// Token: 0x04000286 RID: 646
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x04000287 RID: 647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000288 RID: 648
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__1_Internal_IFailable_0;
		}

		// Token: 0x02000070 RID: 112
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x06000426 RID: 1062 RVA: 0x00013994 File Offset: 0x00011B94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass16_0>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_orFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass16_0>.NativeClassPtr, "orFail");
				DecoratorExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass16_0>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass16_0>.NativeClassPtr, 100663649);
				DecoratorExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__OrElse_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass16_0>.NativeClassPtr, 100663650);
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00013A10 File Offset: 0x00011C10
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x00013A4C File Offset: 0x00011C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208510, XrefRangeEnd = 1208513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _OrElse_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass16_0.NativeMethodInfoPtr__OrElse_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x00003CF7 File Offset: 0x00001EF7
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x0600042A RID: 1066 RVA: 0x00013A8C File Offset: 0x00011C8C
			// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003D00 File Offset: 0x00001F00
			public unsafe Func<ErrorInfo, IFailable> orFail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_orFail);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ErrorInfo, IFailable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_orFail), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x0600042C RID: 1068 RVA: 0x00013ABC File Offset: 0x00011CBC
			// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003D1F File Offset: 0x00001F1F
			public unsafe IFailable command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass16_0.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000289 RID: 649
			private static readonly IntPtr NativeFieldInfoPtr_orFail;

			// Token: 0x0400028A RID: 650
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x0400028B RID: 651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400028C RID: 652
			private static readonly IntPtr NativeMethodInfoPtr__OrElse_b__1_Internal_IFailable_0;
		}

		// Token: 0x02000071 RID: 113
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass19_0`1")]
		public sealed class __c__DisplayClass19_0<T> : Object
		{
			// Token: 0x0600042E RID: 1070 RVA: 0x00013AEC File Offset: 0x00011CEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass19_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass19_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass19_0<T>>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass19_0<T>.NativeFieldInfoPtr_validator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass19_0<T>>.NativeClassPtr, "validator");
				DecoratorExtensions.__c__DisplayClass19_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass19_0<T>>.NativeClassPtr, 100663651);
				DecoratorExtensions.__c__DisplayClass19_0<T>.NativeMethodInfoPtr__AndValidate_b__0_Internal_ErrorInfo_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass19_0<T>>.NativeClassPtr, 100663652);
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x00013B90 File Offset: 0x00011D90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass19_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass19_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x00013BCC File Offset: 0x00011DCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208513, XrefRangeEnd = 1208520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _AndValidate_b__0(T c)
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass19_0<T>.NativeMethodInfoPtr__AndValidate_b__0_Internal_ErrorInfo_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return new ErrorInfo(intPtr2);
				}
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00003D3E File Offset: 0x00001F3E
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000432 RID: 1074 RVA: 0x00013C4C File Offset: 0x00011E4C
			// (set) Token: 0x06000433 RID: 1075 RVA: 0x00003D47 File Offset: 0x00001F47
			public unsafe Func<T, ErrorInfo> validator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass19_0<T>.NativeFieldInfoPtr_validator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass19_0<T>.NativeFieldInfoPtr_validator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400028D RID: 653
			private static readonly IntPtr NativeFieldInfoPtr_validator;

			// Token: 0x0400028E RID: 654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400028F RID: 655
			private static readonly IntPtr NativeMethodInfoPtr__AndValidate_b__0_Internal_ErrorInfo_T_0;
		}

		// Token: 0x02000072 RID: 114
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06000434 RID: 1076 RVA: 0x00013C7C File Offset: 0x00011E7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass2_0>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_then = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass2_0>.NativeClassPtr, "then");
				DecoratorExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass2_0>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100663653);
				DecoratorExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100663654);
				DecoratorExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass2_0>.NativeClassPtr, 100663655);
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x00013D0C File Offset: 0x00011F0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x00013D48 File Offset: 0x00011F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208520, XrefRangeEnd = 1208542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x00013D88 File Offset: 0x00011F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208542, XrefRangeEnd = 1208554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass2_0.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x00003D66 File Offset: 0x00001F66
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000439 RID: 1081 RVA: 0x00013DC8 File Offset: 0x00011FC8
			// (set) Token: 0x0600043A RID: 1082 RVA: 0x00003D6F File Offset: 0x00001F6F
			public unsafe Action then
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_then);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_then), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x0600043B RID: 1083 RVA: 0x00013DF8 File Offset: 0x00011FF8
			// (set) Token: 0x0600043C RID: 1084 RVA: 0x00003D8E File Offset: 0x00001F8E
			public unsafe IFailable command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass2_0.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000290 RID: 656
			private static readonly IntPtr NativeFieldInfoPtr_then;

			// Token: 0x04000291 RID: 657
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x04000292 RID: 658
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000293 RID: 659
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0;

			// Token: 0x04000294 RID: 660
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0;
		}

		// Token: 0x02000073 RID: 115
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600043D RID: 1085 RVA: 0x00013E28 File Offset: 0x00012028
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass3_0>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_then = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass3_0>.NativeClassPtr, "then");
				DecoratorExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass3_0>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663656);
				DecoratorExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663657);
				DecoratorExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663658);
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x00013EB8 File Offset: 0x000120B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x00013EF4 File Offset: 0x000120F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208554, XrefRangeEnd = 1208572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x00013F34 File Offset: 0x00012134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208572, XrefRangeEnd = 1208584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x00003DAD File Offset: 0x00001FAD
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x00013F74 File Offset: 0x00012174
			// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003DB6 File Offset: 0x00001FB6
			public unsafe IEnumerator then
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_then);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_then), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000444 RID: 1092 RVA: 0x00013FA4 File Offset: 0x000121A4
			// (set) Token: 0x06000445 RID: 1093 RVA: 0x00003DD5 File Offset: 0x00001FD5
			public unsafe IFailable command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000295 RID: 661
			private static readonly IntPtr NativeFieldInfoPtr_then;

			// Token: 0x04000296 RID: 662
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x04000297 RID: 663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000298 RID: 664
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0;

			// Token: 0x04000299 RID: 665
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0;
		}

		// Token: 0x02000074 RID: 116
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06000446 RID: 1094 RVA: 0x00013FD4 File Offset: 0x000121D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass4_0>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_then = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass4_0>.NativeClassPtr, "then");
				DecoratorExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass4_0>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass4_0>.NativeClassPtr, 100663659);
				DecoratorExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass4_0>.NativeClassPtr, 100663660);
				DecoratorExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass4_0>.NativeClassPtr, 100663661);
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x00014064 File Offset: 0x00012264
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x000140A0 File Offset: 0x000122A0
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x000140E0 File Offset: 0x000122E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208584, XrefRangeEnd = 1208596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass4_0.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x00003DF4 File Offset: 0x00001FF4
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x0600044B RID: 1099 RVA: 0x00014120 File Offset: 0x00012320
			// (set) Token: 0x0600044C RID: 1100 RVA: 0x00003DFD File Offset: 0x00001FFD
			public unsafe IFailable then
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_then);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_then), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x0600044D RID: 1101 RVA: 0x00014150 File Offset: 0x00012350
			// (set) Token: 0x0600044E RID: 1102 RVA: 0x00003E1C File Offset: 0x0000201C
			public unsafe IFailable command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass4_0.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400029A RID: 666
			private static readonly IntPtr NativeFieldInfoPtr_then;

			// Token: 0x0400029B RID: 667
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x0400029C RID: 668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400029D RID: 669
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0;

			// Token: 0x0400029E RID: 670
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0;
		}

		// Token: 0x02000075 RID: 117
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass5_0`1")]
		public sealed class __c__DisplayClass5_0<T> : Object
		{
			// Token: 0x0600044F RID: 1103 RVA: 0x00014180 File Offset: 0x00012380
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass5_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass5_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass5_0<T>>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_then = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass5_0<T>>.NativeClassPtr, "then");
				DecoratorExtensions.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass5_0<T>>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass5_0<T>.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass5_0<T>>.NativeClassPtr, "<>9__2");
				DecoratorExtensions.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass5_0<T>>.NativeClassPtr, 100663662);
				DecoratorExtensions.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass5_0<T>>.NativeClassPtr, 100663663);
				DecoratorExtensions.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__ThenMaybe_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass5_0<T>>.NativeClassPtr, 100663664);
				DecoratorExtensions.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass5_0<T>>.NativeClassPtr, 100663665);
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x00014274 File Offset: 0x00012474
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass5_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x000142B0 File Offset: 0x000124B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208596, XrefRangeEnd = 1208630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x000142F0 File Offset: 0x000124F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208630, XrefRangeEnd = 1208631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThenMaybe_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__ThenMaybe_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000453 RID: 1107 RVA: 0x00014324 File Offset: 0x00012524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208631, XrefRangeEnd = 1208638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass5_0<T>.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000454 RID: 1108 RVA: 0x00003E3B File Offset: 0x0000203B
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000455 RID: 1109 RVA: 0x00014364 File Offset: 0x00012564
			// (set) Token: 0x06000456 RID: 1110 RVA: 0x00003E44 File Offset: 0x00002044
			public unsafe Action<T> then
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_then);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_then), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000457 RID: 1111 RVA: 0x00014394 File Offset: 0x00012594
			// (set) Token: 0x06000458 RID: 1112 RVA: 0x000143BC File Offset: 0x000125BC
			public unsafe T command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_command);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass5_0<T>.NativeFieldInfoPtr_command);
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

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000459 RID: 1113 RVA: 0x00014464 File Offset: 0x00012664
			// (set) Token: 0x0600045A RID: 1114 RVA: 0x00003E63 File Offset: 0x00002063
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass5_0<T>.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass5_0<T>.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400029F RID: 671
			private static readonly IntPtr NativeFieldInfoPtr_then;

			// Token: 0x040002A0 RID: 672
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040002A1 RID: 673
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040002A2 RID: 674
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002A3 RID: 675
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0;

			// Token: 0x040002A4 RID: 676
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__2_Internal_Void_0;

			// Token: 0x040002A5 RID: 677
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0;
		}

		// Token: 0x02000076 RID: 118
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass6_0`1")]
		public sealed class __c__DisplayClass6_0<T> : Object
		{
			// Token: 0x0600045B RID: 1115 RVA: 0x00014494 File Offset: 0x00012694
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass6_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass6_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass6_0<T>>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_then = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass6_0<T>>.NativeClassPtr, "then");
				DecoratorExtensions.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass6_0<T>>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass6_0<T>>.NativeClassPtr, 100663666);
				DecoratorExtensions.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass6_0<T>>.NativeClassPtr, 100663667);
				DecoratorExtensions.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass6_0<T>>.NativeClassPtr, 100663668);
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x00014560 File Offset: 0x00012760
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass6_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x0001459C File Offset: 0x0001279C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208638, XrefRangeEnd = 1208655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x000145DC File Offset: 0x000127DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208655, XrefRangeEnd = 1208662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x00003E82 File Offset: 0x00002082
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000460 RID: 1120 RVA: 0x0001461C File Offset: 0x0001281C
			// (set) Token: 0x06000461 RID: 1121 RVA: 0x00003E8B File Offset: 0x0000208B
			public unsafe Func<T, IEnumerator> then
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_then);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_then), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000462 RID: 1122 RVA: 0x0001464C File Offset: 0x0001284C
			// (set) Token: 0x06000463 RID: 1123 RVA: 0x00014674 File Offset: 0x00012874
			public unsafe T command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_command);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_command);
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

			// Token: 0x040002A6 RID: 678
			private static readonly IntPtr NativeFieldInfoPtr_then;

			// Token: 0x040002A7 RID: 679
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040002A8 RID: 680
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002A9 RID: 681
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0;

			// Token: 0x040002AA RID: 682
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0;
		}

		// Token: 0x02000077 RID: 119
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass7_0`1")]
		public sealed class __c__DisplayClass7_0<T> : Object
		{
			// Token: 0x06000464 RID: 1124 RVA: 0x0001471C File Offset: 0x0001291C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass7_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass7_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass7_0<T>>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_then = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass7_0<T>>.NativeClassPtr, "then");
				DecoratorExtensions.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass7_0<T>>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass7_0<T>>.NativeClassPtr, 100663669);
				DecoratorExtensions.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass7_0<T>>.NativeClassPtr, 100663670);
				DecoratorExtensions.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass7_0<T>>.NativeClassPtr, 100663671);
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x000147E8 File Offset: 0x000129E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass7_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x00014824 File Offset: 0x00012A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208662, XrefRangeEnd = 1208663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x00014864 File Offset: 0x00012A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208663, XrefRangeEnd = 1208670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x00003EAA File Offset: 0x000020AA
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000469 RID: 1129 RVA: 0x000148A4 File Offset: 0x00012AA4
			// (set) Token: 0x0600046A RID: 1130 RVA: 0x00003EB3 File Offset: 0x000020B3
			public unsafe Func<T, IFailable> then
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_then);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IFailable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_then), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x0600046B RID: 1131 RVA: 0x000148D4 File Offset: 0x00012AD4
			// (set) Token: 0x0600046C RID: 1132 RVA: 0x000148FC File Offset: 0x00012AFC
			public unsafe T command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_command);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_command);
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

			// Token: 0x040002AB RID: 683
			private static readonly IntPtr NativeFieldInfoPtr_then;

			// Token: 0x040002AC RID: 684
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040002AD RID: 685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002AE RID: 686
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0;

			// Token: 0x040002AF RID: 687
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0;
		}

		// Token: 0x02000078 RID: 120
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass8_0`1")]
		public sealed class __c__DisplayClass8_0<T> : Object
		{
			// Token: 0x0600046D RID: 1133 RVA: 0x000149A4 File Offset: 0x00012BA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass8_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass8_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass8_0<T>>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_then = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass8_0<T>>.NativeClassPtr, "then");
				DecoratorExtensions.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass8_0<T>>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_orElse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass8_0<T>>.NativeClassPtr, "orElse");
				DecoratorExtensions.__c__DisplayClass8_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass8_0<T>>.NativeClassPtr, 100663672);
				DecoratorExtensions.__c__DisplayClass8_0<T>.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass8_0<T>>.NativeClassPtr, 100663673);
				DecoratorExtensions.__c__DisplayClass8_0<T>.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass8_0<T>>.NativeClassPtr, 100663674);
			}

			// Token: 0x0600046E RID: 1134 RVA: 0x00014A84 File Offset: 0x00012C84
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass8_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass8_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600046F RID: 1135 RVA: 0x00014AC0 File Offset: 0x00012CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208670, XrefRangeEnd = 1208674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass8_0<T>.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000470 RID: 1136 RVA: 0x00014B00 File Offset: 0x00012D00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208674, XrefRangeEnd = 1208680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass8_0<T>.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x00003ED2 File Offset: 0x000020D2
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000472 RID: 1138 RVA: 0x00014B40 File Offset: 0x00012D40
			// (set) Token: 0x06000473 RID: 1139 RVA: 0x00003EDB File Offset: 0x000020DB
			public unsafe Func<T, IFailable> then
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_then);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IFailable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_then), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000474 RID: 1140 RVA: 0x00014B70 File Offset: 0x00012D70
			// (set) Token: 0x06000475 RID: 1141 RVA: 0x00014B98 File Offset: 0x00012D98
			public unsafe T command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_command);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_command);
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

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000476 RID: 1142 RVA: 0x00014C40 File Offset: 0x00012E40
			// (set) Token: 0x06000477 RID: 1143 RVA: 0x00003EFA File Offset: 0x000020FA
			public unsafe Func<ErrorInfo, IFailable> orElse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_orElse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ErrorInfo, IFailable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass8_0<T>.NativeFieldInfoPtr_orElse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002B0 RID: 688
			private static readonly IntPtr NativeFieldInfoPtr_then;

			// Token: 0x040002B1 RID: 689
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040002B2 RID: 690
			private static readonly IntPtr NativeFieldInfoPtr_orElse;

			// Token: 0x040002B3 RID: 691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002B4 RID: 692
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0;

			// Token: 0x040002B5 RID: 693
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0;
		}

		// Token: 0x02000079 RID: 121
		[ObfuscatedName("dwd.core.commands.DecoratorExtensions+<>c__DisplayClass9_0`1")]
		public sealed class __c__DisplayClass9_0<T> : Object
		{
			// Token: 0x06000478 RID: 1144 RVA: 0x00014C70 File Offset: 0x00012E70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass9_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr);
				DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_then = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr, "then");
				DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr, "command");
				DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_orElse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr, "orElse");
				DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr, "<>9__2");
				DecoratorExtensions.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr, 100663675);
				DecoratorExtensions.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr, 100663676);
				DecoratorExtensions.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr, 100663677);
				DecoratorExtensions.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__ThenMaybe_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr, 100663678);
			}

			// Token: 0x06000479 RID: 1145 RVA: 0x00014D78 File Offset: 0x00012F78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoratorExtensions.__c__DisplayClass9_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x00014DB4 File Offset: 0x00012FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x00014DF4 File Offset: 0x00012FF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208680, XrefRangeEnd = 1208692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _ThenMaybe_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x00014E34 File Offset: 0x00013034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1208692, XrefRangeEnd = 1208698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThenMaybe_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeMethodInfoPtr__ThenMaybe_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600047D RID: 1149 RVA: 0x00003F19 File Offset: 0x00002119
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600047E RID: 1150 RVA: 0x00014E68 File Offset: 0x00013068
			// (set) Token: 0x0600047F RID: 1151 RVA: 0x00003F22 File Offset: 0x00002122
			public unsafe Func<T, IFailable> then
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_then);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IFailable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_then), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x06000480 RID: 1152 RVA: 0x00014E98 File Offset: 0x00013098
			// (set) Token: 0x06000481 RID: 1153 RVA: 0x00014EC0 File Offset: 0x000130C0
			public unsafe T command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_command);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_command);
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

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x06000482 RID: 1154 RVA: 0x00014F68 File Offset: 0x00013168
			// (set) Token: 0x06000483 RID: 1155 RVA: 0x00003F41 File Offset: 0x00002141
			public unsafe Action<ErrorInfo> orElse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_orElse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr_orElse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000484 RID: 1156 RVA: 0x00014F98 File Offset: 0x00013198
			// (set) Token: 0x06000485 RID: 1157 RVA: 0x00003F60 File Offset: 0x00002160
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoratorExtensions.__c__DisplayClass9_0<T>.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002B6 RID: 694
			private static readonly IntPtr NativeFieldInfoPtr_then;

			// Token: 0x040002B7 RID: 695
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x040002B8 RID: 696
			private static readonly IntPtr NativeFieldInfoPtr_orElse;

			// Token: 0x040002B9 RID: 697
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040002BA RID: 698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002BB RID: 699
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__0_Internal_IFailable_0;

			// Token: 0x040002BC RID: 700
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__1_Internal_IFailable_0;

			// Token: 0x040002BD RID: 701
			private static readonly IntPtr NativeMethodInfoPtr__ThenMaybe_b__2_Internal_Void_0;
		}

		// Token: 0x0200007A RID: 122
		private sealed class MethodInfoStoreGeneric_ThenMaybe_Public_Static_IFailable_T_Action_1_T_0<T>
		{
			// Token: 0x040002BE RID: 702
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Action_1_T_0, Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007B RID: 123
		private sealed class MethodInfoStoreGeneric_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IEnumerator_0<T>
		{
			// Token: 0x040002BF RID: 703
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IEnumerator_0, Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007C RID: 124
		private sealed class MethodInfoStoreGeneric_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_0<T>
		{
			// Token: 0x040002C0 RID: 704
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_0, Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007D RID: 125
		private sealed class MethodInfoStoreGeneric_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_Func_2_ErrorInfo_IFailable_0<T>
		{
			// Token: 0x040002C1 RID: 705
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_Func_2_ErrorInfo_IFailable_0, Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007E RID: 126
		private sealed class MethodInfoStoreGeneric_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_Action_1_ErrorInfo_0<T>
		{
			// Token: 0x040002C2 RID: 706
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtensions.NativeMethodInfoPtr_ThenMaybe_Public_Static_IFailable_T_Func_2_T_IFailable_Action_1_ErrorInfo_0, Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007F RID: 127
		private sealed class MethodInfoStoreGeneric_Validate_Public_Static_Validator_1_T_T_0<T>
		{
			// Token: 0x040002C3 RID: 707
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtensions.NativeMethodInfoPtr_Validate_Public_Static_Validator_1_T_T_0, Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000080 RID: 128
		private sealed class MethodInfoStoreGeneric_Validate_Public_Static_Validator_1_T_T_Func_2_T_ErrorInfo_0<T>
		{
			// Token: 0x040002C4 RID: 708
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtensions.NativeMethodInfoPtr_Validate_Public_Static_Validator_1_T_T_Func_2_T_ErrorInfo_0, Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000081 RID: 129
		private sealed class MethodInfoStoreGeneric_AndValidate_Public_Static_Validator_1_T_T_Func_2_T_ErrorInfo_0<T>
		{
			// Token: 0x040002C5 RID: 709
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DecoratorExtensions.NativeMethodInfoPtr_AndValidate_Public_Static_Validator_1_T_T_Func_2_T_ErrorInfo_0, Il2CppClassPointerStore<DecoratorExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
