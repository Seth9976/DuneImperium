using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000218 RID: 536
	public class WebResponseStream : WebConnectionStream
	{
		// Token: 0x06002427 RID: 9255 RVA: 0x000A7854 File Offset: 0x000A5A54
		// Note: this type is marked as 'beforefieldinit'.
		static WebResponseStream()
		{
			Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebResponseStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr);
			WebResponseStream.NativeFieldInfoPtr_innerStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "innerStream");
			WebResponseStream.NativeFieldInfoPtr_nextReadCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "nextReadCalled");
			WebResponseStream.NativeFieldInfoPtr_bufferedEntireContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "bufferedEntireContent");
			WebResponseStream.NativeFieldInfoPtr_pendingRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "pendingRead");
			WebResponseStream.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "locker");
			WebResponseStream.NativeFieldInfoPtr_nestedRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "nestedRead");
			WebResponseStream.NativeFieldInfoPtr_read_eof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "read_eof");
			WebResponseStream.NativeFieldInfoPtr__RequestStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<RequestStream>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__Headers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<Headers>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__StatusCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<StatusCode>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__StatusDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<StatusDescription>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<Version>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__KeepAlive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<KeepAlive>k__BackingField");
			WebResponseStream.NativeFieldInfoPtr__ChunkedRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ChunkedRead>k__BackingField");
			WebResponseStream.NativeMethodInfoPtr_get_RequestStream_Public_get_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668689);
			WebResponseStream.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668690);
			WebResponseStream.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668691);
			WebResponseStream.NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668692);
			WebResponseStream.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668693);
			WebResponseStream.NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668694);
			WebResponseStream.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668695);
			WebResponseStream.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668696);
			WebResponseStream.NativeMethodInfoPtr_set_Version_Private_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668697);
			WebResponseStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668698);
			WebResponseStream.NativeMethodInfoPtr_set_KeepAlive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668699);
			WebResponseStream.NativeMethodInfoPtr__ctor_Public_Void_WebRequestStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668700);
			WebResponseStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668701);
			WebResponseStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668702);
			WebResponseStream.NativeMethodInfoPtr_get_ChunkedRead_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668703);
			WebResponseStream.NativeMethodInfoPtr_set_ChunkedRead_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668704);
			WebResponseStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668705);
			WebResponseStream.NativeMethodInfoPtr_ProcessRead_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668706);
			WebResponseStream.NativeMethodInfoPtr_TryReadFromBufferedContent_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668707);
			WebResponseStream.NativeMethodInfoPtr_get_ExpectContent_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668708);
			WebResponseStream.NativeMethodInfoPtr_Initialize_Private_Void_BufferOffsetSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668709);
			WebResponseStream.NativeMethodInfoPtr_ReadAllAsyncInner_Private_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668710);
			WebResponseStream.NativeMethodInfoPtr_ReadAllAsync_Internal_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668711);
			WebResponseStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668712);
			WebResponseStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668713);
			WebResponseStream.NativeMethodInfoPtr_GetReadException_Private_WebException_WebExceptionStatus_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668714);
			WebResponseStream.NativeMethodInfoPtr_InitReadAsync_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668715);
			WebResponseStream.NativeMethodInfoPtr_GetResponse_Private_Boolean_BufferOffsetSize_byref_Int32_byref_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, 100668716);
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x000A7BCC File Offset: 0x000A5DCC
		public unsafe WebRequestStream RequestStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_RequestStream_Public_get_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr3) : null;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x000A7C0C File Offset: 0x000A5E0C
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x000A7C4C File Offset: 0x000A5E4C
		public unsafe WebHeaderCollection Headers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x000A7C90 File Offset: 0x000A5E90
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x000A7CCC File Offset: 0x000A5ECC
		public unsafe HttpStatusCode StatusCode
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x000A7D0C File Offset: 0x000A5F0C
		// (set) Token: 0x0600242E RID: 9262 RVA: 0x000A7D44 File Offset: 0x000A5F44
		public unsafe string StatusDescription
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x000A7D88 File Offset: 0x000A5F88
		// (set) Token: 0x06002430 RID: 9264 RVA: 0x000A7DC8 File Offset: 0x000A5FC8
		public unsafe Version Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_Version_Private_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x000A7E0C File Offset: 0x000A600C
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x000A7E48 File Offset: 0x000A6048
		public unsafe bool KeepAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_KeepAlive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x000A7E88 File Offset: 0x000A6088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486701, RefRangeEnd = 486702, XrefRangeStart = 486693, XrefRangeEnd = 486701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebResponseStream(WebRequestStream request)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr__ctor_Public_Void_WebRequestStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x000A7ED4 File Offset: 0x000A60D4
		public unsafe override bool CanRead
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x000A7F1C File Offset: 0x000A611C
		public unsafe override bool CanWrite
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x000A7F64 File Offset: 0x000A6164
		// (set) Token: 0x06002437 RID: 9271 RVA: 0x000A7FA0 File Offset: 0x000A61A0
		public unsafe bool ChunkedRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_ChunkedRead_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_set_ChunkedRead_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x000A7FE0 File Offset: 0x000A61E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486702, XrefRangeEnd = 486718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x000A8070 File Offset: 0x000A6270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 486755, RefRangeEnd = 486757, XrefRangeStart = 486718, XrefRangeEnd = 486755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> ProcessRead(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_ProcessRead_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x000A80F4 File Offset: 0x000A62F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486757, XrefRangeEnd = 486762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryReadFromBufferedContent(Il2CppStructArray<byte> buffer, int offset, int count, out int result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_TryReadFromBufferedContent_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x000A8178 File Offset: 0x000A6378
		public unsafe bool ExpectContent
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 486765, RefRangeEnd = 486768, XrefRangeStart = 486762, XrefRangeEnd = 486765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_get_ExpectContent_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x000A81B4 File Offset: 0x000A63B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486844, RefRangeEnd = 486845, XrefRangeStart = 486768, XrefRangeEnd = 486844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(BufferOffsetSize buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_Initialize_Private_Void_BufferOffsetSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x000A81F8 File Offset: 0x000A63F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486845, XrefRangeEnd = 486860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppStructArray<byte>> ReadAllAsyncInner(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_ReadAllAsyncInner_Private_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<byte>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x000A8250 File Offset: 0x000A6450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486860, XrefRangeEnd = 486871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReadAllAsync(bool resending, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resending;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_ReadAllAsync_Internal_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x000A82B4 File Offset: 0x000A64B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486871, XrefRangeEnd = 486881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x000A8344 File Offset: 0x000A6544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486881, XrefRangeEnd = 486882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close_internal(ref bool disposed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &disposed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebResponseStream.NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x000A8390 File Offset: 0x000A6590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486895, RefRangeEnd = 486896, XrefRangeStart = 486882, XrefRangeEnd = 486895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebException GetReadException(WebExceptionStatus status, Exception error, string where)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(where);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_GetReadException_Private_WebException_WebExceptionStatus_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x000A8400 File Offset: 0x000A6600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486907, RefRangeEnd = 486908, XrefRangeStart = 486896, XrefRangeEnd = 486907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InitReadAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_InitReadAsync_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x000A8458 File Offset: 0x000A6658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 486987, RefRangeEnd = 486988, XrefRangeStart = 486908, XrefRangeEnd = 486987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.NativeMethodInfoPtr_GetResponse_Private_Boolean_BufferOffsetSize_byref_Int32_byref_ReadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x0000F9F4 File Offset: 0x0000DBF4
		public WebResponseStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x000A84C4 File Offset: 0x000A66C4
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x0000F9FD File Offset: 0x0000DBFD
		public unsafe WebReadStream innerStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_innerStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebReadStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_innerStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x000A84F4 File Offset: 0x000A66F4
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x0000FA1C File Offset: 0x0000DC1C
		public unsafe bool nextReadCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nextReadCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nextReadCalled)) = value;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x000A851C File Offset: 0x000A671C
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x0000FA37 File Offset: 0x0000DC37
		public unsafe bool bufferedEntireContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_bufferedEntireContent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_bufferedEntireContent)) = value;
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x000A8544 File Offset: 0x000A6744
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x0000FA52 File Offset: 0x0000DC52
		public unsafe WebCompletionSource pendingRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_pendingRead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_pendingRead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x000A8574 File Offset: 0x000A6774
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x0000FA71 File Offset: 0x0000DC71
		public new unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x000A85A4 File Offset: 0x000A67A4
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x0000FA90 File Offset: 0x0000DC90
		public unsafe int nestedRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nestedRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_nestedRead)) = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x000A85CC File Offset: 0x000A67CC
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x0000FAAB File Offset: 0x0000DCAB
		public unsafe bool read_eof
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_read_eof);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr_read_eof)) = value;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x000A85F4 File Offset: 0x000A67F4
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x0000FAC6 File Offset: 0x0000DCC6
		public unsafe WebRequestStream _RequestStream_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__RequestStream_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequestStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__RequestStream_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x000A8624 File Offset: 0x000A6824
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x0000FAE5 File Offset: 0x0000DCE5
		public unsafe WebHeaderCollection _Headers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Headers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Headers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x000A8654 File Offset: 0x000A6854
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x0000FB04 File Offset: 0x0000DD04
		public unsafe HttpStatusCode _StatusCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusCode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x000A867C File Offset: 0x000A687C
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x0000FB1F File Offset: 0x0000DD1F
		public unsafe string _StatusDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__StatusDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x000A86A4 File Offset: 0x000A68A4
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x0000FB3E File Offset: 0x0000DD3E
		public unsafe Version _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Version_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__Version_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x000A86D4 File Offset: 0x000A68D4
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x0000FB5D File Offset: 0x0000DD5D
		public unsafe bool _KeepAlive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__KeepAlive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__KeepAlive_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x000A86FC File Offset: 0x000A68FC
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x0000FB78 File Offset: 0x0000DD78
		public unsafe bool _ChunkedRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__ChunkedRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.NativeFieldInfoPtr__ChunkedRead_k__BackingField)) = value;
			}
		}

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeFieldInfoPtr_innerStream;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeFieldInfoPtr_nextReadCalled;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeFieldInfoPtr_bufferedEntireContent;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeFieldInfoPtr_pendingRead;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeFieldInfoPtr_nestedRead;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeFieldInfoPtr_read_eof;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeFieldInfoPtr__RequestStream_k__BackingField;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeFieldInfoPtr__Headers_k__BackingField;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeFieldInfoPtr__StatusCode_k__BackingField;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeFieldInfoPtr__StatusDescription_k__BackingField;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeFieldInfoPtr__KeepAlive_k__BackingField;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeFieldInfoPtr__ChunkedRead_k__BackingField;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestStream_Public_get_WebRequestStream_0;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_HttpStatusCode_0;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusCode_Private_set_Void_HttpStatusCode_0;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_Version_0;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepAlive_Public_get_Boolean_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr_set_KeepAlive_Private_set_Void_Boolean_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebRequestStream_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkedRead_Private_get_Boolean_0;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeMethodInfoPtr_set_ChunkedRead_Private_set_Void_Boolean_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRead_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr_TryReadFromBufferedContent_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpectContent_Private_get_Boolean_0;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_BufferOffsetSize_0;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllAsyncInner_Private_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllAsync_Internal_Task_Boolean_CancellationToken_0;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeMethodInfoPtr_Close_internal_Protected_Virtual_Void_byref_Boolean_0;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeMethodInfoPtr_GetReadException_Private_WebException_WebExceptionStatus_Exception_String_0;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeMethodInfoPtr_InitReadAsync_Internal_Task_CancellationToken_0;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Private_Boolean_BufferOffsetSize_byref_Int32_byref_ReadState_0;

		// Token: 0x02000362 RID: 866
		[ObfuscatedName("System.Net.WebResponseStream+<ReadAsync>d__40")]
		public sealed class _ReadAsync_d__40 : ValueType
		{
			// Token: 0x06003210 RID: 12816 RVA: 0x000D4FC0 File Offset: 0x000D31C0
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAsync_d__40()
			{
				Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ReadAsync>d__40");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr);
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "<>1__state");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "<>t__builder");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "cancellationToken");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "buffer");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "offset");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "count");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "<>4__this");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr__completion_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "<completion>5__2");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr__nbytes_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "<nbytes>5__3");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr__throwMe_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "<throwMe>5__4");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "<>u__1");
				WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, "<>u__2");
				WebResponseStream._ReadAsync_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, 100668717);
				WebResponseStream._ReadAsync_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr, 100668718);
			}

			// Token: 0x06003211 RID: 12817 RVA: 0x000D5104 File Offset: 0x000D3304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486372, XrefRangeEnd = 486449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAsync_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003212 RID: 12818 RVA: 0x000D513C File Offset: 0x000D333C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486449, XrefRangeEnd = 486455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAsync_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003213 RID: 12819 RVA: 0x0001783F File Offset: 0x00015A3F
			public _ReadAsync_d__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003214 RID: 12820 RVA: 0x00017848 File Offset: 0x00015A48
			public _ReadAsync_d__40()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._ReadAsync_d__40>.NativeClassPtr))
			{
			}

			// Token: 0x17000FC8 RID: 4040
			// (get) Token: 0x06003215 RID: 12821 RVA: 0x000D5184 File Offset: 0x000D3384
			// (set) Token: 0x06003216 RID: 12822 RVA: 0x0001785A File Offset: 0x00015A5A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FC9 RID: 4041
			// (get) Token: 0x06003217 RID: 12823 RVA: 0x000D51AC File Offset: 0x000D33AC
			// (set) Token: 0x06003218 RID: 12824 RVA: 0x00017875 File Offset: 0x00015A75
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FCA RID: 4042
			// (get) Token: 0x06003219 RID: 12825 RVA: 0x000D51DC File Offset: 0x000D33DC
			// (set) Token: 0x0600321A RID: 12826 RVA: 0x000178A3 File Offset: 0x00015AA3
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FCB RID: 4043
			// (get) Token: 0x0600321B RID: 12827 RVA: 0x000D520C File Offset: 0x000D340C
			// (set) Token: 0x0600321C RID: 12828 RVA: 0x000178D1 File Offset: 0x00015AD1
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FCC RID: 4044
			// (get) Token: 0x0600321D RID: 12829 RVA: 0x000D523C File Offset: 0x000D343C
			// (set) Token: 0x0600321E RID: 12830 RVA: 0x000178F0 File Offset: 0x00015AF0
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000FCD RID: 4045
			// (get) Token: 0x0600321F RID: 12831 RVA: 0x000D5264 File Offset: 0x000D3464
			// (set) Token: 0x06003220 RID: 12832 RVA: 0x0001790B File Offset: 0x00015B0B
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17000FCE RID: 4046
			// (get) Token: 0x06003221 RID: 12833 RVA: 0x000D528C File Offset: 0x000D348C
			// (set) Token: 0x06003222 RID: 12834 RVA: 0x00017926 File Offset: 0x00015B26
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FCF RID: 4047
			// (get) Token: 0x06003223 RID: 12835 RVA: 0x000D52BC File Offset: 0x000D34BC
			// (set) Token: 0x06003224 RID: 12836 RVA: 0x00017945 File Offset: 0x00015B45
			public unsafe WebCompletionSource _completion_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr__completion_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr__completion_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD0 RID: 4048
			// (get) Token: 0x06003225 RID: 12837 RVA: 0x000D52EC File Offset: 0x000D34EC
			// (set) Token: 0x06003226 RID: 12838 RVA: 0x00017964 File Offset: 0x00015B64
			public unsafe int _nbytes_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr__nbytes_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr__nbytes_5__3)) = value;
				}
			}

			// Token: 0x17000FD1 RID: 4049
			// (get) Token: 0x06003227 RID: 12839 RVA: 0x000D5314 File Offset: 0x000D3514
			// (set) Token: 0x06003228 RID: 12840 RVA: 0x0001797F File Offset: 0x00015B7F
			public unsafe Exception _throwMe_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr__throwMe_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr__throwMe_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD2 RID: 4050
			// (get) Token: 0x06003229 RID: 12841 RVA: 0x000D5344 File Offset: 0x000D3544
			// (set) Token: 0x0600322A RID: 12842 RVA: 0x0001799E File Offset: 0x00015B9E
			public ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FD3 RID: 4051
			// (get) Token: 0x0600322B RID: 12843 RVA: 0x000D5374 File Offset: 0x000D3574
			// (set) Token: 0x0600322C RID: 12844 RVA: 0x000179CC File Offset: 0x00015BCC
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAsync_d__40.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400268E RID: 9870
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400268F RID: 9871
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002690 RID: 9872
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002691 RID: 9873
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x04002692 RID: 9874
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04002693 RID: 9875
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04002694 RID: 9876
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002695 RID: 9877
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__2;

			// Token: 0x04002696 RID: 9878
			private static readonly IntPtr NativeFieldInfoPtr__nbytes_5__3;

			// Token: 0x04002697 RID: 9879
			private static readonly IntPtr NativeFieldInfoPtr__throwMe_5__4;

			// Token: 0x04002698 RID: 9880
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002699 RID: 9881
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400269A RID: 9882
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400269B RID: 9883
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000363 RID: 867
		[ObfuscatedName("System.Net.WebResponseStream+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Object
		{
			// Token: 0x0600322D RID: 12845 RVA: 0x000D53A4 File Offset: 0x000D35A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr);
				WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr, "buffer");
				WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr, "offset");
				WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr, "size");
				WebResponseStream.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr, 100668719);
				WebResponseStream.__c__DisplayClass41_0.NativeMethodInfoPtr__ProcessRead_b__0_Internal_Task_1_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr, 100668720);
				WebResponseStream.__c__DisplayClass41_0.NativeMethodInfoPtr__ProcessRead_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr, 100668721);
				WebResponseStream.__c__DisplayClass41_0.NativeMethodInfoPtr__ProcessRead_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr, 100668722);
			}

			// Token: 0x0600322E RID: 12846 RVA: 0x000D5470 File Offset: 0x000D3670
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600322F RID: 12847 RVA: 0x000D54AC File Offset: 0x000D36AC
			[CallerCount(0)]
			public unsafe Task<int> _ProcessRead_b__0(CancellationToken ct)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.__c__DisplayClass41_0.NativeMethodInfoPtr__ProcessRead_b__0_Internal_Task_1_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
				}
			}

			// Token: 0x06003230 RID: 12848 RVA: 0x000D5504 File Offset: 0x000D3704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486455, XrefRangeEnd = 486458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessRead_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.__c__DisplayClass41_0.NativeMethodInfoPtr__ProcessRead_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003231 RID: 12849 RVA: 0x000D5538 File Offset: 0x000D3738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486458, XrefRangeEnd = 486474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ProcessRead_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream.__c__DisplayClass41_0.NativeMethodInfoPtr__ProcessRead_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003232 RID: 12850 RVA: 0x000179FA File Offset: 0x00015BFA
			public __c__DisplayClass41_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FD4 RID: 4052
			// (get) Token: 0x06003233 RID: 12851 RVA: 0x000D5574 File Offset: 0x000D3774
			// (set) Token: 0x06003234 RID: 12852 RVA: 0x00017A03 File Offset: 0x00015C03
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD5 RID: 4053
			// (get) Token: 0x06003235 RID: 12853 RVA: 0x000D55A4 File Offset: 0x000D37A4
			// (set) Token: 0x06003236 RID: 12854 RVA: 0x00017A22 File Offset: 0x00015C22
			public unsafe Il2CppStructArray<byte> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD6 RID: 4054
			// (get) Token: 0x06003237 RID: 12855 RVA: 0x000D55D4 File Offset: 0x000D37D4
			// (set) Token: 0x06003238 RID: 12856 RVA: 0x00017A41 File Offset: 0x00015C41
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17000FD7 RID: 4055
			// (get) Token: 0x06003239 RID: 12857 RVA: 0x000D55FC File Offset: 0x000D37FC
			// (set) Token: 0x0600323A RID: 12858 RVA: 0x00017A5C File Offset: 0x00015C5C
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream.__c__DisplayClass41_0.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x0400269C RID: 9884
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400269D RID: 9885
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x0400269E RID: 9886
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x0400269F RID: 9887
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x040026A0 RID: 9888
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040026A1 RID: 9889
			private static readonly IntPtr NativeMethodInfoPtr__ProcessRead_b__0_Internal_Task_1_Int32_CancellationToken_0;

			// Token: 0x040026A2 RID: 9890
			private static readonly IntPtr NativeMethodInfoPtr__ProcessRead_b__1_Internal_Void_0;

			// Token: 0x040026A3 RID: 9891
			private static readonly IntPtr NativeMethodInfoPtr__ProcessRead_b__2_Internal_Boolean_0;
		}

		// Token: 0x02000364 RID: 868
		[ObfuscatedName("System.Net.WebResponseStream+<ReadAllAsyncInner>d__47")]
		public sealed class _ReadAllAsyncInner_d__47 : ValueType
		{
			// Token: 0x0600323B RID: 12859 RVA: 0x000D5624 File Offset: 0x000D3824
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAllAsyncInner_d__47()
			{
				Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ReadAllAsyncInner>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr);
				WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr, "<>1__state");
				WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr, "<>t__builder");
				WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr, "cancellationToken");
				WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr, "<>4__this");
				WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr__maximumSize_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr, "<maximumSize>5__2");
				WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr__ms_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr, "<ms>5__3");
				WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr__buffer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr, "<buffer>5__4");
				WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr, "<>u__1");
				WebResponseStream._ReadAllAsyncInner_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr, 100668723);
				WebResponseStream._ReadAllAsyncInner_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr, 100668724);
			}

			// Token: 0x0600323C RID: 12860 RVA: 0x000D5718 File Offset: 0x000D3918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486474, XrefRangeEnd = 486518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAllAsyncInner_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600323D RID: 12861 RVA: 0x000D5750 File Offset: 0x000D3950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486518, XrefRangeEnd = 486524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAllAsyncInner_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600323E RID: 12862 RVA: 0x00017A77 File Offset: 0x00015C77
			public _ReadAllAsyncInner_d__47(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600323F RID: 12863 RVA: 0x00017A80 File Offset: 0x00015C80
			public _ReadAllAsyncInner_d__47()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._ReadAllAsyncInner_d__47>.NativeClassPtr))
			{
			}

			// Token: 0x17000FD8 RID: 4056
			// (get) Token: 0x06003240 RID: 12864 RVA: 0x000D5798 File Offset: 0x000D3998
			// (set) Token: 0x06003241 RID: 12865 RVA: 0x00017A92 File Offset: 0x00015C92
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FD9 RID: 4057
			// (get) Token: 0x06003242 RID: 12866 RVA: 0x000D57C0 File Offset: 0x000D39C0
			// (set) Token: 0x06003243 RID: 12867 RVA: 0x00017AAD File Offset: 0x00015CAD
			public AsyncTaskMethodBuilder<Il2CppStructArray<byte>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FDA RID: 4058
			// (get) Token: 0x06003244 RID: 12868 RVA: 0x000D57F0 File Offset: 0x000D39F0
			// (set) Token: 0x06003245 RID: 12869 RVA: 0x00017ADB File Offset: 0x00015CDB
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FDB RID: 4059
			// (get) Token: 0x06003246 RID: 12870 RVA: 0x000D5820 File Offset: 0x000D3A20
			// (set) Token: 0x06003247 RID: 12871 RVA: 0x00017B09 File Offset: 0x00015D09
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FDC RID: 4060
			// (get) Token: 0x06003248 RID: 12872 RVA: 0x000D5850 File Offset: 0x000D3A50
			// (set) Token: 0x06003249 RID: 12873 RVA: 0x00017B28 File Offset: 0x00015D28
			public unsafe long _maximumSize_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr__maximumSize_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr__maximumSize_5__2)) = value;
				}
			}

			// Token: 0x17000FDD RID: 4061
			// (get) Token: 0x0600324A RID: 12874 RVA: 0x000D5878 File Offset: 0x000D3A78
			// (set) Token: 0x0600324B RID: 12875 RVA: 0x00017B43 File Offset: 0x00015D43
			public unsafe MemoryStream _ms_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr__ms_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr__ms_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FDE RID: 4062
			// (get) Token: 0x0600324C RID: 12876 RVA: 0x000D58A8 File Offset: 0x000D3AA8
			// (set) Token: 0x0600324D RID: 12877 RVA: 0x00017B62 File Offset: 0x00015D62
			public unsafe Il2CppStructArray<byte> _buffer_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr__buffer_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr__buffer_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FDF RID: 4063
			// (get) Token: 0x0600324E RID: 12878 RVA: 0x000D58D8 File Offset: 0x000D3AD8
			// (set) Token: 0x0600324F RID: 12879 RVA: 0x00017B81 File Offset: 0x00015D81
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsyncInner_d__47.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040026A4 RID: 9892
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040026A5 RID: 9893
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040026A6 RID: 9894
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040026A7 RID: 9895
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040026A8 RID: 9896
			private static readonly IntPtr NativeFieldInfoPtr__maximumSize_5__2;

			// Token: 0x040026A9 RID: 9897
			private static readonly IntPtr NativeFieldInfoPtr__ms_5__3;

			// Token: 0x040026AA RID: 9898
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__4;

			// Token: 0x040026AB RID: 9899
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040026AC RID: 9900
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040026AD RID: 9901
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000365 RID: 869
		[ObfuscatedName("System.Net.WebResponseStream+<ReadAllAsync>d__48")]
		public sealed class _ReadAllAsync_d__48 : ValueType
		{
			// Token: 0x06003250 RID: 12880 RVA: 0x000D5908 File Offset: 0x000D3B08
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAllAsync_d__48()
			{
				Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<ReadAllAsync>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr);
				WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, "<>1__state");
				WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, "<>t__builder");
				WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, "<>4__this");
				WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, "cancellationToken");
				WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr_resending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, "resending");
				WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr__completion_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, "<completion>5__2");
				WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr__timeoutCts_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, "<timeoutCts>5__3");
				WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr__timeoutTask_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, "<timeoutTask>5__4");
				WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, "<>u__1");
				WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, "<>u__2");
				WebResponseStream._ReadAllAsync_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, 100668725);
				WebResponseStream._ReadAllAsync_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr, 100668726);
			}

			// Token: 0x06003251 RID: 12881 RVA: 0x000D5A24 File Offset: 0x000D3C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486524, XrefRangeEnd = 486649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAllAsync_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003252 RID: 12882 RVA: 0x000D5A5C File Offset: 0x000D3C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486649, XrefRangeEnd = 486653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._ReadAllAsync_d__48.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003253 RID: 12883 RVA: 0x00017BAF File Offset: 0x00015DAF
			public _ReadAllAsync_d__48(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003254 RID: 12884 RVA: 0x00017BB8 File Offset: 0x00015DB8
			public _ReadAllAsync_d__48()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._ReadAllAsync_d__48>.NativeClassPtr))
			{
			}

			// Token: 0x17000FE0 RID: 4064
			// (get) Token: 0x06003255 RID: 12885 RVA: 0x000D5AA4 File Offset: 0x000D3CA4
			// (set) Token: 0x06003256 RID: 12886 RVA: 0x00017BCA File Offset: 0x00015DCA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FE1 RID: 4065
			// (get) Token: 0x06003257 RID: 12887 RVA: 0x000D5ACC File Offset: 0x000D3CCC
			// (set) Token: 0x06003258 RID: 12888 RVA: 0x00017BE5 File Offset: 0x00015DE5
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FE2 RID: 4066
			// (get) Token: 0x06003259 RID: 12889 RVA: 0x000D5AFC File Offset: 0x000D3CFC
			// (set) Token: 0x0600325A RID: 12890 RVA: 0x00017C13 File Offset: 0x00015E13
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE3 RID: 4067
			// (get) Token: 0x0600325B RID: 12891 RVA: 0x000D5B2C File Offset: 0x000D3D2C
			// (set) Token: 0x0600325C RID: 12892 RVA: 0x00017C32 File Offset: 0x00015E32
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FE4 RID: 4068
			// (get) Token: 0x0600325D RID: 12893 RVA: 0x000D5B5C File Offset: 0x000D3D5C
			// (set) Token: 0x0600325E RID: 12894 RVA: 0x00017C60 File Offset: 0x00015E60
			public unsafe bool resending
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr_resending);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr_resending)) = value;
				}
			}

			// Token: 0x17000FE5 RID: 4069
			// (get) Token: 0x0600325F RID: 12895 RVA: 0x000D5B84 File Offset: 0x000D3D84
			// (set) Token: 0x06003260 RID: 12896 RVA: 0x00017C7B File Offset: 0x00015E7B
			public unsafe WebCompletionSource _completion_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr__completion_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebCompletionSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr__completion_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE6 RID: 4070
			// (get) Token: 0x06003261 RID: 12897 RVA: 0x000D5BB4 File Offset: 0x000D3DB4
			// (set) Token: 0x06003262 RID: 12898 RVA: 0x00017C9A File Offset: 0x00015E9A
			public unsafe CancellationTokenSource _timeoutCts_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr__timeoutCts_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr__timeoutCts_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE7 RID: 4071
			// (get) Token: 0x06003263 RID: 12899 RVA: 0x000D5BE4 File Offset: 0x000D3DE4
			// (set) Token: 0x06003264 RID: 12900 RVA: 0x00017CB9 File Offset: 0x00015EB9
			public unsafe Task _timeoutTask_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr__timeoutTask_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr__timeoutTask_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE8 RID: 4072
			// (get) Token: 0x06003265 RID: 12901 RVA: 0x000D5C14 File Offset: 0x000D3E14
			// (set) Token: 0x06003266 RID: 12902 RVA: 0x00017CD8 File Offset: 0x00015ED8
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FE9 RID: 4073
			// (get) Token: 0x06003267 RID: 12903 RVA: 0x000D5C44 File Offset: 0x000D3E44
			// (set) Token: 0x06003268 RID: 12904 RVA: 0x00017D06 File Offset: 0x00015F06
			public ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._ReadAllAsync_d__48.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040026AE RID: 9902
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040026AF RID: 9903
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040026B0 RID: 9904
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040026B1 RID: 9905
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040026B2 RID: 9906
			private static readonly IntPtr NativeFieldInfoPtr_resending;

			// Token: 0x040026B3 RID: 9907
			private static readonly IntPtr NativeFieldInfoPtr__completion_5__2;

			// Token: 0x040026B4 RID: 9908
			private static readonly IntPtr NativeFieldInfoPtr__timeoutCts_5__3;

			// Token: 0x040026B5 RID: 9909
			private static readonly IntPtr NativeFieldInfoPtr__timeoutTask_5__4;

			// Token: 0x040026B6 RID: 9910
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040026B7 RID: 9911
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040026B8 RID: 9912
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040026B9 RID: 9913
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000366 RID: 870
		[ObfuscatedName("System.Net.WebResponseStream+<InitReadAsync>d__52")]
		public sealed class _InitReadAsync_d__52 : ValueType
		{
			// Token: 0x06003269 RID: 12905 RVA: 0x000D5C74 File Offset: 0x000D3E74
			// Note: this type is marked as 'beforefieldinit'.
			static _InitReadAsync_d__52()
			{
				Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebResponseStream>.NativeClassPtr, "<InitReadAsync>d__52");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr);
				WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr, "<>1__state");
				WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr, "<>t__builder");
				WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr, "<>4__this");
				WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr, "cancellationToken");
				WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr__buffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr, "<buffer>5__2");
				WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr__state_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr, "<state>5__3");
				WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr__position_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr, "<position>5__4");
				WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr, "<>u__1");
				WebResponseStream._InitReadAsync_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr, 100668727);
				WebResponseStream._InitReadAsync_d__52.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr, 100668728);
			}

			// Token: 0x0600326A RID: 12906 RVA: 0x000D5D68 File Offset: 0x000D3F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486653, XrefRangeEnd = 486689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._InitReadAsync_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600326B RID: 12907 RVA: 0x000D5DA0 File Offset: 0x000D3FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486689, XrefRangeEnd = 486693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebResponseStream._InitReadAsync_d__52.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600326C RID: 12908 RVA: 0x00017D34 File Offset: 0x00015F34
			public _InitReadAsync_d__52(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600326D RID: 12909 RVA: 0x00017D3D File Offset: 0x00015F3D
			public _InitReadAsync_d__52()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebResponseStream._InitReadAsync_d__52>.NativeClassPtr))
			{
			}

			// Token: 0x17000FEA RID: 4074
			// (get) Token: 0x0600326E RID: 12910 RVA: 0x000D5DE8 File Offset: 0x000D3FE8
			// (set) Token: 0x0600326F RID: 12911 RVA: 0x00017D4F File Offset: 0x00015F4F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FEB RID: 4075
			// (get) Token: 0x06003270 RID: 12912 RVA: 0x000D5E10 File Offset: 0x000D4010
			// (set) Token: 0x06003271 RID: 12913 RVA: 0x00017D6A File Offset: 0x00015F6A
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FEC RID: 4076
			// (get) Token: 0x06003272 RID: 12914 RVA: 0x000D5E40 File Offset: 0x000D4040
			// (set) Token: 0x06003273 RID: 12915 RVA: 0x00017D98 File Offset: 0x00015F98
			public unsafe WebResponseStream __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebResponseStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FED RID: 4077
			// (get) Token: 0x06003274 RID: 12916 RVA: 0x000D5E70 File Offset: 0x000D4070
			// (set) Token: 0x06003275 RID: 12917 RVA: 0x00017DB7 File Offset: 0x00015FB7
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000FEE RID: 4078
			// (get) Token: 0x06003276 RID: 12918 RVA: 0x000D5EA0 File Offset: 0x000D40A0
			// (set) Token: 0x06003277 RID: 12919 RVA: 0x00017DE5 File Offset: 0x00015FE5
			public unsafe BufferOffsetSize _buffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr__buffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BufferOffsetSize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr__buffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FEF RID: 4079
			// (get) Token: 0x06003278 RID: 12920 RVA: 0x000D5ED0 File Offset: 0x000D40D0
			// (set) Token: 0x06003279 RID: 12921 RVA: 0x00017E04 File Offset: 0x00016004
			public unsafe ReadState _state_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr__state_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr__state_5__3)) = value;
				}
			}

			// Token: 0x17000FF0 RID: 4080
			// (get) Token: 0x0600327A RID: 12922 RVA: 0x000D5EF8 File Offset: 0x000D40F8
			// (set) Token: 0x0600327B RID: 12923 RVA: 0x00017E1F File Offset: 0x0001601F
			public unsafe int _position_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr__position_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr__position_5__4)) = value;
				}
			}

			// Token: 0x17000FF1 RID: 4081
			// (get) Token: 0x0600327C RID: 12924 RVA: 0x000D5F20 File Offset: 0x000D4120
			// (set) Token: 0x0600327D RID: 12925 RVA: 0x00017E3A File Offset: 0x0001603A
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebResponseStream._InitReadAsync_d__52.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040026BA RID: 9914
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040026BB RID: 9915
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040026BC RID: 9916
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040026BD RID: 9917
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040026BE RID: 9918
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__2;

			// Token: 0x040026BF RID: 9919
			private static readonly IntPtr NativeFieldInfoPtr__state_5__3;

			// Token: 0x040026C0 RID: 9920
			private static readonly IntPtr NativeFieldInfoPtr__position_5__4;

			// Token: 0x040026C1 RID: 9921
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040026C2 RID: 9922
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040026C3 RID: 9923
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
