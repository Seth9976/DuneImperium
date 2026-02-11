using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Unity
{
	// Token: 0x0200000A RID: 10
	public static class UnityTls : Object
	{
		// Token: 0x06000044 RID: 68 RVA: 0x0001B808 File Offset: 0x00019A08
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTls()
		{
			Il2CppClassPointerStore<UnityTls>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls>.NativeClassPtr);
			UnityTls.NativeFieldInfoPtr_marshalledInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "marshalledInterface");
			UnityTls.NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663335);
			UnityTls.NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663336);
			UnityTls.NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663337);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0001B888 File Offset: 0x00019A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427028, XrefRangeEnd = 427029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetUnityTlsInterface()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		public unsafe static bool IsSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427029, XrefRangeEnd = 427030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		public unsafe static UnityTls.unitytls_interface_struct NativeInterface
		{
			[CallerCount(71)]
			[CachedScanResults(RefRangeStart = 427044, RefRangeEnd = 427115, XrefRangeStart = 427030, XrefRangeEnd = 427044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct>(intPtr3) : null;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000021A3 File Offset: 0x000003A3
		public UnityTls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0001B91C File Offset: 0x00019B1C
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000021AC File Offset: 0x000003AC
		public unsafe static UnityTls.unitytls_interface_struct marshalledInterface
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityTls.NativeFieldInfoPtr_marshalledInterface, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityTls.NativeFieldInfoPtr_marshalledInterface, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_marshalledInterface;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0;

		// Token: 0x02000282 RID: 642
		public enum unitytls_error_code : uint
		{
			// Token: 0x040020EF RID: 8431
			UNITYTLS_SUCCESS,
			// Token: 0x040020F0 RID: 8432
			UNITYTLS_INVALID_ARGUMENT,
			// Token: 0x040020F1 RID: 8433
			UNITYTLS_INVALID_FORMAT,
			// Token: 0x040020F2 RID: 8434
			UNITYTLS_INVALID_PASSWORD,
			// Token: 0x040020F3 RID: 8435
			UNITYTLS_INVALID_STATE,
			// Token: 0x040020F4 RID: 8436
			UNITYTLS_BUFFER_OVERFLOW,
			// Token: 0x040020F5 RID: 8437
			UNITYTLS_OUT_OF_MEMORY,
			// Token: 0x040020F6 RID: 8438
			UNITYTLS_INTERNAL_ERROR,
			// Token: 0x040020F7 RID: 8439
			UNITYTLS_NOT_SUPPORTED,
			// Token: 0x040020F8 RID: 8440
			UNITYTLS_ENTROPY_SOURCE_FAILED,
			// Token: 0x040020F9 RID: 8441
			UNITYTLS_STREAM_CLOSED,
			// Token: 0x040020FA RID: 8442
			UNITYTLS_USER_CUSTOM_ERROR_START = 1048576U,
			// Token: 0x040020FB RID: 8443
			UNITYTLS_USER_WOULD_BLOCK,
			// Token: 0x040020FC RID: 8444
			UNITYTLS_USER_READ_FAILED,
			// Token: 0x040020FD RID: 8445
			UNITYTLS_USER_WRITE_FAILED,
			// Token: 0x040020FE RID: 8446
			UNITYTLS_USER_UNKNOWN_ERROR,
			// Token: 0x040020FF RID: 8447
			UNITYTLS_USER_CUSTOM_ERROR_END = 2097152U
		}

		// Token: 0x02000283 RID: 643
		[StructLayout(2)]
		public struct unitytls_errorstate
		{
			// Token: 0x0600299D RID: 10653 RVA: 0x000BC594 File Offset: 0x000BA794
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_errorstate()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_errorstate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr);
				UnityTls.unitytls_errorstate.NativeFieldInfoPtr_magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, "magic");
				UnityTls.unitytls_errorstate.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, "code");
				UnityTls.unitytls_errorstate.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, "reserved");
			}

			// Token: 0x0600299E RID: 10654 RVA: 0x00011E38 File Offset: 0x00010038
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_errorstate>.NativeClassPtr, ref this));
			}

			// Token: 0x04002100 RID: 8448
			private static readonly IntPtr NativeFieldInfoPtr_magic;

			// Token: 0x04002101 RID: 8449
			private static readonly IntPtr NativeFieldInfoPtr_code;

			// Token: 0x04002102 RID: 8450
			private static readonly IntPtr NativeFieldInfoPtr_reserved;

			// Token: 0x04002103 RID: 8451
			[FieldOffset(0)]
			public uint magic;

			// Token: 0x04002104 RID: 8452
			[FieldOffset(4)]
			public UnityTls.unitytls_error_code code;

			// Token: 0x04002105 RID: 8453
			[FieldOffset(8)]
			public ulong reserved;
		}

		// Token: 0x02000284 RID: 644
		[StructLayout(2)]
		public struct unitytls_key
		{
			// Token: 0x0600299F RID: 10655 RVA: 0x00011E4A File Offset: 0x0001004A
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_key()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_key>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_key");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_key>.NativeClassPtr);
			}

			// Token: 0x060029A0 RID: 10656 RVA: 0x00011E6A File Offset: 0x0001006A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_key>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000285 RID: 645
		[StructLayout(2)]
		public struct unitytls_key_ref
		{
			// Token: 0x060029A1 RID: 10657 RVA: 0x00011E7C File Offset: 0x0001007C
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_key_ref()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_key_ref");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr);
				UnityTls.unitytls_key_ref.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr, "handle");
			}

			// Token: 0x060029A2 RID: 10658 RVA: 0x00011EB0 File Offset: 0x000100B0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_key_ref>.NativeClassPtr, ref this));
			}

			// Token: 0x04002106 RID: 8454
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x04002107 RID: 8455
			[FieldOffset(0)]
			public ulong handle;
		}

		// Token: 0x02000286 RID: 646
		[StructLayout(2)]
		public struct unitytls_x509_ref
		{
			// Token: 0x060029A3 RID: 10659 RVA: 0x00011EC2 File Offset: 0x000100C2
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509_ref()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509_ref");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr);
				UnityTls.unitytls_x509_ref.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr, "handle");
			}

			// Token: 0x060029A4 RID: 10660 RVA: 0x00011EF6 File Offset: 0x000100F6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509_ref>.NativeClassPtr, ref this));
			}

			// Token: 0x04002108 RID: 8456
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x04002109 RID: 8457
			[FieldOffset(0)]
			public ulong handle;
		}

		// Token: 0x02000287 RID: 647
		[StructLayout(2)]
		public struct unitytls_x509list
		{
			// Token: 0x060029A5 RID: 10661 RVA: 0x00011F08 File Offset: 0x00010108
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509list()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509list>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509list");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509list>.NativeClassPtr);
			}

			// Token: 0x060029A6 RID: 10662 RVA: 0x00011F28 File Offset: 0x00010128
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509list>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000288 RID: 648
		[StructLayout(2)]
		public struct unitytls_x509list_ref
		{
			// Token: 0x060029A7 RID: 10663 RVA: 0x00011F3A File Offset: 0x0001013A
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509list_ref()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509list_ref");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr);
				UnityTls.unitytls_x509list_ref.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr, "handle");
			}

			// Token: 0x060029A8 RID: 10664 RVA: 0x00011F6E File Offset: 0x0001016E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509list_ref>.NativeClassPtr, ref this));
			}

			// Token: 0x0400210A RID: 8458
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x0400210B RID: 8459
			[FieldOffset(0)]
			public ulong handle;
		}

		// Token: 0x02000289 RID: 649
		[Flags]
		public enum unitytls_x509verify_result : uint
		{
			// Token: 0x0400210D RID: 8461
			UNITYTLS_X509VERIFY_SUCCESS = 0U,
			// Token: 0x0400210E RID: 8462
			UNITYTLS_X509VERIFY_NOT_DONE = 2147483648U,
			// Token: 0x0400210F RID: 8463
			UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295U,
			// Token: 0x04002110 RID: 8464
			UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1U,
			// Token: 0x04002111 RID: 8465
			UNITYTLS_X509VERIFY_FLAG_REVOKED = 2U,
			// Token: 0x04002112 RID: 8466
			UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4U,
			// Token: 0x04002113 RID: 8467
			UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8U,
			// Token: 0x04002114 RID: 8468
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536U,
			// Token: 0x04002115 RID: 8469
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072U,
			// Token: 0x04002116 RID: 8470
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144U,
			// Token: 0x04002117 RID: 8471
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288U,
			// Token: 0x04002118 RID: 8472
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576U,
			// Token: 0x04002119 RID: 8473
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152U,
			// Token: 0x0400211A RID: 8474
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304U,
			// Token: 0x0400211B RID: 8475
			UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608U,
			// Token: 0x0400211C RID: 8476
			UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728U
		}

		// Token: 0x0200028A RID: 650
		public sealed class unitytls_x509verify_callback : MulticastDelegate
		{
			// Token: 0x060029A9 RID: 10665 RVA: 0x00011F80 File Offset: 0x00010180
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509verify_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509verify_callback");
				UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr, 100663338);
				UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr, 100663339);
			}

			// Token: 0x060029AA RID: 10666 RVA: 0x000BC5FC File Offset: 0x000BA7FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 426927, RefRangeEnd = 426929, XrefRangeStart = 426923, XrefRangeEnd = 426927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509verify_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_x509verify_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029AB RID: 10667 RVA: 0x000BC658 File Offset: 0x000BA858
			[CallerCount(0)]
			public unsafe UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cert;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060029AC RID: 10668 RVA: 0x00011FBE File Offset: 0x000101BE
			public unitytls_x509verify_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400211D RID: 8477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400211E RID: 8478
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0;
		}

		// Token: 0x0200028B RID: 651
		[StructLayout(2)]
		public struct unitytls_tlsctx
		{
			// Token: 0x060029AD RID: 10669 RVA: 0x00011FC7 File Offset: 0x000101C7
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx>.NativeClassPtr);
			}

			// Token: 0x060029AE RID: 10670 RVA: 0x00011FE7 File Offset: 0x000101E7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200028C RID: 652
		[StructLayout(2)]
		public struct unitytls_x509name
		{
			// Token: 0x060029AF RID: 10671 RVA: 0x00011FF9 File Offset: 0x000101F9
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_x509name()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_x509name>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509name");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_x509name>.NativeClassPtr);
			}

			// Token: 0x060029B0 RID: 10672 RVA: 0x00012019 File Offset: 0x00010219
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_x509name>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x0200028D RID: 653
		public enum unitytls_ciphersuite : uint
		{
			// Token: 0x04002120 RID: 8480
			UNITYTLS_CIPHERSUITE_INVALID = 16777215U
		}

		// Token: 0x0200028E RID: 654
		public enum unitytls_protocol : uint
		{
			// Token: 0x04002122 RID: 8482
			UNITYTLS_PROTOCOL_TLS_1_0,
			// Token: 0x04002123 RID: 8483
			UNITYTLS_PROTOCOL_TLS_1_1,
			// Token: 0x04002124 RID: 8484
			UNITYTLS_PROTOCOL_TLS_1_2,
			// Token: 0x04002125 RID: 8485
			UNITYTLS_PROTOCOL_INVALID
		}

		// Token: 0x0200028F RID: 655
		[StructLayout(2)]
		public struct unitytls_tlsctx_protocolrange
		{
			// Token: 0x060029B1 RID: 10673 RVA: 0x000BC6CC File Offset: 0x000BA8CC
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_protocolrange()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_protocolrange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr);
				UnityTls.unitytls_tlsctx_protocolrange.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr, "min");
				UnityTls.unitytls_tlsctx_protocolrange.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr, "max");
			}

			// Token: 0x060029B2 RID: 10674 RVA: 0x0001202B File Offset: 0x0001022B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_protocolrange>.NativeClassPtr, ref this));
			}

			// Token: 0x04002126 RID: 8486
			private static readonly IntPtr NativeFieldInfoPtr_min;

			// Token: 0x04002127 RID: 8487
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x04002128 RID: 8488
			[FieldOffset(0)]
			public UnityTls.unitytls_protocol min;

			// Token: 0x04002129 RID: 8489
			[FieldOffset(4)]
			public UnityTls.unitytls_protocol max;
		}

		// Token: 0x02000290 RID: 656
		public sealed class unitytls_tlsctx_write_callback : MulticastDelegate
		{
			// Token: 0x060029B3 RID: 10675 RVA: 0x0001203D File Offset: 0x0001023D
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_write_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_write_callback");
				UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr, 100663340);
				UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr, 100663341);
			}

			// Token: 0x060029B4 RID: 10676 RVA: 0x000BC720 File Offset: 0x000BA920
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 426933, RefRangeEnd = 426938, XrefRangeStart = 426929, XrefRangeEnd = 426933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_write_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_write_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029B5 RID: 10677 RVA: 0x000BC77C File Offset: 0x000BA97C
			[CallerCount(0)]
			public unsafe IntPtr Invoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_write_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060029B6 RID: 10678 RVA: 0x0001207B File Offset: 0x0001027B
			public unitytls_tlsctx_write_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400212A RID: 8490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400212B RID: 8491
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
		}

		// Token: 0x02000291 RID: 657
		public sealed class unitytls_tlsctx_read_callback : MulticastDelegate
		{
			// Token: 0x060029B7 RID: 10679 RVA: 0x00012084 File Offset: 0x00010284
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_read_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_read_callback");
				UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr, 100663342);
				UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr, 100663343);
			}

			// Token: 0x060029B8 RID: 10680 RVA: 0x000BC7F0 File Offset: 0x000BA9F0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 426933, RefRangeEnd = 426938, XrefRangeStart = 426933, XrefRangeEnd = 426938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_read_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_read_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029B9 RID: 10681 RVA: 0x000BC84C File Offset: 0x000BAA4C
			[CallerCount(0)]
			public unsafe IntPtr Invoke(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_read_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060029BA RID: 10682 RVA: 0x000120C2 File Offset: 0x000102C2
			public unitytls_tlsctx_read_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400212C RID: 8492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400212D RID: 8493
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
		}

		// Token: 0x02000292 RID: 658
		public sealed class unitytls_tlsctx_trace_callback : MulticastDelegate
		{
			// Token: 0x060029BB RID: 10683 RVA: 0x000120CB File Offset: 0x000102CB
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_trace_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_trace_callback");
				UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr, 100663344);
				UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr, 100663345);
			}

			// Token: 0x060029BC RID: 10684 RVA: 0x000BC8C0 File Offset: 0x000BAAC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426938, XrefRangeEnd = 426942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_trace_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_trace_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029BD RID: 10685 RVA: 0x000BC91C File Offset: 0x000BAB1C
			[CallerCount(0)]
			public unsafe void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ctx;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = traceMessage;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref traceMessageLen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_trace_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029BE RID: 10686 RVA: 0x00012109 File Offset: 0x00010309
			public unitytls_tlsctx_trace_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400212E RID: 8494
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400212F RID: 8495
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0;
		}

		// Token: 0x02000293 RID: 659
		public sealed class unitytls_tlsctx_certificate_callback : MulticastDelegate
		{
			// Token: 0x060029BF RID: 10687 RVA: 0x00012112 File Offset: 0x00010312
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_certificate_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_certificate_callback");
				UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr, 100663346);
				UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr, 100663347);
			}

			// Token: 0x060029C0 RID: 10688 RVA: 0x000BC984 File Offset: 0x000BAB84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426942, XrefRangeEnd = 426946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_certificate_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_certificate_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029C1 RID: 10689 RVA: 0x000BC9E0 File Offset: 0x000BABE0
			[CallerCount(0)]
			public unsafe void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ctx;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = caList;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caListLen;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chain;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = key;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_certificate_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029C2 RID: 10690 RVA: 0x00012150 File Offset: 0x00010350
			public unitytls_tlsctx_certificate_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002130 RID: 8496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002131 RID: 8497
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0;
		}

		// Token: 0x02000294 RID: 660
		public sealed class unitytls_tlsctx_x509verify_callback : MulticastDelegate
		{
			// Token: 0x060029C3 RID: 10691 RVA: 0x00012159 File Offset: 0x00010359
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_x509verify_callback()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_x509verify_callback");
				UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr, 100663348);
				UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr, 100663349);
			}

			// Token: 0x060029C4 RID: 10692 RVA: 0x000BCA8C File Offset: 0x000BAC8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426946, XrefRangeEnd = 426950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_x509verify_callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_x509verify_callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029C5 RID: 10693 RVA: 0x000BCAE8 File Offset: 0x000BACE8
			[CallerCount(0)]
			public unsafe UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = userData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chain;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_tlsctx_x509verify_callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060029C6 RID: 10694 RVA: 0x00012197 File Offset: 0x00010397
			public unitytls_tlsctx_x509verify_callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002132 RID: 8498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002133 RID: 8499
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0;
		}

		// Token: 0x02000295 RID: 661
		public sealed class unitytls_tlsctx_callbacks : ValueType
		{
			// Token: 0x060029C7 RID: 10695 RVA: 0x000BCB4C File Offset: 0x000BAD4C
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_tlsctx_callbacks()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_callbacks");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr);
				UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr, "read");
				UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_write = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr, "write");
				UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr, "data");
			}

			// Token: 0x060029C8 RID: 10696 RVA: 0x000121A0 File Offset: 0x000103A0
			public unitytls_tlsctx_callbacks(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060029C9 RID: 10697 RVA: 0x000121A9 File Offset: 0x000103A9
			public unitytls_tlsctx_callbacks()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_tlsctx_callbacks>.NativeClassPtr))
			{
			}

			// Token: 0x17000D2A RID: 3370
			// (get) Token: 0x060029CA RID: 10698 RVA: 0x000BCBB4 File Offset: 0x000BADB4
			// (set) Token: 0x060029CB RID: 10699 RVA: 0x000121BB File Offset: 0x000103BB
			public unsafe UnityTls.unitytls_tlsctx_read_callback read
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_read);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_read_callback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_read), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D2B RID: 3371
			// (get) Token: 0x060029CC RID: 10700 RVA: 0x000BCBE4 File Offset: 0x000BADE4
			// (set) Token: 0x060029CD RID: 10701 RVA: 0x000121DA File Offset: 0x000103DA
			public unsafe UnityTls.unitytls_tlsctx_write_callback write
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_write);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_tlsctx_write_callback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_write), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D2C RID: 3372
			// (get) Token: 0x060029CE RID: 10702 RVA: 0x000BCC14 File Offset: 0x000BAE14
			// (set) Token: 0x060029CF RID: 10703 RVA: 0x000121F9 File Offset: 0x000103F9
			public unsafe void* data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_data);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_tlsctx_callbacks.NativeFieldInfoPtr_data)) = value;
				}
			}

			// Token: 0x04002134 RID: 8500
			private static readonly IntPtr NativeFieldInfoPtr_read;

			// Token: 0x04002135 RID: 8501
			private static readonly IntPtr NativeFieldInfoPtr_write;

			// Token: 0x04002136 RID: 8502
			private static readonly IntPtr NativeFieldInfoPtr_data;
		}

		// Token: 0x02000296 RID: 662
		public class unitytls_interface_struct : Object
		{
			// Token: 0x060029D0 RID: 10704 RVA: 0x000BCC38 File Offset: 0x000BAE38
			// Note: this type is marked as 'beforefieldinit'.
			static unitytls_interface_struct()
			{
				Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_interface_struct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr);
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "UNITYTLS_INVALID_HANDLE");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_create");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_raise_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_raise_error");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_get_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_get_ref");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_der");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_pem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_pem");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_free");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509_export_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509_export_der");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_ref");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_x509 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_x509");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_create");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_der");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_pem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_pem");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_free");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_default_ca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_default_ca");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_explicit_ca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_explicit_ca");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_server");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_client");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_server_require_client_authentication");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_certificate_callback");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_trace_callback");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_x509verify_callback");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_supported_ciphersuites");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_ciphersuite");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_protocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_protocol");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_process_handshake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_process_handshake");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_read");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_write = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_write");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_notify_close = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_notify_close");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_free");
				UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_random_generate_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_random_generate_bytes");
				UnityTls.unitytls_interface_struct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, 100663350);
			}

			// Token: 0x060029D1 RID: 10705 RVA: 0x000BCF0C File Offset: 0x000BB10C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_interface_struct()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029D2 RID: 10706 RVA: 0x00012214 File Offset: 0x00010414
			public unitytls_interface_struct(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D2D RID: 3373
			// (get) Token: 0x060029D3 RID: 10707 RVA: 0x000BCF48 File Offset: 0x000BB148
			// (set) Token: 0x060029D4 RID: 10708 RVA: 0x0001221D File Offset: 0x0001041D
			public unsafe ulong UNITYTLS_INVALID_HANDLE
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE)) = value;
				}
			}

			// Token: 0x17000D2E RID: 3374
			// (get) Token: 0x060029D5 RID: 10709 RVA: 0x000BCF70 File Offset: 0x000BB170
			// (set) Token: 0x060029D6 RID: 10710 RVA: 0x00012238 File Offset: 0x00010438
			public unsafe UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT)) = value;
				}
			}

			// Token: 0x17000D2F RID: 3375
			// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000BCF98 File Offset: 0x000BB198
			// (set) Token: 0x060029D8 RID: 10712 RVA: 0x00012253 File Offset: 0x00010453
			public unsafe UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_create);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_create), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D30 RID: 3376
			// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000BCFC8 File Offset: 0x000BB1C8
			// (set) Token: 0x060029DA RID: 10714 RVA: 0x00012272 File Offset: 0x00010472
			public unsafe UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_raise_error);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_errorstate_raise_error), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D31 RID: 3377
			// (get) Token: 0x060029DB RID: 10715 RVA: 0x000BCFF8 File Offset: 0x000BB1F8
			// (set) Token: 0x060029DC RID: 10716 RVA: 0x00012291 File Offset: 0x00010491
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_get_ref);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_get_ref), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D32 RID: 3378
			// (get) Token: 0x060029DD RID: 10717 RVA: 0x000BD028 File Offset: 0x000BB228
			// (set) Token: 0x060029DE RID: 10718 RVA: 0x000122B0 File Offset: 0x000104B0
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_der);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_der), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D33 RID: 3379
			// (get) Token: 0x060029DF RID: 10719 RVA: 0x000BD058 File Offset: 0x000BB258
			// (set) Token: 0x060029E0 RID: 10720 RVA: 0x000122CF File Offset: 0x000104CF
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_pem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_parse_pem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D34 RID: 3380
			// (get) Token: 0x060029E1 RID: 10721 RVA: 0x000BD088 File Offset: 0x000BB288
			// (set) Token: 0x060029E2 RID: 10722 RVA: 0x000122EE File Offset: 0x000104EE
			public unsafe UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_free);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_key_free_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_key_free), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D35 RID: 3381
			// (get) Token: 0x060029E3 RID: 10723 RVA: 0x000BD0B8 File Offset: 0x000BB2B8
			// (set) Token: 0x060029E4 RID: 10724 RVA: 0x0001230D File Offset: 0x0001050D
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509_export_der);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509_export_der), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D36 RID: 3382
			// (get) Token: 0x060029E5 RID: 10725 RVA: 0x000BD0E8 File Offset: 0x000BB2E8
			// (set) Token: 0x060029E6 RID: 10726 RVA: 0x0001232C File Offset: 0x0001052C
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_ref);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_ref), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D37 RID: 3383
			// (get) Token: 0x060029E7 RID: 10727 RVA: 0x000BD118 File Offset: 0x000BB318
			// (set) Token: 0x060029E8 RID: 10728 RVA: 0x0001234B File Offset: 0x0001054B
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_x509);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_get_x509), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D38 RID: 3384
			// (get) Token: 0x060029E9 RID: 10729 RVA: 0x000BD148 File Offset: 0x000BB348
			// (set) Token: 0x060029EA RID: 10730 RVA: 0x0001236A File Offset: 0x0001056A
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_create);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_create), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D39 RID: 3385
			// (get) Token: 0x060029EB RID: 10731 RVA: 0x000BD178 File Offset: 0x000BB378
			// (set) Token: 0x060029EC RID: 10732 RVA: 0x00012389 File Offset: 0x00010589
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3A RID: 3386
			// (get) Token: 0x060029ED RID: 10733 RVA: 0x000BD1A8 File Offset: 0x000BB3A8
			// (set) Token: 0x060029EE RID: 10734 RVA: 0x000123A8 File Offset: 0x000105A8
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_der);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_der), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3B RID: 3387
			// (get) Token: 0x060029EF RID: 10735 RVA: 0x000BD1D8 File Offset: 0x000BB3D8
			// (set) Token: 0x060029F0 RID: 10736 RVA: 0x000123C7 File Offset: 0x000105C7
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_pem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_append_pem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3C RID: 3388
			// (get) Token: 0x060029F1 RID: 10737 RVA: 0x000BD208 File Offset: 0x000BB408
			// (set) Token: 0x060029F2 RID: 10738 RVA: 0x000123E6 File Offset: 0x000105E6
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_free);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509list_free), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3D RID: 3389
			// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000BD238 File Offset: 0x000BB438
			// (set) Token: 0x060029F4 RID: 10740 RVA: 0x00012405 File Offset: 0x00010605
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_default_ca);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_default_ca), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3E RID: 3390
			// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000BD268 File Offset: 0x000BB468
			// (set) Token: 0x060029F6 RID: 10742 RVA: 0x00012424 File Offset: 0x00010624
			public unsafe UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_explicit_ca);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_x509verify_explicit_ca), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D3F RID: 3391
			// (get) Token: 0x060029F7 RID: 10743 RVA: 0x000BD298 File Offset: 0x000BB498
			// (set) Token: 0x060029F8 RID: 10744 RVA: 0x00012443 File Offset: 0x00010643
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_server);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_server), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D40 RID: 3392
			// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000BD2C8 File Offset: 0x000BB4C8
			// (set) Token: 0x060029FA RID: 10746 RVA: 0x00012462 File Offset: 0x00010662
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_client);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_create_client), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D41 RID: 3393
			// (get) Token: 0x060029FB RID: 10747 RVA: 0x000BD2F8 File Offset: 0x000BB4F8
			// (set) Token: 0x060029FC RID: 10748 RVA: 0x00012481 File Offset: 0x00010681
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D42 RID: 3394
			// (get) Token: 0x060029FD RID: 10749 RVA: 0x000BD328 File Offset: 0x000BB528
			// (set) Token: 0x060029FE RID: 10750 RVA: 0x000124A0 File Offset: 0x000106A0
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D43 RID: 3395
			// (get) Token: 0x060029FF RID: 10751 RVA: 0x000BD358 File Offset: 0x000BB558
			// (set) Token: 0x06002A00 RID: 10752 RVA: 0x000124BF File Offset: 0x000106BF
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D44 RID: 3396
			// (get) Token: 0x06002A01 RID: 10753 RVA: 0x000BD388 File Offset: 0x000BB588
			// (set) Token: 0x06002A02 RID: 10754 RVA: 0x000124DE File Offset: 0x000106DE
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D45 RID: 3397
			// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000BD3B8 File Offset: 0x000BB5B8
			// (set) Token: 0x06002A04 RID: 10756 RVA: 0x000124FD File Offset: 0x000106FD
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D46 RID: 3398
			// (get) Token: 0x06002A05 RID: 10757 RVA: 0x000BD3E8 File Offset: 0x000BB5E8
			// (set) Token: 0x06002A06 RID: 10758 RVA: 0x0001251C File Offset: 0x0001071C
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D47 RID: 3399
			// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000BD418 File Offset: 0x000BB618
			// (set) Token: 0x06002A08 RID: 10760 RVA: 0x0001253B File Offset: 0x0001073B
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_protocol);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_get_protocol), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D48 RID: 3400
			// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000BD448 File Offset: 0x000BB648
			// (set) Token: 0x06002A0A RID: 10762 RVA: 0x0001255A File Offset: 0x0001075A
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_process_handshake);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_process_handshake), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D49 RID: 3401
			// (get) Token: 0x06002A0B RID: 10763 RVA: 0x000BD478 File Offset: 0x000BB678
			// (set) Token: 0x06002A0C RID: 10764 RVA: 0x00012579 File Offset: 0x00010779
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_read);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_read), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4A RID: 3402
			// (get) Token: 0x06002A0D RID: 10765 RVA: 0x000BD4A8 File Offset: 0x000BB6A8
			// (set) Token: 0x06002A0E RID: 10766 RVA: 0x00012598 File Offset: 0x00010798
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_write);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_write), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4B RID: 3403
			// (get) Token: 0x06002A0F RID: 10767 RVA: 0x000BD4D8 File Offset: 0x000BB6D8
			// (set) Token: 0x06002A10 RID: 10768 RVA: 0x000125B7 File Offset: 0x000107B7
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_notify_close);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_notify_close), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4C RID: 3404
			// (get) Token: 0x06002A11 RID: 10769 RVA: 0x000BD508 File Offset: 0x000BB708
			// (set) Token: 0x06002A12 RID: 10770 RVA: 0x000125D6 File Offset: 0x000107D6
			public unsafe UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_free);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_tlsctx_free), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D4D RID: 3405
			// (get) Token: 0x06002A13 RID: 10771 RVA: 0x000BD538 File Offset: 0x000BB738
			// (set) Token: 0x06002A14 RID: 10772 RVA: 0x000125F5 File Offset: 0x000107F5
			public unsafe UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_random_generate_bytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityTls.unitytls_interface_struct.NativeFieldInfoPtr_unitytls_random_generate_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002137 RID: 8503
			private static readonly IntPtr NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE;

			// Token: 0x04002138 RID: 8504
			private static readonly IntPtr NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;

			// Token: 0x04002139 RID: 8505
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_errorstate_create;

			// Token: 0x0400213A RID: 8506
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_errorstate_raise_error;

			// Token: 0x0400213B RID: 8507
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_get_ref;

			// Token: 0x0400213C RID: 8508
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_parse_der;

			// Token: 0x0400213D RID: 8509
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_parse_pem;

			// Token: 0x0400213E RID: 8510
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_key_free;

			// Token: 0x0400213F RID: 8511
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509_export_der;

			// Token: 0x04002140 RID: 8512
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_get_ref;

			// Token: 0x04002141 RID: 8513
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_get_x509;

			// Token: 0x04002142 RID: 8514
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_create;

			// Token: 0x04002143 RID: 8515
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_append;

			// Token: 0x04002144 RID: 8516
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_append_der;

			// Token: 0x04002145 RID: 8517
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_append_pem;

			// Token: 0x04002146 RID: 8518
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509list_free;

			// Token: 0x04002147 RID: 8519
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509verify_default_ca;

			// Token: 0x04002148 RID: 8520
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_x509verify_explicit_ca;

			// Token: 0x04002149 RID: 8521
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_create_server;

			// Token: 0x0400214A RID: 8522
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_create_client;

			// Token: 0x0400214B RID: 8523
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication;

			// Token: 0x0400214C RID: 8524
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback;

			// Token: 0x0400214D RID: 8525
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback;

			// Token: 0x0400214E RID: 8526
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback;

			// Token: 0x0400214F RID: 8527
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites;

			// Token: 0x04002150 RID: 8528
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite;

			// Token: 0x04002151 RID: 8529
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_get_protocol;

			// Token: 0x04002152 RID: 8530
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_process_handshake;

			// Token: 0x04002153 RID: 8531
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_read;

			// Token: 0x04002154 RID: 8532
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_write;

			// Token: 0x04002155 RID: 8533
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_notify_close;

			// Token: 0x04002156 RID: 8534
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_tlsctx_free;

			// Token: 0x04002157 RID: 8535
			private static readonly IntPtr NativeFieldInfoPtr_unitytls_random_generate_bytes;

			// Token: 0x04002158 RID: 8536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200039A RID: 922
			public sealed class unitytls_errorstate_create_t : MulticastDelegate
			{
				// Token: 0x060034D8 RID: 13528 RVA: 0x00019B15 File Offset: 0x00017D15
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_errorstate_create_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_create_t");
					UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr, 100663351);
					UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr, 100663352);
				}

				// Token: 0x060034D9 RID: 13529 RVA: 0x000DBEE0 File Offset: 0x000DA0E0
				[CallerCount(27)]
				[CachedScanResults(RefRangeStart = 426953, RefRangeEnd = 426980, XrefRangeStart = 426950, XrefRangeEnd = 426953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_errorstate_create_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034DA RID: 13530 RVA: 0x000DBF3C File Offset: 0x000DA13C
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_errorstate Invoke()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060034DB RID: 13531 RVA: 0x00019B53 File Offset: 0x00017D53
				public unitytls_errorstate_create_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060034DC RID: 13532 RVA: 0x00019B5C File Offset: 0x00017D5C
				public static implicit operator UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t(Func<UnityTls.unitytls_errorstate> A_0)
				{
					return DelegateSupport.ConvertDelegate<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>(A_0);
				}

				// Token: 0x060034DD RID: 13533 RVA: 0x00019B64 File Offset: 0x00017D64
				public static UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t operator +(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_0, UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>();
				}

				// Token: 0x060034DE RID: 13534 RVA: 0x00019B72 File Offset: 0x00017D72
				public static UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t operator -(UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_0, UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t>();
					}
					return delegate2;
				}

				// Token: 0x04002812 RID: 10258
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002813 RID: 10259
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0;
			}

			// Token: 0x0200039B RID: 923
			public sealed class unitytls_errorstate_raise_error_t : MulticastDelegate
			{
				// Token: 0x060034DF RID: 13535 RVA: 0x00019B83 File Offset: 0x00017D83
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_errorstate_raise_error_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_raise_error_t");
					UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr, 100663353);
					UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr, 100663354);
				}

				// Token: 0x060034E0 RID: 13536 RVA: 0x000DBF78 File Offset: 0x000DA178
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 426984, RefRangeEnd = 426986, XrefRangeStart = 426980, XrefRangeEnd = 426984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_errorstate_raise_error_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034E1 RID: 13537 RVA: 0x000DBFD4 File Offset: 0x000DA1D4
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = errorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorCode;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034E2 RID: 13538 RVA: 0x00019BC1 File Offset: 0x00017DC1
				public unitytls_errorstate_raise_error_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002814 RID: 10260
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002815 RID: 10261
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0;
			}

			// Token: 0x0200039C RID: 924
			public sealed class unitytls_key_get_ref_t : MulticastDelegate
			{
				// Token: 0x060034E3 RID: 13539 RVA: 0x00019BCA File Offset: 0x00017DCA
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_get_ref_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_get_ref_t");
					UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr, 100663355);
					UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr, 100663356);
				}

				// Token: 0x060034E4 RID: 13540 RVA: 0x000DC020 File Offset: 0x000DA220
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 426990, RefRangeEnd = 426992, XrefRangeStart = 426986, XrefRangeEnd = 426990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_get_ref_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034E5 RID: 13541 RVA: 0x000DC07C File Offset: 0x000DA27C
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_key_ref Invoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = key;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060034E6 RID: 13542 RVA: 0x00019C08 File Offset: 0x00017E08
				public unitytls_key_get_ref_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002816 RID: 10262
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002817 RID: 10263
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0;
			}

			// Token: 0x0200039D RID: 925
			public sealed class unitytls_key_parse_der_t : MulticastDelegate
			{
				// Token: 0x060034E7 RID: 13543 RVA: 0x00019C11 File Offset: 0x00017E11
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_parse_der_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_der_t");
					UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr, 100663357);
					UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr, 100663358);
				}

				// Token: 0x060034E8 RID: 13544 RVA: 0x000DC0D4 File Offset: 0x000DA2D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426992, XrefRangeEnd = 426996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_parse_der_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034E9 RID: 13545 RVA: 0x000DC130 File Offset: 0x000DA330
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = password;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passwordLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x060034EA RID: 13546 RVA: 0x00019C4F File Offset: 0x00017E4F
				public unitytls_key_parse_der_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002818 RID: 10264
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002819 RID: 10265
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x0200039E RID: 926
			public sealed class unitytls_key_parse_pem_t : MulticastDelegate
			{
				// Token: 0x060034EB RID: 13547 RVA: 0x00019C58 File Offset: 0x00017E58
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_parse_pem_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_pem_t");
					UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr, 100663359);
					UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr, 100663360);
				}

				// Token: 0x060034EC RID: 13548 RVA: 0x000DC1A8 File Offset: 0x000DA3A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_parse_pem_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034ED RID: 13549 RVA: 0x000DC204 File Offset: 0x000DA404
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = password;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passwordLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x060034EE RID: 13550 RVA: 0x00019C96 File Offset: 0x00017E96
				public unitytls_key_parse_pem_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400281A RID: 10266
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400281B RID: 10267
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x0200039F RID: 927
			public sealed class unitytls_key_free_t : MulticastDelegate
			{
				// Token: 0x060034EF RID: 13551 RVA: 0x00019C9F File Offset: 0x00017E9F
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_key_free_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_key_free_t");
					UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr, 100663361);
					UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr, 100663362);
				}

				// Token: 0x060034F0 RID: 13552 RVA: 0x000DC27C File Offset: 0x000DA47C
				[CallerCount(16)]
				[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_key_free_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_key_free_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034F1 RID: 13553 RVA: 0x000DC2D8 File Offset: 0x000DA4D8
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_key* key)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = key;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_key_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060034F2 RID: 13554 RVA: 0x00019CDD File Offset: 0x00017EDD
				public unitytls_key_free_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400281C RID: 10268
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400281D RID: 10269
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0;
			}

			// Token: 0x020003A0 RID: 928
			public sealed class unitytls_x509_export_der_t : MulticastDelegate
			{
				// Token: 0x060034F3 RID: 13555 RVA: 0x00019CE6 File Offset: 0x00017EE6
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509_export_der_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509_export_der_t");
					UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr, 100663363);
					UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr, 100663364);
				}

				// Token: 0x060034F4 RID: 13556 RVA: 0x000DC318 File Offset: 0x000DA518
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426996, XrefRangeEnd = 426999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509_export_der_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034F5 RID: 13557 RVA: 0x000DC374 File Offset: 0x000DA574
				[CallerCount(0)]
				public unsafe IntPtr Invoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref cert;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060034F6 RID: 13558 RVA: 0x00019D24 File Offset: 0x00017F24
				public unitytls_x509_export_der_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400281E RID: 10270
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400281F RID: 10271
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003A1 RID: 929
			public sealed class unitytls_x509list_get_ref_t : MulticastDelegate
			{
				// Token: 0x060034F7 RID: 13559 RVA: 0x00019D2D File Offset: 0x00017F2D
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_get_ref_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_ref_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr, 100663365);
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr, 100663366);
				}

				// Token: 0x060034F8 RID: 13560 RVA: 0x000DC3E8 File Offset: 0x000DA5E8
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 426990, RefRangeEnd = 426992, XrefRangeStart = 426990, XrefRangeEnd = 426992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_get_ref_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034F9 RID: 13561 RVA: 0x000DC444 File Offset: 0x000DA644
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_x509list_ref Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060034FA RID: 13562 RVA: 0x00019D6B File Offset: 0x00017F6B
				public unitytls_x509list_get_ref_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002820 RID: 10272
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002821 RID: 10273
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003A2 RID: 930
			public sealed class unitytls_x509list_get_x509_t : MulticastDelegate
			{
				// Token: 0x060034FB RID: 13563 RVA: 0x00019D74 File Offset: 0x00017F74
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_get_x509_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_x509_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr, 100663367);
					UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr, 100663368);
				}

				// Token: 0x060034FC RID: 13564 RVA: 0x000DC49C File Offset: 0x000DA69C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426999, XrefRangeEnd = 427002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_get_x509_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034FD RID: 13565 RVA: 0x000DC4F8 File Offset: 0x000DA6F8
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_x509_ref Invoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060034FE RID: 13566 RVA: 0x00019DB2 File Offset: 0x00017FB2
				public unitytls_x509list_get_x509_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002822 RID: 10274
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002823 RID: 10275
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003A3 RID: 931
			public sealed class unitytls_x509list_create_t : MulticastDelegate
			{
				// Token: 0x060034FF RID: 13567 RVA: 0x00019DBB File Offset: 0x00017FBB
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_create_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_create_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr, 100663369);
					UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr, 100663370);
				}

				// Token: 0x06003500 RID: 13568 RVA: 0x000DC55C File Offset: 0x000DA75C
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 427006, RefRangeEnd = 427011, XrefRangeStart = 427002, XrefRangeEnd = 427006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_create_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_create_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003501 RID: 13569 RVA: 0x000DC5B8 File Offset: 0x000DA7B8
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_x509list* Invoke(UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = errorState;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_create_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return intPtr;
					}
				}

				// Token: 0x06003502 RID: 13570 RVA: 0x00019DF9 File Offset: 0x00017FF9
				public unitytls_x509list_create_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002824 RID: 10276
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002825 RID: 10277
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003A4 RID: 932
			public sealed class unitytls_x509list_append_t : MulticastDelegate
			{
				// Token: 0x06003503 RID: 13571 RVA: 0x00019E02 File Offset: 0x00018002
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_append_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr, 100663371);
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr, 100663372);
				}

				// Token: 0x06003504 RID: 13572 RVA: 0x000DC5F8 File Offset: 0x000DA7F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427011, XrefRangeEnd = 427015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_append_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003505 RID: 13573 RVA: 0x000DC654 File Offset: 0x000DA854
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cert;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003506 RID: 13574 RVA: 0x00019E40 File Offset: 0x00018040
				public unitytls_x509list_append_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002826 RID: 10278
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002827 RID: 10279
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003A5 RID: 933
			public sealed class unitytls_x509list_append_der_t : MulticastDelegate
			{
				// Token: 0x06003507 RID: 13575 RVA: 0x00019E49 File Offset: 0x00018049
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_append_der_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_der_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr, 100663373);
					UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr, 100663374);
				}

				// Token: 0x06003508 RID: 13576 RVA: 0x000DC6AC File Offset: 0x000DA8AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_append_der_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003509 RID: 13577 RVA: 0x000DC708 File Offset: 0x000DA908
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600350A RID: 13578 RVA: 0x00019E87 File Offset: 0x00018087
				public unitytls_x509list_append_der_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002828 RID: 10280
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002829 RID: 10281
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003A6 RID: 934
			public sealed class unitytls_x509list_free_t : MulticastDelegate
			{
				// Token: 0x0600350B RID: 13579 RVA: 0x00019E90 File Offset: 0x00018090
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509list_free_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_free_t");
					UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr, 100663375);
					UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr, 100663376);
				}

				// Token: 0x0600350C RID: 13580 RVA: 0x000DC770 File Offset: 0x000DA970
				[CallerCount(16)]
				[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509list_free_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509list_free_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600350D RID: 13581 RVA: 0x000DC7CC File Offset: 0x000DA9CC
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_x509list* list)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = list;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509list_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600350E RID: 13582 RVA: 0x00019ECE File Offset: 0x000180CE
				public unitytls_x509list_free_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400282A RID: 10282
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400282B RID: 10283
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0;
			}

			// Token: 0x020003A7 RID: 935
			public sealed class unitytls_x509verify_default_ca_t : MulticastDelegate
			{
				// Token: 0x0600350F RID: 13583 RVA: 0x00019ED7 File Offset: 0x000180D7
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509verify_default_ca_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_default_ca_t");
					UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr, 100663377);
					UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr, 100663378);
				}

				// Token: 0x06003510 RID: 13584 RVA: 0x000DC80C File Offset: 0x000DAA0C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427015, XrefRangeEnd = 427018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509verify_default_ca_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003511 RID: 13585 RVA: 0x000DC868 File Offset: 0x000DAA68
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref chain;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06003512 RID: 13586 RVA: 0x00019F15 File Offset: 0x00018115
				public unitytls_x509verify_default_ca_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400282C RID: 10284
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400282D RID: 10285
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003A8 RID: 936
			public sealed class unitytls_x509verify_explicit_ca_t : MulticastDelegate
			{
				// Token: 0x06003513 RID: 13587 RVA: 0x00019F1E File Offset: 0x0001811E
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_x509verify_explicit_ca_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_explicit_ca_t");
					UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr, 100663379);
					UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr, 100663380);
				}

				// Token: 0x06003514 RID: 13588 RVA: 0x000DC8FC File Offset: 0x000DAAFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427018, XrefRangeEnd = 427021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_x509verify_explicit_ca_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003515 RID: 13589 RVA: 0x000DC958 File Offset: 0x000DAB58
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref chain;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trustCA;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06003516 RID: 13590 RVA: 0x00019F5C File Offset: 0x0001815C
				public unitytls_x509verify_explicit_ca_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400282E RID: 10286
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400282F RID: 10287
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003A9 RID: 937
			public sealed class unitytls_tlsctx_create_server_t : MulticastDelegate
			{
				// Token: 0x06003517 RID: 13591 RVA: 0x00019F65 File Offset: 0x00018165
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_create_server_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_server_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr, 100663381);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr, 100663382);
				}

				// Token: 0x06003518 RID: 13592 RVA: 0x000DC9FC File Offset: 0x000DABFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427021, XrefRangeEnd = 427024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_create_server_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003519 RID: 13593 RVA: 0x000DCA58 File Offset: 0x000DAC58
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref supportedProtocols;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbacks));
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref certChain;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leafCertificateKey;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x0600351A RID: 13594 RVA: 0x00019FA3 File Offset: 0x000181A3
				public unitytls_tlsctx_create_server_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002830 RID: 10288
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002831 RID: 10289
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003AA RID: 938
			public sealed class unitytls_tlsctx_create_client_t : MulticastDelegate
			{
				// Token: 0x0600351B RID: 13595 RVA: 0x00019FAC File Offset: 0x000181AC
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_create_client_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_client_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr, 100663383);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr, 100663384);
				}

				// Token: 0x0600351C RID: 13596 RVA: 0x000DCAD8 File Offset: 0x000DACD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_create_client_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600351D RID: 13597 RVA: 0x000DCB34 File Offset: 0x000DAD34
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref supportedProtocols;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbacks));
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = cn;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x0600351E RID: 13598 RVA: 0x00019FEA File Offset: 0x000181EA
				public unitytls_tlsctx_create_client_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002832 RID: 10290
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002833 RID: 10291
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003AB RID: 939
			public sealed class unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate
			{
				// Token: 0x0600351F RID: 13599 RVA: 0x00019FF3 File Offset: 0x000181F3
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_server_require_client_authentication_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_server_require_client_authentication_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr, 100663385);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr, 100663386);
				}

				// Token: 0x06003520 RID: 13600 RVA: 0x000DCBB4 File Offset: 0x000DADB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_server_require_client_authentication_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003521 RID: 13601 RVA: 0x000DCC10 File Offset: 0x000DAE10
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clientAuthCAList;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003522 RID: 13602 RVA: 0x0001A031 File Offset: 0x00018231
				public unitytls_tlsctx_server_require_client_authentication_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002834 RID: 10292
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002835 RID: 10293
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003AC RID: 940
			public sealed class unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate
			{
				// Token: 0x06003523 RID: 13603 RVA: 0x0001A03A File Offset: 0x0001823A
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_certificate_callback_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_certificate_callback_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr, 100663387);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr, 100663388);
				}

				// Token: 0x06003524 RID: 13604 RVA: 0x000DCC68 File Offset: 0x000DAE68
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_certificate_callback_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003525 RID: 13605 RVA: 0x000DCCC4 File Offset: 0x000DAEC4
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003526 RID: 13606 RVA: 0x0001A078 File Offset: 0x00018278
				public unitytls_tlsctx_set_certificate_callback_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002836 RID: 10294
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002837 RID: 10295
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003AD RID: 941
			public sealed class unitytls_tlsctx_set_trace_callback_t : MulticastDelegate
			{
				// Token: 0x06003527 RID: 13607 RVA: 0x0001A081 File Offset: 0x00018281
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_trace_callback_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_trace_callback_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr, 100663389);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr, 100663390);
				}

				// Token: 0x06003528 RID: 13608 RVA: 0x000DCD30 File Offset: 0x000DAF30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_trace_callback_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003529 RID: 13609 RVA: 0x000DCD8C File Offset: 0x000DAF8C
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600352A RID: 13610 RVA: 0x0001A0BF File Offset: 0x000182BF
				public unitytls_tlsctx_set_trace_callback_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002838 RID: 10296
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002839 RID: 10297
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003AE RID: 942
			public sealed class unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate
			{
				// Token: 0x0600352B RID: 13611 RVA: 0x0001A0C8 File Offset: 0x000182C8
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_x509verify_callback_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_x509verify_callback_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr, 100663391);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr, 100663392);
				}

				// Token: 0x0600352C RID: 13612 RVA: 0x000DCDF8 File Offset: 0x000DAFF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_x509verify_callback_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600352D RID: 13613 RVA: 0x000DCE54 File Offset: 0x000DB054
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600352E RID: 13614 RVA: 0x0001A106 File Offset: 0x00018306
				public unitytls_tlsctx_set_x509verify_callback_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400283A RID: 10298
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400283B RID: 10299
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003AF RID: 943
			public sealed class unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate
			{
				// Token: 0x0600352F RID: 13615 RVA: 0x0001A10F File Offset: 0x0001830F
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_set_supported_ciphersuites_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_supported_ciphersuites_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr, 100663393);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr, 100663394);
				}

				// Token: 0x06003530 RID: 13616 RVA: 0x000DCEC0 File Offset: 0x000DB0C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_set_supported_ciphersuites_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003531 RID: 13617 RVA: 0x000DCF1C File Offset: 0x000DB11C
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = supportedCiphersuites;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref supportedCiphersuitesLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003532 RID: 13618 RVA: 0x0001A14D File Offset: 0x0001834D
				public unitytls_tlsctx_set_supported_ciphersuites_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400283C RID: 10300
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400283D RID: 10301
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003B0 RID: 944
			public sealed class unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate
			{
				// Token: 0x06003533 RID: 13619 RVA: 0x0001A156 File Offset: 0x00018356
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_get_ciphersuite_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_ciphersuite_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr, 100663395);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr, 100663396);
				}

				// Token: 0x06003534 RID: 13620 RVA: 0x000DCF84 File Offset: 0x000DB184
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427024, XrefRangeEnd = 427028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_get_ciphersuite_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003535 RID: 13621 RVA: 0x000DCFE0 File Offset: 0x000DB1E0
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_ciphersuite Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06003536 RID: 13622 RVA: 0x0001A194 File Offset: 0x00018394
				public unitytls_tlsctx_get_ciphersuite_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400283E RID: 10302
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400283F RID: 10303
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003B1 RID: 945
			public sealed class unitytls_tlsctx_get_protocol_t : MulticastDelegate
			{
				// Token: 0x06003537 RID: 13623 RVA: 0x0001A19D File Offset: 0x0001839D
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_get_protocol_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_protocol_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr, 100663397);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr, 100663398);
				}

				// Token: 0x06003538 RID: 13624 RVA: 0x000DD038 File Offset: 0x000DB238
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_get_protocol_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003539 RID: 13625 RVA: 0x000DD094 File Offset: 0x000DB294
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_protocol Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600353A RID: 13626 RVA: 0x0001A1DB File Offset: 0x000183DB
				public unitytls_tlsctx_get_protocol_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002840 RID: 10304
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002841 RID: 10305
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003B2 RID: 946
			public sealed class unitytls_tlsctx_process_handshake_t : MulticastDelegate
			{
				// Token: 0x0600353B RID: 13627 RVA: 0x0001A1E4 File Offset: 0x000183E4
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_process_handshake_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_process_handshake_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr, 100663399);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr, 100663400);
				}

				// Token: 0x0600353C RID: 13628 RVA: 0x000DD0EC File Offset: 0x000DB2EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_process_handshake_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600353D RID: 13629 RVA: 0x000DD148 File Offset: 0x000DB348
				[CallerCount(0)]
				public unsafe UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600353E RID: 13630 RVA: 0x0001A222 File Offset: 0x00018422
				public unitytls_tlsctx_process_handshake_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002842 RID: 10306
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002843 RID: 10307
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003B3 RID: 947
			public sealed class unitytls_tlsctx_read_t : MulticastDelegate
			{
				// Token: 0x0600353F RID: 13631 RVA: 0x0001A22B File Offset: 0x0001842B
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_read_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_read_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr, 100663401);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr, 100663402);
				}

				// Token: 0x06003540 RID: 13632 RVA: 0x000DD1A0 File Offset: 0x000DB3A0
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 426933, RefRangeEnd = 426938, XrefRangeStart = 426933, XrefRangeEnd = 426938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_read_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003541 RID: 13633 RVA: 0x000DD1FC File Offset: 0x000DB3FC
				[CallerCount(0)]
				public unsafe IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06003542 RID: 13634 RVA: 0x0001A269 File Offset: 0x00018469
				public unitytls_tlsctx_read_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002844 RID: 10308
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002845 RID: 10309
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003B4 RID: 948
			public sealed class unitytls_tlsctx_write_t : MulticastDelegate
			{
				// Token: 0x06003543 RID: 13635 RVA: 0x0001A272 File Offset: 0x00018472
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_write_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_write_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr, 100663403);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr, 100663404);
				}

				// Token: 0x06003544 RID: 13636 RVA: 0x000DD270 File Offset: 0x000DB470
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 426933, RefRangeEnd = 426938, XrefRangeStart = 426933, XrefRangeEnd = 426938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_write_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003545 RID: 13637 RVA: 0x000DD2CC File Offset: 0x000DB4CC
				[CallerCount(0)]
				public unsafe IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06003546 RID: 13638 RVA: 0x0001A2B0 File Offset: 0x000184B0
				public unitytls_tlsctx_write_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002846 RID: 10310
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002847 RID: 10311
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003B5 RID: 949
			public sealed class unitytls_tlsctx_notify_close_t : MulticastDelegate
			{
				// Token: 0x06003547 RID: 13639 RVA: 0x0001A2B9 File Offset: 0x000184B9
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_notify_close_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_notify_close_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr, 100663405);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr, 100663406);
				}

				// Token: 0x06003548 RID: 13640 RVA: 0x000DD340 File Offset: 0x000DB540
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 408089, RefRangeEnd = 408094, XrefRangeStart = 408089, XrefRangeEnd = 408094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_notify_close_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003549 RID: 13641 RVA: 0x000DD39C File Offset: 0x000DB59C
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600354A RID: 13642 RVA: 0x0001A2F7 File Offset: 0x000184F7
				public unitytls_tlsctx_notify_close_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04002848 RID: 10312
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04002849 RID: 10313
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;
			}

			// Token: 0x020003B6 RID: 950
			public sealed class unitytls_tlsctx_free_t : MulticastDelegate
			{
				// Token: 0x0600354B RID: 13643 RVA: 0x0001A300 File Offset: 0x00018500
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_tlsctx_free_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_free_t");
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr, 100663407);
					UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr, 100663408);
				}

				// Token: 0x0600354C RID: 13644 RVA: 0x000DD3E8 File Offset: 0x000DB5E8
				[CallerCount(16)]
				[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_tlsctx_free_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600354D RID: 13645 RVA: 0x000DD444 File Offset: 0x000DB644
				[CallerCount(0)]
				public unsafe void Invoke(UnityTls.unitytls_tlsctx* ctx)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ctx;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600354E RID: 13646 RVA: 0x0001A33E File Offset: 0x0001853E
				public unitytls_tlsctx_free_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400284A RID: 10314
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400284B RID: 10315
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0;
			}

			// Token: 0x020003B7 RID: 951
			public sealed class unitytls_random_generate_bytes_t : MulticastDelegate
			{
				// Token: 0x0600354F RID: 13647 RVA: 0x0001A347 File Offset: 0x00018547
				// Note: this type is marked as 'beforefieldinit'.
				static unitytls_random_generate_bytes_t()
				{
					Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct>.NativeClassPtr, "unitytls_random_generate_bytes_t");
					UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr, 100663409);
					UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr, 100663410);
				}

				// Token: 0x06003550 RID: 13648 RVA: 0x000DD484 File Offset: 0x000DB684
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe unitytls_random_generate_bytes_t(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003551 RID: 13649 RVA: 0x000DD4E0 File Offset: 0x000DB6E0
				[CallerCount(0)]
				public unsafe void Invoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = buffer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = errorState;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003552 RID: 13650 RVA: 0x0001A385 File Offset: 0x00018585
				public unitytls_random_generate_bytes_t(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400284C RID: 10316
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400284D RID: 10317
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;
			}
		}
	}
}
