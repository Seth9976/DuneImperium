using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.IO.Enumeration
{
	// Token: 0x02000553 RID: 1363
	public static class FileSystemEnumerableFactory : Object
	{
		// Token: 0x0600543A RID: 21562 RVA: 0x00187E84 File Offset: 0x00186084
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEnumerableFactory()
		{
			Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO.Enumeration", "FileSystemEnumerableFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr);
			FileSystemEnumerableFactory.NativeFieldInfoPtr_s_unixEscapeChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, "s_unixEscapeChars");
			FileSystemEnumerableFactory.NativeMethodInfoPtr_NormalizeInputs_Internal_Static_Void_byref_String_byref_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, 100676221);
			FileSystemEnumerableFactory.NativeMethodInfoPtr_MatchesPattern_Private_Static_Boolean_String_ReadOnlySpan_1_Char_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, 100676222);
			FileSystemEnumerableFactory.NativeMethodInfoPtr_UserFiles_Internal_Static_IEnumerable_1_String_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, 100676223);
			FileSystemEnumerableFactory.NativeMethodInfoPtr_UserDirectories_Internal_Static_IEnumerable_1_String_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, 100676224);
			FileSystemEnumerableFactory.NativeMethodInfoPtr_UserEntries_Internal_Static_IEnumerable_1_String_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, 100676225);
			FileSystemEnumerableFactory.NativeMethodInfoPtr_FileInfos_Internal_Static_IEnumerable_1_FileInfo_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, 100676226);
			FileSystemEnumerableFactory.NativeMethodInfoPtr_DirectoryInfos_Internal_Static_IEnumerable_1_DirectoryInfo_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, 100676227);
			FileSystemEnumerableFactory.NativeMethodInfoPtr_FileSystemInfos_Internal_Static_IEnumerable_1_FileSystemInfo_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, 100676228);
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x00187F68 File Offset: 0x00186168
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1435006, RefRangeEnd = 1435010, XrefRangeStart = 1434926, XrefRangeEnd = 1435006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(directory);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(expression);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.NativeMethodInfoPtr_NormalizeInputs_Internal_Static_Void_byref_String_byref_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			directory = IL2CPP.Il2CppStringToManaged(intPtr);
			expression = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x00187FE0 File Offset: 0x001861E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1435028, RefRangeEnd = 1435030, XrefRangeStart = 1435010, XrefRangeEnd = 1435028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MatchesPattern(string expression, ReadOnlySpan<char> name, EnumerationOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(name));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.NativeMethodInfoPtr_MatchesPattern_Private_Static_Boolean_String_ReadOnlySpan_1_Char_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x0018804C File Offset: 0x0018624C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435030, XrefRangeEnd = 1435065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expression);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.NativeMethodInfoPtr_UserFiles_Internal_Static_IEnumerable_1_String_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x001880B4 File Offset: 0x001862B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435065, XrefRangeEnd = 1435100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expression);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.NativeMethodInfoPtr_UserDirectories_Internal_Static_IEnumerable_1_String_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x0018811C File Offset: 0x0018631C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1435135, RefRangeEnd = 1435136, XrefRangeStart = 1435100, XrefRangeEnd = 1435135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expression);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.NativeMethodInfoPtr_UserEntries_Internal_Static_IEnumerable_1_String_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x00188184 File Offset: 0x00186384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1435171, RefRangeEnd = 1435173, XrefRangeStart = 1435136, XrefRangeEnd = 1435171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<FileInfo> FileInfos(string directory, string expression, EnumerationOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expression);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.NativeMethodInfoPtr_FileInfos_Internal_Static_IEnumerable_1_FileInfo_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FileInfo>>(intPtr3) : null;
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x001881EC File Offset: 0x001863EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1435173, XrefRangeEnd = 1435208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<DirectoryInfo> DirectoryInfos(string directory, string expression, EnumerationOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expression);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.NativeMethodInfoPtr_DirectoryInfos_Internal_Static_IEnumerable_1_DirectoryInfo_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DirectoryInfo>>(intPtr3) : null;
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x00188254 File Offset: 0x00186454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1435243, RefRangeEnd = 1435244, XrefRangeStart = 1435208, XrefRangeEnd = 1435243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<FileSystemInfo> FileSystemInfos(string directory, string expression, EnumerationOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expression);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.NativeMethodInfoPtr_FileSystemInfos_Internal_Static_IEnumerable_1_FileSystemInfo_String_String_EnumerationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FileSystemInfo>>(intPtr3) : null;
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x0001DD93 File Offset: 0x0001BF93
		public FileSystemEnumerableFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06005444 RID: 21572 RVA: 0x001882BC File Offset: 0x001864BC
		// (set) Token: 0x06005445 RID: 21573 RVA: 0x0001DD9C File Offset: 0x0001BF9C
		public unsafe static Il2CppStructArray<char> s_unixEscapeChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileSystemEnumerableFactory.NativeFieldInfoPtr_s_unixEscapeChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileSystemEnumerableFactory.NativeFieldInfoPtr_s_unixEscapeChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044DD RID: 17629
		private static readonly IntPtr NativeFieldInfoPtr_s_unixEscapeChars;

		// Token: 0x040044DE RID: 17630
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeInputs_Internal_Static_Void_byref_String_byref_String_EnumerationOptions_0;

		// Token: 0x040044DF RID: 17631
		private static readonly IntPtr NativeMethodInfoPtr_MatchesPattern_Private_Static_Boolean_String_ReadOnlySpan_1_Char_EnumerationOptions_0;

		// Token: 0x040044E0 RID: 17632
		private static readonly IntPtr NativeMethodInfoPtr_UserFiles_Internal_Static_IEnumerable_1_String_String_String_EnumerationOptions_0;

		// Token: 0x040044E1 RID: 17633
		private static readonly IntPtr NativeMethodInfoPtr_UserDirectories_Internal_Static_IEnumerable_1_String_String_String_EnumerationOptions_0;

		// Token: 0x040044E2 RID: 17634
		private static readonly IntPtr NativeMethodInfoPtr_UserEntries_Internal_Static_IEnumerable_1_String_String_String_EnumerationOptions_0;

		// Token: 0x040044E3 RID: 17635
		private static readonly IntPtr NativeMethodInfoPtr_FileInfos_Internal_Static_IEnumerable_1_FileInfo_String_String_EnumerationOptions_0;

		// Token: 0x040044E4 RID: 17636
		private static readonly IntPtr NativeMethodInfoPtr_DirectoryInfos_Internal_Static_IEnumerable_1_DirectoryInfo_String_String_EnumerationOptions_0;

		// Token: 0x040044E5 RID: 17637
		private static readonly IntPtr NativeMethodInfoPtr_FileSystemInfos_Internal_Static_IEnumerable_1_FileSystemInfo_String_String_EnumerationOptions_0;

		// Token: 0x02000732 RID: 1842
		[ObfuscatedName("System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06006218 RID: 25112 RVA: 0x001B7FC4 File Offset: 0x001B61C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass3_0>.NativeClassPtr);
				FileSystemEnumerableFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass3_0>.NativeClassPtr, "expression");
				FileSystemEnumerableFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass3_0>.NativeClassPtr, "options");
				FileSystemEnumerableFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass3_0>.NativeClassPtr, 100676230);
				FileSystemEnumerableFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__UserFiles_b__1_Internal_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass3_0>.NativeClassPtr, 100676231);
			}

			// Token: 0x06006219 RID: 25113 RVA: 0x001B8040 File Offset: 0x001B6240
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600621A RID: 25114 RVA: 0x001B807C File Offset: 0x001B627C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434904, XrefRangeEnd = 1434905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UserFiles_b__1(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__UserFiles_b__1_Internal_Boolean_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600621B RID: 25115 RVA: 0x0002450B File Offset: 0x0002270B
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001979 RID: 6521
			// (get) Token: 0x0600621C RID: 25116 RVA: 0x001B80CC File Offset: 0x001B62CC
			// (set) Token: 0x0600621D RID: 25117 RVA: 0x00024514 File Offset: 0x00022714
			public unsafe string expression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_expression);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_expression), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700197A RID: 6522
			// (get) Token: 0x0600621E RID: 25118 RVA: 0x001B80F4 File Offset: 0x001B62F4
			// (set) Token: 0x0600621F RID: 25119 RVA: 0x00024533 File Offset: 0x00022733
			public unsafe EnumerationOptions options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004F37 RID: 20279
			private static readonly IntPtr NativeFieldInfoPtr_expression;

			// Token: 0x04004F38 RID: 20280
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04004F39 RID: 20281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004F3A RID: 20282
			private static readonly IntPtr NativeMethodInfoPtr__UserFiles_b__1_Internal_Boolean_byref_FileSystemEntry_0;
		}

		// Token: 0x02000733 RID: 1843
		[ObfuscatedName("System.IO.Enumeration.FileSystemEnumerableFactory+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006220 RID: 25120 RVA: 0x001B8124 File Offset: 0x001B6324
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr);
				FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, "<>9");
				FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, "<>9__3_0");
				FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, "<>9__4_0");
				FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, "<>9__5_0");
				FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, "<>9__6_0");
				FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, "<>9__7_0");
				FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, "<>9__8_0");
				FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, 100676233);
				FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__UserFiles_b__3_0_Internal_String_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, 100676234);
				FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__UserDirectories_b__4_0_Internal_String_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, 100676235);
				FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__UserEntries_b__5_0_Internal_String_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, 100676236);
				FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__FileInfos_b__6_0_Internal_FileInfo_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, 100676237);
				FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__DirectoryInfos_b__7_0_Internal_DirectoryInfo_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, 100676238);
				FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__FileSystemInfos_b__8_0_Internal_FileSystemInfo_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr, 100676239);
			}

			// Token: 0x06006221 RID: 25121 RVA: 0x001B8268 File Offset: 0x001B6468
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006222 RID: 25122 RVA: 0x001B82A4 File Offset: 0x001B64A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434905, XrefRangeEnd = 1434906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UserFiles_b__3_0(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__UserFiles_b__3_0_Internal_String_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06006223 RID: 25123 RVA: 0x001B82F0 File Offset: 0x001B64F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UserDirectories_b__4_0(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__UserDirectories_b__4_0_Internal_String_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06006224 RID: 25124 RVA: 0x001B833C File Offset: 0x001B653C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UserEntries_b__5_0(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__UserEntries_b__5_0_Internal_String_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06006225 RID: 25125 RVA: 0x001B8388 File Offset: 0x001B6588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434906, XrefRangeEnd = 1434909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FileInfo _FileInfos_b__6_0(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__FileInfos_b__6_0_Internal_FileInfo_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06006226 RID: 25126 RVA: 0x001B83DC File Offset: 0x001B65DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434909, XrefRangeEnd = 1434912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DirectoryInfo _DirectoryInfos_b__7_0(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__DirectoryInfos_b__7_0_Internal_DirectoryInfo_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06006227 RID: 25127 RVA: 0x001B8430 File Offset: 0x001B6630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434912, XrefRangeEnd = 1434913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FileSystemInfo _FileSystemInfos_b__8_0(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c.NativeMethodInfoPtr__FileSystemInfos_b__8_0_Internal_FileSystemInfo_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileSystemInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06006228 RID: 25128 RVA: 0x00024552 File Offset: 0x00022752
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700197B RID: 6523
			// (get) Token: 0x06006229 RID: 25129 RVA: 0x001B8484 File Offset: 0x001B6684
			// (set) Token: 0x0600622A RID: 25130 RVA: 0x0002455B File Offset: 0x0002275B
			public unsafe static FileSystemEnumerableFactory.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerableFactory.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700197C RID: 6524
			// (get) Token: 0x0600622B RID: 25131 RVA: 0x001B84AC File Offset: 0x001B66AC
			// (set) Token: 0x0600622C RID: 25132 RVA: 0x0002456D File Offset: 0x0002276D
			public unsafe static FileSystemEnumerable<string>.FindTransform __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<string>.FindTransform>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700197D RID: 6525
			// (get) Token: 0x0600622D RID: 25133 RVA: 0x001B84D4 File Offset: 0x001B66D4
			// (set) Token: 0x0600622E RID: 25134 RVA: 0x0002457F File Offset: 0x0002277F
			public unsafe static FileSystemEnumerable<string>.FindTransform __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<string>.FindTransform>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700197E RID: 6526
			// (get) Token: 0x0600622F RID: 25135 RVA: 0x001B84FC File Offset: 0x001B66FC
			// (set) Token: 0x06006230 RID: 25136 RVA: 0x00024591 File Offset: 0x00022791
			public unsafe static FileSystemEnumerable<string>.FindTransform __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<string>.FindTransform>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700197F RID: 6527
			// (get) Token: 0x06006231 RID: 25137 RVA: 0x001B8524 File Offset: 0x001B6724
			// (set) Token: 0x06006232 RID: 25138 RVA: 0x000245A3 File Offset: 0x000227A3
			public unsafe static FileSystemEnumerable<FileInfo>.FindTransform __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<FileInfo>.FindTransform>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001980 RID: 6528
			// (get) Token: 0x06006233 RID: 25139 RVA: 0x001B854C File Offset: 0x001B674C
			// (set) Token: 0x06006234 RID: 25140 RVA: 0x000245B5 File Offset: 0x000227B5
			public unsafe static FileSystemEnumerable<DirectoryInfo>.FindTransform __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<DirectoryInfo>.FindTransform>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001981 RID: 6529
			// (get) Token: 0x06006235 RID: 25141 RVA: 0x001B8574 File Offset: 0x001B6774
			// (set) Token: 0x06006236 RID: 25142 RVA: 0x000245C7 File Offset: 0x000227C7
			public unsafe static FileSystemEnumerable<FileSystemInfo>.FindTransform __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<FileSystemInfo>.FindTransform>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FileSystemEnumerableFactory.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004F3B RID: 20283
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004F3C RID: 20284
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04004F3D RID: 20285
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04004F3E RID: 20286
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04004F3F RID: 20287
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04004F40 RID: 20288
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04004F41 RID: 20289
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04004F42 RID: 20290
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004F43 RID: 20291
			private static readonly IntPtr NativeMethodInfoPtr__UserFiles_b__3_0_Internal_String_byref_FileSystemEntry_0;

			// Token: 0x04004F44 RID: 20292
			private static readonly IntPtr NativeMethodInfoPtr__UserDirectories_b__4_0_Internal_String_byref_FileSystemEntry_0;

			// Token: 0x04004F45 RID: 20293
			private static readonly IntPtr NativeMethodInfoPtr__UserEntries_b__5_0_Internal_String_byref_FileSystemEntry_0;

			// Token: 0x04004F46 RID: 20294
			private static readonly IntPtr NativeMethodInfoPtr__FileInfos_b__6_0_Internal_FileInfo_byref_FileSystemEntry_0;

			// Token: 0x04004F47 RID: 20295
			private static readonly IntPtr NativeMethodInfoPtr__DirectoryInfos_b__7_0_Internal_DirectoryInfo_byref_FileSystemEntry_0;

			// Token: 0x04004F48 RID: 20296
			private static readonly IntPtr NativeMethodInfoPtr__FileSystemInfos_b__8_0_Internal_FileSystemInfo_byref_FileSystemEntry_0;
		}

		// Token: 0x02000734 RID: 1844
		[ObfuscatedName("System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06006237 RID: 25143 RVA: 0x001B859C File Offset: 0x001B679C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass4_0>.NativeClassPtr);
				FileSystemEnumerableFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass4_0>.NativeClassPtr, "expression");
				FileSystemEnumerableFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass4_0>.NativeClassPtr, "options");
				FileSystemEnumerableFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass4_0>.NativeClassPtr, 100676240);
				FileSystemEnumerableFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__UserDirectories_b__1_Internal_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass4_0>.NativeClassPtr, 100676241);
			}

			// Token: 0x06006238 RID: 25144 RVA: 0x001B8618 File Offset: 0x001B6818
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006239 RID: 25145 RVA: 0x001B8654 File Offset: 0x001B6854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434913, XrefRangeEnd = 1434914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UserDirectories_b__1(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__UserDirectories_b__1_Internal_Boolean_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600623A RID: 25146 RVA: 0x000245D9 File Offset: 0x000227D9
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001982 RID: 6530
			// (get) Token: 0x0600623B RID: 25147 RVA: 0x001B86A4 File Offset: 0x001B68A4
			// (set) Token: 0x0600623C RID: 25148 RVA: 0x000245E2 File Offset: 0x000227E2
			public unsafe string expression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_expression);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_expression), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001983 RID: 6531
			// (get) Token: 0x0600623D RID: 25149 RVA: 0x001B86CC File Offset: 0x001B68CC
			// (set) Token: 0x0600623E RID: 25150 RVA: 0x00024601 File Offset: 0x00022801
			public unsafe EnumerationOptions options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004F49 RID: 20297
			private static readonly IntPtr NativeFieldInfoPtr_expression;

			// Token: 0x04004F4A RID: 20298
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04004F4B RID: 20299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004F4C RID: 20300
			private static readonly IntPtr NativeMethodInfoPtr__UserDirectories_b__1_Internal_Boolean_byref_FileSystemEntry_0;
		}

		// Token: 0x02000735 RID: 1845
		[ObfuscatedName("System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600623F RID: 25151 RVA: 0x001B86FC File Offset: 0x001B68FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass5_0>.NativeClassPtr);
				FileSystemEnumerableFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass5_0>.NativeClassPtr, "expression");
				FileSystemEnumerableFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass5_0>.NativeClassPtr, "options");
				FileSystemEnumerableFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass5_0>.NativeClassPtr, 100676242);
				FileSystemEnumerableFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__UserEntries_b__1_Internal_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass5_0>.NativeClassPtr, 100676243);
			}

			// Token: 0x06006240 RID: 25152 RVA: 0x001B8778 File Offset: 0x001B6978
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006241 RID: 25153 RVA: 0x001B87B4 File Offset: 0x001B69B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434914, XrefRangeEnd = 1434919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UserEntries_b__1(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__UserEntries_b__1_Internal_Boolean_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006242 RID: 25154 RVA: 0x00024620 File Offset: 0x00022820
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001984 RID: 6532
			// (get) Token: 0x06006243 RID: 25155 RVA: 0x001B8804 File Offset: 0x001B6A04
			// (set) Token: 0x06006244 RID: 25156 RVA: 0x00024629 File Offset: 0x00022829
			public unsafe string expression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_expression);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_expression), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001985 RID: 6533
			// (get) Token: 0x06006245 RID: 25157 RVA: 0x001B882C File Offset: 0x001B6A2C
			// (set) Token: 0x06006246 RID: 25158 RVA: 0x00024648 File Offset: 0x00022848
			public unsafe EnumerationOptions options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004F4D RID: 20301
			private static readonly IntPtr NativeFieldInfoPtr_expression;

			// Token: 0x04004F4E RID: 20302
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04004F4F RID: 20303
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004F50 RID: 20304
			private static readonly IntPtr NativeMethodInfoPtr__UserEntries_b__1_Internal_Boolean_byref_FileSystemEntry_0;
		}

		// Token: 0x02000736 RID: 1846
		[ObfuscatedName("System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06006247 RID: 25159 RVA: 0x001B885C File Offset: 0x001B6A5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass6_0>.NativeClassPtr);
				FileSystemEnumerableFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass6_0>.NativeClassPtr, "expression");
				FileSystemEnumerableFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass6_0>.NativeClassPtr, "options");
				FileSystemEnumerableFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass6_0>.NativeClassPtr, 100676244);
				FileSystemEnumerableFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__FileInfos_b__1_Internal_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass6_0>.NativeClassPtr, 100676245);
			}

			// Token: 0x06006248 RID: 25160 RVA: 0x001B88D8 File Offset: 0x001B6AD8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006249 RID: 25161 RVA: 0x001B8914 File Offset: 0x001B6B14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434919, XrefRangeEnd = 1434920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FileInfos_b__1(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__FileInfos_b__1_Internal_Boolean_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600624A RID: 25162 RVA: 0x00024667 File Offset: 0x00022867
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001986 RID: 6534
			// (get) Token: 0x0600624B RID: 25163 RVA: 0x001B8964 File Offset: 0x001B6B64
			// (set) Token: 0x0600624C RID: 25164 RVA: 0x00024670 File Offset: 0x00022870
			public unsafe string expression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_expression);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_expression), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001987 RID: 6535
			// (get) Token: 0x0600624D RID: 25165 RVA: 0x001B898C File Offset: 0x001B6B8C
			// (set) Token: 0x0600624E RID: 25166 RVA: 0x0002468F File Offset: 0x0002288F
			public unsafe EnumerationOptions options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004F51 RID: 20305
			private static readonly IntPtr NativeFieldInfoPtr_expression;

			// Token: 0x04004F52 RID: 20306
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04004F53 RID: 20307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004F54 RID: 20308
			private static readonly IntPtr NativeMethodInfoPtr__FileInfos_b__1_Internal_Boolean_byref_FileSystemEntry_0;
		}

		// Token: 0x02000737 RID: 1847
		[ObfuscatedName("System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600624F RID: 25167 RVA: 0x001B89BC File Offset: 0x001B6BBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass7_0>.NativeClassPtr);
				FileSystemEnumerableFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass7_0>.NativeClassPtr, "expression");
				FileSystemEnumerableFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass7_0>.NativeClassPtr, "options");
				FileSystemEnumerableFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass7_0>.NativeClassPtr, 100676246);
				FileSystemEnumerableFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__DirectoryInfos_b__1_Internal_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass7_0>.NativeClassPtr, 100676247);
			}

			// Token: 0x06006250 RID: 25168 RVA: 0x001B8A38 File Offset: 0x001B6C38
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006251 RID: 25169 RVA: 0x001B8A74 File Offset: 0x001B6C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434920, XrefRangeEnd = 1434921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DirectoryInfos_b__1(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__DirectoryInfos_b__1_Internal_Boolean_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006252 RID: 25170 RVA: 0x000246AE File Offset: 0x000228AE
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001988 RID: 6536
			// (get) Token: 0x06006253 RID: 25171 RVA: 0x001B8AC4 File Offset: 0x001B6CC4
			// (set) Token: 0x06006254 RID: 25172 RVA: 0x000246B7 File Offset: 0x000228B7
			public unsafe string expression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_expression);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_expression), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001989 RID: 6537
			// (get) Token: 0x06006255 RID: 25173 RVA: 0x001B8AEC File Offset: 0x001B6CEC
			// (set) Token: 0x06006256 RID: 25174 RVA: 0x000246D6 File Offset: 0x000228D6
			public unsafe EnumerationOptions options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004F55 RID: 20309
			private static readonly IntPtr NativeFieldInfoPtr_expression;

			// Token: 0x04004F56 RID: 20310
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04004F57 RID: 20311
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004F58 RID: 20312
			private static readonly IntPtr NativeMethodInfoPtr__DirectoryInfos_b__1_Internal_Boolean_byref_FileSystemEntry_0;
		}

		// Token: 0x02000738 RID: 1848
		[ObfuscatedName("System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06006257 RID: 25175 RVA: 0x001B8B1C File Offset: 0x001B6D1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemEnumerableFactory>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass8_0>.NativeClassPtr);
				FileSystemEnumerableFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass8_0>.NativeClassPtr, "expression");
				FileSystemEnumerableFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass8_0>.NativeClassPtr, "options");
				FileSystemEnumerableFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass8_0>.NativeClassPtr, 100676248);
				FileSystemEnumerableFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__FileSystemInfos_b__1_Internal_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass8_0>.NativeClassPtr, 100676249);
			}

			// Token: 0x06006258 RID: 25176 RVA: 0x001B8B98 File Offset: 0x001B6D98
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerableFactory.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006259 RID: 25177 RVA: 0x001B8BD4 File Offset: 0x001B6DD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434921, XrefRangeEnd = 1434926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FileSystemInfos_b__1(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerableFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__FileSystemInfos_b__1_Internal_Boolean_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600625A RID: 25178 RVA: 0x000246F5 File Offset: 0x000228F5
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700198A RID: 6538
			// (get) Token: 0x0600625B RID: 25179 RVA: 0x001B8C24 File Offset: 0x001B6E24
			// (set) Token: 0x0600625C RID: 25180 RVA: 0x000246FE File Offset: 0x000228FE
			public unsafe string expression
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_expression);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_expression), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700198B RID: 6539
			// (get) Token: 0x0600625D RID: 25181 RVA: 0x001B8C4C File Offset: 0x001B6E4C
			// (set) Token: 0x0600625E RID: 25182 RVA: 0x0002471D File Offset: 0x0002291D
			public unsafe EnumerationOptions options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerableFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004F59 RID: 20313
			private static readonly IntPtr NativeFieldInfoPtr_expression;

			// Token: 0x04004F5A RID: 20314
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04004F5B RID: 20315
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004F5C RID: 20316
			private static readonly IntPtr NativeMethodInfoPtr__FileSystemInfos_b__1_Internal_Boolean_byref_FileSystemEntry_0;
		}
	}
}
