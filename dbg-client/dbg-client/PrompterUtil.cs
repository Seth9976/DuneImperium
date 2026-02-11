using System;
using Canis.utils.localization;
using dwd.core.ui.prompt;
using dwd.core.ui.prompt.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

// Token: 0x0200000A RID: 10
public static class PrompterUtil : Object
{
	// Token: 0x06000047 RID: 71 RVA: 0x0001E324 File Offset: 0x0001C524
	// Note: this type is marked as 'beforefieldinit'.
	static PrompterUtil()
	{
		Il2CppClassPointerStore<PrompterUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "PrompterUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrompterUtil>.NativeClassPtr);
		PrompterUtil.NativeMethodInfoPtr_WithSpinner_Public_Static_ShowSpinnerWhile_1_T_T_ModalScope_Spinner_Boolean_ScopedPromptDisplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrompterUtil>.NativeClassPtr, 100663357);
		PrompterUtil.NativeMethodInfoPtr_WithSpinner_Public_Static_ShowSpinnerWhile_1_T_T_ModalScope_LocalizedString_Boolean_ScopedPromptDisplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrompterUtil>.NativeClassPtr, 100663358);
		PrompterUtil.NativeMethodInfoPtr_WithModalSpinner_Public_Static_ShowSpinnerWhile_1_T_T_Spinner_Boolean_ScopedPromptDisplayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrompterUtil>.NativeClassPtr, 100663359);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0001E390 File Offset: 0x0001C590
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495187, XrefRangeEnd = 495191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShowSpinnerWhile<T> WithSpinner<T>(this T toSpinDuring, ModalScope scope, Spinner spinner = null, bool waitForDisplayed = false, ScopedPromptDisplayData displayData = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = toSpinDuring;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref toSpinDuring;
			}
			ptr2 = intPtr;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scope);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spinner);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForDisplayed;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(displayData);
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrompterUtil.MethodInfoStoreGeneric_WithSpinner_Public_Static_ShowSpinnerWhile_1_T_T_ModalScope_Spinner_Boolean_ScopedPromptDisplayData_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr2;
		return (intPtr4 != 0) ? Il2CppObjectPool.Get<ShowSpinnerWhile<T>>(intPtr4) : null;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0001E450 File Offset: 0x0001C650
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495191, XrefRangeEnd = 495198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShowSpinnerWhile<T> WithSpinner<T>(this T toSpinDuring, ModalScope scope, LocalizedString message, bool waitForDisplayed = false, ScopedPromptDisplayData displayData = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = toSpinDuring;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref toSpinDuring;
			}
			ptr2 = intPtr;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scope);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForDisplayed;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(displayData);
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrompterUtil.MethodInfoStoreGeneric_WithSpinner_Public_Static_ShowSpinnerWhile_1_T_T_ModalScope_LocalizedString_Boolean_ScopedPromptDisplayData_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr2;
		return (intPtr4 != 0) ? Il2CppObjectPool.Get<ShowSpinnerWhile<T>>(intPtr4) : null;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x0001E510 File Offset: 0x0001C710
	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 495206, RefRangeEnd = 495238, XrefRangeStart = 495198, XrefRangeEnd = 495206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShowSpinnerWhile<T> WithModalSpinner<T>(this T command, Spinner spinner = null, bool waitForDisplayed = false, ScopedPromptDisplayData displayData = null)
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
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spinner);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForDisplayed;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(displayData);
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrompterUtil.MethodInfoStoreGeneric_WithModalSpinner_Public_Static_ShowSpinnerWhile_1_T_T_Spinner_Boolean_ScopedPromptDisplayData_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr2;
		return (intPtr4 != 0) ? Il2CppObjectPool.Get<ShowSpinnerWhile<T>>(intPtr4) : null;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x000021FF File Offset: 0x000003FF
	public PrompterUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeMethodInfoPtr_WithSpinner_Public_Static_ShowSpinnerWhile_1_T_T_ModalScope_Spinner_Boolean_ScopedPromptDisplayData_0;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr_WithSpinner_Public_Static_ShowSpinnerWhile_1_T_T_ModalScope_LocalizedString_Boolean_ScopedPromptDisplayData_0;

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeMethodInfoPtr_WithModalSpinner_Public_Static_ShowSpinnerWhile_1_T_T_Spinner_Boolean_ScopedPromptDisplayData_0;

	// Token: 0x020002C6 RID: 710
	private sealed class MethodInfoStoreGeneric_WithSpinner_Public_Static_ShowSpinnerWhile_1_T_T_ModalScope_Spinner_Boolean_ScopedPromptDisplayData_0<T>
	{
		// Token: 0x0400150B RID: 5387
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PrompterUtil.NativeMethodInfoPtr_WithSpinner_Public_Static_ShowSpinnerWhile_1_T_T_ModalScope_Spinner_Boolean_ScopedPromptDisplayData_0, Il2CppClassPointerStore<PrompterUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x020002C7 RID: 711
	private sealed class MethodInfoStoreGeneric_WithSpinner_Public_Static_ShowSpinnerWhile_1_T_T_ModalScope_LocalizedString_Boolean_ScopedPromptDisplayData_0<T>
	{
		// Token: 0x0400150C RID: 5388
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PrompterUtil.NativeMethodInfoPtr_WithSpinner_Public_Static_ShowSpinnerWhile_1_T_T_ModalScope_LocalizedString_Boolean_ScopedPromptDisplayData_0, Il2CppClassPointerStore<PrompterUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x020002C8 RID: 712
	private sealed class MethodInfoStoreGeneric_WithModalSpinner_Public_Static_ShowSpinnerWhile_1_T_T_Spinner_Boolean_ScopedPromptDisplayData_0<T>
	{
		// Token: 0x0400150D RID: 5389
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PrompterUtil.NativeMethodInfoPtr_WithModalSpinner_Public_Static_ShowSpinnerWhile_1_T_T_Spinner_Boolean_ScopedPromptDisplayData_0, Il2CppClassPointerStore<PrompterUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
