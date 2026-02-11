using System;
using Canis.attributes;
using Canis.utils;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.match.data
{
	// Token: 0x02000180 RID: 384
	public class WormChallengeProgressData : VersionedDataComponent
	{
		// Token: 0x0600113E RID: 4414 RVA: 0x0004BF94 File Offset: 0x0004A194
		// Note: this type is marked as 'beforefieldinit'.
		static WormChallengeProgressData()
		{
			Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormChallengeProgressData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr);
			WormChallengeProgressData.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "elements");
			WormChallengeProgressData.NativeFieldInfoPtr__ControlMarkers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<ControlMarkers>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__Solari_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<Solari>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__SpiceMustFlowAcquired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<SpiceMustFlowAcquired>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__DeckList_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<DeckList>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__VisitedSpaces_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<VisitedSpaces>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__LocalPlayerAllianceTokens_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<LocalPlayerAllianceTokens>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__OtherPlayersSolari_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<OtherPlayersSolari>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__TechTiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<TechTiles>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__FinalDeliveries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<FinalDeliveries>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__GeneticMarkers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<GeneticMarkers>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__TleliaxuInfluence_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<TleliaxuInfluence>k__BackingField");
			WormChallengeProgressData.NativeFieldInfoPtr__HasHighCouncil_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<HasHighCouncil>k__BackingField");
			WormChallengeProgressData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_ReadOnlyVersionedList_1_EntityComponent_IEnumerable_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665684);
			WormChallengeProgressData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665685);
			WormChallengeProgressData.NativeMethodInfoPtr_get_ControlMarkers_Public_get_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665686);
			WormChallengeProgressData.NativeMethodInfoPtr_get_Solari_Public_get_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665687);
			WormChallengeProgressData.NativeMethodInfoPtr_get_SpiceMustFlowAcquired_Public_get_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665688);
			WormChallengeProgressData.NativeMethodInfoPtr_get_DeckList_Public_get_IAttribute_1_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665689);
			WormChallengeProgressData.NativeMethodInfoPtr_get_VisitedSpaces_Public_get_IAttribute_1_Dictionary_2_ArchetypeID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665690);
			WormChallengeProgressData.NativeMethodInfoPtr_get_LocalPlayerAllianceTokens_Public_get_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665691);
			WormChallengeProgressData.NativeMethodInfoPtr_get_OtherPlayersSolari_Public_get_IReadOnlyList_1_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665692);
			WormChallengeProgressData.NativeMethodInfoPtr_get_TechTiles_Public_get_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665693);
			WormChallengeProgressData.NativeMethodInfoPtr_get_FinalDeliveries_Public_get_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665694);
			WormChallengeProgressData.NativeMethodInfoPtr_get_GeneticMarkers_Public_get_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665695);
			WormChallengeProgressData.NativeMethodInfoPtr_get_TleliaxuInfluence_Public_get_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665696);
			WormChallengeProgressData.NativeMethodInfoPtr_get_HasHighCouncil_Public_get_IAttribute_1_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, 100665697);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0004C1E0 File Offset: 0x0004A3E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711110, RefRangeEnd = 711111, XrefRangeStart = 710985, XrefRangeEnd = 711110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChallengeProgressData(EntityComponent localPlayer, ReadOnlyVersionedList<EntityComponent> localPlayerAllianceTokens, IEnumerable<EntityComponent> allPlayers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localPlayerAllianceTokens);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allPlayers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_ReadOnlyVersionedList_1_EntityComponent_IEnumerable_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0004C250 File Offset: 0x0004A450
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711111, XrefRangeEnd = 711115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormChallengeProgressData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0004C298 File Offset: 0x0004A498
		public unsafe IAttribute<Nullable<int>> ControlMarkers
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_ControlMarkers_Public_get_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
		public unsafe IAttribute<Nullable<int>> Solari
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_Solari_Public_get_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x0004C318 File Offset: 0x0004A518
		public unsafe IAttribute<Nullable<int>> SpiceMustFlowAcquired
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_SpiceMustFlowAcquired_Public_get_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x0004C358 File Offset: 0x0004A558
		public unsafe IAttribute<List<ArchetypeID>> DeckList
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_DeckList_Public_get_IAttribute_1_List_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<List<ArchetypeID>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0004C398 File Offset: 0x0004A598
		public unsafe IAttribute<Dictionary<ArchetypeID, int>> VisitedSpaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_VisitedSpaces_Public_get_IAttribute_1_Dictionary_2_ArchetypeID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Dictionary<ArchetypeID, int>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x0004C3D8 File Offset: 0x0004A5D8
		public unsafe ReadOnlyVersionedList<EntityComponent> LocalPlayerAllianceTokens
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_LocalPlayerAllianceTokens_Public_get_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0004C418 File Offset: 0x0004A618
		public unsafe IReadOnlyList<IAttribute<Nullable<int>>> OtherPlayersSolari
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_OtherPlayersSolari_Public_get_IReadOnlyList_1_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<IAttribute<Nullable<int>>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0004C458 File Offset: 0x0004A658
		public unsafe IAttribute<Nullable<int>> TechTiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_TechTiles_Public_get_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0004C498 File Offset: 0x0004A698
		public unsafe IAttribute<Nullable<int>> FinalDeliveries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_FinalDeliveries_Public_get_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0004C4D8 File Offset: 0x0004A6D8
		public unsafe IAttribute<Nullable<int>> GeneticMarkers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_GeneticMarkers_Public_get_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0004C518 File Offset: 0x0004A718
		public unsafe IAttribute<Nullable<int>> TleliaxuInfluence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_TleliaxuInfluence_Public_get_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0004C558 File Offset: 0x0004A758
		public unsafe IAttribute<Nullable<bool>> HasHighCouncil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.NativeMethodInfoPtr_get_HasHighCouncil_Public_get_IAttribute_1_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0000B0AC File Offset: 0x000092AC
		public WormChallengeProgressData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0004C598 File Offset: 0x0004A798
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x0000B0B5 File Offset: 0x000092B5
		public unsafe IReadOnlyList<IVersionedModel> elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr_elements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<IVersionedModel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0004C5C8 File Offset: 0x0004A7C8
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x0000B0D4 File Offset: 0x000092D4
		public unsafe IAttribute<Nullable<int>> _ControlMarkers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__ControlMarkers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__ControlMarkers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x0004C5F8 File Offset: 0x0004A7F8
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x0000B0F3 File Offset: 0x000092F3
		public unsafe IAttribute<Nullable<int>> _Solari_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__Solari_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__Solari_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0004C628 File Offset: 0x0004A828
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x0000B112 File Offset: 0x00009312
		public unsafe IAttribute<Nullable<int>> _SpiceMustFlowAcquired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__SpiceMustFlowAcquired_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__SpiceMustFlowAcquired_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0004C658 File Offset: 0x0004A858
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x0000B131 File Offset: 0x00009331
		public unsafe IAttribute<List<ArchetypeID>> _DeckList_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__DeckList_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__DeckList_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0004C688 File Offset: 0x0004A888
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x0000B150 File Offset: 0x00009350
		public unsafe IAttribute<Dictionary<ArchetypeID, int>> _VisitedSpaces_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__VisitedSpaces_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Dictionary<ArchetypeID, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__VisitedSpaces_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0004C6B8 File Offset: 0x0004A8B8
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x0000B16F File Offset: 0x0000936F
		public unsafe ReadOnlyVersionedList<EntityComponent> _LocalPlayerAllianceTokens_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__LocalPlayerAllianceTokens_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__LocalPlayerAllianceTokens_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x0004C6E8 File Offset: 0x0004A8E8
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x0000B18E File Offset: 0x0000938E
		public unsafe IReadOnlyList<IAttribute<Nullable<int>>> _OtherPlayersSolari_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__OtherPlayersSolari_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<IAttribute<Nullable<int>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__OtherPlayersSolari_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0004C718 File Offset: 0x0004A918
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x0000B1AD File Offset: 0x000093AD
		public unsafe IAttribute<Nullable<int>> _TechTiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__TechTiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__TechTiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x0004C748 File Offset: 0x0004A948
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x0000B1CC File Offset: 0x000093CC
		public unsafe IAttribute<Nullable<int>> _FinalDeliveries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__FinalDeliveries_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__FinalDeliveries_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x0004C778 File Offset: 0x0004A978
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x0000B1EB File Offset: 0x000093EB
		public unsafe IAttribute<Nullable<int>> _GeneticMarkers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__GeneticMarkers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__GeneticMarkers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x0004C7A8 File Offset: 0x0004A9A8
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x0000B20A File Offset: 0x0000940A
		public unsafe IAttribute<Nullable<int>> _TleliaxuInfluence_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__TleliaxuInfluence_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__TleliaxuInfluence_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0004C7D8 File Offset: 0x0004A9D8
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x0000B229 File Offset: 0x00009429
		public unsafe IAttribute<Nullable<bool>> _HasHighCouncil_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__HasHighCouncil_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.NativeFieldInfoPtr__HasHighCouncil_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr__ControlMarkers_k__BackingField;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeFieldInfoPtr__Solari_k__BackingField;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr__SpiceMustFlowAcquired_k__BackingField;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr__DeckList_k__BackingField;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr__VisitedSpaces_k__BackingField;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerAllianceTokens_k__BackingField;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr__OtherPlayersSolari_k__BackingField;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeFieldInfoPtr__TechTiles_k__BackingField;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeFieldInfoPtr__FinalDeliveries_k__BackingField;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeFieldInfoPtr__GeneticMarkers_k__BackingField;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeFieldInfoPtr__TleliaxuInfluence_k__BackingField;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeFieldInfoPtr__HasHighCouncil_k__BackingField;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_ReadOnlyVersionedList_1_EntityComponent_IEnumerable_1_EntityComponent_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_get_ControlMarkers_Public_get_IAttribute_1_Nullable_1_Int32_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_get_Solari_Public_get_IAttribute_1_Nullable_1_Int32_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_get_SpiceMustFlowAcquired_Public_get_IAttribute_1_Nullable_1_Int32_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_get_DeckList_Public_get_IAttribute_1_List_1_ArchetypeID_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_get_VisitedSpaces_Public_get_IAttribute_1_Dictionary_2_ArchetypeID_Int32_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerAllianceTokens_Public_get_ReadOnlyVersionedList_1_EntityComponent_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_get_OtherPlayersSolari_Public_get_IReadOnlyList_1_IAttribute_1_Nullable_1_Int32_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_get_TechTiles_Public_get_IAttribute_1_Nullable_1_Int32_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalDeliveries_Public_get_IAttribute_1_Nullable_1_Int32_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneticMarkers_Public_get_IAttribute_1_Nullable_1_Int32_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_get_TleliaxuInfluence_Public_get_IAttribute_1_Nullable_1_Int32_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_get_HasHighCouncil_Public_get_IAttribute_1_Nullable_1_Boolean_0;

		// Token: 0x020003BB RID: 955
		[ObfuscatedName("worm.match.data.WormChallengeProgressData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002690 RID: 9872 RVA: 0x0008D2EC File Offset: 0x0008B4EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormChallengeProgressData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengeProgressData.__c>.NativeClassPtr);
				WormChallengeProgressData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData.__c>.NativeClassPtr, "<>9");
				WormChallengeProgressData.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData.__c>.NativeClassPtr, "<>9__1_1");
				WormChallengeProgressData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData.__c>.NativeClassPtr, 100665699);
				WormChallengeProgressData.__c.NativeMethodInfoPtr___ctor_b__1_1_Internal_ReadOnlyAttribute_1_Nullable_1_Int32_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData.__c>.NativeClassPtr, 100665700);
			}

			// Token: 0x06002691 RID: 9873 RVA: 0x0008D368 File Offset: 0x0008B568
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengeProgressData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002692 RID: 9874 RVA: 0x0008D3A4 File Offset: 0x0008B5A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710980, XrefRangeEnd = 710985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttribute<Nullable<int>> __ctor_b__1_1(EntityComponent p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.__c.NativeMethodInfoPtr___ctor_b__1_1_Internal_ReadOnlyAttribute_1_Nullable_1_Int32_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<int>>>(intPtr3) : null;
				}
			}

			// Token: 0x06002693 RID: 9875 RVA: 0x000154AA File Offset: 0x000136AA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AB6 RID: 2742
			// (get) Token: 0x06002694 RID: 9876 RVA: 0x0008D3F4 File Offset: 0x0008B5F4
			// (set) Token: 0x06002695 RID: 9877 RVA: 0x000154B3 File Offset: 0x000136B3
			public unsafe static WormChallengeProgressData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChallengeProgressData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChallengeProgressData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChallengeProgressData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AB7 RID: 2743
			// (get) Token: 0x06002696 RID: 9878 RVA: 0x0008D41C File Offset: 0x0008B61C
			// (set) Token: 0x06002697 RID: 9879 RVA: 0x000154C5 File Offset: 0x000136C5
			public unsafe static Func<EntityComponent, ReadOnlyAttribute<Nullable<int>>> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChallengeProgressData.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, ReadOnlyAttribute<Nullable<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChallengeProgressData.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001635 RID: 5685
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001636 RID: 5686
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x04001637 RID: 5687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001638 RID: 5688
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_1_Internal_ReadOnlyAttribute_1_Nullable_1_Int32_EntityComponent_0;
		}

		// Token: 0x020003BC RID: 956
		[ObfuscatedName("worm.match.data.WormChallengeProgressData+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06002698 RID: 9880 RVA: 0x0008D444 File Offset: 0x0008B644
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormChallengeProgressData.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChallengeProgressData>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengeProgressData.__c__DisplayClass1_0>.NativeClassPtr);
				WormChallengeProgressData.__c__DisplayClass1_0.NativeFieldInfoPtr_localPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeProgressData.__c__DisplayClass1_0>.NativeClassPtr, "localPlayer");
				WormChallengeProgressData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData.__c__DisplayClass1_0>.NativeClassPtr, 100665701);
				WormChallengeProgressData.__c__DisplayClass1_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeProgressData.__c__DisplayClass1_0>.NativeClassPtr, 100665702);
			}

			// Token: 0x06002699 RID: 9881 RVA: 0x0008D4AC File Offset: 0x0008B6AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengeProgressData.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600269A RID: 9882 RVA: 0x0008D4E8 File Offset: 0x0008B6E8
			[CallerCount(0)]
			public unsafe bool __ctor_b__0(EntityComponent p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeProgressData.__c__DisplayClass1_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600269B RID: 9883 RVA: 0x000154D7 File Offset: 0x000136D7
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AB8 RID: 2744
			// (get) Token: 0x0600269C RID: 9884 RVA: 0x0008D538 File Offset: 0x0008B738
			// (set) Token: 0x0600269D RID: 9885 RVA: 0x000154E0 File Offset: 0x000136E0
			public unsafe EntityComponent localPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.__c__DisplayClass1_0.NativeFieldInfoPtr_localPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeProgressData.__c__DisplayClass1_0.NativeFieldInfoPtr_localPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001639 RID: 5689
			private static readonly IntPtr NativeFieldInfoPtr_localPlayer;

			// Token: 0x0400163A RID: 5690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400163B RID: 5691
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_EntityComponent_0;
		}
	}
}
