using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000175 RID: 373
	public class FileSystemEventArgs : EventArgs
	{
		// Token: 0x060016EE RID: 5870 RVA: 0x00076544 File Offset: 0x00074744
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEventArgs()
		{
			Il2CppClassPointerStore<FileSystemEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "FileSystemEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEventArgs>.NativeClassPtr);
			FileSystemEventArgs.NativeFieldInfoPtr__changeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEventArgs>.NativeClassPtr, "_changeType");
			FileSystemEventArgs.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEventArgs>.NativeClassPtr, "_name");
			FileSystemEventArgs.NativeFieldInfoPtr__fullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEventArgs>.NativeClassPtr, "_fullPath");
			FileSystemEventArgs.NativeMethodInfoPtr__ctor_Public_Void_WatcherChangeTypes_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEventArgs>.NativeClassPtr, 100666955);
			FileSystemEventArgs.NativeMethodInfoPtr_Combine_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEventArgs>.NativeClassPtr, 100666956);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x000765D8 File Offset: 0x000747D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 469275, RefRangeEnd = 469279, XrefRangeStart = 469264, XrefRangeEnd = 469275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemEventArgs(WatcherChangeTypes changeType, string directory, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref changeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEventArgs.NativeMethodInfoPtr__ctor_Public_Void_WatcherChangeTypes_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00076644 File Offset: 0x00074844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 469298, RefRangeEnd = 469300, XrefRangeStart = 469279, XrefRangeEnd = 469298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Combine(string directoryPath, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEventArgs.NativeMethodInfoPtr_Combine_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00009DF7 File Offset: 0x00007FF7
		public FileSystemEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00076694 File Offset: 0x00074894
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x00009E00 File Offset: 0x00008000
		public unsafe WatcherChangeTypes _changeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEventArgs.NativeFieldInfoPtr__changeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEventArgs.NativeFieldInfoPtr__changeType)) = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x000766BC File Offset: 0x000748BC
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x00009E1B File Offset: 0x0000801B
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEventArgs.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEventArgs.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x000766E4 File Offset: 0x000748E4
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x00009E3A File Offset: 0x0000803A
		public unsafe string _fullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEventArgs.NativeFieldInfoPtr__fullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEventArgs.NativeFieldInfoPtr__fullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeFieldInfoPtr__changeType;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeFieldInfoPtr__fullPath;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WatcherChangeTypes_String_String_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Internal_Static_String_String_String_0;
	}
}
