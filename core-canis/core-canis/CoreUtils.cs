using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200004E RID: 78
public static class CoreUtils : Object
{
	// Token: 0x060005C6 RID: 1478 RVA: 0x0002AA24 File Offset: 0x00028C24
	// Note: this type is marked as 'beforefieldinit'.
	static CoreUtils()
	{
		Il2CppClassPointerStore<CoreUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "CoreUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr);
		CoreUtils.NativeMethodInfoPtr_getWineVersion_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100664160);
		CoreUtils.NativeMethodInfoPtr_RunningInWine_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100664161);
		CoreUtils.NativeMethodInfoPtr_LogInternal_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUtils>.NativeClassPtr, 100664162);
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x0002AA90 File Offset: 0x00028C90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858177, XrefRangeEnd = 858181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getWineVersion()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_getWineVersion_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x0002AABC File Offset: 0x00028CBC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858187, RefRangeEnd = 858188, XrefRangeStart = 858181, XrefRangeEnd = 858187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RunningInWine()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_RunningInWine_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0002AAEC File Offset: 0x00028CEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858188, XrefRangeEnd = 858192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogInternal(string message)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUtils.NativeMethodInfoPtr_LogInternal_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x00003FCE File Offset: 0x000021CE
	public CoreUtils(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000454 RID: 1108
	private static readonly IntPtr NativeMethodInfoPtr_getWineVersion_Private_Static_String_0;

	// Token: 0x04000455 RID: 1109
	private static readonly IntPtr NativeMethodInfoPtr_RunningInWine_Public_Static_Boolean_0;

	// Token: 0x04000456 RID: 1110
	private static readonly IntPtr NativeMethodInfoPtr_LogInternal_Public_Static_Void_String_0;
}
