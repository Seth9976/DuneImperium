using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x02000488 RID: 1160
	public class LietKynesRevealAbility : RevealAbility
	{
		// Token: 0x060033A6 RID: 13222 RVA: 0x00134754 File Offset: 0x00132954
		// Note: this type is marked as 'beforefieldinit'.
		static LietKynesRevealAbility()
		{
			Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "LietKynesRevealAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr);
			LietKynesRevealAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, "AbilityName");
			LietKynesRevealAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, "AbilityID");
			LietKynesRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, 100679463);
			LietKynesRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, 100679464);
			LietKynesRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, 100679465);
			LietKynesRevealAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, 100679466);
			LietKynesRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, 100679467);
			LietKynesRevealAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, 100679468);
			LietKynesRevealAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, 100679470);
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x00134838 File Offset: 0x00132A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236176, XrefRangeEnd = 236180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LietKynesRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00134884 File Offset: 0x00132A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236180, XrefRangeEnd = 236196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LietKynesRevealAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x001348D0 File Offset: 0x00132AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236196, XrefRangeEnd = 236200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LietKynesRevealAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x00134940 File Offset: 0x00132B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236200, XrefRangeEnd = 236209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LietKynesRevealAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x001349C0 File Offset: 0x00132BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236209, XrefRangeEnd = 236244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<string, int> GetRevealPreviewValue(WormMatch match, WormPlayer player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LietKynesRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00134A30 File Offset: 0x00132C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236244, XrefRangeEnd = 236280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIValueSummer<double> ValueForPlayer(WormPlayer player, [Optional] Il2CppReferenceArray<WormEntity> withEntities)
		{
			if (withEntities == null)
			{
				withEntities = new Il2CppReferenceArray<WormEntity>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(withEntities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LietKynesRevealAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x00134AAC File Offset: 0x00132CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> __n__0(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x00011CB7 File Offset: 0x0000FEB7
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x00011CC6 File Offset: 0x0000FEC6
		public LietKynesRevealAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060033B0 RID: 13232 RVA: 0x00134B20 File Offset: 0x00132D20
		// (set) Token: 0x060033B1 RID: 13233 RVA: 0x00011CCF File Offset: 0x0000FECF
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LietKynesRevealAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LietKynesRevealAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060033B2 RID: 13234 RVA: 0x00134B40 File Offset: 0x00132D40
		// (set) Token: 0x060033B3 RID: 13235 RVA: 0x00011CE1 File Offset: 0x0000FEE1
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LietKynesRevealAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LietKynesRevealAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002194 RID: 8596
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002195 RID: 8597
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002196 RID: 8598
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002197 RID: 8599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002198 RID: 8600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002199 RID: 8601
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400219A RID: 8602
		private static readonly IntPtr NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0;

		// Token: 0x0400219B RID: 8603
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000B14 RID: 2836
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.LietKynesRevealAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600B33A RID: 45882 RVA: 0x002D0760 File Offset: 0x002CE960
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LietKynesRevealAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LietKynesRevealAbility.__c>.NativeClassPtr);
				LietKynesRevealAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility.__c>.NativeClassPtr, "<>9");
				LietKynesRevealAbility.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility.__c>.NativeClassPtr, "<>9__7_0");
				LietKynesRevealAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility.__c>.NativeClassPtr, 100679472);
				LietKynesRevealAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__7_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility.__c>.NativeClassPtr, 100679473);
			}

			// Token: 0x0600B33B RID: 45883 RVA: 0x002D07DC File Offset: 0x002CE9DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LietKynesRevealAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B33C RID: 45884 RVA: 0x002D0818 File Offset: 0x002CEA18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236057, XrefRangeEnd = 236062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueForPlayer_b__7_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__7_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B33D RID: 45885 RVA: 0x0005277B File Offset: 0x0005097B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036EE RID: 14062
			// (get) Token: 0x0600B33E RID: 45886 RVA: 0x002D0868 File Offset: 0x002CEA68
			// (set) Token: 0x0600B33F RID: 45887 RVA: 0x00052784 File Offset: 0x00050984
			public unsafe static LietKynesRevealAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LietKynesRevealAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LietKynesRevealAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LietKynesRevealAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036EF RID: 14063
			// (get) Token: 0x0600B340 RID: 45888 RVA: 0x002D0890 File Offset: 0x002CEA90
			// (set) Token: 0x0600B341 RID: 45889 RVA: 0x00052796 File Offset: 0x00050996
			public unsafe static Func<Entity, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LietKynesRevealAbility.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LietKynesRevealAbility.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070F5 RID: 28917
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040070F6 RID: 28918
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040070F7 RID: 28919
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040070F8 RID: 28920
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__7_0_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000B15 RID: 2837
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.LietKynesRevealAbility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600B342 RID: 45890 RVA: 0x002D08B8 File Offset: 0x002CEAB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass5_0>.NativeClassPtr);
				LietKynesRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, "player");
				LietKynesRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, 100679474);
				LietKynesRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, 100679475);
			}

			// Token: 0x0600B343 RID: 45891 RVA: 0x002D0920 File Offset: 0x002CEB20
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B344 RID: 45892 RVA: 0x002D095C File Offset: 0x002CEB5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236062, XrefRangeEnd = 236063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__0(WormPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B345 RID: 45893 RVA: 0x000527A8 File Offset: 0x000509A8
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036F0 RID: 14064
			// (get) Token: 0x0600B346 RID: 45894 RVA: 0x002D09AC File Offset: 0x002CEBAC
			// (set) Token: 0x0600B347 RID: 45895 RVA: 0x000527B1 File Offset: 0x000509B1
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070F9 RID: 28921
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040070FA RID: 28922
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040070FB RID: 28923
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormPlayable_0;
		}

		// Token: 0x02000B16 RID: 2838
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.LietKynesRevealAbility+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600B348 RID: 45896 RVA: 0x002D09DC File Offset: 0x002CEBDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass6_0>.NativeClassPtr);
				LietKynesRevealAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass6_0>.NativeClassPtr, "player");
				LietKynesRevealAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass6_0>.NativeClassPtr, 100679476);
				LietKynesRevealAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass6_0>.NativeClassPtr, 100679477);
			}

			// Token: 0x0600B349 RID: 45897 RVA: 0x002D0A44 File Offset: 0x002CEC44
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LietKynesRevealAbility.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B34A RID: 45898 RVA: 0x002D0A80 File Offset: 0x002CEC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236063, XrefRangeEnd = 236064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRevealPreviewValue_b__0(WormPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B34B RID: 45899 RVA: 0x000527D0 File Offset: 0x000509D0
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036F1 RID: 14065
			// (get) Token: 0x0600B34C RID: 45900 RVA: 0x002D0AD0 File Offset: 0x002CECD0
			// (set) Token: 0x0600B34D RID: 45901 RVA: 0x000527D9 File Offset: 0x000509D9
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility.__c__DisplayClass6_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070FC RID: 28924
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040070FD RID: 28925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040070FE RID: 28926
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0;
		}

		// Token: 0x02000B17 RID: 2839
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.LietKynesRevealAbility+<BeginExecution>d__5")]
		public sealed class _BeginExecution_d__5 : Object
		{
			// Token: 0x0600B34E RID: 45902 RVA: 0x002D0B00 File Offset: 0x002CED00
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__5()
			{
				Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LietKynesRevealAbility>.NativeClassPtr, "<BeginExecution>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr);
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>1__state");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>2__current");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>l__initialThreadId");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "activeAbility");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>3__activeAbility");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "match");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>3__match");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>8__1");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>4__this");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "context");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>3__context");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__persuasionGain_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<persuasionGain>5__2");
				LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, "<>7__wrap2");
				LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100679478);
				LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100679479);
				LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100679480);
				LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100679481);
				LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100679482);
				LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100679483);
				LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100679484);
				LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100679485);
				LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr, 100679486);
			}

			// Token: 0x0600B34F RID: 45903 RVA: 0x002D0CE4 File Offset: 0x002CEEE4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LietKynesRevealAbility._BeginExecution_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B350 RID: 45904 RVA: 0x002D0D2C File Offset: 0x002CEF2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236064, XrefRangeEnd = 236069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B351 RID: 45905 RVA: 0x002D0D60 File Offset: 0x002CEF60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236069, XrefRangeEnd = 236157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B352 RID: 45906 RVA: 0x002D0D9C File Offset: 0x002CEF9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236157, XrefRangeEnd = 236160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170036FF RID: 14079
			// (get) Token: 0x0600B353 RID: 45907 RVA: 0x002D0DD0 File Offset: 0x002CEFD0
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B354 RID: 45908 RVA: 0x002D0E10 File Offset: 0x002CF010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236160, XrefRangeEnd = 236165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003700 RID: 14080
			// (get) Token: 0x0600B355 RID: 45909 RVA: 0x002D0E44 File Offset: 0x002CF044
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B356 RID: 45910 RVA: 0x002D0E84 File Offset: 0x002CF084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236165, XrefRangeEnd = 236176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B357 RID: 45911 RVA: 0x002D0EC4 File Offset: 0x002CF0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LietKynesRevealAbility._BeginExecution_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B358 RID: 45912 RVA: 0x000527F8 File Offset: 0x000509F8
			public _BeginExecution_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036F2 RID: 14066
			// (get) Token: 0x0600B359 RID: 45913 RVA: 0x002D0F04 File Offset: 0x002CF104
			// (set) Token: 0x0600B35A RID: 45914 RVA: 0x00052801 File Offset: 0x00050A01
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170036F3 RID: 14067
			// (get) Token: 0x0600B35B RID: 45915 RVA: 0x002D0F2C File Offset: 0x002CF12C
			// (set) Token: 0x0600B35C RID: 45916 RVA: 0x0005281C File Offset: 0x00050A1C
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F4 RID: 14068
			// (get) Token: 0x0600B35D RID: 45917 RVA: 0x002D0F5C File Offset: 0x002CF15C
			// (set) Token: 0x0600B35E RID: 45918 RVA: 0x0005283B File Offset: 0x00050A3B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170036F5 RID: 14069
			// (get) Token: 0x0600B35F RID: 45919 RVA: 0x002D0F84 File Offset: 0x002CF184
			// (set) Token: 0x0600B360 RID: 45920 RVA: 0x00052856 File Offset: 0x00050A56
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F6 RID: 14070
			// (get) Token: 0x0600B361 RID: 45921 RVA: 0x002D0FB4 File Offset: 0x002CF1B4
			// (set) Token: 0x0600B362 RID: 45922 RVA: 0x00052875 File Offset: 0x00050A75
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F7 RID: 14071
			// (get) Token: 0x0600B363 RID: 45923 RVA: 0x002D0FE4 File Offset: 0x002CF1E4
			// (set) Token: 0x0600B364 RID: 45924 RVA: 0x00052894 File Offset: 0x00050A94
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F8 RID: 14072
			// (get) Token: 0x0600B365 RID: 45925 RVA: 0x002D1014 File Offset: 0x002CF214
			// (set) Token: 0x0600B366 RID: 45926 RVA: 0x000528B3 File Offset: 0x00050AB3
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F9 RID: 14073
			// (get) Token: 0x0600B367 RID: 45927 RVA: 0x002D1044 File Offset: 0x002CF244
			// (set) Token: 0x0600B368 RID: 45928 RVA: 0x000528D2 File Offset: 0x00050AD2
			public unsafe LietKynesRevealAbility.__c__DisplayClass5_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LietKynesRevealAbility.__c__DisplayClass5_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036FA RID: 14074
			// (get) Token: 0x0600B369 RID: 45929 RVA: 0x002D1074 File Offset: 0x002CF274
			// (set) Token: 0x0600B36A RID: 45930 RVA: 0x000528F1 File Offset: 0x00050AF1
			public unsafe LietKynesRevealAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LietKynesRevealAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036FB RID: 14075
			// (get) Token: 0x0600B36B RID: 45931 RVA: 0x002D10A4 File Offset: 0x002CF2A4
			// (set) Token: 0x0600B36C RID: 45932 RVA: 0x00052910 File Offset: 0x00050B10
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036FC RID: 14076
			// (get) Token: 0x0600B36D RID: 45933 RVA: 0x002D10D4 File Offset: 0x002CF2D4
			// (set) Token: 0x0600B36E RID: 45934 RVA: 0x0005292F File Offset: 0x00050B2F
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036FD RID: 14077
			// (get) Token: 0x0600B36F RID: 45935 RVA: 0x002D1104 File Offset: 0x002CF304
			// (set) Token: 0x0600B370 RID: 45936 RVA: 0x0005294E File Offset: 0x00050B4E
			public unsafe int _persuasionGain_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__persuasionGain_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr__persuasionGain_5__2)) = value;
				}
			}

			// Token: 0x170036FE RID: 14078
			// (get) Token: 0x0600B371 RID: 45937 RVA: 0x002D112C File Offset: 0x002CF32C
			// (set) Token: 0x0600B372 RID: 45938 RVA: 0x00052969 File Offset: 0x00050B69
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LietKynesRevealAbility._BeginExecution_d__5.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070FF RID: 28927
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007100 RID: 28928
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007101 RID: 28929
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007102 RID: 28930
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04007103 RID: 28931
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04007104 RID: 28932
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007105 RID: 28933
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007106 RID: 28934
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04007107 RID: 28935
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007108 RID: 28936
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007109 RID: 28937
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400710A RID: 28938
			private static readonly IntPtr NativeFieldInfoPtr__persuasionGain_5__2;

			// Token: 0x0400710B RID: 28939
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400710C RID: 28940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400710D RID: 28941
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400710E RID: 28942
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400710F RID: 28943
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007110 RID: 28944
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04007111 RID: 28945
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007112 RID: 28946
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007113 RID: 28947
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007114 RID: 28948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
