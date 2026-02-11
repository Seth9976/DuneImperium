using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace offlineChallenges
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class ChallengesModel : Object
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00004A0C File Offset: 0x00002C0C
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengesModel()
		{
			Il2CppClassPointerStore<ChallengesModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges", "ChallengesModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengesModel>.NativeClassPtr);
			ChallengesModel.NativeFieldInfoPtr_challenges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengesModel>.NativeClassPtr, "challenges");
			ChallengesModel.NativeMethodInfoPtr_Add_Public_Void_ChallengeModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesModel>.NativeClassPtr, 100663400);
			ChallengesModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengesModel>.NativeClassPtr, 100663401);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004A78 File Offset: 0x00002C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261123, RefRangeEnd = 1261124, XrefRangeStart = 1261117, XrefRangeEnd = 1261123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(ChallengeModel data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesModel.NativeMethodInfoPtr_Add_Public_Void_ChallengeModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004ABC File Offset: 0x00002CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261124, XrefRangeEnd = 1261132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengesModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengesModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengesModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000022F1 File Offset: 0x000004F1
		public ChallengesModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00004AF8 File Offset: 0x00002CF8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000022FA File Offset: 0x000004FA
		public unsafe List<ChallengeModel> challenges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesModel.NativeFieldInfoPtr_challenges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChallengeModel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengesModel.NativeFieldInfoPtr_challenges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_challenges;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_ChallengeModel_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
