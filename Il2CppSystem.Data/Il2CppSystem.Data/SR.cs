using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000005 RID: 5
public static class SR : Object
{
	// Token: 0x0600000E RID: 14 RVA: 0x00008464 File Offset: 0x00006664
	// Note: this type is marked as 'beforefieldinit'.
	static SR()
	{
		Il2CppClassPointerStore<global::SR>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "", "SR");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::SR>.NativeClassPtr);
		global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663300);
		global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663301);
		global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663302);
		global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663303);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000084E4 File Offset: 0x000066E4
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

	// Token: 0x06000010 RID: 16 RVA: 0x00008520 File Offset: 0x00006720
	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 886896, RefRangeEnd = 886927, XrefRangeStart = 886891, XrefRangeEnd = 886896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	// Token: 0x06000011 RID: 17 RVA: 0x00008570 File Offset: 0x00006770
	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 886932, RefRangeEnd = 886971, XrefRangeStart = 886927, XrefRangeEnd = 886932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	// Token: 0x06000012 RID: 18 RVA: 0x000085D0 File Offset: 0x000067D0
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 886976, RefRangeEnd = 886986, XrefRangeStart = 886971, XrefRangeEnd = 886976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	// Token: 0x06000013 RID: 19 RVA: 0x000020DE File Offset: 0x000002DE
	public SR(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeMethodInfoPtr_GetString_Internal_Static_String_String_0;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_Object_0;
}
