using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000118 RID: 280
	[StructLayout(2)]
	public struct SearchForGameResultCallback_t
	{
		// Token: 0x06001014 RID: 4116 RVA: 0x0005F0BC File Offset: 0x0005D2BC
		// Note: this type is marked as 'beforefieldinit'.
		static SearchForGameResultCallback_t()
		{
			Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SearchForGameResultCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr);
			SearchForGameResultCallback_t.NativeFieldInfoPtr_LSearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "LSearchID");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "Result");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_CountPlayersInGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "CountPlayersInGame");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_CountAcceptedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "CountAcceptedGame");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_SteamIDHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "SteamIDHost");
			SearchForGameResultCallback_t.NativeFieldInfoPtr_FinalCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "FinalCallback");
			SearchForGameResultCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, "_datasize");
			SearchForGameResultCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, 100666900);
			SearchForGameResultCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, 100666901);
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950363, XrefRangeEnd = 950367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchForGameResultCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0005F1D0 File Offset: 0x0005D3D0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SearchForGameResultCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00004756 File Offset: 0x00002956
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SearchForGameResultCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0005F200 File Offset: 0x0005D400
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x00004768 File Offset: 0x00002968
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SearchForGameResultCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SearchForGameResultCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeFieldInfoPtr_LSearchID;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeFieldInfoPtr_CountPlayersInGame;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeFieldInfoPtr_CountAcceptedGame;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDHost;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeFieldInfoPtr_FinalCallback;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001674 RID: 5748
		[FieldOffset(0)]
		public ulong LSearchID;

		// Token: 0x04001675 RID: 5749
		[FieldOffset(8)]
		public Result Result;

		// Token: 0x04001676 RID: 5750
		[FieldOffset(12)]
		public int CountPlayersInGame;

		// Token: 0x04001677 RID: 5751
		[FieldOffset(16)]
		public int CountAcceptedGame;

		// Token: 0x04001678 RID: 5752
		[FieldOffset(20)]
		public ulong SteamIDHost;

		// Token: 0x04001679 RID: 5753
		[FieldOffset(28)]
		[MarshalAs(4)]
		public bool FinalCallback;
	}
}
