using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Unity.Collections;

namespace UnityEngine.Networking
{
	// Token: 0x02000006 RID: 6
	public class DownloadHandler : Object
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00003B6C File Offset: 0x00001D6C
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadHandler()
		{
			Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "DownloadHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr);
			DownloadHandler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, "m_Ptr");
			DownloadHandler.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663329);
			DownloadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663330);
			DownloadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663331);
			DownloadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663332);
			DownloadHandler.NativeMethodInfoPtr_get_error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663333);
			DownloadHandler.NativeMethodInfoPtr_GetErrorMsg_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663334);
			DownloadHandler.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663335);
			DownloadHandler.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663336);
			DownloadHandler.NativeMethodInfoPtr_GetNativeData_Protected_Virtual_New_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663337);
			DownloadHandler.NativeMethodInfoPtr_GetData_Protected_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663338);
			DownloadHandler.NativeMethodInfoPtr_GetText_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663339);
			DownloadHandler.NativeMethodInfoPtr_GetTextEncoder_Private_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663340);
			DownloadHandler.NativeMethodInfoPtr_GetContentType_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663341);
			DownloadHandler.NativeMethodInfoPtr_ReceiveData_Protected_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663342);
			DownloadHandler.NativeMethodInfoPtr_ReceiveContentLengthHeader_Protected_Virtual_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663343);
			DownloadHandler.NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663344);
			DownloadHandler.NativeMethodInfoPtr_CompleteContent_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663345);
			DownloadHandler.NativeMethodInfoPtr_GetProgress_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663346);
			DownloadHandler.NativeMethodInfoPtr_GetCheckedDownloader_Protected_Static_T_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663347);
			DownloadHandler.NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_ptr_Byte_DownloadHandler_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663348);
			DownloadHandler.NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_Il2CppStructArray_1_Byte_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663349);
			DownloadHandler.NativeMethodInfoPtr_InternalGetNativeArray_Internal_Static_NativeArray_1_Byte_DownloadHandler_byref_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663350);
			DownloadHandler.NativeMethodInfoPtr_DisposeNativeArray_Internal_Static_Void_byref_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663351);
			DownloadHandler.NativeMethodInfoPtr_CreateNativeArrayForNativeData_Internal_Static_Void_byref_NativeArray_1_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663352);
			DownloadHandler.IsDoneDelegateField = IL2CPP.ResolveICall<DownloadHandler.IsDoneDelegate>("UnityEngine.Networking.DownloadHandler::IsDone");
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003DA0 File Offset: 0x00001FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247124, XrefRangeEnd = 1247126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003DD4 File Offset: 0x00001FD4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003E10 File Offset: 0x00002010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247126, XrefRangeEnd = 1247129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003E4C File Offset: 0x0000204C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247132, RefRangeEnd = 1247133, XrefRangeStart = 1247129, XrefRangeEnd = 1247132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003E88 File Offset: 0x00002088
		public unsafe string error
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1247135, RefRangeEnd = 1247136, XrefRangeStart = 1247133, XrefRangeEnd = 1247135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_get_error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003EC0 File Offset: 0x000020C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247135, RefRangeEnd = 1247136, XrefRangeStart = 1247135, XrefRangeEnd = 1247136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetErrorMsg()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_GetErrorMsg_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00003EF8 File Offset: 0x000020F8
		public unsafe Il2CppStructArray<byte> data
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 373605, RefRangeEnd = 373608, XrefRangeStart = 373605, XrefRangeEnd = 373608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003F38 File Offset: 0x00002138
		public unsafe string text
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 381934, RefRangeEnd = 381975, XrefRangeStart = 381934, XrefRangeEnd = 381975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003F70 File Offset: 0x00002170
		[CallerCount(0)]
		public unsafe virtual NativeArray<byte> GetNativeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_GetNativeData_Protected_Virtual_New_NativeArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<byte>(intPtr);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003FB4 File Offset: 0x000021B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247136, XrefRangeEnd = 1247138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_GetData_Protected_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004000 File Offset: 0x00002200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247138, XrefRangeEnd = 1247145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_GetText_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004044 File Offset: 0x00002244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247169, RefRangeEnd = 1247170, XrefRangeStart = 1247145, XrefRangeEnd = 1247169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding GetTextEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_GetTextEncoder_Private_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004084 File Offset: 0x00002284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247170, XrefRangeEnd = 1247172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetContentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_GetContentType_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000040BC File Offset: 0x000022BC
		[CallerCount(0)]
		public unsafe virtual bool ReceiveData(Il2CppStructArray<byte> data, int dataLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_ReceiveData_Protected_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004124 File Offset: 0x00002324
		[CallerCount(0)]
		public unsafe virtual void ReceiveContentLengthHeader(ulong contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_ReceiveContentLengthHeader_Protected_Virtual_New_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004170 File Offset: 0x00002370
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveContentLength(int contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000041BC File Offset: 0x000023BC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompleteContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_CompleteContent_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000041F8 File Offset: 0x000023F8
		[CallerCount(0)]
		public unsafe virtual float GetProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_GetProgress_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004240 File Offset: 0x00002440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247177, RefRangeEnd = 1247178, XrefRangeStart = 1247172, XrefRangeEnd = 1247177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCheckedDownloader<T>(UnityWebRequest www) where T : DownloadHandler
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(www);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.MethodInfoStoreGeneric_GetCheckedDownloader_Protected_Static_T_UnityWebRequest_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004280 File Offset: 0x00002480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247178, XrefRangeEnd = 1247180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte* InternalGetByteArray(DownloadHandler dh, out int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_ptr_Byte_DownloadHandler_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000042C8 File Offset: 0x000024C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> InternalGetByteArray(DownloadHandler dh)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_Il2CppStructArray_1_Byte_DownloadHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000430C File Offset: 0x0000250C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247187, RefRangeEnd = 1247188, XrefRangeStart = 1247180, XrefRangeEnd = 1247187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(nativeArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_InternalGetNativeArray_Internal_Static_NativeArray_1_Byte_DownloadHandler_byref_NativeArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<byte>(intPtr);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000435C File Offset: 0x0000255C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247189, RefRangeEnd = 1247190, XrefRangeStart = 1247188, XrefRangeEnd = 1247189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisposeNativeArray(ref NativeArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_DisposeNativeArray_Internal_Static_Void_byref_NativeArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004394 File Offset: 0x00002594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247190, XrefRangeEnd = 1247193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_CreateNativeArrayForNativeData_Internal_Static_Void_byref_NativeArray_1_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000022BC File Offset: 0x000004BC
		public DownloadHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000043E8 File Offset: 0x000025E8
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000022C5 File Offset: 0x000004C5
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandler.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandler.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00004410 File Offset: 0x00002610
		public bool isDone
		{
			get
			{
				return this.IsDone();
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000022E0 File Offset: 0x000004E0
		public bool IsDone()
		{
			return DownloadHandler.IsDoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00004428 File Offset: 0x00002628
		public NativeArray<byte>.ReadOnly nativeData
		{
			get
			{
				NativeArray<byte> nativeData = this.GetNativeData();
				return nativeData.AsReadOnly();
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_error_Public_get_String_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_GetErrorMsg_Private_String_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeData_Protected_Virtual_New_NativeArray_1_Byte_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Protected_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Virtual_New_String_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_GetTextEncoder_Private_Encoding_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_GetContentType_Private_String_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveData_Protected_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContentLengthHeader_Protected_Virtual_New_Void_UInt64_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_CompleteContent_Protected_Virtual_New_Void_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetProgress_Protected_Virtual_New_Single_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_GetCheckedDownloader_Protected_Static_T_UnityWebRequest_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_ptr_Byte_DownloadHandler_byref_Int32_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_Il2CppStructArray_1_Byte_DownloadHandler_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetNativeArray_Internal_Static_NativeArray_1_Byte_DownloadHandler_byref_NativeArray_1_Byte_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_DisposeNativeArray_Internal_Static_Void_byref_NativeArray_1_Byte_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_CreateNativeArrayForNativeData_Internal_Static_Void_byref_NativeArray_1_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000050 RID: 80
		private static readonly DownloadHandler.IsDoneDelegate IsDoneDelegateField;

		// Token: 0x02000012 RID: 18
		private sealed class MethodInfoStoreGeneric_GetCheckedDownloader_Protected_Static_T_UnityWebRequest_0<T>
		{
			// Token: 0x040000D7 RID: 215
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DownloadHandler.NativeMethodInfoPtr_GetCheckedDownloader_Protected_Static_T_UnityWebRequest_0, Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600016C RID: 364
		private delegate bool IsDoneDelegate(IntPtr @this);
	}
}
