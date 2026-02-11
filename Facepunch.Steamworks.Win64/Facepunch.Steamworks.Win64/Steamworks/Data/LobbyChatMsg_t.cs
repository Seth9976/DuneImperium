using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000110 RID: 272
	[StructLayout(2)]
	public struct LobbyChatMsg_t
	{
		// Token: 0x06000FE4 RID: 4068 RVA: 0x0005E7B0 File Offset: 0x0005C9B0
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyChatMsg_t()
		{
			Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LobbyChatMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr);
			LobbyChatMsg_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "SteamIDLobby");
			LobbyChatMsg_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "SteamIDUser");
			LobbyChatMsg_t.NativeFieldInfoPtr_ChatEntryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "ChatEntryType");
			LobbyChatMsg_t.NativeFieldInfoPtr_ChatID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "ChatID");
			LobbyChatMsg_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "_datasize");
			LobbyChatMsg_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, 100666876);
			LobbyChatMsg_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, 100666877);
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0005E86C File Offset: 0x0005CA6C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950331, XrefRangeEnd = 950335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatMsg_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0005E89C File Offset: 0x0005CA9C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyChatMsg_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00004656 File Offset: 0x00002856
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0005E8CC File Offset: 0x0005CACC
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x00004668 File Offset: 0x00002868
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyChatMsg_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyChatMsg_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeFieldInfoPtr_ChatEntryType;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeFieldInfoPtr_ChatID;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400162C RID: 5676
		[FieldOffset(0)]
		public ulong SteamIDLobby;

		// Token: 0x0400162D RID: 5677
		[FieldOffset(8)]
		public ulong SteamIDUser;

		// Token: 0x0400162E RID: 5678
		[FieldOffset(16)]
		public byte ChatEntryType;

		// Token: 0x0400162F RID: 5679
		[FieldOffset(20)]
		public uint ChatID;
	}
}
