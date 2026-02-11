using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000018 RID: 24
	public static class ChallengeResponse2 : Object
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x0000AC44 File Offset: 0x00008E44
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeResponse2()
		{
			Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "ChallengeResponse2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr);
			ChallengeResponse2.NativeFieldInfoPtr_magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, "magic");
			ChallengeResponse2.NativeFieldInfoPtr_nullEncMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, "nullEncMagic");
			ChallengeResponse2.NativeMethodInfoPtr_Compute_LM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663573);
			ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLM_Password_Private_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663574);
			ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663575);
			ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLMv2_Session_Private_Static_Void_String_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663576);
			ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLMv2_Private_Static_Il2CppStructArray_1_Byte_Type2Message_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663577);
			ChallengeResponse2.NativeMethodInfoPtr_Compute_Public_Static_Void_Type2Message_NtlmAuthLevel_String_String_String_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663578);
			ChallengeResponse2.NativeMethodInfoPtr_GetResponse_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663579);
			ChallengeResponse2.NativeMethodInfoPtr_PrepareDESKey_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663580);
			ChallengeResponse2.NativeMethodInfoPtr_PasswordToKey_Private_Static_Il2CppStructArray_1_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse2>.NativeClassPtr, 100663581);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000AD50 File Offset: 0x00008F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148877, XrefRangeEnd = 1148913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Compute_LM(string password, Il2CppStructArray<byte> challenge)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_LM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1148925, RefRangeEnd = 1148928, XrefRangeStart = 1148913, XrefRangeEnd = 1148925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Compute_NTLM_Password(string password)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLM_Password_Private_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000ADEC File Offset: 0x00008FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148928, XrefRangeEnd = 1148933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Compute_NTLM(string password, Il2CppStructArray<byte> challenge)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000AE44 File Offset: 0x00009044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1148964, RefRangeEnd = 1148965, XrefRangeStart = 1148933, XrefRangeEnd = 1148964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Compute_NTLMv2_Session(string password, Il2CppStructArray<byte> challenge, out Il2CppStructArray<byte> lm, out Il2CppStructArray<byte> ntlm)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLMv2_Session_Private_Static_Void_String_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			lm = ((intPtr5 == 0) ? null : new Il2CppStructArray<byte>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			ntlm = ((intPtr6 == 0) ? null : new Il2CppStructArray<byte>(intPtr6));
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000AED0 File Offset: 0x000090D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149022, RefRangeEnd = 1149023, XrefRangeStart = 1148965, XrefRangeEnd = 1149022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Compute_NTLMv2(Type2Message type2, string username, string password, string domain)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type2);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(domain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_NTLMv2_Private_Static_Il2CppStructArray_1_Byte_Type2Message_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000AF4C File Offset: 0x0000914C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1149038, RefRangeEnd = 1149039, XrefRangeStart = 1149023, XrefRangeEnd = 1149038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out Il2CppStructArray<byte> lm, out Il2CppStructArray<byte> ntlm)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type2);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(domain);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_Compute_Public_Static_Void_Type2Message_NtlmAuthLevel_String_String_String_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			lm = ((intPtr5 == 0) ? null : new Il2CppStructArray<byte>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			ntlm = ((intPtr6 == 0) ? null : new Il2CppStructArray<byte>(intPtr6));
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000B010 File Offset: 0x00009210
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1149059, RefRangeEnd = 1149062, XrefRangeStart = 1149039, XrefRangeEnd = 1149059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetResponse(Il2CppStructArray<byte> challenge, Il2CppStructArray<byte> pwd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pwd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_GetResponse_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000B068 File Offset: 0x00009268
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1149065, RefRangeEnd = 1149069, XrefRangeStart = 1149062, XrefRangeEnd = 1149065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PrepareDESKey(Il2CppStructArray<byte> key56bits, int position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key56bits);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_PrepareDESKey_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000B0BC File Offset: 0x000092BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1149087, RefRangeEnd = 1149089, XrefRangeStart = 1149069, XrefRangeEnd = 1149087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PasswordToKey(string password, int position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse2.NativeMethodInfoPtr_PasswordToKey_Private_Static_Il2CppStructArray_1_Byte_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002B7E File Offset: 0x00000D7E
		public ChallengeResponse2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000B110 File Offset: 0x00009310
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002B87 File Offset: 0x00000D87
		public unsafe static Il2CppStructArray<byte> magic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChallengeResponse2.NativeFieldInfoPtr_magic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChallengeResponse2.NativeFieldInfoPtr_magic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000B138 File Offset: 0x00009338
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002B99 File Offset: 0x00000D99
		public unsafe static Il2CppStructArray<byte> nullEncMagic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChallengeResponse2.NativeFieldInfoPtr_nullEncMagic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChallengeResponse2.NativeFieldInfoPtr_nullEncMagic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr_magic;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_nullEncMagic;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_Compute_LM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_Compute_NTLM_Password_Private_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_Compute_NTLM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_Compute_NTLMv2_Session_Private_Static_Void_String_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_Compute_NTLMv2_Private_Static_Il2CppStructArray_1_Byte_Type2Message_String_String_String_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_Compute_Public_Static_Void_Type2Message_NtlmAuthLevel_String_String_String_byref_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDESKey_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_PasswordToKey_Private_Static_Il2CppStructArray_1_Byte_String_Int32_0;
	}
}
