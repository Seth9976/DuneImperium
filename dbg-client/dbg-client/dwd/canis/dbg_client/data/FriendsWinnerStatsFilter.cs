using System;
using dbgclient.data;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.canis.dbg_client.data
{
	// Token: 0x02000075 RID: 117
	[Serializable]
	public class FriendsWinnerStatsFilter : StatsFilter
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x0002B260 File Offset: 0x00029460
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsWinnerStatsFilter()
		{
			Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.data", "FriendsWinnerStatsFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr);
			FriendsWinnerStatsFilter.NativeFieldInfoPtr_wins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr, "wins");
			FriendsWinnerStatsFilter.NativeFieldInfoPtr_friendsAccounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr, "friendsAccounts");
			FriendsWinnerStatsFilter.NativeMethodInfoPtr_Filter_Public_Virtual_IEnumerable_1_MatchStatsEntry_IEnumerable_1_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr, 100663940);
			FriendsWinnerStatsFilter.NativeMethodInfoPtr_GetAccountData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr, 100663941);
			FriendsWinnerStatsFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr, 100663942);
			FriendsWinnerStatsFilter.NativeMethodInfoPtr__Filter_b__2_0_Private_Boolean_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr, 100663943);
			FriendsWinnerStatsFilter.NativeMethodInfoPtr__Filter_b__2_1_Private_Boolean_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr, 100663944);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0002B31C File Offset: 0x0002951C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500560, XrefRangeEnd = 500595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<MatchStatsEntry> Filter(IEnumerable<MatchStatsEntry> entries)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendsWinnerStatsFilter.NativeMethodInfoPtr_Filter_Public_Virtual_IEnumerable_1_MatchStatsEntry_IEnumerable_1_MatchStatsEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MatchStatsEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0002B378 File Offset: 0x00029578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500595, XrefRangeEnd = 500621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAccountData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsWinnerStatsFilter.NativeMethodInfoPtr_GetAccountData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0002B3AC File Offset: 0x000295AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500621, XrefRangeEnd = 500622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsWinnerStatsFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsWinnerStatsFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0002B3E8 File Offset: 0x000295E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500622, XrefRangeEnd = 500632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe bool _Filter_b__2_0(MatchStatsEntry e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsWinnerStatsFilter.NativeMethodInfoPtr__Filter_b__2_0_Private_Boolean_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0002B438 File Offset: 0x00029638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500632, XrefRangeEnd = 500638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Filter_b__2_1(KeyValuePair<string, string> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsWinnerStatsFilter.NativeMethodInfoPtr__Filter_b__2_1_Private_Boolean_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00003F7B File Offset: 0x0000217B
		public FriendsWinnerStatsFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0002B48C File Offset: 0x0002968C
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00003F84 File Offset: 0x00002184
		public unsafe bool wins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsWinnerStatsFilter.NativeFieldInfoPtr_wins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsWinnerStatsFilter.NativeFieldInfoPtr_wins)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0002B4B4 File Offset: 0x000296B4
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00003F9F File Offset: 0x0000219F
		public unsafe Il2CppStringArray friendsAccounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsWinnerStatsFilter.NativeFieldInfoPtr_friendsAccounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsWinnerStatsFilter.NativeFieldInfoPtr_friendsAccounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_wins;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_friendsAccounts;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_Filter_Public_Virtual_IEnumerable_1_MatchStatsEntry_IEnumerable_1_MatchStatsEntry_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_GetAccountData_Private_Void_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr__Filter_b__2_0_Private_Boolean_MatchStatsEntry_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr__Filter_b__2_1_Private_Boolean_KeyValuePair_2_String_String_0;

		// Token: 0x020002F1 RID: 753
		[ObfuscatedName("dwd.canis.dbg_client.data.FriendsWinnerStatsFilter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002389 RID: 9097 RVA: 0x00092C98 File Offset: 0x00090E98
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FriendsWinnerStatsFilter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendsWinnerStatsFilter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsWinnerStatsFilter.__c>.NativeClassPtr);
				FriendsWinnerStatsFilter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsWinnerStatsFilter.__c>.NativeClassPtr, "<>9");
				FriendsWinnerStatsFilter.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsWinnerStatsFilter.__c>.NativeClassPtr, "<>9__3_0");
				FriendsWinnerStatsFilter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsWinnerStatsFilter.__c>.NativeClassPtr, 100663946);
				FriendsWinnerStatsFilter.__c.NativeMethodInfoPtr__GetAccountData_b__3_0_Internal_String_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsWinnerStatsFilter.__c>.NativeClassPtr, 100663947);
			}

			// Token: 0x0600238A RID: 9098 RVA: 0x00092D14 File Offset: 0x00090F14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsWinnerStatsFilter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsWinnerStatsFilter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600238B RID: 9099 RVA: 0x00092D50 File Offset: 0x00090F50
			[CallerCount(0)]
			public unsafe string _GetAccountData_b__3_0(RosterEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsWinnerStatsFilter.__c.NativeMethodInfoPtr__GetAccountData_b__3_0_Internal_String_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600238C RID: 9100 RVA: 0x00012826 File Offset: 0x00010A26
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A6 RID: 2470
			// (get) Token: 0x0600238D RID: 9101 RVA: 0x00092D98 File Offset: 0x00090F98
			// (set) Token: 0x0600238E RID: 9102 RVA: 0x0001282F File Offset: 0x00010A2F
			public unsafe static FriendsWinnerStatsFilter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsWinnerStatsFilter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsWinnerStatsFilter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsWinnerStatsFilter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009A7 RID: 2471
			// (get) Token: 0x0600238F RID: 9103 RVA: 0x00092DC0 File Offset: 0x00090FC0
			// (set) Token: 0x06002390 RID: 9104 RVA: 0x00012841 File Offset: 0x00010A41
			public unsafe static Func<RosterEntry, string> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsWinnerStatsFilter.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RosterEntry, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsWinnerStatsFilter.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001656 RID: 5718
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001657 RID: 5719
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001658 RID: 5720
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001659 RID: 5721
			private static readonly IntPtr NativeMethodInfoPtr__GetAccountData_b__3_0_Internal_String_RosterEntry_0;
		}
	}
}
