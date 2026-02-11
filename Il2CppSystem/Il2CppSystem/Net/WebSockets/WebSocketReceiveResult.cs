using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x0200025C RID: 604
	public class WebSocketReceiveResult : Object
	{
		// Token: 0x06002875 RID: 10357 RVA: 0x000B87DC File Offset: 0x000B69DC
		// Note: this type is marked as 'beforefieldinit'.
		static WebSocketReceiveResult()
		{
			Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.WebSockets", "WebSocketReceiveResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr);
			WebSocketReceiveResult.NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr, "<Count>k__BackingField");
			WebSocketReceiveResult.NativeFieldInfoPtr__EndOfMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr, "<EndOfMessage>k__BackingField");
			WebSocketReceiveResult.NativeFieldInfoPtr__MessageType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr, "<MessageType>k__BackingField");
			WebSocketReceiveResult.NativeFieldInfoPtr__CloseStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr, "<CloseStatus>k__BackingField");
			WebSocketReceiveResult.NativeFieldInfoPtr__CloseStatusDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr, "<CloseStatusDescription>k__BackingField");
			WebSocketReceiveResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_WebSocketMessageType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr, 100669349);
			WebSocketReceiveResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_WebSocketMessageType_Boolean_Nullable_1_WebSocketCloseStatus_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr, 100669350);
			WebSocketReceiveResult.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr, 100669351);
			WebSocketReceiveResult.NativeMethodInfoPtr_get_EndOfMessage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr, 100669352);
			WebSocketReceiveResult.NativeMethodInfoPtr_get_MessageType_Public_get_WebSocketMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr, 100669353);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000B88D4 File Offset: 0x000B6AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493792, XrefRangeEnd = 493793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketReceiveResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_WebSocketMessageType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x000B8938 File Offset: 0x000B6B38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 493801, RefRangeEnd = 493803, XrefRangeStart = 493793, XrefRangeEnd = 493801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketReceiveResult(int count, WebSocketMessageType messageType, bool endOfMessage, Nullable<WebSocketCloseStatus> closeStatus, string closeStatusDescription)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketReceiveResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfMessage;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(closeStatus));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(closeStatusDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketReceiveResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_WebSocketMessageType_Boolean_Nullable_1_WebSocketCloseStatus_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x000B89C8 File Offset: 0x000B6BC8
		public unsafe int Count
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketReceiveResult.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x000B8A04 File Offset: 0x000B6C04
		public unsafe bool EndOfMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketReceiveResult.NativeMethodInfoPtr_get_EndOfMessage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x000B8A40 File Offset: 0x000B6C40
		public unsafe WebSocketMessageType MessageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketReceiveResult.NativeMethodInfoPtr_get_MessageType_Public_get_WebSocketMessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x000116A7 File Offset: 0x0000F8A7
		public WebSocketReceiveResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x000B8A7C File Offset: 0x000B6C7C
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x000116B0 File Offset: 0x0000F8B0
		public unsafe int _Count_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketReceiveResult.NativeFieldInfoPtr__Count_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketReceiveResult.NativeFieldInfoPtr__Count_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x000B8AA4 File Offset: 0x000B6CA4
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x000116CB File Offset: 0x0000F8CB
		public unsafe bool _EndOfMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketReceiveResult.NativeFieldInfoPtr__EndOfMessage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketReceiveResult.NativeFieldInfoPtr__EndOfMessage_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x000B8ACC File Offset: 0x000B6CCC
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x000116E6 File Offset: 0x0000F8E6
		public unsafe WebSocketMessageType _MessageType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketReceiveResult.NativeFieldInfoPtr__MessageType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketReceiveResult.NativeFieldInfoPtr__MessageType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x000B8AF4 File Offset: 0x000B6CF4
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x00011701 File Offset: 0x0000F901
		public Nullable<WebSocketCloseStatus> _CloseStatus_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketReceiveResult.NativeFieldInfoPtr__CloseStatus_k__BackingField);
				return new Nullable<WebSocketCloseStatus>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WebSocketCloseStatus>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketReceiveResult.NativeFieldInfoPtr__CloseStatus_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WebSocketCloseStatus>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x000B8B24 File Offset: 0x000B6D24
		// (set) Token: 0x06002885 RID: 10373 RVA: 0x0001172F File Offset: 0x0000F92F
		public unsafe string _CloseStatusDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketReceiveResult.NativeFieldInfoPtr__CloseStatusDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketReceiveResult.NativeFieldInfoPtr__CloseStatusDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeFieldInfoPtr__Count_k__BackingField;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeFieldInfoPtr__EndOfMessage_k__BackingField;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeFieldInfoPtr__MessageType_k__BackingField;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeFieldInfoPtr__CloseStatus_k__BackingField;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeFieldInfoPtr__CloseStatusDescription_k__BackingField;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_WebSocketMessageType_Boolean_0;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_WebSocketMessageType_Boolean_Nullable_1_WebSocketCloseStatus_String_0;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeMethodInfoPtr_get_EndOfMessage_Public_get_Boolean_0;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageType_Public_get_WebSocketMessageType_0;
	}
}
