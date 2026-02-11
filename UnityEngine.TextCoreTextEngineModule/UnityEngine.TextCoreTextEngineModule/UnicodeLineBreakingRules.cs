using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public class UnicodeLineBreakingRules : Object
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x0001B7A4 File Offset: 0x000199A4
		// Note: this type is marked as 'beforefieldinit'.
		static UnicodeLineBreakingRules()
		{
			Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "UnicodeLineBreakingRules");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr);
			UnicodeLineBreakingRules.NativeFieldInfoPtr_m_UnicodeLineBreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_UnicodeLineBreakingRules");
			UnicodeLineBreakingRules.NativeFieldInfoPtr_m_LeadingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_LeadingCharacters");
			UnicodeLineBreakingRules.NativeFieldInfoPtr_m_FollowingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_FollowingCharacters");
			UnicodeLineBreakingRules.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_UseModernHangulLineBreakingRules");
			UnicodeLineBreakingRules.NativeFieldInfoPtr_m_LeadingCharactersLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_LeadingCharactersLookup");
			UnicodeLineBreakingRules.NativeFieldInfoPtr_m_FollowingCharactersLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, "m_FollowingCharactersLookup");
			UnicodeLineBreakingRules.NativeMethodInfoPtr_get_leadingCharacters_Public_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100663760);
			UnicodeLineBreakingRules.NativeMethodInfoPtr_get_followingCharacters_Public_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100663761);
			UnicodeLineBreakingRules.NativeMethodInfoPtr_get_leadingCharactersLookup_Internal_get_HashSet_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100663762);
			UnicodeLineBreakingRules.NativeMethodInfoPtr_get_followingCharactersLookup_Internal_get_HashSet_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100663763);
			UnicodeLineBreakingRules.NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100663764);
			UnicodeLineBreakingRules.NativeMethodInfoPtr_LoadLineBreakingRules_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100663765);
			UnicodeLineBreakingRules.NativeMethodInfoPtr_LoadLineBreakingRules_Internal_Void_TextAsset_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100663766);
			UnicodeLineBreakingRules.NativeMethodInfoPtr_GetCharacters_Private_Static_HashSet_1_UInt32_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100663767);
			UnicodeLineBreakingRules.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr, 100663768);
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0001B900 File Offset: 0x00019B00
		public unsafe TextAsset leadingCharacters
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeLineBreakingRules.NativeMethodInfoPtr_get_leadingCharacters_Public_get_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr3) : null;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0001B940 File Offset: 0x00019B40
		public unsafe TextAsset followingCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeLineBreakingRules.NativeMethodInfoPtr_get_followingCharacters_Public_get_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr3) : null;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0001B980 File Offset: 0x00019B80
		public unsafe HashSet<uint> leadingCharactersLookup
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1106297, RefRangeEnd = 1106300, XrefRangeStart = 1106296, XrefRangeEnd = 1106297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeLineBreakingRules.NativeMethodInfoPtr_get_leadingCharactersLookup_Internal_get_HashSet_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr3) : null;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		public unsafe HashSet<uint> followingCharactersLookup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1106301, RefRangeEnd = 1106302, XrefRangeStart = 1106300, XrefRangeEnd = 1106301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeLineBreakingRules.NativeMethodInfoPtr_get_followingCharactersLookup_Internal_get_HashSet_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr3) : null;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0001BA00 File Offset: 0x00019C00
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00006211 File Offset: 0x00004411
		public unsafe bool useModernHangulLineBreakingRules
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeLineBreakingRules.NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_UseModernHangulLineBreakingRules = value;
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0001BA3C File Offset: 0x00019C3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1106342, RefRangeEnd = 1106345, XrefRangeStart = 1106302, XrefRangeEnd = 1106342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLineBreakingRules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeLineBreakingRules.NativeMethodInfoPtr_LoadLineBreakingRules_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0001BA70 File Offset: 0x00019C70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1106383, RefRangeEnd = 1106385, XrefRangeStart = 1106345, XrefRangeEnd = 1106383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLineBreakingRules(TextAsset leadingRules, TextAsset followingRules)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leadingRules);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followingRules);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeLineBreakingRules.NativeMethodInfoPtr_LoadLineBreakingRules_Internal_Void_TextAsset_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0001BAC4 File Offset: 0x00019CC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1106397, RefRangeEnd = 1106401, XrefRangeStart = 1106385, XrefRangeEnd = 1106397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashSet<uint> GetCharacters(TextAsset file)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeLineBreakingRules.NativeMethodInfoPtr_GetCharacters_Private_Static_HashSet_1_UInt32_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr3) : null;
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0001BB08 File Offset: 0x00019D08
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnicodeLineBreakingRules()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnicodeLineBreakingRules>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeLineBreakingRules.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0000614A File Offset: 0x0000434A
		public UnicodeLineBreakingRules(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x0001BB44 File Offset: 0x00019D44
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00006153 File Offset: 0x00004353
		public unsafe TextAsset m_UnicodeLineBreakingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_UnicodeLineBreakingRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_UnicodeLineBreakingRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0001BB74 File Offset: 0x00019D74
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00006172 File Offset: 0x00004372
		public unsafe TextAsset m_LeadingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_LeadingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_LeadingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00006191 File Offset: 0x00004391
		public unsafe TextAsset m_FollowingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_FollowingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_FollowingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0001BBD4 File Offset: 0x00019DD4
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x000061B0 File Offset: 0x000043B0
		public unsafe bool m_UseModernHangulLineBreakingRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules)) = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0001BBFC File Offset: 0x00019DFC
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x000061CB File Offset: 0x000043CB
		public unsafe HashSet<uint> m_LeadingCharactersLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_LeadingCharactersLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_LeadingCharactersLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0001BC2C File Offset: 0x00019E2C
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x000061EA File Offset: 0x000043EA
		public unsafe HashSet<uint> m_FollowingCharactersLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_FollowingCharactersLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeLineBreakingRules.NativeFieldInfoPtr_m_FollowingCharactersLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00006209 File Offset: 0x00004409
		public TextAsset lineBreakingRules
		{
			get
			{
				return this.m_UnicodeLineBreakingRules;
			}
		}

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeFieldInfoPtr_m_UnicodeLineBreakingRules;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeFieldInfoPtr_m_LeadingCharacters;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr_m_FollowingCharacters;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr_m_UseModernHangulLineBreakingRules;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_m_LeadingCharactersLookup;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_m_FollowingCharactersLookup;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_get_leadingCharacters_Public_get_TextAsset_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_get_followingCharacters_Public_get_TextAsset_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_get_leadingCharactersLookup_Internal_get_HashSet_1_UInt32_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_get_followingCharactersLookup_Internal_get_HashSet_1_UInt32_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_get_useModernHangulLineBreakingRules_Public_get_Boolean_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_LoadLineBreakingRules_Internal_Void_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_LoadLineBreakingRules_Internal_Void_TextAsset_TextAsset_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacters_Private_Static_HashSet_1_UInt32_TextAsset_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
