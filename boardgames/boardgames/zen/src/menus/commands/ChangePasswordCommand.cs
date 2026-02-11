using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace zen.src.menus.commands
{
	// Token: 0x0200005F RID: 95
	public class ChangePasswordCommand : Command
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x0001FA84 File Offset: 0x0001DC84
		// Note: this type is marked as 'beforefieldinit'.
		static ChangePasswordCommand()
		{
			Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus.commands", "ChangePasswordCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr);
			ChangePasswordCommand.NativeFieldInfoPtr_CHANGE_PASSWORD_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr, "CHANGE_PASSWORD_URL");
			ChangePasswordCommand.NativeFieldInfoPtr_OldPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr, "OldPassword");
			ChangePasswordCommand.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr, "Password");
			ChangePasswordCommand.NativeFieldInfoPtr_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr, "Complete");
			ChangePasswordCommand.NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr, "success");
			ChangePasswordCommand.NativeFieldInfoPtr_errorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr, "errorMessage");
			ChangePasswordCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr, 100663982);
			ChangePasswordCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr, 100663983);
			ChangePasswordCommand.NativeMethodInfoPtr_handlePassword_Private_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr, 100663984);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001FB68 File Offset: 0x0001DD68
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChangePasswordCommand(string oldPassword, string newPassword)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldPassword);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newPassword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001FBC8 File Offset: 0x0001DDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986627, XrefRangeEnd = 986632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChangePasswordCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001FC14 File Offset: 0x0001DE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986632, XrefRangeEnd = 986633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handlePassword(bool success, string errorMessageLocKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref success;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMessageLocKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordCommand.NativeMethodInfoPtr_handlePassword_Private_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00004529 File Offset: 0x00002729
		public ChangePasswordCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0001FC64 File Offset: 0x0001DE64
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00004532 File Offset: 0x00002732
		public unsafe static string CHANGE_PASSWORD_URL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChangePasswordCommand.NativeFieldInfoPtr_CHANGE_PASSWORD_URL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChangePasswordCommand.NativeFieldInfoPtr_CHANGE_PASSWORD_URL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0001FC84 File Offset: 0x0001DE84
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00004544 File Offset: 0x00002744
		public unsafe string OldPassword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand.NativeFieldInfoPtr_OldPassword);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand.NativeFieldInfoPtr_OldPassword), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0001FCAC File Offset: 0x0001DEAC
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00004563 File Offset: 0x00002763
		public unsafe string Password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand.NativeFieldInfoPtr_Password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0001FCD4 File Offset: 0x0001DED4
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00004582 File Offset: 0x00002782
		public unsafe bool Complete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand.NativeFieldInfoPtr_Complete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand.NativeFieldInfoPtr_Complete)) = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0001FCFC File Offset: 0x0001DEFC
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0000459D File Offset: 0x0000279D
		public unsafe bool success
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand.NativeFieldInfoPtr_success);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand.NativeFieldInfoPtr_success)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001FD24 File Offset: 0x0001DF24
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x000045B8 File Offset: 0x000027B8
		public unsafe string errorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand.NativeFieldInfoPtr_errorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand.NativeFieldInfoPtr_errorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_CHANGE_PASSWORD_URL;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_OldPassword;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_Password;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_Complete;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_success;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_errorMessage;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_handlePassword_Private_Void_Boolean_String_0;

		// Token: 0x020001CD RID: 461
		[ObfuscatedName("zen.src.menus.commands.ChangePasswordCommand+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x060015EA RID: 5610 RVA: 0x00054B58 File Offset: 0x00052D58
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangePasswordCommand>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr);
				ChangePasswordCommand._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr, "<>1__state");
				ChangePasswordCommand._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr, "<>2__current");
				ChangePasswordCommand._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr, "<>4__this");
				ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr, 100663985);
				ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr, 100663986);
				ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr, 100663987);
				ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr, 100663988);
				ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr, 100663989);
				ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr, 100663990);
			}

			// Token: 0x060015EB RID: 5611 RVA: 0x00054C38 File Offset: 0x00052E38
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangePasswordCommand._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015EC RID: 5612 RVA: 0x00054C80 File Offset: 0x00052E80
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015ED RID: 5613 RVA: 0x00054CB4 File Offset: 0x00052EB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986596, XrefRangeEnd = 986622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x060015EE RID: 5614 RVA: 0x00054CF0 File Offset: 0x00052EF0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015EF RID: 5615 RVA: 0x00054D30 File Offset: 0x00052F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986622, XrefRangeEnd = 986627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x060015F0 RID: 5616 RVA: 0x00054D64 File Offset: 0x00052F64
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordCommand._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015F1 RID: 5617 RVA: 0x0000C41F File Offset: 0x0000A61F
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x060015F2 RID: 5618 RVA: 0x00054DA4 File Offset: 0x00052FA4
			// (set) Token: 0x060015F3 RID: 5619 RVA: 0x0000C428 File Offset: 0x0000A628
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x060015F4 RID: 5620 RVA: 0x00054DCC File Offset: 0x00052FCC
			// (set) Token: 0x060015F5 RID: 5621 RVA: 0x0000C443 File Offset: 0x0000A643
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x060015F6 RID: 5622 RVA: 0x00054DFC File Offset: 0x00052FFC
			// (set) Token: 0x060015F7 RID: 5623 RVA: 0x0000C462 File Offset: 0x0000A662
			public unsafe ChangePasswordCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChangePasswordCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordCommand._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D4C RID: 3404
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D4D RID: 3405
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D4E RID: 3406
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D4F RID: 3407
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D50 RID: 3408
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D51 RID: 3409
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D52 RID: 3410
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D53 RID: 3411
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D54 RID: 3412
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
