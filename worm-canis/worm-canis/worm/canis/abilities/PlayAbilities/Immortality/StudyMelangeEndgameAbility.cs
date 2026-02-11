using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.Immortality
{
	// Token: 0x02000466 RID: 1126
	public class StudyMelangeEndgameAbility : IntrigueAbility
	{
		// Token: 0x060031AE RID: 12718 RVA: 0x0012A8F8 File Offset: 0x00128AF8
		// Note: this type is marked as 'beforefieldinit'.
		static StudyMelangeEndgameAbility()
		{
			Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.Immortality", "StudyMelangeEndgameAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr);
			StudyMelangeEndgameAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, "AbilityName");
			StudyMelangeEndgameAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, "AbilityID");
			StudyMelangeEndgameAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, 100678640);
			StudyMelangeEndgameAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, 100678641);
			StudyMelangeEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, 100678642);
			StudyMelangeEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, 100678643);
			StudyMelangeEndgameAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, 100678644);
			StudyMelangeEndgameAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, 100678645);
			StudyMelangeEndgameAbility.NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, 100678646);
			StudyMelangeEndgameAbility.NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, 100678647);
			StudyMelangeEndgameAbility.NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, 100678648);
			StudyMelangeEndgameAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, 100678649);
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x0012AA18 File Offset: 0x00128C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228625, XrefRangeEnd = 228629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StudyMelangeEndgameAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x0012AA64 File Offset: 0x00128C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228629, XrefRangeEnd = 228635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StudyMelangeEndgameAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x0012AAC0 File Offset: 0x00128CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228635, XrefRangeEnd = 228648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StudyMelangeEndgameAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x0012AB0C File Offset: 0x00128D0C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 215283, RefRangeEnd = 215298, XrefRangeStart = 215283, XrefRangeEnd = 215298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StudyMelangeEndgameAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x0012AB7C File Offset: 0x00128D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228648, XrefRangeEnd = 228658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CostAction Cost(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StudyMelangeEndgameAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x0012ABEC File Offset: 0x00128DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228658, XrefRangeEnd = 228666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> RunImmediateEffects(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StudyMelangeEndgameAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x0012AC6C File Offset: 0x00128E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228666, XrefRangeEnd = 228671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeRunImmediateEffects(WormActiveAbility activeAbility, global::Canis.actions.Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StudyMelangeEndgameAbility.NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x0012ACD8 File Offset: 0x00128ED8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEndgamePlayable(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StudyMelangeEndgameAbility.NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x0012AD44 File Offset: 0x00128F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228671, XrefRangeEnd = 228687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<AccountID, int> GetConditionalEndgameVP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StudyMelangeEndgameAbility.NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, int>>(intPtr3) : null;
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x0012AD90 File Offset: 0x00128F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsBadIntrigue(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StudyMelangeEndgameAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x00011630 File Offset: 0x0000F830
		public StudyMelangeEndgameAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x0012ADFC File Offset: 0x00128FFC
		// (set) Token: 0x060031BB RID: 12731 RVA: 0x00011639 File Offset: 0x0000F839
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StudyMelangeEndgameAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StudyMelangeEndgameAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x0012AE1C File Offset: 0x0012901C
		// (set) Token: 0x060031BD RID: 12733 RVA: 0x0001164B File Offset: 0x0000F84B
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StudyMelangeEndgameAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StudyMelangeEndgameAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x02000AB8 RID: 2744
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.StudyMelangeEndgameAbility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600ACB2 RID: 44210 RVA: 0x002BD710 File Offset: 0x002BB910
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<StudyMelangeEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudyMelangeEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr);
				StudyMelangeEndgameAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr, "player");
				StudyMelangeEndgameAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr, 100678651);
				StudyMelangeEndgameAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr, 100678652);
			}

			// Token: 0x0600ACB3 RID: 44211 RVA: 0x002BD778 File Offset: 0x002BB978
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudyMelangeEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACB4 RID: 44212 RVA: 0x002BD7B4 File Offset: 0x002BB9B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228559, XrefRangeEnd = 228568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600ACB5 RID: 44213 RVA: 0x0004EC3E File Offset: 0x0004CE3E
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170034A7 RID: 13479
			// (get) Token: 0x0600ACB6 RID: 44214 RVA: 0x002BD804 File Offset: 0x002BBA04
			// (set) Token: 0x0600ACB7 RID: 44215 RVA: 0x0004EC47 File Offset: 0x0004CE47
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D1C RID: 27932
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006D1D RID: 27933
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006D1E RID: 27934
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000AB9 RID: 2745
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.StudyMelangeEndgameAbility+<RunImmediateEffects>d__7")]
		public sealed class _RunImmediateEffects_d__7 : Object
		{
			// Token: 0x0600ACB8 RID: 44216 RVA: 0x002BD834 File Offset: 0x002BBA34
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__7()
			{
				Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudyMelangeEndgameAbility>.NativeClassPtr, "<RunImmediateEffects>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr);
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>1__state");
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>2__current");
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>l__initialThreadId");
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "activeAbility");
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__activeAbility");
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>4__this");
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "match");
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__match");
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678653);
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678654);
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678655);
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678656);
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678657);
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678658);
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678659);
				StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678660);
			}

			// Token: 0x0600ACB9 RID: 44217 RVA: 0x002BD9A0 File Offset: 0x002BBBA0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudyMelangeEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600ACBA RID: 44218 RVA: 0x002BD9E8 File Offset: 0x002BBBE8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACBB RID: 44219 RVA: 0x002BDA1C File Offset: 0x002BBC1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228568, XrefRangeEnd = 228610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170034B0 RID: 13488
			// (get) Token: 0x0600ACBC RID: 44220 RVA: 0x002BDA58 File Offset: 0x002BBC58
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600ACBD RID: 44221 RVA: 0x002BDA98 File Offset: 0x002BBC98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228610, XrefRangeEnd = 228615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170034B1 RID: 13489
			// (get) Token: 0x0600ACBE RID: 44222 RVA: 0x002BDACC File Offset: 0x002BBCCC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ACBF RID: 44223 RVA: 0x002BDB0C File Offset: 0x002BBD0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228615, XrefRangeEnd = 228625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600ACC0 RID: 44224 RVA: 0x002BDB4C File Offset: 0x002BBD4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600ACC1 RID: 44225 RVA: 0x0004EC66 File Offset: 0x0004CE66
			public _RunImmediateEffects_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170034A8 RID: 13480
			// (get) Token: 0x0600ACC2 RID: 44226 RVA: 0x002BDB8C File Offset: 0x002BBD8C
			// (set) Token: 0x0600ACC3 RID: 44227 RVA: 0x0004EC6F File Offset: 0x0004CE6F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170034A9 RID: 13481
			// (get) Token: 0x0600ACC4 RID: 44228 RVA: 0x002BDBB4 File Offset: 0x002BBDB4
			// (set) Token: 0x0600ACC5 RID: 44229 RVA: 0x0004EC8A File Offset: 0x0004CE8A
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034AA RID: 13482
			// (get) Token: 0x0600ACC6 RID: 44230 RVA: 0x002BDBE4 File Offset: 0x002BBDE4
			// (set) Token: 0x0600ACC7 RID: 44231 RVA: 0x0004ECA9 File Offset: 0x0004CEA9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170034AB RID: 13483
			// (get) Token: 0x0600ACC8 RID: 44232 RVA: 0x002BDC0C File Offset: 0x002BBE0C
			// (set) Token: 0x0600ACC9 RID: 44233 RVA: 0x0004ECC4 File Offset: 0x0004CEC4
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034AC RID: 13484
			// (get) Token: 0x0600ACCA RID: 44234 RVA: 0x002BDC3C File Offset: 0x002BBE3C
			// (set) Token: 0x0600ACCB RID: 44235 RVA: 0x0004ECE3 File Offset: 0x0004CEE3
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034AD RID: 13485
			// (get) Token: 0x0600ACCC RID: 44236 RVA: 0x002BDC6C File Offset: 0x002BBE6C
			// (set) Token: 0x0600ACCD RID: 44237 RVA: 0x0004ED02 File Offset: 0x0004CF02
			public unsafe StudyMelangeEndgameAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StudyMelangeEndgameAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034AE RID: 13486
			// (get) Token: 0x0600ACCE RID: 44238 RVA: 0x002BDC9C File Offset: 0x002BBE9C
			// (set) Token: 0x0600ACCF RID: 44239 RVA: 0x0004ED21 File Offset: 0x0004CF21
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034AF RID: 13487
			// (get) Token: 0x0600ACD0 RID: 44240 RVA: 0x002BDCCC File Offset: 0x002BBECC
			// (set) Token: 0x0600ACD1 RID: 44241 RVA: 0x0004ED40 File Offset: 0x0004CF40
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StudyMelangeEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D1F RID: 27935
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006D20 RID: 27936
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006D21 RID: 27937
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006D22 RID: 27938
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006D23 RID: 27939
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006D24 RID: 27940
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006D25 RID: 27941
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006D26 RID: 27942
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006D27 RID: 27943
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006D28 RID: 27944
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D29 RID: 27945
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006D2A RID: 27946
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006D2B RID: 27947
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D2C RID: 27948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006D2D RID: 27949
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006D2E RID: 27950
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
