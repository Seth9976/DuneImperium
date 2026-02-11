using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.IO
{
	// Token: 0x02000533 RID: 1331
	public static class Directory : Object
	{
		// Token: 0x06005185 RID: 20869 RVA: 0x0017B6BC File Offset: 0x001798BC
		// Note: this type is marked as 'beforefieldinit'.
		static Directory()
		{
			Il2CppClassPointerStore<Directory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Directory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Directory>.NativeClassPtr);
			Directory.NativeMethodInfoPtr_GetParent_Public_Static_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675701);
			Directory.NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675702);
			Directory.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675703);
			Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675704);
			Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675705);
			Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675706);
			Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675707);
			Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675708);
			Directory.NativeMethodInfoPtr_GetFileSystemEntries_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675709);
			Directory.NativeMethodInfoPtr_GetFileSystemEntries_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675710);
			Directory.NativeMethodInfoPtr_InternalEnumeratePaths_Internal_Static_IEnumerable_1_String_String_String_SearchTarget_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675711);
			Directory.NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675712);
			Directory.NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_String_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675713);
			Directory.NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675714);
			Directory.NativeMethodInfoPtr_EnumerateFiles_Public_Static_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675715);
			Directory.NativeMethodInfoPtr_EnumerateFiles_Public_Static_IEnumerable_1_String_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675716);
			Directory.NativeMethodInfoPtr_InternalGetDirectoryRoot_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675717);
			Directory.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675718);
			Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675719);
			Directory.NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100675720);
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x0017B87C File Offset: 0x00179A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430109, RefRangeEnd = 1430110, XrefRangeStart = 1430095, XrefRangeEnd = 1430109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DirectoryInfo GetParent(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetParent_Public_Static_DirectoryInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x0017B8C0 File Offset: 0x00179AC0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1430119, RefRangeEnd = 1430132, XrefRangeStart = 1430110, XrefRangeEnd = 1430119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DirectoryInfo CreateDirectory(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x0017B904 File Offset: 0x00179B04
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 1430139, RefRangeEnd = 1430190, XrefRangeStart = 1430132, XrefRangeEnd = 1430139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x0017B948 File Offset: 0x00179B48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1430203, RefRangeEnd = 1430205, XrefRangeStart = 1430190, XrefRangeEnd = 1430203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetFiles(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x0017B98C File Offset: 0x00179B8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1430216, RefRangeEnd = 1430220, XrefRangeStart = 1430205, XrefRangeEnd = 1430216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetFiles(string path, string searchPattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x0017B9E4 File Offset: 0x00179BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430220, XrefRangeEnd = 1430224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerationOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x0017BA4C File Offset: 0x00179C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430237, RefRangeEnd = 1430238, XrefRangeStart = 1430224, XrefRangeEnd = 1430237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetDirectories(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x0017BA90 File Offset: 0x00179C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430238, XrefRangeEnd = 1430242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerationOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x0017BAF8 File Offset: 0x00179CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430253, RefRangeEnd = 1430254, XrefRangeStart = 1430242, XrefRangeEnd = 1430253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetFileSystemEntries(string path, string searchPattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetFileSystemEntries_Public_Static_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x0017BB50 File Offset: 0x00179D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430254, XrefRangeEnd = 1430258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerationOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetFileSystemEntries_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x0017BBB8 File Offset: 0x00179DB8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1430265, RefRangeEnd = 1430277, XrefRangeStart = 1430258, XrefRangeEnd = 1430265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchTarget;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InternalEnumeratePaths_Internal_Static_IEnumerable_1_String_String_String_SearchTarget_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x0017BC30 File Offset: 0x00179E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430287, RefRangeEnd = 1430288, XrefRangeStart = 1430277, XrefRangeEnd = 1430287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> EnumerateDirectories(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x0017BC74 File Offset: 0x00179E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430293, RefRangeEnd = 1430294, XrefRangeStart = 1430288, XrefRangeEnd = 1430293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_String_SearchOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x0017BCD8 File Offset: 0x00179ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430294, XrefRangeEnd = 1430295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerationOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x0017BD40 File Offset: 0x00179F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430305, RefRangeEnd = 1430306, XrefRangeStart = 1430295, XrefRangeEnd = 1430305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> EnumerateFiles(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_EnumerateFiles_Public_Static_IEnumerable_1_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x0017BD84 File Offset: 0x00179F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430306, XrefRangeEnd = 1430307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerationOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_EnumerateFiles_Public_Static_IEnumerable_1_String_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x0017BDEC File Offset: 0x00179FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430314, RefRangeEnd = 1430315, XrefRangeStart = 1430307, XrefRangeEnd = 1430314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalGetDirectoryRoot(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InternalGetDirectoryRoot_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x0017BE28 File Offset: 0x0017A028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1430316, RefRangeEnd = 1430318, XrefRangeStart = 1430315, XrefRangeEnd = 1430316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentDirectory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x0017BE54 File Offset: 0x0017A054
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1430323, RefRangeEnd = 1430330, XrefRangeStart = 1430318, XrefRangeEnd = 1430323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete(string path, bool recursive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x0017BE98 File Offset: 0x0017A098
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1430334, RefRangeEnd = 1430338, XrefRangeStart = 1430330, XrefRangeEnd = 1430334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InsecureGetCurrentDirectory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x0001D14F File Offset: 0x0001B34F
		public Directory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400427B RID: 17019
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_Static_DirectoryInfo_String_0;

		// Token: 0x0400427C RID: 17020
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0;

		// Token: 0x0400427D RID: 17021
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

		// Token: 0x0400427E RID: 17022
		private static readonly IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x0400427F RID: 17023
		private static readonly IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_0;

		// Token: 0x04004280 RID: 17024
		private static readonly IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0;

		// Token: 0x04004281 RID: 17025
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04004282 RID: 17026
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0;

		// Token: 0x04004283 RID: 17027
		private static readonly IntPtr NativeMethodInfoPtr_GetFileSystemEntries_Public_Static_Il2CppStringArray_String_String_0;

		// Token: 0x04004284 RID: 17028
		private static readonly IntPtr NativeMethodInfoPtr_GetFileSystemEntries_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0;

		// Token: 0x04004285 RID: 17029
		private static readonly IntPtr NativeMethodInfoPtr_InternalEnumeratePaths_Internal_Static_IEnumerable_1_String_String_String_SearchTarget_EnumerationOptions_0;

		// Token: 0x04004286 RID: 17030
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_0;

		// Token: 0x04004287 RID: 17031
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_String_SearchOption_0;

		// Token: 0x04004288 RID: 17032
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateDirectories_Public_Static_IEnumerable_1_String_String_String_EnumerationOptions_0;

		// Token: 0x04004289 RID: 17033
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateFiles_Public_Static_IEnumerable_1_String_String_0;

		// Token: 0x0400428A RID: 17034
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateFiles_Public_Static_IEnumerable_1_String_String_String_EnumerationOptions_0;

		// Token: 0x0400428B RID: 17035
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetDirectoryRoot_Internal_Static_String_String_0;

		// Token: 0x0400428C RID: 17036
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0;

		// Token: 0x0400428D RID: 17037
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0;

		// Token: 0x0400428E RID: 17038
		private static readonly IntPtr NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0;
	}
}
