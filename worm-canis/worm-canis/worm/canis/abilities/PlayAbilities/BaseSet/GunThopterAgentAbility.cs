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

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x02000484 RID: 1156
	public class GunThopterAgentAbility : AgentAbility
	{
		// Token: 0x0600336B RID: 13163 RVA: 0x001334A4 File Offset: 0x001316A4
		// Note: this type is marked as 'beforefieldinit'.
		static GunThopterAgentAbility()
		{
			Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "GunThopterAgentAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr);
			GunThopterAgentAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, "AbilityName");
			GunThopterAgentAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, "AbilityID");
			GunThopterAgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, 100679340);
			GunThopterAgentAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, 100679341);
			GunThopterAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, 100679342);
			GunThopterAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, 100679343);
			GunThopterAgentAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, 100679344);
			GunThopterAgentAbility.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, 100679345);
			GunThopterAgentAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, 100679347);
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00133588 File Offset: 0x00131788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235030, XrefRangeEnd = 235034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GunThopterAgentAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x001335D4 File Offset: 0x001317D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235034, XrefRangeEnd = 235040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GunThopterAgentAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x00133630 File Offset: 0x00131830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235040, XrefRangeEnd = 235046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GunThopterAgentAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x0013367C File Offset: 0x0013187C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235046, XrefRangeEnd = 235050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GunThopterAgentAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x001336EC File Offset: 0x001318EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235050, XrefRangeEnd = 235059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GunThopterAgentAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x0013376C File Offset: 0x0013196C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235059, XrefRangeEnd = 235067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> Undo(UndoNode node, PlayerEntity player, Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility.NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x001337F4 File Offset: 0x001319F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> __n__0(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x00011BF4 File Offset: 0x0000FDF4
		public GunThopterAgentAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06003374 RID: 13172 RVA: 0x00133868 File Offset: 0x00131A68
		// (set) Token: 0x06003375 RID: 13173 RVA: 0x00011BFD File Offset: 0x0000FDFD
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GunThopterAgentAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GunThopterAgentAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06003376 RID: 13174 RVA: 0x00133888 File Offset: 0x00131A88
		// (set) Token: 0x06003377 RID: 13175 RVA: 0x00011C0F File Offset: 0x0000FE0F
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GunThopterAgentAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GunThopterAgentAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_Final_New_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000B01 RID: 2817
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.GunThopterAgentAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600B207 RID: 45575 RVA: 0x002CD07C File Offset: 0x002CB27C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GunThopterAgentAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunThopterAgentAbility.__c>.NativeClassPtr);
				GunThopterAgentAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility.__c>.NativeClassPtr, "<>9");
				GunThopterAgentAbility.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility.__c>.NativeClassPtr, "<>9__6_0");
				GunThopterAgentAbility.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility.__c>.NativeClassPtr, "<>9__6_1");
				GunThopterAgentAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility.__c>.NativeClassPtr, 100679349);
				GunThopterAgentAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__6_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility.__c>.NativeClassPtr, 100679350);
				GunThopterAgentAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__6_1_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility.__c>.NativeClassPtr, 100679351);
			}

			// Token: 0x0600B208 RID: 45576 RVA: 0x002CD120 File Offset: 0x002CB320
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunThopterAgentAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B209 RID: 45577 RVA: 0x002CD15C File Offset: 0x002CB35C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234744, XrefRangeEnd = 234745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunImmediateEffects_b__6_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__6_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B20A RID: 45578 RVA: 0x002CD1AC File Offset: 0x002CB3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234745, XrefRangeEnd = 234747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__6_1(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__6_1_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600B20B RID: 45579 RVA: 0x00051C1C File Offset: 0x0004FE1C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003685 RID: 13957
			// (get) Token: 0x0600B20C RID: 45580 RVA: 0x002CD1FC File Offset: 0x002CB3FC
			// (set) Token: 0x0600B20D RID: 45581 RVA: 0x00051C25 File Offset: 0x0004FE25
			public unsafe static GunThopterAgentAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GunThopterAgentAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GunThopterAgentAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GunThopterAgentAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003686 RID: 13958
			// (get) Token: 0x0600B20E RID: 45582 RVA: 0x002CD224 File Offset: 0x002CB424
			// (set) Token: 0x0600B20F RID: 45583 RVA: 0x00051C37 File Offset: 0x0004FE37
			public unsafe static Func<Entity, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GunThopterAgentAbility.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GunThopterAgentAbility.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003687 RID: 13959
			// (get) Token: 0x0600B210 RID: 45584 RVA: 0x002CD24C File Offset: 0x002CB44C
			// (set) Token: 0x0600B211 RID: 45585 RVA: 0x00051C49 File Offset: 0x0004FE49
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GunThopterAgentAbility.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GunThopterAgentAbility.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007045 RID: 28741
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007046 RID: 28742
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04007047 RID: 28743
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04007048 RID: 28744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007049 RID: 28745
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__6_0_Internal_Boolean_Entity_0;

			// Token: 0x0400704A RID: 28746
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__6_1_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000B02 RID: 2818
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.GunThopterAgentAbility+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600B212 RID: 45586 RVA: 0x002CD274 File Offset: 0x002CB474
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<GunThopterAgentAbility.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunThopterAgentAbility.__c__DisplayClass6_0>.NativeClassPtr);
				GunThopterAgentAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_opponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility.__c__DisplayClass6_0>.NativeClassPtr, "opponent");
				GunThopterAgentAbility.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				GunThopterAgentAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility.__c__DisplayClass6_0>.NativeClassPtr, 100679352);
				GunThopterAgentAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__RunImmediateEffects_b__2_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility.__c__DisplayClass6_0>.NativeClassPtr, 100679353);
			}

			// Token: 0x0600B213 RID: 45587 RVA: 0x002CD2F0 File Offset: 0x002CB4F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunThopterAgentAbility.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B214 RID: 45588 RVA: 0x002CD32C File Offset: 0x002CB52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234747, XrefRangeEnd = 234757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__2(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__RunImmediateEffects_b__2_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600B215 RID: 45589 RVA: 0x00051C5B File Offset: 0x0004FE5B
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003688 RID: 13960
			// (get) Token: 0x0600B216 RID: 45590 RVA: 0x002CD37C File Offset: 0x002CB57C
			// (set) Token: 0x0600B217 RID: 45591 RVA: 0x00051C64 File Offset: 0x0004FE64
			public unsafe WormPlayer opponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_opponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_opponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003689 RID: 13961
			// (get) Token: 0x0600B218 RID: 45592 RVA: 0x002CD3AC File Offset: 0x002CB5AC
			// (set) Token: 0x0600B219 RID: 45593 RVA: 0x00051C83 File Offset: 0x0004FE83
			public unsafe GunThopterAgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GunThopterAgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400704B RID: 28747
			private static readonly IntPtr NativeFieldInfoPtr_opponent;

			// Token: 0x0400704C RID: 28748
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400704D RID: 28749
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400704E RID: 28750
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__2_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000B03 RID: 2819
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.GunThopterAgentAbility+<RunImmediateEffects>d__6")]
		public sealed class _RunImmediateEffects_d__6 : Object
		{
			// Token: 0x0600B21A RID: 45594 RVA: 0x002CD3DC File Offset: 0x002CB5DC
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__6()
			{
				Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, "<RunImmediateEffects>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr);
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>1__state");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>2__current");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>l__initialThreadId");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "activeAbility");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>3__activeAbility");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>4__this");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "match");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>3__match");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>8__1");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "context");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>3__context");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>7__wrap1");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__garrisonedTroop_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<garrisonedTroop>5__3");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, "<>7__wrap3");
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100679354);
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100679355);
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100679356);
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100679357);
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100679358);
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100679359);
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100679360);
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100679361);
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100679362);
				GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr, 100679363);
			}

			// Token: 0x0600B21B RID: 45595 RVA: 0x002CD5E8 File Offset: 0x002CB7E8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunThopterAgentAbility._RunImmediateEffects_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B21C RID: 45596 RVA: 0x002CD630 File Offset: 0x002CB830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234757, XrefRangeEnd = 234767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B21D RID: 45597 RVA: 0x002CD664 File Offset: 0x002CB864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234767, XrefRangeEnd = 234926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B21E RID: 45598 RVA: 0x002CD6A0 File Offset: 0x002CB8A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234926, XrefRangeEnd = 234929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B21F RID: 45599 RVA: 0x002CD6D4 File Offset: 0x002CB8D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234929, XrefRangeEnd = 234932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003698 RID: 13976
			// (get) Token: 0x0600B220 RID: 45600 RVA: 0x002CD708 File Offset: 0x002CB908
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B221 RID: 45601 RVA: 0x002CD748 File Offset: 0x002CB948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234932, XrefRangeEnd = 234937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003699 RID: 13977
			// (get) Token: 0x0600B222 RID: 45602 RVA: 0x002CD77C File Offset: 0x002CB97C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B223 RID: 45603 RVA: 0x002CD7BC File Offset: 0x002CB9BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234937, XrefRangeEnd = 234948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B224 RID: 45604 RVA: 0x002CD7FC File Offset: 0x002CB9FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B225 RID: 45605 RVA: 0x00051CA2 File Offset: 0x0004FEA2
			public _RunImmediateEffects_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700368A RID: 13962
			// (get) Token: 0x0600B226 RID: 45606 RVA: 0x002CD83C File Offset: 0x002CBA3C
			// (set) Token: 0x0600B227 RID: 45607 RVA: 0x00051CAB File Offset: 0x0004FEAB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700368B RID: 13963
			// (get) Token: 0x0600B228 RID: 45608 RVA: 0x002CD864 File Offset: 0x002CBA64
			// (set) Token: 0x0600B229 RID: 45609 RVA: 0x00051CC6 File Offset: 0x0004FEC6
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700368C RID: 13964
			// (get) Token: 0x0600B22A RID: 45610 RVA: 0x002CD894 File Offset: 0x002CBA94
			// (set) Token: 0x0600B22B RID: 45611 RVA: 0x00051CE5 File Offset: 0x0004FEE5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700368D RID: 13965
			// (get) Token: 0x0600B22C RID: 45612 RVA: 0x002CD8BC File Offset: 0x002CBABC
			// (set) Token: 0x0600B22D RID: 45613 RVA: 0x00051D00 File Offset: 0x0004FF00
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700368E RID: 13966
			// (get) Token: 0x0600B22E RID: 45614 RVA: 0x002CD8EC File Offset: 0x002CBAEC
			// (set) Token: 0x0600B22F RID: 45615 RVA: 0x00051D1F File Offset: 0x0004FF1F
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700368F RID: 13967
			// (get) Token: 0x0600B230 RID: 45616 RVA: 0x002CD91C File Offset: 0x002CBB1C
			// (set) Token: 0x0600B231 RID: 45617 RVA: 0x00051D3E File Offset: 0x0004FF3E
			public unsafe GunThopterAgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GunThopterAgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003690 RID: 13968
			// (get) Token: 0x0600B232 RID: 45618 RVA: 0x002CD94C File Offset: 0x002CBB4C
			// (set) Token: 0x0600B233 RID: 45619 RVA: 0x00051D5D File Offset: 0x0004FF5D
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003691 RID: 13969
			// (get) Token: 0x0600B234 RID: 45620 RVA: 0x002CD97C File Offset: 0x002CBB7C
			// (set) Token: 0x0600B235 RID: 45621 RVA: 0x00051D7C File Offset: 0x0004FF7C
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003692 RID: 13970
			// (get) Token: 0x0600B236 RID: 45622 RVA: 0x002CD9AC File Offset: 0x002CBBAC
			// (set) Token: 0x0600B237 RID: 45623 RVA: 0x00051D9B File Offset: 0x0004FF9B
			public unsafe GunThopterAgentAbility.__c__DisplayClass6_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GunThopterAgentAbility.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003693 RID: 13971
			// (get) Token: 0x0600B238 RID: 45624 RVA: 0x002CD9DC File Offset: 0x002CBBDC
			// (set) Token: 0x0600B239 RID: 45625 RVA: 0x00051DBA File Offset: 0x0004FFBA
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003694 RID: 13972
			// (get) Token: 0x0600B23A RID: 45626 RVA: 0x002CDA0C File Offset: 0x002CBC0C
			// (set) Token: 0x0600B23B RID: 45627 RVA: 0x00051DD9 File Offset: 0x0004FFD9
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003695 RID: 13973
			// (get) Token: 0x0600B23C RID: 45628 RVA: 0x002CDA3C File Offset: 0x002CBC3C
			// (set) Token: 0x0600B23D RID: 45629 RVA: 0x00051DF8 File Offset: 0x0004FFF8
			public unsafe IEnumerator<WormPlayer> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003696 RID: 13974
			// (get) Token: 0x0600B23E RID: 45630 RVA: 0x002CDA6C File Offset: 0x002CBC6C
			// (set) Token: 0x0600B23F RID: 45631 RVA: 0x00051E17 File Offset: 0x00050017
			public unsafe Entity _garrisonedTroop_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__garrisonedTroop_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr__garrisonedTroop_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003697 RID: 13975
			// (get) Token: 0x0600B240 RID: 45632 RVA: 0x002CDA9C File Offset: 0x002CBC9C
			// (set) Token: 0x0600B241 RID: 45633 RVA: 0x00051E36 File Offset: 0x00050036
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._RunImmediateEffects_d__6.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400704F RID: 28751
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007050 RID: 28752
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007051 RID: 28753
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007052 RID: 28754
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04007053 RID: 28755
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04007054 RID: 28756
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007055 RID: 28757
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007056 RID: 28758
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007057 RID: 28759
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04007058 RID: 28760
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007059 RID: 28761
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400705A RID: 28762
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400705B RID: 28763
			private static readonly IntPtr NativeFieldInfoPtr__garrisonedTroop_5__3;

			// Token: 0x0400705C RID: 28764
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400705D RID: 28765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400705E RID: 28766
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400705F RID: 28767
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007060 RID: 28768
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007061 RID: 28769
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04007062 RID: 28770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04007063 RID: 28771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007064 RID: 28772
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007065 RID: 28773
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007066 RID: 28774
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000B04 RID: 2820
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.GunThopterAgentAbility+<Undo>d__7")]
		public sealed class _Undo_d__7 : Object
		{
			// Token: 0x0600B242 RID: 45634 RVA: 0x002CDACC File Offset: 0x002CBCCC
			// Note: this type is marked as 'beforefieldinit'.
			static _Undo_d__7()
			{
				Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GunThopterAgentAbility>.NativeClassPtr, "<Undo>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr);
				GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, "<>1__state");
				GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, "<>2__current");
				GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, "<>l__initialThreadId");
				GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, "node");
				GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___3__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, "<>3__node");
				GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, "match");
				GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, "<>3__match");
				GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, "<>4__this");
				GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, "<>7__wrap1");
				GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, 100679364);
				GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, 100679365);
				GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, 100679366);
				GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, 100679367);
				GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, 100679368);
				GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, 100679369);
				GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, 100679370);
				GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, 100679371);
				GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr, 100679372);
			}

			// Token: 0x0600B243 RID: 45635 RVA: 0x002CDC60 File Offset: 0x002CBE60
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Undo_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunThopterAgentAbility._Undo_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B244 RID: 45636 RVA: 0x002CDCA8 File Offset: 0x002CBEA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234948, XrefRangeEnd = 234953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B245 RID: 45637 RVA: 0x002CDCDC File Offset: 0x002CBEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234953, XrefRangeEnd = 235012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B246 RID: 45638 RVA: 0x002CDD18 File Offset: 0x002CBF18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235012, XrefRangeEnd = 235015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170036A3 RID: 13987
			// (get) Token: 0x0600B247 RID: 45639 RVA: 0x002CDD4C File Offset: 0x002CBF4C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B248 RID: 45640 RVA: 0x002CDD8C File Offset: 0x002CBF8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235015, XrefRangeEnd = 235020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170036A4 RID: 13988
			// (get) Token: 0x0600B249 RID: 45641 RVA: 0x002CDDC0 File Offset: 0x002CBFC0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B24A RID: 45642 RVA: 0x002CDE00 File Offset: 0x002CC000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235020, XrefRangeEnd = 235030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B24B RID: 45643 RVA: 0x002CDE40 File Offset: 0x002CC040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunThopterAgentAbility._Undo_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B24C RID: 45644 RVA: 0x00051E55 File Offset: 0x00050055
			public _Undo_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700369A RID: 13978
			// (get) Token: 0x0600B24D RID: 45645 RVA: 0x002CDE80 File Offset: 0x002CC080
			// (set) Token: 0x0600B24E RID: 45646 RVA: 0x00051E5E File Offset: 0x0005005E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700369B RID: 13979
			// (get) Token: 0x0600B24F RID: 45647 RVA: 0x002CDEA8 File Offset: 0x002CC0A8
			// (set) Token: 0x0600B250 RID: 45648 RVA: 0x00051E79 File Offset: 0x00050079
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700369C RID: 13980
			// (get) Token: 0x0600B251 RID: 45649 RVA: 0x002CDED8 File Offset: 0x002CC0D8
			// (set) Token: 0x0600B252 RID: 45650 RVA: 0x00051E98 File Offset: 0x00050098
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700369D RID: 13981
			// (get) Token: 0x0600B253 RID: 45651 RVA: 0x002CDF00 File Offset: 0x002CC100
			// (set) Token: 0x0600B254 RID: 45652 RVA: 0x00051EB3 File Offset: 0x000500B3
			public unsafe UndoNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700369E RID: 13982
			// (get) Token: 0x0600B255 RID: 45653 RVA: 0x002CDF30 File Offset: 0x002CC130
			// (set) Token: 0x0600B256 RID: 45654 RVA: 0x00051ED2 File Offset: 0x000500D2
			public unsafe UndoNode __3__node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___3__node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___3__node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700369F RID: 13983
			// (get) Token: 0x0600B257 RID: 45655 RVA: 0x002CDF60 File Offset: 0x002CC160
			// (set) Token: 0x0600B258 RID: 45656 RVA: 0x00051EF1 File Offset: 0x000500F1
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A0 RID: 13984
			// (get) Token: 0x0600B259 RID: 45657 RVA: 0x002CDF90 File Offset: 0x002CC190
			// (set) Token: 0x0600B25A RID: 45658 RVA: 0x00051F10 File Offset: 0x00050110
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A1 RID: 13985
			// (get) Token: 0x0600B25B RID: 45659 RVA: 0x002CDFC0 File Offset: 0x002CC1C0
			// (set) Token: 0x0600B25C RID: 45660 RVA: 0x00051F2F File Offset: 0x0005012F
			public unsafe GunThopterAgentAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GunThopterAgentAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A2 RID: 13986
			// (get) Token: 0x0600B25D RID: 45661 RVA: 0x002CDFF0 File Offset: 0x002CC1F0
			// (set) Token: 0x0600B25E RID: 45662 RVA: 0x00051F4E File Offset: 0x0005014E
			public unsafe IEnumerator<WormTroop> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormTroop>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunThopterAgentAbility._Undo_d__7.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007067 RID: 28775
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007068 RID: 28776
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007069 RID: 28777
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400706A RID: 28778
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x0400706B RID: 28779
			private static readonly IntPtr NativeFieldInfoPtr___3__node;

			// Token: 0x0400706C RID: 28780
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400706D RID: 28781
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400706E RID: 28782
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400706F RID: 28783
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04007070 RID: 28784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007071 RID: 28785
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007072 RID: 28786
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007073 RID: 28787
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007074 RID: 28788
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04007075 RID: 28789
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007076 RID: 28790
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007077 RID: 28791
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007078 RID: 28792
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
