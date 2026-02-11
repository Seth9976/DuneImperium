using System;
using Canis.utils.ids;
using dwd.core;
using dwd.core.commands;
using dwd.core.platform.websocket.incoming;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x0200021B RID: 539
	public class RunBlockAccountFlow : Command
	{
		// Token: 0x060018A2 RID: 6306 RVA: 0x0006D788 File Offset: 0x0006B988
		// Note: this type is marked as 'beforefieldinit'.
		static RunBlockAccountFlow()
		{
			Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunBlockAccountFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr);
			RunBlockAccountFlow.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, "name");
			RunBlockAccountFlow.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, "accountID");
			RunBlockAccountFlow.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, "info");
			RunBlockAccountFlow.NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, 100666984);
			RunBlockAccountFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, 100666985);
			RunBlockAccountFlow.NativeMethodInfoPtr_openConfirmationPrompt_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, 100666986);
			RunBlockAccountFlow.NativeMethodInfoPtr_openWouldYouLikeToReportPrompt_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, 100666987);
			RunBlockAccountFlow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, 100666988);
			RunBlockAccountFlow.NativeMethodInfoPtr__openConfirmationPrompt_b__5_0_Private_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, 100666989);
			RunBlockAccountFlow.NativeMethodInfoPtr__openConfirmationPrompt_b__5_1_Private_Boolean_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, 100666990);
			RunBlockAccountFlow.NativeMethodInfoPtr__openConfirmationPrompt_b__5_2_Private_Boolean_InvitationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, 100666991);
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0006D894 File Offset: 0x0006BA94
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunBlockAccountFlow(string name, AccountID accountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow.NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0006D8F4 File Offset: 0x0006BAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527655, XrefRangeEnd = 527660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunBlockAccountFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0006D940 File Offset: 0x0006BB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527660, XrefRangeEnd = 527665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator openConfirmationPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow.NativeMethodInfoPtr_openConfirmationPrompt_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0006D980 File Offset: 0x0006BB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527665, XrefRangeEnd = 527670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator openWouldYouLikeToReportPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow.NativeMethodInfoPtr_openWouldYouLikeToReportPrompt_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0006D9C0 File Offset: 0x0006BBC0
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0006D9F8 File Offset: 0x0006BBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527670, XrefRangeEnd = 527672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _openConfirmationPrompt_b__5_0(RosterEntry friend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow.NativeMethodInfoPtr__openConfirmationPrompt_b__5_0_Private_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0006DA48 File Offset: 0x0006BC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527672, XrefRangeEnd = 527674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _openConfirmationPrompt_b__5_1(InvitationEntry invite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(invite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow.NativeMethodInfoPtr__openConfirmationPrompt_b__5_1_Private_Boolean_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0006DA98 File Offset: 0x0006BC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527674, XrefRangeEnd = 527676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _openConfirmationPrompt_b__5_2(InvitationEntry invite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(invite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow.NativeMethodInfoPtr__openConfirmationPrompt_b__5_2_Private_Boolean_InvitationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0000DA34 File Offset: 0x0000BC34
		public RunBlockAccountFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x0006DAE8 File Offset: 0x0006BCE8
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x0000DA3D File Offset: 0x0000BC3D
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x0006DB10 File Offset: 0x0006BD10
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x0006DB40 File Offset: 0x0006BD40
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x0000DA7B File Offset: 0x0000BC7B
		public ErrorInfo info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow.NativeFieldInfoPtr_info);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow.NativeFieldInfoPtr_info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_openConfirmationPrompt_Private_IEnumerator_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_openWouldYouLikeToReportPrompt_Private_IEnumerator_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr__openConfirmationPrompt_b__5_0_Private_Boolean_RosterEntry_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr__openConfirmationPrompt_b__5_1_Private_Boolean_InvitationEntry_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr__openConfirmationPrompt_b__5_2_Private_Boolean_InvitationEntry_0;

		// Token: 0x020003F3 RID: 1011
		[ObfuscatedName("boardgames.menus.commands.RunBlockAccountFlow+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06002F45 RID: 12101 RVA: 0x000B59A0 File Offset: 0x000B3BA0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr);
				RunBlockAccountFlow._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr, "<>1__state");
				RunBlockAccountFlow._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr, "<>2__current");
				RunBlockAccountFlow._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr, "<>4__this");
				RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr, 100666992);
				RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr, 100666993);
				RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr, 100666994);
				RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr, 100666995);
				RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr, 100666996);
				RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr, 100666997);
			}

			// Token: 0x06002F46 RID: 12102 RVA: 0x000B5A80 File Offset: 0x000B3C80
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunBlockAccountFlow._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F47 RID: 12103 RVA: 0x000B5AC8 File Offset: 0x000B3CC8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F48 RID: 12104 RVA: 0x000B5AFC File Offset: 0x000B3CFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527532, XrefRangeEnd = 527538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D8D RID: 3469
			// (get) Token: 0x06002F49 RID: 12105 RVA: 0x000B5B38 File Offset: 0x000B3D38
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F4A RID: 12106 RVA: 0x000B5B78 File Offset: 0x000B3D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527538, XrefRangeEnd = 527543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D8E RID: 3470
			// (get) Token: 0x06002F4B RID: 12107 RVA: 0x000B5BAC File Offset: 0x000B3DAC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F4C RID: 12108 RVA: 0x000186C8 File Offset: 0x000168C8
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D8A RID: 3466
			// (get) Token: 0x06002F4D RID: 12109 RVA: 0x000B5BEC File Offset: 0x000B3DEC
			// (set) Token: 0x06002F4E RID: 12110 RVA: 0x000186D1 File Offset: 0x000168D1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D8B RID: 3467
			// (get) Token: 0x06002F4F RID: 12111 RVA: 0x000B5C14 File Offset: 0x000B3E14
			// (set) Token: 0x06002F50 RID: 12112 RVA: 0x000186EC File Offset: 0x000168EC
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D8C RID: 3468
			// (get) Token: 0x06002F51 RID: 12113 RVA: 0x000B5C44 File Offset: 0x000B3E44
			// (set) Token: 0x06002F52 RID: 12114 RVA: 0x0001870B File Offset: 0x0001690B
			public unsafe RunBlockAccountFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunBlockAccountFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D3F RID: 7487
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D40 RID: 7488
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D41 RID: 7489
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D42 RID: 7490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D43 RID: 7491
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D44 RID: 7492
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D45 RID: 7493
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D46 RID: 7494
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D47 RID: 7495
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003F4 RID: 1012
		[ObfuscatedName("boardgames.menus.commands.RunBlockAccountFlow+<openConfirmationPrompt>d__5")]
		public sealed class _openConfirmationPrompt_d__5 : Object
		{
			// Token: 0x06002F53 RID: 12115 RVA: 0x000B5C74 File Offset: 0x000B3E74
			// Note: this type is marked as 'beforefieldinit'.
			static _openConfirmationPrompt_d__5()
			{
				Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, "<openConfirmationPrompt>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr);
				RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr, "<>1__state");
				RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr, "<>2__current");
				RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr, "<>4__this");
				RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr__confirmOrDeny_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr, "<confirmOrDeny>5__2");
				RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr, 100666998);
				RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr, 100666999);
				RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr, 100667000);
				RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr, 100667001);
				RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr, 100667002);
				RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr, 100667003);
			}

			// Token: 0x06002F54 RID: 12116 RVA: 0x000B5D68 File Offset: 0x000B3F68
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _openConfirmationPrompt_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunBlockAccountFlow._openConfirmationPrompt_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F55 RID: 12117 RVA: 0x000B5DB0 File Offset: 0x000B3FB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F56 RID: 12118 RVA: 0x000B5DE4 File Offset: 0x000B3FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527543, XrefRangeEnd = 527611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D93 RID: 3475
			// (get) Token: 0x06002F57 RID: 12119 RVA: 0x000B5E20 File Offset: 0x000B4020
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F58 RID: 12120 RVA: 0x000B5E60 File Offset: 0x000B4060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527611, XrefRangeEnd = 527616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D94 RID: 3476
			// (get) Token: 0x06002F59 RID: 12121 RVA: 0x000B5E94 File Offset: 0x000B4094
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F5A RID: 12122 RVA: 0x0001872A File Offset: 0x0001692A
			public _openConfirmationPrompt_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D8F RID: 3471
			// (get) Token: 0x06002F5B RID: 12123 RVA: 0x000B5ED4 File Offset: 0x000B40D4
			// (set) Token: 0x06002F5C RID: 12124 RVA: 0x00018733 File Offset: 0x00016933
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D90 RID: 3472
			// (get) Token: 0x06002F5D RID: 12125 RVA: 0x000B5EFC File Offset: 0x000B40FC
			// (set) Token: 0x06002F5E RID: 12126 RVA: 0x0001874E File Offset: 0x0001694E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D91 RID: 3473
			// (get) Token: 0x06002F5F RID: 12127 RVA: 0x000B5F2C File Offset: 0x000B412C
			// (set) Token: 0x06002F60 RID: 12128 RVA: 0x0001876D File Offset: 0x0001696D
			public unsafe RunBlockAccountFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunBlockAccountFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D92 RID: 3474
			// (get) Token: 0x06002F61 RID: 12129 RVA: 0x000B5F5C File Offset: 0x000B415C
			// (set) Token: 0x06002F62 RID: 12130 RVA: 0x0001878C File Offset: 0x0001698C
			public unsafe ConfirmOrDenyPrompt _confirmOrDeny_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr__confirmOrDeny_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openConfirmationPrompt_d__5.NativeFieldInfoPtr__confirmOrDeny_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D48 RID: 7496
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D49 RID: 7497
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D4A RID: 7498
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D4B RID: 7499
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDeny_5__2;

			// Token: 0x04001D4C RID: 7500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D4D RID: 7501
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D4E RID: 7502
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D4F RID: 7503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D50 RID: 7504
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D51 RID: 7505
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003F5 RID: 1013
		[ObfuscatedName("boardgames.menus.commands.RunBlockAccountFlow+<openWouldYouLikeToReportPrompt>d__6")]
		public sealed class _openWouldYouLikeToReportPrompt_d__6 : Object
		{
			// Token: 0x06002F63 RID: 12131 RVA: 0x000B5F8C File Offset: 0x000B418C
			// Note: this type is marked as 'beforefieldinit'.
			static _openWouldYouLikeToReportPrompt_d__6()
			{
				Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunBlockAccountFlow>.NativeClassPtr, "<openWouldYouLikeToReportPrompt>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr);
				RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr, "<>1__state");
				RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr, "<>2__current");
				RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr, "<>4__this");
				RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr__confirmOrDeny_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr, "<confirmOrDeny>5__2");
				RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr, 100667004);
				RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr, 100667005);
				RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr, 100667006);
				RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr, 100667007);
				RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr, 100667008);
				RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr, 100667009);
			}

			// Token: 0x06002F64 RID: 12132 RVA: 0x000B6080 File Offset: 0x000B4280
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _openWouldYouLikeToReportPrompt_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F65 RID: 12133 RVA: 0x000B60C8 File Offset: 0x000B42C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F66 RID: 12134 RVA: 0x000B60FC File Offset: 0x000B42FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527616, XrefRangeEnd = 527650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D99 RID: 3481
			// (get) Token: 0x06002F67 RID: 12135 RVA: 0x000B6138 File Offset: 0x000B4338
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F68 RID: 12136 RVA: 0x000B6178 File Offset: 0x000B4378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527650, XrefRangeEnd = 527655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D9A RID: 3482
			// (get) Token: 0x06002F69 RID: 12137 RVA: 0x000B61AC File Offset: 0x000B43AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F6A RID: 12138 RVA: 0x000187AB File Offset: 0x000169AB
			public _openWouldYouLikeToReportPrompt_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D95 RID: 3477
			// (get) Token: 0x06002F6B RID: 12139 RVA: 0x000B61EC File Offset: 0x000B43EC
			// (set) Token: 0x06002F6C RID: 12140 RVA: 0x000187B4 File Offset: 0x000169B4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D96 RID: 3478
			// (get) Token: 0x06002F6D RID: 12141 RVA: 0x000B6214 File Offset: 0x000B4414
			// (set) Token: 0x06002F6E RID: 12142 RVA: 0x000187CF File Offset: 0x000169CF
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D97 RID: 3479
			// (get) Token: 0x06002F6F RID: 12143 RVA: 0x000B6244 File Offset: 0x000B4444
			// (set) Token: 0x06002F70 RID: 12144 RVA: 0x000187EE File Offset: 0x000169EE
			public unsafe RunBlockAccountFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunBlockAccountFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D98 RID: 3480
			// (get) Token: 0x06002F71 RID: 12145 RVA: 0x000B6274 File Offset: 0x000B4474
			// (set) Token: 0x06002F72 RID: 12146 RVA: 0x0001880D File Offset: 0x00016A0D
			public unsafe ConfirmOrDenyPrompt _confirmOrDeny_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr__confirmOrDeny_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunBlockAccountFlow._openWouldYouLikeToReportPrompt_d__6.NativeFieldInfoPtr__confirmOrDeny_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D52 RID: 7506
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D53 RID: 7507
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D54 RID: 7508
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D55 RID: 7509
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDeny_5__2;

			// Token: 0x04001D56 RID: 7510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D57 RID: 7511
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D58 RID: 7512
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D59 RID: 7513
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D5A RID: 7514
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D5B RID: 7515
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
