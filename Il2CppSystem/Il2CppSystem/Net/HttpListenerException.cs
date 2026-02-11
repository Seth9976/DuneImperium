using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net
{
	// Token: 0x020001AD RID: 429
	[Serializable]
	public class HttpListenerException : Win32Exception
	{
		// Token: 0x06001AB1 RID: 6833 RVA: 0x00084E74 File Offset: 0x00083074
		// Note: this type is marked as 'beforefieldinit'.
		static HttpListenerException()
		{
			Il2CppClassPointerStore<HttpListenerException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpListenerException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpListenerException>.NativeClassPtr);
			HttpListenerException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerException>.NativeClassPtr, 100667451);
			HttpListenerException.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerException>.NativeClassPtr, 100667452);
			HttpListenerException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerException>.NativeClassPtr, 100667453);
			HttpListenerException.NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerException>.NativeClassPtr, 100667454);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00084EF4 File Offset: 0x000830F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474053, XrefRangeEnd = 474058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpListenerException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00084F30 File Offset: 0x00083130
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 474059, RefRangeEnd = 474064, XrefRangeStart = 474058, XrefRangeEnd = 474059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerException(int errorCode, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpListenerException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerException.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00084F8C File Offset: 0x0008318C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474064, XrefRangeEnd = 474065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpListenerException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x00084FF0 File Offset: 0x000831F0
		public unsafe override int ErrorCode
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpListenerException.NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0000B6C5 File Offset: 0x000098C5
		public HttpListenerException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCode_Public_Virtual_get_Int32_0;
	}
}
