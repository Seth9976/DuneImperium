using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200012B RID: 299
	[StructLayout(2)]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		// Token: 0x060010AC RID: 4268 RVA: 0x00060A3C File Offset: 0x0005EC3C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUpdatePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageUpdatePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "Result");
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "PublishedFileId");
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_UserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "UserNeedsToAcceptWorkshopLegalAgreement");
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageUpdatePublishedFileResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, 100666959);
			RemoteStorageUpdatePublishedFileResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, 100666960);
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00060AE4 File Offset: 0x0005ECE4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950449, XrefRangeEnd = 950453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageUpdatePublishedFileResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x00060B14 File Offset: 0x0005ED14
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageUpdatePublishedFileResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00004B9E File Offset: 0x00002D9E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x00060B44 File Offset: 0x0005ED44
		// (set) Token: 0x060010B1 RID: 4273 RVA: 0x00004BB0 File Offset: 0x00002DB0
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_UserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400170C RID: 5900
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x0400170D RID: 5901
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x0400170E RID: 5902
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool UserNeedsToAcceptWorkshopLegalAgreement;
	}
}
