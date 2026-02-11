using System;
using analytics;
using boardgames.match.data;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace zen.analytics.messages
{
	// Token: 0x02000093 RID: 147
	public class AnalyticsOfflineGameResults : IAnalyticsMessage
	{
		// Token: 0x06000730 RID: 1840 RVA: 0x000279D8 File Offset: 0x00025BD8
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsOfflineGameResults()
		{
			Il2CppClassPointerStore<AnalyticsOfflineGameResults>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsOfflineGameResults");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsOfflineGameResults>.NativeClassPtr);
			AnalyticsOfflineGameResults.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsOfflineGameResults>.NativeClassPtr, "data");
			AnalyticsOfflineGameResults.NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_GameOptionsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsOfflineGameResults>.NativeClassPtr, 100664462);
			AnalyticsOfflineGameResults.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsOfflineGameResults>.NativeClassPtr, 100664463);
			AnalyticsOfflineGameResults.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsOfflineGameResults>.NativeClassPtr, 100664464);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00027A58 File Offset: 0x00025C58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 990432, RefRangeEnd = 990433, XrefRangeStart = 990368, XrefRangeEnd = 990432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsOfflineGameResults(DBGGameResults results, GameOptionsData gameOptionsData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsOfflineGameResults>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameOptionsData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsOfflineGameResults.NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_GameOptionsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00027AB8 File Offset: 0x00025CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990433, XrefRangeEnd = 990437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string url(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsOfflineGameResults.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00027B0C File Offset: 0x00025D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990437, XrefRangeEnd = 990473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnalyticsOfflineGameResults.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0000534B File Offset: 0x0000354B
		public AnalyticsOfflineGameResults(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00027B60 File Offset: 0x00025D60
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00005354 File Offset: 0x00003554
		public unsafe Dictionary<string, Object> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameResults.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameResults.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DBGGameResults_GameOptionsData_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x02000213 RID: 531
		public sealed class PlayerData : ValueType
		{
			// Token: 0x06001857 RID: 6231 RVA: 0x0005C924 File Offset: 0x0005AB24
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerData()
			{
				Il2CppClassPointerStore<AnalyticsOfflineGameResults.PlayerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsOfflineGameResults>.NativeClassPtr, "PlayerData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsOfflineGameResults.PlayerData>.NativeClassPtr);
				AnalyticsOfflineGameResults.PlayerData.NativeFieldInfoPtr_ResultsEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsOfflineGameResults.PlayerData>.NativeClassPtr, "ResultsEntry");
				AnalyticsOfflineGameResults.PlayerData.NativeFieldInfoPtr_PlayerMatchInitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsOfflineGameResults.PlayerData>.NativeClassPtr, "PlayerMatchInitData");
				AnalyticsOfflineGameResults.PlayerData.NativeMethodInfoPtr__ctor_Public_Void_DBGGameResultsEntry_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsOfflineGameResults.PlayerData>.NativeClassPtr, 100664465);
			}

			// Token: 0x06001858 RID: 6232 RVA: 0x0005C98C File Offset: 0x0005AB8C
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerData(DBGGameResultsEntry resultsEntry, PlayerMatchInitData playerMatchInitData)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsOfflineGameResults.PlayerData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(resultsEntry);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerMatchInitData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsOfflineGameResults.PlayerData.NativeMethodInfoPtr__ctor_Public_Void_DBGGameResultsEntry_PlayerMatchInitData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001859 RID: 6233 RVA: 0x0000D52B File Offset: 0x0000B72B
			public PlayerData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600185A RID: 6234 RVA: 0x0000D534 File Offset: 0x0000B734
			public PlayerData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsOfflineGameResults.PlayerData>.NativeClassPtr))
			{
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x0600185B RID: 6235 RVA: 0x0005C9F0 File Offset: 0x0005ABF0
			// (set) Token: 0x0600185C RID: 6236 RVA: 0x0000D546 File Offset: 0x0000B746
			public unsafe DBGGameResultsEntry ResultsEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameResults.PlayerData.NativeFieldInfoPtr_ResultsEntry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGGameResultsEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameResults.PlayerData.NativeFieldInfoPtr_ResultsEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x0600185D RID: 6237 RVA: 0x0005CA20 File Offset: 0x0005AC20
			// (set) Token: 0x0600185E RID: 6238 RVA: 0x0000D565 File Offset: 0x0000B765
			public unsafe PlayerMatchInitData PlayerMatchInitData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameResults.PlayerData.NativeFieldInfoPtr_PlayerMatchInitData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMatchInitData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameResults.PlayerData.NativeFieldInfoPtr_PlayerMatchInitData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EC0 RID: 3776
			private static readonly IntPtr NativeFieldInfoPtr_ResultsEntry;

			// Token: 0x04000EC1 RID: 3777
			private static readonly IntPtr NativeFieldInfoPtr_PlayerMatchInitData;

			// Token: 0x04000EC2 RID: 3778
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DBGGameResultsEntry_PlayerMatchInitData_0;
		}

		// Token: 0x02000214 RID: 532
		[ObfuscatedName("zen.analytics.messages.AnalyticsOfflineGameResults+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600185F RID: 6239 RVA: 0x0005CA50 File Offset: 0x0005AC50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<AnalyticsOfflineGameResults.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsOfflineGameResults>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsOfflineGameResults.__c__DisplayClass2_0>.NativeClassPtr);
				AnalyticsOfflineGameResults.__c__DisplayClass2_0.NativeFieldInfoPtr_playerResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsOfflineGameResults.__c__DisplayClass2_0>.NativeClassPtr, "playerResult");
				AnalyticsOfflineGameResults.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsOfflineGameResults.__c__DisplayClass2_0>.NativeClassPtr, 100664466);
				AnalyticsOfflineGameResults.__c__DisplayClass2_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsOfflineGameResults.__c__DisplayClass2_0>.NativeClassPtr, 100664467);
			}

			// Token: 0x06001860 RID: 6240 RVA: 0x0005CAB8 File Offset: 0x0005ACB8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsOfflineGameResults.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsOfflineGameResults.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001861 RID: 6241 RVA: 0x0005CAF4 File Offset: 0x0005ACF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990363, XrefRangeEnd = 990368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__0(PlayerMatchInitData player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsOfflineGameResults.__c__DisplayClass2_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001862 RID: 6242 RVA: 0x0000D584 File Offset: 0x0000B784
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x06001863 RID: 6243 RVA: 0x0005CB44 File Offset: 0x0005AD44
			// (set) Token: 0x06001864 RID: 6244 RVA: 0x0000D58D File Offset: 0x0000B78D
			public unsafe DBGGameResultsEntry playerResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameResults.__c__DisplayClass2_0.NativeFieldInfoPtr_playerResult);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGGameResultsEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsOfflineGameResults.__c__DisplayClass2_0.NativeFieldInfoPtr_playerResult), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EC3 RID: 3779
			private static readonly IntPtr NativeFieldInfoPtr_playerResult;

			// Token: 0x04000EC4 RID: 3780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000EC5 RID: 3781
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_PlayerMatchInitData_0;
		}
	}
}
