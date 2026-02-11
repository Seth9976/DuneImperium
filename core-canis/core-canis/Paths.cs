using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

// Token: 0x02000031 RID: 49
public static class Paths : Object
{
	// Token: 0x0600045F RID: 1119 RVA: 0x00024944 File Offset: 0x00022B44
	// Note: this type is marked as 'beforefieldinit'.
	static Paths()
	{
		Il2CppClassPointerStore<Paths>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "Paths");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Paths>.NativeClassPtr);
		Paths.NativeMethodInfoPtr_LegacyAppDataPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paths>.NativeClassPtr, 100663916);
		Paths.NativeMethodInfoPtr_AppDataPath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paths>.NativeClassPtr, 100663917);
		Paths.NativeMethodInfoPtr_AssetPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paths>.NativeClassPtr, 100663918);
		Paths.NativeMethodInfoPtr_AssetPath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paths>.NativeClassPtr, 100663919);
		Paths.NativeMethodInfoPtr_GetRelativePath_Public_Static_String_DirectoryInfo_FileInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paths>.NativeClassPtr, 100663920);
		Paths.NativeMethodInfoPtr_GetRelativePath_Public_Static_String_DirectoryInfo_DirectoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paths>.NativeClassPtr, 100663921);
		Paths.NativeMethodInfoPtr_getRelativePath_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paths>.NativeClassPtr, 100663922);
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00024A00 File Offset: 0x00022C00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856647, XrefRangeEnd = 856648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string LegacyAppDataPath()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paths.NativeMethodInfoPtr_LegacyAppDataPath_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00024A2C File Offset: 0x00022C2C
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 856653, RefRangeEnd = 856665, XrefRangeStart = 856648, XrefRangeEnd = 856653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string AppDataPath(string filename)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paths.NativeMethodInfoPtr_AppDataPath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00024A68 File Offset: 0x00022C68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856665, XrefRangeEnd = 856666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string AssetPath()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paths.NativeMethodInfoPtr_AssetPath_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00024A94 File Offset: 0x00022C94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856666, XrefRangeEnd = 856671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string AssetPath(string filename)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paths.NativeMethodInfoPtr_AssetPath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00024AD0 File Offset: 0x00022CD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856671, XrefRangeEnd = 856673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRelativePath(DirectoryInfo directory, FileInfo file)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(directory);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(file);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paths.NativeMethodInfoPtr_GetRelativePath_Public_Static_String_DirectoryInfo_FileInfo_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00024B20 File Offset: 0x00022D20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRelativePath(DirectoryInfo rootDirectory, DirectoryInfo descendantDirectory)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootDirectory);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descendantDirectory);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paths.NativeMethodInfoPtr_GetRelativePath_Public_Static_String_DirectoryInfo_DirectoryInfo_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00024B70 File Offset: 0x00022D70
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 856682, RefRangeEnd = 856684, XrefRangeStart = 856673, XrefRangeEnd = 856682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getRelativePath(string rootPath, string descendantPath)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(rootPath);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(descendantPath);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paths.NativeMethodInfoPtr_getRelativePath_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00003AE4 File Offset: 0x00001CE4
	public Paths(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000332 RID: 818
	private static readonly IntPtr NativeMethodInfoPtr_LegacyAppDataPath_Public_Static_String_0;

	// Token: 0x04000333 RID: 819
	private static readonly IntPtr NativeMethodInfoPtr_AppDataPath_Public_Static_String_String_0;

	// Token: 0x04000334 RID: 820
	private static readonly IntPtr NativeMethodInfoPtr_AssetPath_Public_Static_String_0;

	// Token: 0x04000335 RID: 821
	private static readonly IntPtr NativeMethodInfoPtr_AssetPath_Public_Static_String_String_0;

	// Token: 0x04000336 RID: 822
	private static readonly IntPtr NativeMethodInfoPtr_GetRelativePath_Public_Static_String_DirectoryInfo_FileInfo_0;

	// Token: 0x04000337 RID: 823
	private static readonly IntPtr NativeMethodInfoPtr_GetRelativePath_Public_Static_String_DirectoryInfo_DirectoryInfo_0;

	// Token: 0x04000338 RID: 824
	private static readonly IntPtr NativeMethodInfoPtr_getRelativePath_Private_Static_String_String_String_0;
}
