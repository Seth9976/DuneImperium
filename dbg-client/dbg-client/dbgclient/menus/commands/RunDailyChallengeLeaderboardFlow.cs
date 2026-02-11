using System;
using boardgames.commands;
using dwd.core.commands;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient.menus.commands
{
	// Token: 0x020000A1 RID: 161
	public class RunDailyChallengeLeaderboardFlow : RunLeaderboardFlow
	{
		// Token: 0x0600065A RID: 1626 RVA: 0x00031C14 File Offset: 0x0002FE14
		// Note: this type is marked as 'beforefieldinit'.
		static RunDailyChallengeLeaderboardFlow()
		{
			Il2CppClassPointerStore<RunDailyChallengeLeaderboardFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.menus.commands", "RunDailyChallengeLeaderboardFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDailyChallengeLeaderboardFlow>.NativeClassPtr);
			RunDailyChallengeLeaderboardFlow.NativeMethodInfoPtr_get_LoadCommand_Public_get_LoadDailyChallengeLeaderboards_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeLeaderboardFlow>.NativeClassPtr, 100664296);
			RunDailyChallengeLeaderboardFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeLeaderboardFlow>.NativeClassPtr, 100664297);
			RunDailyChallengeLeaderboardFlow.NativeMethodInfoPtr_GetLoadLeaderboardsCommand_Protected_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeLeaderboardFlow>.NativeClassPtr, 100664298);
			RunDailyChallengeLeaderboardFlow.NativeMethodInfoPtr_GetPromptData_Protected_Virtual_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDailyChallengeLeaderboardFlow>.NativeClassPtr, 100664299);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00031C94 File Offset: 0x0002FE94
		public unsafe LoadDailyChallengeLeaderboards LoadCommand
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 503237, RefRangeEnd = 503239, XrefRangeStart = 503236, XrefRangeEnd = 503237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeLeaderboardFlow.NativeMethodInfoPtr_get_LoadCommand_Public_get_LoadDailyChallengeLeaderboards_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadDailyChallengeLeaderboards>(intPtr3) : null;
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00031CD4 File Offset: 0x0002FED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 503250, RefRangeEnd = 503252, XrefRangeStart = 503239, XrefRangeEnd = 503250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunDailyChallengeLeaderboardFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDailyChallengeLeaderboardFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDailyChallengeLeaderboardFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00031D10 File Offset: 0x0002FF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503252, XrefRangeEnd = 503269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command GetLoadLeaderboardsCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDailyChallengeLeaderboardFlow.NativeMethodInfoPtr_GetLoadLeaderboardsCommand_Protected_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00031D5C File Offset: 0x0002FF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503269, XrefRangeEnd = 503282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComposition GetPromptData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDailyChallengeLeaderboardFlow.NativeMethodInfoPtr_GetPromptData_Protected_Virtual_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00004E13 File Offset: 0x00003013
		public RunDailyChallengeLeaderboardFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadCommand_Public_get_LoadDailyChallengeLeaderboards_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadLeaderboardsCommand_Protected_Virtual_Command_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptData_Protected_Virtual_DataComposition_0;
	}
}
