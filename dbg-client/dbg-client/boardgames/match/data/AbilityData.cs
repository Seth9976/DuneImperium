using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.data.readonlyWrappers;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.data
{
	// Token: 0x02000273 RID: 627
	public class AbilityData : DataComponent
	{
		// Token: 0x06001D49 RID: 7497 RVA: 0x0007EE94 File Offset: 0x0007D094
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityData()
		{
			Il2CppClassPointerStore<AbilityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.data", "AbilityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityData>.NativeClassPtr);
			AbilityData.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, "entity");
			AbilityData.NativeFieldInfoPtr_cachedChildrenVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, "cachedChildrenVersion");
			AbilityData.NativeFieldInfoPtr_abilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, "abilities");
			AbilityData.NativeFieldInfoPtr_readonlyAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, "readonlyAbilities");
			AbilityData.NativeFieldInfoPtr_abilityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, "abilityIDs");
			AbilityData.NativeFieldInfoPtr_readonlyAbilityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, "readonlyAbilityIDs");
			AbilityData.NativeFieldInfoPtr_entityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, "entityIDs");
			AbilityData.NativeFieldInfoPtr_readonlyEntityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, "readonlyEntityIDs");
			AbilityData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, 100668114);
			AbilityData.NativeMethodInfoPtr_get_Abilities_Public_get_ReadOnlyList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, 100668115);
			AbilityData.NativeMethodInfoPtr_get_AbilityIDs_Public_get_ReadOnlyList_1_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, 100668116);
			AbilityData.NativeMethodInfoPtr_get_EntityIDs_Public_get_ReadOnlyList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, 100668117);
			AbilityData.NativeMethodInfoPtr_rebuildCachedLists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, 100668118);
			AbilityData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, 100668119);
			AbilityData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityData>.NativeClassPtr, 100668120);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0007EFF0 File Offset: 0x0007D1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536833, XrefRangeEnd = 536856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityData(EntityComponent entity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x0007F03C File Offset: 0x0007D23C
		public unsafe ReadOnlyList<EntityComponent> Abilities
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536856, XrefRangeEnd = 536857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityData.NativeMethodInfoPtr_get_Abilities_Public_get_ReadOnlyList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x0007F07C File Offset: 0x0007D27C
		public unsafe ReadOnlyList<AbilityID> AbilityIDs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536857, XrefRangeEnd = 536858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityData.NativeMethodInfoPtr_get_AbilityIDs_Public_get_ReadOnlyList_1_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<AbilityID>>(intPtr3) : null;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x0007F0BC File Offset: 0x0007D2BC
		public unsafe ReadOnlyList<EntityID> EntityIDs
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 536859, RefRangeEnd = 536860, XrefRangeStart = 536858, XrefRangeEnd = 536859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityData.NativeMethodInfoPtr_get_EntityIDs_Public_get_ReadOnlyList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x0007F0FC File Offset: 0x0007D2FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 536924, RefRangeEnd = 536929, XrefRangeStart = 536860, XrefRangeEnd = 536924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void rebuildCachedLists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityData.NativeMethodInfoPtr_rebuildCachedLists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x0007F130 File Offset: 0x0007D330
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536929, XrefRangeEnd = 536930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x0007F16C File Offset: 0x0007D36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536930, XrefRangeEnd = 536956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x0000F898 File Offset: 0x0000DA98
		public AbilityData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x0007F1B0 File Offset: 0x0007D3B0
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x0000F8A1 File Offset: 0x0000DAA1
		public unsafe EntityComponent entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x0007F1E0 File Offset: 0x0007D3E0
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0000F8C0 File Offset: 0x0000DAC0
		public unsafe ulong cachedChildrenVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_cachedChildrenVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_cachedChildrenVersion)) = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0007F208 File Offset: 0x0007D408
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x0000F8DB File Offset: 0x0000DADB
		public unsafe List<EntityComponent> abilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_abilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_abilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0007F238 File Offset: 0x0007D438
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x0000F8FA File Offset: 0x0000DAFA
		public unsafe ReadOnlyList<EntityComponent> readonlyAbilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_readonlyAbilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_readonlyAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x0007F268 File Offset: 0x0007D468
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x0000F919 File Offset: 0x0000DB19
		public unsafe List<AbilityID> abilityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_abilityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_abilityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x0007F298 File Offset: 0x0007D498
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0000F938 File Offset: 0x0000DB38
		public unsafe ReadOnlyList<AbilityID> readonlyAbilityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_readonlyAbilityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<AbilityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_readonlyAbilityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0007F2C8 File Offset: 0x0007D4C8
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0000F957 File Offset: 0x0000DB57
		public unsafe List<EntityID> entityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_entityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_entityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0007F2F8 File Offset: 0x0007D4F8
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0000F976 File Offset: 0x0000DB76
		public unsafe ReadOnlyList<EntityID> readonlyEntityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_readonlyEntityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityData.NativeFieldInfoPtr_readonlyEntityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeFieldInfoPtr_entity;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeFieldInfoPtr_cachedChildrenVersion;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeFieldInfoPtr_abilities;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeFieldInfoPtr_readonlyAbilities;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeFieldInfoPtr_abilityIDs;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeFieldInfoPtr_readonlyAbilityIDs;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeFieldInfoPtr_entityIDs;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeFieldInfoPtr_readonlyEntityIDs;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr_get_Abilities_Public_get_ReadOnlyList_1_EntityComponent_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilityIDs_Public_get_ReadOnlyList_1_AbilityID_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityIDs_Public_get_ReadOnlyList_1_EntityID_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_rebuildCachedLists_Private_Void_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
