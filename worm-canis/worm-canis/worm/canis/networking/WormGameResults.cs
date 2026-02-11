using System;
using canis.Networking.game.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.networking
{
	// Token: 0x02000015 RID: 21
	public class WormGameResults : DBGGameResults
	{
		// Token: 0x0600011D RID: 285 RVA: 0x0006E940 File Offset: 0x0006CB40
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResults()
		{
			Il2CppClassPointerStore<WormGameResults>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.networking", "WormGameResults");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr);
			WormGameResults.NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, "results");
			WormGameResults.NativeFieldInfoPtr_MatchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, "MatchType");
			WormGameResults.NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, "GameMode");
			WormGameResults.NativeFieldInfoPtr_EventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, "EventID");
			WormGameResults.NativeFieldInfoPtr_RoundID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, "RoundID");
			WormGameResults.NativeFieldInfoPtr_Expansions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, "Expansions");
			WormGameResults.NativeMethodInfoPtr_get_baseResults_Public_Virtual_get_IEnumerable_1_DBGGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, 100663773);
			WormGameResults.NativeMethodInfoPtr_get_entries_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_WormGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, 100663774);
			WormGameResults.NativeMethodInfoPtr_MakeFilters_Private_Dictionary_2_String_String_WormGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, 100663775);
			WormGameResults.NativeMethodInfoPtr_MakeGameProperties_Private_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, 100663776);
			WormGameResults.NativeMethodInfoPtr_MakeMatchHistory_Public_Virtual_Final_New_MatchHistoryEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, 100663777);
			WormGameResults.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr, 100663778);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0006EA60 File Offset: 0x0006CC60
		public unsafe override IEnumerable<DBGGameResultsEntry> baseResults
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResults.NativeMethodInfoPtr_get_baseResults_Public_Virtual_get_IEnumerable_1_DBGGameResultsEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DBGGameResultsEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0006EAAC File Offset: 0x0006CCAC
		public unsafe virtual Il2CppReferenceArray<WormGameResultsEntry> entries
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 31271, RefRangeEnd = 31276, XrefRangeStart = 31268, XrefRangeEnd = 31271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResults.NativeMethodInfoPtr_get_entries_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_WormGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormGameResultsEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0006EAEC File Offset: 0x0006CCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31276, XrefRangeEnd = 31287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, string> MakeFilters(WormGameResults results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResults.NativeMethodInfoPtr_MakeFilters_Private_Dictionary_2_String_String_WormGameResults_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0006EB3C File Offset: 0x0006CD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31287, XrefRangeEnd = 31313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, string> MakeGameProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResults.NativeMethodInfoPtr_MakeGameProperties_Private_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0006EB7C File Offset: 0x0006CD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31313, XrefRangeEnd = 31354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MatchHistoryEntry MakeMatchHistory(string client)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(client);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResults.NativeMethodInfoPtr_MakeMatchHistory_Public_Virtual_Final_New_MatchHistoryEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchHistoryEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0006EBCC File Offset: 0x0006CDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31354, XrefRangeEnd = 31355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResults()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResults>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResults.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000024B2 File Offset: 0x000006B2
		public WormGameResults(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0006EC08 File Offset: 0x0006CE08
		// (set) Token: 0x06000126 RID: 294 RVA: 0x000024BB File Offset: 0x000006BB
		public unsafe Il2CppReferenceArray<WormGameResultsEntry> results
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_results);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormGameResultsEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_results), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0006EC38 File Offset: 0x0006CE38
		// (set) Token: 0x06000128 RID: 296 RVA: 0x000024DA File Offset: 0x000006DA
		public unsafe string MatchType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_MatchType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_MatchType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0006EC60 File Offset: 0x0006CE60
		// (set) Token: 0x0600012A RID: 298 RVA: 0x000024F9 File Offset: 0x000006F9
		public unsafe string GameMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_GameMode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_GameMode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0006EC88 File Offset: 0x0006CE88
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002518 File Offset: 0x00000718
		public unsafe EventID EventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_EventID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_EventID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0006ECB8 File Offset: 0x0006CEB8
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002537 File Offset: 0x00000737
		public unsafe RoundID RoundID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_RoundID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_RoundID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0006ECE8 File Offset: 0x0006CEE8
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002556 File Offset: 0x00000756
		public unsafe List<string> Expansions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_Expansions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResults.NativeFieldInfoPtr_Expansions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_results;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_MatchType;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_GameMode;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_EventID;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_RoundID;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_Expansions;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_baseResults_Public_Virtual_get_IEnumerable_1_DBGGameResultsEntry_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_entries_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_WormGameResultsEntry_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_MakeFilters_Private_Dictionary_2_String_String_WormGameResults_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameProperties_Private_Dictionary_2_String_String_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_MakeMatchHistory_Public_Virtual_Final_New_MatchHistoryEntry_String_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
