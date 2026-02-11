using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000113 RID: 275
	[StructLayout(2)]
	public struct LobbyKicked_t
	{
		// Token: 0x06000FF6 RID: 4086 RVA: 0x0005EB1C File Offset: 0x0005CD1C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyKicked_t()
		{
			Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LobbyKicked_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr);
			LobbyKicked_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "SteamIDLobby");
			LobbyKicked_t.NativeFieldInfoPtr_SteamIDAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "SteamIDAdmin");
			LobbyKicked_t.NativeFieldInfoPtr_KickedDueToDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "KickedDueToDisconnect");
			LobbyKicked_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "_datasize");
			LobbyKicked_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, 100666885);
			LobbyKicked_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, 100666886);
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x0005EBC4 File Offset: 0x0005CDC4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950343, XrefRangeEnd = 950347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyKicked_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0005EBF4 File Offset: 0x0005CDF4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyKicked_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000046B6 File Offset: 0x000028B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x0005EC24 File Offset: 0x0005CE24
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x000046C8 File Offset: 0x000028C8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyKicked_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyKicked_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDAdmin;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeFieldInfoPtr_KickedDueToDisconnect;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001646 RID: 5702
		[FieldOffset(0)]
		public ulong SteamIDLobby;

		// Token: 0x04001647 RID: 5703
		[FieldOffset(8)]
		public ulong SteamIDAdmin;

		// Token: 0x04001648 RID: 5704
		[FieldOffset(16)]
		public byte KickedDueToDisconnect;
	}
}
