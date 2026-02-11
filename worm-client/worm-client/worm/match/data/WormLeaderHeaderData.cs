using System;
using boardgames.match;
using boardgames.match.selection;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.data
{
	// Token: 0x02000193 RID: 403
	public class WormLeaderHeaderData : VersionedDataComponent
	{
		// Token: 0x06001205 RID: 4613 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
		// Note: this type is marked as 'beforefieldinit'.
		static WormLeaderHeaderData()
		{
			Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormLeaderHeaderData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr);
			WormLeaderHeaderData.NativeFieldInfoPtr_hasSelectedLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, "hasSelectedLeader");
			WormLeaderHeaderData.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, "entities");
			WormLeaderHeaderData.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, "selectionResponder");
			WormLeaderHeaderData.NativeFieldInfoPtr_nonSelectionPromptTextAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, "nonSelectionPromptTextAttribute");
			WormLeaderHeaderData.NativeFieldInfoPtr_currentSelectionPlayerAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, "currentSelectionPlayerAttribute");
			WormLeaderHeaderData.NativeFieldInfoPtr_waitingLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, "waitingLocKey");
			WormLeaderHeaderData.NativeFieldInfoPtr_chooseLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, "chooseLocKey");
			WormLeaderHeaderData.NativeFieldInfoPtr_cachedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, "cachedText");
			WormLeaderHeaderData.NativeFieldInfoPtr_cachedTextVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, "cachedTextVersion");
			WormLeaderHeaderData.NativeMethodInfoPtr__ctor_Public_Void_DBGEntities_DBGSelectionResponder_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, 100665767);
			WormLeaderHeaderData.NativeMethodInfoPtr_get_HasSelectedLeader_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, 100665768);
			WormLeaderHeaderData.NativeMethodInfoPtr_set_HasSelectedLeader_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, 100665769);
			WormLeaderHeaderData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, 100665770);
			WormLeaderHeaderData.NativeMethodInfoPtr_get_DisplayText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, 100665771);
			WormLeaderHeaderData.NativeMethodInfoPtr_GetDisplayText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr, 100665772);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0004E9FC File Offset: 0x0004CBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711687, XrefRangeEnd = 711712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeaderHeaderData(DBGEntities entities, DBGSelectionResponder selectionResponder, string waitingLocKey, string chooseLocKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderHeaderData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionResponder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(waitingLocKey);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(chooseLocKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderHeaderData.NativeMethodInfoPtr__ctor_Public_Void_DBGEntities_DBGSelectionResponder_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x0004EA80 File Offset: 0x0004CC80
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x0004EABC File Offset: 0x0004CCBC
		public unsafe bool HasSelectedLeader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderHeaderData.NativeMethodInfoPtr_get_HasSelectedLeader_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderHeaderData.NativeMethodInfoPtr_set_HasSelectedLeader_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x0004EAFC File Offset: 0x0004CCFC
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711712, XrefRangeEnd = 711717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLeaderHeaderData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x0004EB44 File Offset: 0x0004CD44
		public unsafe string DisplayText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711717, XrefRangeEnd = 711719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderHeaderData.NativeMethodInfoPtr_get_DisplayText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0004EB7C File Offset: 0x0004CD7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 711731, RefRangeEnd = 711733, XrefRangeStart = 711719, XrefRangeEnd = 711731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderHeaderData.NativeMethodInfoPtr_GetDisplayText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0000B664 File Offset: 0x00009864
		public WormLeaderHeaderData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0004EBB4 File Offset: 0x0004CDB4
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x0000B66D File Offset: 0x0000986D
		public unsafe bool hasSelectedLeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_hasSelectedLeader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_hasSelectedLeader)) = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0004EBDC File Offset: 0x0004CDDC
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x0000B688 File Offset: 0x00009888
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0004EC0C File Offset: 0x0004CE0C
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x0000B6A7 File Offset: 0x000098A7
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x0004EC3C File Offset: 0x0004CE3C
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x0000B6C6 File Offset: 0x000098C6
		public unsafe IAttribute<LocalizableTextVariables> nonSelectionPromptTextAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_nonSelectionPromptTextAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<LocalizableTextVariables>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_nonSelectionPromptTextAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x0004EC6C File Offset: 0x0004CE6C
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x0000B6E5 File Offset: 0x000098E5
		public unsafe IAttribute<AccountID> currentSelectionPlayerAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_currentSelectionPlayerAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_currentSelectionPlayerAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0004EC9C File Offset: 0x0004CE9C
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x0000B704 File Offset: 0x00009904
		public unsafe string waitingLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_waitingLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_waitingLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x0004ECC4 File Offset: 0x0004CEC4
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x0000B723 File Offset: 0x00009923
		public unsafe string chooseLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_chooseLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_chooseLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0004ECEC File Offset: 0x0004CEEC
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x0000B742 File Offset: 0x00009942
		public unsafe string cachedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_cachedText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_cachedText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x0004ED14 File Offset: 0x0004CF14
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x0000B761 File Offset: 0x00009961
		public unsafe ulong cachedTextVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_cachedTextVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderHeaderData.NativeFieldInfoPtr_cachedTextVersion)) = value;
			}
		}

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeFieldInfoPtr_hasSelectedLeader;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeFieldInfoPtr_nonSelectionPromptTextAttribute;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeFieldInfoPtr_currentSelectionPlayerAttribute;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeFieldInfoPtr_waitingLocKey;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeFieldInfoPtr_chooseLocKey;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeFieldInfoPtr_cachedText;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeFieldInfoPtr_cachedTextVersion;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DBGEntities_DBGSelectionResponder_String_String_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSelectedLeader_Public_get_Boolean_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_set_HasSelectedLeader_Public_set_Void_Boolean_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayText_Public_get_String_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayText_Private_String_0;
	}
}
