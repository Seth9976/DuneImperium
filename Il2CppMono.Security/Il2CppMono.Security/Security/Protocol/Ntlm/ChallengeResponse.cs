using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000017 RID: 23
	public class ChallengeResponse : Object
	{
		// Token: 0x0600019B RID: 411 RVA: 0x0000A640 File Offset: 0x00008840
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeResponse()
		{
			Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "ChallengeResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr);
			ChallengeResponse.NativeFieldInfoPtr_magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "magic");
			ChallengeResponse.NativeFieldInfoPtr_nullEncMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "nullEncMagic");
			ChallengeResponse.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "_disposed");
			ChallengeResponse.NativeFieldInfoPtr__challenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "_challenge");
			ChallengeResponse.NativeFieldInfoPtr__lmpwd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "_lmpwd");
			ChallengeResponse.NativeFieldInfoPtr__ntpwd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, "_ntpwd");
			ChallengeResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663560);
			ChallengeResponse.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663561);
			ChallengeResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663562);
			ChallengeResponse.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663563);
			ChallengeResponse.NativeMethodInfoPtr_set_Challenge_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663564);
			ChallengeResponse.NativeMethodInfoPtr_get_LM_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663565);
			ChallengeResponse.NativeMethodInfoPtr_get_NT_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663566);
			ChallengeResponse.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663567);
			ChallengeResponse.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663568);
			ChallengeResponse.NativeMethodInfoPtr_GetResponse_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663569);
			ChallengeResponse.NativeMethodInfoPtr_PrepareDESKey_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663570);
			ChallengeResponse.NativeMethodInfoPtr_PasswordToKey_Private_Il2CppStructArray_1_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr, 100663571);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000A7D8 File Offset: 0x000089D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148688, XrefRangeEnd = 1148696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000A814 File Offset: 0x00008A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1148727, RefRangeEnd = 1148728, XrefRangeStart = 1148696, XrefRangeEnd = 1148727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeResponse(string password, Il2CppStructArray<byte> challenge)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(challenge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000A874 File Offset: 0x00008A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148728, XrefRangeEnd = 1148738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChallengeResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000096 RID: 150
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0000A8B0 File Offset: 0x00008AB0
		public unsafe string Password
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1148784, RefRangeEnd = 1148785, XrefRangeStart = 1148738, XrefRangeEnd = 1148784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		public unsafe Il2CppStructArray<byte> Challenge
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148785, XrefRangeEnd = 1148807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_set_Challenge_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000A938 File Offset: 0x00008B38
		public unsafe Il2CppStructArray<byte> LM
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1148814, RefRangeEnd = 1148815, XrefRangeStart = 1148807, XrefRangeEnd = 1148814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_get_LM_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000A978 File Offset: 0x00008B78
		public unsafe Il2CppStructArray<byte> NT
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1148822, RefRangeEnd = 1148823, XrefRangeStart = 1148815, XrefRangeEnd = 1148822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_get_NT_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000A9B8 File Offset: 0x00008BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148823, XrefRangeEnd = 1148831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000A9EC File Offset: 0x00008BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148831, XrefRangeEnd = 1148834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000AA2C File Offset: 0x00008C2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1148851, RefRangeEnd = 1148853, XrefRangeStart = 1148834, XrefRangeEnd = 1148851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetResponse(Il2CppStructArray<byte> pwd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pwd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_GetResponse_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000AA7C File Offset: 0x00008C7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1148856, RefRangeEnd = 1148860, XrefRangeStart = 1148853, XrefRangeEnd = 1148856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> PrepareDESKey(Il2CppStructArray<byte> key56bits, int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key56bits);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_PrepareDESKey_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000AADC File Offset: 0x00008CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1148875, RefRangeEnd = 1148877, XrefRangeStart = 1148860, XrefRangeEnd = 1148875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> PasswordToKey(string password, int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeResponse.NativeMethodInfoPtr_PasswordToKey_Private_Il2CppStructArray_1_Byte_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002AD9 File Offset: 0x00000CD9
		public ChallengeResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000AB3C File Offset: 0x00008D3C
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002AE2 File Offset: 0x00000CE2
		public unsafe static Il2CppStructArray<byte> magic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChallengeResponse.NativeFieldInfoPtr_magic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChallengeResponse.NativeFieldInfoPtr_magic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000AB64 File Offset: 0x00008D64
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002AF4 File Offset: 0x00000CF4
		public unsafe static Il2CppStructArray<byte> nullEncMagic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChallengeResponse.NativeFieldInfoPtr_nullEncMagic, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChallengeResponse.NativeFieldInfoPtr_nullEncMagic, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000AB8C File Offset: 0x00008D8C
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002B06 File Offset: 0x00000D06
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000ABB4 File Offset: 0x00008DB4
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002B21 File Offset: 0x00000D21
		public unsafe Il2CppStructArray<byte> _challenge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__challenge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__challenge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002B40 File Offset: 0x00000D40
		public unsafe Il2CppStructArray<byte> _lmpwd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__lmpwd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__lmpwd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000AC14 File Offset: 0x00008E14
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002B5F File Offset: 0x00000D5F
		public unsafe Il2CppStructArray<byte> _ntpwd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__ntpwd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeResponse.NativeFieldInfoPtr__ntpwd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeFieldInfoPtr_magic;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_nullEncMagic;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr__challenge;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr__lmpwd;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr__ntpwd;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_String_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_set_Challenge_Public_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_get_LM_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_NT_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDESKey_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_PasswordToKey_Private_Il2CppStructArray_1_Byte_String_Int32_0;
	}
}
