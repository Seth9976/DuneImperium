using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200022D RID: 557
	public class Rfc2898DeriveBytes : DeriveBytes
	{
		// Token: 0x060024D4 RID: 9428 RVA: 0x000CC698 File Offset: 0x000CA898
		// Note: this type is marked as 'beforefieldinit'.
		static Rfc2898DeriveBytes()
		{
			Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Rfc2898DeriveBytes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr);
			Rfc2898DeriveBytes.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, "_password");
			Rfc2898DeriveBytes.NativeFieldInfoPtr__salt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, "_salt");
			Rfc2898DeriveBytes.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, "_iterations");
			Rfc2898DeriveBytes.NativeFieldInfoPtr__hmac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, "_hmac");
			Rfc2898DeriveBytes.NativeFieldInfoPtr__blockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, "_blockSize");
			Rfc2898DeriveBytes.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, "_buffer");
			Rfc2898DeriveBytes.NativeFieldInfoPtr__block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, "_block");
			Rfc2898DeriveBytes.NativeFieldInfoPtr__startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, "_startIndex");
			Rfc2898DeriveBytes.NativeFieldInfoPtr__endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, "_endIndex");
			Rfc2898DeriveBytes.NativeFieldInfoPtr__HashAlgorithm_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, "<HashAlgorithm>k__BackingField");
			Rfc2898DeriveBytes.NativeMethodInfoPtr_get_HashAlgorithm_Public_get_HashAlgorithmName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, 100669480);
			Rfc2898DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, 100669481);
			Rfc2898DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_HashAlgorithmName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, 100669482);
			Rfc2898DeriveBytes.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, 100669483);
			Rfc2898DeriveBytes.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, 100669484);
			Rfc2898DeriveBytes.NativeMethodInfoPtr_OpenHmac_Private_HMAC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, 100669485);
			Rfc2898DeriveBytes.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, 100669486);
			Rfc2898DeriveBytes.NativeMethodInfoPtr_Func_Private_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr, 100669487);
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060024D5 RID: 9429 RVA: 0x000CC830 File Offset: 0x000CAA30
		public unsafe HashAlgorithmName HashAlgorithm
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rfc2898DeriveBytes.NativeMethodInfoPtr_get_HashAlgorithm_Public_get_HashAlgorithmName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new HashAlgorithmName(intPtr);
			}
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000CC868 File Offset: 0x000CAA68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1370603, RefRangeEnd = 1370606, XrefRangeStart = 1370601, XrefRangeEnd = 1370603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rfc2898DeriveBytes(Il2CppStructArray<byte> password, Il2CppStructArray<byte> salt, int iterations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rfc2898DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x000CC8D4 File Offset: 0x000CAAD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370619, RefRangeEnd = 1370620, XrefRangeStart = 1370606, XrefRangeEnd = 1370619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rfc2898DeriveBytes(Il2CppStructArray<byte> password, Il2CppStructArray<byte> salt, int iterations, HashAlgorithmName hashAlgorithm)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rfc2898DeriveBytes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterations;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hashAlgorithm));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rfc2898DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_HashAlgorithmName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000CC958 File Offset: 0x000CAB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370620, XrefRangeEnd = 1370626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rfc2898DeriveBytes.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000CC9A4 File Offset: 0x000CABA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370626, XrefRangeEnd = 1370630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetBytes(int cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Rfc2898DeriveBytes.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000CC9FC File Offset: 0x000CABFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370646, RefRangeEnd = 1370647, XrefRangeStart = 1370630, XrefRangeEnd = 1370646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HMAC OpenHmac()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rfc2898DeriveBytes.NativeMethodInfoPtr_OpenHmac_Private_HMAC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HMAC>(intPtr3) : null;
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000CCA3C File Offset: 0x000CAC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370647, XrefRangeEnd = 1370652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rfc2898DeriveBytes.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000CCA70 File Offset: 0x000CAC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1370652, XrefRangeEnd = 1370688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Func()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rfc2898DeriveBytes.NativeMethodInfoPtr_Func_Private_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x0000BDBD File Offset: 0x00009FBD
		public Rfc2898DeriveBytes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x000CCAB0 File Offset: 0x000CACB0
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x0000BDC6 File Offset: 0x00009FC6
		public unsafe Il2CppStructArray<byte> _password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__password);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__password), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x000CCAE0 File Offset: 0x000CACE0
		// (set) Token: 0x060024E1 RID: 9441 RVA: 0x0000BDE5 File Offset: 0x00009FE5
		public unsafe Il2CppStructArray<byte> _salt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__salt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__salt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x000CCB10 File Offset: 0x000CAD10
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x0000BE04 File Offset: 0x0000A004
		public unsafe uint _iterations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__iterations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__iterations)) = value;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x000CCB38 File Offset: 0x000CAD38
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x0000BE1F File Offset: 0x0000A01F
		public unsafe HMAC _hmac
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__hmac);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HMAC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__hmac), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000CCB68 File Offset: 0x000CAD68
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x0000BE3E File Offset: 0x0000A03E
		public unsafe int _blockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__blockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__blockSize)) = value;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000CCB90 File Offset: 0x000CAD90
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x0000BE59 File Offset: 0x0000A059
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x000CCBC0 File Offset: 0x000CADC0
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x0000BE78 File Offset: 0x0000A078
		public unsafe uint _block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__block);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__block)) = value;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000CCBE8 File Offset: 0x000CADE8
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x0000BE93 File Offset: 0x0000A093
		public unsafe int _startIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__startIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__startIndex)) = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000CCC10 File Offset: 0x000CAE10
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x0000BEAE File Offset: 0x0000A0AE
		public unsafe int _endIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__endIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__endIndex)) = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x000CCC38 File Offset: 0x000CAE38
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x0000BEC9 File Offset: 0x0000A0C9
		public HashAlgorithmName _HashAlgorithm_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__HashAlgorithm_k__BackingField);
				return new HashAlgorithmName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rfc2898DeriveBytes.NativeFieldInfoPtr__HashAlgorithm_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HashAlgorithmName>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeFieldInfoPtr__password;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeFieldInfoPtr__salt;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeFieldInfoPtr__iterations;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeFieldInfoPtr__hmac;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeFieldInfoPtr__blockSize;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeFieldInfoPtr__block;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeFieldInfoPtr__startIndex;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeFieldInfoPtr__endIndex;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeFieldInfoPtr__HashAlgorithm_k__BackingField;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeMethodInfoPtr_get_HashAlgorithm_Public_get_HashAlgorithmName_0;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_HashAlgorithmName_0;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeMethodInfoPtr_OpenHmac_Private_HMAC_0;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr_Func_Private_Il2CppStructArray_1_Byte_0;
	}
}
