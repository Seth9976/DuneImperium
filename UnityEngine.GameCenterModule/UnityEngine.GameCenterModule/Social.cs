using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.SocialPlatforms;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public static class Social : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002760 File Offset: 0x00000960
		// Note: this type is marked as 'beforefieldinit'.
		static Social()
		{
			Il2CppClassPointerStore<Social>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine", "Social");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Social>.NativeClassPtr);
			Social.NativeMethodInfoPtr_get_Active_Public_Static_get_ISocialPlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Social>.NativeClassPtr, 100663297);
			Social.NativeMethodInfoPtr_get_localUser_Public_Static_get_ILocalUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Social>.NativeClassPtr, 100663298);
			Social.NativeMethodInfoPtr_ReportProgress_Public_Static_Void_String_Double_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Social>.NativeClassPtr, 100663299);
			Social.NativeMethodInfoPtr_ShowAchievementsUI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Social>.NativeClassPtr, 100663300);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000027E0 File Offset: 0x000009E0
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static ISocialPlatform Active
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1270477, RefRangeEnd = 1270481, XrefRangeStart = 1270434, XrefRangeEnd = 1270477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Social.NativeMethodInfoPtr_get_Active_Public_Static_get_ISocialPlatform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISocialPlatform>(intPtr3) : null;
			}
			set
			{
				ActivePlatform.Instance = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002814 File Offset: 0x00000A14
		public unsafe static ILocalUser localUser
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1270486, RefRangeEnd = 1270487, XrefRangeStart = 1270481, XrefRangeEnd = 1270486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Social.NativeMethodInfoPtr_get_localUser_Public_Static_get_ILocalUser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILocalUser>(intPtr3) : null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002848 File Offset: 0x00000A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1270491, RefRangeEnd = 1270492, XrefRangeStart = 1270487, XrefRangeEnd = 1270491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Social.NativeMethodInfoPtr_ReportProgress_Public_Static_Void_String_Double_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000028A0 File Offset: 0x00000AA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1270497, RefRangeEnd = 1270499, XrefRangeStart = 1270492, XrefRangeEnd = 1270497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShowAchievementsUI()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Social.NativeMethodInfoPtr_ShowAchievementsUI_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		public Social(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002063 File Offset: 0x00000263
		public static void LoadUsers(Il2CppStringArray userIDs, Action<Il2CppReferenceArray<IUserProfile>> callback)
		{
			Social.Active.LoadUsers(userIDs, callback);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002073 File Offset: 0x00000273
		public static void LoadAchievementDescriptions(Action<Il2CppReferenceArray<IAchievementDescription>> callback)
		{
			Social.Active.LoadAchievementDescriptions(callback);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002082 File Offset: 0x00000282
		public static void LoadAchievements(Action<Il2CppReferenceArray<IAchievement>> callback)
		{
			Social.Active.LoadAchievements(callback);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002091 File Offset: 0x00000291
		public static void ReportScore(long score, string board, Action<bool> callback)
		{
			Social.Active.ReportScore(score, board, callback);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020A2 File Offset: 0x000002A2
		public static void LoadScores(string leaderboardID, Action<Il2CppReferenceArray<IScore>> callback)
		{
			Social.Active.LoadScores(leaderboardID, callback);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000028C8 File Offset: 0x00000AC8
		public static ILeaderboard CreateLeaderboard()
		{
			return Social.Active.CreateLeaderboard();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000028E4 File Offset: 0x00000AE4
		public static IAchievement CreateAchievement()
		{
			return Social.Active.CreateAchievement();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020B2 File Offset: 0x000002B2
		public static void ShowLeaderboardUI()
		{
			Social.Active.ShowLeaderboardUI();
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_Static_get_ISocialPlatform_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_get_localUser_Public_Static_get_ILocalUser_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_ReportProgress_Public_Static_Void_String_Double_Action_1_Boolean_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_ShowAchievementsUI_Public_Static_Void_0;
	}
}
