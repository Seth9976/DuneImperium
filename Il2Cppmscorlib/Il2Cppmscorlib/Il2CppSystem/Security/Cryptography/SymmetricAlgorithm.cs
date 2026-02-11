using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200026C RID: 620
	public class SymmetricAlgorithm : Object
	{
		// Token: 0x060027DA RID: 10202 RVA: 0x000D7C04 File Offset: 0x000D5E04
		// Note: this type is marked as 'beforefieldinit'.
		static SymmetricAlgorithm()
		{
			Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SymmetricAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr);
			SymmetricAlgorithm.NativeFieldInfoPtr_BlockSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "BlockSizeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_FeedbackSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "FeedbackSizeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_IVValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "IVValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_KeyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "KeyValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_LegalBlockSizesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "LegalBlockSizesValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "LegalKeySizesValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "KeySizeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_ModeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "ModeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_PaddingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "PaddingValue");
			SymmetricAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669861);
			SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669862);
			SymmetricAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669863);
			SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669864);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_BlockSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669865);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_BlockSize_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669866);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669867);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_IV_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669868);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_IV_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669869);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669870);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669871);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_LegalKeySizes_Public_Virtual_New_get_Il2CppReferenceArray_1_KeySizes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669872);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669873);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669874);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_Mode_Public_Virtual_New_get_CipherMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669875);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_Mode_Public_Virtual_New_set_Void_CipherMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669876);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_Padding_Public_Virtual_New_get_PaddingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669877);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_Padding_Public_Virtual_New_set_Void_PaddingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669878);
			SymmetricAlgorithm.NativeMethodInfoPtr_ValidKeySize_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669879);
			SymmetricAlgorithm.NativeMethodInfoPtr_Create_Public_Static_SymmetricAlgorithm_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669880);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_New_ICryptoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669881);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669882);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_New_ICryptoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669883);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669884);
			SymmetricAlgorithm.NativeMethodInfoPtr_GenerateKey_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669885);
			SymmetricAlgorithm.NativeMethodInfoPtr_GenerateIV_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100669886);
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x000D7EF0 File Offset: 0x000D60F0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1373839, RefRangeEnd = 1373850, XrefRangeStart = 1373838, XrefRangeEnd = 1373839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymmetricAlgorithm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x000D7F2C File Offset: 0x000D612C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373850, XrefRangeEnd = 1373854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x000D7F60 File Offset: 0x000D6160
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1373857, RefRangeEnd = 1373862, XrefRangeStart = 1373854, XrefRangeEnd = 1373857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x000D7F94 File Offset: 0x000D6194
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1373866, RefRangeEnd = 1373869, XrefRangeStart = 1373862, XrefRangeEnd = 1373866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x000D7FE0 File Offset: 0x000D61E0
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x000D8028 File Offset: 0x000D6228
		public unsafe virtual int BlockSize
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_BlockSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373869, XrefRangeEnd = 1373873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_BlockSize_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x000D8074 File Offset: 0x000D6274
		public unsafe virtual int FeedbackSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x000D80BC File Offset: 0x000D62BC
		// (set) Token: 0x060027E3 RID: 10211 RVA: 0x000D8108 File Offset: 0x000D6308
		public unsafe virtual Il2CppStructArray<byte> IV
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1373876, RefRangeEnd = 1373877, XrefRangeStart = 1373873, XrefRangeEnd = 1373876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_IV_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1373900, RefRangeEnd = 1373901, XrefRangeStart = 1373877, XrefRangeEnd = 1373900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_IV_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x000D8158 File Offset: 0x000D6358
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x000D81A4 File Offset: 0x000D63A4
		public unsafe virtual Il2CppStructArray<byte> Key
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1373904, RefRangeEnd = 1373905, XrefRangeStart = 1373901, XrefRangeEnd = 1373904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1373914, RefRangeEnd = 1373915, XrefRangeStart = 1373905, XrefRangeEnd = 1373914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x000D81F4 File Offset: 0x000D63F4
		public unsafe virtual Il2CppReferenceArray<KeySizes> LegalKeySizes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373915, XrefRangeEnd = 1373918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_LegalKeySizes_Public_Virtual_New_get_Il2CppReferenceArray_1_KeySizes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr3) : null;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x000D8240 File Offset: 0x000D6440
		// (set) Token: 0x060027E8 RID: 10216 RVA: 0x000D8288 File Offset: 0x000D6488
		public unsafe virtual int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1373927, RefRangeEnd = 1373929, XrefRangeStart = 1373918, XrefRangeEnd = 1373927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x000D82D4 File Offset: 0x000D64D4
		// (set) Token: 0x060027EA RID: 10218 RVA: 0x000D831C File Offset: 0x000D651C
		public unsafe virtual CipherMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_Mode_Public_Virtual_New_get_CipherMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1373929, RefRangeEnd = 1373930, XrefRangeStart = 1373929, XrefRangeEnd = 1373929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_Mode_Public_Virtual_New_set_Void_CipherMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x000D8368 File Offset: 0x000D6568
		// (set) Token: 0x060027EC RID: 10220 RVA: 0x000D83B0 File Offset: 0x000D65B0
		public unsafe virtual PaddingMode Padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_Padding_Public_Virtual_New_get_PaddingMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1373930, RefRangeEnd = 1373931, XrefRangeStart = 1373930, XrefRangeEnd = 1373930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_Padding_Public_Virtual_New_set_Void_PaddingMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x000D83FC File Offset: 0x000D65FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1373933, RefRangeEnd = 1373939, XrefRangeStart = 1373931, XrefRangeEnd = 1373933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidKeySize(int bitLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_ValidKeySize_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000D8448 File Offset: 0x000D6648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1373948, RefRangeEnd = 1373949, XrefRangeStart = 1373939, XrefRangeEnd = 1373948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SymmetricAlgorithm Create(string algName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_Create_Public_Static_SymmetricAlgorithm_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymmetricAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000D848C File Offset: 0x000D668C
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateEncryptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_New_ICryptoTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000D84D8 File Offset: 0x000D66D8
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateEncryptor(Il2CppStructArray<byte> rgbKey, Il2CppStructArray<byte> rgbIV)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000D8548 File Offset: 0x000D6748
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateDecryptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_New_ICryptoTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000D8594 File Offset: 0x000D6794
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateDecryptor(Il2CppStructArray<byte> rgbKey, Il2CppStructArray<byte> rgbIV)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000D8604 File Offset: 0x000D6804
		[CallerCount(0)]
		public unsafe virtual void GenerateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_GenerateKey_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x000D8640 File Offset: 0x000D6840
		[CallerCount(0)]
		public unsafe virtual void GenerateIV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_GenerateIV_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x0000D195 File Offset: 0x0000B395
		public SymmetricAlgorithm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x000D867C File Offset: 0x000D687C
		// (set) Token: 0x060027F7 RID: 10231 RVA: 0x0000D19E File Offset: 0x0000B39E
		public unsafe int BlockSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_BlockSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_BlockSizeValue)) = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x000D86A4 File Offset: 0x000D68A4
		// (set) Token: 0x060027F9 RID: 10233 RVA: 0x0000D1B9 File Offset: 0x0000B3B9
		public unsafe int FeedbackSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_FeedbackSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_FeedbackSizeValue)) = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x000D86CC File Offset: 0x000D68CC
		// (set) Token: 0x060027FB RID: 10235 RVA: 0x0000D1D4 File Offset: 0x0000B3D4
		public unsafe Il2CppStructArray<byte> IVValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_IVValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_IVValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x000D86FC File Offset: 0x000D68FC
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x0000D1F3 File Offset: 0x0000B3F3
		public unsafe Il2CppStructArray<byte> KeyValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeyValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x000D872C File Offset: 0x000D692C
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x0000D212 File Offset: 0x0000B412
		public unsafe Il2CppReferenceArray<KeySizes> LegalBlockSizesValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalBlockSizesValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalBlockSizesValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x000D875C File Offset: 0x000D695C
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x0000D231 File Offset: 0x0000B431
		public unsafe Il2CppReferenceArray<KeySizes> LegalKeySizesValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000D878C File Offset: 0x000D698C
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x0000D250 File Offset: 0x0000B450
		public unsafe int KeySizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue)) = value;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x000D87B4 File Offset: 0x000D69B4
		// (set) Token: 0x06002805 RID: 10245 RVA: 0x0000D26B File Offset: 0x0000B46B
		public unsafe CipherMode ModeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_ModeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_ModeValue)) = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x000D87DC File Offset: 0x000D69DC
		// (set) Token: 0x06002807 RID: 10247 RVA: 0x0000D286 File Offset: 0x0000B486
		public unsafe PaddingMode PaddingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_PaddingValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_PaddingValue)) = value;
			}
		}

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeFieldInfoPtr_BlockSizeValue;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeFieldInfoPtr_FeedbackSizeValue;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeFieldInfoPtr_IVValue;

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeFieldInfoPtr_KeyValue;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeFieldInfoPtr_LegalBlockSizesValue;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeFieldInfoPtr_LegalKeySizesValue;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeFieldInfoPtr_KeySizeValue;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeFieldInfoPtr_ModeValue;

		// Token: 0x0400223A RID: 8762
		private static readonly IntPtr NativeFieldInfoPtr_PaddingValue;

		// Token: 0x0400223B RID: 8763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400223C RID: 8764
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockSize_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeMethodInfoPtr_get_IV_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeMethodInfoPtr_set_IV_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeMethodInfoPtr_get_LegalKeySizes_Public_Virtual_New_get_Il2CppReferenceArray_1_KeySizes_0;

		// Token: 0x04002247 RID: 8775
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002248 RID: 8776
		private static readonly IntPtr NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04002249 RID: 8777
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_Virtual_New_get_CipherMode_0;

		// Token: 0x0400224A RID: 8778
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Public_Virtual_New_set_Void_CipherMode_0;

		// Token: 0x0400224B RID: 8779
		private static readonly IntPtr NativeMethodInfoPtr_get_Padding_Public_Virtual_New_get_PaddingMode_0;

		// Token: 0x0400224C RID: 8780
		private static readonly IntPtr NativeMethodInfoPtr_set_Padding_Public_Virtual_New_set_Void_PaddingMode_0;

		// Token: 0x0400224D RID: 8781
		private static readonly IntPtr NativeMethodInfoPtr_ValidKeySize_Public_Boolean_Int32_0;

		// Token: 0x0400224E RID: 8782
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SymmetricAlgorithm_String_0;

		// Token: 0x0400224F RID: 8783
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_New_ICryptoTransform_0;

		// Token: 0x04002250 RID: 8784
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002251 RID: 8785
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_New_ICryptoTransform_0;

		// Token: 0x04002252 RID: 8786
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002253 RID: 8787
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKey_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002254 RID: 8788
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIV_Public_Abstract_Virtual_New_Void_0;
	}
}
