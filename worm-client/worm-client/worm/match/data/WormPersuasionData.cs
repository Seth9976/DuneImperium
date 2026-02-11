using System;
using Canis.attributes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.match.data
{
	// Token: 0x02000196 RID: 406
	public class WormPersuasionData : DataComponent
	{
		// Token: 0x0600122B RID: 4651 RVA: 0x0004EFF8 File Offset: 0x0004D1F8
		// Note: this type is marked as 'beforefieldinit'.
		static WormPersuasionData()
		{
			Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormPersuasionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr);
			WormPersuasionData.NativeFieldInfoPtr_persuasionAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr, "persuasionAttribute");
			WormPersuasionData.NativeFieldInfoPtr_revealPreviewAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr, "revealPreviewAttribute");
			WormPersuasionData.NativeFieldInfoPtr_playerTurnAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr, "playerTurnAttribute");
			WormPersuasionData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_Nullable_1_Int32_IAttribute_1_Dictionary_2_String_Int32_IAttribute_1_Nullable_1_PlayerTurnTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr, 100665779);
			WormPersuasionData.NativeMethodInfoPtr_get_Persuasion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr, 100665780);
			WormPersuasionData.NativeMethodInfoPtr_get_RevealPreview_Public_get_IReadOnlyDictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr, 100665781);
			WormPersuasionData.NativeMethodInfoPtr_get_TurnType_Public_get_PlayerTurnTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr, 100665782);
			WormPersuasionData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr, 100665783);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0004F0C8 File Offset: 0x0004D2C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 711769, RefRangeEnd = 711771, XrefRangeStart = 711765, XrefRangeEnd = 711769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPersuasionData(IAttribute<Nullable<int>> persuasionAttribute, IAttribute<Dictionary<string, int>> revealPreviewAttribute, IAttribute<Nullable<PlayerTurnTypes>> playerTurnAttribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPersuasionData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(persuasionAttribute);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(revealPreviewAttribute);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerTurnAttribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPersuasionData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_Nullable_1_Int32_IAttribute_1_Dictionary_2_String_Int32_IAttribute_1_Nullable_1_PlayerTurnTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0004F138 File Offset: 0x0004D338
		public unsafe int Persuasion
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 711775, RefRangeEnd = 711777, XrefRangeStart = 711771, XrefRangeEnd = 711775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPersuasionData.NativeMethodInfoPtr_get_Persuasion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x0004F174 File Offset: 0x0004D374
		public unsafe IReadOnlyDictionary<string, int> RevealPreview
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 711781, RefRangeEnd = 711786, XrefRangeStart = 711777, XrefRangeEnd = 711781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPersuasionData.NativeMethodInfoPtr_get_RevealPreview_Public_get_IReadOnlyDictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x0004F1B4 File Offset: 0x0004D3B4
		public unsafe PlayerTurnTypes TurnType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 711790, RefRangeEnd = 711791, XrefRangeStart = 711786, XrefRangeEnd = 711790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPersuasionData.NativeMethodInfoPtr_get_TurnType_Public_get_PlayerTurnTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x0004F1F0 File Offset: 0x0004D3F0
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711791, XrefRangeEnd = 711798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPersuasionData.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0000B7AD File Offset: 0x000099AD
		public WormPersuasionData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x0004F22C File Offset: 0x0004D42C
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x0000B7B6 File Offset: 0x000099B6
		public unsafe IAttribute<Nullable<int>> persuasionAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPersuasionData.NativeFieldInfoPtr_persuasionAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPersuasionData.NativeFieldInfoPtr_persuasionAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x0004F25C File Offset: 0x0004D45C
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x0000B7D5 File Offset: 0x000099D5
		public unsafe IAttribute<Dictionary<string, int>> revealPreviewAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPersuasionData.NativeFieldInfoPtr_revealPreviewAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Dictionary<string, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPersuasionData.NativeFieldInfoPtr_revealPreviewAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x0004F28C File Offset: 0x0004D48C
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x0000B7F4 File Offset: 0x000099F4
		public unsafe IAttribute<Nullable<PlayerTurnTypes>> playerTurnAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPersuasionData.NativeFieldInfoPtr_playerTurnAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<PlayerTurnTypes>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPersuasionData.NativeFieldInfoPtr_playerTurnAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeFieldInfoPtr_persuasionAttribute;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr_revealPreviewAttribute;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeFieldInfoPtr_playerTurnAttribute;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_Nullable_1_Int32_IAttribute_1_Dictionary_2_String_Int32_IAttribute_1_Nullable_1_PlayerTurnTypes_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_get_Persuasion_Public_get_Int32_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_get_RevealPreview_Public_get_IReadOnlyDictionary_2_String_Int32_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_get_TurnType_Public_get_PlayerTurnTypes_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;
	}
}
