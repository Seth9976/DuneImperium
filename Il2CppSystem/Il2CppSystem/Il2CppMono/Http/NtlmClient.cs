using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppMono.Http
{
	// Token: 0x02000026 RID: 38
	public class NtlmClient : Object
	{
		// Token: 0x06000240 RID: 576 RVA: 0x000239A4 File Offset: 0x00021BA4
		// Note: this type is marked as 'beforefieldinit'.
		static NtlmClient()
		{
			Il2CppClassPointerStore<NtlmClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Http", "NtlmClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr);
			NtlmClient.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, "cache");
			NtlmClient.NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100663693);
			NtlmClient.NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100663694);
			NtlmClient.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100663695);
			NtlmClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, 100663696);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00023A38 File Offset: 0x00021C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429298, XrefRangeEnd = 429344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00023AAC File Offset: 0x00021CAC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00023B10 File Offset: 0x00021D10
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429344, XrefRangeEnd = 429346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00023B48 File Offset: 0x00021D48
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NtlmClient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002D68 File Offset: 0x00000F68
		public NtlmClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00023B84 File Offset: 0x00021D84
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002D71 File Offset: 0x00000F71
		public unsafe static ConditionalWeakTable<HttpWebRequest, NtlmSession> cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NtlmClient.NativeFieldInfoPtr_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<HttpWebRequest, NtlmSession>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NtlmClient.NativeFieldInfoPtr_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Virtual_Final_New_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Virtual_Final_New_Authorization_WebRequest_ICredentials_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002A5 RID: 677
		[ObfuscatedName("Mono.Http.NtlmClient+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002AC3 RID: 10947 RVA: 0x000BEF30 File Offset: 0x000BD130
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NtlmClient>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr);
				NtlmClient.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr, "<>9");
				NtlmClient.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr, "<>9__1_0");
				NtlmClient.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr, 100663699);
				NtlmClient.__c.NativeMethodInfoPtr__Authenticate_b__1_0_Internal_NtlmSession_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr, 100663700);
			}

			// Token: 0x06002AC4 RID: 10948 RVA: 0x000BEFAC File Offset: 0x000BD1AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NtlmClient.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AC5 RID: 10949 RVA: 0x000BEFE8 File Offset: 0x000BD1E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429294, XrefRangeEnd = 429298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NtlmSession _Authenticate_b__1_0(HttpWebRequest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmClient.__c.NativeMethodInfoPtr__Authenticate_b__1_0_Internal_NtlmSession_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NtlmSession>(intPtr3) : null;
				}
			}

			// Token: 0x06002AC6 RID: 10950 RVA: 0x00012F77 File Offset: 0x00011177
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D89 RID: 3465
			// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x000BF038 File Offset: 0x000BD238
			// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x00012F80 File Offset: 0x00011180
			public unsafe static NtlmClient.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NtlmClient.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NtlmClient.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NtlmClient.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D8A RID: 3466
			// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x000BF060 File Offset: 0x000BD260
			// (set) Token: 0x06002ACA RID: 10954 RVA: 0x00012F92 File Offset: 0x00011192
			public unsafe static ConditionalWeakTable<HttpWebRequest, NtlmSession>.CreateValueCallback __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NtlmClient.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<HttpWebRequest, NtlmSession>.CreateValueCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NtlmClient.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021B9 RID: 8633
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040021BA RID: 8634
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040021BB RID: 8635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021BC RID: 8636
			private static readonly IntPtr NativeMethodInfoPtr__Authenticate_b__1_0_Internal_NtlmSession_HttpWebRequest_0;
		}
	}
}
