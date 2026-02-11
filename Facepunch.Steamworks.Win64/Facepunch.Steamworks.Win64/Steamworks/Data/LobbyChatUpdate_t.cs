using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200010F RID: 271
	[StructLayout(2)]
	public struct LobbyChatUpdate_t
	{
		// Token: 0x06000FDE RID: 4062 RVA: 0x0005E678 File Offset: 0x0005C878
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyChatUpdate_t()
		{
			Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LobbyChatUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr);
			LobbyChatUpdate_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "SteamIDLobby");
			LobbyChatUpdate_t.NativeFieldInfoPtr_SteamIDUserChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "SteamIDUserChanged");
			LobbyChatUpdate_t.NativeFieldInfoPtr_SteamIDMakingChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "SteamIDMakingChange");
			LobbyChatUpdate_t.NativeFieldInfoPtr_GfChatMemberStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "GfChatMemberStateChange");
			LobbyChatUpdate_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "_datasize");
			LobbyChatUpdate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, 100666873);
			LobbyChatUpdate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, 100666874);
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0005E734 File Offset: 0x0005C934
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950327, XrefRangeEnd = 950331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatUpdate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0005E764 File Offset: 0x0005C964
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatUpdate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00004636 File Offset: 0x00002836
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0005E794 File Offset: 0x0005C994
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00004648 File Offset: 0x00002848
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyChatUpdate_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyChatUpdate_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUserChanged;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDMakingChange;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeFieldInfoPtr_GfChatMemberStateChange;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001621 RID: 5665
		[FieldOffset(0)]
		public ulong SteamIDLobby;

		// Token: 0x04001622 RID: 5666
		[FieldOffset(8)]
		public ulong SteamIDUserChanged;

		// Token: 0x04001623 RID: 5667
		[FieldOffset(16)]
		public ulong SteamIDMakingChange;

		// Token: 0x04001624 RID: 5668
		[FieldOffset(24)]
		public uint GfChatMemberStateChange;
	}
}
