using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Threading;

namespace Google.Apis.Http
{
	// Token: 0x02000031 RID: 49
	public class HandleExceptionArgs : Object
	{
		// Token: 0x06000229 RID: 553 RVA: 0x0000C068 File Offset: 0x0000A268
		// Note: this type is marked as 'beforefieldinit'.
		static HandleExceptionArgs()
		{
			Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "HandleExceptionArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr);
			HandleExceptionArgs.NativeFieldInfoPtr__Request_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, "<Request>k__BackingField");
			HandleExceptionArgs.NativeFieldInfoPtr__Exception_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, "<Exception>k__BackingField");
			HandleExceptionArgs.NativeFieldInfoPtr__TotalTries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, "<TotalTries>k__BackingField");
			HandleExceptionArgs.NativeFieldInfoPtr__CurrentFailedTry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, "<CurrentFailedTry>k__BackingField");
			HandleExceptionArgs.NativeFieldInfoPtr__CancellationToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, "<CancellationToken>k__BackingField");
			HandleExceptionArgs.NativeMethodInfoPtr_get_Request_Public_get_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663631);
			HandleExceptionArgs.NativeMethodInfoPtr_set_Request_Public_set_Void_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663632);
			HandleExceptionArgs.NativeMethodInfoPtr_get_Exception_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663633);
			HandleExceptionArgs.NativeMethodInfoPtr_set_Exception_Public_set_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663634);
			HandleExceptionArgs.NativeMethodInfoPtr_get_TotalTries_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663635);
			HandleExceptionArgs.NativeMethodInfoPtr_set_TotalTries_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663636);
			HandleExceptionArgs.NativeMethodInfoPtr_get_CurrentFailedTry_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663637);
			HandleExceptionArgs.NativeMethodInfoPtr_set_CurrentFailedTry_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663638);
			HandleExceptionArgs.NativeMethodInfoPtr_get_SupportsRetry_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663639);
			HandleExceptionArgs.NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663640);
			HandleExceptionArgs.NativeMethodInfoPtr_set_CancellationToken_Public_set_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663641);
			HandleExceptionArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr, 100663642);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000C1EC File Offset: 0x0000A3EC
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0000C22C File Offset: 0x0000A42C
		public unsafe HttpRequestMessage Request
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_get_Request_Public_get_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_set_Request_Public_set_Void_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000C270 File Offset: 0x0000A470
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		public unsafe Exception Exception
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_get_Exception_Public_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_set_Exception_Public_set_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000C2F4 File Offset: 0x0000A4F4
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0000C330 File Offset: 0x0000A530
		public unsafe int TotalTries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_get_TotalTries_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_set_TotalTries_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000C370 File Offset: 0x0000A570
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0000C3AC File Offset: 0x0000A5AC
		public unsafe int CurrentFailedTry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_get_CurrentFailedTry_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_set_CurrentFailedTry_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		public unsafe bool SupportsRetry
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1212430, RefRangeEnd = 1212432, XrefRangeStart = 1212430, XrefRangeEnd = 1212430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_get_SupportsRetry_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000C428 File Offset: 0x0000A628
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0000C460 File Offset: 0x0000A660
		public unsafe CancellationToken CancellationToken
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212432, XrefRangeEnd = 1212433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr_set_CancellationToken_Public_set_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandleExceptionArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleExceptionArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleExceptionArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002D9E File Offset: 0x00000F9E
		public HandleExceptionArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002DA7 File Offset: 0x00000FA7
		public unsafe HttpRequestMessage _Request_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleExceptionArgs.NativeFieldInfoPtr__Request_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleExceptionArgs.NativeFieldInfoPtr__Request_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000C514 File Offset: 0x0000A714
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002DC6 File Offset: 0x00000FC6
		public unsafe Exception _Exception_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleExceptionArgs.NativeFieldInfoPtr__Exception_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleExceptionArgs.NativeFieldInfoPtr__Exception_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000C544 File Offset: 0x0000A744
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002DE5 File Offset: 0x00000FE5
		public unsafe int _TotalTries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleExceptionArgs.NativeFieldInfoPtr__TotalTries_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleExceptionArgs.NativeFieldInfoPtr__TotalTries_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000C56C File Offset: 0x0000A76C
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00002E00 File Offset: 0x00001000
		public unsafe int _CurrentFailedTry_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleExceptionArgs.NativeFieldInfoPtr__CurrentFailedTry_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleExceptionArgs.NativeFieldInfoPtr__CurrentFailedTry_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000C594 File Offset: 0x0000A794
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002E1B File Offset: 0x0000101B
		public CancellationToken _CancellationToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleExceptionArgs.NativeFieldInfoPtr__CancellationToken_k__BackingField);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleExceptionArgs.NativeFieldInfoPtr__CancellationToken_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr__Request_k__BackingField;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr__Exception_k__BackingField;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr__TotalTries_k__BackingField;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr__CurrentFailedTry_k__BackingField;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr__CancellationToken_k__BackingField;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Public_get_HttpRequestMessage_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_set_Request_Public_set_Void_HttpRequestMessage_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_get_Exception_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_set_Exception_Public_set_Void_Exception_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalTries_Public_get_Int32_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_set_TotalTries_Public_set_Void_Int32_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentFailedTry_Public_get_Int32_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentFailedTry_Public_set_Void_Int32_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsRetry_Public_get_Boolean_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_set_CancellationToken_Public_set_Void_CancellationToken_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
