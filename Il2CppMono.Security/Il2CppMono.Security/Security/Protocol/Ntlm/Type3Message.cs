using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x0200001F RID: 31
	public class Type3Message : MessageBase
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x0000BB88 File Offset: 0x00009D88
		// Note: this type is marked as 'beforefieldinit'.
		static Type3Message()
		{
			Il2CppClassPointerStore<Type3Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "Type3Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Type3Message>.NativeClassPtr);
			Type3Message.NativeFieldInfoPtr__level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_level");
			Type3Message.NativeFieldInfoPtr__challenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_challenge");
			Type3Message.NativeFieldInfoPtr__host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_host");
			Type3Message.NativeFieldInfoPtr__domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_domain");
			Type3Message.NativeFieldInfoPtr__username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_username");
			Type3Message.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_password");
			Type3Message.NativeFieldInfoPtr__type2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_type2");
			Type3Message.NativeFieldInfoPtr__lm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_lm");
			Type3Message.NativeFieldInfoPtr__nt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, "_nt");
			Type3Message.NativeMethodInfoPtr__ctor_Public_Void_Type2Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663606);
			Type3Message.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663607);
			Type3Message.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663608);
			Type3Message.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663609);
			Type3Message.NativeMethodInfoPtr_set_Username_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663610);
			Type3Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663611);
			Type3Message.NativeMethodInfoPtr_DecodeString_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663612);
			Type3Message.NativeMethodInfoPtr_EncodeString_Private_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663613);
			Type3Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type3Message>.NativeClassPtr, 100663614);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000BD20 File Offset: 0x00009F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149243, RefRangeEnd = 1149244, XrefRangeStart = 1149206, XrefRangeEnd = 1149243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type3Message(Type2Message type2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Type3Message>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr__ctor_Public_Void_Type2Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000BD6C File Offset: 0x00009F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149244, XrefRangeEnd = 1149250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type3Message.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B6 RID: 182
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		public unsafe string Domain
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1149254, RefRangeEnd = 1149255, XrefRangeStart = 1149250, XrefRangeEnd = 1149254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000BDEC File Offset: 0x00009FEC
		public unsafe string Password
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0000BE30 File Offset: 0x0000A030
		public unsafe string Username
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr_set_Username_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000BE74 File Offset: 0x0000A074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149255, XrefRangeEnd = 1149291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Decode(Il2CppStructArray<byte> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type3Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149291, XrefRangeEnd = 1149295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DecodeString(Il2CppStructArray<byte> buffer, int offset, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr_DecodeString_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000BF28 File Offset: 0x0000A128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149295, XrefRangeEnd = 1149302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> EncodeString(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type3Message.NativeMethodInfoPtr_EncodeString_Private_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000BF78 File Offset: 0x0000A178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149302, XrefRangeEnd = 1149349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type3Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002CC0 File Offset: 0x00000EC0
		public Type3Message(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002CC9 File Offset: 0x00000EC9
		public unsafe NtlmAuthLevel _level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__level)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public unsafe Il2CppStructArray<byte> _challenge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__challenge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__challenge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000C01C File Offset: 0x0000A21C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002D03 File Offset: 0x00000F03
		public unsafe string _host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000C044 File Offset: 0x0000A244
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002D22 File Offset: 0x00000F22
		public unsafe string _domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000C06C File Offset: 0x0000A26C
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002D41 File Offset: 0x00000F41
		public unsafe string _username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000C094 File Offset: 0x0000A294
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002D60 File Offset: 0x00000F60
		public unsafe string _password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002D7F File Offset: 0x00000F7F
		public unsafe Type2Message _type2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__type2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type2Message>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__type2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002D9E File Offset: 0x00000F9E
		public unsafe Il2CppStructArray<byte> _lm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__lm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__lm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000C11C File Offset: 0x0000A31C
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002DBD File Offset: 0x00000FBD
		public unsafe Il2CppStructArray<byte> _nt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__nt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type3Message.NativeFieldInfoPtr__nt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr__level;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr__challenge;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr__host;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr__domain;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr__username;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr__password;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr__type2;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr__lm;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr__nt;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type2Message_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_String_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_set_Username_Public_set_Void_String_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_DecodeString_Private_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_EncodeString_Private_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0;
	}
}
