using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000003 RID: 3
	public class Local : Object
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002900 File Offset: 0x00000B00
		// Note: this type is marked as 'beforefieldinit'.
		static Local()
		{
			Il2CppClassPointerStore<Local>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine.SocialPlatforms", "Local");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Local>.NativeClassPtr);
			Local.NativeFieldInfoPtr_m_LocalUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Local>.NativeClassPtr, "m_LocalUser");
			Local.NativeFieldInfoPtr_m_Friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Local>.NativeClassPtr, "m_Friends");
			Local.NativeFieldInfoPtr_m_Users = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Local>.NativeClassPtr, "m_Users");
			Local.NativeFieldInfoPtr_m_AchievementDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Local>.NativeClassPtr, "m_AchievementDescriptions");
			Local.NativeFieldInfoPtr_m_Achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Local>.NativeClassPtr, "m_Achievements");
			Local.NativeFieldInfoPtr_m_Leaderboards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Local>.NativeClassPtr, "m_Leaderboards");
			Local.NativeMethodInfoPtr_get_localUser_Public_Virtual_Final_New_get_ILocalUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Local>.NativeClassPtr, 100663301);
			Local.NativeMethodInfoPtr_ReportProgress_Public_Virtual_Final_New_Void_String_Double_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Local>.NativeClassPtr, 100663302);
			Local.NativeMethodInfoPtr_ShowAchievementsUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Local>.NativeClassPtr, 100663303);
			Local.NativeMethodInfoPtr_VerifyUser_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Local>.NativeClassPtr, 100663304);
			Local.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Local>.NativeClassPtr, 100663305);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002A0C File Offset: 0x00000C0C
		public unsafe virtual ILocalUser localUser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270499, XrefRangeEnd = 1270529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Local.NativeMethodInfoPtr_get_localUser_Public_Virtual_Final_New_get_ILocalUser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILocalUser>(intPtr3) : null;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002A4C File Offset: 0x00000C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270529, XrefRangeEnd = 1270586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReportProgress(string id, double progress, Action<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Local.NativeMethodInfoPtr_ReportProgress_Public_Virtual_Final_New_Void_String_Double_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002AB0 File Offset: 0x00000CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270586, XrefRangeEnd = 1270592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowAchievementsUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Local.NativeMethodInfoPtr_ShowAchievementsUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002AE4 File Offset: 0x00000CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1270627, RefRangeEnd = 1270628, XrefRangeStart = 1270592, XrefRangeEnd = 1270627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifyUser()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Local.NativeMethodInfoPtr_VerifyUser_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002B20 File Offset: 0x00000D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270628, XrefRangeEnd = 1270662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Local()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Local>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Local.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020C0 File Offset: 0x000002C0
		public Local(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002B5C File Offset: 0x00000D5C
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020C9 File Offset: 0x000002C9
		public unsafe static LocalUser m_LocalUser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Local.NativeFieldInfoPtr_m_LocalUser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalUser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Local.NativeFieldInfoPtr_m_LocalUser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002B84 File Offset: 0x00000D84
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020DB File Offset: 0x000002DB
		public unsafe List<UserProfile> m_Friends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Local.NativeFieldInfoPtr_m_Friends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UserProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Local.NativeFieldInfoPtr_m_Friends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002BB4 File Offset: 0x00000DB4
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020FA File Offset: 0x000002FA
		public unsafe List<UserProfile> m_Users
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Local.NativeFieldInfoPtr_m_Users);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UserProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Local.NativeFieldInfoPtr_m_Users), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002BE4 File Offset: 0x00000DE4
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002119 File Offset: 0x00000319
		public unsafe List<AchievementDescription> m_AchievementDescriptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Local.NativeFieldInfoPtr_m_AchievementDescriptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AchievementDescription>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Local.NativeFieldInfoPtr_m_AchievementDescriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002C14 File Offset: 0x00000E14
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002138 File Offset: 0x00000338
		public unsafe List<Achievement> m_Achievements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Local.NativeFieldInfoPtr_m_Achievements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Achievement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Local.NativeFieldInfoPtr_m_Achievements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002C44 File Offset: 0x00000E44
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002157 File Offset: 0x00000357
		public unsafe List<Leaderboard> m_Leaderboards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Local.NativeFieldInfoPtr_m_Leaderboards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Leaderboard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Local.NativeFieldInfoPtr_m_Leaderboards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002176 File Offset: 0x00000376
		public void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, Action<bool> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002183 File Offset: 0x00000383
		public void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, Action<bool, string> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002C74 File Offset: 0x00000E74
		public void UnityEngine.SocialPlatforms.ISocialPlatform.LoadFriends(ILocalUser user, Action<bool> callback)
		{
			bool flag = !this.VerifyUser();
			if (!flag)
			{
				LocalUser localUser = user.Cast<LocalUser>();
				Il2CppReferenceArray<IUserProfile> il2CppReferenceArray = this.m_Friends.ToArray();
				localUser.SetFriends(il2CppReferenceArray);
				bool flag2 = callback != null;
				if (flag2)
				{
					callback.Invoke(true);
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002190 File Offset: 0x00000390
		public void LoadUsers(Il2CppStringArray userIDs, Action<Il2CppReferenceArray<IUserProfile>> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002CBC File Offset: 0x00000EBC
		public void LoadAchievementDescriptions(Action<Il2CppReferenceArray<IAchievementDescription>> callback)
		{
			bool flag = !this.VerifyUser();
			if (!flag)
			{
				bool flag2 = callback != null;
				if (flag2)
				{
					Il2CppReferenceArray<IAchievementDescription> il2CppReferenceArray = this.m_AchievementDescriptions.ToArray();
					callback.Invoke(il2CppReferenceArray);
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002CF8 File Offset: 0x00000EF8
		public void LoadAchievements(Action<Il2CppReferenceArray<IAchievement>> callback)
		{
			bool flag = !this.VerifyUser();
			if (!flag)
			{
				bool flag2 = callback != null;
				if (flag2)
				{
					Il2CppReferenceArray<IAchievement> il2CppReferenceArray = this.m_Achievements.ToArray();
					callback.Invoke(il2CppReferenceArray);
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002D34 File Offset: 0x00000F34
		public void ReportScore(long score, string board, Action<bool> callback)
		{
			bool flag = !this.VerifyUser();
			if (!flag)
			{
				List<Leaderboard>.Enumerator enumerator = this.m_Leaderboards.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Leaderboard leaderboard = enumerator.Current;
						bool flag2 = leaderboard.id == board;
						if (flag2)
						{
							List<Score> list = new List<Score>(leaderboard.scores.Cast<Il2CppReferenceArray<Score>>());
							list.Add(new Score(board, score, this.localUser.id, DateTime.Now, String.Concat(score.ToString(), " points"), 0));
							Leaderboard leaderboard2 = leaderboard;
							Il2CppReferenceArray<IScore> il2CppReferenceArray = list.ToArray();
							leaderboard2.SetScores(il2CppReferenceArray);
							bool flag3 = callback != null;
							if (flag3)
							{
								callback.Invoke(true);
							}
							return;
						}
					}
				}
				finally
				{
					enumerator.Dispose();
				}
				Debug.LogError("Leaderboard not found");
				bool flag4 = callback != null;
				if (flag4)
				{
					callback.Invoke(false);
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002E34 File Offset: 0x00001034
		public void LoadScores(string leaderboardID, Action<Il2CppReferenceArray<IScore>> callback)
		{
			bool flag = !this.VerifyUser();
			if (!flag)
			{
				List<Leaderboard>.Enumerator enumerator = this.m_Leaderboards.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Leaderboard leaderboard = enumerator.Current;
						bool flag2 = leaderboard.id == leaderboardID;
						if (flag2)
						{
							this.SortScores(leaderboard);
							bool flag3 = callback != null;
							if (flag3)
							{
								callback.Invoke(leaderboard.scores);
							}
							return;
						}
					}
				}
				finally
				{
					enumerator.Dispose();
				}
				Debug.LogError("Leaderboard not found");
				bool flag4 = callback != null;
				if (flag4)
				{
					Il2CppReferenceArray<IScore> il2CppReferenceArray = new Il2CppReferenceArray<Score>(0L);
					callback.Invoke(il2CppReferenceArray);
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002EF0 File Offset: 0x000010F0
		public void UnityEngine.SocialPlatforms.ISocialPlatform.LoadScores(ILeaderboard board, Action<bool> callback)
		{
			bool flag = !this.VerifyUser();
			if (!flag)
			{
				Leaderboard leaderboard = board.Cast<Leaderboard>();
				List<Leaderboard>.Enumerator enumerator = this.m_Leaderboards.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Leaderboard leaderboard2 = enumerator.Current;
						bool flag2 = leaderboard2.id == leaderboard.id;
						if (flag2)
						{
							leaderboard.SetTitle(leaderboard2.title);
							leaderboard.SetScores(leaderboard2.scores);
							leaderboard.SetMaxRange((uint)leaderboard2.scores.Length);
						}
					}
				}
				finally
				{
					enumerator.Dispose();
				}
				this.SortScores(leaderboard);
				this.SetLocalPlayerScore(leaderboard);
				bool flag3 = callback != null;
				if (flag3)
				{
					callback.Invoke(true);
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002FC4 File Offset: 0x000011C4
		public bool UnityEngine.SocialPlatforms.ISocialPlatform.GetLoading(ILeaderboard board)
		{
			bool flag = !this.VerifyUser();
			return !flag && board.Cast<Leaderboard>().loading;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000219D File Offset: 0x0000039D
		public void SortScores(Leaderboard board)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021AA File Offset: 0x000003AA
		public void SetLocalPlayerScore(Leaderboard board)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000021B7 File Offset: 0x000003B7
		public void ShowLeaderboardUI()
		{
			Debug.Log("ShowLeaderboardUI not implemented");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002FF4 File Offset: 0x000011F4
		public ILeaderboard CreateLeaderboard()
		{
			return new Leaderboard();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003010 File Offset: 0x00001210
		public IAchievement CreateAchievement()
		{
			return new Achievement();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021C5 File Offset: 0x000003C5
		public void PopulateStaticData()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000302C File Offset: 0x0000122C
		public Texture2D CreateDummyTexture(int width, int height)
		{
			Texture2D texture2D = new Texture2D(width, height);
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Color color = (((j & i) > 0) ? Color.white : Color.gray);
					texture2D.SetPixel(j, i, color);
				}
			}
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalUser;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_m_Friends;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_m_Users;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_m_AchievementDescriptions;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_m_Achievements;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_m_Leaderboards;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_localUser_Public_Virtual_Final_New_get_ILocalUser_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_ReportProgress_Public_Virtual_Final_New_Void_String_Double_Action_1_Boolean_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_ShowAchievementsUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_VerifyUser_Private_Boolean_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000015 RID: 21
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x02000016 RID: 22
		public sealed class <>c__DisplayClass10_0
		{
		}
	}
}
