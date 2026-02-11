using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.data.readonlyWrappers;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.match.data
{
	// Token: 0x0200017C RID: 380
	public class WormBonusPersuasionData : VersionedDataComponent
	{
		// Token: 0x0600110F RID: 4367 RVA: 0x0004B608 File Offset: 0x00049808
		// Note: this type is marked as 'beforefieldinit'.
		static WormBonusPersuasionData()
		{
			Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormBonusPersuasionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr);
			WormBonusPersuasionData.NativeFieldInfoPtr_highCouncilAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr, "highCouncilAttributes");
			WormBonusPersuasionData.NativeFieldInfoPtr_HighCouncilAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr, "HighCouncilAttributes");
			WormBonusPersuasionData.NativeFieldInfoPtr_bonusPersuasionSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr, "bonusPersuasionSpaces");
			WormBonusPersuasionData.NativeFieldInfoPtr_BonusPersuasionSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr, "BonusPersuasionSpaces");
			WormBonusPersuasionData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr, 100665667);
			WormBonusPersuasionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr, 100665668);
			WormBonusPersuasionData.NativeMethodInfoPtr_RegisterPlayerAttribute_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr, 100665669);
			WormBonusPersuasionData.NativeMethodInfoPtr_RegisterSpace_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr, 100665670);
			WormBonusPersuasionData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr, 100665671);
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0004B6EC File Offset: 0x000498EC
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710774, XrefRangeEnd = 710807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBonusPersuasionData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0004B734 File Offset: 0x00049934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 710836, RefRangeEnd = 710838, XrefRangeStart = 710807, XrefRangeEnd = 710836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBonusPersuasionData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBonusPersuasionData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBonusPersuasionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0004B770 File Offset: 0x00049970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 710849, RefRangeEnd = 710850, XrefRangeStart = 710838, XrefRangeEnd = 710849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterPlayerAttribute(EntityComponent player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBonusPersuasionData.NativeMethodInfoPtr_RegisterPlayerAttribute_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0004B7B4 File Offset: 0x000499B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 710856, RefRangeEnd = 710857, XrefRangeStart = 710850, XrefRangeEnd = 710856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSpace(EntityComponent space)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBonusPersuasionData.NativeMethodInfoPtr_RegisterSpace_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0004B7F8 File Offset: 0x000499F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710857, XrefRangeEnd = 710866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBonusPersuasionData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0000AF37 File Offset: 0x00009137
		public WormBonusPersuasionData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0004B83C File Offset: 0x00049A3C
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x0000AF40 File Offset: 0x00009140
		public unsafe Dictionary<AccountID, IAttribute<Nullable<bool>>> highCouncilAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusPersuasionData.NativeFieldInfoPtr_highCouncilAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, IAttribute<Nullable<bool>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusPersuasionData.NativeFieldInfoPtr_highCouncilAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0004B86C File Offset: 0x00049A6C
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x0000AF5F File Offset: 0x0000915F
		public unsafe ReadOnlyDictionary<AccountID, IAttribute<Nullable<bool>>> HighCouncilAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusPersuasionData.NativeFieldInfoPtr_HighCouncilAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<AccountID, IAttribute<Nullable<bool>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusPersuasionData.NativeFieldInfoPtr_HighCouncilAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0004B89C File Offset: 0x00049A9C
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x0000AF7E File Offset: 0x0000917E
		public unsafe List<EntityComponent> bonusPersuasionSpaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusPersuasionData.NativeFieldInfoPtr_bonusPersuasionSpaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusPersuasionData.NativeFieldInfoPtr_bonusPersuasionSpaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x0004B8CC File Offset: 0x00049ACC
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x0000AF9D File Offset: 0x0000919D
		public unsafe ReadOnlyList<EntityComponent> BonusPersuasionSpaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusPersuasionData.NativeFieldInfoPtr_BonusPersuasionSpaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormBonusPersuasionData.NativeFieldInfoPtr_BonusPersuasionSpaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr_highCouncilAttributes;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_HighCouncilAttributes;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr_bonusPersuasionSpaces;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeFieldInfoPtr_BonusPersuasionSpaces;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_RegisterPlayerAttribute_Public_Void_EntityComponent_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSpace_Public_Void_EntityComponent_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
