using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001A3 RID: 419
	public sealed class SteamNetAuthenticationStatus_t : ValueType
	{
		// Token: 0x060014BC RID: 5308 RVA: 0x0006AF38 File Offset: 0x00069138
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetAuthenticationStatus_t()
		{
			Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamNetAuthenticationStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr);
			SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_Avail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, "Avail");
			SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_DebugMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, "DebugMsg");
			SteamNetAuthenticationStatus_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, "_datasize");
			SteamNetAuthenticationStatus_t.NativeMethodInfoPtr_DebugMsgUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, 100667331);
			SteamNetAuthenticationStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, 100667332);
			SteamNetAuthenticationStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr, 100667333);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0006AFE0 File Offset: 0x000691E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950984, XrefRangeEnd = 950988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DebugMsgUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetAuthenticationStatus_t.NativeMethodInfoPtr_DebugMsgUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x0006B01C File Offset: 0x0006921C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950988, XrefRangeEnd = 950992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetAuthenticationStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x0006B060 File Offset: 0x00069260
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetAuthenticationStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00006B2A File Offset: 0x00004D2A
		public SteamNetAuthenticationStatus_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00006B33 File Offset: 0x00004D33
		public SteamNetAuthenticationStatus_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetAuthenticationStatus_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0006B0A4 File Offset: 0x000692A4
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x00006B45 File Offset: 0x00004D45
		public unsafe SteamNetworkingAvailability Avail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_Avail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_Avail)) = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0006B0CC File Offset: 0x000692CC
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x00006B60 File Offset: 0x00004D60
		public unsafe Il2CppStructArray<byte> DebugMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_DebugMsg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr_DebugMsg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0006B0FC File Offset: 0x000692FC
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x00006B7F File Offset: 0x00004D7F
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetAuthenticationStatus_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeFieldInfoPtr_Avail;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeFieldInfoPtr_DebugMsg;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr_DebugMsgUTF8_Internal_String_0;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
