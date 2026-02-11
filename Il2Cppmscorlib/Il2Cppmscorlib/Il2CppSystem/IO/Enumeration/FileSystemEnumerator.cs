using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.ConstrainedExecution;

namespace Il2CppSystem.IO.Enumeration
{
	// Token: 0x02000550 RID: 1360
	public class FileSystemEnumerator<TResult> : CriticalFinalizerObject
	{
		// Token: 0x060053DD RID: 21469 RVA: 0x0018682C File Offset: 0x00184A2C
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEnumerator()
		{
			Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO.Enumeration", "FileSystemEnumerator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr);
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__originalRootDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_originalRootDirectory");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__rootDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_rootDirectory");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_options");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_lock");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_entry");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_current");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_buffer");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__bufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_bufferLength");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__directoryHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_directoryHandle");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__currentPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_currentPath");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__lastEntryFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_lastEntryFound");
			FileSystemEnumerator<TResult>.NativeFieldInfoPtr__pending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, "_pending");
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_GetDataUWP_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676171);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_CreateRelativeDirectoryHandleUWP_Private_IntPtr_ReadOnlySpan_1_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676172);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr__ctor_Public_Void_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676173);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_CloseDirectoryHandle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676174);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_CreateDirectoryHandle_Private_IntPtr_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676175);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_ContinueOnDirectoryError_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676176);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676177);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_FindNextEntry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676178);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_DequeueNextDirectory_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676179);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_InternalDispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676180);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_GetData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676181);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_CreateRelativeDirectoryHandle_Private_IntPtr_ReadOnlySpan_1_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676182);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_ShouldIncludeEntry_Protected_Virtual_New_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676183);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_ShouldRecurseIntoEntry_Protected_Virtual_New_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676184);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_TransformEntry_Protected_Abstract_Virtual_New_TResult_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676185);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_OnDirectoryFinished_Protected_Virtual_New_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676186);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_ContinueOnError_Protected_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676187);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676188);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676189);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_DirectoryFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676190);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676191);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676192);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676193);
			FileSystemEnumerator<TResult>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr, 100676194);
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x00186B68 File Offset: 0x00184D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434614, XrefRangeEnd = 1434619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetDataUWP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_GetDataUWP_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x00186BA4 File Offset: 0x00184DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434619, XrefRangeEnd = 1434620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr CreateRelativeDirectoryHandleUWP(ReadOnlySpan<char> relativePath, string fullPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(relativePath));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_CreateRelativeDirectoryHandleUWP_Private_IntPtr_ReadOnlySpan_1_Char_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x00186C08 File Offset: 0x00184E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1434659, RefRangeEnd = 1434660, XrefRangeStart = 1434620, XrefRangeEnd = 1434659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemEnumerator(string directory, EnumerationOptions options = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerator<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr__ctor_Public_Void_String_EnumerationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x00186C68 File Offset: 0x00184E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434660, XrefRangeEnd = 1434663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseDirectoryHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_CloseDirectoryHandle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x00186C9C File Offset: 0x00184E9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1434684, RefRangeEnd = 1434686, XrefRangeStart = 1434663, XrefRangeEnd = 1434684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_CreateDirectoryHandle_Private_IntPtr_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x00186CF8 File Offset: 0x00184EF8
		[CallerCount(0)]
		public unsafe bool ContinueOnDirectoryError(int error, bool ignoreNotFound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_ContinueOnDirectoryError_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053E4 RID: 21476 RVA: 0x00186D50 File Offset: 0x00184F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434686, XrefRangeEnd = 1434743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x00186D8C File Offset: 0x00184F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434743, XrefRangeEnd = 1434749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindNextEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_FindNextEntry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x00186DC0 File Offset: 0x00184FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434749, XrefRangeEnd = 1434754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DequeueNextDirectory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_DequeueNextDirectory_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x00186DFC File Offset: 0x00184FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1434773, RefRangeEnd = 1434775, XrefRangeStart = 1434754, XrefRangeEnd = 1434773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_InternalDispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x00186E3C File Offset: 0x0018503C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434775, XrefRangeEnd = 1434776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_GetData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x00186E78 File Offset: 0x00185078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434776, XrefRangeEnd = 1434778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr CreateRelativeDirectoryHandle(ReadOnlySpan<char> relativePath, string fullPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(relativePath));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_CreateRelativeDirectoryHandle_Private_IntPtr_ReadOnlySpan_1_Char_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x00186EDC File Offset: 0x001850DC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldIncludeEntry(ref FileSystemEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerator<TResult>.NativeMethodInfoPtr_ShouldIncludeEntry_Protected_Virtual_New_Boolean_byref_FileSystemEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x00186F38 File Offset: 0x00185138
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerator<TResult>.NativeMethodInfoPtr_ShouldRecurseIntoEntry_Protected_Virtual_New_Boolean_byref_FileSystemEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x00186F94 File Offset: 0x00185194
		[CallerCount(0)]
		public unsafe virtual TResult TransformEntry(ref FileSystemEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerator<TResult>.NativeMethodInfoPtr_TransformEntry_Protected_Abstract_Virtual_New_TResult_byref_FileSystemEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x00186FEC File Offset: 0x001851EC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDirectoryFinished(ReadOnlySpan<char> directory)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(directory));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerator<TResult>.NativeMethodInfoPtr_OnDirectoryFinished_Protected_Virtual_New_Void_ReadOnlySpan_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x00187040 File Offset: 0x00185240
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContinueOnError(int error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerator<TResult>.NativeMethodInfoPtr_ContinueOnError_Protected_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x060053EF RID: 21487 RVA: 0x00187094 File Offset: 0x00185294
		public unsafe virtual TResult Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x060053F0 RID: 21488 RVA: 0x001870D0 File Offset: 0x001852D0
		public unsafe virtual Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x00187110 File Offset: 0x00185310
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1434790, RefRangeEnd = 1434793, XrefRangeStart = 1434778, XrefRangeEnd = 1434790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DirectoryFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_DirectoryFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x00187144 File Offset: 0x00185344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x00187178 File Offset: 0x00185378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434793, XrefRangeEnd = 1434798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerator<TResult>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x001871AC File Offset: 0x001853AC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerator<TResult>.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x001871F8 File Offset: 0x001853F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434798, XrefRangeEnd = 1434802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemEnumerator<TResult>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x0001DAC6 File Offset: 0x0001BCC6
		public FileSystemEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x060053F7 RID: 21495 RVA: 0x00187234 File Offset: 0x00185434
		// (set) Token: 0x060053F8 RID: 21496 RVA: 0x0001DACF File Offset: 0x0001BCCF
		public unsafe string _originalRootDirectory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__originalRootDirectory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__originalRootDirectory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x060053F9 RID: 21497 RVA: 0x0018725C File Offset: 0x0018545C
		// (set) Token: 0x060053FA RID: 21498 RVA: 0x0001DAEE File Offset: 0x0001BCEE
		public unsafe string _rootDirectory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__rootDirectory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__rootDirectory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x060053FB RID: 21499 RVA: 0x00187284 File Offset: 0x00185484
		// (set) Token: 0x060053FC RID: 21500 RVA: 0x0001DB0D File Offset: 0x0001BD0D
		public unsafe EnumerationOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x060053FD RID: 21501 RVA: 0x001872B4 File Offset: 0x001854B4
		// (set) Token: 0x060053FE RID: 21502 RVA: 0x0001DB2C File Offset: 0x0001BD2C
		public unsafe Object _lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x060053FF RID: 21503 RVA: 0x001872E4 File Offset: 0x001854E4
		// (set) Token: 0x06005400 RID: 21504 RVA: 0x0001DB4B File Offset: 0x0001BD4B
		public unsafe Interop.NtDll.FILE_FULL_DIR_INFORMATION* _entry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__entry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__entry)) = value;
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06005401 RID: 21505 RVA: 0x00187308 File Offset: 0x00185508
		// (set) Token: 0x06005402 RID: 21506 RVA: 0x00187330 File Offset: 0x00185530
		public unsafe TResult _current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__current);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__current);
				Type typeFromHandle = typeof(TResult);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06005403 RID: 21507 RVA: 0x001873D8 File Offset: 0x001855D8
		// (set) Token: 0x06005404 RID: 21508 RVA: 0x0001DB66 File Offset: 0x0001BD66
		public unsafe IntPtr _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__buffer)) = value;
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06005405 RID: 21509 RVA: 0x00187400 File Offset: 0x00185600
		// (set) Token: 0x06005406 RID: 21510 RVA: 0x0001DB81 File Offset: 0x0001BD81
		public unsafe int _bufferLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__bufferLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__bufferLength)) = value;
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06005407 RID: 21511 RVA: 0x00187428 File Offset: 0x00185628
		// (set) Token: 0x06005408 RID: 21512 RVA: 0x0001DB9C File Offset: 0x0001BD9C
		public unsafe IntPtr _directoryHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__directoryHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__directoryHandle)) = value;
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06005409 RID: 21513 RVA: 0x00187450 File Offset: 0x00185650
		// (set) Token: 0x0600540A RID: 21514 RVA: 0x0001DBB7 File Offset: 0x0001BDB7
		public unsafe string _currentPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__currentPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__currentPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x0600540B RID: 21515 RVA: 0x00187478 File Offset: 0x00185678
		// (set) Token: 0x0600540C RID: 21516 RVA: 0x0001DBD6 File Offset: 0x0001BDD6
		public unsafe bool _lastEntryFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__lastEntryFound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__lastEntryFound)) = value;
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x0600540D RID: 21517 RVA: 0x001874A0 File Offset: 0x001856A0
		// (set) Token: 0x0600540E RID: 21518 RVA: 0x0001DBF1 File Offset: 0x0001BDF1
		public unsafe Queue<ValueTuple<IntPtr, string>> _pending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__pending);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ValueTuple<IntPtr, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerator<TResult>.NativeFieldInfoPtr__pending), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400449D RID: 17565
		private static readonly IntPtr NativeFieldInfoPtr__originalRootDirectory;

		// Token: 0x0400449E RID: 17566
		private static readonly IntPtr NativeFieldInfoPtr__rootDirectory;

		// Token: 0x0400449F RID: 17567
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x040044A0 RID: 17568
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x040044A1 RID: 17569
		private static readonly IntPtr NativeFieldInfoPtr__entry;

		// Token: 0x040044A2 RID: 17570
		private static readonly IntPtr NativeFieldInfoPtr__current;

		// Token: 0x040044A3 RID: 17571
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x040044A4 RID: 17572
		private static readonly IntPtr NativeFieldInfoPtr__bufferLength;

		// Token: 0x040044A5 RID: 17573
		private static readonly IntPtr NativeFieldInfoPtr__directoryHandle;

		// Token: 0x040044A6 RID: 17574
		private static readonly IntPtr NativeFieldInfoPtr__currentPath;

		// Token: 0x040044A7 RID: 17575
		private static readonly IntPtr NativeFieldInfoPtr__lastEntryFound;

		// Token: 0x040044A8 RID: 17576
		private static readonly IntPtr NativeFieldInfoPtr__pending;

		// Token: 0x040044A9 RID: 17577
		private static readonly IntPtr NativeMethodInfoPtr_GetDataUWP_Private_Boolean_0;

		// Token: 0x040044AA RID: 17578
		private static readonly IntPtr NativeMethodInfoPtr_CreateRelativeDirectoryHandleUWP_Private_IntPtr_ReadOnlySpan_1_Char_String_0;

		// Token: 0x040044AB RID: 17579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EnumerationOptions_0;

		// Token: 0x040044AC RID: 17580
		private static readonly IntPtr NativeMethodInfoPtr_CloseDirectoryHandle_Private_Void_0;

		// Token: 0x040044AD RID: 17581
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectoryHandle_Private_IntPtr_String_Boolean_0;

		// Token: 0x040044AE RID: 17582
		private static readonly IntPtr NativeMethodInfoPtr_ContinueOnDirectoryError_Private_Boolean_Int32_Boolean_0;

		// Token: 0x040044AF RID: 17583
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040044B0 RID: 17584
		private static readonly IntPtr NativeMethodInfoPtr_FindNextEntry_Private_Void_0;

		// Token: 0x040044B1 RID: 17585
		private static readonly IntPtr NativeMethodInfoPtr_DequeueNextDirectory_Private_Boolean_0;

		// Token: 0x040044B2 RID: 17586
		private static readonly IntPtr NativeMethodInfoPtr_InternalDispose_Private_Void_Boolean_0;

		// Token: 0x040044B3 RID: 17587
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Private_Boolean_0;

		// Token: 0x040044B4 RID: 17588
		private static readonly IntPtr NativeMethodInfoPtr_CreateRelativeDirectoryHandle_Private_IntPtr_ReadOnlySpan_1_Char_String_0;

		// Token: 0x040044B5 RID: 17589
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIncludeEntry_Protected_Virtual_New_Boolean_byref_FileSystemEntry_0;

		// Token: 0x040044B6 RID: 17590
		private static readonly IntPtr NativeMethodInfoPtr_ShouldRecurseIntoEntry_Protected_Virtual_New_Boolean_byref_FileSystemEntry_0;

		// Token: 0x040044B7 RID: 17591
		private static readonly IntPtr NativeMethodInfoPtr_TransformEntry_Protected_Abstract_Virtual_New_TResult_byref_FileSystemEntry_0;

		// Token: 0x040044B8 RID: 17592
		private static readonly IntPtr NativeMethodInfoPtr_OnDirectoryFinished_Protected_Virtual_New_Void_ReadOnlySpan_1_Char_0;

		// Token: 0x040044B9 RID: 17593
		private static readonly IntPtr NativeMethodInfoPtr_ContinueOnError_Protected_Virtual_New_Boolean_Int32_0;

		// Token: 0x040044BA RID: 17594
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TResult_0;

		// Token: 0x040044BB RID: 17595
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040044BC RID: 17596
		private static readonly IntPtr NativeMethodInfoPtr_DirectoryFinished_Private_Void_0;

		// Token: 0x040044BD RID: 17597
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x040044BE RID: 17598
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040044BF RID: 17599
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040044C0 RID: 17600
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
