using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001A1 RID: 417
	public sealed class SteamNetworkingMessagesSessionFailed_t : ValueType
	{
		// Token: 0x060014A6 RID: 5286 RVA: 0x0006AC18 File Offset: 0x00068E18
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingMessagesSessionFailed_t()
		{
			Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamNetworkingMessagesSessionFailed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr);
			SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr_Nfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr, "Nfo");
			SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr, "_datasize");
			SteamNetworkingMessagesSessionFailed_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr, 100667325);
			SteamNetworkingMessagesSessionFailed_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr, 100667326);
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0006AC98 File Offset: 0x00068E98
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950976, XrefRangeEnd = 950980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessagesSessionFailed_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0006ACDC File Offset: 0x00068EDC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingMessagesSessionFailed_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00006A46 File Offset: 0x00004C46
		public SteamNetworkingMessagesSessionFailed_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00006A4F File Offset: 0x00004C4F
		public SteamNetworkingMessagesSessionFailed_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr))
		{
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0006AD20 File Offset: 0x00068F20
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x00006A61 File Offset: 0x00004C61
		public ConnectionInfo Nfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr_Nfo);
				return new ConnectionInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr_Nfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0006AD50 File Offset: 0x00068F50
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x00006A8F File Offset: 0x00004C8F
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeFieldInfoPtr_Nfo;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
