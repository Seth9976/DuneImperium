using System;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace boardgames.commands
{
	// Token: 0x0200019C RID: 412
	public class DBGCheckForReconnectableLiveGameCommand : FailableCommand
	{
		// Token: 0x06001239 RID: 4665 RVA: 0x00057AC0 File Offset: 0x00055CC0
		// Note: this type is marked as 'beforefieldinit'.
		static DBGCheckForReconnectableLiveGameCommand()
		{
			Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.commands", "DBGCheckForReconnectableLiveGameCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand>.NativeClassPtr);
			DBGCheckForReconnectableLiveGameCommand.NativeFieldInfoPtr_foundMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand>.NativeClassPtr, "foundMatch");
			DBGCheckForReconnectableLiveGameCommand.NativeMethodInfoPtr_get_FoundMatch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand>.NativeClassPtr, 100665858);
			DBGCheckForReconnectableLiveGameCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand>.NativeClassPtr, 100665859);
			DBGCheckForReconnectableLiveGameCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand>.NativeClassPtr, 100665860);
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00057B40 File Offset: 0x00055D40
		public unsafe bool FoundMatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand.NativeMethodInfoPtr_get_FoundMatch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00057B7C File Offset: 0x00055D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516064, XrefRangeEnd = 516069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCheckForReconnectableLiveGameCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00057BC8 File Offset: 0x00055DC8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 498677, RefRangeEnd = 498693, XrefRangeStart = 498677, XrefRangeEnd = 498693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGCheckForReconnectableLiveGameCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0000AAE5 File Offset: 0x00008CE5
		public DBGCheckForReconnectableLiveGameCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00057C04 File Offset: 0x00055E04
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x0000AAEE File Offset: 0x00008CEE
		public unsafe bool foundMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand.NativeFieldInfoPtr_foundMatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand.NativeFieldInfoPtr_foundMatch)) = value;
			}
		}

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeFieldInfoPtr_foundMatch;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_get_FoundMatch_Public_get_Boolean_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000381 RID: 897
		[ObfuscatedName("boardgames.commands.DBGCheckForReconnectableLiveGameCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002A01 RID: 10753 RVA: 0x000A6264 File Offset: 0x000A4464
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c>.NativeClassPtr);
				DBGCheckForReconnectableLiveGameCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c>.NativeClassPtr, "<>9");
				DBGCheckForReconnectableLiveGameCommand.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c>.NativeClassPtr, "<>9__3_0");
				DBGCheckForReconnectableLiveGameCommand.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c>.NativeClassPtr, "<>9__3_2");
				DBGCheckForReconnectableLiveGameCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c>.NativeClassPtr, 100665862);
				DBGCheckForReconnectableLiveGameCommand.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c>.NativeClassPtr, 100665863);
				DBGCheckForReconnectableLiveGameCommand.__c.NativeMethodInfoPtr__execute_b__3_2_Internal_String_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c>.NativeClassPtr, 100665864);
			}

			// Token: 0x06002A02 RID: 10754 RVA: 0x000A6308 File Offset: 0x000A4508
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A03 RID: 10755 RVA: 0x000A6344 File Offset: 0x000A4544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515884, XrefRangeEnd = 515892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__3_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A04 RID: 10756 RVA: 0x000A6388 File Offset: 0x000A4588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515892, XrefRangeEnd = 515897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _execute_b__3_2(AccountIDUsernameMetadata a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand.__c.NativeMethodInfoPtr__execute_b__3_2_Internal_String_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002A05 RID: 10757 RVA: 0x00015A65 File Offset: 0x00013C65
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BCD RID: 3021
			// (get) Token: 0x06002A06 RID: 10758 RVA: 0x000A63D0 File Offset: 0x000A45D0
			// (set) Token: 0x06002A07 RID: 10759 RVA: 0x00015A6E File Offset: 0x00013C6E
			public unsafe static DBGCheckForReconnectableLiveGameCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGCheckForReconnectableLiveGameCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGCheckForReconnectableLiveGameCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGCheckForReconnectableLiveGameCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BCE RID: 3022
			// (get) Token: 0x06002A08 RID: 10760 RVA: 0x000A63F8 File Offset: 0x000A45F8
			// (set) Token: 0x06002A09 RID: 10761 RVA: 0x00015A80 File Offset: 0x00013C80
			public unsafe static Action<UnityWebRequest> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGCheckForReconnectableLiveGameCommand.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGCheckForReconnectableLiveGameCommand.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BCF RID: 3023
			// (get) Token: 0x06002A0A RID: 10762 RVA: 0x000A6420 File Offset: 0x000A4620
			// (set) Token: 0x06002A0B RID: 10763 RVA: 0x00015A92 File Offset: 0x00013C92
			public unsafe static Func<AccountIDUsernameMetadata, string> __9__3_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGCheckForReconnectableLiveGameCommand.__c.NativeFieldInfoPtr___9__3_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountIDUsernameMetadata, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGCheckForReconnectableLiveGameCommand.__c.NativeFieldInfoPtr___9__3_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A37 RID: 6711
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001A38 RID: 6712
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001A39 RID: 6713
			private static readonly IntPtr NativeFieldInfoPtr___9__3_2;

			// Token: 0x04001A3A RID: 6714
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A3B RID: 6715
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_0_Internal_Void_UnityWebRequest_0;

			// Token: 0x04001A3C RID: 6716
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_2_Internal_String_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000382 RID: 898
		[ObfuscatedName("boardgames.commands.DBGCheckForReconnectableLiveGameCommand+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06002A0C RID: 10764 RVA: 0x000A6448 File Offset: 0x000A4648
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0>.NativeClassPtr);
				DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0.NativeFieldInfoPtr_localAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0>.NativeClassPtr, "localAccountID");
				DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0>.NativeClassPtr, 100665865);
				DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0>.NativeClassPtr, 100665866);
			}

			// Token: 0x06002A0D RID: 10765 RVA: 0x000A64B0 File Offset: 0x000A46B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A0E RID: 10766 RVA: 0x000A64EC File Offset: 0x000A46EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515897, XrefRangeEnd = 515902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__1(AccountIDUsernameMetadata a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002A0F RID: 10767 RVA: 0x00015AA4 File Offset: 0x00013CA4
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BD0 RID: 3024
			// (get) Token: 0x06002A10 RID: 10768 RVA: 0x000A653C File Offset: 0x000A473C
			// (set) Token: 0x06002A11 RID: 10769 RVA: 0x00015AAD File Offset: 0x00013CAD
			public unsafe AccountID localAccountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0.NativeFieldInfoPtr_localAccountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand.__c__DisplayClass3_0.NativeFieldInfoPtr_localAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A3D RID: 6717
			private static readonly IntPtr NativeFieldInfoPtr_localAccountID;

			// Token: 0x04001A3E RID: 6718
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001A3F RID: 6719
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000383 RID: 899
		[ObfuscatedName("boardgames.commands.DBGCheckForReconnectableLiveGameCommand+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06002A12 RID: 10770 RVA: 0x000A656C File Offset: 0x000A476C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr);
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, "<>1__state");
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, "<>2__current");
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, "<>4__this");
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr__url_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, "<url>5__2");
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr__requestCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, "<requestCommand>5__3");
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, 100665867);
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, 100665868);
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, 100665869);
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, 100665870);
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, 100665871);
				DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr, 100665872);
			}

			// Token: 0x06002A13 RID: 10771 RVA: 0x000A6674 File Offset: 0x000A4874
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCheckForReconnectableLiveGameCommand._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A14 RID: 10772 RVA: 0x000A66BC File Offset: 0x000A48BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A15 RID: 10773 RVA: 0x000A66F0 File Offset: 0x000A48F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515902, XrefRangeEnd = 516059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BD6 RID: 3030
			// (get) Token: 0x06002A16 RID: 10774 RVA: 0x000A672C File Offset: 0x000A492C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A17 RID: 10775 RVA: 0x000A676C File Offset: 0x000A496C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516059, XrefRangeEnd = 516064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BD7 RID: 3031
			// (get) Token: 0x06002A18 RID: 10776 RVA: 0x000A67A0 File Offset: 0x000A49A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002A19 RID: 10777 RVA: 0x00015ACC File Offset: 0x00013CCC
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BD1 RID: 3025
			// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000A67E0 File Offset: 0x000A49E0
			// (set) Token: 0x06002A1B RID: 10779 RVA: 0x00015AD5 File Offset: 0x00013CD5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BD2 RID: 3026
			// (get) Token: 0x06002A1C RID: 10780 RVA: 0x000A6808 File Offset: 0x000A4A08
			// (set) Token: 0x06002A1D RID: 10781 RVA: 0x00015AF0 File Offset: 0x00013CF0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD3 RID: 3027
			// (get) Token: 0x06002A1E RID: 10782 RVA: 0x000A6838 File Offset: 0x000A4A38
			// (set) Token: 0x06002A1F RID: 10783 RVA: 0x00015B0F File Offset: 0x00013D0F
			public unsafe DBGCheckForReconnectableLiveGameCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGCheckForReconnectableLiveGameCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD4 RID: 3028
			// (get) Token: 0x06002A20 RID: 10784 RVA: 0x000A6868 File Offset: 0x000A4A68
			// (set) Token: 0x06002A21 RID: 10785 RVA: 0x00015B2E File Offset: 0x00013D2E
			public unsafe string _url_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr__url_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr__url_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000BD5 RID: 3029
			// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000A6890 File Offset: 0x000A4A90
			// (set) Token: 0x06002A23 RID: 10787 RVA: 0x00015B4D File Offset: 0x00013D4D
			public unsafe DwdWebRequestCommand _requestCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr__requestCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGCheckForReconnectableLiveGameCommand._execute_d__3.NativeFieldInfoPtr__requestCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A40 RID: 6720
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A41 RID: 6721
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A42 RID: 6722
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001A43 RID: 6723
			private static readonly IntPtr NativeFieldInfoPtr__url_5__2;

			// Token: 0x04001A44 RID: 6724
			private static readonly IntPtr NativeFieldInfoPtr__requestCommand_5__3;

			// Token: 0x04001A45 RID: 6725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A46 RID: 6726
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A47 RID: 6727
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A48 RID: 6728
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A49 RID: 6729
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A4A RID: 6730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
