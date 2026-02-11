using System;
using Canis.utils.ids;
using dbgclient.data;
using dbgclient.prompts;
using dwd.core;
using dwd.core.commands;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dbgclient.commands
{
	// Token: 0x020000DC RID: 220
	public class RunConfigureFriendGameFlow : Command
	{
		// Token: 0x06000960 RID: 2400 RVA: 0x0003B1CC File Offset: 0x000393CC
		// Note: this type is marked as 'beforefieldinit'.
		static RunConfigureFriendGameFlow()
		{
			Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.commands", "RunConfigureFriendGameFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr);
			RunConfigureFriendGameFlow.NativeFieldInfoPtr_selectedFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr, "selectedFriend");
			RunConfigureFriendGameFlow.NativeFieldInfoPtr_returnToFriendsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr, "returnToFriendsList");
			RunConfigureFriendGameFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr, 100664657);
			RunConfigureFriendGameFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr, 100664658);
			RunConfigureFriendGameFlow.NativeMethodInfoPtr_handleError_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr, 100664659);
			RunConfigureFriendGameFlow.NativeMethodInfoPtr__execute_b__3_2_Private_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr, 100664660);
			RunConfigureFriendGameFlow.NativeMethodInfoPtr__handleError_b__4_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr, 100664661);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0003B288 File Offset: 0x00039488
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 505858, RefRangeEnd = 505863, XrefRangeStart = 505856, XrefRangeEnd = 505858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunConfigureFriendGameFlow(DataComposition selectedFriend, bool returnToFriendsList)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedFriend);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnToFriendsList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0003B2E4 File Offset: 0x000394E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505863, XrefRangeEnd = 505868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunConfigureFriendGameFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0003B330 File Offset: 0x00039530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505891, RefRangeEnd = 505893, XrefRangeStart = 505868, XrefRangeEnd = 505891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleError(string errorMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow.NativeMethodInfoPtr_handleError_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0003B374 File Offset: 0x00039574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505893, XrefRangeEnd = 505897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__3_2(ErrorInfo error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(error));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow.NativeMethodInfoPtr__execute_b__3_2_Private_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0003B3BC File Offset: 0x000395BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505897, XrefRangeEnd = 505902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _handleError_b__4_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow.NativeMethodInfoPtr__handleError_b__4_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00006707 File Offset: 0x00004907
		public RunConfigureFriendGameFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0003B3F0 File Offset: 0x000395F0
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00006710 File Offset: 0x00004910
		public unsafe DataComposition selectedFriend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow.NativeFieldInfoPtr_selectedFriend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow.NativeFieldInfoPtr_selectedFriend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0003B420 File Offset: 0x00039620
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x0000672F File Offset: 0x0000492F
		public unsafe bool returnToFriendsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow.NativeFieldInfoPtr_returnToFriendsList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow.NativeFieldInfoPtr_returnToFriendsList)) = value;
			}
		}

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr_selectedFriend;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeFieldInfoPtr_returnToFriendsList;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Boolean_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_handleError_Private_Void_String_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_2_Private_Void_ErrorInfo_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr__handleError_b__4_0_Private_Void_0;

		// Token: 0x0200032D RID: 813
		[ObfuscatedName("dbgclient.commands.RunConfigureFriendGameFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002657 RID: 9815 RVA: 0x0009B344 File Offset: 0x00099544
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunConfigureFriendGameFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureFriendGameFlow.__c>.NativeClassPtr);
				RunConfigureFriendGameFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureFriendGameFlow.__c>.NativeClassPtr, "<>9");
				RunConfigureFriendGameFlow.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureFriendGameFlow.__c>.NativeClassPtr, "<>9__3_0");
				RunConfigureFriendGameFlow.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureFriendGameFlow.__c>.NativeClassPtr, "<>9__3_1");
				RunConfigureFriendGameFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow.__c>.NativeClassPtr, 100664663);
				RunConfigureFriendGameFlow.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_AccountID_FriendGameInviteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow.__c>.NativeClassPtr, 100664664);
				RunConfigureFriendGameFlow.__c.NativeMethodInfoPtr__execute_b__3_1_Internal_String_FriendGameInviteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow.__c>.NativeClassPtr, 100664665);
			}

			// Token: 0x06002658 RID: 9816 RVA: 0x0009B3E8 File Offset: 0x000995E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureFriendGameFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002659 RID: 9817 RVA: 0x0009B424 File Offset: 0x00099624
			[CallerCount(0)]
			public unsafe AccountID _execute_b__3_0(FriendGameInviteData f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow.__c.NativeMethodInfoPtr__execute_b__3_0_Internal_AccountID_FriendGameInviteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x0600265A RID: 9818 RVA: 0x0009B474 File Offset: 0x00099674
			[CallerCount(0)]
			public unsafe string _execute_b__3_1(FriendGameInviteData f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow.__c.NativeMethodInfoPtr__execute_b__3_1_Internal_String_FriendGameInviteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600265B RID: 9819 RVA: 0x00013DDE File Offset: 0x00011FDE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A98 RID: 2712
			// (get) Token: 0x0600265C RID: 9820 RVA: 0x0009B4BC File Offset: 0x000996BC
			// (set) Token: 0x0600265D RID: 9821 RVA: 0x00013DE7 File Offset: 0x00011FE7
			public unsafe static RunConfigureFriendGameFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunConfigureFriendGameFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunConfigureFriendGameFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunConfigureFriendGameFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A99 RID: 2713
			// (get) Token: 0x0600265E RID: 9822 RVA: 0x0009B4E4 File Offset: 0x000996E4
			// (set) Token: 0x0600265F RID: 9823 RVA: 0x00013DF9 File Offset: 0x00011FF9
			public unsafe static Func<FriendGameInviteData, AccountID> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunConfigureFriendGameFlow.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FriendGameInviteData, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunConfigureFriendGameFlow.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9A RID: 2714
			// (get) Token: 0x06002660 RID: 9824 RVA: 0x0009B50C File Offset: 0x0009970C
			// (set) Token: 0x06002661 RID: 9825 RVA: 0x00013E0B File Offset: 0x0001200B
			public unsafe static Func<FriendGameInviteData, string> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunConfigureFriendGameFlow.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FriendGameInviteData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunConfigureFriendGameFlow.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001808 RID: 6152
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001809 RID: 6153
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400180A RID: 6154
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x0400180B RID: 6155
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400180C RID: 6156
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_0_Internal_AccountID_FriendGameInviteData_0;

			// Token: 0x0400180D RID: 6157
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_1_Internal_String_FriendGameInviteData_0;
		}

		// Token: 0x0200032E RID: 814
		[ObfuscatedName("dbgclient.commands.RunConfigureFriendGameFlow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06002662 RID: 9826 RVA: 0x0009B534 File Offset: 0x00099734
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunConfigureFriendGameFlow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr);
				RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, "<>1__state");
				RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, "<>2__current");
				RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, "<>4__this");
				RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr__configPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, "<configPrompt>5__2");
				RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr__inviteFriend_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, "<inviteFriend>5__3");
				RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, 100664666);
				RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, 100664667);
				RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, 100664668);
				RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, 100664669);
				RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, 100664670);
				RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr, 100664671);
			}

			// Token: 0x06002663 RID: 9827 RVA: 0x0009B63C File Offset: 0x0009983C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunConfigureFriendGameFlow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002664 RID: 9828 RVA: 0x0009B684 File Offset: 0x00099884
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002665 RID: 9829 RVA: 0x0009B6B8 File Offset: 0x000998B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505700, XrefRangeEnd = 505851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AA0 RID: 2720
			// (get) Token: 0x06002666 RID: 9830 RVA: 0x0009B6F4 File Offset: 0x000998F4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002667 RID: 9831 RVA: 0x0009B734 File Offset: 0x00099934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505851, XrefRangeEnd = 505856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AA1 RID: 2721
			// (get) Token: 0x06002668 RID: 9832 RVA: 0x0009B768 File Offset: 0x00099968
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunConfigureFriendGameFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002669 RID: 9833 RVA: 0x00013E1D File Offset: 0x0001201D
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A9B RID: 2715
			// (get) Token: 0x0600266A RID: 9834 RVA: 0x0009B7A8 File Offset: 0x000999A8
			// (set) Token: 0x0600266B RID: 9835 RVA: 0x00013E26 File Offset: 0x00012026
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A9C RID: 2716
			// (get) Token: 0x0600266C RID: 9836 RVA: 0x0009B7D0 File Offset: 0x000999D0
			// (set) Token: 0x0600266D RID: 9837 RVA: 0x00013E41 File Offset: 0x00012041
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9D RID: 2717
			// (get) Token: 0x0600266E RID: 9838 RVA: 0x0009B800 File Offset: 0x00099A00
			// (set) Token: 0x0600266F RID: 9839 RVA: 0x00013E60 File Offset: 0x00012060
			public unsafe RunConfigureFriendGameFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunConfigureFriendGameFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9E RID: 2718
			// (get) Token: 0x06002670 RID: 9840 RVA: 0x0009B830 File Offset: 0x00099A30
			// (set) Token: 0x06002671 RID: 9841 RVA: 0x00013E7F File Offset: 0x0001207F
			public unsafe ConfigureFriendGamePrompt _configPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr__configPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigureFriendGamePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr__configPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9F RID: 2719
			// (get) Token: 0x06002672 RID: 9842 RVA: 0x0009B860 File Offset: 0x00099A60
			// (set) Token: 0x06002673 RID: 9843 RVA: 0x00013E9E File Offset: 0x0001209E
			public unsafe DBGRequestFriendMatch _inviteFriend_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr__inviteFriend_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGRequestFriendMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunConfigureFriendGameFlow._execute_d__3.NativeFieldInfoPtr__inviteFriend_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400180E RID: 6158
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400180F RID: 6159
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001810 RID: 6160
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001811 RID: 6161
			private static readonly IntPtr NativeFieldInfoPtr__configPrompt_5__2;

			// Token: 0x04001812 RID: 6162
			private static readonly IntPtr NativeFieldInfoPtr__inviteFriend_5__3;

			// Token: 0x04001813 RID: 6163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001814 RID: 6164
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001815 RID: 6165
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001816 RID: 6166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001817 RID: 6167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001818 RID: 6168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
