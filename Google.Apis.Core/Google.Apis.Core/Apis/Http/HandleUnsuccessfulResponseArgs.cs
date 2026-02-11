using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Threading;

namespace Google.Apis.Http
{
	// Token: 0x02000034 RID: 52
	public class HandleUnsuccessfulResponseArgs : Object
	{
		// Token: 0x06000247 RID: 583 RVA: 0x0000C694 File Offset: 0x0000A894
		// Note: this type is marked as 'beforefieldinit'.
		static HandleUnsuccessfulResponseArgs()
		{
			Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "HandleUnsuccessfulResponseArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr);
			HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__Request_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, "<Request>k__BackingField");
			HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__Response_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, "<Response>k__BackingField");
			HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__TotalTries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, "<TotalTries>k__BackingField");
			HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__CurrentFailedTry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, "<CurrentFailedTry>k__BackingField");
			HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__CancellationToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, "<CancellationToken>k__BackingField");
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_Request_Public_get_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663645);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_set_Request_Public_set_Void_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663646);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_Response_Public_get_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663647);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_set_Response_Public_set_Void_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663648);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_TotalTries_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663649);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_set_TotalTries_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663650);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_CurrentFailedTry_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663651);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_set_CurrentFailedTry_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663652);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_SupportsRetry_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663653);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663654);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_set_CancellationToken_Public_set_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663655);
			HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr, 100663656);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000C818 File Offset: 0x0000AA18
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0000C858 File Offset: 0x0000AA58
		public unsafe HttpRequestMessage Request
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_Request_Public_get_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_set_Request_Public_set_Void_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000C89C File Offset: 0x0000AA9C
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0000C8DC File Offset: 0x0000AADC
		public unsafe HttpResponseMessage Response
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_Response_Public_get_HttpResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_set_Response_Public_set_Void_HttpResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000C920 File Offset: 0x0000AB20
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0000C95C File Offset: 0x0000AB5C
		public unsafe int TotalTries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_TotalTries_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_set_TotalTries_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000C99C File Offset: 0x0000AB9C
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		public unsafe int CurrentFailedTry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_CurrentFailedTry_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_set_CurrentFailedTry_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000CA18 File Offset: 0x0000AC18
		public unsafe bool SupportsRetry
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1212430, RefRangeEnd = 1212432, XrefRangeStart = 1212430, XrefRangeEnd = 1212432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_SupportsRetry_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000CA54 File Offset: 0x0000AC54
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		public unsafe CancellationToken CancellationToken
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr_set_CancellationToken_Public_set_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandleUnsuccessfulResponseArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleUnsuccessfulResponseArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleUnsuccessfulResponseArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002EB9 File Offset: 0x000010B9
		public HandleUnsuccessfulResponseArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000CB10 File Offset: 0x0000AD10
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002EC2 File Offset: 0x000010C2
		public unsafe HttpRequestMessage _Request_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__Request_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpRequestMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__Request_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000CB40 File Offset: 0x0000AD40
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00002EE1 File Offset: 0x000010E1
		public unsafe HttpResponseMessage _Response_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__Response_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__Response_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000CB70 File Offset: 0x0000AD70
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00002F00 File Offset: 0x00001100
		public unsafe int _TotalTries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__TotalTries_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__TotalTries_k__BackingField)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000CB98 File Offset: 0x0000AD98
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00002F1B File Offset: 0x0000111B
		public unsafe int _CurrentFailedTry_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__CurrentFailedTry_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__CurrentFailedTry_k__BackingField)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00002F36 File Offset: 0x00001136
		public CancellationToken _CancellationToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__CancellationToken_k__BackingField);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleUnsuccessfulResponseArgs.NativeFieldInfoPtr__CancellationToken_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr__Request_k__BackingField;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr__Response_k__BackingField;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr__TotalTries_k__BackingField;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr__CurrentFailedTry_k__BackingField;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr__CancellationToken_k__BackingField;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Public_get_HttpRequestMessage_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_set_Request_Public_set_Void_HttpRequestMessage_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_get_Response_Public_get_HttpResponseMessage_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_set_Response_Public_set_Void_HttpResponseMessage_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalTries_Public_get_Int32_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_set_TotalTries_Public_set_Void_Int32_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentFailedTry_Public_get_Int32_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentFailedTry_Public_set_Void_Int32_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsRetry_Public_get_Boolean_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_set_CancellationToken_Public_set_Void_CancellationToken_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
