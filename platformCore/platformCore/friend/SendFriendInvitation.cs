using System;
using Canis.utils.ids;
using dwd.core;
using dwd.core.commands;
using dwd.core.platform.providers;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace platformCore.friend
{
	// Token: 0x02000011 RID: 17
	public class SendFriendInvitation : Command
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x0000588C File Offset: 0x00003A8C
		// Note: this type is marked as 'beforefieldinit'.
		static SendFriendInvitation()
		{
			Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr = IL2CPP.GetIl2CppClass("platformCore.dll", "platformCore.friend", "SendFriendInvitation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr);
			SendFriendInvitation.NativeFieldInfoPtr_emailOrScreenname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, "emailOrScreenname");
			SendFriendInvitation.NativeFieldInfoPtr_inviteeAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, "inviteeAccountID");
			SendFriendInvitation.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, "provider");
			SendFriendInvitation.NativeFieldInfoPtr_finished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, "finished");
			SendFriendInvitation.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, "info");
			SendFriendInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, 100663424);
			SendFriendInvitation.NativeMethodInfoPtr__ctor_Public_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, 100663425);
			SendFriendInvitation.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, 100663426);
			SendFriendInvitation.NativeMethodInfoPtr_AccountNotFound_Private_Void_AccountNotFound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, 100663427);
			SendFriendInvitation.NativeMethodInfoPtr_InvitationSuccess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, 100663428);
			SendFriendInvitation.NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, 100663429);
			SendFriendInvitation.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, 100663430);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000059AC File Offset: 0x00003BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250701, XrefRangeEnd = 1250707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendFriendInvitation(string emailOrScreenname)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(emailOrScreenname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000059F8 File Offset: 0x00003BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250707, XrefRangeEnd = 1250713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendFriendInvitation(AccountID inviteeAccountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inviteeAccountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation.NativeMethodInfoPtr__ctor_Public_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005A44 File Offset: 0x00003C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250713, XrefRangeEnd = 1250718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendFriendInvitation.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005A90 File Offset: 0x00003C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250718, XrefRangeEnd = 1250729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccountNotFound(AccountNotFound msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation.NativeMethodInfoPtr_AccountNotFound_Private_Void_AccountNotFound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250729, XrefRangeEnd = 1250740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvitationSuccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation.NativeMethodInfoPtr_InvitationSuccess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005B08 File Offset: 0x00003D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250740, XrefRangeEnd = 1250765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interrupted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation.NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005B3C File Offset: 0x00003D3C
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000275F File Offset: 0x0000095F
		public SendFriendInvitation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005B74 File Offset: 0x00003D74
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002768 File Offset: 0x00000968
		public unsafe string emailOrScreenname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation.NativeFieldInfoPtr_emailOrScreenname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation.NativeFieldInfoPtr_emailOrScreenname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005B9C File Offset: 0x00003D9C
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002787 File Offset: 0x00000987
		public unsafe AccountID inviteeAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation.NativeFieldInfoPtr_inviteeAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation.NativeFieldInfoPtr_inviteeAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00005BCC File Offset: 0x00003DCC
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000027A6 File Offset: 0x000009A6
		public unsafe PlatformProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005BFC File Offset: 0x00003DFC
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000027C5 File Offset: 0x000009C5
		public unsafe bool finished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation.NativeFieldInfoPtr_finished);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation.NativeFieldInfoPtr_finished)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005C24 File Offset: 0x00003E24
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000027E0 File Offset: 0x000009E0
		public ErrorInfo info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation.NativeFieldInfoPtr_info);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation.NativeFieldInfoPtr_info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_emailOrScreenname;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_inviteeAccountID;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_finished;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_AccountNotFound_Private_Void_AccountNotFound_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_InvitationSuccess_Private_Void_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x02000021 RID: 33
		[ObfuscatedName("platformCore.friend.SendFriendInvitation+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x060001B7 RID: 439 RVA: 0x000083C4 File Offset: 0x000065C4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendFriendInvitation>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr);
				SendFriendInvitation._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr, "<>1__state");
				SendFriendInvitation._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr, "<>2__current");
				SendFriendInvitation._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr, "<>4__this");
				SendFriendInvitation._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr, 100663431);
				SendFriendInvitation._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr, 100663432);
				SendFriendInvitation._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr, 100663433);
				SendFriendInvitation._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr, 100663434);
				SendFriendInvitation._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr, 100663435);
				SendFriendInvitation._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr, 100663436);
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x000084A4 File Offset: 0x000066A4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendFriendInvitation._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x000084EC File Offset: 0x000066EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001BA RID: 442 RVA: 0x00008520 File Offset: 0x00006720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250645, XrefRangeEnd = 1250696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x060001BB RID: 443 RVA: 0x0000855C File Offset: 0x0000675C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001BC RID: 444 RVA: 0x0000859C File Offset: 0x0000679C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250696, XrefRangeEnd = 1250701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x060001BD RID: 445 RVA: 0x000085D0 File Offset: 0x000067D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFriendInvitation._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001BE RID: 446 RVA: 0x00002FA9 File Offset: 0x000011A9
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x060001BF RID: 447 RVA: 0x00008610 File Offset: 0x00006810
			// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002FB2 File Offset: 0x000011B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x060001C1 RID: 449 RVA: 0x00008638 File Offset: 0x00006838
			// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002FCD File Offset: 0x000011CD
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x060001C3 RID: 451 RVA: 0x00008668 File Offset: 0x00006868
			// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002FEC File Offset: 0x000011EC
			public unsafe SendFriendInvitation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendFriendInvitation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFriendInvitation._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000102 RID: 258
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000103 RID: 259
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000104 RID: 260
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000105 RID: 261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000106 RID: 262
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
