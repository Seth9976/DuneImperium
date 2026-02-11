using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000170 RID: 368
	[StructLayout(2)]
	public struct SetUserItemVoteResult_t
	{
		// Token: 0x060012E9 RID: 4841 RVA: 0x000666FC File Offset: 0x000648FC
		// Note: this type is marked as 'beforefieldinit'.
		static SetUserItemVoteResult_t()
		{
			Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SetUserItemVoteResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr);
			SetUserItemVoteResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "PublishedFileId");
			SetUserItemVoteResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "Result");
			SetUserItemVoteResult_t.NativeFieldInfoPtr_VoteUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "VoteUp");
			SetUserItemVoteResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, "_datasize");
			SetUserItemVoteResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, 100667176);
			SetUserItemVoteResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, 100667177);
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x000667A4 File Offset: 0x000649A4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950767, XrefRangeEnd = 950771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetUserItemVoteResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x000667D4 File Offset: 0x000649D4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetUserItemVoteResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00005C3B File Offset: 0x00003E3B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetUserItemVoteResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00066804 File Offset: 0x00064A04
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x00005C4D File Offset: 0x00003E4D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SetUserItemVoteResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetUserItemVoteResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeFieldInfoPtr_VoteUp;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001908 RID: 6408
		[FieldOffset(0)]
		public PublishedFileId PublishedFileId;

		// Token: 0x04001909 RID: 6409
		[FieldOffset(8)]
		public Result Result;

		// Token: 0x0400190A RID: 6410
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool VoteUp;
	}
}
