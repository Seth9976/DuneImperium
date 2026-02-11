using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net
{
	// Token: 0x020001F6 RID: 502
	public sealed class EndPointListener : Object
	{
		// Token: 0x06001F0E RID: 7950 RVA: 0x00094D58 File Offset: 0x00092F58
		// Note: this type is marked as 'beforefieldinit'.
		static EndPointListener()
		{
			Il2CppClassPointerStore<EndPointListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "EndPointListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr);
			EndPointListener.NativeFieldInfoPtr_listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, "listener");
			EndPointListener.NativeFieldInfoPtr_endpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, "endpoint");
			EndPointListener.NativeFieldInfoPtr_sock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, "sock");
			EndPointListener.NativeFieldInfoPtr_prefixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, "prefixes");
			EndPointListener.NativeFieldInfoPtr_unhandled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, "unhandled");
			EndPointListener.NativeFieldInfoPtr_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, "all");
			EndPointListener.NativeFieldInfoPtr_cert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, "cert");
			EndPointListener.NativeFieldInfoPtr_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, "secure");
			EndPointListener.NativeFieldInfoPtr_unregistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, "unregistered");
			EndPointListener.NativeMethodInfoPtr__ctor_Public_Void_HttpListener_IPAddress_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668026);
			EndPointListener.NativeMethodInfoPtr_get_Listener_Internal_get_HttpListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668027);
			EndPointListener.NativeMethodInfoPtr_Accept_Private_Static_Void_Socket_SocketAsyncEventArgs_byref_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668028);
			EndPointListener.NativeMethodInfoPtr_ProcessAccept_Private_Static_Void_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668029);
			EndPointListener.NativeMethodInfoPtr_OnAccept_Private_Static_Void_Object_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668030);
			EndPointListener.NativeMethodInfoPtr_RemoveConnection_Internal_Void_HttpConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668031);
			EndPointListener.NativeMethodInfoPtr_BindContext_Public_Boolean_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668032);
			EndPointListener.NativeMethodInfoPtr_UnbindContext_Public_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668033);
			EndPointListener.NativeMethodInfoPtr_SearchListener_Private_HttpListener_Uri_byref_ListenerPrefix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668034);
			EndPointListener.NativeMethodInfoPtr_MatchFromList_Private_HttpListener_String_String_ArrayList_byref_ListenerPrefix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668035);
			EndPointListener.NativeMethodInfoPtr_AddSpecial_Private_Void_ArrayList_ListenerPrefix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668036);
			EndPointListener.NativeMethodInfoPtr_RemoveSpecial_Private_Boolean_ArrayList_ListenerPrefix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668037);
			EndPointListener.NativeMethodInfoPtr_CheckIfRemove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668038);
			EndPointListener.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668039);
			EndPointListener.NativeMethodInfoPtr_AddPrefix_Public_Void_ListenerPrefix_HttpListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668040);
			EndPointListener.NativeMethodInfoPtr_RemovePrefix_Public_Void_ListenerPrefix_HttpListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr, 100668041);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00094F7C File Offset: 0x0009317C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479541, RefRangeEnd = 479542, XrefRangeStart = 479499, XrefRangeEnd = 479541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndPointListener(HttpListener listener, IPAddress addr, int port, bool secure)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndPointListener>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(addr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr__ctor_Public_Void_HttpListener_IPAddress_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x00094FF8 File Offset: 0x000931F8
		public unsafe HttpListener Listener
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_get_Listener_Internal_get_HttpListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpListener>(intPtr3) : null;
			}
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00095038 File Offset: 0x00093238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479545, RefRangeEnd = 479547, XrefRangeStart = 479542, XrefRangeEnd = 479545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Accept(Socket socket, SocketAsyncEventArgs e, ref Socket accepted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(accepted);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_Accept_Private_Static_Void_Socket_SocketAsyncEventArgs_byref_Socket_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			accepted = ((intPtr4 == 0) ? null : new Socket(intPtr4));
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x000950A8 File Offset: 0x000932A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479562, RefRangeEnd = 479564, XrefRangeStart = 479547, XrefRangeEnd = 479562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessAccept(SocketAsyncEventArgs args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_ProcessAccept_Private_Static_Void_SocketAsyncEventArgs_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x000950E0 File Offset: 0x000932E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479564, XrefRangeEnd = 479565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnAccept(Object sender, SocketAsyncEventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_OnAccept_Private_Static_Void_Object_SocketAsyncEventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00095128 File Offset: 0x00093328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479572, RefRangeEnd = 479573, XrefRangeStart = 479565, XrefRangeEnd = 479572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveConnection(HttpConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_RemoveConnection_Internal_Void_HttpConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x0009516C File Offset: 0x0009336C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479573, XrefRangeEnd = 479576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BindContext(HttpListenerContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_BindContext_Public_Boolean_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000951BC File Offset: 0x000933BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479576, XrefRangeEnd = 479577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnbindContext(HttpListenerContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_UnbindContext_Public_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00095200 File Offset: 0x00093400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479629, RefRangeEnd = 479630, XrefRangeStart = 479577, XrefRangeEnd = 479629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListener SearchListener(Uri uri, out ListenerPrefix prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_SearchListener_Private_HttpListener_Uri_byref_ListenerPrefix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			prefix = ((intPtr4 == 0) ? null : new ListenerPrefix(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<HttpListener>(intPtr5) : null;
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00095274 File Offset: 0x00093474
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 479651, RefRangeEnd = 479655, XrefRangeStart = 479630, XrefRangeEnd = 479651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListener MatchFromList(string host, string path, ArrayList list, out ListenerPrefix prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_MatchFromList_Private_HttpListener_String_String_ArrayList_byref_ListenerPrefix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			prefix = ((intPtr4 == 0) ? null : new ListenerPrefix(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<HttpListener>(intPtr5) : null;
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x0009530C File Offset: 0x0009350C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479655, XrefRangeEnd = 479671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpecial(ArrayList coll, ListenerPrefix prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_AddSpecial_Private_Void_ArrayList_ListenerPrefix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00095360 File Offset: 0x00093560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479671, XrefRangeEnd = 479674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveSpecial(ArrayList coll, ListenerPrefix prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_RemoveSpecial_Private_Boolean_ArrayList_ListenerPrefix_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x000953C0 File Offset: 0x000935C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479678, RefRangeEnd = 479679, XrefRangeStart = 479674, XrefRangeEnd = 479678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIfRemove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_CheckIfRemove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x000953F4 File Offset: 0x000935F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479711, RefRangeEnd = 479712, XrefRangeStart = 479679, XrefRangeEnd = 479711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00095428 File Offset: 0x00093628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479723, RefRangeEnd = 479724, XrefRangeStart = 479712, XrefRangeEnd = 479723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPrefix(ListenerPrefix prefix, HttpListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_AddPrefix_Public_Void_ListenerPrefix_HttpListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x0009547C File Offset: 0x0009367C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 479763, RefRangeEnd = 479764, XrefRangeStart = 479724, XrefRangeEnd = 479763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePrefix(ListenerPrefix prefix, HttpListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndPointListener.NativeMethodInfoPtr_RemovePrefix_Public_Void_ListenerPrefix_HttpListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x0000D2AF File Offset: 0x0000B4AF
		public EndPointListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x000954D0 File Offset: 0x000936D0
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		public unsafe HttpListener listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x00095500 File Offset: 0x00093700
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x0000D2D7 File Offset: 0x0000B4D7
		public unsafe IPEndPoint endpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_endpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_endpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00095530 File Offset: 0x00093730
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x0000D2F6 File Offset: 0x0000B4F6
		public unsafe Socket sock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_sock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_sock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x00095560 File Offset: 0x00093760
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x0000D315 File Offset: 0x0000B515
		public unsafe Hashtable prefixes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_prefixes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_prefixes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x00095590 File Offset: 0x00093790
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x0000D334 File Offset: 0x0000B534
		public unsafe ArrayList unhandled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_unhandled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_unhandled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x000955C0 File Offset: 0x000937C0
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x0000D353 File Offset: 0x0000B553
		public unsafe ArrayList all
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_all);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_all), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x000955F0 File Offset: 0x000937F0
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x0000D372 File Offset: 0x0000B572
		public unsafe X509Certificate cert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_cert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_cert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x00095620 File Offset: 0x00093820
		// (set) Token: 0x06001F2F RID: 7983 RVA: 0x0000D391 File Offset: 0x0000B591
		public unsafe bool secure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_secure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_secure)) = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00095648 File Offset: 0x00093848
		// (set) Token: 0x06001F31 RID: 7985 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		public unsafe Dictionary<HttpConnection, HttpConnection> unregistered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_unregistered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<HttpConnection, HttpConnection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndPointListener.NativeFieldInfoPtr_unregistered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeFieldInfoPtr_listener;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeFieldInfoPtr_endpoint;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeFieldInfoPtr_sock;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeFieldInfoPtr_prefixes;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeFieldInfoPtr_unhandled;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeFieldInfoPtr_all;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeFieldInfoPtr_cert;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeFieldInfoPtr_secure;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeFieldInfoPtr_unregistered;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpListener_IPAddress_Int32_Boolean_0;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr_get_Listener_Internal_get_HttpListener_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Private_Static_Void_Socket_SocketAsyncEventArgs_byref_Socket_0;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAccept_Private_Static_Void_SocketAsyncEventArgs_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_OnAccept_Private_Static_Void_Object_SocketAsyncEventArgs_0;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeMethodInfoPtr_RemoveConnection_Internal_Void_HttpConnection_0;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeMethodInfoPtr_BindContext_Public_Boolean_HttpListenerContext_0;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeMethodInfoPtr_UnbindContext_Public_Void_HttpListenerContext_0;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_SearchListener_Private_HttpListener_Uri_byref_ListenerPrefix_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_MatchFromList_Private_HttpListener_String_String_ArrayList_byref_ListenerPrefix_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr_AddSpecial_Private_Void_ArrayList_ListenerPrefix_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSpecial_Private_Boolean_ArrayList_ListenerPrefix_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfRemove_Private_Void_0;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr_AddPrefix_Public_Void_ListenerPrefix_HttpListener_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr_RemovePrefix_Public_Void_ListenerPrefix_HttpListener_0;
	}
}
