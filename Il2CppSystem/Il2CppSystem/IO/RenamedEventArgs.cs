using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000178 RID: 376
	public class RenamedEventArgs : FileSystemEventArgs
	{
		// Token: 0x06001705 RID: 5893 RVA: 0x000768F4 File Offset: 0x00074AF4
		// Note: this type is marked as 'beforefieldinit'.
		static RenamedEventArgs()
		{
			Il2CppClassPointerStore<RenamedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "RenamedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenamedEventArgs>.NativeClassPtr);
			RenamedEventArgs.NativeFieldInfoPtr__oldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenamedEventArgs>.NativeClassPtr, "_oldName");
			RenamedEventArgs.NativeFieldInfoPtr__oldFullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenamedEventArgs>.NativeClassPtr, "_oldFullPath");
			RenamedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_WatcherChangeTypes_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenamedEventArgs>.NativeClassPtr, 100666962);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00076960 File Offset: 0x00074B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469332, RefRangeEnd = 469333, XrefRangeStart = 469328, XrefRangeEnd = 469332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenamedEventArgs(WatcherChangeTypes changeType, string directory, string name, string oldName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenamedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref changeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenamedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_WatcherChangeTypes_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00009EA0 File Offset: 0x000080A0
		public RenamedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x000769E0 File Offset: 0x00074BE0
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x00009EA9 File Offset: 0x000080A9
		public unsafe string _oldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenamedEventArgs.NativeFieldInfoPtr__oldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenamedEventArgs.NativeFieldInfoPtr__oldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x00076A08 File Offset: 0x00074C08
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x00009EC8 File Offset: 0x000080C8
		public unsafe string _oldFullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenamedEventArgs.NativeFieldInfoPtr__oldFullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenamedEventArgs.NativeFieldInfoPtr__oldFullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeFieldInfoPtr__oldName;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeFieldInfoPtr__oldFullPath;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WatcherChangeTypes_String_String_String_0;
	}
}
