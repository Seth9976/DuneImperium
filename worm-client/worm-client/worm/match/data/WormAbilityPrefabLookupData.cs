using System;
using boardgames.match.data;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.data
{
	// Token: 0x0200017B RID: 379
	public class WormAbilityPrefabLookupData : PrefabLookupData
	{
		// Token: 0x06001101 RID: 4353 RVA: 0x0004B2F8 File Offset: 0x000494F8
		// Note: this type is marked as 'beforefieldinit'.
		static WormAbilityPrefabLookupData()
		{
			Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormAbilityPrefabLookupData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr);
			WormAbilityPrefabLookupData.NativeFieldInfoPtr_abilityIDAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr, "abilityIDAttribute");
			WormAbilityPrefabLookupData.NativeFieldInfoPtr_flavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr, "flavors");
			WormAbilityPrefabLookupData.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr, "cachedVersion");
			WormAbilityPrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr, 100665661);
			WormAbilityPrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr, 100665662);
			WormAbilityPrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr, 100665663);
			WormAbilityPrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr, 100665664);
			WormAbilityPrefabLookupData.NativeMethodInfoPtr_RebuildFlavors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr, 100665665);
			WormAbilityPrefabLookupData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr, 100665666);
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0004B3DC File Offset: 0x000495DC
		public unsafe override HashSet<string> Flavors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710689, XrefRangeEnd = 710708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityPrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0004B428 File Offset: 0x00049628
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710708, XrefRangeEnd = 710712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityPrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0004B470 File Offset: 0x00049670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 710729, RefRangeEnd = 710730, XrefRangeStart = 710712, XrefRangeEnd = 710729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAbilityPrefabLookupData(EntityComponent entityComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityPrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0004B4BC File Offset: 0x000496BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 710745, RefRangeEnd = 710746, XrefRangeStart = 710730, XrefRangeEnd = 710745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAbilityPrefabLookupData(AbilityID id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityPrefabLookupData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityPrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0004B508 File Offset: 0x00049708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710746, XrefRangeEnd = 710765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityPrefabLookupData.NativeMethodInfoPtr_RebuildFlavors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0004B53C File Offset: 0x0004973C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710765, XrefRangeEnd = 710774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityPrefabLookupData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0000AED5 File Offset: 0x000090D5
		public WormAbilityPrefabLookupData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0004B580 File Offset: 0x00049780
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x0000AEDE File Offset: 0x000090DE
		public unsafe IAttribute<AbilityID> abilityIDAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityPrefabLookupData.NativeFieldInfoPtr_abilityIDAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<AbilityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityPrefabLookupData.NativeFieldInfoPtr_abilityIDAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x0004B5B0 File Offset: 0x000497B0
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x0000AEFD File Offset: 0x000090FD
		public unsafe HashSet<string> flavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityPrefabLookupData.NativeFieldInfoPtr_flavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityPrefabLookupData.NativeFieldInfoPtr_flavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x0004B5E0 File Offset: 0x000497E0
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x0000AF1C File Offset: 0x0000911C
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityPrefabLookupData.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityPrefabLookupData.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeFieldInfoPtr_abilityIDAttribute;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeFieldInfoPtr_flavors;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AbilityID_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_RebuildFlavors_Private_Void_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
