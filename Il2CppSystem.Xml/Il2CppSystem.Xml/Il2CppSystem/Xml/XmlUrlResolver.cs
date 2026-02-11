using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Cache;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml
{
	// Token: 0x020000A7 RID: 167
	public class XmlUrlResolver : XmlResolver
	{
		// Token: 0x060011D8 RID: 4568 RVA: 0x000650A4 File Offset: 0x000632A4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlUrlResolver()
		{
			Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlUrlResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr);
			XmlUrlResolver.NativeFieldInfoPtr_s_DownloadManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "s_DownloadManager");
			XmlUrlResolver.NativeFieldInfoPtr__credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "_credentials");
			XmlUrlResolver.NativeFieldInfoPtr__proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "_proxy");
			XmlUrlResolver.NativeFieldInfoPtr__cachePolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "_cachePolicy");
			XmlUrlResolver.NativeMethodInfoPtr_get_DownloadManager_Private_Static_get_XmlDownloadManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100666255);
			XmlUrlResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100666256);
			XmlUrlResolver.NativeMethodInfoPtr_GetEntity_Public_Virtual_Object_Uri_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100666257);
			XmlUrlResolver.NativeMethodInfoPtr_ResolveUri_Public_Virtual_Uri_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100666258);
			XmlUrlResolver.NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_Task_1_Object_Uri_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, 100666259);
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x00065188 File Offset: 0x00063388
		public unsafe static XmlDownloadManager DownloadManager
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 383204, RefRangeEnd = 383206, XrefRangeStart = 383194, XrefRangeEnd = 383204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver.NativeMethodInfoPtr_get_DownloadManager_Private_Static_get_XmlDownloadManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDownloadManager>(intPtr3) : null;
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x000651BC File Offset: 0x000633BC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUrlResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x000651F8 File Offset: 0x000633F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383206, XrefRangeEnd = 383234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(role);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ofObjectToReturn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUrlResolver.NativeMethodInfoPtr_GetEntity_Public_Virtual_Object_Uri_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00065278 File Offset: 0x00063478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383234, XrefRangeEnd = 383235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUrlResolver.NativeMethodInfoPtr_ResolveUri_Public_Virtual_Uri_Uri_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x000652E8 File Offset: 0x000634E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383235, XrefRangeEnd = 383251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(role);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ofObjectToReturn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUrlResolver.NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_Task_1_Object_Uri_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00007992 File Offset: 0x00005B92
		public XmlUrlResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x00065368 File Offset: 0x00063568
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x0000799B File Offset: 0x00005B9B
		public unsafe static Object s_DownloadManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlUrlResolver.NativeFieldInfoPtr_s_DownloadManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlUrlResolver.NativeFieldInfoPtr_s_DownloadManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x00065390 File Offset: 0x00063590
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x000079AD File Offset: 0x00005BAD
		public unsafe ICredentials _credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x000653C0 File Offset: 0x000635C0
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x000079CC File Offset: 0x00005BCC
		public unsafe IWebProxy _proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000653F0 File Offset: 0x000635F0
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x000079EB File Offset: 0x00005BEB
		public unsafe RequestCachePolicy _cachePolicy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__cachePolicy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachePolicy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver.NativeFieldInfoPtr__cachePolicy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeFieldInfoPtr_s_DownloadManager;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeFieldInfoPtr__credentials;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeFieldInfoPtr__proxy;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeFieldInfoPtr__cachePolicy;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr_get_DownloadManager_Private_Static_get_XmlDownloadManager_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr_GetEntity_Public_Virtual_Object_Uri_String_Type_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_ResolveUri_Public_Virtual_Uri_Uri_String_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_Task_1_Object_Uri_String_Type_0;

		// Token: 0x02000248 RID: 584
		[ObfuscatedName("System.Xml.XmlUrlResolver+<GetEntityAsync>d__15")]
		public sealed class _GetEntityAsync_d__15 : ValueType
		{
			// Token: 0x060030BC RID: 12476 RVA: 0x000DB0A0 File Offset: 0x000D92A0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEntityAsync_d__15()
			{
				Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlUrlResolver>.NativeClassPtr, "<GetEntityAsync>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr);
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>1__state");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>t__builder");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_ofObjectToReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "ofObjectToReturn");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_absoluteUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "absoluteUri");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>4__this");
				XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, "<>u__1");
				XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, 100666260);
				XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr, 100666261);
			}

			// Token: 0x060030BD RID: 12477 RVA: 0x000DB16C File Offset: 0x000D936C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383152, XrefRangeEnd = 383188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030BE RID: 12478 RVA: 0x000DB1A4 File Offset: 0x000D93A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383188, XrefRangeEnd = 383194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUrlResolver._GetEntityAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030BF RID: 12479 RVA: 0x00014837 File Offset: 0x00012A37
			public _GetEntityAsync_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060030C0 RID: 12480 RVA: 0x00014840 File Offset: 0x00012A40
			public _GetEntityAsync_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUrlResolver._GetEntityAsync_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x17001063 RID: 4195
			// (get) Token: 0x060030C1 RID: 12481 RVA: 0x000DB1EC File Offset: 0x000D93EC
			// (set) Token: 0x060030C2 RID: 12482 RVA: 0x00014852 File Offset: 0x00012A52
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001064 RID: 4196
			// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000DB214 File Offset: 0x000D9414
			// (set) Token: 0x060030C4 RID: 12484 RVA: 0x0001486D File Offset: 0x00012A6D
			public AsyncTaskMethodBuilder<Object> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001065 RID: 4197
			// (get) Token: 0x060030C5 RID: 12485 RVA: 0x000DB244 File Offset: 0x000D9444
			// (set) Token: 0x060030C6 RID: 12486 RVA: 0x0001489B File Offset: 0x00012A9B
			public unsafe Type ofObjectToReturn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_ofObjectToReturn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_ofObjectToReturn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001066 RID: 4198
			// (get) Token: 0x060030C7 RID: 12487 RVA: 0x000DB274 File Offset: 0x000D9474
			// (set) Token: 0x060030C8 RID: 12488 RVA: 0x000148BA File Offset: 0x00012ABA
			public unsafe Uri absoluteUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_absoluteUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr_absoluteUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001067 RID: 4199
			// (get) Token: 0x060030C9 RID: 12489 RVA: 0x000DB2A4 File Offset: 0x000D94A4
			// (set) Token: 0x060030CA RID: 12490 RVA: 0x000148D9 File Offset: 0x00012AD9
			public unsafe XmlUrlResolver __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlUrlResolver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001068 RID: 4200
			// (get) Token: 0x060030CB RID: 12491 RVA: 0x000DB2D4 File Offset: 0x000D94D4
			// (set) Token: 0x060030CC RID: 12492 RVA: 0x000148F8 File Offset: 0x00012AF8
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUrlResolver._GetEntityAsync_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040025D8 RID: 9688
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040025D9 RID: 9689
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040025DA RID: 9690
			private static readonly IntPtr NativeFieldInfoPtr_ofObjectToReturn;

			// Token: 0x040025DB RID: 9691
			private static readonly IntPtr NativeFieldInfoPtr_absoluteUri;

			// Token: 0x040025DC RID: 9692
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040025DD RID: 9693
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040025DE RID: 9694
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040025DF RID: 9695
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
