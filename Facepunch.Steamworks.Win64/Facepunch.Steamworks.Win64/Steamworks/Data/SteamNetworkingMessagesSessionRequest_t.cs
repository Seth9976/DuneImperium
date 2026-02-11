using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001A0 RID: 416
	[StructLayout(2)]
	public struct SteamNetworkingMessagesSessionRequest_t
	{
		// Token: 0x060014A0 RID: 5280 RVA: 0x0006AB1C File Offset: 0x00068D1C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingMessagesSessionRequest_t()
		{
			Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamNetworkingMessagesSessionRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr);
			SteamNetworkingMessagesSessionRequest_t.NativeFieldInfoPtr_DentityRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr, "DentityRemote");
			SteamNetworkingMessagesSessionRequest_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr, "_datasize");
			SteamNetworkingMessagesSessionRequest_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr, 100667322);
			SteamNetworkingMessagesSessionRequest_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr, 100667323);
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0006AB9C File Offset: 0x00068D9C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950972, XrefRangeEnd = 950976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessagesSessionRequest_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0006ABCC File Offset: 0x00068DCC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessagesSessionRequest_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00006A26 File Offset: 0x00004C26
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0006ABFC File Offset: 0x00068DFC
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x00006A38 File Offset: 0x00004C38
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingMessagesSessionRequest_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingMessagesSessionRequest_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeFieldInfoPtr_DentityRemote;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A6E RID: 6766
		[FieldOffset(0)]
		public NetIdentity DentityRemote;
	}
}
