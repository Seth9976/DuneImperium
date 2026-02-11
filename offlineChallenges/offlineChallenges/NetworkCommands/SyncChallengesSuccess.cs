using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace offlineChallenges.NetworkCommands
{
	// Token: 0x0200000D RID: 13
	public class SyncChallengesSuccess : NetworkMessageEvent
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00002453 File Offset: 0x00000653
		// Note: this type is marked as 'beforefieldinit'.
		static SyncChallengesSuccess()
		{
			Il2CppClassPointerStore<SyncChallengesSuccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges.NetworkCommands", "SyncChallengesSuccess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncChallengesSuccess>.NativeClassPtr);
			SyncChallengesSuccess.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncChallengesSuccess>.NativeClassPtr, 100663407);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005020 File Offset: 0x00003220
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyncChallengesSuccess()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncChallengesSuccess>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncChallengesSuccess.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000248C File Offset: 0x0000068C
		public SyncChallengesSuccess(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
