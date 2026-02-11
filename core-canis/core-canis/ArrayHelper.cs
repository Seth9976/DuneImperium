using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

// Token: 0x0200000E RID: 14
public static class ArrayHelper : Object
{
	// Token: 0x06000237 RID: 567 RVA: 0x0001B72C File Offset: 0x0001992C
	// Note: this type is marked as 'beforefieldinit'.
	static ArrayHelper()
	{
		Il2CppClassPointerStore<ArrayHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "ArrayHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayHelper>.NativeClassPtr);
		ArrayHelper.NativeMethodInfoPtr_AddArrayElement_Public_Static_T_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelper>.NativeClassPtr, 100663592);
		ArrayHelper.NativeMethodInfoPtr_AddArrayElement_Public_Static_T_byref_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelper>.NativeClassPtr, 100663593);
		ArrayHelper.NativeMethodInfoPtr_DeleteArrayElement_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelper>.NativeClassPtr, 100663594);
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0001B798 File Offset: 0x00019998
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852794, XrefRangeEnd = 852798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T AddArrayElement<T>(ref Il2CppArrayBase<T> array) where T : new()
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayHelper.MethodInfoStoreGeneric_AddArrayElement_Public_Static_T_byref_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0001B7F0 File Offset: 0x000199F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852798, XrefRangeEnd = 852811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T AddArrayElement<T>(ref Il2CppArrayBase<T> array, T elToAdd)
	{
		IntPtr* ptr;
		IntPtr intPtr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr2 = &intPtr;
		}
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2;
		if (!typeof(T).IsValueType)
		{
			T t = elToAdd;
			intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr2 = ref elToAdd;
		}
		ptr3 = intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ArrayHelper.MethodInfoStoreGeneric_AddArrayElement_Public_Static_T_byref_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		IntPtr intPtr5 = intPtr;
		array = ((intPtr5 == 0) ? null : new Il2CppArrayBase<T>(intPtr5));
		return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0001B890 File Offset: 0x00019A90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852811, XrefRangeEnd = 852827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteArrayElement<T>(ref Il2CppArrayBase<T> array, int index)
	{
		IntPtr* ptr;
		IntPtr intPtr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr2 = &intPtr;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayHelper.MethodInfoStoreGeneric_DeleteArrayElement_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00002F3C File Offset: 0x0000113C
	public ArrayHelper(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040001AB RID: 427
	private static readonly IntPtr NativeMethodInfoPtr_AddArrayElement_Public_Static_T_byref_Il2CppArrayBase_1_T_0;

	// Token: 0x040001AC RID: 428
	private static readonly IntPtr NativeMethodInfoPtr_AddArrayElement_Public_Static_T_byref_Il2CppArrayBase_1_T_T_0;

	// Token: 0x040001AD RID: 429
	private static readonly IntPtr NativeMethodInfoPtr_DeleteArrayElement_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

	// Token: 0x02000231 RID: 561
	private sealed class MethodInfoStoreGeneric_AddArrayElement_Public_Static_T_byref_Il2CppArrayBase_1_T_0<T>
	{
		// Token: 0x04001529 RID: 5417
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayHelper.NativeMethodInfoPtr_AddArrayElement_Public_Static_T_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ArrayHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000232 RID: 562
	private sealed class MethodInfoStoreGeneric_AddArrayElement_Public_Static_T_byref_Il2CppArrayBase_1_T_T_0<T>
	{
		// Token: 0x0400152A RID: 5418
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayHelper.NativeMethodInfoPtr_AddArrayElement_Public_Static_T_byref_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<ArrayHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000233 RID: 563
	private sealed class MethodInfoStoreGeneric_DeleteArrayElement_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
	{
		// Token: 0x0400152B RID: 5419
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayHelper.NativeMethodInfoPtr_DeleteArrayElement_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<ArrayHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
