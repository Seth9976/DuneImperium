using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net
{
	// Token: 0x020001A3 RID: 419
	public class FtpWebResponse : WebResponse
	{
		// Token: 0x06001A4A RID: 6730 RVA: 0x000833B8 File Offset: 0x000815B8
		// Note: this type is marked as 'beforefieldinit'.
		static FtpWebResponse()
		{
			Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpWebResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr);
			FtpWebResponse.NativeFieldInfoPtr__responseStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "_responseStream");
			FtpWebResponse.NativeFieldInfoPtr__contentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "_contentLength");
			FtpWebResponse.NativeFieldInfoPtr__responseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "_responseUri");
			FtpWebResponse.NativeFieldInfoPtr__statusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "_statusCode");
			FtpWebResponse.NativeFieldInfoPtr__statusLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "_statusLine");
			FtpWebResponse.NativeFieldInfoPtr__ftpRequestHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "_ftpRequestHeaders");
			FtpWebResponse.NativeFieldInfoPtr__lastModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "_lastModified");
			FtpWebResponse.NativeFieldInfoPtr__bannerMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "_bannerMessage");
			FtpWebResponse.NativeFieldInfoPtr__welcomeMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "_welcomeMessage");
			FtpWebResponse.NativeFieldInfoPtr__exitMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "_exitMessage");
			FtpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Int64_Uri_FtpStatusCode_String_DateTime_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100667395);
			FtpWebResponse.NativeMethodInfoPtr_UpdateStatus_Internal_Void_FtpStatusCode_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100667396);
			FtpWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100667397);
			FtpWebResponse.NativeMethodInfoPtr_SetResponseStream_Internal_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100667398);
			FtpWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100667399);
			FtpWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100667400);
			FtpWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100667401);
			FtpWebResponse.NativeMethodInfoPtr_get_StatusCode_Public_get_FtpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, 100667402);
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00083550 File Offset: 0x00081750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 473914, RefRangeEnd = 473916, XrefRangeStart = 473892, XrefRangeEnd = 473914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responseStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseUri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref statusCode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(statusLine);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastModified;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(bannerMessage);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(welcomeMessage);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(exitMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr__ctor_Internal_Void_Stream_Int64_Uri_FtpStatusCode_String_DateTime_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00083624 File Offset: 0x00081824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473916, XrefRangeEnd = 473918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref statusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(statusLine);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(exitMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_UpdateStatus_Internal_Void_FtpStatusCode_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00083688 File Offset: 0x00081888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473918, XrefRangeEnd = 473929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Stream GetResponseStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpWebResponse.NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x000836D4 File Offset: 0x000818D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473929, XrefRangeEnd = 473936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResponseStream(Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_SetResponseStream_Internal_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00083718 File Offset: 0x00081918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473936, XrefRangeEnd = 473960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpWebResponse.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00083754 File Offset: 0x00081954
		public unsafe override WebHeaderCollection Headers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473960, XrefRangeEnd = 473969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpWebResponse.NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x000837A0 File Offset: 0x000819A0
		public unsafe override Uri ResponseUri
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FtpWebResponse.NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x000837EC File Offset: 0x000819EC
		public unsafe FtpStatusCode StatusCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.NativeMethodInfoPtr_get_StatusCode_Public_get_FtpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0000B48C File Offset: 0x0000968C
		public FtpWebResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x00083828 File Offset: 0x00081A28
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x0000B495 File Offset: 0x00009695
		public unsafe Stream _responseStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__responseStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__responseStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00083858 File Offset: 0x00081A58
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0000B4B4 File Offset: 0x000096B4
		public unsafe long _contentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__contentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__contentLength)) = value;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00083880 File Offset: 0x00081A80
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x0000B4CF File Offset: 0x000096CF
		public unsafe Uri _responseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__responseUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__responseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x000838B0 File Offset: 0x00081AB0
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x0000B4EE File Offset: 0x000096EE
		public unsafe FtpStatusCode _statusCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__statusCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__statusCode)) = value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x000838D8 File Offset: 0x00081AD8
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0000B509 File Offset: 0x00009709
		public unsafe string _statusLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__statusLine);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__statusLine), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00083900 File Offset: 0x00081B00
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0000B528 File Offset: 0x00009728
		public unsafe WebHeaderCollection _ftpRequestHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__ftpRequestHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__ftpRequestHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00083930 File Offset: 0x00081B30
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0000B547 File Offset: 0x00009747
		public unsafe DateTime _lastModified
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__lastModified);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__lastModified)) = value;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x00083958 File Offset: 0x00081B58
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0000B562 File Offset: 0x00009762
		public unsafe string _bannerMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__bannerMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__bannerMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x00083980 File Offset: 0x00081B80
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0000B581 File Offset: 0x00009781
		public unsafe string _welcomeMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__welcomeMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__welcomeMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x000839A8 File Offset: 0x00081BA8
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0000B5A0 File Offset: 0x000097A0
		public unsafe string _exitMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__exitMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpWebResponse.NativeFieldInfoPtr__exitMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeFieldInfoPtr__responseStream;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeFieldInfoPtr__contentLength;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeFieldInfoPtr__responseUri;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr__statusCode;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeFieldInfoPtr__statusLine;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeFieldInfoPtr__ftpRequestHeaders;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeFieldInfoPtr__lastModified;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeFieldInfoPtr__bannerMessage;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeFieldInfoPtr__welcomeMessage;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeFieldInfoPtr__exitMessage;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_Int64_Uri_FtpStatusCode_String_DateTime_String_String_String_0;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStatus_Internal_Void_FtpStatusCode_String_String_0;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeMethodInfoPtr_GetResponseStream_Public_Virtual_Stream_0;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeMethodInfoPtr_SetResponseStream_Internal_Void_Stream_0;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_Virtual_get_WebHeaderCollection_0;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseUri_Public_Virtual_get_Uri_0;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_FtpStatusCode_0;

		// Token: 0x0200031B RID: 795
		public sealed class EmptyStream : MemoryStream
		{
			// Token: 0x06002EBB RID: 11963 RVA: 0x00014E74 File Offset: 0x00013074
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyStream()
			{
				Il2CppClassPointerStore<FtpWebResponse.EmptyStream>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FtpWebResponse>.NativeClassPtr, "EmptyStream");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpWebResponse.EmptyStream>.NativeClassPtr);
				FtpWebResponse.EmptyStream.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpWebResponse.EmptyStream>.NativeClassPtr, 100667403);
			}

			// Token: 0x06002EBC RID: 11964 RVA: 0x000CC860 File Offset: 0x000CAA60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473885, XrefRangeEnd = 473892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmptyStream()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpWebResponse.EmptyStream>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpWebResponse.EmptyStream.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EBD RID: 11965 RVA: 0x00014EA8 File Offset: 0x000130A8
			public EmptyStream(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040024AE RID: 9390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
		}
	}
}
