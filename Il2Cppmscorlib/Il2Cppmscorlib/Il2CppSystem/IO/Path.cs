using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Buffers;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x0200054A RID: 1354
	public static class Path : Object
	{
		// Token: 0x06005372 RID: 21362 RVA: 0x00184BC0 File Offset: 0x00182DC0
		// Note: this type is marked as 'beforefieldinit'.
		static Path()
		{
			Il2CppClassPointerStore<Path>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Path");
			Path.NativeFieldInfoPtr_InvalidPathChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "InvalidPathChars");
			Path.NativeFieldInfoPtr_AltDirectorySeparatorChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "AltDirectorySeparatorChar");
			Path.NativeFieldInfoPtr_DirectorySeparatorChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "DirectorySeparatorChar");
			Path.NativeFieldInfoPtr_PathSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "PathSeparator");
			Path.NativeFieldInfoPtr_DirectorySeparatorStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "DirectorySeparatorStr");
			Path.NativeFieldInfoPtr_VolumeSeparatorChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "VolumeSeparatorChar");
			Path.NativeFieldInfoPtr_PathSeparatorChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "PathSeparatorChars");
			Path.NativeFieldInfoPtr_dirEqualsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "dirEqualsVolume");
			Path.NativeFieldInfoPtr_trimEndCharsWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "trimEndCharsWindows");
			Path.NativeFieldInfoPtr_trimEndCharsUnix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "trimEndCharsUnix");
			Path.NativeMethodInfoPtr_ChangeExtension_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676099);
			Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676100);
			Path.NativeMethodInfoPtr_CleanPath_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676101);
			Path.NativeMethodInfoPtr_GetDirectoryName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676102);
			Path.NativeMethodInfoPtr_GetDirectoryName_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676103);
			Path.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676104);
			Path.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676105);
			Path.NativeMethodInfoPtr_GetFileNameWithoutExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676106);
			Path.NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676107);
			Path.NativeMethodInfoPtr_GetFullPathInternal_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676108);
			Path.NativeMethodInfoPtr_GetFullPathName_Private_Static_Int32_String_Int32_StringBuilder_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676109);
			Path.NativeMethodInfoPtr_GetFullPathName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676110);
			Path.NativeMethodInfoPtr_WindowsDriveAdjustment_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676111);
			Path.NativeMethodInfoPtr_InsecureGetFullPath_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676112);
			Path.NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676113);
			Path.NativeMethodInfoPtr_GetPathRoot_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676114);
			Path.NativeMethodInfoPtr_GetTempPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676115);
			Path.NativeMethodInfoPtr_get_temp_path_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676116);
			Path.NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676117);
			Path.NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676118);
			Path.NativeMethodInfoPtr_GetInvalidPathChars_Public_Static_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676119);
			Path.NativeMethodInfoPtr_findExtension_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676120);
			Path.NativeMethodInfoPtr_GetServerAndShare_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676122);
			Path.NativeMethodInfoPtr_SameRoot_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676123);
			Path.NativeMethodInfoPtr_CanonicalizePath_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676124);
			Path.NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676125);
			Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676126);
			Path.NativeMethodInfoPtr_GetFileName_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676127);
			Path.NativeMethodInfoPtr_Join_Public_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676128);
			Path.NativeMethodInfoPtr_Join_Public_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676129);
			Path.NativeMethodInfoPtr_JoinInternal_Private_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676130);
			Path.NativeMethodInfoPtr_JoinInternal_Private_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676131);
			Path.NativeMethodInfoPtr_GetRelativePath_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676132);
			Path.NativeMethodInfoPtr_GetRelativePath_Private_Static_String_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676133);
			Path.NativeMethodInfoPtr_get_StringComparison_Internal_Static_get_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676134);
			Path.NativeMethodInfoPtr_get_IsCaseSensitive_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676135);
			Path.NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100676136);
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00184F94 File Offset: 0x00183194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433397, RefRangeEnd = 1433398, XrefRangeStart = 1433382, XrefRangeEnd = 1433397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ChangeExtension(string path, string extension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(extension);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_ChangeExtension_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x00184FE4 File Offset: 0x001831E4
		[CallerCount(103)]
		[CachedScanResults(RefRangeStart = 1433422, RefRangeEnd = 1433525, XrefRangeStart = 1433398, XrefRangeEnd = 1433422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Combine(string path1, string path2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x00185034 File Offset: 0x00183234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433525, XrefRangeEnd = 1433569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CleanPath(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CleanPath_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x00185070 File Offset: 0x00183270
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1433588, RefRangeEnd = 1433600, XrefRangeStart = 1433569, XrefRangeEnd = 1433588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDirectoryName(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetDirectoryName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x001850AC File Offset: 0x001832AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433600, XrefRangeEnd = 1433609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetDirectoryName_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x001850F0 File Offset: 0x001832F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1433620, RefRangeEnd = 1433624, XrefRangeStart = 1433609, XrefRangeEnd = 1433620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetExtension(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x0018512C File Offset: 0x0018332C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1433634, RefRangeEnd = 1433642, XrefRangeStart = 1433624, XrefRangeEnd = 1433634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFileName(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x00185168 File Offset: 0x00183368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433662, RefRangeEnd = 1433663, XrefRangeStart = 1433642, XrefRangeEnd = 1433662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFileNameWithoutExtension(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFileNameWithoutExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x001851A4 File Offset: 0x001833A4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1433668, RefRangeEnd = 1433694, XrefRangeStart = 1433663, XrefRangeEnd = 1433668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x001851E0 File Offset: 0x001833E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433698, RefRangeEnd = 1433699, XrefRangeStart = 1433694, XrefRangeEnd = 1433698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullPathInternal(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPathInternal_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x0018521C File Offset: 0x0018341C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433699, XrefRangeEnd = 1433704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBufferChars;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpFilePartOrNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPathName_Private_Static_Int32_String_Int32_StringBuilder_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x0018528C File Offset: 0x0018348C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433726, RefRangeEnd = 1433727, XrefRangeStart = 1433704, XrefRangeEnd = 1433726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullPathName(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPathName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x001852C8 File Offset: 0x001834C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1433748, RefRangeEnd = 1433749, XrefRangeStart = 1433727, XrefRangeEnd = 1433748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string WindowsDriveAdjustment(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_WindowsDriveAdjustment_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x00185304 File Offset: 0x00183504
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1433848, RefRangeEnd = 1433853, XrefRangeStart = 1433749, XrefRangeEnd = 1433848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InsecureGetFullPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_InsecureGetFullPath_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x00185340 File Offset: 0x00183540
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1433857, RefRangeEnd = 1433879, XrefRangeStart = 1433853, XrefRangeEnd = 1433857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDirectorySeparator(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x00185380 File Offset: 0x00183580
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1433933, RefRangeEnd = 1433936, XrefRangeStart = 1433879, XrefRangeEnd = 1433933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPathRoot(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetPathRoot_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x001853BC File Offset: 0x001835BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1433953, RefRangeEnd = 1433955, XrefRangeStart = 1433936, XrefRangeEnd = 1433953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTempPath()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetTempPath_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x001853E8 File Offset: 0x001835E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433955, XrefRangeEnd = 1433956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string get_temp_path()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_get_temp_path_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x00185414 File Offset: 0x00183614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433956, XrefRangeEnd = 1433967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPathRooted(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x0018545C File Offset: 0x0018365C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1433988, RefRangeEnd = 1433993, XrefRangeStart = 1433967, XrefRangeEnd = 1433988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPathRooted(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x001854A0 File Offset: 0x001836A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433993, XrefRangeEnd = 1434001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> GetInvalidPathChars()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetInvalidPathChars_Public_Static_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x001854D4 File Offset: 0x001836D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1434007, RefRangeEnd = 1434009, XrefRangeStart = 1434001, XrefRangeEnd = 1434007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int findExtension(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_findExtension_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00185518 File Offset: 0x00183718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1434037, RefRangeEnd = 1434039, XrefRangeStart = 1434009, XrefRangeEnd = 1434037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetServerAndShare(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetServerAndShare_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x00185554 File Offset: 0x00183754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1434066, RefRangeEnd = 1434068, XrefRangeStart = 1434039, XrefRangeEnd = 1434066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SameRoot(string root, string path)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_SameRoot_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x001855A8 File Offset: 0x001837A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1434167, RefRangeEnd = 1434168, XrefRangeStart = 1434068, XrefRangeEnd = 1434167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CanonicalizePath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CanonicalizePath_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x001855E4 File Offset: 0x001837E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1434218, RefRangeEnd = 1434219, XrefRangeStart = 1434168, XrefRangeEnd = 1434218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Combine([Optional] Il2CppStringArray paths)
		{
			if (paths == null)
			{
				paths = new Il2CppStringArray(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x00185630 File Offset: 0x00183830
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1434249, RefRangeEnd = 1434258, XrefRangeStart = 1434219, XrefRangeEnd = 1434249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Combine(string path1, string path2, string path3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x00185690 File Offset: 0x00183890
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1434270, RefRangeEnd = 1434273, XrefRangeStart = 1434258, XrefRangeEnd = 1434270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFileName_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x001856D4 File Offset: 0x001838D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1434278, RefRangeEnd = 1434280, XrefRangeStart = 1434273, XrefRangeEnd = 1434278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Join_Public_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x0018572C File Offset: 0x0018392C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1434309, RefRangeEnd = 1434311, XrefRangeStart = 1434280, XrefRangeEnd = 1434309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path2));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(path3));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Join_Public_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x0018579C File Offset: 0x0018399C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1434346, RefRangeEnd = 1434351, XrefRangeStart = 1434311, XrefRangeEnd = 1434346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(first));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(second));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_JoinInternal_Private_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x001857F4 File Offset: 0x001839F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1434395, RefRangeEnd = 1434396, XrefRangeStart = 1434351, XrefRangeEnd = 1434395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(first));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(second));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(third));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_JoinInternal_Private_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00185864 File Offset: 0x00183A64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1434408, RefRangeEnd = 1434412, XrefRangeStart = 1434396, XrefRangeEnd = 1434408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRelativePath(string relativeTo, string path)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relativeTo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetRelativePath_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x001858B4 File Offset: 0x00183AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1434454, RefRangeEnd = 1434455, XrefRangeStart = 1434412, XrefRangeEnd = 1434454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRelativePath(string relativeTo, string path, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relativeTo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetRelativePath_Private_Static_String_String_String_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06005395 RID: 21397 RVA: 0x00185910 File Offset: 0x00183B10
		public unsafe static StringComparison StringComparison
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434455, XrefRangeEnd = 1434462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_get_StringComparison_Internal_Static_get_StringComparison_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06005396 RID: 21398 RVA: 0x00185940 File Offset: 0x00183B40
		public unsafe static bool IsCaseSensitive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434462, XrefRangeEnd = 1434466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_get_IsCaseSensitive_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06005397 RID: 21399 RVA: 0x00185970 File Offset: 0x00183B70
		public unsafe static bool IsWindows
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x0001D94C File Offset: 0x0001BB4C
		public static string Combine(params string[] paths)
		{
			return Path.Combine(new Il2CppStringArray(paths));
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x0001D959 File Offset: 0x0001BB59
		public Path(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x001859A0 File Offset: 0x00183BA0
		// (set) Token: 0x0600539B RID: 21403 RVA: 0x0001D962 File Offset: 0x0001BB62
		public unsafe static Il2CppStructArray<char> InvalidPathChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_InvalidPathChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_InvalidPathChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x0600539C RID: 21404 RVA: 0x001859C8 File Offset: 0x00183BC8
		// (set) Token: 0x0600539D RID: 21405 RVA: 0x0001D974 File Offset: 0x0001BB74
		public unsafe static char AltDirectorySeparatorChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_AltDirectorySeparatorChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_AltDirectorySeparatorChar, (void*)(&value));
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x0600539E RID: 21406 RVA: 0x001859E4 File Offset: 0x00183BE4
		// (set) Token: 0x0600539F RID: 21407 RVA: 0x0001D982 File Offset: 0x0001BB82
		public unsafe static char DirectorySeparatorChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_DirectorySeparatorChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_DirectorySeparatorChar, (void*)(&value));
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x060053A0 RID: 21408 RVA: 0x00185A00 File Offset: 0x00183C00
		// (set) Token: 0x060053A1 RID: 21409 RVA: 0x0001D990 File Offset: 0x0001BB90
		public unsafe static char PathSeparator
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_PathSeparator, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_PathSeparator, (void*)(&value));
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x060053A2 RID: 21410 RVA: 0x00185A1C File Offset: 0x00183C1C
		// (set) Token: 0x060053A3 RID: 21411 RVA: 0x0001D99E File Offset: 0x0001BB9E
		public unsafe static string DirectorySeparatorStr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_DirectorySeparatorStr, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_DirectorySeparatorStr, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x060053A4 RID: 21412 RVA: 0x00185A3C File Offset: 0x00183C3C
		// (set) Token: 0x060053A5 RID: 21413 RVA: 0x0001D9B0 File Offset: 0x0001BBB0
		public unsafe static char VolumeSeparatorChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_VolumeSeparatorChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_VolumeSeparatorChar, (void*)(&value));
			}
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x060053A6 RID: 21414 RVA: 0x00185A58 File Offset: 0x00183C58
		// (set) Token: 0x060053A7 RID: 21415 RVA: 0x0001D9BE File Offset: 0x0001BBBE
		public unsafe static Il2CppStructArray<char> PathSeparatorChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_PathSeparatorChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_PathSeparatorChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x00185A80 File Offset: 0x00183C80
		// (set) Token: 0x060053A9 RID: 21417 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
		public unsafe static bool dirEqualsVolume
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_dirEqualsVolume, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_dirEqualsVolume, (void*)(&value));
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x060053AA RID: 21418 RVA: 0x00185A9C File Offset: 0x00183C9C
		// (set) Token: 0x060053AB RID: 21419 RVA: 0x0001D9DE File Offset: 0x0001BBDE
		public unsafe static Il2CppStructArray<char> trimEndCharsWindows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_trimEndCharsWindows, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_trimEndCharsWindows, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x060053AC RID: 21420 RVA: 0x00185AC4 File Offset: 0x00183CC4
		// (set) Token: 0x060053AD RID: 21421 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
		public unsafe static Il2CppStructArray<char> trimEndCharsUnix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_trimEndCharsUnix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_trimEndCharsUnix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400444D RID: 17485
		private static readonly IntPtr NativeFieldInfoPtr_InvalidPathChars;

		// Token: 0x0400444E RID: 17486
		private static readonly IntPtr NativeFieldInfoPtr_AltDirectorySeparatorChar;

		// Token: 0x0400444F RID: 17487
		private static readonly IntPtr NativeFieldInfoPtr_DirectorySeparatorChar;

		// Token: 0x04004450 RID: 17488
		private static readonly IntPtr NativeFieldInfoPtr_PathSeparator;

		// Token: 0x04004451 RID: 17489
		private static readonly IntPtr NativeFieldInfoPtr_DirectorySeparatorStr;

		// Token: 0x04004452 RID: 17490
		private static readonly IntPtr NativeFieldInfoPtr_VolumeSeparatorChar;

		// Token: 0x04004453 RID: 17491
		private static readonly IntPtr NativeFieldInfoPtr_PathSeparatorChars;

		// Token: 0x04004454 RID: 17492
		private static readonly IntPtr NativeFieldInfoPtr_dirEqualsVolume;

		// Token: 0x04004455 RID: 17493
		private static readonly IntPtr NativeFieldInfoPtr_trimEndCharsWindows;

		// Token: 0x04004456 RID: 17494
		private static readonly IntPtr NativeFieldInfoPtr_trimEndCharsUnix;

		// Token: 0x04004457 RID: 17495
		private static readonly IntPtr NativeMethodInfoPtr_ChangeExtension_Public_Static_String_String_String_0;

		// Token: 0x04004458 RID: 17496
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0;

		// Token: 0x04004459 RID: 17497
		private static readonly IntPtr NativeMethodInfoPtr_CleanPath_Internal_Static_String_String_0;

		// Token: 0x0400445A RID: 17498
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectoryName_Public_Static_String_String_0;

		// Token: 0x0400445B RID: 17499
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectoryName_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x0400445C RID: 17500
		private static readonly IntPtr NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0;

		// Token: 0x0400445D RID: 17501
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0;

		// Token: 0x0400445E RID: 17502
		private static readonly IntPtr NativeMethodInfoPtr_GetFileNameWithoutExtension_Public_Static_String_String_0;

		// Token: 0x0400445F RID: 17503
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0;

		// Token: 0x04004460 RID: 17504
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPathInternal_Internal_Static_String_String_0;

		// Token: 0x04004461 RID: 17505
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPathName_Private_Static_Int32_String_Int32_StringBuilder_byref_IntPtr_0;

		// Token: 0x04004462 RID: 17506
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPathName_Internal_Static_String_String_0;

		// Token: 0x04004463 RID: 17507
		private static readonly IntPtr NativeMethodInfoPtr_WindowsDriveAdjustment_Internal_Static_String_String_0;

		// Token: 0x04004464 RID: 17508
		private static readonly IntPtr NativeMethodInfoPtr_InsecureGetFullPath_Internal_Static_String_String_0;

		// Token: 0x04004465 RID: 17509
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0;

		// Token: 0x04004466 RID: 17510
		private static readonly IntPtr NativeMethodInfoPtr_GetPathRoot_Public_Static_String_String_0;

		// Token: 0x04004467 RID: 17511
		private static readonly IntPtr NativeMethodInfoPtr_GetTempPath_Public_Static_String_0;

		// Token: 0x04004468 RID: 17512
		private static readonly IntPtr NativeMethodInfoPtr_get_temp_path_Private_Static_String_0;

		// Token: 0x04004469 RID: 17513
		private static readonly IntPtr NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_ReadOnlySpan_1_Char_0;

		// Token: 0x0400446A RID: 17514
		private static readonly IntPtr NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_String_0;

		// Token: 0x0400446B RID: 17515
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidPathChars_Public_Static_Il2CppStructArray_1_Char_0;

		// Token: 0x0400446C RID: 17516
		private static readonly IntPtr NativeMethodInfoPtr_findExtension_Private_Static_Int32_String_0;

		// Token: 0x0400446D RID: 17517
		private static readonly IntPtr NativeMethodInfoPtr_GetServerAndShare_Private_Static_String_String_0;

		// Token: 0x0400446E RID: 17518
		private static readonly IntPtr NativeMethodInfoPtr_SameRoot_Private_Static_Boolean_String_String_0;

		// Token: 0x0400446F RID: 17519
		private static readonly IntPtr NativeMethodInfoPtr_CanonicalizePath_Private_Static_String_String_0;

		// Token: 0x04004470 RID: 17520
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0;

		// Token: 0x04004471 RID: 17521
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_String_String_String_0;

		// Token: 0x04004472 RID: 17522
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04004473 RID: 17523
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04004474 RID: 17524
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04004475 RID: 17525
		private static readonly IntPtr NativeMethodInfoPtr_JoinInternal_Private_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04004476 RID: 17526
		private static readonly IntPtr NativeMethodInfoPtr_JoinInternal_Private_Static_String_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04004477 RID: 17527
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativePath_Public_Static_String_String_String_0;

		// Token: 0x04004478 RID: 17528
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativePath_Private_Static_String_String_String_StringComparison_0;

		// Token: 0x04004479 RID: 17529
		private static readonly IntPtr NativeMethodInfoPtr_get_StringComparison_Internal_Static_get_StringComparison_0;

		// Token: 0x0400447A RID: 17530
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCaseSensitive_Internal_Static_get_Boolean_0;

		// Token: 0x0400447B RID: 17531
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWindows_Private_Static_get_Boolean_0;

		// Token: 0x0200072D RID: 1837
		[ObfuscatedName("System.IO.Path+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060061FC RID: 25084 RVA: 0x001B78C8 File Offset: 0x001B5AC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Path.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Path>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Path.__c>.NativeClassPtr);
				Path.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path.__c>.NativeClassPtr, "<>9");
				Path.__c.NativeFieldInfoPtr___9__59_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path.__c>.NativeClassPtr, "<>9__59_0");
				Path.__c.NativeFieldInfoPtr___9__60_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path.__c>.NativeClassPtr, "<>9__60_0");
				Path.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path.__c>.NativeClassPtr, 100676138);
				Path.__c.NativeMethodInfoPtr__JoinInternal_b__59_0_Internal_Void_Span_1_Char_ValueTuple_5_IntPtr_Int32_IntPtr_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path.__c>.NativeClassPtr, 100676139);
				Path.__c.NativeMethodInfoPtr__JoinInternal_b__60_0_Internal_Void_Span_1_Char_ValueTuple_8_IntPtr_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_ValueTuple_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path.__c>.NativeClassPtr, 100676140);
			}

			// Token: 0x060061FD RID: 25085 RVA: 0x001B796C File Offset: 0x001B5B6C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Path.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061FE RID: 25086 RVA: 0x001B79A8 File Offset: 0x001B5BA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433346, XrefRangeEnd = 1433360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _JoinInternal_b__59_0(Span<char> destination, ValueTuple<IntPtr, int, IntPtr, int, bool> state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.__c.NativeMethodInfoPtr__JoinInternal_b__59_0_Internal_Void_Span_1_Char_ValueTuple_5_IntPtr_Int32_IntPtr_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061FF RID: 25087 RVA: 0x001B7A08 File Offset: 0x001B5C08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433360, XrefRangeEnd = 1433382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _JoinInternal_b__60_0(Span<char> destination, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>> state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.__c.NativeMethodInfoPtr__JoinInternal_b__60_0_Internal_Void_Span_1_Char_ValueTuple_8_IntPtr_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_ValueTuple_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006200 RID: 25088 RVA: 0x00024492 File Offset: 0x00022692
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001975 RID: 6517
			// (get) Token: 0x06006201 RID: 25089 RVA: 0x001B7A68 File Offset: 0x001B5C68
			// (set) Token: 0x06006202 RID: 25090 RVA: 0x0002449B File Offset: 0x0002269B
			public unsafe static Path.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Path.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Path.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001976 RID: 6518
			// (get) Token: 0x06006203 RID: 25091 RVA: 0x001B7A90 File Offset: 0x001B5C90
			// (set) Token: 0x06006204 RID: 25092 RVA: 0x000244AD File Offset: 0x000226AD
			public unsafe static SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>> __9__59_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Path.__c.NativeFieldInfoPtr___9__59_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Path.__c.NativeFieldInfoPtr___9__59_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001977 RID: 6519
			// (get) Token: 0x06006205 RID: 25093 RVA: 0x001B7AB8 File Offset: 0x001B5CB8
			// (set) Token: 0x06006206 RID: 25094 RVA: 0x000244BF File Offset: 0x000226BF
			public unsafe static SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>> __9__60_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Path.__c.NativeFieldInfoPtr___9__60_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Path.__c.NativeFieldInfoPtr___9__60_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004F27 RID: 20263
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004F28 RID: 20264
			private static readonly IntPtr NativeFieldInfoPtr___9__59_0;

			// Token: 0x04004F29 RID: 20265
			private static readonly IntPtr NativeFieldInfoPtr___9__60_0;

			// Token: 0x04004F2A RID: 20266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004F2B RID: 20267
			private static readonly IntPtr NativeMethodInfoPtr__JoinInternal_b__59_0_Internal_Void_Span_1_Char_ValueTuple_5_IntPtr_Int32_IntPtr_Int32_Boolean_0;

			// Token: 0x04004F2C RID: 20268
			private static readonly IntPtr NativeMethodInfoPtr__JoinInternal_b__60_0_Internal_Void_Span_1_Char_ValueTuple_8_IntPtr_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_ValueTuple_1_Boolean_0;
		}
	}
}
