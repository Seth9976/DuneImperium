using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000BA RID: 186
	[StructLayout(2)]
	public struct Friend
	{
		// Token: 0x06000BE3 RID: 3043 RVA: 0x000506B0 File Offset: 0x0004E8B0
		// Note: this type is marked as 'beforefieldinit'.
		static Friend()
		{
			Il2CppClassPointerStore<Friend>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "Friend");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Friend>.NativeClassPtr);
			Friend.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend>.NativeClassPtr, "Id");
			Friend.NativeMethodInfoPtr__ctor_Public_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666221);
			Friend.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666222);
			Friend.NativeMethodInfoPtr_get_IsMe_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666223);
			Friend.NativeMethodInfoPtr_get_IsFriend_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666224);
			Friend.NativeMethodInfoPtr_get_IsBlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666225);
			Friend.NativeMethodInfoPtr_get_IsPlayingThisGame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666226);
			Friend.NativeMethodInfoPtr_get_IsOnline_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666227);
			Friend.NativeMethodInfoPtr_RequestInfoAsync_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666228);
			Friend.NativeMethodInfoPtr_get_IsAway_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666229);
			Friend.NativeMethodInfoPtr_get_IsBusy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666230);
			Friend.NativeMethodInfoPtr_get_IsSnoozing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666231);
			Friend.NativeMethodInfoPtr_get_Relationship_Public_get_Relationship_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666232);
			Friend.NativeMethodInfoPtr_get_State_Public_get_FriendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666233);
			Friend.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666234);
			Friend.NativeMethodInfoPtr_get_NameHistory_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666235);
			Friend.NativeMethodInfoPtr_get_SteamLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666236);
			Friend.NativeMethodInfoPtr_get_GameInfo_Public_get_Nullable_1_FriendGameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666237);
			Friend.NativeMethodInfoPtr_IsIn_Public_Boolean_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666238);
			Friend.NativeMethodInfoPtr_GetSmallAvatarAsync_Public_Task_1_Nullable_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666239);
			Friend.NativeMethodInfoPtr_GetMediumAvatarAsync_Public_Task_1_Nullable_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666240);
			Friend.NativeMethodInfoPtr_GetLargeAvatarAsync_Public_Task_1_Nullable_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666241);
			Friend.NativeMethodInfoPtr_GetRichPresence_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666242);
			Friend.NativeMethodInfoPtr_InviteToGame_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666243);
			Friend.NativeMethodInfoPtr_SendMessage_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666244);
			Friend.NativeMethodInfoPtr_RequestUserStatsAsync_Public_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666245);
			Friend.NativeMethodInfoPtr_GetStatFloat_Public_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666246);
			Friend.NativeMethodInfoPtr_GetStatInt_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666247);
			Friend.NativeMethodInfoPtr_GetAchievement_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666248);
			Friend.NativeMethodInfoPtr_GetAchievementUnlockTime_Public_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100666249);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00050938 File Offset: 0x0004EB38
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Friend(SteamId steamid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr__ctor_Public_Void_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0005096C File Offset: 0x0004EB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946404, XrefRangeEnd = 946412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x00050998 File Offset: 0x0004EB98
		public unsafe bool IsMe
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946412, XrefRangeEnd = 946416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_IsMe_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x000509C8 File Offset: 0x0004EBC8
		public unsafe bool IsFriend
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946416, XrefRangeEnd = 946418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_IsFriend_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x000509F8 File Offset: 0x0004EBF8
		public unsafe bool IsBlocked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946418, XrefRangeEnd = 946420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_IsBlocked_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00050A28 File Offset: 0x0004EC28
		public unsafe bool IsPlayingThisGame
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946420, XrefRangeEnd = 946436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_IsPlayingThisGame_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00050A58 File Offset: 0x0004EC58
		public unsafe bool IsOnline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946436, XrefRangeEnd = 946438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_IsOnline_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00050A88 File Offset: 0x0004EC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946438, XrefRangeEnd = 946447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task RequestInfoAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_RequestInfoAsync_Public_Task_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00050ABC File Offset: 0x0004ECBC
		public unsafe bool IsAway
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946447, XrefRangeEnd = 946449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_IsAway_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00050AEC File Offset: 0x0004ECEC
		public unsafe bool IsBusy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946449, XrefRangeEnd = 946451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_IsBusy_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00050B1C File Offset: 0x0004ED1C
		public unsafe bool IsSnoozing
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946451, XrefRangeEnd = 946453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_IsSnoozing_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00050B4C File Offset: 0x0004ED4C
		public unsafe Relationship Relationship
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946453, XrefRangeEnd = 946456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_Relationship_Public_get_Relationship_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00050B7C File Offset: 0x0004ED7C
		public unsafe FriendState State
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946456, XrefRangeEnd = 946459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_State_Public_get_FriendState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00050BAC File Offset: 0x0004EDAC
		public unsafe string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946459, XrefRangeEnd = 946462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_Name_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00050BD8 File Offset: 0x0004EDD8
		public unsafe IEnumerable<string> NameHistory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946462, XrefRangeEnd = 946467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_NameHistory_Public_get_IEnumerable_1_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00050C0C File Offset: 0x0004EE0C
		public unsafe int SteamLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946467, XrefRangeEnd = 946470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_SteamLevel_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00050C3C File Offset: 0x0004EE3C
		public unsafe Nullable<Friend.FriendGameInfo> GameInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 946475, RefRangeEnd = 946476, XrefRangeStart = 946470, XrefRangeEnd = 946475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_get_GameInfo_Public_get_Nullable_1_FriendGameInfo_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<Friend.FriendGameInfo>(intPtr);
			}
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00050C68 File Offset: 0x0004EE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946476, XrefRangeEnd = 946479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIn(SteamId group_or_room)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref group_or_room;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_IsIn_Public_Boolean_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00050CA8 File Offset: 0x0004EEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946479, XrefRangeEnd = 946492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<Image>> GetSmallAvatarAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_GetSmallAvatarAsync_Public_Task_1_Nullable_1_Image_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Image>>>(intPtr3) : null;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00050CDC File Offset: 0x0004EEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946492, XrefRangeEnd = 946505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<Image>> GetMediumAvatarAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_GetMediumAvatarAsync_Public_Task_1_Nullable_1_Image_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Image>>>(intPtr3) : null;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00050D10 File Offset: 0x0004EF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946505, XrefRangeEnd = 946518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<Image>> GetLargeAvatarAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_GetLargeAvatarAsync_Public_Task_1_Nullable_1_Image_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Image>>>(intPtr3) : null;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00050D44 File Offset: 0x0004EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946518, XrefRangeEnd = 946521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRichPresence(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_GetRichPresence_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00050D80 File Offset: 0x0004EF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946521, XrefRangeEnd = 946524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InviteToGame(string Text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_InviteToGame_Public_Boolean_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00050DC4 File Offset: 0x0004EFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946524, XrefRangeEnd = 946527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendMessage(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_SendMessage_Public_Boolean_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00050E08 File Offset: 0x0004F008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946527, XrefRangeEnd = 946540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> RequestUserStatsAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_RequestUserStatsAsync_Public_Task_1_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00050E3C File Offset: 0x0004F03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946540, XrefRangeEnd = 946542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetStatFloat(string statName, float defult = 0f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(statName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_GetStatFloat_Public_Single_String_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00050E8C File Offset: 0x0004F08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946542, XrefRangeEnd = 946544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStatInt(string statName, int defult = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(statName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_GetStatInt_Public_Int32_String_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00050EDC File Offset: 0x0004F0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946544, XrefRangeEnd = 946546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAchievement(string statName, bool defult = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(statName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_GetAchievement_Public_Boolean_String_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00050F2C File Offset: 0x0004F12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946546, XrefRangeEnd = 946557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime GetAchievementUnlockTime(string statName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(statName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.NativeMethodInfoPtr_GetAchievementUnlockTime_Public_DateTime_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00002EF3 File Offset: 0x000010F3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Friend>.NativeClassPtr, ref this));
		}

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SteamId_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMe_Public_get_Boolean_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFriend_Public_get_Boolean_0;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBlocked_Public_get_Boolean_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlayingThisGame_Public_get_Boolean_0;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOnline_Public_get_Boolean_0;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeMethodInfoPtr_RequestInfoAsync_Public_Task_0;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAway_Public_get_Boolean_0;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBusy_Public_get_Boolean_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSnoozing_Public_get_Boolean_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_get_Relationship_Public_get_Relationship_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_FriendState_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr_get_NameHistory_Public_get_IEnumerable_1_String_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_get_SteamLevel_Public_get_Int32_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_get_GameInfo_Public_get_Nullable_1_FriendGameInfo_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_IsIn_Public_Boolean_SteamId_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_GetSmallAvatarAsync_Public_Task_1_Nullable_1_Image_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_GetMediumAvatarAsync_Public_Task_1_Nullable_1_Image_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_GetLargeAvatarAsync_Public_Task_1_Nullable_1_Image_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_GetRichPresence_Public_String_String_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr_InviteToGame_Public_Boolean_String_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Boolean_String_0;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserStatsAsync_Public_Task_1_Boolean_0;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr_GetStatFloat_Public_Single_String_Single_0;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeMethodInfoPtr_GetStatInt_Public_Int32_String_Int32_0;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievement_Public_Boolean_String_Boolean_0;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementUnlockTime_Public_DateTime_String_0;

		// Token: 0x040012B0 RID: 4784
		[FieldOffset(0)]
		public SteamId Id;

		// Token: 0x02000270 RID: 624
		[StructLayout(2)]
		public struct FriendGameInfo
		{
			// Token: 0x06001FA8 RID: 8104 RVA: 0x0008CF5C File Offset: 0x0008B15C
			// Note: this type is marked as 'beforefieldinit'.
			static FriendGameInfo()
			{
				Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Friend>.NativeClassPtr, "FriendGameInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr);
				Friend.FriendGameInfo.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr, "GameID");
				Friend.FriendGameInfo.NativeFieldInfoPtr_GameIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr, "GameIP");
				Friend.FriendGameInfo.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr, "SteamIDLobby");
				Friend.FriendGameInfo.NativeFieldInfoPtr_ConnectionPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr, "ConnectionPort");
				Friend.FriendGameInfo.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr, "QueryPort");
				Friend.FriendGameInfo.NativeMethodInfoPtr_get_IpAddressRaw_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr, 100666250);
				Friend.FriendGameInfo.NativeMethodInfoPtr_get_IpAddress_Public_get_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr, 100666251);
				Friend.FriendGameInfo.NativeMethodInfoPtr_get_Lobby_Public_get_Nullable_1_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr, 100666252);
				Friend.FriendGameInfo.NativeMethodInfoPtr_From_Internal_Static_FriendGameInfo_FriendGameInfo_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr, 100666253);
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0008D03C File Offset: 0x0008B23C
			public unsafe uint IpAddressRaw
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.FriendGameInfo.NativeMethodInfoPtr_get_IpAddressRaw_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x06001FAA RID: 8106 RVA: 0x0008D06C File Offset: 0x0008B26C
			public unsafe IPAddress IpAddress
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946257, XrefRangeEnd = 946267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.FriendGameInfo.NativeMethodInfoPtr_get_IpAddress_Public_get_IPAddress_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
				}
			}

			// Token: 0x1700081B RID: 2075
			// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0008D0A0 File Offset: 0x0008B2A0
			public unsafe Nullable<Lobby> Lobby
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946267, XrefRangeEnd = 946271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.FriendGameInfo.NativeMethodInfoPtr_get_Lobby_Public_get_Nullable_1_Lobby_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<Lobby>(intPtr);
				}
			}

			// Token: 0x06001FAC RID: 8108 RVA: 0x0008D0CC File Offset: 0x0008B2CC
			[CallerCount(0)]
			public unsafe static Friend.FriendGameInfo From(FriendGameInfo_t i)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend.FriendGameInfo.NativeMethodInfoPtr_From_Internal_Static_FriendGameInfo_FriendGameInfo_t_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FAD RID: 8109 RVA: 0x0000BD52 File Offset: 0x00009F52
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Friend.FriendGameInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x04002259 RID: 8793
			private static readonly IntPtr NativeFieldInfoPtr_GameID;

			// Token: 0x0400225A RID: 8794
			private static readonly IntPtr NativeFieldInfoPtr_GameIP;

			// Token: 0x0400225B RID: 8795
			private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

			// Token: 0x0400225C RID: 8796
			private static readonly IntPtr NativeFieldInfoPtr_ConnectionPort;

			// Token: 0x0400225D RID: 8797
			private static readonly IntPtr NativeFieldInfoPtr_QueryPort;

			// Token: 0x0400225E RID: 8798
			private static readonly IntPtr NativeMethodInfoPtr_get_IpAddressRaw_Public_get_UInt32_0;

			// Token: 0x0400225F RID: 8799
			private static readonly IntPtr NativeMethodInfoPtr_get_IpAddress_Public_get_IPAddress_0;

			// Token: 0x04002260 RID: 8800
			private static readonly IntPtr NativeMethodInfoPtr_get_Lobby_Public_get_Nullable_1_Lobby_0;

			// Token: 0x04002261 RID: 8801
			private static readonly IntPtr NativeMethodInfoPtr_From_Internal_Static_FriendGameInfo_FriendGameInfo_t_0;

			// Token: 0x04002262 RID: 8802
			[FieldOffset(0)]
			public ulong GameID;

			// Token: 0x04002263 RID: 8803
			[FieldOffset(8)]
			public uint GameIP;

			// Token: 0x04002264 RID: 8804
			[FieldOffset(16)]
			public ulong SteamIDLobby;

			// Token: 0x04002265 RID: 8805
			[FieldOffset(24)]
			public int ConnectionPort;

			// Token: 0x04002266 RID: 8806
			[FieldOffset(28)]
			public int QueryPort;
		}

		// Token: 0x02000271 RID: 625
		[ObfuscatedName("Steamworks.Friend+<GetLargeAvatarAsync>d__36")]
		public sealed class _GetLargeAvatarAsync_d__36 : ValueType
		{
			// Token: 0x06001FAE RID: 8110 RVA: 0x0008D10C File Offset: 0x0008B30C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetLargeAvatarAsync_d__36()
			{
				Il2CppClassPointerStore<Friend._GetLargeAvatarAsync_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Friend>.NativeClassPtr, "<GetLargeAvatarAsync>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Friend._GetLargeAvatarAsync_d__36>.NativeClassPtr);
				Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetLargeAvatarAsync_d__36>.NativeClassPtr, "<>1__state");
				Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetLargeAvatarAsync_d__36>.NativeClassPtr, "<>t__builder");
				Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetLargeAvatarAsync_d__36>.NativeClassPtr, "<>4__this");
				Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetLargeAvatarAsync_d__36>.NativeClassPtr, "<>u__1");
				Friend._GetLargeAvatarAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._GetLargeAvatarAsync_d__36>.NativeClassPtr, 100666254);
				Friend._GetLargeAvatarAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._GetLargeAvatarAsync_d__36>.NativeClassPtr, 100666255);
			}

			// Token: 0x06001FAF RID: 8111 RVA: 0x0008D1B0 File Offset: 0x0008B3B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946271, XrefRangeEnd = 946289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._GetLargeAvatarAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FB0 RID: 8112 RVA: 0x0008D1E8 File Offset: 0x0008B3E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946289, XrefRangeEnd = 946295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._GetLargeAvatarAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FB1 RID: 8113 RVA: 0x0000BD64 File Offset: 0x00009F64
			public _GetLargeAvatarAsync_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FB2 RID: 8114 RVA: 0x0000BD6D File Offset: 0x00009F6D
			public _GetLargeAvatarAsync_d__36()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Friend._GetLargeAvatarAsync_d__36>.NativeClassPtr))
			{
			}

			// Token: 0x1700081C RID: 2076
			// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0008D230 File Offset: 0x0008B430
			// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x0000BD7F File Offset: 0x00009F7F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700081D RID: 2077
			// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0008D258 File Offset: 0x0008B458
			// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x0000BD9A File Offset: 0x00009F9A
			public AsyncTaskMethodBuilder<Nullable<Image>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Image>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700081E RID: 2078
			// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0008D288 File Offset: 0x0008B488
			// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x0000BDC8 File Offset: 0x00009FC8
			public unsafe Friend __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x1700081F RID: 2079
			// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0008D2B0 File Offset: 0x0008B4B0
			// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0000BDE3 File Offset: 0x00009FE3
			public TaskAwaiter<Nullable<Image>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<Image>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<Image>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetLargeAvatarAsync_d__36.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<Image>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002267 RID: 8807
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002268 RID: 8808
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002269 RID: 8809
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400226A RID: 8810
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400226B RID: 8811
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400226C RID: 8812
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000272 RID: 626
		[ObfuscatedName("Steamworks.Friend+<GetMediumAvatarAsync>d__35")]
		public sealed class _GetMediumAvatarAsync_d__35 : ValueType
		{
			// Token: 0x06001FBB RID: 8123 RVA: 0x0008D2E0 File Offset: 0x0008B4E0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetMediumAvatarAsync_d__35()
			{
				Il2CppClassPointerStore<Friend._GetMediumAvatarAsync_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Friend>.NativeClassPtr, "<GetMediumAvatarAsync>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Friend._GetMediumAvatarAsync_d__35>.NativeClassPtr);
				Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetMediumAvatarAsync_d__35>.NativeClassPtr, "<>1__state");
				Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetMediumAvatarAsync_d__35>.NativeClassPtr, "<>t__builder");
				Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetMediumAvatarAsync_d__35>.NativeClassPtr, "<>4__this");
				Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetMediumAvatarAsync_d__35>.NativeClassPtr, "<>u__1");
				Friend._GetMediumAvatarAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._GetMediumAvatarAsync_d__35>.NativeClassPtr, 100666256);
				Friend._GetMediumAvatarAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._GetMediumAvatarAsync_d__35>.NativeClassPtr, 100666257);
			}

			// Token: 0x06001FBC RID: 8124 RVA: 0x0008D384 File Offset: 0x0008B584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946295, XrefRangeEnd = 946313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._GetMediumAvatarAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FBD RID: 8125 RVA: 0x0008D3BC File Offset: 0x0008B5BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946313, XrefRangeEnd = 946319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._GetMediumAvatarAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FBE RID: 8126 RVA: 0x0000BE11 File Offset: 0x0000A011
			public _GetMediumAvatarAsync_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FBF RID: 8127 RVA: 0x0000BE1A File Offset: 0x0000A01A
			public _GetMediumAvatarAsync_d__35()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Friend._GetMediumAvatarAsync_d__35>.NativeClassPtr))
			{
			}

			// Token: 0x17000820 RID: 2080
			// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x0008D404 File Offset: 0x0008B604
			// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x0000BE2C File Offset: 0x0000A02C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000821 RID: 2081
			// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x0008D42C File Offset: 0x0008B62C
			// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x0000BE47 File Offset: 0x0000A047
			public AsyncTaskMethodBuilder<Nullable<Image>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Image>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000822 RID: 2082
			// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x0008D45C File Offset: 0x0008B65C
			// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x0000BE75 File Offset: 0x0000A075
			public unsafe Friend __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x17000823 RID: 2083
			// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0008D484 File Offset: 0x0008B684
			// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x0000BE90 File Offset: 0x0000A090
			public TaskAwaiter<Nullable<Image>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<Image>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<Image>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetMediumAvatarAsync_d__35.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<Image>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400226D RID: 8813
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400226E RID: 8814
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400226F RID: 8815
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002270 RID: 8816
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002271 RID: 8817
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002272 RID: 8818
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000273 RID: 627
		[ObfuscatedName("Steamworks.Friend+<GetSmallAvatarAsync>d__34")]
		public sealed class _GetSmallAvatarAsync_d__34 : ValueType
		{
			// Token: 0x06001FC8 RID: 8136 RVA: 0x0008D4B4 File Offset: 0x0008B6B4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetSmallAvatarAsync_d__34()
			{
				Il2CppClassPointerStore<Friend._GetSmallAvatarAsync_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Friend>.NativeClassPtr, "<GetSmallAvatarAsync>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Friend._GetSmallAvatarAsync_d__34>.NativeClassPtr);
				Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetSmallAvatarAsync_d__34>.NativeClassPtr, "<>1__state");
				Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetSmallAvatarAsync_d__34>.NativeClassPtr, "<>t__builder");
				Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetSmallAvatarAsync_d__34>.NativeClassPtr, "<>4__this");
				Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._GetSmallAvatarAsync_d__34>.NativeClassPtr, "<>u__1");
				Friend._GetSmallAvatarAsync_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._GetSmallAvatarAsync_d__34>.NativeClassPtr, 100666258);
				Friend._GetSmallAvatarAsync_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._GetSmallAvatarAsync_d__34>.NativeClassPtr, 100666259);
			}

			// Token: 0x06001FC9 RID: 8137 RVA: 0x0008D558 File Offset: 0x0008B758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946319, XrefRangeEnd = 946337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._GetSmallAvatarAsync_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FCA RID: 8138 RVA: 0x0008D590 File Offset: 0x0008B790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946337, XrefRangeEnd = 946343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._GetSmallAvatarAsync_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FCB RID: 8139 RVA: 0x0000BEBE File Offset: 0x0000A0BE
			public _GetSmallAvatarAsync_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FCC RID: 8140 RVA: 0x0000BEC7 File Offset: 0x0000A0C7
			public _GetSmallAvatarAsync_d__34()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Friend._GetSmallAvatarAsync_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x17000824 RID: 2084
			// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0008D5D8 File Offset: 0x0008B7D8
			// (set) Token: 0x06001FCE RID: 8142 RVA: 0x0000BED9 File Offset: 0x0000A0D9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000825 RID: 2085
			// (get) Token: 0x06001FCF RID: 8143 RVA: 0x0008D600 File Offset: 0x0008B800
			// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
			public AsyncTaskMethodBuilder<Nullable<Image>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Image>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000826 RID: 2086
			// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0008D630 File Offset: 0x0008B830
			// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0000BF22 File Offset: 0x0000A122
			public unsafe Friend __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x17000827 RID: 2087
			// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x0008D658 File Offset: 0x0008B858
			// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0000BF3D File Offset: 0x0000A13D
			public TaskAwaiter<Nullable<Image>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Nullable<Image>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Nullable<Image>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._GetSmallAvatarAsync_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Nullable<Image>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002273 RID: 8819
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002274 RID: 8820
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002275 RID: 8821
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002276 RID: 8822
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002277 RID: 8823
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002278 RID: 8824
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000274 RID: 628
		[ObfuscatedName("Steamworks.Friend+<RequestInfoAsync>d__13")]
		public sealed class _RequestInfoAsync_d__13 : ValueType
		{
			// Token: 0x06001FD5 RID: 8149 RVA: 0x0008D688 File Offset: 0x0008B888
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestInfoAsync_d__13()
			{
				Il2CppClassPointerStore<Friend._RequestInfoAsync_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Friend>.NativeClassPtr, "<RequestInfoAsync>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Friend._RequestInfoAsync_d__13>.NativeClassPtr);
				Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._RequestInfoAsync_d__13>.NativeClassPtr, "<>1__state");
				Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._RequestInfoAsync_d__13>.NativeClassPtr, "<>t__builder");
				Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._RequestInfoAsync_d__13>.NativeClassPtr, "<>4__this");
				Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._RequestInfoAsync_d__13>.NativeClassPtr, "<>u__1");
				Friend._RequestInfoAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._RequestInfoAsync_d__13>.NativeClassPtr, 100666260);
				Friend._RequestInfoAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._RequestInfoAsync_d__13>.NativeClassPtr, 100666261);
			}

			// Token: 0x06001FD6 RID: 8150 RVA: 0x0008D72C File Offset: 0x0008B92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946343, XrefRangeEnd = 946353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._RequestInfoAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FD7 RID: 8151 RVA: 0x0008D764 File Offset: 0x0008B964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946353, XrefRangeEnd = 946357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._RequestInfoAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FD8 RID: 8152 RVA: 0x0000BF6B File Offset: 0x0000A16B
			public _RequestInfoAsync_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FD9 RID: 8153 RVA: 0x0000BF74 File Offset: 0x0000A174
			public _RequestInfoAsync_d__13()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Friend._RequestInfoAsync_d__13>.NativeClassPtr))
			{
			}

			// Token: 0x17000828 RID: 2088
			// (get) Token: 0x06001FDA RID: 8154 RVA: 0x0008D7AC File Offset: 0x0008B9AC
			// (set) Token: 0x06001FDB RID: 8155 RVA: 0x0000BF86 File Offset: 0x0000A186
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000829 RID: 2089
			// (get) Token: 0x06001FDC RID: 8156 RVA: 0x0008D7D4 File Offset: 0x0008B9D4
			// (set) Token: 0x06001FDD RID: 8157 RVA: 0x0000BFA1 File Offset: 0x0000A1A1
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700082A RID: 2090
			// (get) Token: 0x06001FDE RID: 8158 RVA: 0x0008D804 File Offset: 0x0008BA04
			// (set) Token: 0x06001FDF RID: 8159 RVA: 0x0000BFCF File Offset: 0x0000A1CF
			public unsafe Friend __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x1700082B RID: 2091
			// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x0008D82C File Offset: 0x0008BA2C
			// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x0000BFEA File Offset: 0x0000A1EA
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestInfoAsync_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002279 RID: 8825
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400227A RID: 8826
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400227B RID: 8827
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400227C RID: 8828
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400227D RID: 8829
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400227E RID: 8830
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000275 RID: 629
		[ObfuscatedName("Steamworks.Friend+<RequestUserStatsAsync>d__40")]
		public sealed class _RequestUserStatsAsync_d__40 : ValueType
		{
			// Token: 0x06001FE2 RID: 8162 RVA: 0x0008D85C File Offset: 0x0008BA5C
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestUserStatsAsync_d__40()
			{
				Il2CppClassPointerStore<Friend._RequestUserStatsAsync_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Friend>.NativeClassPtr, "<RequestUserStatsAsync>d__40");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Friend._RequestUserStatsAsync_d__40>.NativeClassPtr);
				Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._RequestUserStatsAsync_d__40>.NativeClassPtr, "<>1__state");
				Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._RequestUserStatsAsync_d__40>.NativeClassPtr, "<>t__builder");
				Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._RequestUserStatsAsync_d__40>.NativeClassPtr, "<>4__this");
				Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._RequestUserStatsAsync_d__40>.NativeClassPtr, "<>u__1");
				Friend._RequestUserStatsAsync_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._RequestUserStatsAsync_d__40>.NativeClassPtr, 100666262);
				Friend._RequestUserStatsAsync_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._RequestUserStatsAsync_d__40>.NativeClassPtr, 100666263);
			}

			// Token: 0x06001FE3 RID: 8163 RVA: 0x0008D900 File Offset: 0x0008BB00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946357, XrefRangeEnd = 946381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._RequestUserStatsAsync_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FE4 RID: 8164 RVA: 0x0008D938 File Offset: 0x0008BB38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946381, XrefRangeEnd = 946387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._RequestUserStatsAsync_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FE5 RID: 8165 RVA: 0x0000C018 File Offset: 0x0000A218
			public _RequestUserStatsAsync_d__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FE6 RID: 8166 RVA: 0x0000C021 File Offset: 0x0000A221
			public _RequestUserStatsAsync_d__40()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Friend._RequestUserStatsAsync_d__40>.NativeClassPtr))
			{
			}

			// Token: 0x1700082C RID: 2092
			// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x0008D980 File Offset: 0x0008BB80
			// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x0000C033 File Offset: 0x0000A233
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0008D9A8 File Offset: 0x0008BBA8
			// (set) Token: 0x06001FEA RID: 8170 RVA: 0x0000C04E File Offset: 0x0000A24E
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x06001FEB RID: 8171 RVA: 0x0008D9D8 File Offset: 0x0008BBD8
			// (set) Token: 0x06001FEC RID: 8172 RVA: 0x0000C07C File Offset: 0x0000A27C
			public unsafe Friend __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x1700082F RID: 2095
			// (get) Token: 0x06001FED RID: 8173 RVA: 0x0008DA00 File Offset: 0x0008BC00
			// (set) Token: 0x06001FEE RID: 8174 RVA: 0x0000C097 File Offset: 0x0000A297
			public CallResult<UserStatsReceived_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___u__1);
					return new CallResult<UserStatsReceived_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<UserStatsReceived_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._RequestUserStatsAsync_d__40.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<UserStatsReceived_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400227F RID: 8831
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002280 RID: 8832
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002281 RID: 8833
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002282 RID: 8834
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002283 RID: 8835
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002284 RID: 8836
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000276 RID: 630
		[ObfuscatedName("Steamworks.Friend+<get_NameHistory>d__27")]
		public sealed class _get_NameHistory_d__27 : Object
		{
			// Token: 0x06001FEF RID: 8175 RVA: 0x0008DA30 File Offset: 0x0008BC30
			// Note: this type is marked as 'beforefieldinit'.
			static _get_NameHistory_d__27()
			{
				Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Friend>.NativeClassPtr, "<get_NameHistory>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr);
				Friend._get_NameHistory_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, "<>1__state");
				Friend._get_NameHistory_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, "<>2__current");
				Friend._get_NameHistory_d__27.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, "<>l__initialThreadId");
				Friend._get_NameHistory_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, "<>4__this");
				Friend._get_NameHistory_d__27.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, "<>3__<>4__this");
				Friend._get_NameHistory_d__27.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, "<i>5__2");
				Friend._get_NameHistory_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, 100666264);
				Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, 100666265);
				Friend._get_NameHistory_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, 100666266);
				Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, 100666267);
				Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, 100666268);
				Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, 100666269);
				Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, 100666270);
				Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr, 100666271);
			}

			// Token: 0x06001FF0 RID: 8176 RVA: 0x0008DB74 File Offset: 0x0008BD74
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_NameHistory_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Friend._get_NameHistory_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._get_NameHistory_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FF1 RID: 8177 RVA: 0x0008DBBC File Offset: 0x0008BDBC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FF2 RID: 8178 RVA: 0x0008DBF0 File Offset: 0x0008BDF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946387, XrefRangeEnd = 946392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._get_NameHistory_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000836 RID: 2102
			// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0008DC2C File Offset: 0x0008BE2C
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001FF4 RID: 8180 RVA: 0x0008DC64 File Offset: 0x0008BE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946392, XrefRangeEnd = 946397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000837 RID: 2103
			// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0008DC98 File Offset: 0x0008BE98
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001FF6 RID: 8182 RVA: 0x0008DCD8 File Offset: 0x0008BED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946397, XrefRangeEnd = 946404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x06001FF7 RID: 8183 RVA: 0x0008DD18 File Offset: 0x0008BF18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Friend._get_NameHistory_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001FF8 RID: 8184 RVA: 0x0000C0C5 File Offset: 0x0000A2C5
			public _get_NameHistory_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000830 RID: 2096
			// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x0008DD58 File Offset: 0x0008BF58
			// (set) Token: 0x06001FFA RID: 8186 RVA: 0x0000C0CE File Offset: 0x0000A2CE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000831 RID: 2097
			// (get) Token: 0x06001FFB RID: 8187 RVA: 0x0008DD80 File Offset: 0x0008BF80
			// (set) Token: 0x06001FFC RID: 8188 RVA: 0x0000C0E9 File Offset: 0x0000A2E9
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000832 RID: 2098
			// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0008DDA8 File Offset: 0x0008BFA8
			// (set) Token: 0x06001FFE RID: 8190 RVA: 0x0000C108 File Offset: 0x0000A308
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000833 RID: 2099
			// (get) Token: 0x06001FFF RID: 8191 RVA: 0x0008DDD0 File Offset: 0x0008BFD0
			// (set) Token: 0x06002000 RID: 8192 RVA: 0x0000C123 File Offset: 0x0000A323
			public unsafe Friend __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x17000834 RID: 2100
			// (get) Token: 0x06002001 RID: 8193 RVA: 0x0008DDF8 File Offset: 0x0008BFF8
			// (set) Token: 0x06002002 RID: 8194 RVA: 0x0000C13E File Offset: 0x0000A33E
			public unsafe Friend __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr___3____4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr___3____4__this)) = value;
				}
			}

			// Token: 0x17000835 RID: 2101
			// (get) Token: 0x06002003 RID: 8195 RVA: 0x0008DE20 File Offset: 0x0008C020
			// (set) Token: 0x06002004 RID: 8196 RVA: 0x0000C159 File Offset: 0x0000A359
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Friend._get_NameHistory_d__27.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04002285 RID: 8837
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002286 RID: 8838
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002287 RID: 8839
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002288 RID: 8840
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002289 RID: 8841
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x0400228A RID: 8842
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400228B RID: 8843
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400228C RID: 8844
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400228D RID: 8845
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400228E RID: 8846
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x0400228F RID: 8847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002290 RID: 8848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002291 RID: 8849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x04002292 RID: 8850
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
