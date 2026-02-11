using System;
using boardgames.data;
using Canis.utils.ids;
using dwd.core;
using dwd.core.account;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.menus.commands
{
	// Token: 0x0200009E RID: 158
	public class LoadDailyChallengeLeaderboards : Command
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x000314FC File Offset: 0x0002F6FC
		// Note: this type is marked as 'beforefieldinit'.
		static LoadDailyChallengeLeaderboards()
		{
			Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.menus.commands", "LoadDailyChallengeLeaderboards");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr);
			LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, "Data");
			LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_topRankCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, "topRankCount");
			LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_relativeRankCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, "relativeRankCount");
			LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_friendsOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, "friendsOnly");
			LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, "accountProvider");
			LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_sortOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, "sortOrder");
			LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, "error");
			LoadDailyChallengeLeaderboards.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_SortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, 100664251);
			LoadDailyChallengeLeaderboards.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, 100664252);
			LoadDailyChallengeLeaderboards.NativeMethodInfoPtr_populateDataForRequest_Private_List_1_DataComposition_FetchDailyChallengeLeaderboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, 100664253);
			LoadDailyChallengeLeaderboards.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, 100664254);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00031608 File Offset: 0x0002F808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502979, RefRangeEnd = 502980, XrefRangeStart = 502965, XrefRangeEnd = 502979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadDailyChallengeLeaderboards(int topRankCount, int relativeRankCount, bool friendsOnly, FetchDailyChallengeLeaderboard.SortMode sortOrder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topRankCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRankCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref friendsOnly;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_SortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0003167C File Offset: 0x0002F87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502980, XrefRangeEnd = 502985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadDailyChallengeLeaderboards.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000316C8 File Offset: 0x0002F8C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 503050, RefRangeEnd = 503051, XrefRangeStart = 502985, XrefRangeEnd = 503050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DataComposition> populateDataForRequest(FetchDailyChallengeLeaderboard request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards.NativeMethodInfoPtr_populateDataForRequest_Private_List_1_DataComposition_FetchDailyChallengeLeaderboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataComposition>>(intPtr3) : null;
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00031718 File Offset: 0x0002F918
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00004CD3 File Offset: 0x00002ED3
		public LoadDailyChallengeLeaderboards(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00031750 File Offset: 0x0002F950
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00004CDC File Offset: 0x00002EDC
		public unsafe LeaderboardsData Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaderboardsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00031780 File Offset: 0x0002F980
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00004CFB File Offset: 0x00002EFB
		public unsafe int topRankCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_topRankCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_topRankCount)) = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x000317A8 File Offset: 0x0002F9A8
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00004D16 File Offset: 0x00002F16
		public unsafe int relativeRankCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_relativeRankCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_relativeRankCount)) = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000317D0 File Offset: 0x0002F9D0
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00004D31 File Offset: 0x00002F31
		public unsafe bool friendsOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_friendsOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_friendsOnly)) = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x000317F8 File Offset: 0x0002F9F8
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00004D4C File Offset: 0x00002F4C
		public unsafe AccountProvider accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00031828 File Offset: 0x0002FA28
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00004D6B File Offset: 0x00002F6B
		public unsafe FetchDailyChallengeLeaderboard.SortMode sortOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_sortOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_sortOrder)) = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00031850 File Offset: 0x0002FA50
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00004D86 File Offset: 0x00002F86
		public ErrorInfo error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_error);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards.NativeFieldInfoPtr_error), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_topRankCount;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr_relativeRankCount;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_friendsOnly;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_accountProvider;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_sortOrder;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_SortMode_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_populateDataForRequest_Private_List_1_DataComposition_FetchDailyChallengeLeaderboard_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x0200030C RID: 780
		[ObfuscatedName("dbgclient.menus.commands.LoadDailyChallengeLeaderboards+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060024E8 RID: 9448 RVA: 0x00096D4C File Offset: 0x00094F4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadDailyChallengeLeaderboards.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards.__c>.NativeClassPtr);
				LoadDailyChallengeLeaderboards.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards.__c>.NativeClassPtr, "<>9");
				LoadDailyChallengeLeaderboards.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards.__c>.NativeClassPtr, "<>9__8_0");
				LoadDailyChallengeLeaderboards.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards.__c>.NativeClassPtr, 100664256);
				LoadDailyChallengeLeaderboards.__c.NativeMethodInfoPtr__execute_b__8_0_Internal_AccountID_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards.__c>.NativeClassPtr, 100664257);
			}

			// Token: 0x060024E9 RID: 9449 RVA: 0x00096DC8 File Offset: 0x00094FC8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024EA RID: 9450 RVA: 0x00096E04 File Offset: 0x00095004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502884, XrefRangeEnd = 502888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountID _execute_b__8_0(RosterEntry f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards.__c.NativeMethodInfoPtr__execute_b__8_0_Internal_AccountID_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060024EB RID: 9451 RVA: 0x00013330 File Offset: 0x00011530
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x060024EC RID: 9452 RVA: 0x00096E54 File Offset: 0x00095054
			// (set) Token: 0x060024ED RID: 9453 RVA: 0x00013339 File Offset: 0x00011539
			public unsafe static LoadDailyChallengeLeaderboards.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadDailyChallengeLeaderboards.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadDailyChallengeLeaderboards.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadDailyChallengeLeaderboards.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A24 RID: 2596
			// (get) Token: 0x060024EE RID: 9454 RVA: 0x00096E7C File Offset: 0x0009507C
			// (set) Token: 0x060024EF RID: 9455 RVA: 0x0001334B File Offset: 0x0001154B
			public unsafe static Func<RosterEntry, AccountID> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadDailyChallengeLeaderboards.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RosterEntry, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadDailyChallengeLeaderboards.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400172F RID: 5935
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001730 RID: 5936
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04001731 RID: 5937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001732 RID: 5938
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_0_Internal_AccountID_RosterEntry_0;
		}

		// Token: 0x0200030D RID: 781
		[ObfuscatedName("dbgclient.menus.commands.LoadDailyChallengeLeaderboards+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x060024F0 RID: 9456 RVA: 0x00096EA4 File Offset: 0x000950A4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr);
				LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr, "<>1__state");
				LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr, "<>2__current");
				LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr, "<>4__this");
				LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr, "<request>5__2");
				LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr, 100664258);
				LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr, 100664259);
				LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr, 100664260);
				LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr, 100664261);
				LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr, 100664262);
				LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr, 100664263);
			}

			// Token: 0x060024F1 RID: 9457 RVA: 0x00096F98 File Offset: 0x00095198
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadDailyChallengeLeaderboards._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024F2 RID: 9458 RVA: 0x00096FE0 File Offset: 0x000951E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024F3 RID: 9459 RVA: 0x00097014 File Offset: 0x00095214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502888, XrefRangeEnd = 502960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x060024F4 RID: 9460 RVA: 0x00097050 File Offset: 0x00095250
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024F5 RID: 9461 RVA: 0x00097090 File Offset: 0x00095290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502960, XrefRangeEnd = 502965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A2A RID: 2602
			// (get) Token: 0x060024F6 RID: 9462 RVA: 0x000970C4 File Offset: 0x000952C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDailyChallengeLeaderboards._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024F7 RID: 9463 RVA: 0x0001335D File Offset: 0x0001155D
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A25 RID: 2597
			// (get) Token: 0x060024F8 RID: 9464 RVA: 0x00097104 File Offset: 0x00095304
			// (set) Token: 0x060024F9 RID: 9465 RVA: 0x00013366 File Offset: 0x00011566
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A26 RID: 2598
			// (get) Token: 0x060024FA RID: 9466 RVA: 0x0009712C File Offset: 0x0009532C
			// (set) Token: 0x060024FB RID: 9467 RVA: 0x00013381 File Offset: 0x00011581
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A27 RID: 2599
			// (get) Token: 0x060024FC RID: 9468 RVA: 0x0009715C File Offset: 0x0009535C
			// (set) Token: 0x060024FD RID: 9469 RVA: 0x000133A0 File Offset: 0x000115A0
			public unsafe LoadDailyChallengeLeaderboards __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadDailyChallengeLeaderboards>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A28 RID: 2600
			// (get) Token: 0x060024FE RID: 9470 RVA: 0x0009718C File Offset: 0x0009538C
			// (set) Token: 0x060024FF RID: 9471 RVA: 0x000133BF File Offset: 0x000115BF
			public unsafe FetchDailyChallengeLeaderboard _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchDailyChallengeLeaderboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDailyChallengeLeaderboards._execute_d__8.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001733 RID: 5939
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001734 RID: 5940
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001735 RID: 5941
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001736 RID: 5942
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04001737 RID: 5943
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001738 RID: 5944
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001739 RID: 5945
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400173A RID: 5946
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400173B RID: 5947
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400173C RID: 5948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
