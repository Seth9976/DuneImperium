using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using offlineChallenges;
using zen.src.challenges;

namespace worm.client.achievements
{
	// Token: 0x020002A8 RID: 680
	public class WormAchievements : Challenges
	{
		// Token: 0x06001BB7 RID: 7095 RVA: 0x0006D598 File Offset: 0x0006B798
		// Note: this type is marked as 'beforefieldinit'.
		static WormAchievements()
		{
			Il2CppClassPointerStore<WormAchievements>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.achievements", "WormAchievements");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAchievements>.NativeClassPtr);
			WormAchievements.NativeMethodInfoPtr_NumberOfChallengesActive_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAchievements>.NativeClassPtr, 100667343);
			WormAchievements.NativeMethodInfoPtr_Queue_Protected_Virtual_IEnumerable_1_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAchievements>.NativeClassPtr, 100667344);
			WormAchievements.NativeMethodInfoPtr_ConfigureMatchData_Public_Virtual_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAchievements>.NativeClassPtr, 100667345);
			WormAchievements.NativeMethodInfoPtr_ChallengeDefs_Private_Static_Il2CppReferenceArray_1_ChallengeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAchievements>.NativeClassPtr, 100667346);
			WormAchievements.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAchievements>.NativeClassPtr, 100667347);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0006D62C File Offset: 0x0006B82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725373, XrefRangeEnd = 725374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int NumberOfChallengesActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAchievements.NativeMethodInfoPtr_NumberOfChallengesActive_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0006D674 File Offset: 0x0006B874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725374, XrefRangeEnd = 725375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ChallengeDefinition> Queue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAchievements.NativeMethodInfoPtr_Queue_Protected_Virtual_IEnumerable_1_ChallengeDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ChallengeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0006D6C0 File Offset: 0x0006B8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 725375, XrefRangeEnd = 725417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureMatchData(MatchInitData matchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAchievements.NativeMethodInfoPtr_ConfigureMatchData_Public_Virtual_Void_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0006D710 File Offset: 0x0006B910
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 726928, RefRangeEnd = 726930, XrefRangeStart = 725417, XrefRangeEnd = 726928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ChallengeDefinition> ChallengeDefs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAchievements.NativeMethodInfoPtr_ChallengeDefs_Private_Static_Il2CppReferenceArray_1_ChallengeDefinition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ChallengeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0006D744 File Offset: 0x0006B944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726930, XrefRangeEnd = 726931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAchievements()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAchievements>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAchievements.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0000FFD4 File Offset: 0x0000E1D4
		public WormAchievements(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_NumberOfChallengesActive_Protected_Virtual_Int32_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_Queue_Protected_Virtual_IEnumerable_1_ChallengeDefinition_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureMatchData_Public_Virtual_Void_MatchInitData_0;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr_ChallengeDefs_Private_Static_Il2CppReferenceArray_1_ChallengeDefinition_0;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
