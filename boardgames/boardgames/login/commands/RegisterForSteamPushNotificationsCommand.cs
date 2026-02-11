using System;
using dwd.core;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace boardgames.login.commands
{
	// Token: 0x02000133 RID: 307
	public class RegisterForSteamPushNotificationsCommand : Command
	{
		// Token: 0x0600101D RID: 4125 RVA: 0x00042788 File Offset: 0x00040988
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterForSteamPushNotificationsCommand()
		{
			Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.login.commands", "RegisterForSteamPushNotificationsCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr);
			RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_NotificationURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr, "NotificationURL");
			RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_PlatformToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr, "PlatformToken");
			RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr, "Client");
			RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr, "status");
			RegisterForSteamPushNotificationsCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr, 100665618);
			RegisterForSteamPushNotificationsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr, 100665619);
			RegisterForSteamPushNotificationsCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr, 100665620);
			RegisterForSteamPushNotificationsCommand.NativeMethodInfoPtr__execute_b__5_0_Private_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr, 100665621);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00042858 File Offset: 0x00040A58
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 998618, RefRangeEnd = 998746, XrefRangeStart = 998614, XrefRangeEnd = 998618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterForSteamPushNotificationsCommand(string notificationURL, string platformToken, string client)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(notificationURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(platformToken);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForSteamPushNotificationsCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000428C8 File Offset: 0x00040AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998746, XrefRangeEnd = 998751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterForSteamPushNotificationsCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00042914 File Offset: 0x00040B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998751, XrefRangeEnd = 998755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForSteamPushNotificationsCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0004294C File Offset: 0x00040B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998755, XrefRangeEnd = 998759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__5_0(UnityWebRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForSteamPushNotificationsCommand.NativeMethodInfoPtr__execute_b__5_0_Private_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00009794 File Offset: 0x00007994
		public RegisterForSteamPushNotificationsCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x00042990 File Offset: 0x00040B90
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x0000979D File Offset: 0x0000799D
		public unsafe string NotificationURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_NotificationURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_NotificationURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x000429B8 File Offset: 0x00040BB8
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x000097BC File Offset: 0x000079BC
		public unsafe string PlatformToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_PlatformToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_PlatformToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x000429E0 File Offset: 0x00040BE0
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x000097DB File Offset: 0x000079DB
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00042A08 File Offset: 0x00040C08
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x000097FA File Offset: 0x000079FA
		public Nullable<ErrorInfo> status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_status);
				return new Nullable<ErrorInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ErrorInfo>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ErrorInfo>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr_NotificationURL;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeFieldInfoPtr_PlatformToken;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_0_Private_Void_UnityWebRequest_0;

		// Token: 0x02000269 RID: 617
		[ObfuscatedName("boardgames.login.commands.RegisterForSteamPushNotificationsCommand+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06001C4A RID: 7242 RVA: 0x00068520 File Offset: 0x00066720
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr);
				RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr, "<>1__state");
				RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr, "<>2__current");
				RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr, "<>4__this");
				RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr__registerCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr, "<registerCommand>5__2");
				RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665622);
				RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665623);
				RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665624);
				RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665625);
				RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665626);
				RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr, 100665627);
			}

			// Token: 0x06001C4B RID: 7243 RVA: 0x00068614 File Offset: 0x00066814
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterForSteamPushNotificationsCommand._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C4C RID: 7244 RVA: 0x0006865C File Offset: 0x0006685C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C4D RID: 7245 RVA: 0x00068690 File Offset: 0x00066890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998565, XrefRangeEnd = 998609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x06001C4E RID: 7246 RVA: 0x000686CC File Offset: 0x000668CC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C4F RID: 7247 RVA: 0x0006870C File Offset: 0x0006690C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998609, XrefRangeEnd = 998614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x06001C50 RID: 7248 RVA: 0x00068740 File Offset: 0x00066940
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C51 RID: 7249 RVA: 0x0000F435 File Offset: 0x0000D635
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00068780 File Offset: 0x00066980
			// (set) Token: 0x06001C53 RID: 7251 RVA: 0x0000F43E File Offset: 0x0000D63E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x06001C54 RID: 7252 RVA: 0x000687A8 File Offset: 0x000669A8
			// (set) Token: 0x06001C55 RID: 7253 RVA: 0x0000F459 File Offset: 0x0000D659
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x06001C56 RID: 7254 RVA: 0x000687D8 File Offset: 0x000669D8
			// (set) Token: 0x06001C57 RID: 7255 RVA: 0x0000F478 File Offset: 0x0000D678
			public unsafe RegisterForSteamPushNotificationsCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterForSteamPushNotificationsCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00068808 File Offset: 0x00066A08
			// (set) Token: 0x06001C59 RID: 7257 RVA: 0x0000F497 File Offset: 0x0000D697
			public unsafe DwdWebRequestCommand _registerCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr__registerCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterForSteamPushNotificationsCommand._execute_d__5.NativeFieldInfoPtr__registerCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001133 RID: 4403
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001134 RID: 4404
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001135 RID: 4405
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001136 RID: 4406
			private static readonly IntPtr NativeFieldInfoPtr__registerCommand_5__2;

			// Token: 0x04001137 RID: 4407
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001138 RID: 4408
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001139 RID: 4409
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400113A RID: 4410
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400113B RID: 4411
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400113C RID: 4412
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
