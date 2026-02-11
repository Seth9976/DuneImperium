using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.Archive
{
	// Token: 0x02000030 RID: 48
	public sealed class ArchiveFileInfo : ValueType
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0001A9B4 File Offset: 0x00018BB4
		// Note: this type is marked as 'beforefieldinit'.
		static ArchiveFileInfo()
		{
			Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", "ArchiveFileInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr);
			ArchiveFileInfo.NativeFieldInfoPtr_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr, "Filename");
			ArchiveFileInfo.NativeFieldInfoPtr_FileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr, "FileSize");
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002E95 File Offset: 0x00001095
		public ArchiveFileInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002E9E File Offset: 0x0000109E
		public ArchiveFileInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0001AA0C File Offset: 0x00018C0C
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002EB0 File Offset: 0x000010B0
		public unsafe string Filename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_Filename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_Filename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0001AA34 File Offset: 0x00018C34
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002ECF File Offset: 0x000010CF
		public unsafe ulong FileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_FileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_FileSize)) = value;
			}
		}

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_Filename;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_FileSize;
	}
}
