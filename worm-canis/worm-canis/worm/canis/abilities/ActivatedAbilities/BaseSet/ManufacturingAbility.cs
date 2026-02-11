using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.gameLogs;
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

namespace worm.canis.abilities.ActivatedAbilities.BaseSet
{
	// Token: 0x0200053D RID: 1341
	public class ManufacturingAbility : SignetAbility
	{
		// Token: 0x06003F24 RID: 16164 RVA: 0x00170324 File Offset: 0x0016E524
		// Note: this type is marked as 'beforefieldinit'.
		static ManufacturingAbility()
		{
			Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.BaseSet", "ManufacturingAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr);
			ManufacturingAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, "AbilityName");
			ManufacturingAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, "AbilityID");
			ManufacturingAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, 100684066);
			ManufacturingAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, 100684067);
			ManufacturingAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, 100684068);
			ManufacturingAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, 100684069);
			ManufacturingAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, 100684070);
			ManufacturingAbility.NativeMethodInfoPtr_get_RunCopiesTogether_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, 100684071);
			ManufacturingAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, 100684072);
			ManufacturingAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, 100684073);
			ManufacturingAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, 100684074);
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x00170430 File Offset: 0x0016E630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277293, XrefRangeEnd = 277297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManufacturingAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x0017047C File Offset: 0x0016E67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277297, XrefRangeEnd = 277303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManufacturingAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x001704D8 File Offset: 0x0016E6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277303, XrefRangeEnd = 277306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManufacturingAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x00170524 File Offset: 0x0016E724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManufacturingAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00170594 File Offset: 0x0016E794
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanRunImmediately(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManufacturingAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06003F2A RID: 16170 RVA: 0x001705EC File Offset: 0x0016E7EC
		public unsafe override bool RunCopiesTogether
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManufacturingAbility.NativeMethodInfoPtr_get_RunCopiesTogether_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x00170634 File Offset: 0x0016E834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277306, XrefRangeEnd = 277313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManufacturingAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x001706B4 File Offset: 0x0016E8B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25007, RefRangeEnd = 25008, XrefRangeStart = 25007, XrefRangeEnd = 25008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeExecution(WormActiveAbility activeAbility, Canis.actions.Action returningAction, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManufacturingAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x00170730 File Offset: 0x0016E930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277313, XrefRangeEnd = 277327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManufacturingAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x000140CB File Offset: 0x000122CB
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x000140DA File Offset: 0x000122DA
		public ManufacturingAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06003F30 RID: 16176 RVA: 0x001707AC File Offset: 0x0016E9AC
		// (set) Token: 0x06003F31 RID: 16177 RVA: 0x000140E3 File Offset: 0x000122E3
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManufacturingAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManufacturingAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06003F32 RID: 16178 RVA: 0x001707CC File Offset: 0x0016E9CC
		// (set) Token: 0x06003F33 RID: 16179 RVA: 0x000140F5 File Offset: 0x000122F5
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ManufacturingAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManufacturingAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029F1 RID: 10737
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040029F2 RID: 10738
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040029F3 RID: 10739
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040029F4 RID: 10740
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x040029F5 RID: 10741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040029F6 RID: 10742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040029F7 RID: 10743
		private static readonly IntPtr NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0;

		// Token: 0x040029F8 RID: 10744
		private static readonly IntPtr NativeMethodInfoPtr_get_RunCopiesTogether_Protected_Virtual_get_Boolean_0;

		// Token: 0x040029F9 RID: 10745
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040029FA RID: 10746
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x040029FB RID: 10747
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x02000CCC RID: 3276
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.BaseSet.ManufacturingAbility+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x0600D5F8 RID: 54776 RVA: 0x003351E0 File Offset: 0x003333E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ManufacturingAbility.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManufacturingAbility.__c__DisplayClass9_0>.NativeClassPtr);
				ManufacturingAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_signetIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufacturingAbility.__c__DisplayClass9_0>.NativeClassPtr, "signetIcons");
				ManufacturingAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility.__c__DisplayClass9_0>.NativeClassPtr, 100684076);
				ManufacturingAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility.__c__DisplayClass9_0>.NativeClassPtr, 100684077);
			}

			// Token: 0x0600D5F9 RID: 54777 RVA: 0x00335248 File Offset: 0x00333448
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManufacturingAbility.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5FA RID: 54778 RVA: 0x00335284 File Offset: 0x00333484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277229, XrefRangeEnd = 277239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5FB RID: 54779 RVA: 0x00066B0A File Offset: 0x00064D0A
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17004385 RID: 17285
			// (get) Token: 0x0600D5FC RID: 54780 RVA: 0x003352D4 File Offset: 0x003334D4
			// (set) Token: 0x0600D5FD RID: 54781 RVA: 0x00066B13 File Offset: 0x00064D13
			public unsafe int signetIcons
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_signetIcons);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_signetIcons)) = value;
				}
			}

			// Token: 0x0400859E RID: 34206
			private static readonly IntPtr NativeFieldInfoPtr_signetIcons;

			// Token: 0x0400859F RID: 34207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085A0 RID: 34208
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000CCD RID: 3277
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.BaseSet.ManufacturingAbility+<BeginExecution>d__9")]
		public sealed class _BeginExecution_d__9 : Object
		{
			// Token: 0x0600D5FE RID: 54782 RVA: 0x003352FC File Offset: 0x003334FC
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__9()
			{
				Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManufacturingAbility>.NativeClassPtr, "<BeginExecution>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr);
				ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, "<>1__state");
				ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, "<>2__current");
				ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, "<>l__initialThreadId");
				ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, "activeAbility");
				ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__activeAbility");
				ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, "match");
				ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__match");
				ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, 100684078);
				ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, 100684079);
				ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, 100684080);
				ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, 100684081);
				ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, 100684082);
				ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, 100684083);
				ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, 100684084);
				ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr, 100684085);
			}

			// Token: 0x0600D5FF RID: 54783 RVA: 0x00335454 File Offset: 0x00333654
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManufacturingAbility._BeginExecution_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600D600 RID: 54784 RVA: 0x0033549C File Offset: 0x0033369C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D601 RID: 54785 RVA: 0x003354D0 File Offset: 0x003336D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277239, XrefRangeEnd = 277279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700438D RID: 17293
			// (get) Token: 0x0600D602 RID: 54786 RVA: 0x0033550C File Offset: 0x0033370C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600D603 RID: 54787 RVA: 0x0033554C File Offset: 0x0033374C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277279, XrefRangeEnd = 277284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700438E RID: 17294
			// (get) Token: 0x0600D604 RID: 54788 RVA: 0x00335580 File Offset: 0x00333780
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D605 RID: 54789 RVA: 0x003355C0 File Offset: 0x003337C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277284, XrefRangeEnd = 277293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600D606 RID: 54790 RVA: 0x00335600 File Offset: 0x00333800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManufacturingAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D607 RID: 54791 RVA: 0x00066B2E File Offset: 0x00064D2E
			public _BeginExecution_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17004386 RID: 17286
			// (get) Token: 0x0600D608 RID: 54792 RVA: 0x00335640 File Offset: 0x00333840
			// (set) Token: 0x0600D609 RID: 54793 RVA: 0x00066B37 File Offset: 0x00064D37
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004387 RID: 17287
			// (get) Token: 0x0600D60A RID: 54794 RVA: 0x00335668 File Offset: 0x00333868
			// (set) Token: 0x0600D60B RID: 54795 RVA: 0x00066B52 File Offset: 0x00064D52
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004388 RID: 17288
			// (get) Token: 0x0600D60C RID: 54796 RVA: 0x00335698 File Offset: 0x00333898
			// (set) Token: 0x0600D60D RID: 54797 RVA: 0x00066B71 File Offset: 0x00064D71
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17004389 RID: 17289
			// (get) Token: 0x0600D60E RID: 54798 RVA: 0x003356C0 File Offset: 0x003338C0
			// (set) Token: 0x0600D60F RID: 54799 RVA: 0x00066B8C File Offset: 0x00064D8C
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700438A RID: 17290
			// (get) Token: 0x0600D610 RID: 54800 RVA: 0x003356F0 File Offset: 0x003338F0
			// (set) Token: 0x0600D611 RID: 54801 RVA: 0x00066BAB File Offset: 0x00064DAB
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700438B RID: 17291
			// (get) Token: 0x0600D612 RID: 54802 RVA: 0x00335720 File Offset: 0x00333920
			// (set) Token: 0x0600D613 RID: 54803 RVA: 0x00066BCA File Offset: 0x00064DCA
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700438C RID: 17292
			// (get) Token: 0x0600D614 RID: 54804 RVA: 0x00335750 File Offset: 0x00333950
			// (set) Token: 0x0600D615 RID: 54805 RVA: 0x00066BE9 File Offset: 0x00064DE9
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManufacturingAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085A1 RID: 34209
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040085A2 RID: 34210
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040085A3 RID: 34211
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040085A4 RID: 34212
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040085A5 RID: 34213
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040085A6 RID: 34214
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040085A7 RID: 34215
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040085A8 RID: 34216
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040085A9 RID: 34217
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085AA RID: 34218
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040085AB RID: 34219
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040085AC RID: 34220
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085AD RID: 34221
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040085AE RID: 34222
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040085AF RID: 34223
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
