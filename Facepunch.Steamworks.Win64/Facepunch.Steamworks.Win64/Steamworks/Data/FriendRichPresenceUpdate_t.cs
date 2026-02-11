using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000F5 RID: 245
	[StructLayout(2)]
	public struct FriendRichPresenceUpdate_t
	{
		// Token: 0x06000F2F RID: 3887 RVA: 0x0005C840 File Offset: 0x0005AA40
		// Note: this type is marked as 'beforefieldinit'.
		static FriendRichPresenceUpdate_t()
		{
			Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FriendRichPresenceUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr);
			FriendRichPresenceUpdate_t.NativeFieldInfoPtr_SteamIDFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, "SteamIDFriend");
			FriendRichPresenceUpdate_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, "AppID");
			FriendRichPresenceUpdate_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, "_datasize");
			FriendRichPresenceUpdate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, 100666793);
			FriendRichPresenceUpdate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, 100666794);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x0005C8D4 File Offset: 0x0005AAD4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950213, XrefRangeEnd = 950217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendRichPresenceUpdate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x0005C904 File Offset: 0x0005AB04
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendRichPresenceUpdate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00004212 File Offset: 0x00002412
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0005C934 File Offset: 0x0005AB34
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x00004224 File Offset: 0x00002424
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendRichPresenceUpdate_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendRichPresenceUpdate_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDFriend;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001566 RID: 5478
		[FieldOffset(0)]
		public ulong SteamIDFriend;

		// Token: 0x04001567 RID: 5479
		[FieldOffset(8)]
		public AppId AppID;
	}
}
