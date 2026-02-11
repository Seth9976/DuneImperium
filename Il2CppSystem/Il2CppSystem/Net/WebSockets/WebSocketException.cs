using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net.WebSockets
{
	// Token: 0x0200025A RID: 602
	[Serializable]
	public sealed class WebSocketException : Win32Exception
	{
		// Token: 0x06002863 RID: 10339 RVA: 0x000B8208 File Offset: 0x000B6408
		// Note: this type is marked as 'beforefieldinit'.
		static WebSocketException()
		{
			Il2CppClassPointerStore<WebSocketException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.WebSockets", "WebSocketException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr);
			WebSocketException.NativeFieldInfoPtr__webSocketErrorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, "_webSocketErrorCode");
			WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669335);
			WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669336);
			WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669337);
			WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669338);
			WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669339);
			WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669340);
			WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669341);
			WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669342);
			WebSocketException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669343);
			WebSocketException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669344);
			WebSocketException.NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669345);
			WebSocketException.NativeMethodInfoPtr_GetErrorMessage_Private_Static_String_WebSocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669346);
			WebSocketException.NativeMethodInfoPtr_SetErrorCodeOnError_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669347);
			WebSocketException.NativeMethodInfoPtr_Succeeded_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr, 100669348);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000B8364 File Offset: 0x000B6564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493752, XrefRangeEnd = 493757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x000B83A0 File Offset: 0x000B65A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493757, XrefRangeEnd = 493759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketException(WebSocketError error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x000B83E8 File Offset: 0x000B65E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493759, XrefRangeEnd = 493760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketException(WebSocketError error, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000B8444 File Offset: 0x000B6644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 493762, RefRangeEnd = 493763, XrefRangeStart = 493760, XrefRangeEnd = 493762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketException(WebSocketError error, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000B84A0 File Offset: 0x000B66A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493763, XrefRangeEnd = 493764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketException(WebSocketError error, string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x000B850C File Offset: 0x000B670C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493764, XrefRangeEnd = 493765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketException(int nativeError)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeError;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x000B8554 File Offset: 0x000B6754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493765, XrefRangeEnd = 493766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x000B85A0 File Offset: 0x000B67A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493766, XrefRangeEnd = 493767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x000B8600 File Offset: 0x000B6800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebSocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebSocketException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x000B8664 File Offset: 0x000B6864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493767, XrefRangeEnd = 493774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x000B86C0 File Offset: 0x000B68C0
		public unsafe override int ErrorCode
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x000B86FC File Offset: 0x000B68FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 493790, RefRangeEnd = 493792, XrefRangeStart = 493774, XrefRangeEnd = 493790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetErrorMessage(WebSocketError error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr_GetErrorMessage_Private_Static_String_WebSocketError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x000B8734 File Offset: 0x000B6934
		[CallerCount(0)]
		public unsafe void SetErrorCodeOnError(int nativeError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeError;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr_SetErrorCodeOnError_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x000B8774 File Offset: 0x000B6974
		[CallerCount(0)]
		public unsafe static bool Succeeded(int hr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebSocketException.NativeMethodInfoPtr_Succeeded_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00011683 File Offset: 0x0000F883
		public WebSocketException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x000B87B4 File Offset: 0x000B69B4
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x0001168C File Offset: 0x0000F88C
		public unsafe WebSocketError _webSocketErrorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketException.NativeFieldInfoPtr__webSocketErrorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebSocketException.NativeFieldInfoPtr__webSocketErrorCode)) = value;
			}
		}

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeFieldInfoPtr__webSocketErrorCode;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_0;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_String_0;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_Exception_0;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebSocketError_String_Exception_0;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_get_Int32_0;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeMethodInfoPtr_GetErrorMessage_Private_Static_String_WebSocketError_0;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeMethodInfoPtr_SetErrorCodeOnError_Private_Void_Int32_0;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeMethodInfoPtr_Succeeded_Private_Static_Boolean_Int32_0;
	}
}
