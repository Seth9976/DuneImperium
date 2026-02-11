using System;
using boardgames.matchMaking.commands;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dbg_client.commands
{
	// Token: 0x02000040 RID: 64
	public class InviteFriendToMatch : Command
	{
		// Token: 0x0600027E RID: 638 RVA: 0x000257D0 File Offset: 0x000239D0
		// Note: this type is marked as 'beforefieldinit'.
		static InviteFriendToMatch()
		{
			Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbg_client.commands", "InviteFriendToMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr);
			InviteFriendToMatch.NativeFieldInfoPtr_accountToSendTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr, "accountToSendTo");
			InviteFriendToMatch.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr, "gameID");
			InviteFriendToMatch.NativeFieldInfoPtr__friendMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr, "_friendMetadata");
			InviteFriendToMatch.NativeFieldInfoPtr_username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr, "username");
			InviteFriendToMatch.NativeFieldInfoPtr__matchInitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr, "_matchInitData");
			InviteFriendToMatch.NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_GameID_IDictionary_2_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr, 100663699);
			InviteFriendToMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr, 100663700);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0002588C File Offset: 0x00023A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 498888, RefRangeEnd = 498889, XrefRangeStart = 498882, XrefRangeEnd = 498888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InviteFriendToMatch(AccountID accountToSendTo, string username, GameID gameID, IDictionary<string, string> friendMetadata, string matchInitData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountToSendTo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(friendMetadata);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(matchInitData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InviteFriendToMatch.NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_GameID_IDictionary_2_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00025924 File Offset: 0x00023B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498889, XrefRangeEnd = 498894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InviteFriendToMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000313B File Offset: 0x0000133B
		public InviteFriendToMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00025970 File Offset: 0x00023B70
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00003144 File Offset: 0x00001344
		public unsafe AccountID accountToSendTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch.NativeFieldInfoPtr_accountToSendTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch.NativeFieldInfoPtr_accountToSendTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000284 RID: 644 RVA: 0x000259A0 File Offset: 0x00023BA0
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00003163 File Offset: 0x00001363
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000286 RID: 646 RVA: 0x000259D0 File Offset: 0x00023BD0
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00003182 File Offset: 0x00001382
		public unsafe IDictionary<string, string> _friendMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch.NativeFieldInfoPtr__friendMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch.NativeFieldInfoPtr__friendMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00025A00 File Offset: 0x00023C00
		// (set) Token: 0x06000289 RID: 649 RVA: 0x000031A1 File Offset: 0x000013A1
		public unsafe string username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch.NativeFieldInfoPtr_username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch.NativeFieldInfoPtr_username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00025A28 File Offset: 0x00023C28
		// (set) Token: 0x0600028B RID: 651 RVA: 0x000031C0 File Offset: 0x000013C0
		public unsafe string _matchInitData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch.NativeFieldInfoPtr__matchInitData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch.NativeFieldInfoPtr__matchInitData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_accountToSendTo;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr__friendMetadata;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_username;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr__matchInitData;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_GameID_IDictionary_2_String_String_String_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020002E1 RID: 737
		[ObfuscatedName("dbg_client.commands.InviteFriendToMatch+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x060022A9 RID: 8873 RVA: 0x00090294 File Offset: 0x0008E494
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InviteFriendToMatch>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr);
				InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr, "<>1__state");
				InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr, "<>2__current");
				InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr, "<>4__this");
				InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr__canInvite_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr, "<canInvite>5__2");
				InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr, 100663701);
				InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr, 100663702);
				InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr, 100663703);
				InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr, 100663704);
				InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr, 100663705);
				InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr, 100663706);
			}

			// Token: 0x060022AA RID: 8874 RVA: 0x00090388 File Offset: 0x0008E588
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InviteFriendToMatch._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022AB RID: 8875 RVA: 0x000903D0 File Offset: 0x0008E5D0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022AC RID: 8876 RVA: 0x00090404 File Offset: 0x0008E604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498866, XrefRangeEnd = 498877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700095B RID: 2395
			// (get) Token: 0x060022AD RID: 8877 RVA: 0x00090440 File Offset: 0x0008E640
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022AE RID: 8878 RVA: 0x00090480 File Offset: 0x0008E680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498877, XrefRangeEnd = 498882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700095C RID: 2396
			// (get) Token: 0x060022AF RID: 8879 RVA: 0x000904B4 File Offset: 0x0008E6B4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InviteFriendToMatch._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022B0 RID: 8880 RVA: 0x00012123 File Offset: 0x00010323
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000957 RID: 2391
			// (get) Token: 0x060022B1 RID: 8881 RVA: 0x000904F4 File Offset: 0x0008E6F4
			// (set) Token: 0x060022B2 RID: 8882 RVA: 0x0001212C File Offset: 0x0001032C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000958 RID: 2392
			// (get) Token: 0x060022B3 RID: 8883 RVA: 0x0009051C File Offset: 0x0008E71C
			// (set) Token: 0x060022B4 RID: 8884 RVA: 0x00012147 File Offset: 0x00010347
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000959 RID: 2393
			// (get) Token: 0x060022B5 RID: 8885 RVA: 0x0009054C File Offset: 0x0008E74C
			// (set) Token: 0x060022B6 RID: 8886 RVA: 0x00012166 File Offset: 0x00010366
			public unsafe InviteFriendToMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InviteFriendToMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095A RID: 2394
			// (get) Token: 0x060022B7 RID: 8887 RVA: 0x0009057C File Offset: 0x0008E77C
			// (set) Token: 0x060022B8 RID: 8888 RVA: 0x00012185 File Offset: 0x00010385
			public unsafe ICanInviteUser _canInvite_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr__canInvite_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICanInviteUser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InviteFriendToMatch._execute_d__6.NativeFieldInfoPtr__canInvite_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015CC RID: 5580
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015CD RID: 5581
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015CE RID: 5582
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015CF RID: 5583
			private static readonly IntPtr NativeFieldInfoPtr__canInvite_5__2;

			// Token: 0x040015D0 RID: 5584
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015D1 RID: 5585
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015D2 RID: 5586
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015D3 RID: 5587
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015D4 RID: 5588
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015D5 RID: 5589
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
