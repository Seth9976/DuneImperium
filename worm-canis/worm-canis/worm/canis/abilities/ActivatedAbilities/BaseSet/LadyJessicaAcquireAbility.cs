using System;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.context;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.ActivatedAbilities.BaseSet
{
	// Token: 0x0200053B RID: 1339
	public class LadyJessicaAcquireAbility : AcquireAbility
	{
		// Token: 0x06003F03 RID: 16131 RVA: 0x0016F884 File Offset: 0x0016DA84
		// Note: this type is marked as 'beforefieldinit'.
		static LadyJessicaAcquireAbility()
		{
			Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.BaseSet", "LadyJessicaAcquireAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr);
			LadyJessicaAcquireAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, "AbilityName");
			LadyJessicaAcquireAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, "AbilityID");
			LadyJessicaAcquireAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, 100684002);
			LadyJessicaAcquireAbility.NativeMethodInfoPtr_GetSourceEntityID_Public_Virtual_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, 100684003);
			LadyJessicaAcquireAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, 100684004);
			LadyJessicaAcquireAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, 100684005);
			LadyJessicaAcquireAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, 100684006);
			LadyJessicaAcquireAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, 100684007);
			LadyJessicaAcquireAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, 100684008);
			LadyJessicaAcquireAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, 100684010);
			LadyJessicaAcquireAbility.NativeMethodInfoPtr___n__1_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, 100684011);
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x0016F990 File Offset: 0x0016DB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276853, XrefRangeEnd = 276857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LadyJessicaAcquireAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x0016F9DC File Offset: 0x0016DBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityID GetSourceEntityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LadyJessicaAcquireAbility.NativeMethodInfoPtr_GetSourceEntityID_Public_Virtual_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x0016FA28 File Offset: 0x0016DC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276857, XrefRangeEnd = 276863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LadyJessicaAcquireAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x0016FA74 File Offset: 0x0016DC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276863, XrefRangeEnd = 276867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LadyJessicaAcquireAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x0016FAE4 File Offset: 0x0016DCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276867, XrefRangeEnd = 276875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<TargetInformation> Targets(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LadyJessicaAcquireAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x0016FB54 File Offset: 0x0016DD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276875, XrefRangeEnd = 276884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LadyJessicaAcquireAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x0016FBD4 File Offset: 0x0016DDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276884, XrefRangeEnd = 276964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LadyJessicaAcquireAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x0016FC30 File Offset: 0x0016DE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<TargetInformation> __n__0(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_TargetInformation_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x0016FC94 File Offset: 0x0016DE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> __n__1(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility.NativeMethodInfoPtr___n__1_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x00014062 File Offset: 0x00012262
		public LadyJessicaAcquireAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x0016FD08 File Offset: 0x0016DF08
		// (set) Token: 0x06003F0F RID: 16143 RVA: 0x0001406B File Offset: 0x0001226B
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LadyJessicaAcquireAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LadyJessicaAcquireAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x0016FD28 File Offset: 0x0016DF28
		// (set) Token: 0x06003F11 RID: 16145 RVA: 0x0001407D File Offset: 0x0001227D
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LadyJessicaAcquireAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LadyJessicaAcquireAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029D9 RID: 10713
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040029DA RID: 10714
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040029DB RID: 10715
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040029DC RID: 10716
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceEntityID_Public_Virtual_EntityID_0;

		// Token: 0x040029DD RID: 10717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040029DE RID: 10718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040029DF RID: 10719
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040029E0 RID: 10720
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040029E1 RID: 10721
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x040029E2 RID: 10722
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040029E3 RID: 10723
		private static readonly IntPtr NativeMethodInfoPtr___n__1_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x02000CC6 RID: 3270
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.BaseSet.LadyJessicaAcquireAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600D56D RID: 54637 RVA: 0x00333888 File Offset: 0x00331A88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr);
				LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr, "<>9");
				LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr, "<>9__6_0");
				LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr, "<>9__6_1");
				LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr, "<>9__6_2");
				LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr, "<>9__8_0");
				LadyJessicaAcquireAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr, 100684013);
				LadyJessicaAcquireAbility.__c.NativeMethodInfoPtr__Targets_b__6_0_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr, 100684014);
				LadyJessicaAcquireAbility.__c.NativeMethodInfoPtr__Targets_b__6_1_Internal_EntityID_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr, 100684015);
				LadyJessicaAcquireAbility.__c.NativeMethodInfoPtr__Targets_b__6_2_Internal_ReadOnlyAttributes_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr, 100684016);
				LadyJessicaAcquireAbility.__c.NativeMethodInfoPtr__Evaluate_b__8_0_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr, 100684017);
			}

			// Token: 0x0600D56E RID: 54638 RVA: 0x0033397C File Offset: 0x00331B7C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LadyJessicaAcquireAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D56F RID: 54639 RVA: 0x003339B8 File Offset: 0x00331BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Targets_b__6_0(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility.__c.NativeMethodInfoPtr__Targets_b__6_0_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D570 RID: 54640 RVA: 0x00333A08 File Offset: 0x00331C08
			[CallerCount(0)]
			public unsafe EntityID _Targets_b__6_1(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility.__c.NativeMethodInfoPtr__Targets_b__6_1_Internal_EntityID_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600D571 RID: 54641 RVA: 0x00333A58 File Offset: 0x00331C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276604, XrefRangeEnd = 276624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _Targets_b__6_2(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility.__c.NativeMethodInfoPtr__Targets_b__6_2_Internal_ReadOnlyAttributes_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x0600D572 RID: 54642 RVA: 0x00333AA8 File Offset: 0x00331CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276624, XrefRangeEnd = 276629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__8_0(TargetInformation _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility.__c.NativeMethodInfoPtr__Evaluate_b__8_0_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D573 RID: 54643 RVA: 0x00066604 File Offset: 0x00064804
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17004352 RID: 17234
			// (get) Token: 0x0600D574 RID: 54644 RVA: 0x00333AF8 File Offset: 0x00331CF8
			// (set) Token: 0x0600D575 RID: 54645 RVA: 0x0006660D File Offset: 0x0006480D
			public unsafe static LadyJessicaAcquireAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LadyJessicaAcquireAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004353 RID: 17235
			// (get) Token: 0x0600D576 RID: 54646 RVA: 0x00333B20 File Offset: 0x00331D20
			// (set) Token: 0x0600D577 RID: 54647 RVA: 0x0006661F File Offset: 0x0006481F
			public unsafe static Func<WormFactionTrack, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004354 RID: 17236
			// (get) Token: 0x0600D578 RID: 54648 RVA: 0x00333B48 File Offset: 0x00331D48
			// (set) Token: 0x0600D579 RID: 54649 RVA: 0x00066631 File Offset: 0x00064831
			public unsafe static Func<WormFactionTrack, EntityID> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004355 RID: 17237
			// (get) Token: 0x0600D57A RID: 54650 RVA: 0x00333B70 File Offset: 0x00331D70
			// (set) Token: 0x0600D57B RID: 54651 RVA: 0x00066643 File Offset: 0x00064843
			public unsafe static Func<WormFactionTrack, ReadOnlyAttributes> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004356 RID: 17238
			// (get) Token: 0x0600D57C RID: 54652 RVA: 0x00333B98 File Offset: 0x00331D98
			// (set) Token: 0x0600D57D RID: 54653 RVA: 0x00066655 File Offset: 0x00064855
			public unsafe static Func<TargetInformation, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LadyJessicaAcquireAbility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400854A RID: 34122
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400854B RID: 34123
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400854C RID: 34124
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x0400854D RID: 34125
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x0400854E RID: 34126
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400854F RID: 34127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008550 RID: 34128
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_0_Internal_Boolean_WormFactionTrack_0;

			// Token: 0x04008551 RID: 34129
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_1_Internal_EntityID_WormFactionTrack_0;

			// Token: 0x04008552 RID: 34130
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_2_Internal_ReadOnlyAttributes_WormFactionTrack_0;

			// Token: 0x04008553 RID: 34131
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__8_0_Internal_Boolean_TargetInformation_0;
		}

		// Token: 0x02000CC7 RID: 3271
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.BaseSet.LadyJessicaAcquireAbility+<BeginExecution>d__7")]
		public sealed class _BeginExecution_d__7 : Object
		{
			// Token: 0x0600D57E RID: 54654 RVA: 0x00333BC0 File Offset: 0x00331DC0
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__7()
			{
				Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, "<BeginExecution>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr);
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "<>1__state");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "<>2__current");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "<>l__initialThreadId");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "activeAbility");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "<>3__activeAbility");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "<>4__this");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "match");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "<>3__match");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "context");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "<>3__context");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, "<>7__wrap1");
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, 100684018);
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, 100684019);
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, 100684020);
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, 100684021);
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, 100684022);
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, 100684023);
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, 100684024);
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, 100684025);
				LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr, 100684026);
			}

			// Token: 0x0600D57F RID: 54655 RVA: 0x00333D7C File Offset: 0x00331F7C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LadyJessicaAcquireAbility._BeginExecution_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600D580 RID: 54656 RVA: 0x00333DC4 File Offset: 0x00331FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276629, XrefRangeEnd = 276634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D581 RID: 54657 RVA: 0x00333DF8 File Offset: 0x00331FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276634, XrefRangeEnd = 276679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D582 RID: 54658 RVA: 0x00333E34 File Offset: 0x00332034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276679, XrefRangeEnd = 276682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004362 RID: 17250
			// (get) Token: 0x0600D583 RID: 54659 RVA: 0x00333E68 File Offset: 0x00332068
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600D584 RID: 54660 RVA: 0x00333EA8 File Offset: 0x003320A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276682, XrefRangeEnd = 276687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004363 RID: 17251
			// (get) Token: 0x0600D585 RID: 54661 RVA: 0x00333EDC File Offset: 0x003320DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D586 RID: 54662 RVA: 0x00333F1C File Offset: 0x0033211C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276687, XrefRangeEnd = 276698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600D587 RID: 54663 RVA: 0x00333F5C File Offset: 0x0033215C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D588 RID: 54664 RVA: 0x00066667 File Offset: 0x00064867
			public _BeginExecution_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17004357 RID: 17239
			// (get) Token: 0x0600D589 RID: 54665 RVA: 0x00333F9C File Offset: 0x0033219C
			// (set) Token: 0x0600D58A RID: 54666 RVA: 0x00066670 File Offset: 0x00064870
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004358 RID: 17240
			// (get) Token: 0x0600D58B RID: 54667 RVA: 0x00333FC4 File Offset: 0x003321C4
			// (set) Token: 0x0600D58C RID: 54668 RVA: 0x0006668B File Offset: 0x0006488B
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004359 RID: 17241
			// (get) Token: 0x0600D58D RID: 54669 RVA: 0x00333FF4 File Offset: 0x003321F4
			// (set) Token: 0x0600D58E RID: 54670 RVA: 0x000666AA File Offset: 0x000648AA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700435A RID: 17242
			// (get) Token: 0x0600D58F RID: 54671 RVA: 0x0033401C File Offset: 0x0033221C
			// (set) Token: 0x0600D590 RID: 54672 RVA: 0x000666C5 File Offset: 0x000648C5
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435B RID: 17243
			// (get) Token: 0x0600D591 RID: 54673 RVA: 0x0033404C File Offset: 0x0033224C
			// (set) Token: 0x0600D592 RID: 54674 RVA: 0x000666E4 File Offset: 0x000648E4
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435C RID: 17244
			// (get) Token: 0x0600D593 RID: 54675 RVA: 0x0033407C File Offset: 0x0033227C
			// (set) Token: 0x0600D594 RID: 54676 RVA: 0x00066703 File Offset: 0x00064903
			public unsafe LadyJessicaAcquireAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LadyJessicaAcquireAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435D RID: 17245
			// (get) Token: 0x0600D595 RID: 54677 RVA: 0x003340AC File Offset: 0x003322AC
			// (set) Token: 0x0600D596 RID: 54678 RVA: 0x00066722 File Offset: 0x00064922
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435E RID: 17246
			// (get) Token: 0x0600D597 RID: 54679 RVA: 0x003340DC File Offset: 0x003322DC
			// (set) Token: 0x0600D598 RID: 54680 RVA: 0x00066741 File Offset: 0x00064941
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435F RID: 17247
			// (get) Token: 0x0600D599 RID: 54681 RVA: 0x0033410C File Offset: 0x0033230C
			// (set) Token: 0x0600D59A RID: 54682 RVA: 0x00066760 File Offset: 0x00064960
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004360 RID: 17248
			// (get) Token: 0x0600D59B RID: 54683 RVA: 0x0033413C File Offset: 0x0033233C
			// (set) Token: 0x0600D59C RID: 54684 RVA: 0x0006677F File Offset: 0x0006497F
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004361 RID: 17249
			// (get) Token: 0x0600D59D RID: 54685 RVA: 0x0033416C File Offset: 0x0033236C
			// (set) Token: 0x0600D59E RID: 54686 RVA: 0x0006679E File Offset: 0x0006499E
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._BeginExecution_d__7.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008554 RID: 34132
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008555 RID: 34133
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008556 RID: 34134
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04008557 RID: 34135
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04008558 RID: 34136
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04008559 RID: 34137
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400855A RID: 34138
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400855B RID: 34139
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400855C RID: 34140
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400855D RID: 34141
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400855E RID: 34142
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400855F RID: 34143
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008560 RID: 34144
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008561 RID: 34145
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008562 RID: 34146
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04008563 RID: 34147
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04008564 RID: 34148
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008565 RID: 34149
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008566 RID: 34150
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04008567 RID: 34151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000CC8 RID: 3272
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.BaseSet.LadyJessicaAcquireAbility+<Targets>d__6")]
		public new sealed class _Targets_d__6 : Object
		{
			// Token: 0x0600D59F RID: 54687 RVA: 0x0033419C File Offset: 0x0033239C
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__6()
			{
				Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LadyJessicaAcquireAbility>.NativeClassPtr, "<Targets>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr);
				LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, "<>1__state");
				LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, "<>2__current");
				LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, "<>l__initialThreadId");
				LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, "<>4__this");
				LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, "match");
				LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, "<>3__match");
				LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, "context");
				LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, "<>3__context");
				LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, "<>7__wrap1");
				LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, 100684027);
				LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, 100684028);
				LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, 100684029);
				LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, 100684030);
				LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, 100684031);
				LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, 100684032);
				LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, 100684033);
				LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, 100684034);
				LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr, 100684035);
			}

			// Token: 0x0600D5A0 RID: 54688 RVA: 0x00334330 File Offset: 0x00332530
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LadyJessicaAcquireAbility._Targets_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600D5A1 RID: 54689 RVA: 0x00334378 File Offset: 0x00332578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276698, XrefRangeEnd = 276703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5A2 RID: 54690 RVA: 0x003343AC File Offset: 0x003325AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276703, XrefRangeEnd = 276835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D5A3 RID: 54691 RVA: 0x003343E8 File Offset: 0x003325E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276835, XrefRangeEnd = 276838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700436D RID: 17261
			// (get) Token: 0x0600D5A4 RID: 54692 RVA: 0x0033441C File Offset: 0x0033261C
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5A5 RID: 54693 RVA: 0x0033445C File Offset: 0x0033265C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276838, XrefRangeEnd = 276843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700436E RID: 17262
			// (get) Token: 0x0600D5A6 RID: 54694 RVA: 0x00334490 File Offset: 0x00332690
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5A7 RID: 54695 RVA: 0x003344D0 File Offset: 0x003326D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276843, XrefRangeEnd = 276853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600D5A8 RID: 54696 RVA: 0x00334510 File Offset: 0x00332710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessicaAcquireAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D5A9 RID: 54697 RVA: 0x000667BD File Offset: 0x000649BD
			public _Targets_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17004364 RID: 17252
			// (get) Token: 0x0600D5AA RID: 54698 RVA: 0x00334550 File Offset: 0x00332750
			// (set) Token: 0x0600D5AB RID: 54699 RVA: 0x000667C6 File Offset: 0x000649C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004365 RID: 17253
			// (get) Token: 0x0600D5AC RID: 54700 RVA: 0x00334578 File Offset: 0x00332778
			// (set) Token: 0x0600D5AD RID: 54701 RVA: 0x000667E1 File Offset: 0x000649E1
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004366 RID: 17254
			// (get) Token: 0x0600D5AE RID: 54702 RVA: 0x003345A8 File Offset: 0x003327A8
			// (set) Token: 0x0600D5AF RID: 54703 RVA: 0x00066800 File Offset: 0x00064A00
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17004367 RID: 17255
			// (get) Token: 0x0600D5B0 RID: 54704 RVA: 0x003345D0 File Offset: 0x003327D0
			// (set) Token: 0x0600D5B1 RID: 54705 RVA: 0x0006681B File Offset: 0x00064A1B
			public unsafe LadyJessicaAcquireAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LadyJessicaAcquireAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004368 RID: 17256
			// (get) Token: 0x0600D5B2 RID: 54706 RVA: 0x00334600 File Offset: 0x00332800
			// (set) Token: 0x0600D5B3 RID: 54707 RVA: 0x0006683A File Offset: 0x00064A3A
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004369 RID: 17257
			// (get) Token: 0x0600D5B4 RID: 54708 RVA: 0x00334630 File Offset: 0x00332830
			// (set) Token: 0x0600D5B5 RID: 54709 RVA: 0x00066859 File Offset: 0x00064A59
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700436A RID: 17258
			// (get) Token: 0x0600D5B6 RID: 54710 RVA: 0x00334660 File Offset: 0x00332860
			// (set) Token: 0x0600D5B7 RID: 54711 RVA: 0x00066878 File Offset: 0x00064A78
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700436B RID: 17259
			// (get) Token: 0x0600D5B8 RID: 54712 RVA: 0x00334690 File Offset: 0x00332890
			// (set) Token: 0x0600D5B9 RID: 54713 RVA: 0x00066897 File Offset: 0x00064A97
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700436C RID: 17260
			// (get) Token: 0x0600D5BA RID: 54714 RVA: 0x003346C0 File Offset: 0x003328C0
			// (set) Token: 0x0600D5BB RID: 54715 RVA: 0x000668B6 File Offset: 0x00064AB6
			public unsafe IEnumerator<TargetInformation> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadyJessicaAcquireAbility._Targets_d__6.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008568 RID: 34152
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008569 RID: 34153
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400856A RID: 34154
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400856B RID: 34155
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400856C RID: 34156
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400856D RID: 34157
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400856E RID: 34158
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400856F RID: 34159
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04008570 RID: 34160
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04008571 RID: 34161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008572 RID: 34162
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008573 RID: 34163
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008574 RID: 34164
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04008575 RID: 34165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x04008576 RID: 34166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008577 RID: 34167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008578 RID: 34168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x04008579 RID: 34169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
