using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200016E RID: 366
	[StructLayout(2)]
	public struct DownloadItemResult_t
	{
		// Token: 0x060012DD RID: 4829 RVA: 0x000664B4 File Offset: 0x000646B4
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadItemResult_t()
		{
			Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "DownloadItemResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr);
			DownloadItemResult_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "AppID");
			DownloadItemResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "PublishedFileId");
			DownloadItemResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "Result");
			DownloadItemResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "_datasize");
			DownloadItemResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, 100667170);
			DownloadItemResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, 100667171);
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x0006655C File Offset: 0x0006475C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950759, XrefRangeEnd = 950763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadItemResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x0006658C File Offset: 0x0006478C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadItemResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00005BFB File Offset: 0x00003DFB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000665BC File Offset: 0x000647BC
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x00005C0D File Offset: 0x00003E0D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DownloadItemResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DownloadItemResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040018F6 RID: 6390
		[FieldOffset(0)]
		public AppId AppID;

		// Token: 0x040018F7 RID: 6391
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x040018F8 RID: 6392
		[FieldOffset(16)]
		public Result Result;
	}
}
