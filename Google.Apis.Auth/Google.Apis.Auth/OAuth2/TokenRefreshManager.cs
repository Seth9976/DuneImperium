using System;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200001E RID: 30
	public sealed class TokenRefreshManager : Object
	{
		// Token: 0x0600018D RID: 397 RVA: 0x0000C50C File Offset: 0x0000A70C
		// Note: this type is marked as 'beforefieldinit'.
		static TokenRefreshManager()
		{
			Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "TokenRefreshManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr);
			TokenRefreshManager.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, "_lock");
			TokenRefreshManager.NativeFieldInfoPtr__clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, "_clock");
			TokenRefreshManager.NativeFieldInfoPtr__logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, "_logger");
			TokenRefreshManager.NativeFieldInfoPtr__refreshAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, "_refreshAction");
			TokenRefreshManager.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, "_token");
			TokenRefreshManager.NativeFieldInfoPtr__refreshTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, "_refreshTask");
			TokenRefreshManager.NativeFieldInfoPtr_RefreshTimeouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, "RefreshTimeouts");
			TokenRefreshManager.NativeMethodInfoPtr__ctor_Internal_Void_Func_2_CancellationToken_Task_1_Boolean_IClock_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, 100663689);
			TokenRefreshManager.NativeMethodInfoPtr_get_Token_Internal_get_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, 100663690);
			TokenRefreshManager.NativeMethodInfoPtr_set_Token_Internal_set_Void_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, 100663691);
			TokenRefreshManager.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Internal_Task_1_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, 100663692);
			TokenRefreshManager.NativeMethodInfoPtr_RefreshTokenAsync_Private_Task_1_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, 100663693);
			TokenRefreshManager.NativeMethodInfoPtr_ResultWithUnwrappedExceptions_Private_Static_T_Task_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, 100663694);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000C640 File Offset: 0x0000A840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1156106, RefRangeEnd = 1156108, XrefRangeStart = 1156097, XrefRangeEnd = 1156106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenRefreshManager(Func<CancellationToken, Task<bool>> refreshAction, IClock clock, ILogger logger)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(refreshAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clock);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager.NativeMethodInfoPtr__ctor_Internal_Void_Func_2_CancellationToken_Task_1_Boolean_IClock_ILogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		public unsafe TokenResponse Token
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1156112, RefRangeEnd = 1156125, XrefRangeStart = 1156108, XrefRangeEnd = 1156112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager.NativeMethodInfoPtr_get_Token_Internal_get_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TokenResponse>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1156130, RefRangeEnd = 1156137, XrefRangeStart = 1156125, XrefRangeEnd = 1156130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager.NativeMethodInfoPtr_set_Token_Internal_set_Void_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000C734 File Offset: 0x0000A934
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1156152, RefRangeEnd = 1156156, XrefRangeStart = 1156137, XrefRangeEnd = 1156152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<string> GetAccessTokenForRequestAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Internal_Task_1_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000C78C File Offset: 0x0000A98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156156, XrefRangeEnd = 1156170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TokenResponse> RefreshTokenAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager.NativeMethodInfoPtr_RefreshTokenAsync_Private_Task_1_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr3) : null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000C7CC File Offset: 0x0000A9CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1156180, RefRangeEnd = 1156181, XrefRangeStart = 1156170, XrefRangeEnd = 1156180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ResultWithUnwrappedExceptions<T>(Task<T> task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager.MethodInfoStoreGeneric_ResultWithUnwrappedExceptions_Private_Static_T_Task_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002AFA File Offset: 0x00000CFA
		public TokenRefreshManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000C80C File Offset: 0x0000AA0C
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002B03 File Offset: 0x00000D03
		public unsafe Object _lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000C83C File Offset: 0x0000AA3C
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002B22 File Offset: 0x00000D22
		public unsafe IClock _clock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__clock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__clock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000C86C File Offset: 0x0000AA6C
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002B41 File Offset: 0x00000D41
		public unsafe ILogger _logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000C89C File Offset: 0x0000AA9C
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002B60 File Offset: 0x00000D60
		public unsafe Func<CancellationToken, Task<bool>> _refreshAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__refreshAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CancellationToken, Task<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__refreshAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000C8CC File Offset: 0x0000AACC
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002B7F File Offset: 0x00000D7F
		public unsafe TokenResponse _token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__token);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__token), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002B9E File Offset: 0x00000D9E
		public unsafe Task<TokenResponse> _refreshTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__refreshTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager.NativeFieldInfoPtr__refreshTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000C92C File Offset: 0x0000AB2C
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002BBD File Offset: 0x00000DBD
		public unsafe static Il2CppStructArray<TimeSpan> RefreshTimeouts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TokenRefreshManager.NativeFieldInfoPtr_RefreshTimeouts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TimeSpan>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TokenRefreshManager.NativeFieldInfoPtr_RefreshTimeouts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr__clock;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr__logger;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr__refreshAction;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr__token;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr__refreshTask;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_RefreshTimeouts;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Func_2_CancellationToken_Task_1_Boolean_IClock_ILogger_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Internal_get_TokenResponse_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_set_Token_Internal_set_Void_TokenResponse_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Internal_Task_1_String_CancellationToken_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTokenAsync_Private_Task_1_TokenResponse_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_ResultWithUnwrappedExceptions_Private_Static_T_Task_1_T_0;

		// Token: 0x0200005C RID: 92
		[ObfuscatedName("Google.Apis.Auth.OAuth2.TokenRefreshManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060005B0 RID: 1456 RVA: 0x00019444 File Offset: 0x00017644
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TokenRefreshManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRefreshManager.__c>.NativeClassPtr);
				TokenRefreshManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager.__c>.NativeClassPtr, "<>9");
				TokenRefreshManager.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager.__c>.NativeClassPtr, "<>9__10_0");
				TokenRefreshManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager.__c>.NativeClassPtr, 100663697);
				TokenRefreshManager.__c.NativeMethodInfoPtr__GetAccessTokenForRequestAsync_b__10_0_Internal_TokenResponse_Task_1_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager.__c>.NativeClassPtr, 100663698);
			}

			// Token: 0x060005B1 RID: 1457 RVA: 0x000194C0 File Offset: 0x000176C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRefreshManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005B2 RID: 1458 RVA: 0x000194FC File Offset: 0x000176FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155941, XrefRangeEnd = 1155947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TokenResponse _GetAccessTokenForRequestAsync_b__10_0(Task<TokenResponse> task)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager.__c.NativeMethodInfoPtr__GetAccessTokenForRequestAsync_b__10_0_Internal_TokenResponse_Task_1_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TokenResponse>(intPtr3) : null;
				}
			}

			// Token: 0x060005B3 RID: 1459 RVA: 0x00005210 File Offset: 0x00003410
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700020F RID: 527
			// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001954C File Offset: 0x0001774C
			// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00005219 File Offset: 0x00003419
			public unsafe static TokenRefreshManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TokenRefreshManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenRefreshManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TokenRefreshManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000210 RID: 528
			// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00019574 File Offset: 0x00017774
			// (set) Token: 0x060005B7 RID: 1463 RVA: 0x0000522B File Offset: 0x0000342B
			public unsafe static Func<Task<TokenResponse>, TokenResponse> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TokenRefreshManager.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task<TokenResponse>, TokenResponse>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TokenRefreshManager.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400037B RID: 891
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400037C RID: 892
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400037D RID: 893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400037E RID: 894
			private static readonly IntPtr NativeMethodInfoPtr__GetAccessTokenForRequestAsync_b__10_0_Internal_TokenResponse_Task_1_TokenResponse_0;
		}

		// Token: 0x0200005D RID: 93
		[ObfuscatedName("Google.Apis.Auth.OAuth2.TokenRefreshManager+<GetAccessTokenForRequestAsync>d__10")]
		public sealed class _GetAccessTokenForRequestAsync_d__10 : ValueType
		{
			// Token: 0x060005B8 RID: 1464 RVA: 0x0001959C File Offset: 0x0001779C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAccessTokenForRequestAsync_d__10()
			{
				Il2CppClassPointerStore<TokenRefreshManager._GetAccessTokenForRequestAsync_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, "<GetAccessTokenForRequestAsync>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRefreshManager._GetAccessTokenForRequestAsync_d__10>.NativeClassPtr);
				TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._GetAccessTokenForRequestAsync_d__10>.NativeClassPtr, "<>1__state");
				TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._GetAccessTokenForRequestAsync_d__10>.NativeClassPtr, "<>t__builder");
				TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._GetAccessTokenForRequestAsync_d__10>.NativeClassPtr, "<>4__this");
				TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._GetAccessTokenForRequestAsync_d__10>.NativeClassPtr, "cancellationToken");
				TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._GetAccessTokenForRequestAsync_d__10>.NativeClassPtr, "<>u__1");
				TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager._GetAccessTokenForRequestAsync_d__10>.NativeClassPtr, 100663699);
				TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager._GetAccessTokenForRequestAsync_d__10>.NativeClassPtr, 100663700);
			}

			// Token: 0x060005B9 RID: 1465 RVA: 0x00019654 File Offset: 0x00017854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155947, XrefRangeEnd = 1156028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005BA RID: 1466 RVA: 0x0001968C File Offset: 0x0001788C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156028, XrefRangeEnd = 1156034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005BB RID: 1467 RVA: 0x0000523D File Offset: 0x0000343D
			public _GetAccessTokenForRequestAsync_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060005BC RID: 1468 RVA: 0x00005246 File Offset: 0x00003446
			public _GetAccessTokenForRequestAsync_d__10()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRefreshManager._GetAccessTokenForRequestAsync_d__10>.NativeClassPtr))
			{
			}

			// Token: 0x17000211 RID: 529
			// (get) Token: 0x060005BD RID: 1469 RVA: 0x000196D4 File Offset: 0x000178D4
			// (set) Token: 0x060005BE RID: 1470 RVA: 0x00005258 File Offset: 0x00003458
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000212 RID: 530
			// (get) Token: 0x060005BF RID: 1471 RVA: 0x000196FC File Offset: 0x000178FC
			// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00005273 File Offset: 0x00003473
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000213 RID: 531
			// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001972C File Offset: 0x0001792C
			// (set) Token: 0x060005C2 RID: 1474 RVA: 0x000052A1 File Offset: 0x000034A1
			public unsafe TokenRefreshManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenRefreshManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000214 RID: 532
			// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001975C File Offset: 0x0001795C
			// (set) Token: 0x060005C4 RID: 1476 RVA: 0x000052C0 File Offset: 0x000034C0
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000215 RID: 533
			// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001978C File Offset: 0x0001798C
			// (set) Token: 0x060005C6 RID: 1478 RVA: 0x000052EE File Offset: 0x000034EE
			public ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._GetAccessTokenForRequestAsync_d__10.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400037F RID: 895
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000380 RID: 896
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000381 RID: 897
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000382 RID: 898
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04000383 RID: 899
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000384 RID: 900
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000385 RID: 901
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200005E RID: 94
		[ObfuscatedName("Google.Apis.Auth.OAuth2.TokenRefreshManager+<RefreshTokenAsync>d__12")]
		public sealed class _RefreshTokenAsync_d__12 : ValueType
		{
			// Token: 0x060005C7 RID: 1479 RVA: 0x000197BC File Offset: 0x000179BC
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshTokenAsync_d__12()
			{
				Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr, "<RefreshTokenAsync>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr);
				TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr, "<>1__state");
				TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr, "<>t__builder");
				TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr, "<>4__this");
				TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr__errors_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr, "<errors>5__2");
				TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr, "<>7__wrap2");
				TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr, "<>7__wrap3");
				TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr__timeout_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr, "<timeout>5__5");
				TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr, "<>u__1");
				TokenRefreshManager._RefreshTokenAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr, 100663701);
				TokenRefreshManager._RefreshTokenAsync_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr, 100663702);
			}

			// Token: 0x060005C8 RID: 1480 RVA: 0x000198B0 File Offset: 0x00017AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156034, XrefRangeEnd = 1156091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager._RefreshTokenAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005C9 RID: 1481 RVA: 0x000198E8 File Offset: 0x00017AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156091, XrefRangeEnd = 1156097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRefreshManager._RefreshTokenAsync_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x0000531C File Offset: 0x0000351C
			public _RefreshTokenAsync_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x00005325 File Offset: 0x00003525
			public _RefreshTokenAsync_d__12()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRefreshManager._RefreshTokenAsync_d__12>.NativeClassPtr))
			{
			}

			// Token: 0x17000216 RID: 534
			// (get) Token: 0x060005CC RID: 1484 RVA: 0x00019930 File Offset: 0x00017B30
			// (set) Token: 0x060005CD RID: 1485 RVA: 0x00005337 File Offset: 0x00003537
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000217 RID: 535
			// (get) Token: 0x060005CE RID: 1486 RVA: 0x00019958 File Offset: 0x00017B58
			// (set) Token: 0x060005CF RID: 1487 RVA: 0x00005352 File Offset: 0x00003552
			public AsyncTaskMethodBuilder<TokenResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TokenResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000218 RID: 536
			// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00019988 File Offset: 0x00017B88
			// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00005380 File Offset: 0x00003580
			public unsafe TokenRefreshManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenRefreshManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000219 RID: 537
			// (get) Token: 0x060005D2 RID: 1490 RVA: 0x000199B8 File Offset: 0x00017BB8
			// (set) Token: 0x060005D3 RID: 1491 RVA: 0x0000539F File Offset: 0x0000359F
			public unsafe List<string> _errors_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr__errors_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr__errors_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700021A RID: 538
			// (get) Token: 0x060005D4 RID: 1492 RVA: 0x000199E8 File Offset: 0x00017BE8
			// (set) Token: 0x060005D5 RID: 1493 RVA: 0x000053BE File Offset: 0x000035BE
			public unsafe Il2CppStructArray<TimeSpan> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TimeSpan>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700021B RID: 539
			// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00019A18 File Offset: 0x00017C18
			// (set) Token: 0x060005D7 RID: 1495 RVA: 0x000053DD File Offset: 0x000035DD
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x1700021C RID: 540
			// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00019A40 File Offset: 0x00017C40
			// (set) Token: 0x060005D9 RID: 1497 RVA: 0x000053F8 File Offset: 0x000035F8
			public unsafe TimeSpan _timeout_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr__timeout_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr__timeout_5__5)) = value;
				}
			}

			// Token: 0x1700021D RID: 541
			// (get) Token: 0x060005DA RID: 1498 RVA: 0x00019A68 File Offset: 0x00017C68
			// (set) Token: 0x060005DB RID: 1499 RVA: 0x00005413 File Offset: 0x00003613
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRefreshManager._RefreshTokenAsync_d__12.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000386 RID: 902
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000387 RID: 903
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000388 RID: 904
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000389 RID: 905
			private static readonly IntPtr NativeFieldInfoPtr__errors_5__2;

			// Token: 0x0400038A RID: 906
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400038B RID: 907
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400038C RID: 908
			private static readonly IntPtr NativeFieldInfoPtr__timeout_5__5;

			// Token: 0x0400038D RID: 909
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400038E RID: 910
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400038F RID: 911
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200005F RID: 95
		private sealed class MethodInfoStoreGeneric_ResultWithUnwrappedExceptions_Private_Static_T_Task_1_T_0<T>
		{
			// Token: 0x04000390 RID: 912
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TokenRefreshManager.NativeMethodInfoPtr_ResultWithUnwrappedExceptions_Private_Static_T_Task_1_T_0, Il2CppClassPointerStore<TokenRefreshManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
