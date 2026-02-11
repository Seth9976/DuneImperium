using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppSystem.Net
{
	// Token: 0x020001E5 RID: 485
	[Serializable]
	public class WebProxy : Object
	{
		// Token: 0x06001E47 RID: 7751 RVA: 0x00091ADC File Offset: 0x0008FCDC
		// Note: this type is marked as 'beforefieldinit'.
		static WebProxy()
		{
			Il2CppClassPointerStore<WebProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebProxy>.NativeClassPtr);
			WebProxy.NativeFieldInfoPtr__UseRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_UseRegistry");
			WebProxy.NativeFieldInfoPtr__BypassOnLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_BypassOnLocal");
			WebProxy.NativeFieldInfoPtr_m_EnableAutoproxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "m_EnableAutoproxy");
			WebProxy.NativeFieldInfoPtr__ProxyAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_ProxyAddress");
			WebProxy.NativeFieldInfoPtr__BypassList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_BypassList");
			WebProxy.NativeFieldInfoPtr__Credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_Credentials");
			WebProxy.NativeFieldInfoPtr__RegExBypassList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_RegExBypassList");
			WebProxy.NativeFieldInfoPtr__ProxyHostAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_ProxyHostAddresses");
			WebProxy.NativeFieldInfoPtr_m_ScriptEngine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "m_ScriptEngine");
			WebProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667909);
			WebProxy.NativeMethodInfoPtr__ctor_Public_Void_Uri_Boolean_Il2CppStringArray_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667910);
			WebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667911);
			WebProxy.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667912);
			WebProxy.NativeMethodInfoPtr_set_UseDefaultCredentials_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667913);
			WebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667914);
			WebProxy.NativeMethodInfoPtr_UpdateRegExList_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667915);
			WebProxy.NativeMethodInfoPtr_IsMatchInBypassList_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667916);
			WebProxy.NativeMethodInfoPtr_IsLocal_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667917);
			WebProxy.NativeMethodInfoPtr_IsLocalInProxyHash_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667918);
			WebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667919);
			WebProxy.NativeMethodInfoPtr_IsBypassedManual_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667920);
			WebProxy.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667921);
			WebProxy.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667922);
			WebProxy.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667923);
			WebProxy.NativeMethodInfoPtr_get_ScriptEngine_Internal_get_AutoWebProxyScriptEngine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667924);
			WebProxy.NativeMethodInfoPtr_CreateDefaultProxy_Public_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667925);
			WebProxy.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667926);
			WebProxy.NativeMethodInfoPtr_UnsafeUpdateFromRegistry_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667927);
			WebProxy.NativeMethodInfoPtr_GetProxyAuto_Private_Boolean_Uri_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667928);
			WebProxy.NativeMethodInfoPtr_IsBypassedAuto_Private_Boolean_Uri_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667929);
			WebProxy.NativeMethodInfoPtr_AreAllBypassed_Private_Static_Boolean_IEnumerable_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667930);
			WebProxy.NativeMethodInfoPtr_ProxyUri_Private_Static_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100667931);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00091D8C File Offset: 0x0008FF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478233, XrefRangeEnd = 478237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00091DC8 File Offset: 0x0008FFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478237, XrefRangeEnd = 478246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy(Uri Address, bool BypassOnLocal, Il2CppStringArray BypassList, ICredentials Credentials)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref BypassOnLocal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(BypassList);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Public_Void_Uri_Boolean_Il2CppStringArray_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x00091E48 File Offset: 0x00090048
		public unsafe virtual ICredentials Credentials
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00091E88 File Offset: 0x00090088
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x00091EC4 File Offset: 0x000900C4
		public unsafe bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478246, XrefRangeEnd = 478248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478248, XrefRangeEnd = 478255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_set_UseDefaultCredentials_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00091F04 File Offset: 0x00090104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478255, XrefRangeEnd = 478268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Uri GetProxy(Uri destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00091F54 File Offset: 0x00090154
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 478281, RefRangeEnd = 478284, XrefRangeStart = 478268, XrefRangeEnd = 478281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRegExList(bool canThrow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canThrow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_UpdateRegExList_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00091F94 File Offset: 0x00090194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478284, XrefRangeEnd = 478301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatchInBypassList(Uri input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsMatchInBypassList_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00091FE4 File Offset: 0x000901E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478312, RefRangeEnd = 478313, XrefRangeStart = 478301, XrefRangeEnd = 478312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocal(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsLocal_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00092034 File Offset: 0x00090234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478313, XrefRangeEnd = 478319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalInProxyHash(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsLocalInProxyHash_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00092084 File Offset: 0x00090284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478319, XrefRangeEnd = 478328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsBypassed(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000920D4 File Offset: 0x000902D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478357, RefRangeEnd = 478358, XrefRangeStart = 478328, XrefRangeEnd = 478357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBypassedManual(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsBypassedManual_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00092124 File Offset: 0x00090324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478358, XrefRangeEnd = 478400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00092188 File Offset: 0x00090388
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x000921E4 File Offset: 0x000903E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478400, XrefRangeEnd = 478419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebProxy.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x00092248 File Offset: 0x00090448
		public unsafe AutoWebProxyScriptEngine ScriptEngine
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_get_ScriptEngine_Internal_get_AutoWebProxyScriptEngine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AutoWebProxyScriptEngine>(intPtr3) : null;
			}
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00092288 File Offset: 0x00090488
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 478423, RefRangeEnd = 478426, XrefRangeStart = 478419, XrefRangeEnd = 478423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy CreateDefaultProxy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_CreateDefaultProxy_Public_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x000922BC File Offset: 0x000904BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478426, XrefRangeEnd = 478427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy(bool enableAutoproxy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enableAutoproxy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00092304 File Offset: 0x00090504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsafeUpdateFromRegistry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_UnsafeUpdateFromRegistry_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00092338 File Offset: 0x00090538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478449, RefRangeEnd = 478450, XrefRangeStart = 478428, XrefRangeEnd = 478449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetProxyAuto(Uri destination, out Uri proxyUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_GetProxyAuto_Private_Boolean_Uri_byref_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			proxyUri = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000923A8 File Offset: 0x000905A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478450, XrefRangeEnd = 478455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBypassedAuto(Uri destination, out bool isBypassed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isBypassed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsBypassedAuto_Private_Boolean_Uri_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00092404 File Offset: 0x00090604
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 478475, RefRangeEnd = 478478, XrefRangeStart = 478455, XrefRangeEnd = 478475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxies);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFirstOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_AreAllBypassed_Private_Static_Boolean_IEnumerable_1_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00092454 File Offset: 0x00090654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478478, XrefRangeEnd = 478485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri ProxyUri(string proxyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(proxyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_ProxyUri_Private_Static_Uri_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x0000CE07 File Offset: 0x0000B007
		public WebProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x00092498 File Offset: 0x00090698
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0000CE10 File Offset: 0x0000B010
		public unsafe bool _UseRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__UseRegistry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__UseRegistry)) = value;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x000924C0 File Offset: 0x000906C0
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0000CE2B File Offset: 0x0000B02B
		public unsafe bool _BypassOnLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassOnLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassOnLocal)) = value;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000924E8 File Offset: 0x000906E8
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x0000CE46 File Offset: 0x0000B046
		public unsafe bool m_EnableAutoproxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_EnableAutoproxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_EnableAutoproxy)) = value;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x00092510 File Offset: 0x00090710
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0000CE61 File Offset: 0x0000B061
		public unsafe Uri _ProxyAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyAddress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyAddress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x00092540 File Offset: 0x00090740
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0000CE80 File Offset: 0x0000B080
		public unsafe ArrayList _BypassList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x00092570 File Offset: 0x00090770
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x0000CE9F File Offset: 0x0000B09F
		public unsafe ICredentials _Credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__Credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__Credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x000925A0 File Offset: 0x000907A0
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0000CEBE File Offset: 0x0000B0BE
		public unsafe Il2CppReferenceArray<Regex> _RegExBypassList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__RegExBypassList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Regex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__RegExBypassList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x000925D0 File Offset: 0x000907D0
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x0000CEDD File Offset: 0x0000B0DD
		public unsafe Hashtable _ProxyHostAddresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyHostAddresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyHostAddresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x00092600 File Offset: 0x00090800
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		public unsafe AutoWebProxyScriptEngine m_ScriptEngine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_ScriptEngine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoWebProxyScriptEngine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_ScriptEngine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeFieldInfoPtr__UseRegistry;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeFieldInfoPtr__BypassOnLocal;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableAutoproxy;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeFieldInfoPtr__ProxyAddress;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeFieldInfoPtr__BypassList;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeFieldInfoPtr__Credentials;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeFieldInfoPtr__RegExBypassList;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeFieldInfoPtr__ProxyHostAddresses;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeFieldInfoPtr_m_ScriptEngine;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Boolean_Il2CppStringArray_ICredentials_0;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_get_Boolean_0;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeMethodInfoPtr_set_UseDefaultCredentials_Public_set_Void_Boolean_0;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRegExList_Private_Void_Boolean_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchInBypassList_Private_Boolean_Uri_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_IsLocal_Private_Boolean_Uri_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalInProxyHash_Private_Boolean_Uri_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassedManual_Private_Boolean_Uri_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_get_ScriptEngine_Internal_get_AutoWebProxyScriptEngine_0;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultProxy_Public_Static_IWebProxy_0;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeUpdateFromRegistry_Internal_Void_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyAuto_Private_Boolean_Uri_byref_Uri_0;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassedAuto_Private_Boolean_Uri_byref_Boolean_0;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr_AreAllBypassed_Private_Static_Boolean_IEnumerable_1_String_Boolean_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_ProxyUri_Private_Static_Uri_String_0;
	}
}
