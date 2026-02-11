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
	// Token: 0x02000214 RID: 532
	public class WebConnectionTunnel : Object
	{
		// Token: 0x06002365 RID: 9061 RVA: 0x000A46EC File Offset: 0x000A28EC
		// Note: this type is marked as 'beforefieldinit'.
		static WebConnectionTunnel()
		{
			Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebConnectionTunnel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr);
			WebConnectionTunnel.NativeFieldInfoPtr__Request_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Request>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__ConnectUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<ConnectUri>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr_connectRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "connectRequest");
			WebConnectionTunnel.NativeFieldInfoPtr_ntlmAuthState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "ntlmAuthState");
			WebConnectionTunnel.NativeFieldInfoPtr__Success_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Success>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__CloseConnection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<CloseConnection>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__StatusCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<StatusCode>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__StatusDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<StatusDescription>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__Challenge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Challenge>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__Headers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Headers>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__ProxyVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<ProxyVersion>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Data>k__BackingField");
			WebConnectionTunnel.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668566);
			WebConnectionTunnel.NativeMethodInfoPtr_get_ConnectUri_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668567);
			WebConnectionTunnel.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668568);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668569);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668570);
			WebConnectionTunnel.NativeMethodInfoPtr_get_CloseConnection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668571);
			WebConnectionTunnel.NativeMethodInfoPtr_set_CloseConnection_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668572);
			WebConnectionTunnel.NativeMethodInfoPtr_get_StatusCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668573);
			WebConnectionTunnel.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668574);
			WebConnectionTunnel.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668575);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Challenge_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668576);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Challenge_Private_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668577);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668578);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668579);
			WebConnectionTunnel.NativeMethodInfoPtr_get_ProxyVersion_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668580);
			WebConnectionTunnel.NativeMethodInfoPtr_set_ProxyVersion_Private_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668581);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668582);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Data_Private_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668583);
			WebConnectionTunnel.NativeMethodInfoPtr_Initialize_Internal_Task_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668584);
			WebConnectionTunnel.NativeMethodInfoPtr_ReadHeaders_Private_Task_1_ValueTuple_3_WebHeaderCollection_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668585);
			WebConnectionTunnel.NativeMethodInfoPtr_FlushContents_Private_Void_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100668586);
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x000A49B0 File Offset: 0x000A2BB0
		public unsafe HttpWebRequest Request
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x000A49F0 File Offset: 0x000A2BF0
		public unsafe Uri ConnectUri
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_ConnectUri_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x000A4A30 File Offset: 0x000A2C30
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebConnectionTunnel(HttpWebRequest request, Uri connectUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(connectUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x000A4A90 File Offset: 0x000A2C90
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x000A4ACC File Offset: 0x000A2CCC
		public unsafe bool Success
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x000A4B0C File Offset: 0x000A2D0C
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x000A4B48 File Offset: 0x000A2D48
		public unsafe bool CloseConnection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_CloseConnection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_CloseConnection_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000A4B88 File Offset: 0x000A2D88
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x000A4BC4 File Offset: 0x000A2DC4
		public unsafe int StatusCode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_StatusCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (set) Token: 0x0600236F RID: 9071 RVA: 0x000A4C04 File Offset: 0x000A2E04
		public unsafe string StatusDescription
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x000A4C48 File Offset: 0x000A2E48
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x000A4C88 File Offset: 0x000A2E88
		public unsafe Il2CppStringArray Challenge
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Challenge_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Challenge_Private_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x000A4CCC File Offset: 0x000A2ECC
		// (set) Token: 0x06002373 RID: 9075 RVA: 0x000A4D0C File Offset: 0x000A2F0C
		public unsafe WebHeaderCollection Headers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x000A4D50 File Offset: 0x000A2F50
		// (set) Token: 0x06002375 RID: 9077 RVA: 0x000A4D90 File Offset: 0x000A2F90
		public unsafe Version ProxyVersion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_ProxyVersion_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_ProxyVersion_Private_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x000A4DD4 File Offset: 0x000A2FD4
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x000A4E14 File Offset: 0x000A3014
		public unsafe Il2CppStructArray<byte> Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Data_Private_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x000A4E58 File Offset: 0x000A3058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485225, XrefRangeEnd = 485237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Initialize(Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_Initialize_Internal_Task_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x000A4EC0 File Offset: 0x000A30C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485237, XrefRangeEnd = 485253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>> ReadHeaders(Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_ReadHeaders_Private_Task_1_ValueTuple_3_WebHeaderCollection_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>>(intPtr3) : null;
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x000A4F28 File Offset: 0x000A3128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485253, XrefRangeEnd = 485256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushContents(Stream stream, int contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_FlushContents_Private_Void_Stream_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x0000F4AA File Offset: 0x0000D6AA
		public WebConnectionTunnel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x000A4F78 File Offset: 0x000A3178
		// (set) Token: 0x0600237D RID: 9085 RVA: 0x0000F4B3 File Offset: 0x0000D6B3
		public unsafe HttpWebRequest _Request_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Request_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Request_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x000A4FA8 File Offset: 0x000A31A8
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x0000F4D2 File Offset: 0x0000D6D2
		public unsafe Uri _ConnectUri_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ConnectUri_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ConnectUri_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x000A4FD8 File Offset: 0x000A31D8
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x0000F4F1 File Offset: 0x0000D6F1
		public unsafe HttpWebRequest connectRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_connectRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_connectRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x000A5008 File Offset: 0x000A3208
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x0000F510 File Offset: 0x0000D710
		public unsafe WebConnectionTunnel.NtlmAuthState ntlmAuthState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_ntlmAuthState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_ntlmAuthState)) = value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000A5030 File Offset: 0x000A3230
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x0000F52B File Offset: 0x0000D72B
		public unsafe bool _Success_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Success_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Success_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000A5058 File Offset: 0x000A3258
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x0000F546 File Offset: 0x0000D746
		public unsafe bool _CloseConnection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__CloseConnection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__CloseConnection_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x000A5080 File Offset: 0x000A3280
		// (set) Token: 0x06002389 RID: 9097 RVA: 0x0000F561 File Offset: 0x0000D761
		public unsafe int _StatusCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusCode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x000A50A8 File Offset: 0x000A32A8
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x0000F57C File Offset: 0x0000D77C
		public unsafe string _StatusDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x000A50D0 File Offset: 0x000A32D0
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x0000F59B File Offset: 0x0000D79B
		public unsafe Il2CppStringArray _Challenge_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Challenge_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Challenge_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x000A5100 File Offset: 0x000A3300
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x0000F5BA File Offset: 0x0000D7BA
		public unsafe WebHeaderCollection _Headers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Headers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Headers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x000A5130 File Offset: 0x000A3330
		// (set) Token: 0x06002391 RID: 9105 RVA: 0x0000F5D9 File Offset: 0x0000D7D9
		public unsafe Version _ProxyVersion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ProxyVersion_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ProxyVersion_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x000A5160 File Offset: 0x000A3360
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x0000F5F8 File Offset: 0x0000D7F8
		public unsafe Il2CppStructArray<byte> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeFieldInfoPtr__Request_k__BackingField;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeFieldInfoPtr__ConnectUri_k__BackingField;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeFieldInfoPtr_connectRequest;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeFieldInfoPtr_ntlmAuthState;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeFieldInfoPtr__Success_k__BackingField;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeFieldInfoPtr__CloseConnection_k__BackingField;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeFieldInfoPtr__StatusCode_k__BackingField;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeFieldInfoPtr__StatusDescription_k__BackingField;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeFieldInfoPtr__Challenge_k__BackingField;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeFieldInfoPtr__Headers_k__BackingField;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeFieldInfoPtr__ProxyVersion_k__BackingField;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectUri_Public_get_Uri_0;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Uri_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseConnection_Public_get_Boolean_0;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseConnection_Private_set_Void_Boolean_0;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_Int32_0;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusCode_Private_set_Void_Int32_0;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeMethodInfoPtr_get_Challenge_Public_get_Il2CppStringArray_0;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr_set_Challenge_Private_set_Void_Il2CppStringArray_0;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyVersion_Public_get_Version_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_set_ProxyVersion_Private_set_Void_Version_0;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Private_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Task_Stream_CancellationToken_0;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeMethodInfoPtr_ReadHeaders_Private_Task_1_ValueTuple_3_WebHeaderCollection_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeMethodInfoPtr_FlushContents_Private_Void_Stream_Int32_0;

		// Token: 0x02000354 RID: 852
		public enum NtlmAuthState
		{
			// Token: 0x04002615 RID: 9749
			None,
			// Token: 0x04002616 RID: 9750
			Challenge,
			// Token: 0x04002617 RID: 9751
			Response
		}

		// Token: 0x02000355 RID: 853
		[ObfuscatedName("System.Net.WebConnectionTunnel+<Initialize>d__42")]
		public sealed class _Initialize_d__42 : ValueType
		{
			// Token: 0x06003117 RID: 12567 RVA: 0x000D2D3C File Offset: 0x000D0F3C
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__42()
			{
				Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Initialize>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr);
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>1__state");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>t__builder");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>4__this");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "stream");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "cancellationToken");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr__have_auth_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<have_auth>5__2");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>u__1");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>u__2");
				WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, 100668587);
				WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, 100668588);
			}

			// Token: 0x06003118 RID: 12568 RVA: 0x000D2E30 File Offset: 0x000D1030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 484983, XrefRangeEnd = 485132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003119 RID: 12569 RVA: 0x000D2E68 File Offset: 0x000D1068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485132, XrefRangeEnd = 485136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600311A RID: 12570 RVA: 0x0001698F File Offset: 0x00014B8F
			public _Initialize_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600311B RID: 12571 RVA: 0x00016998 File Offset: 0x00014B98
			public _Initialize_d__42()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr))
			{
			}

			// Token: 0x17000F6C RID: 3948
			// (get) Token: 0x0600311C RID: 12572 RVA: 0x000D2EB0 File Offset: 0x000D10B0
			// (set) Token: 0x0600311D RID: 12573 RVA: 0x000169AA File Offset: 0x00014BAA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F6D RID: 3949
			// (get) Token: 0x0600311E RID: 12574 RVA: 0x000D2ED8 File Offset: 0x000D10D8
			// (set) Token: 0x0600311F RID: 12575 RVA: 0x000169C5 File Offset: 0x00014BC5
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F6E RID: 3950
			// (get) Token: 0x06003120 RID: 12576 RVA: 0x000D2F08 File Offset: 0x000D1108
			// (set) Token: 0x06003121 RID: 12577 RVA: 0x000169F3 File Offset: 0x00014BF3
			public unsafe WebConnectionTunnel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F6F RID: 3951
			// (get) Token: 0x06003122 RID: 12578 RVA: 0x000D2F38 File Offset: 0x000D1138
			// (set) Token: 0x06003123 RID: 12579 RVA: 0x00016A12 File Offset: 0x00014C12
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F70 RID: 3952
			// (get) Token: 0x06003124 RID: 12580 RVA: 0x000D2F68 File Offset: 0x000D1168
			// (set) Token: 0x06003125 RID: 12581 RVA: 0x00016A31 File Offset: 0x00014C31
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F71 RID: 3953
			// (get) Token: 0x06003126 RID: 12582 RVA: 0x000D2F98 File Offset: 0x000D1198
			// (set) Token: 0x06003127 RID: 12583 RVA: 0x00016A5F File Offset: 0x00014C5F
			public unsafe bool _have_auth_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr__have_auth_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr__have_auth_5__2)) = value;
				}
			}

			// Token: 0x17000F72 RID: 3954
			// (get) Token: 0x06003128 RID: 12584 RVA: 0x000D2FC0 File Offset: 0x000D11C0
			// (set) Token: 0x06003129 RID: 12585 RVA: 0x00016A7A File Offset: 0x00014C7A
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F73 RID: 3955
			// (get) Token: 0x0600312A RID: 12586 RVA: 0x000D2FF0 File Offset: 0x000D11F0
			// (set) Token: 0x0600312B RID: 12587 RVA: 0x00016AA8 File Offset: 0x00014CA8
			public ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002618 RID: 9752
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002619 RID: 9753
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400261A RID: 9754
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400261B RID: 9755
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x0400261C RID: 9756
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400261D RID: 9757
			private static readonly IntPtr NativeFieldInfoPtr__have_auth_5__2;

			// Token: 0x0400261E RID: 9758
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400261F RID: 9759
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04002620 RID: 9760
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002621 RID: 9761
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000356 RID: 854
		[ObfuscatedName("System.Net.WebConnectionTunnel+<ReadHeaders>d__43")]
		public sealed class _ReadHeaders_d__43 : ValueType
		{
			// Token: 0x0600312C RID: 12588 RVA: 0x000D3020 File Offset: 0x000D1220
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadHeaders_d__43()
			{
				Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<ReadHeaders>d__43");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr);
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>1__state");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>t__builder");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "cancellationToken");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "stream");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>4__this");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__retBuffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<retBuffer>5__2");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__status_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<status>5__3");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__buffer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<buffer>5__4");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__ms_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<ms>5__5");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>u__1");
				WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, 100668589);
				WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, 100668590);
			}

			// Token: 0x0600312D RID: 12589 RVA: 0x000D313C File Offset: 0x000D133C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485136, XrefRangeEnd = 485219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600312E RID: 12590 RVA: 0x000D3174 File Offset: 0x000D1374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485219, XrefRangeEnd = 485225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600312F RID: 12591 RVA: 0x00016AD6 File Offset: 0x00014CD6
			public _ReadHeaders_d__43(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003130 RID: 12592 RVA: 0x00016ADF File Offset: 0x00014CDF
			public _ReadHeaders_d__43()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr))
			{
			}

			// Token: 0x17000F74 RID: 3956
			// (get) Token: 0x06003131 RID: 12593 RVA: 0x000D31BC File Offset: 0x000D13BC
			// (set) Token: 0x06003132 RID: 12594 RVA: 0x00016AF1 File Offset: 0x00014CF1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F75 RID: 3957
			// (get) Token: 0x06003133 RID: 12595 RVA: 0x000D31E4 File Offset: 0x000D13E4
			// (set) Token: 0x06003134 RID: 12596 RVA: 0x00016B0C File Offset: 0x00014D0C
			public AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F76 RID: 3958
			// (get) Token: 0x06003135 RID: 12597 RVA: 0x000D3214 File Offset: 0x000D1414
			// (set) Token: 0x06003136 RID: 12598 RVA: 0x00016B3A File Offset: 0x00014D3A
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F77 RID: 3959
			// (get) Token: 0x06003137 RID: 12599 RVA: 0x000D3244 File Offset: 0x000D1444
			// (set) Token: 0x06003138 RID: 12600 RVA: 0x00016B68 File Offset: 0x00014D68
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F78 RID: 3960
			// (get) Token: 0x06003139 RID: 12601 RVA: 0x000D3274 File Offset: 0x000D1474
			// (set) Token: 0x0600313A RID: 12602 RVA: 0x00016B87 File Offset: 0x00014D87
			public unsafe WebConnectionTunnel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F79 RID: 3961
			// (get) Token: 0x0600313B RID: 12603 RVA: 0x000D32A4 File Offset: 0x000D14A4
			// (set) Token: 0x0600313C RID: 12604 RVA: 0x00016BA6 File Offset: 0x00014DA6
			public unsafe Il2CppStructArray<byte> _retBuffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__retBuffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__retBuffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7A RID: 3962
			// (get) Token: 0x0600313D RID: 12605 RVA: 0x000D32D4 File Offset: 0x000D14D4
			// (set) Token: 0x0600313E RID: 12606 RVA: 0x00016BC5 File Offset: 0x00014DC5
			public unsafe int _status_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__status_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__status_5__3)) = value;
				}
			}

			// Token: 0x17000F7B RID: 3963
			// (get) Token: 0x0600313F RID: 12607 RVA: 0x000D32FC File Offset: 0x000D14FC
			// (set) Token: 0x06003140 RID: 12608 RVA: 0x00016BE0 File Offset: 0x00014DE0
			public unsafe Il2CppStructArray<byte> _buffer_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__buffer_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__buffer_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7C RID: 3964
			// (get) Token: 0x06003141 RID: 12609 RVA: 0x000D332C File Offset: 0x000D152C
			// (set) Token: 0x06003142 RID: 12610 RVA: 0x00016BFF File Offset: 0x00014DFF
			public unsafe MemoryStream _ms_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__ms_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__ms_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7D RID: 3965
			// (get) Token: 0x06003143 RID: 12611 RVA: 0x000D335C File Offset: 0x000D155C
			// (set) Token: 0x06003144 RID: 12612 RVA: 0x00016C1E File Offset: 0x00014E1E
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002622 RID: 9762
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002623 RID: 9763
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002624 RID: 9764
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002625 RID: 9765
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04002626 RID: 9766
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002627 RID: 9767
			private static readonly IntPtr NativeFieldInfoPtr__retBuffer_5__2;

			// Token: 0x04002628 RID: 9768
			private static readonly IntPtr NativeFieldInfoPtr__status_5__3;

			// Token: 0x04002629 RID: 9769
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__4;

			// Token: 0x0400262A RID: 9770
			private static readonly IntPtr NativeFieldInfoPtr__ms_5__5;

			// Token: 0x0400262B RID: 9771
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400262C RID: 9772
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400262D RID: 9773
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
