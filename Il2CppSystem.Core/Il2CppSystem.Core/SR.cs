using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000002 RID: 2
public static class SR : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x0000B0FC File Offset: 0x000092FC
	// Note: this type is marked as 'beforefieldinit'.
	static SR()
	{
		Il2CppClassPointerStore<global::SR>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "", "SR");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::SR>.NativeClassPtr);
		global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663297);
		global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663298);
		global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663299);
		global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663300);
		global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663301);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000B190 File Offset: 0x00009390
	[CallerCount(1295)]
	[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetString(string name)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000B1CC File Offset: 0x000093CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1001930, RefRangeEnd = 1001931, XrefRangeStart = 1001929, XrefRangeEnd = 1001930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string resourceFormat, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000B228 File Offset: 0x00009428
	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 1001936, RefRangeEnd = 1001993, XrefRangeStart = 1001931, XrefRangeEnd = 1001936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string resourceFormat, Object p1)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000B278 File Offset: 0x00009478
	[CallerCount(55)]
	[CachedScanResults(RefRangeStart = 1001998, RefRangeEnd = 1002053, XrefRangeStart = 1001993, XrefRangeEnd = 1001998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string resourceFormat, Object p1, Object p2)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000B2D8 File Offset: 0x000094D8
	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 1002058, RefRangeEnd = 1002075, XrefRangeStart = 1002053, XrefRangeEnd = 1002058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string resourceFormat, Object p1, Object p2, Object p3)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p3);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	public static string Format(string resourceFormat, params Object[] args)
	{
		return global::SR.Format(resourceFormat, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000205E File Offset: 0x0000025E
	public SR(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeMethodInfoPtr_GetString_Internal_Static_String_String_0;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_Object_0;
}
