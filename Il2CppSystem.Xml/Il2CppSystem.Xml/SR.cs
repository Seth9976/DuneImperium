using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Globalization;

// Token: 0x02000002 RID: 2
public static class SR : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x00016318 File Offset: 0x00014518
	// Note: this type is marked as 'beforefieldinit'.
	static SR()
	{
		Il2CppClassPointerStore<global::SR>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "", "SR");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::SR>.NativeClassPtr);
		global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663297);
		global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_CultureInfo_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663298);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00016370 File Offset: 0x00014570
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 362159, RefRangeEnd = 362172, XrefRangeStart = 362154, XrefRangeEnd = 362159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetString(string name, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000163CC File Offset: 0x000145CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362172, XrefRangeEnd = 362173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetString(CultureInfo culture, string name, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_CultureInfo_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	public static string GetString(string name, params Object[] args)
	{
		return global::SR.GetString(name, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000205E File Offset: 0x0000025E
	public static string GetString(CultureInfo culture, string name, params Object[] args)
	{
		return global::SR.GetString(culture, name, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000206D File Offset: 0x0000026D
	public SR(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeMethodInfoPtr_GetString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeMethodInfoPtr_GetString_Internal_Static_String_CultureInfo_String_Il2CppReferenceArray_1_Object_0;
}
