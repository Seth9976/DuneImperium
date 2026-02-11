using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.dailyChallenge
{
	// Token: 0x020000BF RID: 191
	public class PlayDailyChallengeGame : NetworkMessageEvent
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x00016478 File Offset: 0x00014678
		// Note: this type is marked as 'beforefieldinit'.
		static PlayDailyChallengeGame()
		{
			Il2CppClassPointerStore<PlayDailyChallengeGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.dailyChallenge", "PlayDailyChallengeGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayDailyChallengeGame>.NativeClassPtr);
			PlayDailyChallengeGame.NativeFieldInfoPtr_PlayerMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeGame>.NativeClassPtr, "PlayerMetadata");
			PlayDailyChallengeGame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeGame>.NativeClassPtr, 100663676);
			PlayDailyChallengeGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeGame>.NativeClassPtr, 100663677);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000164E4 File Offset: 0x000146E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195336, XrefRangeEnd = 1195345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayDailyChallengeGame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00016528 File Offset: 0x00014728
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayDailyChallengeGame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayDailyChallengeGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00005E46 File Offset: 0x00004046
		public PlayDailyChallengeGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00016564 File Offset: 0x00014764
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00005E4F File Offset: 0x0000404F
		public unsafe Dictionary<string, string> PlayerMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeGame.NativeFieldInfoPtr_PlayerMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeGame.NativeFieldInfoPtr_PlayerMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr_PlayerMetadata;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
