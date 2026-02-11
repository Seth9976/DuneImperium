using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000134 RID: 308
	[StructLayout(2)]
	public struct RemoteStorageUserVoteDetails_t
	{
		// Token: 0x0600112F RID: 4399 RVA: 0x00061E48 File Offset: 0x00060048
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUserVoteDetails_t()
		{
			Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageUserVoteDetails_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr);
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "Result");
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "PublishedFileId");
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_Vote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "Vote");
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "_datasize");
			RemoteStorageUserVoteDetails_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, 100666992);
			RemoteStorageUserVoteDetails_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, 100666993);
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x00061EF0 File Offset: 0x000600F0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950509, XrefRangeEnd = 950513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageUserVoteDetails_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x00061F20 File Offset: 0x00060120
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageUserVoteDetails_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0000508F File Offset: 0x0000328F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x00061F50 File Offset: 0x00060150
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x000050A1 File Offset: 0x000032A1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeFieldInfoPtr_Vote;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001771 RID: 6001
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001772 RID: 6002
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x04001773 RID: 6003
		[FieldOffset(16)]
		public WorkshopVote Vote;
	}
}
