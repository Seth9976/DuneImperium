using System;
using Google.Apis.Services;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Media
{
	// Token: 0x02000017 RID: 23
	public static class MediaApiErrorHandling : Object
	{
		// Token: 0x0600018C RID: 396 RVA: 0x0000B00C File Offset: 0x0000920C
		// Note: this type is marked as 'beforefieldinit'.
		static MediaApiErrorHandling()
		{
			Il2CppClassPointerStore<MediaApiErrorHandling>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Media", "MediaApiErrorHandling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaApiErrorHandling>.NativeClassPtr);
			MediaApiErrorHandling.NativeMethodInfoPtr_ExceptionForResponseAsync_Internal_Static_Task_1_GoogleApiException_IClientService_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaApiErrorHandling>.NativeClassPtr, 100663636);
			MediaApiErrorHandling.NativeMethodInfoPtr_ExceptionForResponseAsync_Internal_Static_Task_1_GoogleApiException_ISerializer_String_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaApiErrorHandling>.NativeClassPtr, 100663637);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000B064 File Offset: 0x00009264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199088, XrefRangeEnd = 1199095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<GoogleApiException> ExceptionForResponseAsync(IClientService service, HttpResponseMessage response)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaApiErrorHandling.NativeMethodInfoPtr_ExceptionForResponseAsync_Internal_Static_Task_1_GoogleApiException_IClientService_HttpResponseMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GoogleApiException>>(intPtr3) : null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000B0BC File Offset: 0x000092BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1199111, RefRangeEnd = 1199116, XrefRangeStart = 1199095, XrefRangeEnd = 1199111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<GoogleApiException> ExceptionForResponseAsync(ISerializer serializer, string name, HttpResponseMessage response)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaApiErrorHandling.NativeMethodInfoPtr_ExceptionForResponseAsync_Internal_Static_Task_1_GoogleApiException_ISerializer_String_HttpResponseMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GoogleApiException>>(intPtr3) : null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000283D File Offset: 0x00000A3D
		public MediaApiErrorHandling(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionForResponseAsync_Internal_Static_Task_1_GoogleApiException_IClientService_HttpResponseMessage_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionForResponseAsync_Internal_Static_Task_1_GoogleApiException_ISerializer_String_HttpResponseMessage_0;

		// Token: 0x02000047 RID: 71
		[ObfuscatedName("Google.Apis.Media.MediaApiErrorHandling+<ExceptionForResponseAsync>d__1")]
		public sealed class _ExceptionForResponseAsync_d__1 : ValueType
		{
			// Token: 0x060003F4 RID: 1012 RVA: 0x00012290 File Offset: 0x00010490
			// Note: this type is marked as 'beforefieldinit'.
			static _ExceptionForResponseAsync_d__1()
			{
				Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MediaApiErrorHandling>.NativeClassPtr, "<ExceptionForResponseAsync>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr);
				MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr, "<>1__state");
				MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr, "<>t__builder");
				MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr, "response");
				MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr_serializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr, "serializer");
				MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr, "name");
				MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr, "<>u__1");
				MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr, 100663638);
				MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr, 100663639);
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x0001235C File Offset: 0x0001055C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199044, XrefRangeEnd = 1199082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x00012394 File Offset: 0x00010594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199082, XrefRangeEnd = 1199088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x00004355 File Offset: 0x00002555
			public _ExceptionForResponseAsync_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x0000435E File Offset: 0x0000255E
			public _ExceptionForResponseAsync_d__1()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaApiErrorHandling._ExceptionForResponseAsync_d__1>.NativeClassPtr))
			{
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000123DC File Offset: 0x000105DC
			// (set) Token: 0x060003FA RID: 1018 RVA: 0x00004370 File Offset: 0x00002570
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x060003FB RID: 1019 RVA: 0x00012404 File Offset: 0x00010604
			// (set) Token: 0x060003FC RID: 1020 RVA: 0x0000438B File Offset: 0x0000258B
			public AsyncTaskMethodBuilder<GoogleApiException> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<GoogleApiException>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<GoogleApiException>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<GoogleApiException>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x060003FD RID: 1021 RVA: 0x00012434 File Offset: 0x00010634
			// (set) Token: 0x060003FE RID: 1022 RVA: 0x000043B9 File Offset: 0x000025B9
			public unsafe HttpResponseMessage response
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr_response);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x060003FF RID: 1023 RVA: 0x00012464 File Offset: 0x00010664
			// (set) Token: 0x06000400 RID: 1024 RVA: 0x000043D8 File Offset: 0x000025D8
			public unsafe ISerializer serializer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr_serializer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr_serializer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x06000401 RID: 1025 RVA: 0x00012494 File Offset: 0x00010694
			// (set) Token: 0x06000402 RID: 1026 RVA: 0x000043F7 File Offset: 0x000025F7
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x000124BC File Offset: 0x000106BC
			// (set) Token: 0x06000404 RID: 1028 RVA: 0x00004416 File Offset: 0x00002616
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaApiErrorHandling._ExceptionForResponseAsync_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400027E RID: 638
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400027F RID: 639
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000280 RID: 640
			private static readonly IntPtr NativeFieldInfoPtr_response;

			// Token: 0x04000281 RID: 641
			private static readonly IntPtr NativeFieldInfoPtr_serializer;

			// Token: 0x04000282 RID: 642
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04000283 RID: 643
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000284 RID: 644
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000285 RID: 645
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
