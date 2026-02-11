using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200012F RID: 303
	[StructLayout(2)]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		// Token: 0x06001111 RID: 4369 RVA: 0x000618A8 File Offset: 0x0005FAA8
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageGetPublishedItemVoteDetailsResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageGetPublishedItemVoteDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr);
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "Result");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "PublishedFileId");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_VotesFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "VotesFor");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_VotesAgainst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "VotesAgainst");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_Reports = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "Reports");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_FScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "FScore");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, 100666977);
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, 100666978);
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x0006198C File Offset: 0x0005FB8C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950489, XrefRangeEnd = 950493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x000619BC File Offset: 0x0005FBBC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00004FEF File Offset: 0x000031EF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x000619EC File Offset: 0x0005FBEC
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x00005001 File Offset: 0x00003201
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeFieldInfoPtr_VotesFor;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeFieldInfoPtr_VotesAgainst;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeFieldInfoPtr_Reports;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeFieldInfoPtr_FScore;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001749 RID: 5961
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x0400174A RID: 5962
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x0400174B RID: 5963
		[FieldOffset(16)]
		public int VotesFor;

		// Token: 0x0400174C RID: 5964
		[FieldOffset(20)]
		public int VotesAgainst;

		// Token: 0x0400174D RID: 5965
		[FieldOffset(24)]
		public int Reports;

		// Token: 0x0400174E RID: 5966
		[FieldOffset(28)]
		public float FScore;
	}
}
