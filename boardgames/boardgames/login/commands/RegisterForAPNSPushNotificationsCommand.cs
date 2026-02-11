using System;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.login.commands
{
	// Token: 0x02000132 RID: 306
	public class RegisterForAPNSPushNotificationsCommand : Command
	{
		// Token: 0x06001010 RID: 4112 RVA: 0x00042530 File Offset: 0x00040730
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterForAPNSPushNotificationsCommand()
		{
			Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.login.commands", "RegisterForAPNSPushNotificationsCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr);
			RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr, "status");
			RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_NotificationURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr, "NotificationURL");
			RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_PlatformToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr, "PlatformToken");
			RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr, "Client");
			RegisterForAPNSPushNotificationsCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr, 100665609);
			RegisterForAPNSPushNotificationsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr, 100665610);
			RegisterForAPNSPushNotificationsCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr, 100665611);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x000425EC File Offset: 0x000407EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998552, XrefRangeEnd = 998561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterForAPNSPushNotificationsCommand(string notificationUrl, string platformToken, string client)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(notificationUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(platformToken);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForAPNSPushNotificationsCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0004265C File Offset: 0x0004085C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998561, XrefRangeEnd = 998565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterForAPNSPushNotificationsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000426A8 File Offset: 0x000408A8
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForAPNSPushNotificationsCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00009700 File Offset: 0x00007900
		public RegisterForAPNSPushNotificationsCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x000426E0 File Offset: 0x000408E0
		// (set) Token: 0x06001016 RID: 4118 RVA: 0x00009709 File Offset: 0x00007909
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x00042710 File Offset: 0x00040910
		// (set) Token: 0x06001018 RID: 4120 RVA: 0x00009737 File Offset: 0x00007937
		public unsafe string NotificationURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_NotificationURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_NotificationURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x00042738 File Offset: 0x00040938
		// (set) Token: 0x0600101A RID: 4122 RVA: 0x00009756 File Offset: 0x00007956
		public unsafe string PlatformToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_PlatformToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_PlatformToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x00042760 File Offset: 0x00040960
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x00009775 File Offset: 0x00007975
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeFieldInfoPtr_NotificationURL;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeFieldInfoPtr_PlatformToken;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x02000268 RID: 616
		[ObfuscatedName("boardgames.login.commands.RegisterForAPNSPushNotificationsCommand+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06001C3E RID: 7230 RVA: 0x00068290 File Offset: 0x00066490
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr);
				RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr, "<>1__state");
				RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr, "<>2__current");
				RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665612);
				RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665613);
				RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665614);
				RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665615);
				RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665616);
				RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665617);
			}

			// Token: 0x06001C3F RID: 7231 RVA: 0x0006835C File Offset: 0x0006655C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterForAPNSPushNotificationsCommand._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C40 RID: 7232 RVA: 0x000683A4 File Offset: 0x000665A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C41 RID: 7233 RVA: 0x000683D8 File Offset: 0x000665D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998541, XrefRangeEnd = 998547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700085C RID: 2140
			// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00068414 File Offset: 0x00066614
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C43 RID: 7235 RVA: 0x00068454 File Offset: 0x00066654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998547, XrefRangeEnd = 998552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00068488 File Offset: 0x00066688
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C45 RID: 7237 RVA: 0x0000F3F2 File Offset: 0x0000D5F2
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700085A RID: 2138
			// (get) Token: 0x06001C46 RID: 7238 RVA: 0x000684C8 File Offset: 0x000666C8
			// (set) Token: 0x06001C47 RID: 7239 RVA: 0x0000F3FB File Offset: 0x0000D5FB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700085B RID: 2139
			// (get) Token: 0x06001C48 RID: 7240 RVA: 0x000684F0 File Offset: 0x000666F0
			// (set) Token: 0x06001C49 RID: 7241 RVA: 0x0000F416 File Offset: 0x0000D616
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForAPNSPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400112B RID: 4395
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400112C RID: 4396
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400112D RID: 4397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400112E RID: 4398
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400112F RID: 4399
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001130 RID: 4400
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001131 RID: 4401
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001132 RID: 4402
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
