using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001A2 RID: 418
	public sealed class SteamNetConnectionStatusChangedCallback_t : ValueType
	{
		// Token: 0x060014AF RID: 5295 RVA: 0x0006AD6C File Offset: 0x00068F6C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetConnectionStatusChangedCallback_t()
		{
			Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamNetConnectionStatusChangedCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr);
			SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_Conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr, "Conn");
			SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_Nfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr, "Nfo");
			SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_OldState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr, "OldState");
			SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr, "_datasize");
			SteamNetConnectionStatusChangedCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr, 100667328);
			SteamNetConnectionStatusChangedCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr, 100667329);
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0006AE14 File Offset: 0x00069014
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950980, XrefRangeEnd = 950984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetConnectionStatusChangedCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x0006AE58 File Offset: 0x00069058
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetConnectionStatusChangedCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00006A9D File Offset: 0x00004C9D
		public SteamNetConnectionStatusChangedCallback_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00006AA6 File Offset: 0x00004CA6
		public SteamNetConnectionStatusChangedCallback_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr))
		{
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0006AE9C File Offset: 0x0006909C
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x00006AB8 File Offset: 0x00004CB8
		public unsafe Connection Conn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_Conn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_Conn)) = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0006AEC4 File Offset: 0x000690C4
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x00006AD3 File Offset: 0x00004CD3
		public ConnectionInfo Nfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_Nfo);
				return new ConnectionInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_Nfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0006AEF4 File Offset: 0x000690F4
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x00006B01 File Offset: 0x00004D01
		public unsafe ConnectionState OldState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_OldState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_OldState)) = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0006AF1C File Offset: 0x0006911C
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x00006B1C File Offset: 0x00004D1C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeFieldInfoPtr_Conn;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeFieldInfoPtr_Nfo;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeFieldInfoPtr_OldState;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
