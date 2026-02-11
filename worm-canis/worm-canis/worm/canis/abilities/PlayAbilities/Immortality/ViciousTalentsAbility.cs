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
	// Token: 0x0200046C RID: 1132
	public class ViciousTalentsAbility : StrengthIntrigueAbility
	{
		// Token: 0x06003206 RID: 12806 RVA: 0x0012C4DC File Offset: 0x0012A6DC
		// Note: this type is marked as 'beforefieldinit'.
		static ViciousTalentsAbility()
		{
			Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.Immortality", "ViciousTalentsAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr);
			ViciousTalentsAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, "AbilityName");
			ViciousTalentsAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, "AbilityID");
			ViciousTalentsAbility.NativeFieldInfoPtr_LogToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, "LogToken");
			ViciousTalentsAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, 100678764);
			ViciousTalentsAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, 100678765);
			ViciousTalentsAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, 100678766);
			ViciousTalentsAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, 100678767);
			ViciousTalentsAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, 100678768);
			ViciousTalentsAbility.NativeMethodInfoPtr_CombatValue_Public_Virtual_Double_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, 100678769);
			ViciousTalentsAbility.NativeMethodInfoPtr_StrengthValue_Public_Virtual_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, 100678770);
			ViciousTalentsAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, 100678771);
			ViciousTalentsAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, 100678772);
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x0012C5FC File Offset: 0x0012A7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229484, XrefRangeEnd = 229488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViciousTalentsAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x0012C648 File Offset: 0x0012A848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229488, XrefRangeEnd = 229496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViciousTalentsAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x0012C6A4 File Offset: 0x0012A8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229496, XrefRangeEnd = 229499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViciousTalentsAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x0012C6F0 File Offset: 0x0012A8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViciousTalentsAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x0012C760 File Offset: 0x0012A960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229499, XrefRangeEnd = 229503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViciousTalentsAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x0012C7D0 File Offset: 0x0012A9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229503, XrefRangeEnd = 229504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double CombatValue(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViciousTalentsAbility.NativeMethodInfoPtr_CombatValue_Public_Virtual_Double_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x0012C828 File Offset: 0x0012AA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229504, XrefRangeEnd = 229505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int StrengthValue(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViciousTalentsAbility.NativeMethodInfoPtr_StrengthValue_Public_Virtual_Int32_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x0012C880 File Offset: 0x0012AA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229505, XrefRangeEnd = 229513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViciousTalentsAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x0012C900 File Offset: 0x0012AB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229513, XrefRangeEnd = 229533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShowHinting(WormMatch match, WormPlayer player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViciousTalentsAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x0001174D File Offset: 0x0000F94D
		public ViciousTalentsAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06003211 RID: 12817 RVA: 0x0012C96C File Offset: 0x0012AB6C
		// (set) Token: 0x06003212 RID: 12818 RVA: 0x00011756 File Offset: 0x0000F956
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ViciousTalentsAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViciousTalentsAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06003213 RID: 12819 RVA: 0x0012C98C File Offset: 0x0012AB8C
		// (set) Token: 0x06003214 RID: 12820 RVA: 0x00011768 File Offset: 0x0000F968
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ViciousTalentsAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViciousTalentsAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x0012C9B4 File Offset: 0x0012ABB4
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x0001177A File Offset: 0x0000F97A
		public unsafe static string LogToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ViciousTalentsAbility.NativeFieldInfoPtr_LogToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViciousTalentsAbility.NativeFieldInfoPtr_LogToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeFieldInfoPtr_LogToken;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeMethodInfoPtr_CombatValue_Public_Virtual_Double_WormPlayer_0;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeMethodInfoPtr_StrengthValue_Public_Virtual_Int32_WormPlayer_0;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x02000AC3 RID: 2755
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.ViciousTalentsAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600AD8F RID: 44431 RVA: 0x002BFF1C File Offset: 0x002BE11C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ViciousTalentsAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViciousTalentsAbility.__c>.NativeClassPtr);
				ViciousTalentsAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility.__c>.NativeClassPtr, "<>9");
				ViciousTalentsAbility.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility.__c>.NativeClassPtr, "<>9__11_0");
				ViciousTalentsAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility.__c>.NativeClassPtr, 100678775);
				ViciousTalentsAbility.__c.NativeMethodInfoPtr__ShowHinting_b__11_0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility.__c>.NativeClassPtr, 100678776);
			}

			// Token: 0x0600AD90 RID: 44432 RVA: 0x002BFF98 File Offset: 0x002BE198
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViciousTalentsAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD91 RID: 44433 RVA: 0x002BFFD4 File Offset: 0x002BE1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ShowHinting_b__11_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility.__c.NativeMethodInfoPtr__ShowHinting_b__11_0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AD92 RID: 44434 RVA: 0x0004F452 File Offset: 0x0004D652
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170034F8 RID: 13560
			// (get) Token: 0x0600AD93 RID: 44435 RVA: 0x002C0024 File Offset: 0x002BE224
			// (set) Token: 0x0600AD94 RID: 44436 RVA: 0x0004F45B File Offset: 0x0004D65B
			public unsafe static ViciousTalentsAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ViciousTalentsAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViciousTalentsAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ViciousTalentsAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034F9 RID: 13561
			// (get) Token: 0x0600AD95 RID: 44437 RVA: 0x002C004C File Offset: 0x002BE24C
			// (set) Token: 0x0600AD96 RID: 44438 RVA: 0x0004F46D File Offset: 0x0004D66D
			public unsafe static Func<WormPlayer, int> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ViciousTalentsAbility.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ViciousTalentsAbility.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006DA0 RID: 28064
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006DA1 RID: 28065
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04006DA2 RID: 28066
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006DA3 RID: 28067
			private static readonly IntPtr NativeMethodInfoPtr__ShowHinting_b__11_0_Internal_Int32_WormPlayer_0;
		}

		// Token: 0x02000AC4 RID: 2756
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.ViciousTalentsAbility+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600AD97 RID: 44439 RVA: 0x002C0074 File Offset: 0x002BE274
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<ViciousTalentsAbility.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViciousTalentsAbility.__c__DisplayClass10_0>.NativeClassPtr);
				ViciousTalentsAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_strengthToGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility.__c__DisplayClass10_0>.NativeClassPtr, "strengthToGain");
				ViciousTalentsAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility.__c__DisplayClass10_0>.NativeClassPtr, 100678777);
				ViciousTalentsAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility.__c__DisplayClass10_0>.NativeClassPtr, 100678778);
			}

			// Token: 0x0600AD98 RID: 44440 RVA: 0x002C00DC File Offset: 0x002BE2DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViciousTalentsAbility.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD99 RID: 44441 RVA: 0x002C0118 File Offset: 0x002BE318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229422, XrefRangeEnd = 229437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600AD9A RID: 44442 RVA: 0x0004F47F File Offset: 0x0004D67F
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170034FA RID: 13562
			// (get) Token: 0x0600AD9B RID: 44443 RVA: 0x002C0168 File Offset: 0x002BE368
			// (set) Token: 0x0600AD9C RID: 44444 RVA: 0x0004F488 File Offset: 0x0004D688
			public unsafe int strengthToGain
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_strengthToGain);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_strengthToGain)) = value;
				}
			}

			// Token: 0x04006DA4 RID: 28068
			private static readonly IntPtr NativeFieldInfoPtr_strengthToGain;

			// Token: 0x04006DA5 RID: 28069
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006DA6 RID: 28070
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000AC5 RID: 2757
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.ViciousTalentsAbility+<RunImmediateEffects>d__10")]
		public sealed class _RunImmediateEffects_d__10 : Object
		{
			// Token: 0x0600AD9D RID: 44445 RVA: 0x002C0190 File Offset: 0x002BE390
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__10()
			{
				Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ViciousTalentsAbility>.NativeClassPtr, "<RunImmediateEffects>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr);
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, "<>1__state");
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, "<>2__current");
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, "<>l__initialThreadId");
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, "activeAbility");
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, "<>3__activeAbility");
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, "<>4__this");
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, "match");
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, "<>3__match");
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, 100678779);
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, 100678780);
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, 100678781);
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, 100678782);
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, 100678783);
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, 100678784);
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, 100678785);
				ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr, 100678786);
			}

			// Token: 0x0600AD9E RID: 44446 RVA: 0x002C02FC File Offset: 0x002BE4FC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViciousTalentsAbility._RunImmediateEffects_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600AD9F RID: 44447 RVA: 0x002C0344 File Offset: 0x002BE544
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADA0 RID: 44448 RVA: 0x002C0378 File Offset: 0x002BE578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229437, XrefRangeEnd = 229469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003503 RID: 13571
			// (get) Token: 0x0600ADA1 RID: 44449 RVA: 0x002C03B4 File Offset: 0x002BE5B4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600ADA2 RID: 44450 RVA: 0x002C03F4 File Offset: 0x002BE5F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229469, XrefRangeEnd = 229474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003504 RID: 13572
			// (get) Token: 0x0600ADA3 RID: 44451 RVA: 0x002C0428 File Offset: 0x002BE628
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ADA4 RID: 44452 RVA: 0x002C0468 File Offset: 0x002BE668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229474, XrefRangeEnd = 229484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600ADA5 RID: 44453 RVA: 0x002C04A8 File Offset: 0x002BE6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600ADA6 RID: 44454 RVA: 0x0004F4A3 File Offset: 0x0004D6A3
			public _RunImmediateEffects_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170034FB RID: 13563
			// (get) Token: 0x0600ADA7 RID: 44455 RVA: 0x002C04E8 File Offset: 0x002BE6E8
			// (set) Token: 0x0600ADA8 RID: 44456 RVA: 0x0004F4AC File Offset: 0x0004D6AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170034FC RID: 13564
			// (get) Token: 0x0600ADA9 RID: 44457 RVA: 0x002C0510 File Offset: 0x002BE710
			// (set) Token: 0x0600ADAA RID: 44458 RVA: 0x0004F4C7 File Offset: 0x0004D6C7
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034FD RID: 13565
			// (get) Token: 0x0600ADAB RID: 44459 RVA: 0x002C0540 File Offset: 0x002BE740
			// (set) Token: 0x0600ADAC RID: 44460 RVA: 0x0004F4E6 File Offset: 0x0004D6E6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170034FE RID: 13566
			// (get) Token: 0x0600ADAD RID: 44461 RVA: 0x002C0568 File Offset: 0x002BE768
			// (set) Token: 0x0600ADAE RID: 44462 RVA: 0x0004F501 File Offset: 0x0004D701
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034FF RID: 13567
			// (get) Token: 0x0600ADAF RID: 44463 RVA: 0x002C0598 File Offset: 0x002BE798
			// (set) Token: 0x0600ADB0 RID: 44464 RVA: 0x0004F520 File Offset: 0x0004D720
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003500 RID: 13568
			// (get) Token: 0x0600ADB1 RID: 44465 RVA: 0x002C05C8 File Offset: 0x002BE7C8
			// (set) Token: 0x0600ADB2 RID: 44466 RVA: 0x0004F53F File Offset: 0x0004D73F
			public unsafe ViciousTalentsAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViciousTalentsAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003501 RID: 13569
			// (get) Token: 0x0600ADB3 RID: 44467 RVA: 0x002C05F8 File Offset: 0x002BE7F8
			// (set) Token: 0x0600ADB4 RID: 44468 RVA: 0x0004F55E File Offset: 0x0004D75E
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003502 RID: 13570
			// (get) Token: 0x0600ADB5 RID: 44469 RVA: 0x002C0628 File Offset: 0x002BE828
			// (set) Token: 0x0600ADB6 RID: 44470 RVA: 0x0004F57D File Offset: 0x0004D77D
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViciousTalentsAbility._RunImmediateEffects_d__10.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006DA7 RID: 28071
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006DA8 RID: 28072
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006DA9 RID: 28073
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006DAA RID: 28074
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006DAB RID: 28075
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006DAC RID: 28076
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006DAD RID: 28077
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006DAE RID: 28078
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006DAF RID: 28079
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006DB0 RID: 28080
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006DB1 RID: 28081
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006DB2 RID: 28082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006DB3 RID: 28083
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006DB4 RID: 28084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006DB5 RID: 28085
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006DB6 RID: 28086
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
