using System;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace iap.claims
{
	// Token: 0x02000007 RID: 7
	public class GetClaimStatusCommand : Command
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00003938 File Offset: 0x00001B38
		// Note: this type is marked as 'beforefieldinit'.
		static GetClaimStatusCommand()
		{
			Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Claims.dll", "iap.claims", "GetClaimStatusCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr);
			GetClaimStatusCommand.NativeFieldInfoPtr_claimId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "claimId");
			GetClaimStatusCommand.NativeFieldInfoPtr_commerceURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "commerceURL");
			GetClaimStatusCommand.NativeFieldInfoPtr_onProductFulfill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "onProductFulfill");
			GetClaimStatusCommand.NativeFieldInfoPtr_onProductFulfillFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "onProductFulfillFailure");
			GetClaimStatusCommand.NativeFieldInfoPtr_authTokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "authTokenType");
			GetClaimStatusCommand.NativeFieldInfoPtr_authToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "authToken");
			GetClaimStatusCommand.NativeFieldInfoPtr_StatusCheckInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "StatusCheckInterval");
			GetClaimStatusCommand.NativeFieldInfoPtr_NotCreatedRetryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "NotCreatedRetryTime");
			GetClaimStatusCommand.NativeFieldInfoPtr_MaxTries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "MaxTries");
			GetClaimStatusCommand.NativeFieldInfoPtr_Max404Retries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "Max404Retries");
			GetClaimStatusCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Action_1_ClaimResponse_Action_1_ClaimResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, 100663330);
			GetClaimStatusCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, 100663331);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003A58 File Offset: 0x00001C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268005, XrefRangeEnd = 1268012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetClaimStatusCommand(string claimId, string commerceURL, string authToken, string authTokenType, Action<ClaimResponse> onProductFulfill, Action<ClaimResponse> onProductFulfillFailure)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(claimId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(commerceURL);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authToken);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authTokenType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onProductFulfill);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onProductFulfillFailure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetClaimStatusCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Action_1_ClaimResponse_Action_1_ClaimResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003B00 File Offset: 0x00001D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268012, XrefRangeEnd = 1268017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetClaimStatusCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000022C8 File Offset: 0x000004C8
		public GetClaimStatusCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003B4C File Offset: 0x00001D4C
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000022D1 File Offset: 0x000004D1
		public unsafe string claimId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_claimId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_claimId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003B74 File Offset: 0x00001D74
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000022F0 File Offset: 0x000004F0
		public unsafe string commerceURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_commerceURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_commerceURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003B9C File Offset: 0x00001D9C
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000230F File Offset: 0x0000050F
		public unsafe Action<ClaimResponse> onProductFulfill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_onProductFulfill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClaimResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_onProductFulfill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003BCC File Offset: 0x00001DCC
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000232E File Offset: 0x0000052E
		public unsafe Action<ClaimResponse> onProductFulfillFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_onProductFulfillFailure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClaimResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_onProductFulfillFailure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003BFC File Offset: 0x00001DFC
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000234D File Offset: 0x0000054D
		public unsafe string authTokenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_authTokenType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_authTokenType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003C24 File Offset: 0x00001E24
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000236C File Offset: 0x0000056C
		public unsafe string authToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_authToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand.NativeFieldInfoPtr_authToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00003C4C File Offset: 0x00001E4C
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000238B File Offset: 0x0000058B
		public unsafe static float StatusCheckInterval
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(GetClaimStatusCommand.NativeFieldInfoPtr_StatusCheckInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetClaimStatusCommand.NativeFieldInfoPtr_StatusCheckInterval, (void*)(&value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003C68 File Offset: 0x00001E68
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002399 File Offset: 0x00000599
		public unsafe static float NotCreatedRetryTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(GetClaimStatusCommand.NativeFieldInfoPtr_NotCreatedRetryTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetClaimStatusCommand.NativeFieldInfoPtr_NotCreatedRetryTime, (void*)(&value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003C84 File Offset: 0x00001E84
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000023A7 File Offset: 0x000005A7
		public unsafe static int MaxTries
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetClaimStatusCommand.NativeFieldInfoPtr_MaxTries, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetClaimStatusCommand.NativeFieldInfoPtr_MaxTries, (void*)(&value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00003CA0 File Offset: 0x00001EA0
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000023B5 File Offset: 0x000005B5
		public unsafe static int Max404Retries
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetClaimStatusCommand.NativeFieldInfoPtr_Max404Retries, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetClaimStatusCommand.NativeFieldInfoPtr_Max404Retries, (void*)(&value));
			}
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_claimId;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_commerceURL;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_onProductFulfill;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_onProductFulfillFailure;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_authTokenType;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_authToken;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_StatusCheckInterval;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_NotCreatedRetryTime;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_MaxTries;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_Max404Retries;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Action_1_ClaimResponse_Action_1_ClaimResponse_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000013 RID: 19
		[ObfuscatedName("iap.claims.GetClaimStatusCommand+<execute>d__11")]
		public sealed class _execute_d__11 : Object
		{
			// Token: 0x060000D8 RID: 216 RVA: 0x00004FCC File Offset: 0x000031CC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__11()
			{
				Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetClaimStatusCommand>.NativeClassPtr, "<execute>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr);
				GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, "<>1__state");
				GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, "<>2__current");
				GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, "<>4__this");
				GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__url_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, "<url>5__2");
				GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__headers_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, "<headers>5__3");
				GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__tries_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, "<tries>5__4");
				GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__notCreatedTries_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, "<notCreatedTries>5__5");
				GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__haveResult_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, "<haveResult>5__6");
				GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__request_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, "<request>5__7");
				GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, 100663332);
				GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, 100663333);
				GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, 100663334);
				GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, 100663335);
				GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, 100663336);
				GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr, 100663337);
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00005124 File Offset: 0x00003324
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetClaimStatusCommand._execute_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000DA RID: 218 RVA: 0x0000516C File Offset: 0x0000336C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000DB RID: 219 RVA: 0x000051A0 File Offset: 0x000033A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267937, XrefRangeEnd = 1268000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060000DC RID: 220 RVA: 0x000051DC File Offset: 0x000033DC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000DD RID: 221 RVA: 0x0000521C File Offset: 0x0000341C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268000, XrefRangeEnd = 1268005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060000DE RID: 222 RVA: 0x00005250 File Offset: 0x00003450
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetClaimStatusCommand._execute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060000DF RID: 223 RVA: 0x0000282A File Offset: 0x00000A2A
			public _execute_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005290 File Offset: 0x00003490
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002833 File Offset: 0x00000A33
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x000052B8 File Offset: 0x000034B8
			// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000284E File Offset: 0x00000A4E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x000052E8 File Offset: 0x000034E8
			// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000286D File Offset: 0x00000A6D
			public unsafe GetClaimStatusCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetClaimStatusCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005318 File Offset: 0x00003518
			// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000288C File Offset: 0x00000A8C
			public unsafe string _url_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__url_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__url_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005340 File Offset: 0x00003540
			// (set) Token: 0x060000E9 RID: 233 RVA: 0x000028AB File Offset: 0x00000AAB
			public unsafe Dictionary<string, string> _headers_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__headers_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__headers_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060000EA RID: 234 RVA: 0x00005370 File Offset: 0x00003570
			// (set) Token: 0x060000EB RID: 235 RVA: 0x000028CA File Offset: 0x00000ACA
			public unsafe int _tries_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__tries_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__tries_5__4)) = value;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060000EC RID: 236 RVA: 0x00005398 File Offset: 0x00003598
			// (set) Token: 0x060000ED RID: 237 RVA: 0x000028E5 File Offset: 0x00000AE5
			public unsafe int _notCreatedTries_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__notCreatedTries_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__notCreatedTries_5__5)) = value;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060000EE RID: 238 RVA: 0x000053C0 File Offset: 0x000035C0
			// (set) Token: 0x060000EF RID: 239 RVA: 0x00002900 File Offset: 0x00000B00
			public unsafe bool _haveResult_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__haveResult_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__haveResult_5__6)) = value;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x000053E8 File Offset: 0x000035E8
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000291B File Offset: 0x00000B1B
			public unsafe DwdWebRequestCommand _request_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__request_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetClaimStatusCommand._execute_d__11.NativeFieldInfoPtr__request_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000073 RID: 115
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000074 RID: 116
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000075 RID: 117
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000076 RID: 118
			private static readonly IntPtr NativeFieldInfoPtr__url_5__2;

			// Token: 0x04000077 RID: 119
			private static readonly IntPtr NativeFieldInfoPtr__headers_5__3;

			// Token: 0x04000078 RID: 120
			private static readonly IntPtr NativeFieldInfoPtr__tries_5__4;

			// Token: 0x04000079 RID: 121
			private static readonly IntPtr NativeFieldInfoPtr__notCreatedTries_5__5;

			// Token: 0x0400007A RID: 122
			private static readonly IntPtr NativeFieldInfoPtr__haveResult_5__6;

			// Token: 0x0400007B RID: 123
			private static readonly IntPtr NativeFieldInfoPtr__request_5__7;

			// Token: 0x0400007C RID: 124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400007D RID: 125
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400007E RID: 126
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400007F RID: 127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000080 RID: 128
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000081 RID: 129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
