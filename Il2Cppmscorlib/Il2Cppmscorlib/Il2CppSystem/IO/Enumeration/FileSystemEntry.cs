using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO.Enumeration
{
	// Token: 0x02000551 RID: 1361
	public sealed class FileSystemEntry : ValueType
	{
		// Token: 0x0600540F RID: 21519 RVA: 0x001874D0 File Offset: 0x001856D0
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEntry()
		{
			Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO.Enumeration", "FileSystemEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr);
			FileSystemEntry.NativeFieldInfoPtr__info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, "_info");
			FileSystemEntry.NativeFieldInfoPtr__Directory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, "<Directory>k__BackingField");
			FileSystemEntry.NativeFieldInfoPtr__RootDirectory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, "<RootDirectory>k__BackingField");
			FileSystemEntry.NativeFieldInfoPtr__OriginalRootDirectory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, "<OriginalRootDirectory>k__BackingField");
			FileSystemEntry.NativeMethodInfoPtr_Initialize_Internal_Static_Void_byref_FileSystemEntry_ptr_FILE_FULL_DIR_INFORMATION_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676195);
			FileSystemEntry.NativeMethodInfoPtr_get_Directory_Public_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676196);
			FileSystemEntry.NativeMethodInfoPtr_set_Directory_Private_set_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676197);
			FileSystemEntry.NativeMethodInfoPtr_get_RootDirectory_Public_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676198);
			FileSystemEntry.NativeMethodInfoPtr_set_RootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676199);
			FileSystemEntry.NativeMethodInfoPtr_get_OriginalRootDirectory_Public_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676200);
			FileSystemEntry.NativeMethodInfoPtr_set_OriginalRootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676201);
			FileSystemEntry.NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676202);
			FileSystemEntry.NativeMethodInfoPtr_get_Attributes_Public_get_FileAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676203);
			FileSystemEntry.NativeMethodInfoPtr_get_IsDirectory_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676204);
			FileSystemEntry.NativeMethodInfoPtr_ToFileSystemInfo_Public_FileSystemInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676205);
			FileSystemEntry.NativeMethodInfoPtr_ToSpecifiedFullPath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100676206);
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x00187640 File Offset: 0x00185840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1434802, RefRangeEnd = 1434803, XrefRangeStart = 1434802, XrefRangeEnd = 1434802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(ref FileSystemEntry entry, Interop.NtDll.FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = info;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(directory));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rootDirectory));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(originalRootDirectory));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_Initialize_Internal_Static_Void_byref_FileSystemEntry_ptr_FILE_FULL_DIR_INFORMATION_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06005411 RID: 21521 RVA: 0x001876CC File Offset: 0x001858CC
		// (set) Token: 0x06005412 RID: 21522 RVA: 0x00187708 File Offset: 0x00185908
		public unsafe ReadOnlySpan<char> Directory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_get_Directory_Public_get_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_set_Directory_Private_set_Void_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06005413 RID: 21523 RVA: 0x00187754 File Offset: 0x00185954
		// (set) Token: 0x06005414 RID: 21524 RVA: 0x00187790 File Offset: 0x00185990
		public unsafe ReadOnlySpan<char> RootDirectory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_get_RootDirectory_Public_get_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_set_RootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06005415 RID: 21525 RVA: 0x001877DC File Offset: 0x001859DC
		// (set) Token: 0x06005416 RID: 21526 RVA: 0x00187818 File Offset: 0x00185A18
		public unsafe ReadOnlySpan<char> OriginalRootDirectory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_get_OriginalRootDirectory_Public_get_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 755145, RefRangeEnd = 755149, XrefRangeStart = 755145, XrefRangeEnd = 755149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_set_OriginalRootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06005417 RID: 21527 RVA: 0x00187864 File Offset: 0x00185A64
		public unsafe ReadOnlySpan<char> FileName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1434804, RefRangeEnd = 1434806, XrefRangeStart = 1434803, XrefRangeEnd = 1434804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x001878A0 File Offset: 0x00185AA0
		public unsafe FileAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_get_Attributes_Public_get_FileAttributes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06005419 RID: 21529 RVA: 0x001878E4 File Offset: 0x00185AE4
		public unsafe bool IsDirectory
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1434806, RefRangeEnd = 1434807, XrefRangeStart = 1434806, XrefRangeEnd = 1434806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_get_IsDirectory_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x00187928 File Offset: 0x00185B28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1434820, RefRangeEnd = 1434823, XrefRangeStart = 1434807, XrefRangeEnd = 1434820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemInfo ToFileSystemInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_ToFileSystemInfo_Public_FileSystemInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileSystemInfo>(intPtr3) : null;
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x0018796C File Offset: 0x00185B6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1434843, RefRangeEnd = 1434846, XrefRangeStart = 1434823, XrefRangeEnd = 1434843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToSpecifiedFullPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEntry.NativeMethodInfoPtr_ToSpecifiedFullPath_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x0001DC10 File Offset: 0x0001BE10
		public FileSystemEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x0001DC19 File Offset: 0x0001BE19
		public FileSystemEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr))
		{
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x0600541E RID: 21534 RVA: 0x001879A8 File Offset: 0x00185BA8
		// (set) Token: 0x0600541F RID: 21535 RVA: 0x0001DC2B File Offset: 0x0001BE2B
		public unsafe Interop.NtDll.FILE_FULL_DIR_INFORMATION* _info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEntry.NativeFieldInfoPtr__info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEntry.NativeFieldInfoPtr__info)) = value;
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06005420 RID: 21536 RVA: 0x001879CC File Offset: 0x00185BCC
		// (set) Token: 0x06005421 RID: 21537 RVA: 0x0001DC46 File Offset: 0x0001BE46
		public ReadOnlySpan<char> _Directory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEntry.NativeFieldInfoPtr__Directory_k__BackingField);
				return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEntry.NativeFieldInfoPtr__Directory_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06005422 RID: 21538 RVA: 0x001879FC File Offset: 0x00185BFC
		// (set) Token: 0x06005423 RID: 21539 RVA: 0x0001DC74 File Offset: 0x0001BE74
		public ReadOnlySpan<char> _RootDirectory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEntry.NativeFieldInfoPtr__RootDirectory_k__BackingField);
				return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEntry.NativeFieldInfoPtr__RootDirectory_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x00187A2C File Offset: 0x00185C2C
		// (set) Token: 0x06005425 RID: 21541 RVA: 0x0001DCA2 File Offset: 0x0001BEA2
		public ReadOnlySpan<char> _OriginalRootDirectory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEntry.NativeFieldInfoPtr__OriginalRootDirectory_k__BackingField);
				return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEntry.NativeFieldInfoPtr__OriginalRootDirectory_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040044C1 RID: 17601
		private static readonly IntPtr NativeFieldInfoPtr__info;

		// Token: 0x040044C2 RID: 17602
		private static readonly IntPtr NativeFieldInfoPtr__Directory_k__BackingField;

		// Token: 0x040044C3 RID: 17603
		private static readonly IntPtr NativeFieldInfoPtr__RootDirectory_k__BackingField;

		// Token: 0x040044C4 RID: 17604
		private static readonly IntPtr NativeFieldInfoPtr__OriginalRootDirectory_k__BackingField;

		// Token: 0x040044C5 RID: 17605
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_byref_FileSystemEntry_ptr_FILE_FULL_DIR_INFORMATION_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x040044C6 RID: 17606
		private static readonly IntPtr NativeMethodInfoPtr_get_Directory_Public_get_ReadOnlySpan_1_Char_0;

		// Token: 0x040044C7 RID: 17607
		private static readonly IntPtr NativeMethodInfoPtr_set_Directory_Private_set_Void_ReadOnlySpan_1_Char_0;

		// Token: 0x040044C8 RID: 17608
		private static readonly IntPtr NativeMethodInfoPtr_get_RootDirectory_Public_get_ReadOnlySpan_1_Char_0;

		// Token: 0x040044C9 RID: 17609
		private static readonly IntPtr NativeMethodInfoPtr_set_RootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0;

		// Token: 0x040044CA RID: 17610
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalRootDirectory_Public_get_ReadOnlySpan_1_Char_0;

		// Token: 0x040044CB RID: 17611
		private static readonly IntPtr NativeMethodInfoPtr_set_OriginalRootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0;

		// Token: 0x040044CC RID: 17612
		private static readonly IntPtr NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0;

		// Token: 0x040044CD RID: 17613
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_FileAttributes_0;

		// Token: 0x040044CE RID: 17614
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDirectory_Public_get_Boolean_0;

		// Token: 0x040044CF RID: 17615
		private static readonly IntPtr NativeMethodInfoPtr_ToFileSystemInfo_Public_FileSystemInfo_0;

		// Token: 0x040044D0 RID: 17616
		private static readonly IntPtr NativeMethodInfoPtr_ToSpecifiedFullPath_Public_String_0;
	}
}
