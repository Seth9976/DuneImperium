using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001FB RID: 507
	public sealed class FileDetails : ValueType
	{
		// Token: 0x06001962 RID: 6498 RVA: 0x0007B1B0 File Offset: 0x000793B0
		// Note: this type is marked as 'beforefieldinit'.
		static FileDetails()
		{
			Il2CppClassPointerStore<FileDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FileDetails");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileDetails>.NativeClassPtr);
			FileDetails.NativeFieldInfoPtr_SizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetails>.NativeClassPtr, "SizeInBytes");
			FileDetails.NativeFieldInfoPtr_Sha1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetails>.NativeClassPtr, "Sha1");
			FileDetails.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDetails>.NativeClassPtr, "Flags");
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000083A7 File Offset: 0x000065A7
		public FileDetails(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000083B0 File Offset: 0x000065B0
		public FileDetails()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileDetails>.NativeClassPtr))
		{
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x0007B21C File Offset: 0x0007941C
		// (set) Token: 0x06001966 RID: 6502 RVA: 0x000083C2 File Offset: 0x000065C2
		public unsafe ulong SizeInBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetails.NativeFieldInfoPtr_SizeInBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetails.NativeFieldInfoPtr_SizeInBytes)) = value;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x0007B244 File Offset: 0x00079444
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x000083DD File Offset: 0x000065DD
		public unsafe string Sha1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetails.NativeFieldInfoPtr_Sha1);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetails.NativeFieldInfoPtr_Sha1), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x0007B26C File Offset: 0x0007946C
		// (set) Token: 0x0600196A RID: 6506 RVA: 0x000083FC File Offset: 0x000065FC
		public unsafe uint Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetails.NativeFieldInfoPtr_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDetails.NativeFieldInfoPtr_Flags)) = value;
			}
		}

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeFieldInfoPtr_SizeInBytes;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeFieldInfoPtr_Sha1;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeFieldInfoPtr_Flags;
	}
}
