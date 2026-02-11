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
	// Token: 0x02000469 RID: 1129
	public class TleilaxuPuppetEndgameAbility : IntrigueAbility
	{
		// Token: 0x060031D6 RID: 12758 RVA: 0x0012B508 File Offset: 0x00129708
		// Note: this type is marked as 'beforefieldinit'.
		static TleilaxuPuppetEndgameAbility()
		{
			Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.Immortality", "TleilaxuPuppetEndgameAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr);
			TleilaxuPuppetEndgameAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, "AbilityName");
			TleilaxuPuppetEndgameAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, "AbilityID");
			TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, 100678683);
			TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, 100678684);
			TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, 100678685);
			TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, 100678686);
			TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, 100678687);
			TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, 100678688);
			TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, 100678689);
			TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, 100678690);
			TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, 100678691);
			TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, 100678692);
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x0012B628 File Offset: 0x00129828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228865, XrefRangeEnd = 228869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x0012B674 File Offset: 0x00129874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228869, XrefRangeEnd = 228875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x0012B6D0 File Offset: 0x001298D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228875, XrefRangeEnd = 228888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TleilaxuPuppetEndgameAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x0012B71C File Offset: 0x0012991C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 215283, RefRangeEnd = 215298, XrefRangeStart = 215283, XrefRangeEnd = 215298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TleilaxuPuppetEndgameAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x0012B78C File Offset: 0x0012998C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228888, XrefRangeEnd = 228897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x0012B7FC File Offset: 0x001299FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228897, XrefRangeEnd = 228905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x0012B87C File Offset: 0x00129A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228905, XrefRangeEnd = 228910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x0012B8E8 File Offset: 0x00129AE8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0012B954 File Offset: 0x00129B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228910, XrefRangeEnd = 228932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<AccountID, int> GetConditionalEndgameVP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, int>>(intPtr3) : null;
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x0012B9A0 File Offset: 0x00129BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228932, XrefRangeEnd = 228935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TleilaxuPuppetEndgameAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x000116B7 File Offset: 0x0000F8B7
		public TleilaxuPuppetEndgameAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x0012BA0C File Offset: 0x00129C0C
		// (set) Token: 0x060031E3 RID: 12771 RVA: 0x000116C0 File Offset: 0x0000F8C0
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TleilaxuPuppetEndgameAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TleilaxuPuppetEndgameAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x0012BA2C File Offset: 0x00129C2C
		// (set) Token: 0x060031E5 RID: 12773 RVA: 0x000116D2 File Offset: 0x0000F8D2
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TleilaxuPuppetEndgameAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TleilaxuPuppetEndgameAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr_ResumeRunImmediateEffects_Protected_Virtual_Int32_WormActiveAbility_Action_0;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_Dictionary_2_AccountID_Int32_0;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x02000ABB RID: 2747
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.TleilaxuPuppetEndgameAbility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600ACEA RID: 44266 RVA: 0x002BE180 File Offset: 0x002BC380
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr);
				TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr, "player");
				TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr, 100678694);
				TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr, 100678695);
			}

			// Token: 0x0600ACEB RID: 44267 RVA: 0x002BE1E8 File Offset: 0x002BC3E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACEC RID: 44268 RVA: 0x002BE224 File Offset: 0x002BC424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228799, XrefRangeEnd = 228808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600ACED RID: 44269 RVA: 0x0004EE39 File Offset: 0x0004D039
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170034BB RID: 13499
			// (get) Token: 0x0600ACEE RID: 44270 RVA: 0x002BE274 File Offset: 0x002BC474
			// (set) Token: 0x0600ACEF RID: 44271 RVA: 0x0004EE42 File Offset: 0x0004D042
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D3E RID: 27966
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006D3F RID: 27967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006D40 RID: 27968
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000ABC RID: 2748
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.TleilaxuPuppetEndgameAbility+<RunImmediateEffects>d__7")]
		public sealed class _RunImmediateEffects_d__7 : Object
		{
			// Token: 0x0600ACF0 RID: 44272 RVA: 0x002BE2A4 File Offset: 0x002BC4A4
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__7()
			{
				Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility>.NativeClassPtr, "<RunImmediateEffects>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr);
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>1__state");
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>2__current");
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>l__initialThreadId");
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "activeAbility");
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__activeAbility");
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>4__this");
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "match");
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__match");
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678696);
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678697);
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678698);
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678699);
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678700);
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678701);
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678702);
				TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100678703);
			}

			// Token: 0x0600ACF1 RID: 44273 RVA: 0x002BE410 File Offset: 0x002BC610
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600ACF2 RID: 44274 RVA: 0x002BE458 File Offset: 0x002BC658
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACF3 RID: 44275 RVA: 0x002BE48C File Offset: 0x002BC68C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228808, XrefRangeEnd = 228850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170034C4 RID: 13508
			// (get) Token: 0x0600ACF4 RID: 44276 RVA: 0x002BE4C8 File Offset: 0x002BC6C8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600ACF5 RID: 44277 RVA: 0x002BE508 File Offset: 0x002BC708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228850, XrefRangeEnd = 228855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170034C5 RID: 13509
			// (get) Token: 0x0600ACF6 RID: 44278 RVA: 0x002BE53C File Offset: 0x002BC73C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ACF7 RID: 44279 RVA: 0x002BE57C File Offset: 0x002BC77C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228855, XrefRangeEnd = 228865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600ACF8 RID: 44280 RVA: 0x002BE5BC File Offset: 0x002BC7BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600ACF9 RID: 44281 RVA: 0x0004EE61 File Offset: 0x0004D061
			public _RunImmediateEffects_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170034BC RID: 13500
			// (get) Token: 0x0600ACFA RID: 44282 RVA: 0x002BE5FC File Offset: 0x002BC7FC
			// (set) Token: 0x0600ACFB RID: 44283 RVA: 0x0004EE6A File Offset: 0x0004D06A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170034BD RID: 13501
			// (get) Token: 0x0600ACFC RID: 44284 RVA: 0x002BE624 File Offset: 0x002BC824
			// (set) Token: 0x0600ACFD RID: 44285 RVA: 0x0004EE85 File Offset: 0x0004D085
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034BE RID: 13502
			// (get) Token: 0x0600ACFE RID: 44286 RVA: 0x002BE654 File Offset: 0x002BC854
			// (set) Token: 0x0600ACFF RID: 44287 RVA: 0x0004EEA4 File Offset: 0x0004D0A4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170034BF RID: 13503
			// (get) Token: 0x0600AD00 RID: 44288 RVA: 0x002BE67C File Offset: 0x002BC87C
			// (set) Token: 0x0600AD01 RID: 44289 RVA: 0x0004EEBF File Offset: 0x0004D0BF
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C0 RID: 13504
			// (get) Token: 0x0600AD02 RID: 44290 RVA: 0x002BE6AC File Offset: 0x002BC8AC
			// (set) Token: 0x0600AD03 RID: 44291 RVA: 0x0004EEDE File Offset: 0x0004D0DE
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C1 RID: 13505
			// (get) Token: 0x0600AD04 RID: 44292 RVA: 0x002BE6DC File Offset: 0x002BC8DC
			// (set) Token: 0x0600AD05 RID: 44293 RVA: 0x0004EEFD File Offset: 0x0004D0FD
			public unsafe TleilaxuPuppetEndgameAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TleilaxuPuppetEndgameAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C2 RID: 13506
			// (get) Token: 0x0600AD06 RID: 44294 RVA: 0x002BE70C File Offset: 0x002BC90C
			// (set) Token: 0x0600AD07 RID: 44295 RVA: 0x0004EF1C File Offset: 0x0004D11C
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C3 RID: 13507
			// (get) Token: 0x0600AD08 RID: 44296 RVA: 0x002BE73C File Offset: 0x002BC93C
			// (set) Token: 0x0600AD09 RID: 44297 RVA: 0x0004EF3B File Offset: 0x0004D13B
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TleilaxuPuppetEndgameAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D41 RID: 27969
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006D42 RID: 27970
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006D43 RID: 27971
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006D44 RID: 27972
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006D45 RID: 27973
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006D46 RID: 27974
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006D47 RID: 27975
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006D48 RID: 27976
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006D49 RID: 27977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006D4A RID: 27978
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D4B RID: 27979
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006D4C RID: 27980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006D4D RID: 27981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D4E RID: 27982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006D4F RID: 27983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006D50 RID: 27984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
