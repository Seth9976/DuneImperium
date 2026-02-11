using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000117 RID: 279
	[StructLayout(2)]
	public struct SearchForGameProgressCallback_t
	{
		// Token: 0x0600100E RID: 4110 RVA: 0x0005EF5C File Offset: 0x0005D15C
		// Note: this type is marked as 'beforefieldinit'.
		static SearchForGameProgressCallback_t()
		{
			Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SearchForGameProgressCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr);
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_LSearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "LSearchID");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "Result");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_LobbyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "LobbyID");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_SteamIDEndedSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "SteamIDEndedSearch");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_SecondsRemainingEstimate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "SecondsRemainingEstimate");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr_CPlayersSearching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "CPlayersSearching");
			SearchForGameProgressCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, "_datasize");
			SearchForGameProgressCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, 100666897);
			SearchForGameProgressCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, 100666898);
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x0005F040 File Offset: 0x0005D240
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950359, XrefRangeEnd = 950363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchForGameProgressCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0005F070 File Offset: 0x0005D270
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchForGameProgressCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00004736 File Offset: 0x00002936
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SearchForGameProgressCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0005F0A0 File Offset: 0x0005D2A0
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00004748 File Offset: 0x00002948
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SearchForGameProgressCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SearchForGameProgressCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeFieldInfoPtr_LSearchID;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeFieldInfoPtr_LobbyID;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDEndedSearch;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeFieldInfoPtr_SecondsRemainingEstimate;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeFieldInfoPtr_CPlayersSearching;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001665 RID: 5733
		[FieldOffset(0)]
		public ulong LSearchID;

		// Token: 0x04001666 RID: 5734
		[FieldOffset(8)]
		public Result Result;

		// Token: 0x04001667 RID: 5735
		[FieldOffset(12)]
		public ulong LobbyID;

		// Token: 0x04001668 RID: 5736
		[FieldOffset(20)]
		public ulong SteamIDEndedSearch;

		// Token: 0x04001669 RID: 5737
		[FieldOffset(28)]
		public int SecondsRemainingEstimate;

		// Token: 0x0400166A RID: 5738
		[FieldOffset(32)]
		public int CPlayersSearching;
	}
}
