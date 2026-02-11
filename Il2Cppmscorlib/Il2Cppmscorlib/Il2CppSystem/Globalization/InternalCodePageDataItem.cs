using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000492 RID: 1170
	public sealed class InternalCodePageDataItem : ValueType
	{
		// Token: 0x06004848 RID: 18504 RVA: 0x00150E98 File Offset: 0x0014F098
		// Note: this type is marked as 'beforefieldinit'.
		static InternalCodePageDataItem()
		{
			Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "InternalCodePageDataItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr);
			InternalCodePageDataItem.NativeFieldInfoPtr_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "codePage");
			InternalCodePageDataItem.NativeFieldInfoPtr_uiFamilyCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "uiFamilyCodePage");
			InternalCodePageDataItem.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "flags");
			InternalCodePageDataItem.NativeFieldInfoPtr_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "Names");
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x0001A457 File Offset: 0x00018657
		public InternalCodePageDataItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x0001A460 File Offset: 0x00018660
		public InternalCodePageDataItem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr))
		{
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x00150F18 File Offset: 0x0014F118
		// (set) Token: 0x0600484C RID: 18508 RVA: 0x0001A472 File Offset: 0x00018672
		public unsafe ushort codePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_codePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_codePage)) = value;
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x0600484D RID: 18509 RVA: 0x00150F40 File Offset: 0x0014F140
		// (set) Token: 0x0600484E RID: 18510 RVA: 0x0001A48D File Offset: 0x0001868D
		public unsafe ushort uiFamilyCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_uiFamilyCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_uiFamilyCodePage)) = value;
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x00150F68 File Offset: 0x0014F168
		// (set) Token: 0x06004850 RID: 18512 RVA: 0x0001A4A8 File Offset: 0x000186A8
		public unsafe uint flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x00150F90 File Offset: 0x0014F190
		// (set) Token: 0x06004852 RID: 18514 RVA: 0x0001A4C3 File Offset: 0x000186C3
		public unsafe string Names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_Names);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_Names), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003B7E RID: 15230
		private static readonly IntPtr NativeFieldInfoPtr_codePage;

		// Token: 0x04003B7F RID: 15231
		private static readonly IntPtr NativeFieldInfoPtr_uiFamilyCodePage;

		// Token: 0x04003B80 RID: 15232
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04003B81 RID: 15233
		private static readonly IntPtr NativeFieldInfoPtr_Names;
	}
}
