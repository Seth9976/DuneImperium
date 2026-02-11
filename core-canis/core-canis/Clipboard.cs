using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000032 RID: 50
public static class Clipboard : Object
{
	// Token: 0x06000468 RID: 1128 RVA: 0x00024BC0 File Offset: 0x00022DC0
	// Note: this type is marked as 'beforefieldinit'.
	static Clipboard()
	{
		Il2CppClassPointerStore<Clipboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "Clipboard");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clipboard>.NativeClassPtr);
		Clipboard.NativeMethodInfoPtr_SetText_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipboard>.NativeClassPtr, 100663923);
		Clipboard.NativeMethodInfoPtr_GetTextAsync_Public_Static_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipboard>.NativeClassPtr, 100663924);
		Clipboard.NativeMethodInfoPtr_GetText_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clipboard>.NativeClassPtr, 100663925);
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00024C2C File Offset: 0x00022E2C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 856688, RefRangeEnd = 856691, XrefRangeStart = 856684, XrefRangeEnd = 856688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetText(string newText, bool forceSynchronous = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newText);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceSynchronous;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipboard.NativeMethodInfoPtr_SetText_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00024C70 File Offset: 0x00022E70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856691, XrefRangeEnd = 856698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetTextAsync(Action<string> callback)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipboard.NativeMethodInfoPtr_GetTextAsync_Public_Static_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00024CA8 File Offset: 0x00022EA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856698, XrefRangeEnd = 856704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetText()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clipboard.NativeMethodInfoPtr_GetText_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x00003AED File Offset: 0x00001CED
	public Clipboard(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000339 RID: 825
	private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Static_Void_String_Boolean_0;

	// Token: 0x0400033A RID: 826
	private static readonly IntPtr NativeMethodInfoPtr_GetTextAsync_Public_Static_Void_Action_1_String_0;

	// Token: 0x0400033B RID: 827
	private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_0;
}
