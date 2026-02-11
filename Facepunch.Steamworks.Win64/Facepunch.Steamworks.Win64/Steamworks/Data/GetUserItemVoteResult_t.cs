using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000171 RID: 369
	[StructLayout(2)]
	public struct GetUserItemVoteResult_t
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x00066820 File Offset: 0x00064A20
		// Note: this type is marked as 'beforefieldinit'.
		static GetUserItemVoteResult_t()
		{
			Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GetUserItemVoteResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr);
			GetUserItemVoteResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "PublishedFileId");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "Result");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_VotedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "VotedUp");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_VotedDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "VotedDown");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_VoteSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "VoteSkipped");
			GetUserItemVoteResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "_datasize");
			GetUserItemVoteResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, 100667179);
			GetUserItemVoteResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, 100667180);
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000668F0 File Offset: 0x00064AF0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950771, XrefRangeEnd = 950775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetUserItemVoteResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00066920 File Offset: 0x00064B20
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetUserItemVoteResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00005C5B File Offset: 0x00003E5B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00066950 File Offset: 0x00064B50
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x00005C6D File Offset: 0x00003E6D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetUserItemVoteResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetUserItemVoteResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeFieldInfoPtr_VotedUp;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeFieldInfoPtr_VotedDown;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeFieldInfoPtr_VoteSkipped;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001913 RID: 6419
		[FieldOffset(0)]
		public PublishedFileId PublishedFileId;

		// Token: 0x04001914 RID: 6420
		[FieldOffset(8)]
		public Result Result;

		// Token: 0x04001915 RID: 6421
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool VotedUp;

		// Token: 0x04001916 RID: 6422
		[FieldOffset(13)]
		[MarshalAs(4)]
		public bool VotedDown;

		// Token: 0x04001917 RID: 6423
		[FieldOffset(14)]
		[MarshalAs(4)]
		public bool VoteSkipped;
	}
}
