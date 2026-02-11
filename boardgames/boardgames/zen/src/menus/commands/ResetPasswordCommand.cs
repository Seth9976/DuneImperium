using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace zen.src.menus.commands
{
	// Token: 0x02000060 RID: 96
	public class ResetPasswordCommand : Command
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x0001FD4C File Offset: 0x0001DF4C
		// Note: this type is marked as 'beforefieldinit'.
		static ResetPasswordCommand()
		{
			Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus.commands", "ResetPasswordCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr);
			ResetPasswordCommand.NativeFieldInfoPtr_RECOVER_PASSWORD_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr, "RECOVER_PASSWORD_URL");
			ResetPasswordCommand.NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr, "success");
			ResetPasswordCommand.NativeFieldInfoPtr_errorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr, "errorMessage");
			ResetPasswordCommand.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr, "Username");
			ResetPasswordCommand.NativeFieldInfoPtr_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr, "Complete");
			ResetPasswordCommand.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr, 100663991);
			ResetPasswordCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr, 100663992);
			ResetPasswordCommand.NativeMethodInfoPtr_handleForgotPassword_Private_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr, 100663993);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001FE1C File Offset: 0x0001E01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 986665, RefRangeEnd = 986666, XrefRangeStart = 986663, XrefRangeEnd = 986665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResetPasswordCommand(string username)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPasswordCommand.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001FE68 File Offset: 0x0001E068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986666, XrefRangeEnd = 986671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResetPasswordCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001FEB4 File Offset: 0x0001E0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986671, XrefRangeEnd = 986672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleForgotPassword(bool success, string errorMessageLocKey)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPasswordCommand.NativeMethodInfoPtr_handleForgotPassword_Private_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000045D7 File Offset: 0x000027D7
		public ResetPasswordCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0001FF04 File Offset: 0x0001E104
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x000045E0 File Offset: 0x000027E0
		public unsafe static string RECOVER_PASSWORD_URL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResetPasswordCommand.NativeFieldInfoPtr_RECOVER_PASSWORD_URL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResetPasswordCommand.NativeFieldInfoPtr_RECOVER_PASSWORD_URL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0001FF24 File Offset: 0x0001E124
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x000045F2 File Offset: 0x000027F2
		public unsafe bool success
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand.NativeFieldInfoPtr_success);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand.NativeFieldInfoPtr_success)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0001FF4C File Offset: 0x0001E14C
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x0000460D File Offset: 0x0000280D
		public unsafe string errorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand.NativeFieldInfoPtr_errorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand.NativeFieldInfoPtr_errorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0001FF74 File Offset: 0x0001E174
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0000462C File Offset: 0x0000282C
		public unsafe string Username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand.NativeFieldInfoPtr_Username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0001FF9C File Offset: 0x0001E19C
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x0000464B File Offset: 0x0000284B
		public unsafe bool Complete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand.NativeFieldInfoPtr_Complete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand.NativeFieldInfoPtr_Complete)) = value;
			}
		}

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_RECOVER_PASSWORD_URL;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeFieldInfoPtr_success;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_errorMessage;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_Username;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeFieldInfoPtr_Complete;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_handleForgotPassword_Private_Void_Boolean_String_0;

		// Token: 0x020001CE RID: 462
		[ObfuscatedName("zen.src.menus.commands.ResetPasswordCommand+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x060015F8 RID: 5624 RVA: 0x00054E2C File Offset: 0x0005302C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResetPasswordCommand>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr);
				ResetPasswordCommand._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr, "<>1__state");
				ResetPasswordCommand._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr, "<>2__current");
				ResetPasswordCommand._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr, "<>4__this");
				ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr, 100663994);
				ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr, 100663995);
				ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr, 100663996);
				ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr, 100663997);
				ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr, 100663998);
				ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr, 100663999);
			}

			// Token: 0x060015F9 RID: 5625 RVA: 0x00054F0C File Offset: 0x0005310C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResetPasswordCommand._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015FA RID: 5626 RVA: 0x00054F54 File Offset: 0x00053154
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015FB RID: 5627 RVA: 0x00054F88 File Offset: 0x00053188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986633, XrefRangeEnd = 986658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x060015FC RID: 5628 RVA: 0x00054FC4 File Offset: 0x000531C4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015FD RID: 5629 RVA: 0x00055004 File Offset: 0x00053204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986658, XrefRangeEnd = 986663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x060015FE RID: 5630 RVA: 0x00055038 File Offset: 0x00053238
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPasswordCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015FF RID: 5631 RVA: 0x0000C481 File Offset: 0x0000A681
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x06001600 RID: 5632 RVA: 0x00055078 File Offset: 0x00053278
			// (set) Token: 0x06001601 RID: 5633 RVA: 0x0000C48A File Offset: 0x0000A68A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x06001602 RID: 5634 RVA: 0x000550A0 File Offset: 0x000532A0
			// (set) Token: 0x06001603 RID: 5635 RVA: 0x0000C4A5 File Offset: 0x0000A6A5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x06001604 RID: 5636 RVA: 0x000550D0 File Offset: 0x000532D0
			// (set) Token: 0x06001605 RID: 5637 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
			public unsafe ResetPasswordCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResetPasswordCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPasswordCommand._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D55 RID: 3413
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D56 RID: 3414
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D57 RID: 3415
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D58 RID: 3416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D59 RID: 3417
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D5A RID: 3418
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D5B RID: 3419
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D5C RID: 3420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D5D RID: 3421
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
