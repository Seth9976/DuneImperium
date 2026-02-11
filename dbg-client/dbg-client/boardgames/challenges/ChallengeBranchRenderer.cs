using System;
using boardgames.data;
using boardgames.utils;
using Canis;
using dwd.core.data;
using dwd.core.data.composition;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.challenges
{
	// Token: 0x02000126 RID: 294
	public class ChallengeBranchRenderer : Subscriber<ChallengeEntryMatchInitData>
	{
		// Token: 0x06000D11 RID: 3345 RVA: 0x00046BE8 File Offset: 0x00044DE8
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeBranchRenderer()
		{
			Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.challenges", "ChallengeBranchRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr);
			ChallengeBranchRenderer.NativeFieldInfoPtr_challengeEasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, "challengeEasy");
			ChallengeBranchRenderer.NativeFieldInfoPtr_challengeMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, "challengeMedium");
			ChallengeBranchRenderer.NativeFieldInfoPtr_challengeHard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, "challengeHard");
			ChallengeBranchRenderer.NativeFieldInfoPtr_initialChallengeGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, "initialChallengeGameID");
			ChallengeBranchRenderer.NativeFieldInfoPtr_selectedChallengeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, "selectedChallengeData");
			ChallengeBranchRenderer.NativeFieldInfoPtr_productUtil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, "productUtil");
			ChallengeBranchRenderer.NativeFieldInfoPtr_iapStoreBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, "iapStoreBehaviour");
			ChallengeBranchRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, 100665187);
			ChallengeBranchRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, 100665188);
			ChallengeBranchRenderer.NativeMethodInfoPtr_SelectChallenge_Public_Void_ChallengeDifficulties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, 100665189);
			ChallengeBranchRenderer.NativeMethodInfoPtr_GetChallengeFromDifficulty_Public_MatchInitData_ChallengeDifficulties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, 100665190);
			ChallengeBranchRenderer.NativeMethodInfoPtr_setupChallengeData_Protected_Virtual_New_DataComposition_ChallengeDifficulties_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, 100665191);
			ChallengeBranchRenderer.NativeMethodInfoPtr_MeetOwnershipRequirements_Protected_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, 100665192);
			ChallengeBranchRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, 100665193);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00046D30 File Offset: 0x00044F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510422, XrefRangeEnd = 510444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeBranchRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00046D6C File Offset: 0x00044F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510444, XrefRangeEnd = 510498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeBranchRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00046DA8 File Offset: 0x00044FA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 510504, RefRangeEnd = 510507, XrefRangeStart = 510498, XrefRangeEnd = 510504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectChallenge(DBGConstants.ChallengeDifficulties difficulty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref difficulty;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeBranchRenderer.NativeMethodInfoPtr_SelectChallenge_Public_Void_ChallengeDifficulties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00046DE8 File Offset: 0x00044FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510507, XrefRangeEnd = 510513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchInitData GetChallengeFromDifficulty(DBGConstants.ChallengeDifficulties difficulty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref difficulty;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeBranchRenderer.NativeMethodInfoPtr_GetChallengeFromDifficulty_Public_MatchInitData_ChallengeDifficulties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00046E34 File Offset: 0x00045034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510513, XrefRangeEnd = 510571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataComposition setupChallengeData(DBGConstants.ChallengeDifficulties difficulty, MatchInitData challenge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref difficulty;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeBranchRenderer.NativeMethodInfoPtr_setupChallengeData_Protected_Virtual_New_DataComposition_ChallengeDifficulties_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00046EA0 File Offset: 0x000450A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510598, RefRangeEnd = 510599, XrefRangeStart = 510571, XrefRangeEnd = 510598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MeetOwnershipRequirements(MatchInitData challenge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeBranchRenderer.NativeMethodInfoPtr_MeetOwnershipRequirements_Protected_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00046EF0 File Offset: 0x000450F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510599, XrefRangeEnd = 510605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeBranchRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeBranchRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0000854B File Offset: 0x0000674B
		public ChallengeBranchRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00046F2C File Offset: 0x0004512C
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00008554 File Offset: 0x00006754
		public unsafe SubscriptionProvider challengeEasy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_challengeEasy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_challengeEasy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00046F5C File Offset: 0x0004515C
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x00008573 File Offset: 0x00006773
		public unsafe SubscriptionProvider challengeMedium
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_challengeMedium);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_challengeMedium), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00046F8C File Offset: 0x0004518C
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00008592 File Offset: 0x00006792
		public unsafe SubscriptionProvider challengeHard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_challengeHard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_challengeHard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00046FBC File Offset: 0x000451BC
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x000085B1 File Offset: 0x000067B1
		public unsafe string initialChallengeGameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_initialChallengeGameID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_initialChallengeGameID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x00046FE4 File Offset: 0x000451E4
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x000085D0 File Offset: 0x000067D0
		public unsafe SelectedData<MatchInitData> selectedChallengeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_selectedChallengeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedData<MatchInitData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_selectedChallengeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00047014 File Offset: 0x00045214
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x000085EF File Offset: 0x000067EF
		public unsafe ProductUtils productUtil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_productUtil);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductUtils>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_productUtil), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00047044 File Offset: 0x00045244
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x0000860E File Offset: 0x0000680E
		public unsafe IAPStoreBehaviour iapStoreBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_iapStoreBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeBranchRenderer.NativeFieldInfoPtr_iapStoreBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_challengeEasy;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_challengeMedium;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_challengeHard;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_initialChallengeGameID;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_selectedChallengeData;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr_productUtil;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr_iapStoreBehaviour;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_SelectChallenge_Public_Void_ChallengeDifficulties_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_GetChallengeFromDifficulty_Public_MatchInitData_ChallengeDifficulties_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_setupChallengeData_Protected_Virtual_New_DataComposition_ChallengeDifficulties_MatchInitData_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_MeetOwnershipRequirements_Protected_Boolean_MatchInitData_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000355 RID: 853
		[ObfuscatedName("boardgames.challenges.ChallengeBranchRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002840 RID: 10304 RVA: 0x000A0F90 File Offset: 0x0009F190
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ChallengeBranchRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChallengeBranchRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeBranchRenderer.__c>.NativeClassPtr);
				ChallengeBranchRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeBranchRenderer.__c>.NativeClassPtr, "<>9");
				ChallengeBranchRenderer.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeBranchRenderer.__c>.NativeClassPtr, "<>9__11_0");
				ChallengeBranchRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeBranchRenderer.__c>.NativeClassPtr, 100665195);
				ChallengeBranchRenderer.__c.NativeMethodInfoPtr__setupChallengeData_b__11_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeBranchRenderer.__c>.NativeClassPtr, 100665196);
			}

			// Token: 0x06002841 RID: 10305 RVA: 0x000A100C File Offset: 0x0009F20C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeBranchRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeBranchRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002842 RID: 10306 RVA: 0x000A1048 File Offset: 0x0009F248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510421, XrefRangeEnd = 510422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _setupChallengeData_b__11_0(string scenarioName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(scenarioName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeBranchRenderer.__c.NativeMethodInfoPtr__setupChallengeData_b__11_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002843 RID: 10307 RVA: 0x00014D00 File Offset: 0x00012F00
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B41 RID: 2881
			// (get) Token: 0x06002844 RID: 10308 RVA: 0x000A1098 File Offset: 0x0009F298
			// (set) Token: 0x06002845 RID: 10309 RVA: 0x00014D09 File Offset: 0x00012F09
			public unsafe static ChallengeBranchRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChallengeBranchRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengeBranchRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChallengeBranchRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B42 RID: 2882
			// (get) Token: 0x06002846 RID: 10310 RVA: 0x000A10C0 File Offset: 0x0009F2C0
			// (set) Token: 0x06002847 RID: 10311 RVA: 0x00014D1B File Offset: 0x00012F1B
			public unsafe static Func<string, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ChallengeBranchRenderer.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChallengeBranchRenderer.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400193A RID: 6458
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400193B RID: 6459
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400193C RID: 6460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400193D RID: 6461
			private static readonly IntPtr NativeMethodInfoPtr__setupChallengeData_b__11_0_Internal_Boolean_String_0;
		}
	}
}
