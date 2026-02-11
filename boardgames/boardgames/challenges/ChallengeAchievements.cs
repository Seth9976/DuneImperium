using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using offlineChallenges;

namespace boardgames.challenges
{
	// Token: 0x02000154 RID: 340
	public static class ChallengeAchievements : Object
	{
		// Token: 0x0600115B RID: 4443 RVA: 0x00046428 File Offset: 0x00044628
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeAchievements()
		{
			Il2CppClassPointerStore<ChallengeAchievements>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.challenges", "ChallengeAchievements");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeAchievements>.NativeClassPtr);
			ChallengeAchievements.NativeMethodInfoPtr_UnlockAchievement_Public_Static_Void_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeAchievements>.NativeClassPtr, 100665843);
			ChallengeAchievements.NativeMethodInfoPtr_UnlockAchievement_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeAchievements>.NativeClassPtr, 100665844);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00046480 File Offset: 0x00044680
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 999958, RefRangeEnd = 999960, XrefRangeStart = 999932, XrefRangeEnd = 999958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnlockAchievement(ChallengeDefinition challenge)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeAchievements.NativeMethodInfoPtr_UnlockAchievement_Public_Static_Void_ChallengeDefinition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x000464B8 File Offset: 0x000446B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1000028, RefRangeEnd = 1000029, XrefRangeStart = 999960, XrefRangeEnd = 1000028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnlockAchievement(string achievementId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeAchievements.NativeMethodInfoPtr_UnlockAchievement_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0000A1FA File Offset: 0x000083FA
		public ChallengeAchievements(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Static_Void_ChallengeDefinition_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Static_Void_String_0;
	}
}
