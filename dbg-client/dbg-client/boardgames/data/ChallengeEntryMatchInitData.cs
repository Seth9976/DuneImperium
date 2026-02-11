using System;
using boardgames.utils;
using Canis;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.data
{
	// Token: 0x02000180 RID: 384
	public class ChallengeEntryMatchInitData : DataComponent
	{
		// Token: 0x060010D6 RID: 4310 RVA: 0x00052BBC File Offset: 0x00050DBC
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeEntryMatchInitData()
		{
			Il2CppClassPointerStore<ChallengeEntryMatchInitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "ChallengeEntryMatchInitData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeEntryMatchInitData>.NativeClassPtr);
			ChallengeEntryMatchInitData.NativeFieldInfoPtr_Challenges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeEntryMatchInitData>.NativeClassPtr, "Challenges");
			ChallengeEntryMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_ChallengeDifficulties_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeEntryMatchInitData>.NativeClassPtr, 100665655);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00052C14 File Offset: 0x00050E14
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeEntryMatchInitData(Dictionary<DBGConstants.ChallengeDifficulties, MatchInitData> challenges)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeEntryMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenges);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeEntryMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_ChallengeDifficulties_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0000A1EF File Offset: 0x000083EF
		public ChallengeEntryMatchInitData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00052C60 File Offset: 0x00050E60
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x0000A1F8 File Offset: 0x000083F8
		public unsafe Dictionary<DBGConstants.ChallengeDifficulties, MatchInitData> Challenges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeEntryMatchInitData.NativeFieldInfoPtr_Challenges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DBGConstants.ChallengeDifficulties, MatchInitData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeEntryMatchInitData.NativeFieldInfoPtr_Challenges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_Challenges;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_ChallengeDifficulties_MatchInitData_0;
	}
}
