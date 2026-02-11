using System;
using boardgames.match.data;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.match.data
{
	// Token: 0x0200017F RID: 383
	public class WormCardPrefabLookupData : PrefabLookupData
	{
		// Token: 0x0600112F RID: 4399 RVA: 0x0004BCA0 File Offset: 0x00049EA0
		// Note: this type is marked as 'beforefieldinit'.
		static WormCardPrefabLookupData()
		{
			Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormCardPrefabLookupData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr);
			WormCardPrefabLookupData.NativeFieldInfoPtr_archetypeIDAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr, "archetypeIDAttribute");
			WormCardPrefabLookupData.NativeFieldInfoPtr_entityTypeAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr, "entityTypeAttribute");
			WormCardPrefabLookupData.NativeFieldInfoPtr_flavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr, "flavors");
			WormCardPrefabLookupData.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr, "cachedVersion");
			WormCardPrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr, 100665679);
			WormCardPrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr, 100665680);
			WormCardPrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr, 100665681);
			WormCardPrefabLookupData.NativeMethodInfoPtr_RebuildFlavors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr, 100665682);
			WormCardPrefabLookupData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr, 100665683);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0004BD84 File Offset: 0x00049F84
		public unsafe override HashSet<string> Flavors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710907, XrefRangeEnd = 710908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardPrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0004BDD0 File Offset: 0x00049FD0
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710908, XrefRangeEnd = 710913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardPrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0004BE18 File Offset: 0x0004A018
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 710940, RefRangeEnd = 710944, XrefRangeStart = 710913, XrefRangeEnd = 710940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCardPrefabLookupData(IHasAttributes entityComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCardPrefabLookupData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardPrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0004BE64 File Offset: 0x0004A064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 710973, RefRangeEnd = 710974, XrefRangeStart = 710944, XrefRangeEnd = 710973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardPrefabLookupData.NativeMethodInfoPtr_RebuildFlavors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0004BE98 File Offset: 0x0004A098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710974, XrefRangeEnd = 710980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardPrefabLookupData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0000B02B File Offset: 0x0000922B
		public WormCardPrefabLookupData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0004BEDC File Offset: 0x0004A0DC
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x0000B034 File Offset: 0x00009234
		public unsafe IAttribute<ArchetypeID> archetypeIDAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardPrefabLookupData.NativeFieldInfoPtr_archetypeIDAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardPrefabLookupData.NativeFieldInfoPtr_archetypeIDAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0004BF0C File Offset: 0x0004A10C
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x0000B053 File Offset: 0x00009253
		public unsafe IAttribute<Nullable<EntityTypes>> entityTypeAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardPrefabLookupData.NativeFieldInfoPtr_entityTypeAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<EntityTypes>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardPrefabLookupData.NativeFieldInfoPtr_entityTypeAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x0004BF3C File Offset: 0x0004A13C
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x0000B072 File Offset: 0x00009272
		public unsafe HashSet<string> flavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardPrefabLookupData.NativeFieldInfoPtr_flavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardPrefabLookupData.NativeFieldInfoPtr_flavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0004BF6C File Offset: 0x0004A16C
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x0000B091 File Offset: 0x00009291
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardPrefabLookupData.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardPrefabLookupData.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeFieldInfoPtr_archetypeIDAttribute;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeFieldInfoPtr_entityTypeAttribute;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeFieldInfoPtr_flavors;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHasAttributes_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_RebuildFlavors_Private_Void_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
