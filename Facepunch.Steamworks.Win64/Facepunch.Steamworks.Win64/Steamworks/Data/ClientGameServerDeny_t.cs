using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000E4 RID: 228
	[StructLayout(2)]
	public struct ClientGameServerDeny_t
	{
		// Token: 0x06000EBA RID: 3770 RVA: 0x0005B2F0 File Offset: 0x000594F0
		// Note: this type is marked as 'beforefieldinit'.
		static ClientGameServerDeny_t()
		{
			Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ClientGameServerDeny_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr);
			ClientGameServerDeny_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "AppID");
			ClientGameServerDeny_t.NativeFieldInfoPtr_GameServerIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "GameServerIP");
			ClientGameServerDeny_t.NativeFieldInfoPtr_GameServerPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "GameServerPort");
			ClientGameServerDeny_t.NativeFieldInfoPtr_Secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "Secure");
			ClientGameServerDeny_t.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "Reason");
			ClientGameServerDeny_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "_datasize");
			ClientGameServerDeny_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, 100666738);
			ClientGameServerDeny_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, 100666739);
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0005B3C0 File Offset: 0x000595C0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950125, XrefRangeEnd = 950129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientGameServerDeny_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0005B3F0 File Offset: 0x000595F0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientGameServerDeny_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00003F5B File Offset: 0x0000215B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0005B420 File Offset: 0x00059620
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x00003F6D File Offset: 0x0000216D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClientGameServerDeny_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientGameServerDeny_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeFieldInfoPtr_GameServerIP;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeFieldInfoPtr_GameServerPort;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeFieldInfoPtr_Secure;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeFieldInfoPtr_Reason;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040014DE RID: 5342
		[FieldOffset(0)]
		public uint AppID;

		// Token: 0x040014DF RID: 5343
		[FieldOffset(4)]
		public uint GameServerIP;

		// Token: 0x040014E0 RID: 5344
		[FieldOffset(8)]
		public ushort GameServerPort;

		// Token: 0x040014E1 RID: 5345
		[FieldOffset(10)]
		public ushort Secure;

		// Token: 0x040014E2 RID: 5346
		[FieldOffset(12)]
		public uint Reason;
	}
}
