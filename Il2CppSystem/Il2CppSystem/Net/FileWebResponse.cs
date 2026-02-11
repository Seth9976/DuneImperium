using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net
{
	// Token: 0x020001E3 RID: 483
	[Serializable]
	public class FileWebResponse : WebResponse
	{
		// Token: 0x06001E2A RID: 7722 RVA: 0x000913CC File Offset: 0x0008F5CC
		// Note: this type is marked as 'beforefieldinit'.
		static FileWebResponse()
		{
			Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FileWebResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr);
			FileWebResponse.NativeFieldInfoPtr_m_closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_closed");
			FileWebResponse.NativeFieldInfoPtr_m_contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_contentLength");
			FileWebResponse.NativeFieldInfoPtr_m_fileAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_fileAccess");
			FileWebResponse.NativeFieldInfoPtr_m_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_headers");
			FileWebResponse.NativeFieldInfoPtr_m_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_stream");
			FileWebResponse.NativeFieldInfoPtr_m_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, "m_uri");
			FileWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_FileWebRequest_Uri_FileAccess_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100667896);
			FileWebResponse.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100667897);
			FileWebResponse.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100667898);
			FileWebResponse.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100667899);
			FileWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100667900);
			FileWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100667901);
			FileWebResponse.NativeMethodInfoPtr_CheckDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100667902);
			FileWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100667903);
			FileWebResponse.NativeMethodInfoPtr_System_Net_ICloseEx_CloseEx_Private_Virtual_Final_New_Void_CloseExState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100667904);
			FileWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr, 100667905);
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0009153C File Offset: 0x0008F73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478154, RefRangeEnd = 478155, XrefRangeStart = 478111, XrefRangeEnd = 478154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asyncHint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_FileWebRequest_Uri_FileAccess_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x000915B8 File Offset: 0x0008F7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478155, XrefRangeEnd = 478187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebResponse.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0009161C File Offset: 0x0008F81C
		[CallerCount(0)]
		public new unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebResponse.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00091678 File Offset: 0x0008F878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478187, XrefRangeEnd = 478211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebResponse.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x000916DC File Offset: 0x0008F8DC
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478211, XrefRangeEnd = 478212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00091728 File Offset: 0x0008F928
		public unsafe override Uri ResponseUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478212, XrefRangeEnd = 478213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00091774 File Offset: 0x0008F974
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 478213, RefRangeEnd = 478216, XrefRangeStart = 478213, XrefRangeEnd = 478213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebResponse.NativeMethodInfoPtr_CheckDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000917A8 File Offset: 0x0008F9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478216, XrefRangeEnd = 478219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x000917E4 File Offset: 0x0008F9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478219, XrefRangeEnd = 478231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Net_ICloseEx_CloseEx(CloseExState closeState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebResponse.NativeMethodInfoPtr_System_Net_ICloseEx_CloseEx_Private_Virtual_Final_New_Void_CloseExState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00091824 File Offset: 0x0008FA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478231, XrefRangeEnd = 478233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream GetResponseStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0000CD47 File Offset: 0x0000AF47
		public FileWebResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00091870 File Offset: 0x0008FA70
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x0000CD50 File Offset: 0x0000AF50
		public unsafe bool m_closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_closed)) = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00091898 File Offset: 0x0008FA98
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x0000CD6B File Offset: 0x0000AF6B
		public unsafe long m_contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_contentLength)) = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x000918C0 File Offset: 0x0008FAC0
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x0000CD86 File Offset: 0x0000AF86
		public unsafe FileAccess m_fileAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_fileAccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_fileAccess)) = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x000918E8 File Offset: 0x0008FAE8
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x0000CDA1 File Offset: 0x0000AFA1
		public unsafe WebHeaderCollection m_headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00091918 File Offset: 0x0008FB18
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x0000CDC0 File Offset: 0x0000AFC0
		public unsafe Stream m_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00091948 File Offset: 0x0008FB48
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x0000CDDF File Offset: 0x0000AFDF
		public unsafe Uri m_uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebResponse.NativeFieldInfoPtr_m_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeFieldInfoPtr_m_closed;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeFieldInfoPtr_m_contentLength;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeFieldInfoPtr_m_fileAccess;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeFieldInfoPtr_m_headers;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeFieldInfoPtr_m_stream;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeFieldInfoPtr_m_uri;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FileWebRequest_Uri_FileAccess_Boolean_0;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisposed_Private_Void_0;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr_System_Net_ICloseEx_CloseEx_Private_Virtual_Final_New_Void_CloseExState_0;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0;
	}
}
