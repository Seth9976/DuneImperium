using System;
using Canis.utils.ids;
using dbgclient.data;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.menus.commands
{
	// Token: 0x0200009B RID: 155
	public class FetchDailyChallengeLeaderboard : FailableCommand
	{
		// Token: 0x060005FF RID: 1535 RVA: 0x00030A40 File Offset: 0x0002EC40
		// Note: this type is marked as 'beforefieldinit'.
		static FetchDailyChallengeLeaderboard()
		{
			Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.menus.commands", "FetchDailyChallengeLeaderboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr);
			FetchDailyChallengeLeaderboard.NativeFieldInfoPtr__Scoreboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, "<Scoreboard>k__BackingField");
			FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_useFriendsRequestBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, "useFriendsRequestBody");
			FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_topStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, "topStart");
			FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_topEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, "topEnd");
			FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_numRelative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, "numRelative");
			FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, "friends");
			FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_baseUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, "baseUrl");
			FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, "client");
			FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_sortMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, "sortMode");
			FetchDailyChallengeLeaderboard.NativeMethodInfoPtr_get_Scoreboard_Public_get_DailyChallengeLeaderboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, 100664218);
			FetchDailyChallengeLeaderboard.NativeMethodInfoPtr_set_Scoreboard_Private_set_Void_DailyChallengeLeaderboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, 100664219);
			FetchDailyChallengeLeaderboard.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_Int32_Int32_IReadOnlyCollection_1_AccountID_String_SortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, 100664220);
			FetchDailyChallengeLeaderboard.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, 100664221);
			FetchDailyChallengeLeaderboard.NativeMethodInfoPtr__execute_b__14_0_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, 100664222);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00030B88 File Offset: 0x0002ED88
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x00030BC8 File Offset: 0x0002EDC8
		public unsafe DailyChallengeLeaderboard Scoreboard
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchDailyChallengeLeaderboard.NativeMethodInfoPtr_get_Scoreboard_Public_get_DailyChallengeLeaderboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DailyChallengeLeaderboard>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchDailyChallengeLeaderboard.NativeMethodInfoPtr_set_Scoreboard_Private_set_Void_DailyChallengeLeaderboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00030C0C File Offset: 0x0002EE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502667, XrefRangeEnd = 502671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FetchDailyChallengeLeaderboard(string url, bool useFriendsRequestBody, int topStart, int topEnd, int numRelative, IReadOnlyCollection<AccountID> friends, string client, FetchDailyChallengeLeaderboard.SortMode sortMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useFriendsRequestBody;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topEnd;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numRelative;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(friends);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchDailyChallengeLeaderboard.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_Int32_Int32_IReadOnlyCollection_1_AccountID_String_SortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00030CC4 File Offset: 0x0002EEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502671, XrefRangeEnd = 502676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FetchDailyChallengeLeaderboard.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00030D10 File Offset: 0x0002EF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502676, XrefRangeEnd = 502706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__14_0(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchDailyChallengeLeaderboard.NativeMethodInfoPtr__execute_b__14_0_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00004ABD File Offset: 0x00002CBD
		public FetchDailyChallengeLeaderboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00030D54 File Offset: 0x0002EF54
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00004AC6 File Offset: 0x00002CC6
		public unsafe DailyChallengeLeaderboard _Scoreboard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr__Scoreboard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeLeaderboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr__Scoreboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00030D84 File Offset: 0x0002EF84
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x00004AE5 File Offset: 0x00002CE5
		public unsafe bool useFriendsRequestBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_useFriendsRequestBody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_useFriendsRequestBody)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00030DAC File Offset: 0x0002EFAC
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00004B00 File Offset: 0x00002D00
		public unsafe int topStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_topStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_topStart)) = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00030DD4 File Offset: 0x0002EFD4
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00004B1B File Offset: 0x00002D1B
		public unsafe int topEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_topEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_topEnd)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00030DFC File Offset: 0x0002EFFC
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00004B36 File Offset: 0x00002D36
		public unsafe int numRelative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_numRelative);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_numRelative)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00030E24 File Offset: 0x0002F024
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00004B51 File Offset: 0x00002D51
		public unsafe IReadOnlyCollection<AccountID> friends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_friends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_friends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00030E54 File Offset: 0x0002F054
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00004B70 File Offset: 0x00002D70
		public unsafe string baseUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_baseUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_baseUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00030E7C File Offset: 0x0002F07C
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00004B8F File Offset: 0x00002D8F
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00030EA4 File Offset: 0x0002F0A4
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00004BAE File Offset: 0x00002DAE
		public unsafe int sortMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_sortMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard.NativeFieldInfoPtr_sortMode)) = value;
			}
		}

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeFieldInfoPtr__Scoreboard_k__BackingField;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr_useFriendsRequestBody;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_topStart;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_topEnd;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_numRelative;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_friends;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_baseUrl;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_sortMode;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_get_Scoreboard_Public_get_DailyChallengeLeaderboard_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_set_Scoreboard_Private_set_Void_DailyChallengeLeaderboard_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_Int32_Int32_IReadOnlyCollection_1_AccountID_String_SortMode_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__14_0_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x02000308 RID: 776
		public enum SortMode
		{
			// Token: 0x04001712 RID: 5906
			Season,
			// Token: 0x04001713 RID: 5907
			Game
		}

		// Token: 0x02000309 RID: 777
		[ObfuscatedName("dbgclient.menus.commands.FetchDailyChallengeLeaderboard+<execute>d__14")]
		public sealed class _execute_d__14 : Object
		{
			// Token: 0x060024BE RID: 9406 RVA: 0x000964D0 File Offset: 0x000946D0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__14()
			{
				Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard>.NativeClassPtr, "<execute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr);
				FetchDailyChallengeLeaderboard._execute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr, "<>1__state");
				FetchDailyChallengeLeaderboard._execute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr, "<>2__current");
				FetchDailyChallengeLeaderboard._execute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr, "<>4__this");
				FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr, 100664223);
				FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr, 100664224);
				FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr, 100664225);
				FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr, 100664226);
				FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr, 100664227);
				FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr, 100664228);
			}

			// Token: 0x060024BF RID: 9407 RVA: 0x000965B0 File Offset: 0x000947B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchDailyChallengeLeaderboard._execute_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024C0 RID: 9408 RVA: 0x000965F8 File Offset: 0x000947F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024C1 RID: 9409 RVA: 0x0009662C File Offset: 0x0009482C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502547, XrefRangeEnd = 502662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A17 RID: 2583
			// (get) Token: 0x060024C2 RID: 9410 RVA: 0x00096668 File Offset: 0x00094868
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024C3 RID: 9411 RVA: 0x000966A8 File Offset: 0x000948A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502662, XrefRangeEnd = 502667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A18 RID: 2584
			// (get) Token: 0x060024C4 RID: 9412 RVA: 0x000966DC File Offset: 0x000948DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchDailyChallengeLeaderboard._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024C5 RID: 9413 RVA: 0x0001320A File Offset: 0x0001140A
			public _execute_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A14 RID: 2580
			// (get) Token: 0x060024C6 RID: 9414 RVA: 0x0009671C File Offset: 0x0009491C
			// (set) Token: 0x060024C7 RID: 9415 RVA: 0x00013213 File Offset: 0x00011413
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard._execute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard._execute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A15 RID: 2581
			// (get) Token: 0x060024C8 RID: 9416 RVA: 0x00096744 File Offset: 0x00094944
			// (set) Token: 0x060024C9 RID: 9417 RVA: 0x0001322E File Offset: 0x0001142E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard._execute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard._execute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A16 RID: 2582
			// (get) Token: 0x060024CA RID: 9418 RVA: 0x00096774 File Offset: 0x00094974
			// (set) Token: 0x060024CB RID: 9419 RVA: 0x0001324D File Offset: 0x0001144D
			public unsafe FetchDailyChallengeLeaderboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard._execute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchDailyChallengeLeaderboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchDailyChallengeLeaderboard._execute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001714 RID: 5908
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001715 RID: 5909
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001716 RID: 5910
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001717 RID: 5911
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001718 RID: 5912
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001719 RID: 5913
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400171A RID: 5914
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400171B RID: 5915
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400171C RID: 5916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
