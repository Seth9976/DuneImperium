using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net
{
	// Token: 0x020001C1 RID: 449
	[Serializable]
	public class WebException : InvalidOperationException
	{
		// Token: 0x06001B82 RID: 7042 RVA: 0x0008795C File Offset: 0x00085B5C
		// Note: this type is marked as 'beforefieldinit'.
		static WebException()
		{
			Il2CppClassPointerStore<WebException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebException>.NativeClassPtr);
			WebException.NativeFieldInfoPtr_m_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebException>.NativeClassPtr, "m_Status");
			WebException.NativeFieldInfoPtr_m_Response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebException>.NativeClassPtr, "m_Response");
			WebException.NativeFieldInfoPtr_m_InternalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebException>.NativeClassPtr, "m_InternalStatus");
			WebException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667535);
			WebException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667536);
			WebException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667537);
			WebException.NativeMethodInfoPtr__ctor_Public_Void_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667538);
			WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_WebExceptionStatus_WebExceptionInternalStatus_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667539);
			WebException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_WebExceptionStatus_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667540);
			WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667541);
			WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667542);
			WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667543);
			WebException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667544);
			WebException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667545);
			WebException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667546);
			WebException.NativeMethodInfoPtr_get_Status_Public_get_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667547);
			WebException.NativeMethodInfoPtr_get_Response_Public_get_WebResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebException>.NativeClassPtr, 100667548);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00087AE0 File Offset: 0x00085CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474756, XrefRangeEnd = 474757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00087B1C File Offset: 0x00085D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474758, RefRangeEnd = 474759, XrefRangeStart = 474757, XrefRangeEnd = 474758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00087B68 File Offset: 0x00085D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474760, RefRangeEnd = 474761, XrefRangeStart = 474759, XrefRangeEnd = 474760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00087BC8 File Offset: 0x00085DC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 474762, RefRangeEnd = 474768, XrefRangeStart = 474761, XrefRangeEnd = 474762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, WebExceptionStatus status)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Public_Void_String_WebExceptionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00087C24 File Offset: 0x00085E24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474775, RefRangeEnd = 474776, XrefRangeStart = 474768, XrefRangeEnd = 474775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalStatus;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_WebExceptionStatus_WebExceptionInternalStatus_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00087CA0 File Offset: 0x00085EA0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 474783, RefRangeEnd = 474793, XrefRangeStart = 474776, XrefRangeEnd = 474783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_WebExceptionStatus_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00087D20 File Offset: 0x00085F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474793, XrefRangeEnd = 474804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00087DB0 File Offset: 0x00085FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474804, XrefRangeEnd = 474811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00087E3C File Offset: 0x0008603C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474811, XrefRangeEnd = 474822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00087EDC File Offset: 0x000860DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474822, XrefRangeEnd = 474823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00087F40 File Offset: 0x00086140
		[CallerCount(0)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00087F9C File Offset: 0x0008619C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00088000 File Offset: 0x00086200
		public unsafe WebExceptionStatus Status
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr_get_Status_Public_get_WebExceptionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0008803C File Offset: 0x0008623C
		public unsafe WebResponse Response
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebException.NativeMethodInfoPtr_get_Response_Public_get_WebResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr3) : null;
			}
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0000BCE9 File Offset: 0x00009EE9
		public WebException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0008807C File Offset: 0x0008627C
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x0000BCF2 File Offset: 0x00009EF2
		public unsafe WebExceptionStatus m_Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_Status)) = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x000880A4 File Offset: 0x000862A4
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x0000BD0D File Offset: 0x00009F0D
		public unsafe WebResponse m_Response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_Response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_Response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x000880D4 File Offset: 0x000862D4
		// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0000BD2C File Offset: 0x00009F2C
		public unsafe WebExceptionInternalStatus m_InternalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_InternalStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebException.NativeFieldInfoPtr_m_InternalStatus)) = value;
			}
		}

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeFieldInfoPtr_m_Status;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeFieldInfoPtr_m_Response;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalStatus;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_WebExceptionStatus_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_WebExceptionStatus_WebExceptionInternalStatus_Exception_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_WebExceptionStatus_WebResponse_0;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_0;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_Exception_WebExceptionStatus_WebResponse_WebExceptionInternalStatus_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_WebExceptionStatus_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_get_Response_Public_get_WebResponse_0;
	}
}
