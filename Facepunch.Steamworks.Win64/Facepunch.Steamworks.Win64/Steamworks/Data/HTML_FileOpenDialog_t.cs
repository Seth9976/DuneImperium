using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200018D RID: 397
	public sealed class HTML_FileOpenDialog_t : ValueType
	{
		// Token: 0x060013FB RID: 5115 RVA: 0x000691B4 File Offset: 0x000673B4
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_FileOpenDialog_t()
		{
			Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_FileOpenDialog_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr);
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_PchTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "PchTitle");
			HTML_FileOpenDialog_t.NativeFieldInfoPtr_PchInitialFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "PchInitialFile");
			HTML_FileOpenDialog_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, "_datasize");
			HTML_FileOpenDialog_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, 100667263);
			HTML_FileOpenDialog_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr, 100667264);
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x0006925C File Offset: 0x0006745C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950887, XrefRangeEnd = 950891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_FileOpenDialog_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x000692A0 File Offset: 0x000674A0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_FileOpenDialog_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00006530 File Offset: 0x00004730
		public HTML_FileOpenDialog_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00006539 File Offset: 0x00004739
		public HTML_FileOpenDialog_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_FileOpenDialog_t>.NativeClassPtr))
		{
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x000692E4 File Offset: 0x000674E4
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x0000654B File Offset: 0x0000474B
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0006930C File Offset: 0x0006750C
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x00006566 File Offset: 0x00004766
		public unsafe string PchTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_PchTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_PchTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00069334 File Offset: 0x00067534
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x00006585 File Offset: 0x00004785
		public unsafe string PchInitialFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_PchInitialFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_FileOpenDialog_t.NativeFieldInfoPtr_PchInitialFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0006935C File Offset: 0x0006755C
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x000065A4 File Offset: 0x000047A4
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_FileOpenDialog_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_FileOpenDialog_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeFieldInfoPtr_PchTitle;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeFieldInfoPtr_PchInitialFile;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
