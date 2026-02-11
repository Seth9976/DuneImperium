using System;
using dwd.core;
using dwd.core.commands;
using dwd.core.platform.auth;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.platformCore.authentication
{
	// Token: 0x02000013 RID: 19
	public class AuthenticatePlatformNoSession : Command
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00005DD0 File Offset: 0x00003FD0
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticatePlatformNoSession()
		{
			Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("platformCore.dll", "dwd.platformCore.authentication", "AuthenticatePlatformNoSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr);
			AuthenticatePlatformNoSession.NativeFieldInfoPtr_platformAuthURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr, "platformAuthURL");
			AuthenticatePlatformNoSession.NativeFieldInfoPtr_username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr, "username");
			AuthenticatePlatformNoSession.NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr, "password");
			AuthenticatePlatformNoSession.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr, "error");
			AuthenticatePlatformNoSession.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr, 100663445);
			AuthenticatePlatformNoSession.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr, 100663446);
			AuthenticatePlatformNoSession.NativeMethodInfoPtr_getPlatformToken_Private_IEnumerator_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr, 100663447);
			AuthenticatePlatformNoSession.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr, 100663448);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005EA0 File Offset: 0x000040A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1250863, RefRangeEnd = 1250865, XrefRangeStart = 1250854, XrefRangeEnd = 1250863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticatePlatformNoSession(string platformAuthURL, string username, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(platformAuthURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005F10 File Offset: 0x00004110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250865, XrefRangeEnd = 1250870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthenticatePlatformNoSession.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005F5C File Offset: 0x0000415C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250870, XrefRangeEnd = 1250876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator getPlatformToken(WWWForm wwwForm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wwwForm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession.NativeMethodInfoPtr_getPlatformToken_Private_IEnumerator_WWWForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005FAC File Offset: 0x000041AC
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002855 File Offset: 0x00000A55
		public AuthenticatePlatformNoSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005FE4 File Offset: 0x000041E4
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000285E File Offset: 0x00000A5E
		public unsafe string platformAuthURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession.NativeFieldInfoPtr_platformAuthURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession.NativeFieldInfoPtr_platformAuthURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000600C File Offset: 0x0000420C
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000287D File Offset: 0x00000A7D
		public unsafe string username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession.NativeFieldInfoPtr_username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession.NativeFieldInfoPtr_username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00006034 File Offset: 0x00004234
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000289C File Offset: 0x00000A9C
		public unsafe string password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession.NativeFieldInfoPtr_password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession.NativeFieldInfoPtr_password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000605C File Offset: 0x0000425C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000028BB File Offset: 0x00000ABB
		public ErrorInfo error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession.NativeFieldInfoPtr_error);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession.NativeFieldInfoPtr_error), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_platformAuthURL;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_username;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_password;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_getPlatformToken_Private_IEnumerator_WWWForm_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x02000023 RID: 35
		[ObfuscatedName("dwd.platformCore.authentication.AuthenticatePlatformNoSession+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x060001D5 RID: 469 RVA: 0x000089B0 File Offset: 0x00006BB0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr);
				AuthenticatePlatformNoSession._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr, "<>1__state");
				AuthenticatePlatformNoSession._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr, "<>2__current");
				AuthenticatePlatformNoSession._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr, "<>4__this");
				AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr, 100663449);
				AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr, 100663450);
				AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr, 100663451);
				AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr, 100663452);
				AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr, 100663453);
				AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr, 100663454);
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x00008A90 File Offset: 0x00006C90
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticatePlatformNoSession._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x00008AD8 File Offset: 0x00006CD8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00008B0C File Offset: 0x00006D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250783, XrefRangeEnd = 1250817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060001D9 RID: 473 RVA: 0x00008B48 File Offset: 0x00006D48
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001DA RID: 474 RVA: 0x00008B88 File Offset: 0x00006D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250817, XrefRangeEnd = 1250822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060001DB RID: 475 RVA: 0x00008BBC File Offset: 0x00006DBC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001DC RID: 476 RVA: 0x0000308C File Offset: 0x0000128C
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060001DD RID: 477 RVA: 0x00008BFC File Offset: 0x00006DFC
			// (set) Token: 0x060001DE RID: 478 RVA: 0x00003095 File Offset: 0x00001295
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060001DF RID: 479 RVA: 0x00008C24 File Offset: 0x00006E24
			// (set) Token: 0x060001E0 RID: 480 RVA: 0x000030B0 File Offset: 0x000012B0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060001E1 RID: 481 RVA: 0x00008C54 File Offset: 0x00006E54
			// (set) Token: 0x060001E2 RID: 482 RVA: 0x000030CF File Offset: 0x000012CF
			public unsafe AuthenticatePlatformNoSession __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthenticatePlatformNoSession>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000115 RID: 277
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000116 RID: 278
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000117 RID: 279
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000118 RID: 280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000119 RID: 281
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400011A RID: 282
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400011B RID: 283
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400011C RID: 284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400011D RID: 285
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000024 RID: 36
		[ObfuscatedName("dwd.platformCore.authentication.AuthenticatePlatformNoSession+<getPlatformToken>d__6")]
		public sealed class _getPlatformToken_d__6 : Object
		{
			// Token: 0x060001E3 RID: 483 RVA: 0x00008C84 File Offset: 0x00006E84
			// Note: this type is marked as 'beforefieldinit'.
			static _getPlatformToken_d__6()
			{
				Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthenticatePlatformNoSession>.NativeClassPtr, "<getPlatformToken>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr);
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, "<>1__state");
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, "<>2__current");
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, "<>4__this");
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr_wwwForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, "wwwForm");
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr__token_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, "<token>5__2");
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, 100663455);
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, 100663456);
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, 100663457);
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, 100663458);
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, 100663459);
				AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr, 100663460);
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x00008D8C File Offset: 0x00006F8C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _getPlatformToken_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticatePlatformNoSession._getPlatformToken_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x00008DD4 File Offset: 0x00006FD4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x00008E08 File Offset: 0x00007008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250822, XrefRangeEnd = 1250849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060001E7 RID: 487 RVA: 0x00008E44 File Offset: 0x00007044
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x00008E84 File Offset: 0x00007084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250849, XrefRangeEnd = 1250854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060001E9 RID: 489 RVA: 0x00008EB8 File Offset: 0x000070B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001EA RID: 490 RVA: 0x000030EE File Offset: 0x000012EE
			public _getPlatformToken_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060001EB RID: 491 RVA: 0x00008EF8 File Offset: 0x000070F8
			// (set) Token: 0x060001EC RID: 492 RVA: 0x000030F7 File Offset: 0x000012F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060001ED RID: 493 RVA: 0x00008F20 File Offset: 0x00007120
			// (set) Token: 0x060001EE RID: 494 RVA: 0x00003112 File Offset: 0x00001312
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060001EF RID: 495 RVA: 0x00008F50 File Offset: 0x00007150
			// (set) Token: 0x060001F0 RID: 496 RVA: 0x00003131 File Offset: 0x00001331
			public unsafe AuthenticatePlatformNoSession __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthenticatePlatformNoSession>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060001F1 RID: 497 RVA: 0x00008F80 File Offset: 0x00007180
			// (set) Token: 0x060001F2 RID: 498 RVA: 0x00003150 File Offset: 0x00001350
			public unsafe WWWForm wwwForm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr_wwwForm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWWForm>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr_wwwForm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060001F3 RID: 499 RVA: 0x00008FB0 File Offset: 0x000071B0
			// (set) Token: 0x060001F4 RID: 500 RVA: 0x0000316F File Offset: 0x0000136F
			public unsafe GetPlatformToken _token_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr__token_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetPlatformToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatePlatformNoSession._getPlatformToken_d__6.NativeFieldInfoPtr__token_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400011E RID: 286
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400011F RID: 287
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000120 RID: 288
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000121 RID: 289
			private static readonly IntPtr NativeFieldInfoPtr_wwwForm;

			// Token: 0x04000122 RID: 290
			private static readonly IntPtr NativeFieldInfoPtr__token_5__2;

			// Token: 0x04000123 RID: 291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000124 RID: 292
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000125 RID: 293
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000126 RID: 294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000127 RID: 295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000128 RID: 296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
