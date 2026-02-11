using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000090 RID: 144
	public class XmlDownloadManager : Object
	{
		// Token: 0x060010DC RID: 4316 RVA: 0x00060320 File Offset: 0x0005E520
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDownloadManager()
		{
			Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlDownloadManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr);
			XmlDownloadManager.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, "connections");
			XmlDownloadManager.NativeMethodInfoPtr_GetStream_Internal_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100666097);
			XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStream_Private_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100666098);
			XmlDownloadManager.NativeMethodInfoPtr_Remove_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100666099);
			XmlDownloadManager.NativeMethodInfoPtr_GetStreamAsync_Internal_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100666100);
			XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStreamAsync_Private_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100666101);
			XmlDownloadManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, 100666102);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000603DC File Offset: 0x0005E5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381780, XrefRangeEnd = 381786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetStream_Internal_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00060464 File Offset: 0x0005E664
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381818, RefRangeEnd = 381820, XrefRangeStart = 381786, XrefRangeEnd = 381818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStream_Private_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x000604EC File Offset: 0x0005E6EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381826, RefRangeEnd = 381828, XrefRangeStart = 381820, XrefRangeEnd = 381826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(string host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_Remove_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00060530 File Offset: 0x0005E730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381859, RefRangeEnd = 381860, XrefRangeStart = 381828, XrefRangeEnd = 381859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetStreamAsync_Internal_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x000605B8 File Offset: 0x0005E7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381860, XrefRangeEnd = 381878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachePolicy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr_GetNonFileStreamAsync_Private_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Stream>>(intPtr3) : null;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00060640 File Offset: 0x0005E840
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDownloadManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00007575 File Offset: 0x00005775
		public XmlDownloadManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0006067C File Offset: 0x0005E87C
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x0000757E File Offset: 0x0000577E
		public unsafe Hashtable connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_GetStream_Internal_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_GetNonFileStream_Private_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_String_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_GetStreamAsync_Internal_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_GetNonFileStreamAsync_Private_Task_1_Stream_Uri_ICredentials_IWebProxy_RequestCachePolicy_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000244 RID: 580
		[ObfuscatedName("System.Xml.XmlDownloadManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600308C RID: 12428 RVA: 0x000DA9EC File Offset: 0x000D8BEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr);
				XmlDownloadManager.__c__DisplayClass4_0.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr, "uri");
				XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr, 100666103);
				XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__GetStreamAsync_b__0_Internal_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr, 100666104);
			}

			// Token: 0x0600308D RID: 12429 RVA: 0x000DAA54 File Offset: 0x000D8C54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDownloadManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600308E RID: 12430 RVA: 0x000DAA90 File Offset: 0x000D8C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381700, XrefRangeEnd = 381705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stream _GetStreamAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager.__c__DisplayClass4_0.NativeMethodInfoPtr__GetStreamAsync_b__0_Internal_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}

			// Token: 0x0600308F RID: 12431 RVA: 0x000145C6 File Offset: 0x000127C6
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001055 RID: 4181
			// (get) Token: 0x06003090 RID: 12432 RVA: 0x000DAAD0 File Offset: 0x000D8CD0
			// (set) Token: 0x06003091 RID: 12433 RVA: 0x000145CF File Offset: 0x000127CF
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.__c__DisplayClass4_0.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager.__c__DisplayClass4_0.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040025C3 RID: 9667
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x040025C4 RID: 9668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040025C5 RID: 9669
			private static readonly IntPtr NativeMethodInfoPtr__GetStreamAsync_b__0_Internal_Stream_0;
		}

		// Token: 0x02000245 RID: 581
		[ObfuscatedName("System.Xml.XmlDownloadManager+<GetNonFileStreamAsync>d__5")]
		public sealed class _GetNonFileStreamAsync_d__5 : ValueType
		{
			// Token: 0x06003092 RID: 12434 RVA: 0x000DAB00 File Offset: 0x000D8D00
			// Note: this type is marked as 'beforefieldinit'.
			static _GetNonFileStreamAsync_d__5()
			{
				Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlDownloadManager>.NativeClassPtr, "<GetNonFileStreamAsync>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr);
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>1__state");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>t__builder");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "uri");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "credentials");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "proxy");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_cachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "cachePolicy");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>4__this");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr__req_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<req>5__2");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, "<>u__1");
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, 100666105);
				XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr, 100666106);
			}

			// Token: 0x06003093 RID: 12435 RVA: 0x000DAC08 File Offset: 0x000D8E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381705, XrefRangeEnd = 381774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003094 RID: 12436 RVA: 0x000DAC40 File Offset: 0x000D8E40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381774, XrefRangeEnd = 381780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003095 RID: 12437 RVA: 0x000145EE File Offset: 0x000127EE
			public _GetNonFileStreamAsync_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003096 RID: 12438 RVA: 0x000145F7 File Offset: 0x000127F7
			public _GetNonFileStreamAsync_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDownloadManager._GetNonFileStreamAsync_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x17001056 RID: 4182
			// (get) Token: 0x06003097 RID: 12439 RVA: 0x000DAC88 File Offset: 0x000D8E88
			// (set) Token: 0x06003098 RID: 12440 RVA: 0x00014609 File Offset: 0x00012809
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001057 RID: 4183
			// (get) Token: 0x06003099 RID: 12441 RVA: 0x000DACB0 File Offset: 0x000D8EB0
			// (set) Token: 0x0600309A RID: 12442 RVA: 0x00014624 File Offset: 0x00012824
			public AsyncTaskMethodBuilder<Stream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Stream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Stream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001058 RID: 4184
			// (get) Token: 0x0600309B RID: 12443 RVA: 0x000DACE0 File Offset: 0x000D8EE0
			// (set) Token: 0x0600309C RID: 12444 RVA: 0x00014652 File Offset: 0x00012852
			public unsafe Uri uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_uri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001059 RID: 4185
			// (get) Token: 0x0600309D RID: 12445 RVA: 0x000DAD10 File Offset: 0x000D8F10
			// (set) Token: 0x0600309E RID: 12446 RVA: 0x00014671 File Offset: 0x00012871
			public unsafe ICredentials credentials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_credentials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105A RID: 4186
			// (get) Token: 0x0600309F RID: 12447 RVA: 0x000DAD40 File Offset: 0x000D8F40
			// (set) Token: 0x060030A0 RID: 12448 RVA: 0x00014690 File Offset: 0x00012890
			public unsafe IWebProxy proxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_proxy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105B RID: 4187
			// (get) Token: 0x060030A1 RID: 12449 RVA: 0x000DAD70 File Offset: 0x000D8F70
			// (set) Token: 0x060030A2 RID: 12450 RVA: 0x000146AF File Offset: 0x000128AF
			public unsafe RequestCachePolicy cachePolicy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_cachePolicy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr_cachePolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105C RID: 4188
			// (get) Token: 0x060030A3 RID: 12451 RVA: 0x000DADA0 File Offset: 0x000D8FA0
			// (set) Token: 0x060030A4 RID: 12452 RVA: 0x000146CE File Offset: 0x000128CE
			public unsafe XmlDownloadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDownloadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105D RID: 4189
			// (get) Token: 0x060030A5 RID: 12453 RVA: 0x000DADD0 File Offset: 0x000D8FD0
			// (set) Token: 0x060030A6 RID: 12454 RVA: 0x000146ED File Offset: 0x000128ED
			public unsafe WebRequest _req_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr__req_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr__req_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105E RID: 4190
			// (get) Token: 0x060030A7 RID: 12455 RVA: 0x000DAE00 File Offset: 0x000D9000
			// (set) Token: 0x060030A8 RID: 12456 RVA: 0x0001470C File Offset: 0x0001290C
			public ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDownloadManager._GetNonFileStreamAsync_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<WebResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040025C6 RID: 9670
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040025C7 RID: 9671
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040025C8 RID: 9672
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x040025C9 RID: 9673
			private static readonly IntPtr NativeFieldInfoPtr_credentials;

			// Token: 0x040025CA RID: 9674
			private static readonly IntPtr NativeFieldInfoPtr_proxy;

			// Token: 0x040025CB RID: 9675
			private static readonly IntPtr NativeFieldInfoPtr_cachePolicy;

			// Token: 0x040025CC RID: 9676
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040025CD RID: 9677
			private static readonly IntPtr NativeFieldInfoPtr__req_5__2;

			// Token: 0x040025CE RID: 9678
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040025CF RID: 9679
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040025D0 RID: 9680
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
