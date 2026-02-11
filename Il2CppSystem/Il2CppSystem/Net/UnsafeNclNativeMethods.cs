using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security;

namespace Il2CppSystem.Net
{
	// Token: 0x020001E7 RID: 487
	public static class UnsafeNclNativeMethods : Object
	{
		// Token: 0x06001E76 RID: 7798 RVA: 0x0000CF24 File Offset: 0x0000B124
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeNclNativeMethods()
		{
			Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "UnsafeNclNativeMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr);
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x0000CF49 File Offset: 0x0000B149
		public UnsafeNclNativeMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0200032F RID: 815
		public static class HttpApi : Object
		{
			// Token: 0x06002F4D RID: 12109 RVA: 0x0001530C File Offset: 0x0001350C
			// Note: this type is marked as 'beforefieldinit'.
			static HttpApi()
			{
				Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr, "HttpApi");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr);
				UnsafeNclNativeMethods.HttpApi.NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr, "m_Strings");
			}

			// Token: 0x06002F4E RID: 12110 RVA: 0x00015340 File Offset: 0x00013540
			public HttpApi(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EC9 RID: 3785
			// (get) Token: 0x06002F4F RID: 12111 RVA: 0x000CE404 File Offset: 0x000CC604
			// (set) Token: 0x06002F50 RID: 12112 RVA: 0x00015349 File Offset: 0x00013549
			public unsafe static Il2CppStringArray m_Strings
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnsafeNclNativeMethods.HttpApi.NativeFieldInfoPtr_m_Strings, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnsafeNclNativeMethods.HttpApi.NativeFieldInfoPtr_m_Strings, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002513 RID: 9491
			private static readonly IntPtr NativeFieldInfoPtr_m_Strings;

			// Token: 0x020003C4 RID: 964
			public static class HTTP_REQUEST_HEADER_ID : Object
			{
				// Token: 0x060035E0 RID: 13792 RVA: 0x000DF7EC File Offset: 0x000DD9EC
				// Note: this type is marked as 'beforefieldinit'.
				static HTTP_REQUEST_HEADER_ID()
				{
					Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi>.NativeClassPtr, "HTTP_REQUEST_HEADER_ID");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr);
					UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr, "m_Strings");
					UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID>.NativeClassPtr, 100667935);
				}

				// Token: 0x060035E1 RID: 13793 RVA: 0x000DF840 File Offset: 0x000DDA40
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 478493, RefRangeEnd = 478494, XrefRangeStart = 478489, XrefRangeEnd = 478493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string ToString(int position)
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref position;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060035E2 RID: 13794 RVA: 0x0001A704 File Offset: 0x00018904
				public HTTP_REQUEST_HEADER_ID(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010D3 RID: 4307
				// (get) Token: 0x060035E3 RID: 13795 RVA: 0x000DF878 File Offset: 0x000DDA78
				// (set) Token: 0x060035E4 RID: 13796 RVA: 0x0001A70D File Offset: 0x0001890D
				public unsafe static Il2CppStringArray m_Strings
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeFieldInfoPtr_m_Strings, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.NativeFieldInfoPtr_m_Strings, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040028AF RID: 10415
				private static readonly IntPtr NativeFieldInfoPtr_m_Strings;

				// Token: 0x040028B0 RID: 10416
				private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0;
			}
		}

		// Token: 0x02000330 RID: 816
		public static class SecureStringHelper : Object
		{
			// Token: 0x06002F51 RID: 12113 RVA: 0x000CE42C File Offset: 0x000CC62C
			// Note: this type is marked as 'beforefieldinit'.
			static SecureStringHelper()
			{
				Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr, "SecureStringHelper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr);
				UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr, 100667937);
				UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNclNativeMethods.SecureStringHelper>.NativeClassPtr, 100667938);
			}

			// Token: 0x06002F52 RID: 12114 RVA: 0x000CE480 File Offset: 0x000CC680
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 478507, RefRangeEnd = 478509, XrefRangeStart = 478494, XrefRangeEnd = 478507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string CreateString(SecureString secureString)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(secureString);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002F53 RID: 12115 RVA: 0x000CE4BC File Offset: 0x000CC6BC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 478514, RefRangeEnd = 478517, XrefRangeStart = 478509, XrefRangeEnd = 478514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static SecureString CreateSecureString(string plainString)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(plainString);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNclNativeMethods.SecureStringHelper.NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecureString>(intPtr3) : null;
				}
			}

			// Token: 0x06002F54 RID: 12116 RVA: 0x0001535B File Offset: 0x0001355B
			public SecureStringHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002514 RID: 9492
			private static readonly IntPtr NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0;

			// Token: 0x04002515 RID: 9493
			private static readonly IntPtr NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0;
		}
	}
}
