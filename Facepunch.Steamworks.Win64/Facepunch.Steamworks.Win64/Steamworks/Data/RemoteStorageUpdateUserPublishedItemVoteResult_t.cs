using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000133 RID: 307
	[StructLayout(2)]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		// Token: 0x06001129 RID: 4393 RVA: 0x00061D38 File Offset: 0x0005FF38
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUpdateUserPublishedItemVoteResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageUpdateUserPublishedItemVoteResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr);
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, "Result");
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, "PublishedFileId");
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, 100666989);
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, 100666990);
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00061DCC File Offset: 0x0005FFCC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950505, XrefRangeEnd = 950509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x00061DFC File Offset: 0x0005FFFC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0000506F File Offset: 0x0000326F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00061E2C File Offset: 0x0006002C
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x00005081 File Offset: 0x00003281
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001769 RID: 5993
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x0400176A RID: 5994
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;
	}
}
