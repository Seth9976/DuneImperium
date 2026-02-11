using System;
using Google.Apis.Auth.OAuth2.Responses;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200000B RID: 11
	public class ComputeCredential : ServiceCredential
	{
		// Token: 0x0600005A RID: 90 RVA: 0x0000847C File Offset: 0x0000667C
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeCredential()
		{
			Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "ComputeCredential");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr);
			ComputeCredential.NativeFieldInfoPtr_MetadataServerUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, "MetadataServerUrl");
			ComputeCredential.NativeFieldInfoPtr_isRunningOnComputeEngineCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, "isRunningOnComputeEngineCached");
			ComputeCredential.NativeFieldInfoPtr_MetadataServerPingTimeoutInMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, "MetadataServerPingTimeoutInMilliseconds");
			ComputeCredential.NativeFieldInfoPtr_MetadataServerPingAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, "MetadataServerPingAttempts");
			ComputeCredential.NativeFieldInfoPtr_MetadataFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, "MetadataFlavor");
			ComputeCredential.NativeFieldInfoPtr_GoogleMetadataHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, "GoogleMetadataHeader");
			ComputeCredential.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, 100663427);
			ComputeCredential.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, 100663428);
			ComputeCredential.NativeMethodInfoPtr_RequestAccessTokenAsync_Public_Virtual_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, 100663429);
			ComputeCredential.NativeMethodInfoPtr_IsRunningOnComputeEngine_Public_Static_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, 100663430);
			ComputeCredential.NativeMethodInfoPtr_IsRunningOnComputeEngineNoCache_Private_Static_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, 100663431);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00008588 File Offset: 0x00006788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1153141, RefRangeEnd = 1153143, XrefRangeStart = 1153131, XrefRangeEnd = 1153141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeCredential()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000085C4 File Offset: 0x000067C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153143, XrefRangeEnd = 1153147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeCredential(ComputeCredential.Initializer initializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00008610 File Offset: 0x00006810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153147, XrefRangeEnd = 1153162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ComputeCredential.NativeMethodInfoPtr_RequestAccessTokenAsync_Public_Virtual_Task_1_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00008670 File Offset: 0x00006870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153162, XrefRangeEnd = 1153170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> IsRunningOnComputeEngine()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential.NativeMethodInfoPtr_IsRunningOnComputeEngine_Public_Static_Task_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000086A4 File Offset: 0x000068A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153170, XrefRangeEnd = 1153183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<bool> IsRunningOnComputeEngineNoCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential.NativeMethodInfoPtr_IsRunningOnComputeEngineNoCache_Private_Static_Task_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002307 File Offset: 0x00000507
		public ComputeCredential(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000086D8 File Offset: 0x000068D8
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002310 File Offset: 0x00000510
		public unsafe static string MetadataServerUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ComputeCredential.NativeFieldInfoPtr_MetadataServerUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputeCredential.NativeFieldInfoPtr_MetadataServerUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000086F8 File Offset: 0x000068F8
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002322 File Offset: 0x00000522
		public unsafe static Lazy<Task<bool>> isRunningOnComputeEngineCached
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ComputeCredential.NativeFieldInfoPtr_isRunningOnComputeEngineCached, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<Task<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputeCredential.NativeFieldInfoPtr_isRunningOnComputeEngineCached, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00008720 File Offset: 0x00006920
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002334 File Offset: 0x00000534
		public unsafe static int MetadataServerPingTimeoutInMilliseconds
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ComputeCredential.NativeFieldInfoPtr_MetadataServerPingTimeoutInMilliseconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputeCredential.NativeFieldInfoPtr_MetadataServerPingTimeoutInMilliseconds, (void*)(&value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000873C File Offset: 0x0000693C
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002342 File Offset: 0x00000542
		public unsafe static int MetadataServerPingAttempts
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ComputeCredential.NativeFieldInfoPtr_MetadataServerPingAttempts, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputeCredential.NativeFieldInfoPtr_MetadataServerPingAttempts, (void*)(&value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00008758 File Offset: 0x00006958
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002350 File Offset: 0x00000550
		public unsafe static string MetadataFlavor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ComputeCredential.NativeFieldInfoPtr_MetadataFlavor, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputeCredential.NativeFieldInfoPtr_MetadataFlavor, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00008778 File Offset: 0x00006978
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002362 File Offset: 0x00000562
		public unsafe static string GoogleMetadataHeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ComputeCredential.NativeFieldInfoPtr_GoogleMetadataHeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputeCredential.NativeFieldInfoPtr_GoogleMetadataHeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_MetadataServerUrl;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_isRunningOnComputeEngineCached;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_MetadataServerPingTimeoutInMilliseconds;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_MetadataServerPingAttempts;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_MetadataFlavor;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_GoogleMetadataHeader;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Initializer_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_RequestAccessTokenAsync_Public_Virtual_Task_1_Boolean_CancellationToken_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_IsRunningOnComputeEngine_Public_Static_Task_1_Boolean_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_IsRunningOnComputeEngineNoCache_Private_Static_Task_1_Boolean_0;

		// Token: 0x0200003F RID: 63
		public new class Initializer : ServiceCredential.Initializer
		{
			// Token: 0x06000406 RID: 1030 RVA: 0x00014D4C File Offset: 0x00012F4C
			// Note: this type is marked as 'beforefieldinit'.
			static Initializer()
			{
				Il2CppClassPointerStore<ComputeCredential.Initializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, "Initializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeCredential.Initializer>.NativeClassPtr);
				ComputeCredential.Initializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential.Initializer>.NativeClassPtr, 100663433);
				ComputeCredential.Initializer.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential.Initializer>.NativeClassPtr, 100663434);
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x00014DA0 File Offset: 0x00012FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152915, XrefRangeEnd = 1152918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeCredential.Initializer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential.Initializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x00014DDC File Offset: 0x00012FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152918, XrefRangeEnd = 1152919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer(string tokenUrl)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeCredential.Initializer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenUrl);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential.Initializer.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x00003E92 File Offset: 0x00002092
			public Initializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400029A RID: 666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400029B RID: 667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
		}

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("Google.Apis.Auth.OAuth2.ComputeCredential+<RequestAccessTokenAsync>d__9")]
		public sealed class _RequestAccessTokenAsync_d__9 : ValueType
		{
			// Token: 0x0600040A RID: 1034 RVA: 0x00014E28 File Offset: 0x00013028
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestAccessTokenAsync_d__9()
			{
				Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, "<RequestAccessTokenAsync>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr);
				ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr, "<>1__state");
				ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr, "<>t__builder");
				ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr, "<>4__this");
				ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr, "taskCancellationToken");
				ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr, "<>u__1");
				ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr, "<>u__2");
				ComputeCredential._RequestAccessTokenAsync_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr, 100663435);
				ComputeCredential._RequestAccessTokenAsync_d__9.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr, 100663436);
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x00014EF4 File Offset: 0x000130F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152919, XrefRangeEnd = 1152987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential._RequestAccessTokenAsync_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x00014F2C File Offset: 0x0001312C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152987, XrefRangeEnd = 1152993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential._RequestAccessTokenAsync_d__9.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x00003E9B File Offset: 0x0000209B
			public _RequestAccessTokenAsync_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x00003EA4 File Offset: 0x000020A4
			public _RequestAccessTokenAsync_d__9()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeCredential._RequestAccessTokenAsync_d__9>.NativeClassPtr))
			{
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x0600040F RID: 1039 RVA: 0x00014F74 File Offset: 0x00013174
			// (set) Token: 0x06000410 RID: 1040 RVA: 0x00003EB6 File Offset: 0x000020B6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x06000411 RID: 1041 RVA: 0x00014F9C File Offset: 0x0001319C
			// (set) Token: 0x06000412 RID: 1042 RVA: 0x00003ED1 File Offset: 0x000020D1
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x06000413 RID: 1043 RVA: 0x00014FCC File Offset: 0x000131CC
			// (set) Token: 0x06000414 RID: 1044 RVA: 0x00003EFF File Offset: 0x000020FF
			public unsafe ComputeCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x06000415 RID: 1045 RVA: 0x00014FFC File Offset: 0x000131FC
			// (set) Token: 0x06000416 RID: 1046 RVA: 0x00003F1E File Offset: 0x0000211E
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x06000417 RID: 1047 RVA: 0x0001502C File Offset: 0x0001322C
			// (set) Token: 0x06000418 RID: 1048 RVA: 0x00003F4C File Offset: 0x0000214C
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x06000419 RID: 1049 RVA: 0x0001505C File Offset: 0x0001325C
			// (set) Token: 0x0600041A RID: 1050 RVA: 0x00003F7A File Offset: 0x0000217A
			public ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._RequestAccessTokenAsync_d__9.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400029C RID: 668
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400029D RID: 669
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400029E RID: 670
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400029F RID: 671
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x040002A0 RID: 672
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002A1 RID: 673
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040002A2 RID: 674
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002A3 RID: 675
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000041 RID: 65
		[ObfuscatedName("Google.Apis.Auth.OAuth2.ComputeCredential+<IsRunningOnComputeEngineNoCache>d__11")]
		public sealed class _IsRunningOnComputeEngineNoCache_d__11 : ValueType
		{
			// Token: 0x0600041B RID: 1051 RVA: 0x0001508C File Offset: 0x0001328C
			// Note: this type is marked as 'beforefieldinit'.
			static _IsRunningOnComputeEngineNoCache_d__11()
			{
				Il2CppClassPointerStore<ComputeCredential._IsRunningOnComputeEngineNoCache_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, "<IsRunningOnComputeEngineNoCache>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeCredential._IsRunningOnComputeEngineNoCache_d__11>.NativeClassPtr);
				ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._IsRunningOnComputeEngineNoCache_d__11>.NativeClassPtr, "<>1__state");
				ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._IsRunningOnComputeEngineNoCache_d__11>.NativeClassPtr, "<>t__builder");
				ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr__httpClient_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._IsRunningOnComputeEngineNoCache_d__11>.NativeClassPtr, "<httpClient>5__2");
				ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._IsRunningOnComputeEngineNoCache_d__11>.NativeClassPtr, "<i>5__3");
				ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential._IsRunningOnComputeEngineNoCache_d__11>.NativeClassPtr, "<>u__1");
				ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential._IsRunningOnComputeEngineNoCache_d__11>.NativeClassPtr, 100663437);
				ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential._IsRunningOnComputeEngineNoCache_d__11>.NativeClassPtr, 100663438);
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x00015144 File Offset: 0x00013344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152993, XrefRangeEnd = 1153109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x0001517C File Offset: 0x0001337C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153109, XrefRangeEnd = 1153115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x00003FA8 File Offset: 0x000021A8
			public _IsRunningOnComputeEngineNoCache_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x00003FB1 File Offset: 0x000021B1
			public _IsRunningOnComputeEngineNoCache_d__11()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeCredential._IsRunningOnComputeEngineNoCache_d__11>.NativeClassPtr))
			{
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x06000420 RID: 1056 RVA: 0x000151C4 File Offset: 0x000133C4
			// (set) Token: 0x06000421 RID: 1057 RVA: 0x00003FC3 File Offset: 0x000021C3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x06000422 RID: 1058 RVA: 0x000151EC File Offset: 0x000133EC
			// (set) Token: 0x06000423 RID: 1059 RVA: 0x00003FDE File Offset: 0x000021DE
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001521C File Offset: 0x0001341C
			// (set) Token: 0x06000425 RID: 1061 RVA: 0x0000400C File Offset: 0x0000220C
			public unsafe HttpClient _httpClient_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr__httpClient_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr__httpClient_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001524C File Offset: 0x0001344C
			// (set) Token: 0x06000427 RID: 1063 RVA: 0x0000402B File Offset: 0x0000222B
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06000428 RID: 1064 RVA: 0x00015274 File Offset: 0x00013474
			// (set) Token: 0x06000429 RID: 1065 RVA: 0x00004046 File Offset: 0x00002246
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeCredential._IsRunningOnComputeEngineNoCache_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002A4 RID: 676
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002A5 RID: 677
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002A6 RID: 678
			private static readonly IntPtr NativeFieldInfoPtr__httpClient_5__2;

			// Token: 0x040002A7 RID: 679
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040002A8 RID: 680
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002A9 RID: 681
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002AA RID: 682
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000042 RID: 66
		[ObfuscatedName("Google.Apis.Auth.OAuth2.ComputeCredential+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600042A RID: 1066 RVA: 0x000152A4 File Offset: 0x000134A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ComputeCredential.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComputeCredential>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeCredential.__c>.NativeClassPtr);
				ComputeCredential.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeCredential.__c>.NativeClassPtr, "<>9");
				ComputeCredential.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential.__c>.NativeClassPtr, 100663440);
				ComputeCredential.__c.NativeMethodInfoPtr___cctor_b__12_0_Internal_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeCredential.__c>.NativeClassPtr, 100663441);
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x0001530C File Offset: 0x0001350C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeCredential.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x00015348 File Offset: 0x00013548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153115, XrefRangeEnd = 1153131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<bool> __cctor_b__12_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeCredential.__c.NativeMethodInfoPtr___cctor_b__12_0_Internal_Task_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x00004074 File Offset: 0x00002274
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x0600042E RID: 1070 RVA: 0x00015388 File Offset: 0x00013588
			// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000407D File Offset: 0x0000227D
			public unsafe static ComputeCredential.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputeCredential.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeCredential.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputeCredential.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002AB RID: 683
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040002AC RID: 684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002AD RID: 685
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__12_0_Internal_Task_1_Boolean_0;
		}
	}
}
