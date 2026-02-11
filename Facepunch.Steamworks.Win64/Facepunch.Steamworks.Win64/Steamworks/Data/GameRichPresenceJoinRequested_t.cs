using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000F6 RID: 246
	public sealed class GameRichPresenceJoinRequested_t : ValueType
	{
		// Token: 0x06000F35 RID: 3893 RVA: 0x0005C950 File Offset: 0x0005AB50
		// Note: this type is marked as 'beforefieldinit'.
		static GameRichPresenceJoinRequested_t()
		{
			Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GameRichPresenceJoinRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr);
			GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_SteamIDFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, "SteamIDFriend");
			GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_Connect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, "Connect");
			GameRichPresenceJoinRequested_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, "_datasize");
			GameRichPresenceJoinRequested_t.NativeMethodInfoPtr_ConnectUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, 100666796);
			GameRichPresenceJoinRequested_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, 100666797);
			GameRichPresenceJoinRequested_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr, 100666798);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0005C9F8 File Offset: 0x0005ABF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950221, RefRangeEnd = 950222, XrefRangeStart = 950217, XrefRangeEnd = 950221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ConnectUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameRichPresenceJoinRequested_t.NativeMethodInfoPtr_ConnectUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x0005CA34 File Offset: 0x0005AC34
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950222, XrefRangeEnd = 950226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameRichPresenceJoinRequested_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x0005CA78 File Offset: 0x0005AC78
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameRichPresenceJoinRequested_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00004232 File Offset: 0x00002432
		public GameRichPresenceJoinRequested_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0000423B File Offset: 0x0000243B
		public GameRichPresenceJoinRequested_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameRichPresenceJoinRequested_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0005CABC File Offset: 0x0005ACBC
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x0000424D File Offset: 0x0000244D
		public unsafe ulong SteamIDFriend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_SteamIDFriend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_SteamIDFriend)) = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x0005CAE4 File Offset: 0x0005ACE4
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00004268 File Offset: 0x00002468
		public unsafe Il2CppStructArray<byte> Connect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_Connect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr_Connect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x0005CB14 File Offset: 0x0005AD14
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00004287 File Offset: 0x00002487
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameRichPresenceJoinRequested_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDFriend;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeFieldInfoPtr_Connect;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeMethodInfoPtr_ConnectUTF8_Internal_String_0;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
