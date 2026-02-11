using System;
using boardgames.menus.prompts;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;

namespace boardgames.menus.commands
{
	// Token: 0x02000234 RID: 564
	public class RunReportPlayerFlow : Command
	{
		// Token: 0x06001995 RID: 6549 RVA: 0x00070BDC File Offset: 0x0006EDDC
		// Note: this type is marked as 'beforefieldinit'.
		static RunReportPlayerFlow()
		{
			Il2CppClassPointerStore<RunReportPlayerFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunReportPlayerFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunReportPlayerFlow>.NativeClassPtr);
			RunReportPlayerFlow.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunReportPlayerFlow>.NativeClassPtr, "name");
			RunReportPlayerFlow.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunReportPlayerFlow>.NativeClassPtr, "accountID");
			RunReportPlayerFlow.NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow>.NativeClassPtr, 100667295);
			RunReportPlayerFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow>.NativeClassPtr, 100667296);
			RunReportPlayerFlow.NativeMethodInfoPtr__execute_b__3_0_Private_Boolean_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow>.NativeClassPtr, 100667297);
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00070C70 File Offset: 0x0006EE70
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunReportPlayerFlow(string name, AccountID accountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunReportPlayerFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunReportPlayerFlow.NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00070CD0 File Offset: 0x0006EED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529951, XrefRangeEnd = 529956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunReportPlayerFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00070D1C File Offset: 0x0006EF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529956, XrefRangeEnd = 529961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _execute_b__3_0(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunReportPlayerFlow.NativeMethodInfoPtr__execute_b__3_0_Private_Boolean_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0000E0AF File Offset: 0x0000C2AF
		public RunReportPlayerFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x00070D6C File Offset: 0x0006EF6C
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x00070D94 File Offset: 0x0006EF94
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x0000E0D7 File Offset: 0x0000C2D7
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_0_Private_Boolean_ClientChatMessage_0;

		// Token: 0x0200041B RID: 1051
		[ObfuscatedName("boardgames.menus.commands.RunReportPlayerFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060031B0 RID: 12720 RVA: 0x000BCBE4 File Offset: 0x000BADE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunReportPlayerFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunReportPlayerFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunReportPlayerFlow.__c>.NativeClassPtr);
				RunReportPlayerFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunReportPlayerFlow.__c>.NativeClassPtr, "<>9");
				RunReportPlayerFlow.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunReportPlayerFlow.__c>.NativeClassPtr, "<>9__3_1");
				RunReportPlayerFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow.__c>.NativeClassPtr, 100667299);
				RunReportPlayerFlow.__c.NativeMethodInfoPtr__execute_b__3_1_Internal_String_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow.__c>.NativeClassPtr, 100667300);
			}

			// Token: 0x060031B1 RID: 12721 RVA: 0x000BCC60 File Offset: 0x000BAE60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunReportPlayerFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunReportPlayerFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031B2 RID: 12722 RVA: 0x000BCC9C File Offset: 0x000BAE9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _execute_b__3_1(ClientChatMessage message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunReportPlayerFlow.__c.NativeMethodInfoPtr__execute_b__3_1_Internal_String_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060031B3 RID: 12723 RVA: 0x00019B31 File Offset: 0x00017D31
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E6E RID: 3694
			// (get) Token: 0x060031B4 RID: 12724 RVA: 0x000BCCE4 File Offset: 0x000BAEE4
			// (set) Token: 0x060031B5 RID: 12725 RVA: 0x00019B3A File Offset: 0x00017D3A
			public unsafe static RunReportPlayerFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunReportPlayerFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunReportPlayerFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunReportPlayerFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E6F RID: 3695
			// (get) Token: 0x060031B6 RID: 12726 RVA: 0x000BCD0C File Offset: 0x000BAF0C
			// (set) Token: 0x060031B7 RID: 12727 RVA: 0x00019B4C File Offset: 0x00017D4C
			public unsafe static Func<ClientChatMessage, string> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunReportPlayerFlow.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ClientChatMessage, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunReportPlayerFlow.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EB2 RID: 7858
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001EB3 RID: 7859
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04001EB4 RID: 7860
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001EB5 RID: 7861
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__3_1_Internal_String_ClientChatMessage_0;
		}

		// Token: 0x0200041C RID: 1052
		[ObfuscatedName("boardgames.menus.commands.RunReportPlayerFlow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x060031B8 RID: 12728 RVA: 0x000BCD34 File Offset: 0x000BAF34
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunReportPlayerFlow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr);
				RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr, "<>1__state");
				RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr, "<>2__current");
				RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr, "<>4__this");
				RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr__reportPlayerPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr, "<reportPlayerPrompt>5__2");
				RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr, 100667301);
				RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr, 100667302);
				RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr, 100667303);
				RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr, 100667304);
				RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr, 100667305);
				RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr, 100667306);
			}

			// Token: 0x060031B9 RID: 12729 RVA: 0x000BCE28 File Offset: 0x000BB028
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunReportPlayerFlow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031BA RID: 12730 RVA: 0x000BCE70 File Offset: 0x000BB070
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031BB RID: 12731 RVA: 0x000BCEA4 File Offset: 0x000BB0A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529897, XrefRangeEnd = 529946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E74 RID: 3700
			// (get) Token: 0x060031BC RID: 12732 RVA: 0x000BCEE0 File Offset: 0x000BB0E0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060031BD RID: 12733 RVA: 0x000BCF20 File Offset: 0x000BB120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529946, XrefRangeEnd = 529951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E75 RID: 3701
			// (get) Token: 0x060031BE RID: 12734 RVA: 0x000BCF54 File Offset: 0x000BB154
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunReportPlayerFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060031BF RID: 12735 RVA: 0x00019B5E File Offset: 0x00017D5E
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E70 RID: 3696
			// (get) Token: 0x060031C0 RID: 12736 RVA: 0x000BCF94 File Offset: 0x000BB194
			// (set) Token: 0x060031C1 RID: 12737 RVA: 0x00019B67 File Offset: 0x00017D67
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E71 RID: 3697
			// (get) Token: 0x060031C2 RID: 12738 RVA: 0x000BCFBC File Offset: 0x000BB1BC
			// (set) Token: 0x060031C3 RID: 12739 RVA: 0x00019B82 File Offset: 0x00017D82
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E72 RID: 3698
			// (get) Token: 0x060031C4 RID: 12740 RVA: 0x000BCFEC File Offset: 0x000BB1EC
			// (set) Token: 0x060031C5 RID: 12741 RVA: 0x00019BA1 File Offset: 0x00017DA1
			public unsafe RunReportPlayerFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunReportPlayerFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E73 RID: 3699
			// (get) Token: 0x060031C6 RID: 12742 RVA: 0x000BD01C File Offset: 0x000BB21C
			// (set) Token: 0x060031C7 RID: 12743 RVA: 0x00019BC0 File Offset: 0x00017DC0
			public unsafe ReportPlayerPrompt _reportPlayerPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr__reportPlayerPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportPlayerPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunReportPlayerFlow._execute_d__3.NativeFieldInfoPtr__reportPlayerPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EB6 RID: 7862
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EB7 RID: 7863
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001EB8 RID: 7864
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EB9 RID: 7865
			private static readonly IntPtr NativeFieldInfoPtr__reportPlayerPrompt_5__2;

			// Token: 0x04001EBA RID: 7866
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001EBB RID: 7867
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EBC RID: 7868
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001EBD RID: 7869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001EBE RID: 7870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EBF RID: 7871
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
