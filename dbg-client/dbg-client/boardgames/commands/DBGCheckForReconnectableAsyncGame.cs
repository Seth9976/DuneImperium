using System;
using Canis;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using zen.src.matchMaking.commands;

namespace boardgames.commands
{
	// Token: 0x0200019B RID: 411
	public class DBGCheckForReconnectableAsyncGame : Command
	{
		// Token: 0x06001235 RID: 4661 RVA: 0x000579E0 File Offset: 0x00055BE0
		// Note: this type is marked as 'beforefieldinit'.
		static DBGCheckForReconnectableAsyncGame()
		{
			Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.commands", "DBGCheckForReconnectableAsyncGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame>.NativeClassPtr);
			DBGCheckForReconnectableAsyncGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame>.NativeClassPtr, 100665843);
			DBGCheckForReconnectableAsyncGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame>.NativeClassPtr, 100665844);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00057A38 File Offset: 0x00055C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515880, XrefRangeEnd = 515884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCheckForReconnectableAsyncGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00057A84 File Offset: 0x00055C84
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGCheckForReconnectableAsyncGame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0000AADC File Offset: 0x00008CDC
		public DBGCheckForReconnectableAsyncGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200037E RID: 894
		[ObfuscatedName("boardgames.commands.DBGCheckForReconnectableAsyncGame+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060029DF RID: 10719 RVA: 0x000A5BD8 File Offset: 0x000A3DD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c>.NativeClassPtr);
				DBGCheckForReconnectableAsyncGame.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c>.NativeClassPtr, "<>9");
				DBGCheckForReconnectableAsyncGame.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c>.NativeClassPtr, "<>9__0_2");
				DBGCheckForReconnectableAsyncGame.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c>.NativeClassPtr, 100665846);
				DBGCheckForReconnectableAsyncGame.__c.NativeMethodInfoPtr__execute_b__0_2_Internal_String_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c>.NativeClassPtr, 100665847);
			}

			// Token: 0x060029E0 RID: 10720 RVA: 0x000A5C54 File Offset: 0x000A3E54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029E1 RID: 10721 RVA: 0x000A5C90 File Offset: 0x000A3E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515752, XrefRangeEnd = 515757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _execute_b__0_2(AccountIDUsernameMetadata a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame.__c.NativeMethodInfoPtr__execute_b__0_2_Internal_String_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060029E2 RID: 10722 RVA: 0x00015970 File Offset: 0x00013B70
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BC3 RID: 3011
			// (get) Token: 0x060029E3 RID: 10723 RVA: 0x000A5CD8 File Offset: 0x000A3ED8
			// (set) Token: 0x060029E4 RID: 10724 RVA: 0x00015979 File Offset: 0x00013B79
			public unsafe static DBGCheckForReconnectableAsyncGame.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGCheckForReconnectableAsyncGame.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGCheckForReconnectableAsyncGame.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGCheckForReconnectableAsyncGame.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC4 RID: 3012
			// (get) Token: 0x060029E5 RID: 10725 RVA: 0x000A5D00 File Offset: 0x000A3F00
			// (set) Token: 0x060029E6 RID: 10726 RVA: 0x0001598B File Offset: 0x00013B8B
			public unsafe static Func<AccountIDUsernameMetadata, string> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGCheckForReconnectableAsyncGame.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountIDUsernameMetadata, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGCheckForReconnectableAsyncGame.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A23 RID: 6691
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001A24 RID: 6692
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x04001A25 RID: 6693
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A26 RID: 6694
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_2_Internal_String_AccountIDUsernameMetadata_0;
		}

		// Token: 0x0200037F RID: 895
		[ObfuscatedName("boardgames.commands.DBGCheckForReconnectableAsyncGame+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x060029E7 RID: 10727 RVA: 0x000A5D28 File Offset: 0x000A3F28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>.NativeClassPtr);
				DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeFieldInfoPtr_foundMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>.NativeClassPtr, "foundMatch");
				DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>.NativeClassPtr, "accountID");
				DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>.NativeClassPtr, "<>9__3");
				DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>.NativeClassPtr, 100665848);
				DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__0_Internal_Void_GetReconnectableGames_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>.NativeClassPtr, 100665849);
				DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__3_Internal_Boolean_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>.NativeClassPtr, 100665850);
				DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>.NativeClassPtr, 100665851);
			}

			// Token: 0x060029E8 RID: 10728 RVA: 0x000A5DE0 File Offset: 0x000A3FE0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029E9 RID: 10729 RVA: 0x000A5E1C File Offset: 0x000A401C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515757, XrefRangeEnd = 515769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__0(GetReconnectableGames response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__0_Internal_Void_GetReconnectableGames_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029EA RID: 10730 RVA: 0x000A5E60 File Offset: 0x000A4060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515769, XrefRangeEnd = 515771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__3(SaveMetaData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__3_Internal_Boolean_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029EB RID: 10731 RVA: 0x000A5EB0 File Offset: 0x000A40B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515771, XrefRangeEnd = 515776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__1(AccountIDUsernameMetadata a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060029EC RID: 10732 RVA: 0x0001599D File Offset: 0x00013B9D
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BC5 RID: 3013
			// (get) Token: 0x060029ED RID: 10733 RVA: 0x000A5F00 File Offset: 0x000A4100
			// (set) Token: 0x060029EE RID: 10734 RVA: 0x000159A6 File Offset: 0x00013BA6
			public unsafe SaveMetaData foundMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeFieldInfoPtr_foundMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveMetaData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeFieldInfoPtr_foundMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC6 RID: 3014
			// (get) Token: 0x060029EF RID: 10735 RVA: 0x000A5F30 File Offset: 0x000A4130
			// (set) Token: 0x060029F0 RID: 10736 RVA: 0x000159C5 File Offset: 0x00013BC5
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC7 RID: 3015
			// (get) Token: 0x060029F1 RID: 10737 RVA: 0x000A5F60 File Offset: 0x000A4160
			// (set) Token: 0x060029F2 RID: 10738 RVA: 0x000159E4 File Offset: 0x00013BE4
			public unsafe Func<SaveMetaData, bool> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SaveMetaData, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A27 RID: 6695
			private static readonly IntPtr NativeFieldInfoPtr_foundMatch;

			// Token: 0x04001A28 RID: 6696
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04001A29 RID: 6697
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04001A2A RID: 6698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A2B RID: 6699
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Void_GetReconnectableGames_0;

			// Token: 0x04001A2C RID: 6700
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_Internal_Boolean_SaveMetaData_0;

			// Token: 0x04001A2D RID: 6701
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000380 RID: 896
		[ObfuscatedName("boardgames.commands.DBGCheckForReconnectableAsyncGame+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x060029F3 RID: 10739 RVA: 0x000A5F90 File Offset: 0x000A4190
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr);
				DBGCheckForReconnectableAsyncGame._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr, "<>1__state");
				DBGCheckForReconnectableAsyncGame._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr, "<>2__current");
				DBGCheckForReconnectableAsyncGame._execute_d__0.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr, "<>8__1");
				DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr, 100665852);
				DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr, 100665853);
				DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr, 100665854);
				DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr, 100665855);
				DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr, 100665856);
				DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr, 100665857);
			}

			// Token: 0x060029F4 RID: 10740 RVA: 0x000A6070 File Offset: 0x000A4270
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCheckForReconnectableAsyncGame._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029F5 RID: 10741 RVA: 0x000A60B8 File Offset: 0x000A42B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029F6 RID: 10742 RVA: 0x000A60EC File Offset: 0x000A42EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515776, XrefRangeEnd = 515875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BCB RID: 3019
			// (get) Token: 0x060029F7 RID: 10743 RVA: 0x000A6128 File Offset: 0x000A4328
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029F8 RID: 10744 RVA: 0x000A6168 File Offset: 0x000A4368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515875, XrefRangeEnd = 515880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BCC RID: 3020
			// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000A619C File Offset: 0x000A439C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060029FA RID: 10746 RVA: 0x00015A03 File Offset: 0x00013C03
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BC8 RID: 3016
			// (get) Token: 0x060029FB RID: 10747 RVA: 0x000A61DC File Offset: 0x000A43DC
			// (set) Token: 0x060029FC RID: 10748 RVA: 0x00015A0C File Offset: 0x00013C0C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BC9 RID: 3017
			// (get) Token: 0x060029FD RID: 10749 RVA: 0x000A6204 File Offset: 0x000A4404
			// (set) Token: 0x060029FE RID: 10750 RVA: 0x00015A27 File Offset: 0x00013C27
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BCA RID: 3018
			// (get) Token: 0x060029FF RID: 10751 RVA: 0x000A6234 File Offset: 0x000A4434
			// (set) Token: 0x06002A00 RID: 10752 RVA: 0x00015A46 File Offset: 0x00013C46
			public unsafe DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGCheckForReconnectableAsyncGame.__c__DisplayClass0_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableAsyncGame._execute_d__0.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A2E RID: 6702
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A2F RID: 6703
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A30 RID: 6704
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001A31 RID: 6705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A32 RID: 6706
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A33 RID: 6707
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A34 RID: 6708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A35 RID: 6709
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A36 RID: 6710
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
