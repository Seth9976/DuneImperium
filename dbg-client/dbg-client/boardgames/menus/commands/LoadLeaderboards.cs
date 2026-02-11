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
using platformCore.scoreboard;

namespace boardgames.menus.commands
{
	// Token: 0x02000214 RID: 532
	public class LoadLeaderboards : Command
	{
		// Token: 0x06001867 RID: 6247 RVA: 0x0006CC80 File Offset: 0x0006AE80
		// Note: this type is marked as 'beforefieldinit'.
		static LoadLeaderboards()
		{
			Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "LoadLeaderboards");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr);
			LoadLeaderboards.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, "Data");
			LoadLeaderboards.NativeFieldInfoPtr_topRankCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, "topRankCount");
			LoadLeaderboards.NativeFieldInfoPtr_relativeRankCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, "relativeRankCount");
			LoadLeaderboards.NativeFieldInfoPtr_accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, "accountProvider");
			LoadLeaderboards.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, "error");
			LoadLeaderboards.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, 100666915);
			LoadLeaderboards.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, 100666916);
			LoadLeaderboards.NativeMethodInfoPtr_populateDataForRequest_Private_Void_FetchScoreboard_Dictionary_2_String_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, 100666917);
			LoadLeaderboards.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, 100666918);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0006CD64 File Offset: 0x0006AF64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 526914, RefRangeEnd = 526915, XrefRangeStart = 526900, XrefRangeEnd = 526914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadLeaderboards(int topRankCount, int relativeRankCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topRankCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRankCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0006CDBC File Offset: 0x0006AFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526915, XrefRangeEnd = 526920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadLeaderboards.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0006CE08 File Offset: 0x0006B008
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 526970, RefRangeEnd = 526973, XrefRangeStart = 526920, XrefRangeEnd = 526970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void populateDataForRequest(FetchScoreboard request, Dictionary<string, DataComposition> datas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards.NativeMethodInfoPtr_populateDataForRequest_Private_Void_FetchScoreboard_Dictionary_2_String_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0006CE5C File Offset: 0x0006B05C
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0000D835 File Offset: 0x0000BA35
		public LoadLeaderboards(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x0006CE94 File Offset: 0x0006B094
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x0000D83E File Offset: 0x0000BA3E
		public unsafe LeaderboardsData Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LeaderboardsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x0006CEC4 File Offset: 0x0006B0C4
		// (set) Token: 0x06001870 RID: 6256 RVA: 0x0000D85D File Offset: 0x0000BA5D
		public unsafe int topRankCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards.NativeFieldInfoPtr_topRankCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards.NativeFieldInfoPtr_topRankCount)) = value;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x0006CEEC File Offset: 0x0006B0EC
		// (set) Token: 0x06001872 RID: 6258 RVA: 0x0000D878 File Offset: 0x0000BA78
		public unsafe int relativeRankCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards.NativeFieldInfoPtr_relativeRankCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards.NativeFieldInfoPtr_relativeRankCount)) = value;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0006CF14 File Offset: 0x0006B114
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x0000D893 File Offset: 0x0000BA93
		public unsafe AccountProvider accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards.NativeFieldInfoPtr_accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards.NativeFieldInfoPtr_accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x0006CF44 File Offset: 0x0006B144
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x0000D8B2 File Offset: 0x0000BAB2
		public ErrorInfo error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards.NativeFieldInfoPtr_error);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards.NativeFieldInfoPtr_error), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeFieldInfoPtr_topRankCount;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeFieldInfoPtr_relativeRankCount;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeFieldInfoPtr_accountProvider;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_populateDataForRequest_Private_Void_FetchScoreboard_Dictionary_2_String_DataComposition_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x020003E9 RID: 1001
		[ObfuscatedName("boardgames.menus.commands.LoadLeaderboards+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002EB6 RID: 11958 RVA: 0x000B3EE0 File Offset: 0x000B20E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadLeaderboards.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadLeaderboards.__c>.NativeClassPtr);
				LoadLeaderboards.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards.__c>.NativeClassPtr, "<>9");
				LoadLeaderboards.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards.__c>.NativeClassPtr, "<>9__6_0");
				LoadLeaderboards.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards.__c>.NativeClassPtr, 100666920);
				LoadLeaderboards.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_AccountID_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards.__c>.NativeClassPtr, 100666921);
			}

			// Token: 0x06002EB7 RID: 11959 RVA: 0x000B3F5C File Offset: 0x000B215C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadLeaderboards.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EB8 RID: 11960 RVA: 0x000B3F98 File Offset: 0x000B2198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526780, XrefRangeEnd = 526784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountID _execute_b__6_0(RosterEntry _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_AccountID_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x06002EB9 RID: 11961 RVA: 0x0001826A File Offset: 0x0001646A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D57 RID: 3415
			// (get) Token: 0x06002EBA RID: 11962 RVA: 0x000B3FE8 File Offset: 0x000B21E8
			// (set) Token: 0x06002EBB RID: 11963 RVA: 0x00018273 File Offset: 0x00016473
			public unsafe static LoadLeaderboards.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadLeaderboards.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadLeaderboards.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadLeaderboards.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D58 RID: 3416
			// (get) Token: 0x06002EBC RID: 11964 RVA: 0x000B4010 File Offset: 0x000B2210
			// (set) Token: 0x06002EBD RID: 11965 RVA: 0x00018285 File Offset: 0x00016485
			public unsafe static Func<RosterEntry, AccountID> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadLeaderboards.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RosterEntry, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadLeaderboards.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CE9 RID: 7401
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001CEA RID: 7402
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001CEB RID: 7403
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001CEC RID: 7404
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__6_0_Internal_AccountID_RosterEntry_0;
		}

		// Token: 0x020003EA RID: 1002
		[ObfuscatedName("boardgames.menus.commands.LoadLeaderboards+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06002EBE RID: 11966 RVA: 0x000B4038 File Offset: 0x000B2238
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadLeaderboards>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr);
				LoadLeaderboards._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, "<>1__state");
				LoadLeaderboards._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, "<>2__current");
				LoadLeaderboards._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, "<>4__this");
				LoadLeaderboards._execute_d__6.NativeFieldInfoPtr__topRanks_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, "<topRanks>5__2");
				LoadLeaderboards._execute_d__6.NativeFieldInfoPtr__nearRanks_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, "<nearRanks>5__3");
				LoadLeaderboards._execute_d__6.NativeFieldInfoPtr__friendRanks_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, "<friendRanks>5__4");
				LoadLeaderboards._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, 100666922);
				LoadLeaderboards._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, 100666923);
				LoadLeaderboards._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, 100666924);
				LoadLeaderboards._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, 100666925);
				LoadLeaderboards._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, 100666926);
				LoadLeaderboards._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr, 100666927);
			}

			// Token: 0x06002EBF RID: 11967 RVA: 0x000B4154 File Offset: 0x000B2354
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadLeaderboards._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002EC0 RID: 11968 RVA: 0x000B419C File Offset: 0x000B239C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EC1 RID: 11969 RVA: 0x000B41D0 File Offset: 0x000B23D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526784, XrefRangeEnd = 526895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D5F RID: 3423
			// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x000B420C File Offset: 0x000B240C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002EC3 RID: 11971 RVA: 0x000B424C File Offset: 0x000B244C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526895, XrefRangeEnd = 526900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D60 RID: 3424
			// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x000B4280 File Offset: 0x000B2480
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLeaderboards._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002EC5 RID: 11973 RVA: 0x00018297 File Offset: 0x00016497
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D59 RID: 3417
			// (get) Token: 0x06002EC6 RID: 11974 RVA: 0x000B42C0 File Offset: 0x000B24C0
			// (set) Token: 0x06002EC7 RID: 11975 RVA: 0x000182A0 File Offset: 0x000164A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D5A RID: 3418
			// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x000B42E8 File Offset: 0x000B24E8
			// (set) Token: 0x06002EC9 RID: 11977 RVA: 0x000182BB File Offset: 0x000164BB
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5B RID: 3419
			// (get) Token: 0x06002ECA RID: 11978 RVA: 0x000B4318 File Offset: 0x000B2518
			// (set) Token: 0x06002ECB RID: 11979 RVA: 0x000182DA File Offset: 0x000164DA
			public unsafe LoadLeaderboards __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadLeaderboards>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5C RID: 3420
			// (get) Token: 0x06002ECC RID: 11980 RVA: 0x000B4348 File Offset: 0x000B2548
			// (set) Token: 0x06002ECD RID: 11981 RVA: 0x000182F9 File Offset: 0x000164F9
			public unsafe FetchScoreboard _topRanks_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr__topRanks_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchScoreboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr__topRanks_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5D RID: 3421
			// (get) Token: 0x06002ECE RID: 11982 RVA: 0x000B4378 File Offset: 0x000B2578
			// (set) Token: 0x06002ECF RID: 11983 RVA: 0x00018318 File Offset: 0x00016518
			public unsafe FetchScoreboard _nearRanks_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr__nearRanks_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchScoreboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr__nearRanks_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5E RID: 3422
			// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x000B43A8 File Offset: 0x000B25A8
			// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x00018337 File Offset: 0x00016537
			public unsafe FetchScoreboard _friendRanks_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr__friendRanks_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchScoreboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadLeaderboards._execute_d__6.NativeFieldInfoPtr__friendRanks_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CED RID: 7405
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001CEE RID: 7406
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001CEF RID: 7407
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001CF0 RID: 7408
			private static readonly IntPtr NativeFieldInfoPtr__topRanks_5__2;

			// Token: 0x04001CF1 RID: 7409
			private static readonly IntPtr NativeFieldInfoPtr__nearRanks_5__3;

			// Token: 0x04001CF2 RID: 7410
			private static readonly IntPtr NativeFieldInfoPtr__friendRanks_5__4;

			// Token: 0x04001CF3 RID: 7411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CF4 RID: 7412
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CF5 RID: 7413
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CF6 RID: 7414
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CF7 RID: 7415
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CF8 RID: 7416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
