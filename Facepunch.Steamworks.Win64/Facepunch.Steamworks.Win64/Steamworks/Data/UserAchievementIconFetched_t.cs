using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000145 RID: 325
	public sealed class UserAchievementIconFetched_t : ValueType
	{
		// Token: 0x060011B7 RID: 4535 RVA: 0x000634D8 File Offset: 0x000616D8
		// Note: this type is marked as 'beforefieldinit'.
		static UserAchievementIconFetched_t()
		{
			Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "UserAchievementIconFetched_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr);
			UserAchievementIconFetched_t.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "GameID");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_AchievementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "AchievementName");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_Achieved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "Achieved");
			UserAchievementIconFetched_t.NativeFieldInfoPtr_IconHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "IconHandle");
			UserAchievementIconFetched_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, "_datasize");
			UserAchievementIconFetched_t.NativeMethodInfoPtr_AchievementNameUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, 100667044);
			UserAchievementIconFetched_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, 100667045);
			UserAchievementIconFetched_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr, 100667046);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x000635A8 File Offset: 0x000617A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950586, RefRangeEnd = 950587, XrefRangeStart = 950582, XrefRangeEnd = 950586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AchievementNameUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserAchievementIconFetched_t.NativeMethodInfoPtr_AchievementNameUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000635E4 File Offset: 0x000617E4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950587, XrefRangeEnd = 950591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserAchievementIconFetched_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x00063628 File Offset: 0x00061828
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserAchievementIconFetched_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0000546F File Offset: 0x0000366F
		public UserAchievementIconFetched_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00005478 File Offset: 0x00003678
		public UserAchievementIconFetched_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserAchievementIconFetched_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x0006366C File Offset: 0x0006186C
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x0000548A File Offset: 0x0000368A
		public unsafe GameId GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_GameID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_GameID)) = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x00063694 File Offset: 0x00061894
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x000054A5 File Offset: 0x000036A5
		public unsafe Il2CppStructArray<byte> AchievementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_AchievementName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_AchievementName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x000636C4 File Offset: 0x000618C4
		// (set) Token: 0x060011C2 RID: 4546 RVA: 0x000054C4 File Offset: 0x000036C4
		public unsafe bool Achieved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_Achieved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_Achieved)) = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x000636EC File Offset: 0x000618EC
		// (set) Token: 0x060011C4 RID: 4548 RVA: 0x000054DF File Offset: 0x000036DF
		public unsafe int IconHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_IconHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UserAchievementIconFetched_t.NativeFieldInfoPtr_IconHandle)) = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x00063714 File Offset: 0x00061914
		// (set) Token: 0x060011C6 RID: 4550 RVA: 0x000054FA File Offset: 0x000036FA
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserAchievementIconFetched_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserAchievementIconFetched_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeFieldInfoPtr_AchievementName;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeFieldInfoPtr_Achieved;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeFieldInfoPtr_IconHandle;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_AchievementNameUTF8_Internal_String_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
