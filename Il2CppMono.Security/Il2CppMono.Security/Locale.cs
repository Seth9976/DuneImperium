using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000002 RID: 2
public sealed class Locale : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x00004788 File Offset: 0x00002988
	// Note: this type is marked as 'beforefieldinit'.
	static Locale()
	{
		Il2CppClassPointerStore<global::Locale>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "", "Locale");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::Locale>.NativeClassPtr);
		global::Locale.NativeMethodInfoPtr_GetText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::Locale>.NativeClassPtr, 100663297);
		global::Locale.NativeMethodInfoPtr_GetText_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::Locale>.NativeClassPtr, 100663298);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000047E0 File Offset: 0x000029E0
	[CallerCount(1295)]
	[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetText(string msg)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::Locale.NativeMethodInfoPtr_GetText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000481C File Offset: 0x00002A1C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1143799, RefRangeEnd = 1143803, XrefRangeStart = 1143798, XrefRangeEnd = 1143799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetText(string fmt, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fmt);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::Locale.NativeMethodInfoPtr_GetText_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	public static string GetText(string fmt, params Object[] args)
	{
		return global::Locale.GetText(fmt, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000205E File Offset: 0x0000025E
	public Locale(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_String_0;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;
}
